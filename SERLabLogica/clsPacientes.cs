using accesoDatos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERLabLogica
{
    public class clsPacientes
    {
        public int idPaciente { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string cedula { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public bool activo { get; set; }
        public bool estado { get; set; }

        public string sexo { get; set; }

        public clsPacientes(){}

        public clsPacientes(String PValor, TipoBusqueda Ptipo)
        {
            if(Ptipo == TipoBusqueda.cedula)
            {
                this.cedula = PValor;
            }
            else
            {
                this.nombre = PValor;
            }                        
        }


        public DataTable ConsultaPorCedula()
        {

            DataTable pacientes = new DataTable();
            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select p.idPaciente as idPaciente,p.nombre as Nombre,p.apellidos as Apellidos,p.cedula as [Cédula],p.telefono as [Teléfono],p.correo as Correo, p.direccion as [Dirección],p.fecha_nacimiento as [Fecha Nacimiento], case when p.estado = 1 then 'Activo' else 'Inactivo' end as Estado, p.sexo as Sexo from Paciente as p where p.cedula like '{0}%' and p.estado = 1", this.cedula);
                    pacientes = conectar.consultar(Query);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SERLab: (Ocurrio el siguiente error en capa logica de negocio)  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                throw;
            }


            conectar.CerrarConecion();
            return pacientes;
        }

        public DataTable ConsultaPorNombre()
        {


            DataTable pacientes = new DataTable();
            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select p.idPaciente as idPaciente,p.nombre as Nombre,p.apellidos as Apellidos,p.cedula as [Cédula],p.telefono as [Teléfono],p.correo as Correo, p.direccion as [Dirección],p.fecha_nacimiento as [Fecha Nacimiento], case when p.estado = 1 then 'Activo' else 'Inactivo' end as Estado, p.sexo as Sexo from Paciente as p where p.nombre like '{0}%' and p.estado = 1", this.nombre);
                    pacientes = conectar.consultar(Query);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Application", "SERLab: (Ocurrio el siguiente error en capa logica de negocio)  " + ex.Message + ex.StackTrace + ". ", EventLogEntryType.Error);
                throw;
            }


            conectar.CerrarConecion();
            return pacientes;
        }


        public DataTable consultarPaciente()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select * from Paciente where estado = 1");
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }

        public DataTable consultaMasiva()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select p.idPaciente as ID, p.nombre as Nombre,p.apellidos as Apellidos,p.cedula as [Cédula],p.telefono as [Teléfono],p.correo as Correo, p.direccion as [Dirección],p.fecha_nacimiento as [Fecha Nacimiento], case when p.estado = 1 then 'Activo' else 'Inactivo' end as Estado, p.sexo as Sexo from Paciente as p where p.estado = 1");
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }

        public int guardarPaciente()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format(@"
                    insert into Paciente (nombre,apellidos,cedula,telefono,correo,direccion,fecha_nacimiento,sexo,estado) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", this.nombre, this.apellidos, this.cedula, this.telefono, this.correo, this.direccion, this.fechaNacimiento,this.sexo,this.estado);
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

        public int editarPaciente() 
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("update Paciente set nombre = '{0}',apellidos = '{1}',cedula = '{2}',telefono = '{3}',correo = '{4}',direccion = '{5}',fecha_nacimiento = CONVERT(DATETIME, '{6}', 103),sexo = '{7}' WHERE idPaciente ='{8}'", this.nombre, this.apellidos, this.cedula, this.telefono, this.correo, this.direccion, this.fechaNacimiento, this.sexo, this.idPaciente);
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


        public int DesactivarPaciente()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("update Paciente set estado = '{0}' WHERE idPaciente ='{1}'", this.estado, this.idPaciente);
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
