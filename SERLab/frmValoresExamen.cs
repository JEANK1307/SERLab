using SERLabLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERLab
{
    public partial class frmValoresExamen : Form
    {
        public int idExamen { get; set; }
        public frmValoresExamen()
        {
            InitializeComponent();
        }

        clsValores valores { get; set; }

        private DataGridView dgvValores;
        public DataGridView DgvValores { get => dgvValores; set => dgvValores = value; }

        public void dtValores()
        {
            dgvValores = DgvValores;

        }

        public frmValoresExamen(frmListaValores vPrevia)
        {
            vPrevia.ShowDialog();
        }

        private void CargarExamenes()
        {
            try
            {
                clsValores valores = new clsValores();
                migrid.DataSource = valores.consultaMasiva();

            }
            catch (Exception)
            {

            }
        }


        private void LimpiarForm()
        {
            //txtNombre.Text = string.Empty;
            //txtDescripcion.Text = string.Empty;
            //txtPrecio.Text = string.Empty;
            //cmbTipo.Text = default;
            //migrid.Rows.Clear();

        }

        private void btnListaValores_Click(object sender, EventArgs e)
        {
            frmListaValores valores = new frmListaValores();
            AddOwnedForm(valores);
            valores.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void frmValoresExamen_Load(object sender, EventArgs e)
        {
            dtValores();
        }

        private void btnAgregarExamen_Click(object sender, EventArgs e)
        {
            try
            {
                ExamenValores examen = new ExamenValores();

                examen.idExamen = idExamen;

                List<clsValores> listaValores = new List<clsValores>();

                foreach (DataGridViewRow fila in migrid.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        // Obtener el valor de la celda y convertirlo a int
                        string valor = fila.Cells[0].Value?.ToString();

                        if (!string.IsNullOrEmpty(valor) && int.TryParse(valor, out int idValor))
                        {
                            // Crear una nueva instancia de clsValor y asignar el valor
                            clsValores nuevoValor = new clsValores
                            {
                                idValor = idValor
                            };

                            listaValores.Add(nuevoValor);
                        }
                    }
                }

                examen.idsValores = listaValores;

                if (examen.guardar() > 0)
                {
                    MessageBox.Show("Se guardó correctamente los valores del examen", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Se guardó correctamente los valores del examen", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
