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
    public partial class frmMedicos : Form
    {
        clsMedicos medico { get; set; }
        clsEspecialidadMedico especialidad { get; set; }

        public int id { get; set; } = 0;

        public frmMedicos()
        {
            InitializeComponent();
        }

        private void CargarEspecialidad()
        {
            try
            {
                especialidad = new clsEspecialidadMedico();
                cmbEspecialidad.DataSource = especialidad.consultaMasiva();
                cmbEspecialidad.DisplayMember = "descripcion";
                cmbEspecialidad.ValueMember = "idEspecialidad";
                cmbEspecialidad.SelectedIndex = -1;
            }
            catch (Exception)
            {

            }
        }

        private void CargarMedicos()
        {
            try
            {
                medico = new clsMedicos();

                migrid.DataSource = medico.consultarMasiva();

            }
            catch (Exception)
            {

            }
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            CargarMedicos();
            CargarEspecialidad();
            this.txtBuscarCodigo.Focus();
        }

        private void consultarTodosMedicos()
        {
            clsMedicos medicos = new clsMedicos();
            this.migrid.DataSource = medicos.consultarMasiva();

        }

        private void LimpiarForm()
        {
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNombreUsuario.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cmbEspecialidad.SelectedIndex = -1;
            id = 0;
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtApellido.Text != "" && txtCedula.Text != "" && txtNombreUsuario.Text != "" && cmbEspecialidad.SelectedIndex != -1 && txtPassword.Text != "")
                {
                    medico = new clsMedicos();
                    medico.nombre = txtNombre.Text;
                    medico.apellido = txtApellido.Text;
                    medico.cedula = txtCedula.Text;
                    medico.nombreUsuario = txtNombreUsuario.Text;
                    medico.password = txtPassword.Text;
                    medico.activo = true;
                    medico.idEspecialidad = new clsEspecialidadMedico();
                    medico.idEspecialidad.idEspecialidad = (int)cmbEspecialidad.SelectedValue;

                    if (medico.guardarMedico() >= 1)
                    {
                        MessageBox.Show("Se guardó correctamente el médico", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMedicos();
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
                    medico = new clsMedicos();
                    medico.idMedico = id;
                    medico.nombre = txtNombre.Text;
                    medico.apellido = txtApellido.Text;
                    medico.cedula = txtCedula.Text;
                    medico.nombreUsuario = txtNombreUsuario.Text;
                    medico.password = txtPassword.Text;
                    medico.activo = true;
                    medico.idEspecialidad = new clsEspecialidadMedico();
                    medico.idEspecialidad.idEspecialidad = (int)cmbEspecialidad.SelectedValue;
                }

                if (medico.EditarMedico() >= 1)
                {
                    MessageBox.Show("Se editó correctamente el médico", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarMedicos();
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

        private void migrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(migrid.Rows[e.RowIndex].Cells[0].Value);
                txtNombre.Text = migrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtApellido.Text = migrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCedula.Text = migrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNombreUsuario.Text = migrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbEspecialidad.Text = migrid.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtPassword.Text = migrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnGuardar.Visible = false;
                btnEditar.Visible = true;
            }
            catch (Exception)
            {
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    medico = new clsMedicos();
                    medico.idMedico = id;
                    medico.activo = false;

                    if (medico.DesactivarMedico() >= 1)
                    {
                        MessageBox.Show("Se desactivo correctamente el médico", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMedicos();
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

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            //cuando el usuario busca por nombre
            int numero;
            if (this.txtBuscarNombre.Text != "")
            {
                if (int.TryParse(this.txtBuscarNombre.Text, out numero) == false)
                {
                    clsMedicos medico = new clsMedicos();
                    this.migrid.DataSource = medico.ConsultaPorNombre(this.txtBuscarNombre.Text);
                }
                else
                {
                    MessageBox.Show("Solo puede digitar letras. Verifique que la búsqueda no contenga números", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBuscarNombre.Text = "";
                }
            }
            else
            {
                consultarTodosMedicos();
            }
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            //cuando el usuario busca por codigo
            int numero;
            if (this.txtBuscarCodigo.Text != "")
            {

                if (int.TryParse(this.txtBuscarCodigo.Text, out numero))
                {

                    clsMedicos medico = new clsMedicos(numero);

                    this.migrid.DataSource = medico.ConsultaPorCodigo();
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
                consultarTodosMedicos();
            }
        }
    }
}

