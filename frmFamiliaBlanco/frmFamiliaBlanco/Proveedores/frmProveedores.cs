using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmFamiliaBlanco
{
    public partial class frmProveedores : Form
    {
        CRUD conexion = new CRUD();

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            this.loadListaProveedores();
        }

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarProveedor form = new frmModificarProveedor();
            form.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor form = new frmAgregarProveedor();
            form.ShowDialog();
        }

        private void loadListaProveedores()
        {
            String consulta = "SELECT * FROM proveedor";
            conexion.Consulta(consulta, ltsProveedores);
            ltsProveedores.DisplayMember = "nombre";
            ltsProveedores.ValueMember = "idProveedor";

        }

        private void ltsProveedores_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
