using accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERLabLogica
{
    public class clsValores
    {
        public int idValor { get; set; }
        public string nombre { get; set; }
        public bool presencia { get; set; }
        public string aspecto { get; set; }
        public bool estado { get; set; }
        public clsExamenes Examen { get; set; }
        public clsTipoExamen idTipoExamen { get; set; }
        public string rangoReferencia { get; set; }
        public string unidad { get; set; }

        public clsValores(){}

        public clsValores(int PidValor)
        {
            this.idValor = PidValor;

        }
        public clsValores(string Pnombre)
        {
            this.nombre = Pnombre;
        }  

        public DataTable consultaMasiva()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select v.idValor as ID, v.nombre as Nombre,v.estado as Estado,v.rangoReferencia as [Rango de Referencia], v.unidad as Unidad from Valor as v where v.estado = 1 and v.idExamen ={0}",this.Examen.idExamen);
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }

        

        public DataTable ConsultaPorCodigo()
        {

            DataTable valores = new DataTable();
            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select v.idValor as ID, v.nombre as Nombre,v.presencia as Presencia,v.aspecto as Aspecto,v.estado as Estado,v.rangoReferencia as [Rango de Referencia], v.unidad as Unidad from Valor as v where v.idValor like '{0}%' and v.estado = 1", this.idValor);
                    valores = conectar.consultar(Query);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SERLab: (Ocurrio el siguiente error en capa logica de negocio)  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                throw;
            }

            conectar.CerrarConecion();
            return valores;
        }


        public DataTable ConsultaPorNombre(string Pnombre)
        {

            DataTable valores = new DataTable();
            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select v.idValor as ID, v.nombre as Nombre,v.presencia as Presencia,v.aspecto as Aspecto,v.estado as Estado,v.rangoReferencia as [Rango de Referencia], v.unidad as Unidad from Valor as v where v.nombre like '{0}%' and v.estado = 1", Pnombre);
                    valores = conectar.consultar(Query);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SERLab: (Ocurrio el siguiente error en capa logica de negocio)  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                throw;
            }


            conectar.CerrarConecion();
            return valores;
        }

        public int guardarValor()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("insert into Valor (nombre,presencia,aspecto,estado,rangoReferencia,unidad,idExamen) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", this.nombre, this.presencia, this.aspecto, this.estado, this.rangoReferencia, this.unidad, this.Examen.idExamen);
                    resultado = conectar.HacerHit(Query);
                }

            }
            catch (Exception)
            {

                resultado = 0;
            }
            conectar.CerrarConecion();
            return resultado;
        }

        public int EditarValor()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("update Valor set nombre = '{0}',rangoReferencia = '{1}',unidad = '{2}' WHERE idValor ='{3}'", this.nombre, this.rangoReferencia, this.unidad, this.idValor);
                    resultado = conectar.HacerHit(Query);
                }

            }
            catch (Exception)
            {

                resultado = 0;
            }
            conectar.CerrarConecion();
            return resultado;
        }

        public int DesactivarValor()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("update Valor set estado = '{0}' WHERE idValor ='{1}'", this.estado, this.idValor);
                    resultado = conectar.HacerHit(Query);
                }

            }
            catch (Exception)
            {

                resultado = 0;
            }
            conectar.CerrarConecion();
            return resultado;
        }


    }
}
