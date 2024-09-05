using accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERLabLogica
{
    public class clsResultado
    {
        public int idResultado { get; set; }
        public clsMedicos medico { get; set; }  

        public string observacion { get; set; }

        public DateTime fechaRealizada { get; set; }

        public clsPacientes paciente { get; set; }

        public clsResultado()
        {
                
        }

        public int seleccionarUltimoIDActualizado()
        {
            DataTable consulta = new DataTable();

            clsResultado resultado = new clsResultado();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("SELECT TOP 1 idResultado as idResultado FROM Resultado ORDER BY idResultado DESC");
                    consulta = conectar.consultar(Query);
                }

                if (consulta.Rows.Count > 0)
                {
                    resultado.idResultado = Convert.ToInt32(consulta.Rows[0]["idResultado"].ToString());
                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return resultado.idResultado;
        }

        public DataTable seleccionarUltimoID()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("SELECT TOP 1 idResultado as  FROM Resultado ORDER BY idResultado DESC");
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }

        public DataTable consultarPorID()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format(@"select r.fechaRealizada,r.observacion,
                                                    m.nombre + m.apellido as 'Medico',
                                                    p.nombre + p.apellidos as 'Paciente',
                                                    p.cedula as 'Cedula Paciente',
                                                    p.correo as 'paciente.correo',
                                                    p.direccion as 'Direccion Paciente',
                                                    p.fecha_nacimiento as 'fecha Nacimiento Paciente'
                                                    from Resultado r 
                                                    inner join Medico m on r.idMedico = m.idMedico
                                                    inner join Paciente p on r.idPaciente = p.idPaciente
                                                    where idResultado ={0}", this.idResultado);
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }

        public DataTable consultarResultados()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format(@"select r.idResultado,
                                                    r.fechaRealizada,r.observacion,
                                                    m.nombre + m.apellido as 'medico.nombre',
                                                    p.nombre + p.apellidos as 'paciente.nombre',
                                                    p.cedula as 'paciente.cedula',
                                                    p.correo as 'paciente.correo',
                                                    p.direccion as 'paciente.direccion',
                                                    p.fecha_nacimiento as 'paciente.fecha_nacimiento'
                                                    from Resultado r 
                                                    inner join Medico m on r.idMedico = m.idMedico
                                                    inner join Paciente p on r.idPaciente = p.idPaciente", this.idResultado);
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }


        public int guardarResultado()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format(@"
                    insert into Resultado (observacion,idMedico,idPaciente) values ('{0}',{1},{2})", this.observacion, this.medico.idMedico, this.paciente.idPaciente);
                    resultado = conectar.HacerHit(Query);
                }

            }
            catch (Exception)
            {

                resultado = 0;
            }
            conectar.CerrarConecion();

            idResultado = resultado;

            return resultado;
        }


    }
}
