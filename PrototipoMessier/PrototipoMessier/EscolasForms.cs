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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            grdEscolas.Rows.Add(txtCnpj.Text, txtInstituicao.Text, chkPacote.Text, txtIP.Text);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCnpj.Text = "";
            txtInstituicao.Text = "";
            txtIP.Text = "";
            for (int i = 0; i < chkPacote.Items.Count; i++)
            {
                chkPacote.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
