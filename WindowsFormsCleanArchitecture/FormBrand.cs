using ApplicationBusiness;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCleanArchitecture
{
    public partial class FormBrand : Form
    {
        private IRepository<Brand> _repositoryBrand;
        public FormBrand(IRepository<Brand> repositoryBrand)
        {
            InitializeComponent();
            _repositoryBrand = repositoryBrand;
        }

        private async Task Refresh()
        {
            var brands = await _repositoryBrand.GetAllAsync();
            dgv.DataSource = brands.ToList();
        }

        private async void FormBrand_Load(object sender, EventArgs e)
        {
            await Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
