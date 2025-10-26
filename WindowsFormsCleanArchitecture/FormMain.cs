using Microsoft.Extensions.DependencyInjection;

namespace WindowsFormsCleanArchitecture
{
    public partial class FormMain : Form
    {
        private readonly IServiceProvider _serviceProvide;

        public FormMain(IServiceProvider serviceProvide)
        {
            InitializeComponent();
            _serviceProvide = serviceProvide;
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // var frm = new FormBrand();
            var frm = _serviceProvide.GetRequiredService<FormBrand>();
            frm.ShowDialog();
            MessageBox.Show("Se ha cerrado");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
