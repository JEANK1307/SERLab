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
    public class clsMedicos
    {
        #region propiedades
        public int idMedico { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public string password { get; set; }
        public string nombreUsuario { get; set; }
        public bool activo { get; set; }
        public clsEspecialidadMedico idEspecialidad { get; set; }
        #endregion propiedades

        #region constructores
        public clsMedicos() { }

        public clsMedicos(int PidMedico) {
            this.idMedico = PidMedico;
        
        }
        public clsMedicos(string Pnombre)
        {
            this.nombre = Pnombre;
        }

        public clsMedicos(string Pclave, string PnombreUsuario)
        {
            this.password = Pclave;
            this.nombreUsuario = PnombreUsuario;

        }
        /// <summary>
        /// constructor para guardar usuario nuevo
        /// </summary>
        /// <param name="Pclave"></param>
        /// <param name="Ptipo_usuario"></param>
        /// <param name="Pnombre"></param>
        public clsMedicos(string Pclave, string Pnombre, bool Pestado)
        {
            this.password = Pclave;
            this.nombre = Pnombre;
            this.activo = Pestado;
        }
        /// <summary>
        /// constructor para actualizar usuario
        /// </summary>
        /// <param name="PidUsuario"></param>
        /// <param name="Pclave"></param>
        /// <param name="Ptipo_usuario"></param>
        /// <param name="Pnombre"></param>
        public clsMedicos(int clsMedicos, string Pclave, string Pnombre, bool Pestado)
        {
            this.idMedico = idMedico;
            this.password = Pclave;
            this.nombre = Pnombre;
            this.activo = Pestado;
        }
        #endregion constructores

        #region funciones

        public bool eliminarUsuario()
        {
            bool resultado = false;

            return resultado;
        }

        public DataTable consultarMedico()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select * from Medico where estado = 1");
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }

        public DataTable consultarMasiva()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select m.*,EM.descripcion as 'idEspecialidad.descripcion' from Medico m \r\ninner join EspecialidadMedico EM\r\nON  M.idEspecialidad = EM.idEspecialidad\r\nwhere m.estado = 1");
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }

        public DataTable ConsultaMasivaUsuario()
        {
            DataTable Usuarios = new DataTable();
            try
            {
                accesoDatos.clsConeccion objConeccion = new accesoDatos.clsConeccion();
                if (objConeccion.AbrirConeccion())
                {
                    Usuarios = objConeccion.consultar("select u.id_usuario as Codigo,u.nombre,u.clave,tipo.descripcion as [Tipo De Usuario],u.estado from usuario u inner join tipo_usuario tipo on u.tipo_usuario= tipo.id_tipo_usuario");
                    objConeccion.CerrarConecion();
                }
                objConeccion = null;
                return Usuarios;
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SERLab: (Ocurrio el siguiente error en capa logica de negocio)  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                return null;
            }

        }

        public int guardarMedico()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("insert into Medico (nombre,apellido,cedula,password,nombreUsuario,idEspecialidad,estado) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", this.nombre, this.apellido, this.cedula, this.password, this.nombreUsuario, this.idEspecialidad.idEspecialidad,this.activo);
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

        public int EditarMedico()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("update Medico set nombre = '{0}',apellido = '{1}',cedula = '{2}',password = '{3}',nombreUsuario = '{4}',idEspecialidad ={5} WHERE idMedico ='{6}'",this.nombre, this.apellido, this.cedula, this.password, this.nombreUsuario, this.idEspecialidad.idEspecialidad, this.idMedico);
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

        public int DesactivarMedico()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("update Medico set estado = '{0}' WHERE idMedico ='{1}'", this.activo, this.idMedico);
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

        
        public clsMedicos consultaUsuario()
        {
            DataTable medico = new DataTable();
            clsMedicos myMedicos = new clsMedicos();
            clsConeccion myConeccion = new clsConeccion();
            try
            {
                if (myConeccion.AbrirConeccion())
                {
                    string Query = string.Format("select M.idMedico,M.nombre,M.estado,M.password,M.nombreUsuario,E.descripcion from Medico M INNER JOIN EspecialidadMedico E ON E.idEspecialidad = M.idEspecialidad WHERE M.nombreUsuario = '{0}'", this.nombreUsuario);
                    medico = myConeccion.consultar(Query);
                    myMedicos.idMedico = int.Parse(medico.Rows[0][0].ToString());
                    myMedicos.nombre = medico.Rows[0][1].ToString();
                    myMedicos.activo = Convert.ToBoolean(medico.Rows[0][2]);
                    myMedicos.password = medico.Rows[0][3].ToString();               
                    myMedicos.nombreUsuario = medico.Rows[0][4].ToString();
                    myMedicos.idEspecialidad = new clsEspecialidadMedico();
                    myMedicos.idEspecialidad.descripcion = medico.Rows[0][5].ToString();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SERLab: (Ocurrio el siguiente error en capa logica de negocio)  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                myMedicos = null;
            }

            myConeccion.CerrarConecion();
            return myMedicos;
        }

        public DataTable ConsultaPorCodigo()
        {

            DataTable medicos = new DataTable();
            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select m.idMedico as Codigo,m.nombre as Nombre,m.apellido as Apellido,\r\nm.cedula as Cedula,m.nombreUsuario as NombreUsuario,m.estado as Activo,m.idEspecialidad\r\nfrom Medico as M\r\nwhere m.idMedico like '{0}%' and M.activo = 1", this.idMedico);
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

        /// <summary>
        /// metodo que consulta medicos por nombre
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public DataTable ConsultaPorNombre(string Pnombre)
        {

            DataTable medicos = new DataTable();
            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select m.idMedico as Codigo,m.nombre as Nombre,m.apellido as Apellido,\r\nm.cedula as Cedula,m.nombreUsuario as NombreUsuario,m.estado as Activo,m.idEspecialidad\r\nfrom Medico as M\r\nwhere m.nombre like '%{0}%'", Pnombre);
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


        public bool ValidarConeccion()
        {
            bool estado = false;
            clsConeccion objConeccion = new clsConeccion();
            if (objConeccion.AbrirConeccion())
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            objConeccion = null;
            return estado;
        }

        #endregion funciones

        #region destructor

        ~clsMedicos()
        {
            this.password = null;
            this.nombre = null;
        }
        #endregion destructor
    }
}
