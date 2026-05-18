using PrototipoMessier.Escola;
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
    public partial class LoginEscola : Form
    {
        public LoginEscola()
        {
            InitializeComponent();
        }

        private void btnLoginEscola_Click(object sender, EventArgs e)
        {
            string cnpj     = txtCnpjEscola.Text.Trim().Replace(".", "").Replace("-", "");
            string senha    = txtSenEscola.Text.Trim();
            string ipOrigem = txtIPEscola.Text.Trim();

            Escolas? escola = DadosSistema.GetEscolaPorCNPJ(cnpj);
            if (escola == null)
            {
                MessageBox.Show("Escola não encontrada. Verifique o CNPJ informado.",
                    "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (escola.Senha != senha)
            {
                MessageBox.Show("Senha incorreta.",
                    "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (escola.PacoteId == null)
            {
                MessageBox.Show("Esta escola não possui pacote ativo.\nEntre em contato com a Messier Educacional.",
                    "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Pacote? pacote = DadosSistema.GetPacote(escola.PacoteId.Value);
            if (pacote == null)
            {
                MessageBox.Show("Pacote da escola não encontrado. Contate o suporte.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrWhiteSpace(ipOrigem))
            {
                MessageBox.Show("Informe o IP de origem da conexão.",
                    "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!escola.IPsAutorizados.Contains(ipOrigem))
            {
                MessageBox.Show($"IP '{ipOrigem}' não está autorizado para esta escola.\nContate o administrador do sistema.",
                    "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            LimparCampos();

            var catalogo = new CatalogoJogos();
            catalogo.ShowDialog();
        }

        private void LimparCampos()
        {
            txtCnpjEscola.Text = "";
            txtSenEscola.Text  = "";
            txtIPEscola.Text   = "";
        }
    }
}
