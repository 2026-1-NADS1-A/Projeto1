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
    public partial class RelEscolaForms : Form
    {
        public RelEscolaForms()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtRelatorio.Text = "| ESCOLA                    | PACOTE \n";
            for (int i = 1; i <= 10; i++)
            {
                txtRelatorio.Text += "| ESCOLA     " + 1 + "         |" + 1 + "\r\n";
            }
        }

        private void txtRelatorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void RelEscolaForms_Load(object sender, EventArgs e)
        {

        }
    }
}
