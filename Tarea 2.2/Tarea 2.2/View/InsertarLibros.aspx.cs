using System;
using Tarea_2._2.Model;
using Tarea_2._2.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea_2._2
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool EsNumerico(String cadena)
        {
            return int.TryParse(cadena, out _);
        }

        protected void btnInsentar_Click(object sender, EventArgs e)
        {
            if (txtIsbn.Text.Length < 13 || txtIsbn.Text == "")
            {
                lbMensaje.Text = "Formato del Isbn incorrecto";
                return;
            }
            if (txtTitulo.Text == "")
            {
                lbMensaje.Text = "Formato del titulo incorrecto";
                return;
            }
            if (txtNumEdicion.Text == "" || EsNumerico(txtNumEdicion.Text) == false)
            {
                lbMensaje.Text = "Formato del número de edicion incorrecto";
                return;
            }
            if (txtAnio.Text == "" || txtAnio.Text.Length < 4 || EsNumerico(txtAnio.Text) == false)
            {
                lbMensaje.Text = "Formato del año de publicación incorrecto";
                return;
            }
            if (txtAutores.Text == "")
            {
                lbMensaje.Text = "Formato de los autores incorrecto";
                return;
            }
            if (txtPais.Text == "")
            {
                lbMensaje.Text = "Formato del país incorrecto";
                return;
            }
            if (txtSinopsis.Text == "")
            {
                lbMensaje.Text = "Formato de la sinopsis incorrecto";
                return;
            }
            if (txtCarrera.Text == "")
            {
                lbMensaje.Text = "Formato de la carrera incorrecto";
                return;
            }
            Libro l = new Libro(0, txtIsbn.Text, txtTitulo.Text, Convert.ToInt32(txtNumEdicion.Text),
                Convert.ToInt32(txtAnio.Text), txtAutores.Text, txtPais.Text,txtSinopsis.Text, txtCarrera.Text,
                txtMateria.Text);

            LibrosDAO librosDAO = new LibrosDAO();
            librosDAO.insertar(l);
            lbMensaje.Text = "Libro agregado correctamente";

            txtIsbn.Text = "";
            txtTitulo.Text = "";
            txtNumEdicion.Text = "";
            txtAnio.Text = "";
            txtAutores.Text = "";
            txtPais.Text = "";
            txtSinopsis.Text = "";
            txtCarrera.Text = "";
            txtMateria.Text = "";
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}