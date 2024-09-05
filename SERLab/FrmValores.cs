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
    public partial class FrmValores : Form
    {
        public int idExamen { get; set; }
        clsValores valor { get; set; }
        public int id { get; set; } = 0;
        public FrmValores()
        {
            InitializeComponent();
        }

        private void CargarValores()
        {
            try
            {
                valor = new clsValores();

                valor.Examen = new clsExamenes();

                valor.Examen.idExamen = idExamen;

                migridValores.DataSource = valor.consultaMasiva();

            }
            catch (Exception)
            {

            }
        }

        private void LimpiarForm()
        {
            txtNombre.Text = string.Empty;
            txtRango.Text = string.Empty;
            txtUnidad.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtRango.Text != "" && txtUnidad.Text != "")
                {
                    valor = new clsValores();
                    valor.nombre = txtNombre.Text;
                    valor.rangoReferencia = txtRango.Text;
                    valor.unidad = txtUnidad.Text;
                    valor.estado = true;
                    valor.Examen = new clsExamenes();
                    valor.Examen.idExamen = idExamen;

                    if (valor.guardarValor() >= 1)
                    {
                        MessageBox.Show("El valor guardó correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarValores();
                        LimpiarForm();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique que ninguno de los espacios esten en blanco", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (id != 0)
                {
                    valor = new clsValores();
                    valor.idValor = id;
                    valor.nombre = txtNombre.Text;
                    valor.rangoReferencia = txtRango.Text;
                    valor.unidad = txtUnidad.Text;
                    valor.estado = true;

                }

                if (valor.EditarValor() >= 1)
                {
                    MessageBox.Show("Se editó correctamente el valor", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarValores();
                    LimpiarForm();
                }
                else
                {
                    MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
            }
        }

        private void FrmValores_Load(object sender, EventArgs e)
        {
            CargarValores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    valor = new clsValores();
                    valor.idValor = id;
                    valor.estado = false;

                    if (valor.DesactivarValor() >= 1)
                    {
                        MessageBox.Show("Se desactivo correctamente el valor", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarValores();
                        LimpiarForm();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void migridValores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(migridValores.Rows[e.RowIndex].Cells[0].Value);
            txtNombre.Text = migridValores.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRango.Text = migridValores.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtUnidad.Text = migridValores.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
    }
}
