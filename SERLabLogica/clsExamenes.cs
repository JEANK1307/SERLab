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
    public class clsExamenes
    {
        public int idExamen { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public clsTipoExamen idTipoExamen { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public bool estado { get; set; }
        public int ID { get; set; }


        public clsExamenes()
        {
            
        }

        public clsExamenes(int PidExamen)
        {
            this.idExamen = PidExamen;

        }

        public clsExamenes(string Pnombre)
        {
            this.nombre = Pnombre;
        }

        public int guardarExamen()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format(@"
                                                insert into Examen (nombre,tipo,idTipoExamen,descripcion,precio,estado) values ('{1}','{2}','{3}','{4}','{5}','{6}')", this.idExamen, this.nombre, this.tipo, this.idTipoExamen.idTipoExamen, this.descripcion, this.precio, this.estado);
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

        public DataTable consultaMasiva()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select e.idExamen as ID, e.nombre as Nombre,e.tipo as Tipo,e.idTipoExamen as Tipo,e.descripcion as [Descripción], e.precio as Precio from Examen as e where e.idExamen = idExamen and e.estado = 1");
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

            DataTable medicos = new DataTable();
            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select e.idExamen as ID, e.nombre as Nombre,e.tipo as Tipo,e.idTipoExamen as Tipo,e.descripcion as [Descripción], e.precio as Precio from Examen as e where e.idExamen like '{0}%' and e.estado = 1", this.idExamen);
                    medicos = conectar.consultar(Query);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SERLab: (Ocurrio el siguiente error en capa logica de negocio)  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                throw;
            }

            conectar.CerrarConecion();
            return medicos;
        }

        public DataTable ConsultaPorNombre(string Pnombre)
        {

            DataTable analisis = new DataTable();
            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select e.idExamen as ID, e.nombre as Nombre,e.tipo as Tipo,e.idTipoExamen as Tipo,e.descripcion as [Descripción], e.precio as Precio from Examen as e where e.nombre like '%{0}%'", Pnombre);
                    analisis = conectar.consultar(Query);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SERLab: (Ocurrio el siguiente error en capa logica de negocio)  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                throw;
            }


            conectar.CerrarConecion();
            return analisis;
        }

        public int DesactivarExamen()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("update Examen set estado = '{0}' WHERE idExamen ='{1}'", this.estado, this.idExamen);
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
