using accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERLabLogica
{
    public class ExamenValores
    {
        public int idExamen{ get; set; }
        public List<clsValores> idsValores { get; set; }
        public int idExamenValor { get; set; }
        public int idValor { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string descripcion { get; set; }
        public ExamenValores()
        {
              
        }

        public int guardar()
        {
            int resultado = 0;

            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format(@"
                                                declare @idExamenValor int
                                                 set @idExamenValor = (select isnull(max(idExamenValor),0) + 1 from ExamenValores)");
                    foreach (var item in idsValores)
                    {
                        Query += string.Format(@"insert into ExamenValores(idExamenValor,idExamen,idValor) values (@idExamenValor,'{0}','{1}')", idExamen, item.idValor);
                    }
                    //   insert into Examenes (idExamen,nombre,tipo,idTipoExamen,descripcion,cantidad,precio,estado) values (@examen,'{1}','{2}','{3}','{4}','{5}','{6}','{7}')", this.idExamen, this.nombre, th
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
                    string Query = string.Format("select ex.idExamenValor,ex.idExamen,ex.idValor, e.nombre as 'nombre' , e.tipo as 'tipo' , e.descripcion as 'descripcion' from ExamenValores ex inner join Examenes e on ex.idExamen = e.idExamen");
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }

        public DataTable consultaMasivaValores()
        {
            DataTable consulta = new DataTable();
            try
            {
                clsConeccion conectar = new clsConeccion();
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select * from ExamenValores ex inner join Valores v on ex.idValor = v.idValor where ex.idValor ={0}",this.idValor);
                    consulta = conectar.consultar(Query);

                }
            }
            catch (Exception)
            {

                consulta = null;
            }

            return consulta;
        }
    }
}
