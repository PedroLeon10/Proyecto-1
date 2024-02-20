using Org.BouncyCastle.Security;
using project_u5.data;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Media;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project_u5.view
{
    public partial class frmAddUpdateInventarios : Form
    {

        private List<CLSArea> areas;
        CLSInventario inventario;

        public frmAddUpdateInventarios(CLSInventario inventario)
        {
            this.inventario = inventario;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadData();
            
        }

        private void LoadData()
        {
            areas = AreasDAO.GetAll();
            cboAreas.DataSource = areas;
            cboAreas.DisplayMember = "nombre";
            cboAreas.SelectedItem = null;
            if (inventario != null)
            {
                txtNombre.Text = inventario.NombreCorto;
                txtDescripcion.Text = inventario.Descripcion;
                txtSerie.Text = inventario.Serie;
                txtColor.Text = inventario.Color;
                txtObservaciones.Text = inventario.Observaciones;
                cboTipo.SelectedItem = inventario.TipoAdquision;

                areas = AreasDAO.GetAll();
                cboAreas.DataSource = areas;
                cboAreas.DisplayMember = "nombre";
                foreach (CLSArea cLSAreas in areas)
                {
                    if (cLSAreas.ID == inventario.Area.ID)
                    {
                        cboAreas.SelectedItem = cLSAreas;
                    }
                }
                return;
            }

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                error.SetError(txtNombre, "Por favor, escriba un nombre");
            }
            if (txtDescripcion.Text == "")
            {
                error.SetError(txtDescripcion, "Por favor, escriba una Descripcion");
            }
            if (txtSerie.Text == "")
            {
                error.SetError(txtSerie, "Por favor, escriba una serie");
            }
            if (txtColor.Text == "")
            {
                error.SetError(txtColor, "Por favor, escriba un color");
            }
            if (txtObservaciones.Text == "")
            {
                error.SetError(txtObservaciones, "Por favor, escriba observaciones");
            }
            if(cboAreas.SelectedItem == null)
            {
                error.SetError(cboAreas, "Por favor, seleccione una área");
            }
            if (cboTipo.SelectedItem == null)
            {
                error.SetError(cboTipo, "Por favor, seleccione un tipo de adquisición");
            }
            DateTime fechaHora = mcFecha.SelectionStart;
            String fecha = fechaHora.ToShortDateString();
            CLSArea area = (CLSArea)cboAreas.SelectedItem;
            if (inventario == null)
            {
                CLSInventario t = new CLSInventario(0,
                    area, txtNombre.Text, txtDescripcion.Text, txtSerie.Text, txtColor.Text,
                    fecha, cboTipo.SelectedItem.ToString(), txtObservaciones.Text);
                if (InventariosDAO.AddInventario(t) != 0) MessageBox.Show("Agregado");
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                txtSerie.Text = "";
                txtColor.Text = "";
                txtObservaciones.Text = "";
                cboAreas.SelectedItem = null;
                cboTipo.SelectedItem = null;

            }
            else
            {
                inventario = new CLSInventario(inventario.ID,
                    area, txtNombre.Text, txtDescripcion.Text, txtSerie.Text, txtColor.Text,
                    fecha, cboTipo.SelectedItem.ToString(), txtObservaciones.Text);
                if (InventariosDAO.UpdateInventario(inventario)) MessageBox.Show("Se modificó: " + inventario.NombreCorto);
            }
        }
    }
}
