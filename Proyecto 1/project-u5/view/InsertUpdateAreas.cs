using project_u5.data;
using project_u5.model;
using System;
using System.Windows.Forms;

namespace project_u5.view
{
    public partial class InsertUpdateAreas : Form
    {

        CLSArea area;
        public InsertUpdateAreas(CLSArea cS)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.area = cS;
            if (cS != null)
            {
                txtNombre.Text = area.Nombre;
                txtUbicacion.Text = area.Ubicacion;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                error.SetError(txtNombre, "Por favor, escriba un nombre");
                return;
            }
            if (txtUbicacion.Text == "")
            {
                error.SetError(txtUbicacion, "Por favor, escriba una ubicación");
                return;
            }
            if (area == null)
            {
                CLSArea newArea = new CLSArea(0, txtNombre.Text, txtUbicacion.Text);
                if (AreasDAO.AddArea(newArea) != 0) MessageBox.Show("Nuevo elemento agregado.");
                txtNombre.Text = "";
                txtUbicacion.Text = "";
            }
            else
            {
                area = new CLSArea(area.ID, txtNombre.Text, txtUbicacion.Text);
                if (AreasDAO.UpdateArea(area)) MessageBox.Show("Información actualizada.");
            }
        }
    }
}
