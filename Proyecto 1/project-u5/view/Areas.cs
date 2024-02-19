using Org.BouncyCastle.Security;
using project_u5.data;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Windows.Forms;

namespace project_u5.view
{
    public partial class Areas : Form
    {
        List<CLSArea> areas;

        public Areas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadData();
        }

        private void LoadData()
        {
            areas = AreasDAO.GetAll();
            dgvAreas.DataSource = areas;
            dgvAreas.AllowUserToAddRows = false;
            dgvAreas.AllowUserToDeleteRows = false;
            dgvAreas.AllowUserToOrderColumns = false;
            dgvAreas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAreas.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvAreas.Columns["id"].Visible = false;
            dgvAreas.Columns["nombre"].HeaderText = "Nombre";
            dgvAreas.Columns["ubicacion"].HeaderText = "Ubicacion";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertUpdateAreas form = new InsertUpdateAreas(null);
            form.FormClosed += new FormClosedEventHandler(AddUpdateFormClosed);
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAreas.SelectedRows.Count > 0)
            {
                int index = dgvAreas.CurrentRow.Index;

                CLSArea a = areas[index];

                InsertUpdateAreas form = new InsertUpdateAreas(a);
                form.FormClosed += new FormClosedEventHandler(AddUpdateFormClosed);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un registro.");
            }

        }

        private void AddUpdateFormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAreas.SelectedRows.Count > 0)
            {
                int index = dgvAreas.CurrentRow.Index;

                CLSArea a = areas[index];
                int codigo = AreasDAO.DeleteArea(a.ID);
                if (codigo == 1) MessageBox.Show("Se elimino el area");
                else if (codigo == 1451) MessageBox.Show("Error en eliminar: " + a.Nombre + ". Conflicto de referencia");
                LoadData();
            }
            else
            {
                MessageBox.Show("Seleccione la tienda que desea editar");
            }
        }
    }
}
