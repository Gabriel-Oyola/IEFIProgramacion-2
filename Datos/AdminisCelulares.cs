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
        public int abmCelulares(string accion, Celular objCelular)
        {
            {
                int resultado = -1;//controlar que se realice la operacion con exito
                string orden = string.Empty;//para guardar consulta

                if (accion == "Alta")
                    orden = "insert into Celulares values (" + objCelular.p_id+",'"+ objCelular.P_Marca + ",'" + objCelular.p_Modelo + "', " + objCelular.P_Repacion + "', " + 
                        objCelular.P_Estado + "', " + objCelular.P_Dni_Tecnico + "', " +
                        objCelular.P_FechaIngreso + "', " + objCelular.P_FechaEgreso + "); ";

                if (accion == "Modificar")
                    orden = "update Celulares set CodCelular='"+objCelular.p_id+"Marca= " + objCelular.P_Marca + " Modelo= " + objCelular.p_Modelo+ "Reparacion= "
                        + objCelular.P_Repacion+ "Estado: "+objCelular.P_Estado 
                        + "Dni_tecnico= "+ objCelular.P_Dni_Tecnico+"costo_total= "+ objCelular.P_Costo_total 
                        + "FechaIngreso= "+ objCelular.P_FechaIngreso+ "FechaEgreso= "+objCelular.P_FechaEgreso +"where Id= " + objCelular.p_id+ "; ";


                if (accion == "Borrar")
                    orden = "delete into Celulares values (" +objCelular.p_id+ ",'" + objCelular.P_Marca + ",'" + objCelular.p_Modelo + "', " + objCelular.P_Repacion + "', " +
                        objCelular.P_Estado + "', " + objCelular.P_Dni_Tecnico + "', " +
                        objCelular.P_FechaIngreso + "', " + objCelular.P_FechaEgreso + "',); ";
                
                
                

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

        public DataSet listadoCelulares(string cual)//para uno o todos los dato segun el codigo
        {
            string orden = string.Empty;


            if (cual != "Todos") //entonces me va devolver un solo valor 
                orden = "select * from Celulares where CodCelular = " + int.Parse(cual) + ";";
            else
                orden = "select * from Celulares;";


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
                throw new Exception("Error al listar celulares", e);
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

    
