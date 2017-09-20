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
    public partial class frmAgregarProducto : Form
    {
        CRUD conexion = new CRUD();

        public frmAgregarProducto()
        {
            InitializeComponent();
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            //carga de proveedores en lista
            LoadListaProducto();
            //carga de categorias en comboBox
            LoadListaComboCategoria();
            
            cmbFiltro.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnProvNuevo_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor form = new frmAgregarProveedor();
            form.ShowDialog();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            // Busquedas de productos.
            DataSet productos = new DataSet();
            String consulta;

            if (cmbFiltro.Text == "Nombre")
            {   //Busca por nombre
                consulta = "SELECT * FROM proveedor WHERE proveedor.nombre LIKE '%' @valor '%'";
                productos = conexion.ConsultaParametrizada(consulta, txtFiltro.Text);
            }
            else if (cmbFiltro.Text == "Categoria")
            {
                //busca por nombre de categoria (posibilidad de agregar combobox)
                consulta = "SELECT proveedor.nombre ,categorias.idCategorias FROM categorias , proveedor, categorias_has_proveedor WHERE categorias.nombre LIKE '%' @valor '%' and categorias.idCategorias = categorias_has_proveedor.FK_idCategorias";
                productos = conexion.ConsultaParametrizada(consulta, txtFiltro.Text);
            }

            ltsProveedores.DataSource = productos.Tables[0];

        }
        private void LoadListaProducto()
        {
            String consulta = " Select * from proveedor ";
            conexion.Consulta(consulta, ltsProveedores);
            ltsProveedores.DisplayMember = "nombre";
            ltsProveedores.ValueMember = "idProveedor";
        }

        private void LoadListaComboCategoria()
        {
            String consulta = "SELECT * FROM categorias";
            conexion.Consulta(consulta, combo : cmbCategoria);
            cmbCategoria.DisplayMember = "nombre";
            cmbCategoria.ValueMember = "idCategorias";
                
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string consulta;
            DataSet categorias = new DataSet();
            
            //Busca por nombre
            consulta = "SELECT * FROM categorias WHERE categorias.nombre LIKE '%' @valor '%'";
            categorias = conexion.ConsultaParametrizada(consulta, txtBuscar.Text);
            
            cmbCategoria.DataSource = categorias.Tables[0];
        }
        
       
    }
}

