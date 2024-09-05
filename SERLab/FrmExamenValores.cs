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
    public partial class FrmExamenValores : Form
    {
        public ExamenValores examenesValores { get; set; }
        public FrmExamenValores()
        {
            InitializeComponent();
        }

        private void CargarExamenesValores()
        {
            try
            {
                examenesValores = new ExamenValores();

                miGrid1.DataSource = examenesValores.consultaMasiva();

            }
            catch (Exception)
            {

            }
        }

        private void FrmExamenValores_Load(object sender, EventArgs e)
        {
            CargarExamenesValores();
        }

        private void miGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

            }
        }

        private void miGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int columnaIndex = miGrid1.Columns["idValor"].Index;

                    if (columnaIndex >= 0)
                    {
                        var valorIdValor = miGrid1.Rows[e.RowIndex].Cells[columnaIndex].Value;

                        examenesValores = new ExamenValores();

                        examenesValores.idValor = Convert.ToInt32(valorIdValor);

                        miGrid2.ClearSelection();

                        miGrid2.DataSource = examenesValores.consultaMasivaValores();

                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
