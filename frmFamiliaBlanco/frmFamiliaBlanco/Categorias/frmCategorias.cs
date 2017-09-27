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

        CRUD conexion = new CRUD();
        public static string nombreCatLst;
        public  string id;
     
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            loadListaCategoria();
        }

        public frmCategorias()
        {
            InitializeComponent();
        }


        //AGREGAR CATEGORIA
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria form = new frmAgregarCategoria();
            form.ShowDialog();

            if (frmAgregarCategoria.ok)
            {
                String name = frmAgregarCategoria.getName();
                
                    String sql;
                    sql = "insert into categorias(nombre) values('" + name + "');";
                    conexion.operaciones(sql);

                    this.loadListaCategoria();
                }
                
                   
                
              
            
            
        }


        //MODIFICAR CATEGORIA
        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {

            nombreCatLst = lstCategorias.Text;

            id = lstCategorias.SelectedValue.ToString();
            Console.WriteLine("VALOR: "+id);
            frmModificarCategoria form = new frmModificarCategoria();
            form.ShowDialog();

            if (frmModificarCategoria.ok)
            {
                String name = frmModificarCategoria.getName();
                String sql;

                sql = "update categorias set nombre='" + name + "' WHERE idCategorias ='" + id + "'";
                conexion.operaciones(sql);
                this.loadListaCategoria();
            }

        }

        //CARGAR CATEGORIAS EN EL LIST
        private void loadListaCategoria()
        {
            String consulta = " Select * from categorias ";
            conexion.Consulta(consulta, lstCategorias);
            lstCategorias.DisplayMember = "nombre";
            lstCategorias.ValueMember = "idCategorias";
            
        }

        //GET NOMBRE CATEGORIA
        public  string  getNameLstCategorias()
        {
            return lstCategorias.DisplayMember;
        }


        //ELIMINAR CATEGORIA
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            nombreCatLst = lstCategorias.Text;
            DialogResult result = MessageBox.Show("Seguro quiere eliminar la categoría ? " + nombreCatLst, "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                id = lstCategorias.SelectedValue.ToString();
                String name = frmModificarCategoria.getName();
                String sql;

                sql = "delete from categorias where idCategorias='" + id + "'";
                conexion.operaciones(sql);
                this.loadListaCategoria();
            }
            else if (result == DialogResult.No)
            {
            }
           
          
        }
    }
}
