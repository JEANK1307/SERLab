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
    public partial class frmExamenes : Form
    {
        public int id { get; set; } = 0;
        public frmExamenes()
        {
            InitializeComponent();
        }

        private void CargarExamenes()
        {
            try
            {
                clsExamenes analisis = new clsExamenes();

                migrid.DataSource = analisis.consultaMasiva();

            }
            catch (Exception)
            {

            }
        }

        private void consultarTodosExamenes()
        {
            try
            {
                clsExamenes analisis = new clsExamenes();
                migrid.DataSource = analisis.consultaMasiva();

            }
            catch (Exception)
            {

            }
        }

        private void migrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(migrid.Rows[e.RowIndex].Cells[0].Value);
                DialogResult resultado = MessageBox.Show(
                     "¿Desea agregarle valores a este examen?",
                     "Cuidado",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question
                 );

                if (resultado == DialogResult.Yes)
                {
                    FrmValores valores = new FrmValores();
                    valores.idExamen = id;
                    valores.ShowDialog();
                }
            }
            catch (Exception)
            {

            }
        }


        private void frmAnalisis_Load(object sender, EventArgs e)
        {
            CargarExamenes();
            cargarcmbTipo();
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {

            int numero;
            if (this.txtBuscarCodigo.Text != "")
            {

                if (int.TryParse(this.txtBuscarCodigo.Text, out numero))
                {

                    clsExamenes analisis = new clsExamenes(numero);

                    this.migrid.DataSource = analisis.ConsultaPorCodigo();
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
                consultarTodosExamenes();
            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            //cuando el usuario busca por nombre
            int numero;
            if (this.txtBuscarNombre.Text != "")
            {
                if (int.TryParse(this.txtBuscarNombre.Text, out numero) == false)
                {
                    clsExamenes analisis = new clsExamenes();
                    this.migrid.DataSource = analisis.ConsultaPorNombre(this.txtBuscarNombre.Text);
                }
                else
                {
                    MessageBox.Show("Solo puede digitar letras. Verifique que la búsqueda no contenga números", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBuscarNombre.Text = "";
                }
            }
            else
            {
                consultarTodosExamenes();
            }
        }

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    frmValoresExamen valores = new frmValoresExamen();
        //    valores.ShowDialog();
        //}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    clsExamenes examen = new clsExamenes();
                    examen.idExamen = id;
                    examen.estado = false;

                    if (examen.DesactivarExamen() >= 1)
                    {
                        MessageBox.Show("Se desactivo correctamente el Análisis", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarExamenes();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                consultarTodosExamenes();
            }
        }
        private void cargarcmbTipo()
        {
            try
            {
                clsTipoExamen TipoExamen = new clsTipoExamen();
                cmbTipo.DataSource = TipoExamen.consultaMasiva();
                cmbTipo.DisplayMember = "descripcion";
                cmbTipo.ValueMember = "idTipoExamen";
                cmbTipo.SelectedIndex = -1;
            }
            catch (Exception)
            {

            }
        }

        private void LimpiarForm()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            cmbTipo.SelectedIndex = -1;
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedIndex >= 0)
                {
                    clsExamenes analisis = new clsExamenes();
                    analisis.nombre = txtNombre.Text;
                    analisis.tipo = cmbTipo.Text;
                    analisis.idTipoExamen = new clsTipoExamen();
                    analisis.idTipoExamen.idTipoExamen = (int)cmbTipo.SelectedValue;
                    analisis.descripcion = txtDescripcion.Text;
                    analisis.precio = Convert.ToDouble(txtPrecio.Text);
                    analisis.cantidad = 1;
                    analisis.estado = true;
                    if (analisis.guardarExamen() > 0)
                    {
                        MessageBox.Show("Se guardó correctamente el examen", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarExamenes();
                        LimpiarForm();
                    }
                    else
                    {
                        MessageBox.Show("Se guardó correctamente los valores del examen", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Necesita seleccionar un tipo de examen para continuar", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
