using SERLabLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERLab
{
    public partial class FrmPacientes : Form
    {
        public int id { get; set; } = 0;
        public FrmPacientes()
        {
            InitializeComponent();
        }

        clsPacientes paciente { get; set; }

        private void CargarPacientes()
        {
            try
            {
                clsPacientes pacientes = new clsPacientes();
                migrid.DataSource = pacientes.consultaMasiva();

            }
            catch (Exception)
            {

            }
        }

        private void consultarTodosPacientes()
        {
            clsPacientes pacientes = new clsPacientes();
            this.migrid.DataSource = pacientes.consultaMasiva();

        }

        private void LimpiarForm()
        {
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            //dtFecha.Value = DateTime.Now;
            btnGuardarPaciente.Visible = true;
            btnEditarPaciente.Visible = false;
        }



        private void txtBuscarCedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string valor = txtBuscarCedula.Text;

        }

        private void txtCedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string valor = txtCedula.Text;

        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            txtBuscarCedula.Mask = "0-0000-0000";
            txtCedula.Mask = "0-0000-0000";

            txtBuscarCedula.MaskInputRejected += new MaskInputRejectedEventHandler(txtBuscarCedula_MaskInputRejected);
            txtCedula.MaskInputRejected += new MaskInputRejectedEventHandler(txtCedula_MaskInputRejected);

            consultarTodosPacientes();
            this.txtBuscarNombre.Focus();
            this.chkMasculino.Checked = true;
            this.dtFecha.Value = DateTime.Now;
            this.dtFecha.MaxDate = DateTime.Now;
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            //cuando el usuario busca por nombre
            int numero;
            if (this.txtBuscarNombre.Text != "")
            {
                clsPacientes paciente = new clsPacientes(this.txtBuscarNombre.Text, TipoBusqueda.nombre);
                this.migrid.DataSource = paciente.ConsultaPorNombre();
            }
            else
            {
                //si el campo esta vacio
                consultarTodosPacientes();
            }
        }

        private void txtBuscarCedula_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (this.txtBuscarCedula.Text != "")
            {

                clsPacientes paciente = new clsPacientes(this.txtBuscarCedula.Text, TipoBusqueda.cedula);
                this.migrid.DataSource = paciente.ConsultaPorCedula();
            }
            else
            {
                //si el campo esta vacio
                consultarTodosPacientes();
            }
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtApellido.Text != "" && txtCedula.Text != "" && txtTelefono.Text != "" && txtCorreo.Text != "" && txtDireccion.Text != "" && dtFecha.Value != null)
                {
                    paciente = new clsPacientes();
                    paciente.nombre = txtNombre.Text;
                    paciente.apellidos = txtApellido.Text;
                    paciente.cedula = txtCedula.Text;
                    paciente.telefono = txtTelefono.Text;
                    paciente.correo = txtCorreo.Text;
                    paciente.direccion = txtDireccion.Text;
                    paciente.estado = true;
                    var fecha = Convert.ToDateTime(dtFecha.Value.ToString("yyyy-MM-dd"));
                    paciente.fechaNacimiento = fecha;
                    if (chkMasculino.Checked == true)
                    {
                        paciente.sexo = "M";
                    }
                    else
                    {
                        paciente.sexo = "F";
                    }

                    if (paciente.guardarPaciente() >= 1)
                    {
                        MessageBox.Show("Se guardo correctamente el paciente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPacientes();
                        LimpiarForm();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique que ninguno de los campos este en blanco", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

            }
        }

        private void chkMasculino_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.chkMasculino.Checked)
            {
                this.chkFemenino.Checked = false;
            }
            else
            {
                this.chkFemenino.Checked = true;
            }
        }

        private void chkFemenino_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.chkFemenino.Checked)
            {
                this.chkMasculino.Checked = false;
            }
            else
            {
                this.chkMasculino.Checked = true;
            }
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            try
            {

                paciente = new clsPacientes();
                paciente.idPaciente = id;
                paciente.nombre = txtNombre.Text;
                paciente.apellidos = txtApellido.Text;
                paciente.cedula = txtCedula.Text;
                paciente.telefono = txtTelefono.Text;
                paciente.correo = txtCorreo.Text;
                paciente.direccion = txtDireccion.Text;
                DateTime fecha = dtFecha.Value;
                string fechaFormateada = fecha.ToString("yyyy-MM-dd");
                paciente.fechaNacimiento = Convert.ToDateTime(fechaFormateada);

                if (chkMasculino.Checked == true)
                {
                    paciente.sexo = "M";
                }
                else
                {
                    paciente.sexo = "F";
                }

                if (paciente.editarPaciente() >= 1)
                {
                    MessageBox.Show("Se edito correctamente el paciente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPacientes();
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
                txtTelefono.Text = migrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCorreo.Text = migrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDireccion.Text = migrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtFecha.Text = migrid.Rows[e.RowIndex].Cells[7].Value.ToString();
                string sexo = migrid.Rows[e.RowIndex].Cells[9].Value.ToString();
                btnEditarPaciente.Visible = true;
                btnGuardarPaciente.Visible = false;
                if (sexo == "M")
                {
                    chkMasculino.Checked = true;
                    chkFemenino.Checked = false;
                }
                else
                {
                    chkMasculino.Checked = false;
                    chkFemenino.Checked = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    paciente = new clsPacientes();
                    paciente.idPaciente = id;
                    paciente.estado = false;

                    if (paciente.DesactivarPaciente() >= 1)
                    {
                        MessageBox.Show("Se desactivo correctamente el paciente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPacientes();
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

        private void btnLimpiarPaciente_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
    }
}
