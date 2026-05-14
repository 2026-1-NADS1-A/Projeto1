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

            checkedListBox1.ForeColor = System.Drawing.Color.White;

            PopulateJogosFromOpenForm();

            this.Activated += PacoteForms_Activated;
        }

        private void PacoteForms_Activated(object sender, EventArgs e)
        {
            PopulateJogosFromOpenForm();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            grdPacotes.Rows.Add(txtID.Text, txtNome.Text);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtID.Text = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              
        }

        private void PopulateJogosFromOpenForm()
        {
            checkedListBox1.Items.Clear();

            var jogosForm = Application.OpenForms.OfType<JogosForms>().FirstOrDefault();
            if (jogosForm == null) return;

            var grid = jogosForm.gridJogos;
            if (grid == null) return;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                var id = row.Cells["ID"]?.Value?.ToString()?.Trim() ?? "";
                var nome = row.Cells["Nome"]?.Value?.ToString()?.Trim() ?? "";

                if (string.IsNullOrEmpty(id) && string.IsNullOrEmpty(nome)) continue;

                checkedListBox1.Items.Add($"{id} - {nome}");
            }
        }
    }
}