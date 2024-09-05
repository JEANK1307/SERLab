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
    public partial class FrmResultado : Form
    {
        clsMedicos medico = new clsMedicos();
        clsPacientes paciente = new clsPacientes();
        private void CargarMedico()
        {
            try
            {
                medico = new clsMedicos();
                cmbMedico.DataSource = medico.consultarMedico();
                cmbMedico.DisplayMember = "nombre";
                cmbMedico.ValueMember = "idMedico";
                cmbMedico.SelectedIndex = -1;
            }
            catch (Exception)
            {

            }
        }

        private void CargarPaciente()
        {
            try
            {
                paciente = new clsPacientes();
                cmbPaciente.DataSource = paciente.consultarPaciente();
                cmbPaciente.DisplayMember = "nombre";
                cmbPaciente.ValueMember = "idPaciente";
                cmbPaciente.SelectedIndex = -1;
            }
            catch (Exception)
            {

            }
        }

        public FrmResultado()
        {
            InitializeComponent();
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            CargarMedico();
            CargarPaciente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbPaciente.SelectedIndex = -1;
            cmbMedico.SelectedIndex = -1;
            txtObservacion.Text = string.Empty;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (cmbPaciente.SelectedIndex != -1 && cmbMedico.SelectedIndex != -1 && txtObservacion.Text!= "")
            {
                DialogResult result = MessageBox.Show(
                   "¿Desea Continuar?",
                   "Pregunta",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
               );

                if (result == DialogResult.Yes)
                {

                    clsResultado resultado = new clsResultado();
                    resultado.paciente = new clsPacientes();
                    resultado.paciente.idPaciente = (int)cmbPaciente.SelectedValue;
                    resultado.medico = new clsMedicos();
                    resultado.medico.idMedico = (int)cmbMedico.SelectedValue;
                    resultado.observacion = txtObservacion.Text.ToString();
                    FrmDetalle detalle = new FrmDetalle();
                    detalle.resultado = resultado;
                    detalle.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Verifique que ninguno de los espacios esten en blanco", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}
