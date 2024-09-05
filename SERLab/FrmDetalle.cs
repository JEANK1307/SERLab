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
    public partial class FrmDetalle : Form
    {
        clsExamenes examenes { get; set; }
        public int idResultado { get; set; }
        public int idValor { get; set; } = 0;
        public bool CargoExamen { get; set; } = false;
        public int count { get; set; } = 0;
        public clsDetalle detalle { get; set; }
        public clsResultado resultado { get; set; }
        public bool resultadoCreado { get; set; } = false;
        public int id { get; set; }
        public FrmDetalle()
        {
            InitializeComponent();
        }

        private void CargarExamenes()
        {
            try
            {
                examenes = new clsExamenes();
                cmbExamen.DataSource = examenes.consultaMasiva();
                cmbExamen.DisplayMember = "Nombre";
                cmbExamen.ValueMember = "ID";
                cmbExamen.SelectedIndex = -1;
                CargoExamen = true;
            }
            catch (Exception)
            {

            }
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            CargarExamenes();
        }

        private void cmbExamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CargoExamen)
                {
                    clsValores valores = new clsValores();
                    valores.Examen = new clsExamenes();
                    valores.Examen.idExamen = (int)cmbExamen.SelectedValue;
                    miGrid.DataSource = valores.consultaMasiva();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            cmbExamen.SelectedIndex = -1;
            miGrid.ClearSelection();
            CargoExamen = false;
        }

        private void miGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                DialogResult resultado = MessageBox.Show(
                   "¿Desea agregar los resultados al valor seleccionado?",
                   "Cuidado",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    idValor = Convert.ToInt32(miGrid.Rows[e.RowIndex].Cells[0].Value);

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResultado.Text != string.Empty && idValor != 0)
                {
                    if (!resultadoCreado)
                    {
                        if (resultado.guardarResultado() > 0)
                        {
                            id = resultado.seleccionarUltimoIDActualizado();

                            if (id > 0)
                            {
                                clsDetalle detalle = new clsDetalle();
                                detalle.descripcion = txtDescripcion.Text.ToString();
                                detalle.result = txtResultado.Text.ToString();
                                detalle.resultados = new clsResultado();
                                detalle.resultados.idResultado = id;
                                detalle.valores = new clsValores();
                                detalle.valores.idValor = idValor;

                                if (detalle.guardarDetalle() > 0)
                                {
                                    MessageBox.Show("Se guardo correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    foreach (DataGridViewRow row in miGrid.Rows)
                                    {
                                        if (row.Cells["ID"].Value != null && (int)row.Cells["ID"].Value == idValor)
                                        {
                                            miGrid.Rows.Remove(row);
                                            miGrid.Refresh();
                                            break;
                                        }
                                    }
                                    txtDescripcion.Text = string.Empty;
                                    txtResultado.Text = string.Empty;
                                    count++;
                                    resultadoCreado = true;
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if(resultadoCreado)
                    {
                        clsDetalle detalle = new clsDetalle();
                        detalle.descripcion = txtDescripcion.Text.ToString();
                        detalle.result = txtResultado.Text.ToString();
                        detalle.resultados = new clsResultado();
                        detalle.resultados.idResultado = id;
                        detalle.valores = new clsValores();
                        detalle.valores.idValor = idValor;

                        if (detalle.guardarDetalle() > 0)
                        {
                            MessageBox.Show("Se guardo correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            foreach (DataGridViewRow row in miGrid.Rows)
                            {
                                if (row.Cells["ID"].Value != null && (int)row.Cells["ID"].Value == idValor)
                                {
                                    miGrid.Rows.Remove(row);
                                    miGrid.Refresh();
                                    break;
                                }
                            }
                            txtDescripcion.Text = string.Empty;
                            txtResultado.Text = string.Empty;
                            count++;
                            resultadoCreado = true;
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Verifique haya ingresado el resultado o seleccionado un valor", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (count > 0)
                {
                    DialogResult resultado = MessageBox.Show(
                         "¿Desea ver el resultado?",
                         "Cuidado",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question
                        );

                    if (resultado == DialogResult.Yes)
                    {
                        clsDetalle idDetalle = new clsDetalle();
                        int Resultado = idDetalle.seleccionarUltimoDetalle();
                        CargarDetalle detalle = new CargarDetalle();
                        detalle.idDetalleResultado = Resultado;
                        detalle.idResultado = id;
                        detalle.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("necesita agregar un valor para continuar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
            }
        }
    }
}
