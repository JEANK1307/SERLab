using SERLabLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERLab
{
    public partial class FrmVerResultados : Form
    {
        public int idResultado { get; set; }
        public FrmVerResultados()
        {
            InitializeComponent();
        }

        private void CargarResultado()
        {
            try
            {
                clsResultado resultado = new clsResultado();
                miGridResultados.DataSource = resultado.consultarResultados();
            }
            catch (Exception)
            {

            }
        }

        private void FrmVerResultados_Load(object sender, EventArgs e)
        {
            CargarResultado();
        }

        private void miGridResultados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                idResultado = Convert.ToInt32(miGridResultados.Rows[e.RowIndex].Cells[0].Value);
                DialogResult resultado = MessageBox.Show(
                     "¿Desea Ver los valores a este Resultado?",
                     "Cuidado",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question
                 );

                if (resultado == DialogResult.Yes)
                {
                    clsDetalle detalle = new clsDetalle();
                    detalle.resultados = new clsResultado();
                    detalle.resultados.idResultado = idResultado;
                    miGridDetalles.DataSource = detalle.consultarPorID();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
