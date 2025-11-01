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
    public partial class FormNewEditBeer : Form
    {
        private readonly IRepository<Brand> _brandRepository;
        public FormNewEditBeer(IRepository<Brand> repository)
        {
            InitializeComponent();
            _brandRepository = repository;
        }

        private void FormNewEditBeer_Load(object sender, EventArgs e)
        {
            ChargeData();
        }

        private async Task ChargeData()
        {
            cboBrand.DataSource = await _brandRepository.GetAllAsync();
            cboBrand.DisplayMember = "Name";
            cboBrand.ValueMember = "Id";
            if (cboBrand.Items.Count > 0)
            {
                cboBrand.SelectedIndex = 0;
            }
        }
    }
}
