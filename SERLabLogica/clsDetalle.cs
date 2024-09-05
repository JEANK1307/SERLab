using accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERLabLogica
{
    public class clsDetalle
    {
        public int idDetalleResultado { get; set; }
        public clsValores valores { get; set; }
        public clsResultado resultados { get; set; }
        public string descripcion { get; set; }
        public string result { get; set; }

        public clsDetalle()
        {
                
        }

        public DataTable consultarPorID()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format(@"select d.descripcion,d.resultado,
                                                v.nombre,v.rangoReferencia,v.unidad, E.nombre,E.descripcion,E.precio
                                                from DetalleResultado D
                                                INNER JOIN Valor V 
                                                on d.idValor = v.idValor
                                                inner join Examen E
                                                on E.idExamen = V.idExamen
                                                where d.idResultado = {0}", this.resultados.idResultado);
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }

        public int seleccionarUltimoDetalle()
        {
            DataTable consulta = new DataTable();

            clsDetalle resultado = new clsDetalle();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("SELECT TOP 1 idDetalleResultado as idDetalleResultado FROM DetalleResultado ORDER BY idDetalleResultado DESC");
                    consulta = conectar.consultar(Query);
                }

                if (consulta.Rows.Count > 0)
                {
                    resultado.idDetalleResultado = Convert.ToInt32(consulta.Rows[0]["idDetalleResultado"].ToString());
                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return resultado.idDetalleResultado;
        }

        public int guardarDetalle()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format(@"insert into DetalleResultado (descripcion,resultado,idResultado,idValor) values ('{0}','{1}',{2},{3})", this.descripcion, this.result, this.resultados.idResultado, this.valores.idValor);
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
