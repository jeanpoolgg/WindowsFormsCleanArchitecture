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
    public partial class FormNewEditBrand : Form
    {
        private int _id = 0;
        private readonly AddBrand _addBrand;

        public FormNewEditBrand(AddBrand addBrand)
        {
            InitializeComponent();
            _addBrand = addBrand;
        }


        private void FormNewEditBrand_Load(object sender, EventArgs e)
        {

        }

        public void setInfo(Brand brand)
        {
            _id = brand.Id;
            Text = "Editar Marca";
            txtName.Text = brand.Name;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_id == 0)
                {
                    await Add();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task Add()
        {
            string name = txtName.Text.Trim();

            await _addBrand.ExecuteAsync(new Brand
            {
                Name = name
            });

            this.Close();
        }
    }
}
