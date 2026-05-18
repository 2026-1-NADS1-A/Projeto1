namespace PrototipoMessier
{
    public partial class Form1 : Form
    {
        JogosForms      frmJogos;
        PacoteForms     frmPacotes;
        HelpForms       frmHelp;
        RelEscolasForms frmRelEscola;
        EscolasForms    frmEscolas;

        public Form1()
        {
            InitializeComponent();
            frmJogos     = new JogosForms();
            frmPacotes   = new PacoteForms();
            frmHelp      = new HelpForms();
            frmRelEscola = new RelEscolasForms();
            frmEscolas   = new EscolasForms();
        }

        // Botões ------------------------------------------------------
        private void btnPacotes_Click(object sender, EventArgs e)
        {
            frmPacotes.ShowDialog();
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            frmJogos.ShowDialog();
        }

        private void btnEscolas_Click(object sender, EventArgs e)
        {
            frmEscolas.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            frmRelEscola.ShowDialog();
        }
    }
}
