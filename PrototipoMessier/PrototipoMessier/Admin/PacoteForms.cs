using System;
using System.Linq;
using System.Windows.Forms;

namespace PrototipoMessier
{
    public partial class PacoteForms : Form
    {
        public PacoteForms()
        {
            InitializeComponent();

            PopulateJogosFromOpenForm();

            this.Activated += PacoteForms_Activated;
        }

        // Eventos ------------------------------------------------------
        private void PacoteForms_Activated(object sender, EventArgs e)
        {
            PopulateJogosFromOpenForm();
        }

        private void PacoteForms_Load(object sender, EventArgs e)
        {
            PopularJogos();
            CarregarGrid();
        }

        // Grid ---------------------------------------------------------

        private void CarregarGrid()
        {
            grdPacotes.Rows.Clear();

            foreach (var p in DadosSistema.Pacotes)
            {
                grdPacotes.Rows.Add(p.Id.ToString(), p.Nome, p.LimiteMensal.ToString());
            }
        }

        private void PopularJogos()
        {
            var marcados = new System.Collections.Generic.HashSet<string>();

            for (int i = 0; i < chkPacote.Items.Count; i++)
            {
                if (chkPacote.GetItemChecked(i))
                    marcados.Add(chkPacote.Items[i]!.ToString()!);
            }

            chkPacote.Items.Clear();

            foreach (var jogo in DadosSistema.Jogos.Where(j => j.Ativo))
            {
                chkPacote.Items.Add($"{jogo.Id} - {jogo.Titulo}");
            }

            for (int i = 0; i < chkPacote.Items.Count; i++)
            {
                if (marcados.Contains(chkPacote.Items[i]!.ToString()!))
                {
                    chkPacote.SetItemChecked(i, true);
                }
            }
        }

        // Helpers

        private void LimparFormulario()
        {
            txtIDPacote.Text   = "";
            txtNomePacote.Text = "";
            nudLimite.Value    = 50;

            for (int i = 0; i < chkPacote.Items.Count; i++)
            {
                chkPacote.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        // Botões -------------------------------------------------------

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomePacote.Text))
            {
                MessageBox.Show("Informe o nome do pacote.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // Coleta ID dos jogos marcados

            var jogosIds = new System.Collections.Generic.List<int>();

            for (int i = 0; i < chkPacote.Items.Count; i++)
            {
                if (!chkPacote.GetItemChecked(i))
                {
                    continue;
                }

                string item = chkPacote.Items[i]!.ToString()!;

                if (int.TryParse(item.Split("-")[0].Trim(), out int jid))
                {
                    jogosIds.Add(jid);
                }
            }

            int limite = (int)nudLimite.Value;

            // Edição
            if (int.TryParse(txtIDPacote.Text.Trim(), out int idEdit))
            {
                var existente = DadosSistema.Pacotes.FirstOrDefault(p => p.Id == idEdit);

                if (existente != null)
                {
                    existente.Nome         = txtNomePacote.Text.Trim();
                    existente.JogosIds     = jogosIds;
                    existente.LimiteMensal = limite;

                    CarregarGrid();
                    LimparFormulario();

                    MessageBox.Show("Pacote atualizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }

            // Novo Pacote
            var novoPacote = new Pacote
            {
                Id           = DadosSistema.ProximoIdPacote(),
                Nome         = txtNomePacote.Text.Trim(),
                JogosIds     = jogosIds,
                LimiteMensal = limite,
            };

            DadosSistema.Pacotes.Add(novoPacote);

            CarregarGrid();
            LimparFormulario();

            MessageBox.Show("Pacote cadastrado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void PopulateJogosFromOpenForm()
        {
            chkPacote.Items.Clear();

            var jogosForm = Application.OpenForms.OfType<JogosForms>().FirstOrDefault();
            if (jogosForm == null) return;

            var grid = jogosForm.gridJogos;
            if (grid == null) return;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                var id   = row.Cells["ID"]?.Value?.ToString()?.Trim()   ?? "";
                var nome = row.Cells["Nome"]?.Value?.ToString()?.Trim() ?? "";

                if (string.IsNullOrEmpty(id) && string.IsNullOrEmpty(nome))
                {
                    continue;
                }

                chkPacote.Items.Add($"{id} - {nome}");
            }
        }
    }
}