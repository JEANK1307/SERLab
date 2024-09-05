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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public clsMedicos Medico { get; set; }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmLogin));
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContrasenna = new TextBox();
            btmIngresar = new Button();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(88, 180);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(109, 29);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.Location = new Point(37, 285);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(151, 29);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(228, 186);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(345, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtContrasenna
            // 
            txtContrasenna.Location = new Point(228, 285);
            txtContrasenna.Name = "txtContrasenna";
            txtContrasenna.Size = new Size(345, 23);
            txtContrasenna.TabIndex = 3;
            txtContrasenna.UseSystemPasswordChar = true;
            txtContrasenna.TextChanged += textBox2_TextChanged;
            txtContrasenna.KeyPress += txtContrasenna_KeyPress;
            // 
            // btmIngresar
            // 
            btmIngresar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btmIngresar.Location = new Point(299, 381);
            btmIngresar.Name = "btmIngresar";
            btmIngresar.Size = new Size(151, 50);
            btmIngresar.TabIndex = 4;
            btmIngresar.Text = "Ingresar";
            btmIngresar.UseVisualStyleBackColor = true;
            btmIngresar.Click += btmIngresar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(249, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(286, 32);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Laboratorio Elizondo";
            // 
            // frmLogin
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(749, 528);
            Controls.Add(lblNombre);
            Controls.Add(btmIngresar);
            Controls.Add(txtContrasenna);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtContrasenna;
        private Button btmIngresar;
        private Label lblNombre;
        private Label lblContraseña;

        private void btmIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContrasenna.Text != "")
            {
                ValidarMedico();
            }
            else
            {
                MessageBox.Show("Verifique que ningun de los campo este en blanco", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ValidarMedico()
        {

            clsMedicos myMedico = new clsMedicos(txtContrasenna.Text, txtUsuario.Text);

            DataTable datos = new DataTable();

            if (myMedico.ValidarConeccion())
            {
                myMedico = myMedico.consultaUsuario();
                if (myMedico != null)
                {
                    Medico = new clsMedicos();
                    Medico.idMedico = myMedico.idMedico;
                    Medico.password = myMedico.password;
                    Medico.nombre = myMedico.nombre;
                    Medico.activo = myMedico.activo;
                    Medico.nombreUsuario = myMedico.nombreUsuario;
                    Medico.idEspecialidad = new clsEspecialidadMedico();
                    Medico.idEspecialidad.descripcion = myMedico.idEspecialidad.descripcion;

                    if ((Medico.password == txtContrasenna.Text) && (Medico.nombreUsuario == txtUsuario.Text) && (Medico.activo == true))
                    {
                        //MessageBox.Show("Bienvenido: " + Medico.nombre + "\n Al sistema ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPrincipal principal = new frmPrincipal();
                        this.Hide();
                        principal.ShowDialog();
                    }
                    else
                    {
                        if (Medico.password != txtContrasenna.Text)
                        {
                            MessageBox.Show("La Contraseña es incorrecta. Verifique he intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        if (Medico.activo == false)
                        {
                            MessageBox.Show("Este Usuario se encuentra Inactivo. Verifique he intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("El nombre de Usuario es Invalido. Verifique he intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasenna.Text = "";
                    myMedico = null;
                    datos = null;
                }
            }
            else
            {
                // no se pudo hacer coneccion con la base de datos 
                MessageBox.Show("No se pudo realizar coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtContrasenna_KeyPress(object sender, KeyPressEventArgs e)
        {
            // cuando el usuario preciona enter en al campo

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ValidarMedico();
            }
        }
    }
}
