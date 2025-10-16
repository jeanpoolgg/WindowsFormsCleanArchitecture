namespace WindowsFormsCleanArchitecture
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormBrand();
            frm.ShowDialog();
            MessageBox.Show("Se ha cerrado");
        }
    }
}
