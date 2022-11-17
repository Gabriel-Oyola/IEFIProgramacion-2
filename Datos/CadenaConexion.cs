﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace Datos
{
    public class CadenaConexion
    {
        protected SqlConnection conexion;
        protected string cadenaConexion = @"Data Source=DESKTOP-NUSLQEB\SQLEXPRESS;Initial Catalog=Celular;Integrated Security=True";

        public CadenaConexion()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            //si el estado conexion esta bien la abre 
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

        public void Cerrarconexion()
        {
            //si el estado esta abierta la cierra
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }
}
