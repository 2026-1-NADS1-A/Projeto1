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
    public partial class EscolasForms : Form
    {
        public EscolasForms()
        {
            InitializeComponent();
            this.Load += EscolasForms_Load;
        }

        // Eventos

        private void EscolasForms_Load(object sender, EventArgs e)
        {
            // Substitui os itens fixos do Designer pelos pacotes reais
            chkPacote.Items.Clear();

            foreach (var p in DadosSistema.Pacotes)
            {
                chkPacote.Items.Add(p.Nome);
            }

            CarregarGrid();
        }

        // Grid

        private void CarregarGrid()
        {
            grdEscolas.Rows.Clear();
            foreach (var escola in DadosSistema.Escolas)
            {
                string nomePacote = escola.PacoteId.HasValue
                      ? DadosSistema.GetPacote(escola.PacoteId.Value)?.Nome ?? "-"
                      : "-";
                string ips = string.Join(", ", escola.IPsAutorizados);
                grdEscolas.Rows.Add(escola.CNPJ, escola.Instituicao, nomePacote, ips);
            }
        }

        // Botões

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCnpj.Text) || string.IsNullOrWhiteSpace(txtInstituicao.Text))
            {
                MessageBox.Show("Preencha o CNPJ e o Nome da Instituição.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // Apenas 1 pacote pode estar marcado
            int? pacoteId = null;

            for (int i = 0; i < chkPacote.Items.Count; i++)
            {
                if (!chkPacote.GetItemChecked(i))
                {
                    continue;
                }

                string nomePac = chkPacote.Items[i]!.ToString()!;

                var pac = DadosSistema.Pacotes.FirstOrDefault(p => p.Nome == nomePac);

                if (pac != null) 
                { 
                    pacoteId = pac.Id; break; 
                }
            }

            // IPs: separados por vírgula no campo txtIP
            var ips = txtIP.Text
                           .Split(',')
                           .Select(ip => ip.Trim())
                           .Where(ip  => !string.IsNullOrEmpty(ip))
                           .ToList();

            string cnpjLimpo = txtCnpj.Text.Trim()
                                           .Replace(".", "")
                                           .Replace("/", "")
                                           .Replace("-", "");

            // Edição
            var existente = DadosSistema.Escolas.FirstOrDefault(e => e.CNPJ == cnpjLimpo);

            if (existente != null)
            {
                existente.Instituicao    = txtInstituicao.Text.Trim();
                existente.PacoteId       = pacoteId;
                existente.IPsAutorizados = ips;

                CarregarGrid();

                LimparFormulario();

                MessageBox.Show("Escola atualizada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            // Nova escola (senha padrão = 123456)
            var novaEscola = new Escolas
            {
                Id              = DadosSistema.ProximoIdEscola(),
                CNPJ            = cnpjLimpo,
                Instituicao     = txtInstituicao.Text.Trim(),
                Senha           = "123456",
                PacoteId        = pacoteId,
                IPsAutorizados  = ips,
            };

            DadosSistema.Escolas.Add(novaEscola);

            CarregarGrid();

            LimparFormulario();

            MessageBox.Show("Escola cadastrada!\nSenha padrão: 123456", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCnpj.Text        = "";
            txtInstituicao.Text = "";
            txtIP.Text          = "";

            for (int i = 0; i < chkPacote.Items.Count; i++)
            {
                chkPacote.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        // Helpers

        private void LimparFormulario()
        {
            txtCnpj.Text        = "";
            txtInstituicao.Text = "";
            txtIP.Text          = "";

            for (int i = 0; i < chkPacote.Items.Count; i++)
            {
                chkPacote.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
