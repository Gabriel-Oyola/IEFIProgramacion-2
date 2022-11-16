using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celular
    {
        #region Atributos
        private int IdCelular;
        private string Marca;
        private string Modelo;
        private string Reparacion;
        private string Estado;
        private long Dni_Tecnico;
        private int Costo_total;
        private string FechaIngreso;
        private string FechaEgreso;
        #endregion

        #region Propiedades 

        public int p_id
        {
            get { return IdCelular; }
        }
        public string P_Marca
        {
            set { Marca = value; }
            get { return Marca; }
        }

        public string p_Modelo
        {
            set { Modelo = value; }
            get { return Modelo; }
        }

        public string P_Repacion
        {
            set { Reparacion = value; }
            get { return Reparacion; }

        }

        public string P_Estado
        {
            set { Estado = value; }
            get { return Estado; }
        }

        public long P_Dni_Tecnico
        {
            set { Dni_Tecnico = value; }
            get { return Dni_Tecnico; }
        }

        public int P_Costo_total
        {

            set { Costo_total = value; }
            get { return Costo_total; }
        }

        public string P_FechaIngreso
        {
            set { FechaIngreso = value; }
            get { return FechaIngreso; }
        }

        public string P_FechaEgreso
        {
            set { FechaEgreso = value; }
            get { return FechaEgreso; }
        }
        #endregion

        #region Constructor
        public Celular(string marca, string modelo, string reparacion, string estado,
            long tecnico, int costoTotal, string FechaI, string FechaE)
        {
            Marca = marca;
            Modelo = modelo;
            Reparacion = reparacion;
            Estado = estado;
            Dni_Tecnico = tecnico;
            Costo_total = costoTotal;
            FechaIngreso = FechaI;
            FechaEgreso = FechaE;
        }
        #endregion


        public void ingreso( string estado)
        {
            Estado = estado;
        }

        public void Egreso(string estado)
        {
            Estado = estado;
        }

    }
}
