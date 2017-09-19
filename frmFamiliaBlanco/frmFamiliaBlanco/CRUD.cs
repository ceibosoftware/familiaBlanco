﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace frmFamiliaBlanco
{
    class CRUD
    {
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=familiablanco; Uid=root; Pwd=''");

        public void Conexion()
        {
            try
            {  
                conexion.Open();
                var  result = MessageBox.Show("Conexion exitosa","",buttons);
                conexion.Close();
            }
            catch 
            {
                var result = MessageBox.Show("Conexion fallida", "", buttons);
            }
        }
        // consulta para llenar con todos los datos una listBox , vamos a ir agregando elementos a llenar, (combo y tabla son parametros opcionales por eso estan como null) 
        public void Consulta(String sql, ListBox tabla = null, ComboBox combo = null)
        {
            try
            {
                //Objeto data adapter: realiza conexion y solicitud del usuario.
                MySqlDataAdapter DA = new MySqlDataAdapter(sql, conexion);
                // Data table recibe la informacion del dataAdapter (DA).
                DataTable DT = new DataTable();
                //Pasamos la informacion del dataAdapter (DA) al data (DT) 
                DA.Fill(DT);
                if(tabla != null)
                {
                    tabla.DataSource = DT;
                }else if(combo != null)
                {
                    combo.DataSource = DT;
                }
             
                
            }
            catch
            {
                
                var result = MessageBox.Show("No se pudo realizar la consulta", "Error",buttons,MessageBoxIcon.Warning);
            }
        }
        // consulta parametrizada depende de el valor de parametro .
        public DataSet ConsultaParametrizada(String sql, Object parametro = null , String parametro2 = null)
        {
            try
            {
                //Objeto data adapter: realiza conexion y solicitud del usuario.
                MySqlDataAdapter DA = new MySqlDataAdapter(sql, conexion);
                if (parametro != null)
                {
                    DA.SelectCommand.Parameters.AddWithValue("valor", parametro);
                }else
                {
                    DA.SelectCommand.Parameters.AddWithValue("valor", parametro2);
                }
               
                // Data table recibe la informacion del dataAdapter (DA).
                DataSet DT = new DataSet();
                //Pasamos la informacion del dataAdapter (DA) al data (DT) 
                DA.Fill(DT);               
                return DT;
            }
            catch
            {
                return null;
                var result = MessageBox.Show("No se pudo realizar la consulta", "Error", buttons, MessageBoxIcon.Warning);
            }
        }
        // funcion que se va usar para hacer abm .
        public void operaciones(String sql)
        {
            //abrimos conexion
            conexion.Open();
            try
            {
                //objeto command almacena las instrucciones  
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                //ejecutamos instruccion
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            //cerramos conexion
            conexion.Close();
        }
    }

 }

