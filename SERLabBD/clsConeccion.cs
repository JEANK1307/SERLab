using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Diagnostics;
using System.Configuration;
namespace accesoDatos
{
    public class clsConeccion
    {
        #region propiedad
        /// <summary>
        /// representa la coneccion a la base de datos SQLserver
        /// </summary>
        private SqlConnection conectar = null;
        #endregion propiedades
        #region constructor
        public clsConeccion()
        {

            String coneccionString = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            conectar = new SqlConnection(coneccionString);
        }
        #endregion constructor 

        #region funciones
        public bool AbrirConeccion()
        {
            bool abrir = true;

            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SFTR: (Ocurrio el siguiente error al abrir la conexión  )  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                abrir = false;

            }
            return abrir;

        }

        /// <summary>
        /// esta funcion cierra la conecion a la base de datos 
        /// </summary>
        /// <returns>true si cierra sino fase </returns>
        public bool CerrarConecion()
        {
            bool cerrar = true;

            try
            {
                conectar.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SFTR: (Ocurrio el siguiente error al cerrar la conexión )  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                cerrar = false;

            }
            return cerrar;
        }
        /// <summary>
        /// se encarga de hacer cualquier consulta EN LA BASE DE DATOS
        /// </summary>
        /// <param name="query"> es la consulta que se va a ejecutar </param>
        /// <returns>retorna una tabla con el resultado del select</returns>
        public DataTable consultar(string query)
        {
            DataTable consulta = new DataTable();

            try
            {
                //se crea un comando tipo SQL con los parametros QUERY y la coneccion
                SqlCommand comandoSelect = new SqlCommand(query, conectar);

                //es el tipo de parametro que va a resicir 
                comandoSelect.CommandType = CommandType.Text;

                // este seria para llamar un procedimiento al macemdo
                //comandoSelect.CommandType = CommandType.StoredProcedure;

                //para que la tabla se adapte a laconsulta
                SqlDataAdapter adapter = new SqlDataAdapter(comandoSelect);

                //llenar la tabla resultado
                adapter.Fill(consulta);
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SFTR: (Ocurrio el siguiente error al realizar una consulta en base de datos )  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                consulta = null;
            }

            return consulta;
        }
        /// <summary>
        /// esta funcion se encargar de guardar,actualizar y eleimnar en la base de datos
        /// </summary>
        /// <returns>davuelve el numero de regidtro afectados</returns>
        /// 
        public int HacerHit(string Statement)
        {
            int registrosAfectado = 0;
            SqlCommand comando = new SqlCommand(Statement, conectar);
            try
            {
                registrosAfectado = comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SFTR: (Ocurrio el siguiente error al hacer Hit en la base de datos)  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                registrosAfectado = 0;
            }
            return registrosAfectado;
        }
        #endregion funciones

        #region desttructor
        ~clsConeccion()
        {
            conectar = null;

        }
        #endregion destructor
    }
}
