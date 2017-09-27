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
    public partial class frmModificarCategoria : Form
    {

        public static Boolean ok;
        public static String nombreCategoria;
        
        public frmModificarCategoria()
        {
            InitializeComponent();
        }

        private void frmModificarCategoria_Load(object sender, EventArgs e)
        {
            txtModificarCategoria.Text = frmCategorias.nombreCatLst.ToString();
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            nombreCategoria = txtModificarCategoria.Text;
            if (nombreCategoria != "")
            {
                ok = true;
              
                this.Close();
            }
            else
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModificarCategoria.Text = frmCategorias.nombreCatLst.ToString();
            }
            
        }

        public static String getName()
        {

            return nombreCategoria;
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
