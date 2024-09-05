using accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERLabLogica
{
    public class clsTipoExamen
    {
        public int idTipoExamen { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public DataTable consultaMasiva()
        {
            DataTable datos = new DataTable();
            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select * from TipoExamen ");
                    datos = conectar.consultar(Query);
                }
            }
            catch (Exception)
            {

                datos = null;
            }


            return datos;
        }

    }
}
