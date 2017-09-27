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
    
    public partial class frmAgregarCategoria : Form
    {
        public static Boolean ok;
        public static String nombreCategoria;
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            nombreCategoria = txtAgregarCategoria.Text;
            if (nombreCategoria != "")
            {
                ok = true;
              
                this.Close();
            }
            else
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        public Boolean getOk()
        {

            return ok;
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
