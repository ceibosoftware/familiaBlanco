using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmFamiliaBlanco.Categorias
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria form = new frmAgregarCategoria();
            form.ShowDialog();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            frmModificarCategoria form = new frmModificarCategoria();
            form.ShowDialog();
        }
    }
}
