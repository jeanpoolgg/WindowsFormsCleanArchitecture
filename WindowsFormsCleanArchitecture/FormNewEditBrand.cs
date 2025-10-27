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
        private readonly EditBrand _editBrand;

        public FormNewEditBrand(AddBrand addBrand, EditBrand editBrand)
        {
            InitializeComponent();
            _addBrand = addBrand;
            _editBrand = editBrand;
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
                    await Edit();
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

        private async Task Edit()
        {
            string name = txtName.Text.Trim();

            await _editBrand.ExecuteAsync(new Brand
            {
                Id = _id,
                Name = name
            });
 

            this.Close();
        }   
    }
}
