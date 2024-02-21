using project_u5.data;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace project_u5.view
{
    public partial class InventariosCatalogo : Form
    {
        public static List<CLSInventario> inventarios;
        public InventariosCatalogo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LlenarTabla();
        }
        private void LlenarTabla()
        {
            inventarios = InventariosDAO.GetAll();

            dgvInventarios.DataSource = inventarios;
            dgvInventarios.AllowUserToAddRows = false;
            dgvInventarios.AllowUserToDeleteRows = false;
            dgvInventarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInventarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvInventarios.Columns["id"].Visible = false;
            dgvInventarios.Columns["areaNombre"].HeaderText = "Area";
            dgvInventarios.Columns["area"].Visible = false;
            dgvInventarios.Columns["nombreCorto"].HeaderText = "NombreCorto";
            dgvInventarios.Columns["descripcion"].HeaderText = "Descripcion";
            dgvInventarios.Columns["serie"].HeaderText = "Serie";
            dgvInventarios.Columns["color"].HeaderText = "Color";
            dgvInventarios.Columns["fechaAdquision"].HeaderText = "FechaAdquision";
            dgvInventarios.Columns["tipoAdquision"].HeaderText = "TipoAdquision";
            dgvInventarios.Columns["observaciones"].HeaderText = "Observaciones";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void insertUpdateFormClosed(object sender, FormClosedEventArgs e)
        {
            LlenarTabla();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmAddUpdateInventarios insertUpdate = new view.frmAddUpdateInventarios(null);
            insertUpdate.FormClosed += new FormClosedEventHandler(insertUpdateFormClosed);
            insertUpdate.ShowDialog();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvInventarios.SelectedRows.Count > 0)
            {
                int index = dgvInventarios.CurrentRow.Index;
                CLSInventario cI = inventarios[index];


                frmAddUpdateInventarios insertUpdate = new view.frmAddUpdateInventarios(cI);
                insertUpdate.FormClosed += new FormClosedEventHandler(insertUpdateFormClosed);
                insertUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione el registro que desea editar.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventarios.SelectedRows.Count > 0)
            {
                int index = dgvInventarios.CurrentRow.Index;

                CLSInventario cI = inventarios[index];
                if (InventariosDAO.DeleteInventario(cI.ID)) MessageBox.Show("Se eliminó el registro.");
                LlenarTabla();
            }
            else
            {
                MessageBox.Show("Seleccione el registro que desea eliminar.");
            }
        }
    }
}
