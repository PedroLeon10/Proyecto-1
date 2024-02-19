using System;
using System.Windows.Forms;

namespace project_u5.view
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            new view.Areas().ShowDialog();
        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            new view.InventariosCatalogo().ShowDialog();
        }

        //new view.StoresCatalogue().ShowDialog();

    }
}
