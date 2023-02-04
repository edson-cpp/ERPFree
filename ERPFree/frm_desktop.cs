namespace ERPFree
{
    public partial class frmDesktop : Form
    {
        public frmDesktop()
        {
            InitializeComponent();
        }

        private void movimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniClients_Click(object sender, EventArgs e)
        {
            frmClients client = new frmClients();
            client.ShowDialog();
        }
    }
}