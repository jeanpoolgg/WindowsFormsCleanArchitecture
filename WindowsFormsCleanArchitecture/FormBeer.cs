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
    public partial class FormBeer : Form
    {
        private IRepository<Beer> _repository;
        private readonly IServiceProvider _serviceProvider;


        public FormBeer(IRepository<Beer> repository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _repository = repository;
            _serviceProvider = serviceProvider;
        }

        private async void FormBeer_Load(object sender, EventArgs e)
        {
            await Refresh();
            AddColumns();
        }

        private async Task Refresh()
        {
            var brands = await _repository.GetAllAsync();
            dgv.DataSource = brands.ToList();
        }

        private void AddColumns()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButton";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "Editar";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DefaultCellStyle.BackColor = Color.LightGray;
            dgv.Columns.Add(editButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
            dgv.Columns.Add(deleteButtonColumn);
        }

        private async void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);

            if (dgv.Columns[e.ColumnIndex].Name == "EditButton")
            {

            }else if (dgv.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta cerveza?",
                                                          "Confirmar eliminación", MessageBoxButtons.YesNo);

                if(confirmResult == DialogResult.Yes)
                {
                    await _repository.DeleteAsync(id);
                    await Refresh();
                }
            }
        }
    }
}
