using accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERLabLogica
{
    public class clsEspecialidadMedico
    {
        public int idEspecialidad { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public clsEspecialidadMedico()
        {
            
        }

        public DataTable consultaMasiva()
        {
            DataTable datos = new DataTable();
            clsConeccion conectar = new clsConeccion();
            try
            {
                if (conectar.AbrirConeccion())
                {
                    string Query = string.Format("select * from EspecialidadMedico");
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
