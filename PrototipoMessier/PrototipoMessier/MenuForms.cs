namespace PrototipoMessier
{
    public partial class Form1 : Form
    {
        JogosForms frmJogos;
        PacoteForms frmPacotes;
        HelpForms frmHelp;
        RelEscolaForms frmRelEscola;
        EscolasForms frmEscolas;

        public Form1()
        {
            InitializeComponent();
            frmJogos = new JogosForms();
            frmPacotes = new PacoteForms();
            frmHelp = new HelpForms();
            frmRelEscola = new RelEscolaForms();
            frmEscolas = new EscolasForms();
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJogos.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPacotes_Click(object sender, EventArgs e)
        {
            frmPacotes.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp.ShowDialog();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void escolasToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            frmRelEscola.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            frmJogos.ShowDialog();
        }

        private void btnEscolas_Click(object sender, EventArgs e)
        {
            frmEscolas.ShowDialog();
        }
    }
}
