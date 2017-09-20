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
    public partial class frmPrincipal : Form
    {
        CRUD conexion = new CRUD();
       

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.loadListaProducto();
            //poner un valor por defecto en combobox de filtro y que no salga blanco
            cmbFiltro.SelectedIndex = 0;
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmAgregarProducto form = new frmAgregarProducto();
            form.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarProducto form = new frmModificarProducto();
            form.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores form = new frmProveedores();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ltsProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //consulta categoria, descripcion
                String consulta = "SELECT productos.nombre, productos.idProductos, productos.descripcion, categorias.nombre, categorias.idCategorias, productos.FK_idCategorias FROM productos , categorias WHERE idProductos = @valor AND productos.FK_idCategorias = categorias.idCategorias";
                DataSet productos = conexion.ConsultaParametrizada(consulta, ltsProductos.SelectedValue);
                txtDescripcion.Text = productos.Tables[0].Rows[0].ItemArray[2].ToString();
                txtCategoria.Text = productos.Tables[0].Rows[0].ItemArray[3].ToString();

                //consulta proveedores
                String consultaProveedores = "SELECT proveedor.nombre from proveedor , productos_has_proveedor WHERE productos_has_proveedor.FK_idProductos = @valor  AND productos_has_proveedor.FK_idProveedor = proveedor.idProveedor";
                DataSet proveedores = conexion.ConsultaParametrizada(consultaProveedores, ltsProductos.SelectedValue);
                ltsProveedores.DataSource = proveedores.Tables[0];
                ltsProveedores.DisplayMember = "nombre";
            }catch{

            }
        }

        private void loadListaProducto()
        {
            String consulta = " Select * from productos ";
            conexion.Consulta(consulta, ltsProductos);
            ltsProductos.DisplayMember = "nombre";
            ltsProductos.ValueMember = "idProductos";
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e) 
        {
            // Busquedas de productos.
            DataSet productos = new DataSet();
            String consulta;

            if (cmbFiltro.Text == "Nombre")
            {   //Busca por nombre
               consulta = "SELECT* FROM productos WHERE productos.nombre LIKE '%' @valor '%'";
               productos =  conexion.ConsultaParametrizada(consulta , txtFiltro.Text);
            }else if(cmbFiltro.Text == "Categoria")
            {
                //busca por nombre de categoria (posibilidad de agregar combobox)
               consulta = "SELECT productos.nombre ,categorias.idCategorias FROM categorias , productos WHERE categorias.nombre LIKE  '%' @valor '%' and categorias.idCategorias = productos.FK_idCategorias";
               productos = conexion.ConsultaParametrizada(consulta, txtFiltro.Text);
            }

            ltsProductos.DataSource = productos.Tables[0];
    
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void gbDetalle_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbProductos_Enter(object sender, EventArgs e)
        {

        }

        private void ltsProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}