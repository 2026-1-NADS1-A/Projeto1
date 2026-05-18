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
    public partial class LoginAdmin : Form
    {
        // Credenciais do administrador ------------------------------

        private const string USUARIO_ADMIN = "admin";
        private const string SENHA_ADMIN = "admin123";

        public LoginAdmin()
        {
            InitializeComponent();
        }

        // Botão -----------------------------------------------------

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuAdmin.Text.Trim();
            string senha = txtSenAdmin.Text.Trim();

            if (usuario == USUARIO_ADMIN && senha == SENHA_ADMIN)
            {
                txtUsuAdmin.Text = "";
                txtSenAdmin.Text = "";

                var menu = new Form1();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.",
                    "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtSenAdmin.Text = "";
                txtSenAdmin.Focus();
            }
        }
    }
}
