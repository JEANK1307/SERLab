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
    public partial class frmListaValores : Form
    {
        public int id { get; set; } = 0;
        public List<clsValores> listaValores { get; set; }
        public frmListaValores()
        {
            InitializeComponent();
        }

        private void CargarValores()
        {
            try
            {
                clsValores valores = new clsValores();
                migridHijo.DataSource = valores.consultaMasiva();

            }
            catch (Exception)
            {

            }
        }

        private void consultarTodosValores()
        {
            clsValores valores = new clsValores();
            this.migridHijo.DataSource = valores.consultaMasiva();

        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            //cuando el usuario busca por codigo
            int numero;
            if (this.txtBuscarCodigo.Text != "")
            {

                if (int.TryParse(this.txtBuscarCodigo.Text, out numero))
                {

                    clsValores valor = new clsValores(numero);
                    this.migridHijo.DataSource = valor.ConsultaPorCodigo();
                }
                else
                {
                    MessageBox.Show("Solo puede digitar números en esta area. Verifique he intente de nuevo ", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBuscarCodigo.Text = "";
                }

            }
            else
            {
                //si el campo esta vacio
                consultarTodosValores();
            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (this.txtBuscarNombre.Text != "")
            {
                if (int.TryParse(this.txtBuscarNombre.Text, out numero) == false)
                {
                    clsValores valor = new clsValores();
                    this.migridHijo.DataSource = valor.ConsultaPorNombre(this.txtBuscarNombre.Text);
                }
                else
                {
                    MessageBox.Show("Solo puede digitar letras. Verifique que la búsqueda no contenga números", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBuscarNombre.Text = "";
                }
            }
            else
            {
                consultarTodosValores();
            }
        }

        private void cargarVistaPrevia()
        {

            // Crear una lista para almacenar las filas seleccionadas
            DataTable migrid2 = new DataTable();

            listaValores = new List<clsValores>();

            // Copiar la estructura del DataGridView a la DataTable
            foreach (DataGridViewColumn column in migridHijo.Columns)
            {
                migrid2.Columns.Add(column.Name, column.ValueType);
            }

            // Agregar las filas seleccionadas a la DataTable
            foreach (DataGridViewRow row in migridHijo.SelectedRows)
            {
                DataRow dataRow = migrid2.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                migrid2.Rows.Add(dataRow);
            }

            // Crear una instancia de la segunda ventana
            frmValoresExamen form2 = new frmValoresExamen();

            // Mostrar la segunda ventana
            form2.Show();
        }

        private void frmListaValores_Load(object sender, EventArgs e)
        {
            CargarValores();

        }

        private void migrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    id = Convert.ToInt32(migridHijo.Rows[e.RowIndex].Cells[0].Value);
            //    string nombre = migridHijo.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    string presencia = migridHijo.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    string aspecto = migridHijo.Rows[e.RowIndex].Cells[3].Value.ToString();
            //    string estado = migridHijo.Rows[e.RowIndex].Cells[4].Value.ToString();
            //    string rangoReferencia = migridHijo.Rows[e.RowIndex].Cells[5].Value.ToString();
            //    string unidad = migridHijo.Rows[e.RowIndex].Cells[6].Value.ToString();

            //    // Crea una nueva instancia de clsValores
            //    clsValores nuevoValor = new clsValores
            //    {
            //        idValor = id,
            //        nombre = nombre,
            //        presencia = Convert.ToBoolean(presencia),
            //        aspecto = aspecto,
            //        estado = Convert.ToBoolean(estado),
            //        rangoReferencia = rangoReferencia,
            //        unidad = unidad
            //    };

            //    //Agrega el nuevo valor a la lista
            //    listaValores.Add(nuevoValor);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            frmListaValores frm = new frmListaValores();
            frmValoresExamen frmPadre = Owner as frmValoresExamen;
            foreach (DataGridViewRow row in this.migridHijo.Rows)
            {

                if (row.Selected)
                {
                    frmPadre.migrid.Rows.Add(
                    row.Cells["ID"].Value,
                    row.Cells["Nombre"].Value,
                    row.Cells["Presencia"].Value,
                    row.Cells["Aspecto"].Value,
                    row.Cells["Estado"].Value,
                    row.Cells["Rango de Referencia"].Value,
                    row.Cells["Unidad"].Value

                );
                }

            }
            this.Close();
        }

        private void migrid_DoubleClick(object sender, EventArgs e)
        {
            frmValoresExamen valores = Owner as frmValoresExamen;
            valores.migrid.Rows.Add(
                migridHijo.CurrentRow.Cells["ID"].Value,
                migridHijo.CurrentRow.Cells["Nombre"].Value,
                migridHijo.CurrentRow.Cells["Presencia"].Value,
                migridHijo.CurrentRow.Cells["Aspecto"].Value,
                migridHijo.CurrentRow.Cells["Estado"].Value,
                migridHijo.CurrentRow.Cells["Rango de Referencia"].Value,
                migridHijo.CurrentRow.Cells["Unidad"].Value
            );
            this.Close();
        }

        private void migridHijo_MouseClick(object sender, MouseEventArgs e)
        {

            //int index = this.migridHijo.CurrentRow.Index;
            //this.migridHijo.Rows[index].Selected = true;
        }
    }
}
