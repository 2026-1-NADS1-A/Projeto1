using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMessier
{
    public partial class JogosForms : Form
    {
        public JogosForms()
        {
            InitializeComponent();
        }

        private void JogosForms_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        // Grid  --------------------------------------------

        private void CarregarGrid()
        {
            grdJogos.Rows.Clear();

            foreach (var jogo in DadosSistema.Jogos)
            {
                grdJogos.Rows.Add(jogo.Id.ToString(), jogo.Titulo, jogo.Descricao, jogo.Ativo);
            }
        }

        // Clique em linha do grid > preenche formulário para edição  --------------------------------------------

        public void grdJogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = grdJogos.Rows[e.RowIndex];

            txtIDJogo.Text         = row.Cells["ID"].Value?.ToString()         ?? "";
            txtTituloJogo.Text     = row.Cells["Nome"].Value?.ToString()       ?? "";
            txtDescricaoJogo.Text  = row.Cells["Descricao"].Value?.ToString()  ?? "";
            chkAtivoJogo.Checked   = row.Cells["Ativo"].Value is bool b && b;
        }

        // Helpers --------------------------------------------

        private void LimparFormulario()
        {
            txtIDJogo.Text         = "";
            txtTituloJogo.Text     = "";
            txtDescricaoJogo.Text  = "";
            chkAtivoJogo.Checked   = true;
        }

        // Botões  --------------------------------------------

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTituloJogo.Text))
            {
                MessageBox.Show("Informe o título do jogo.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Edição: ID preenchido e existe no modelo
            if (int.TryParse(txtIDJogo.Text.Trim(), out int idEdit))
            {
                var existente = DadosSistema.GetJogo(idEdit);

                if (existente != null)
                {
                    existente.Titulo = txtTituloJogo.Text.Trim();
                    existente.Descricao = txtDescricaoJogo.Text.Trim();
                    existente.Ativo = chkAtivoJogo.Checked;

                    CarregarGrid();
                    LimparFormulario();

                    MessageBox.Show("Jogo atualizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }

            // Novo Jogo

            var novoJogo = new Jogo
            {
                Id = DadosSistema.ProximoIdJogo(),
                Titulo = txtTituloJogo.Text.Trim(),
                Descricao = txtDescricaoJogo.Text.Trim(),
                Ativo = chkAtivoJogo.Checked,
            };

            DadosSistema.Jogos.Add(novoJogo);

            CarregarGrid();
            LimparFormulario();

            MessageBox.Show("Jogo cadastrado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Para permitir uso do grid em PacoteForms

        public DataGridView gridJogos => grdJogos;

    }
}
