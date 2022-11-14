using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class AdminisCelulares : CadenaConexion
    {
        public int abmProductos(string accion, Celular objProducto)
        {
            {
                int resultado = -1;//controlar que se realice la operacion con exito
                string orden = string.Empty;//para guardar consulta

                if (accion == "Alta")
                    orden = "insert into Producto values (" + objProducto.P_Marca + ",'" + objProducto.p_Modelo + "', " + objProducto.P_Repacion + "', " + 
                        objProducto.P_Estado + "', " + objProducto.P_Dni_Tecnico + "', " +
                        objProducto.P_FechaIngreso + "', " + objProducto.P_FechaEgreso + "); ";



                if (accion == "Borrar")
                    orden = "delete into Producto values (" + objProducto.P_Marca + ",'" + objProducto.p_Modelo + "', " + objProducto.P_Repacion + "', " +
                        objProducto.P_Estado + "', " + objProducto.P_Dni_Tecnico + "', " +
                        objProducto.P_FechaIngreso + "', " + objProducto.P_FechaEgreso + "',); ";
                // falta la orden de borrar


                SqlCommand cmd = new SqlCommand(orden, conexion);

                try
                {
                    Abrirconexion();
                    //EJECUTA ALGO ME DEVUELVE LAS FILAS Q SE GUARDAN EN LA VARIABLE RESULTADO
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Errror al tratar de guardar,borrar o modificar celular", e);
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
                return resultado;
            }

        }

        public DataSet listadoProductos(string cual)//para uno o todos los dato segun el codigo
        {
            string orden = string.Empty;


            if (cual != "Todos") //entonces me va devolver un solo valor 
                orden = "select * from Productos where Codigo = " + int.Parse(cual) + ";";
            else
                orden = "select * from Producto;";


            SqlCommand cmd = new SqlCommand(orden, conexion);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();


            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar profesionales", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
