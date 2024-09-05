namespace SERLab
{
    partial class frmMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            migrid = new DataGridView();
            idMedico = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            cedula = new DataGridViewTextBoxColumn();
            nombreUsuario = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            idEspecialidad = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbEspecialidad = new ComboBox();
            label5 = new Label();
            txtApellido = new TextBox();
            txtCedula = new TextBox();
            txtNombreUsuario = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label6 = new Label();
            txtPassword = new TextBox();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            txtBuscarCodigo = new TextBox();
            txtBuscarNombre = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)migrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // migrid
            // 
            migrid.AllowUserToAddRows = false;
            migrid.AllowUserToDeleteRows = false;
            migrid.AllowUserToOrderColumns = true;
            migrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            migrid.Columns.AddRange(new DataGridViewColumn[] { idMedico, nombre, apellido, cedula, nombreUsuario, estado, idEspecialidad, password });
            migrid.Location = new Point(39, 102);
            migrid.Name = "migrid";
            migrid.RowTemplate.Height = 25;
            migrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            migrid.Size = new Size(741, 334);
            migrid.TabIndex = 0;
            migrid.CellMouseClick += migrid_CellMouseClick;
            // 
            // idMedico
            // 
            idMedico.DataPropertyName = "idMedico";
            idMedico.HeaderText = "ID";
            idMedico.Name = "idMedico";
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.DataPropertyName = "apellido";
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // cedula
            // 
            cedula.DataPropertyName = "cedula";
            cedula.HeaderText = "Cedula";
            cedula.Name = "cedula";
            // 
            // nombreUsuario
            // 
            nombreUsuario.DataPropertyName = "nombreUsuario";
            nombreUsuario.HeaderText = "Nombre Usuario";
            nombreUsuario.Name = "nombreUsuario";
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "Activo";
            estado.Name = "estado";
            // 
            // idEspecialidad
            // 
            idEspecialidad.DataPropertyName = "idEspecialidad.descripcion";
            idEspecialidad.HeaderText = "Especialidad";
            idEspecialidad.Name = "idEspecialidad";
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "password";
            password.Name = "password";
            password.ReadOnly = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(116, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 105);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 45);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Cédula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 105);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 5;
            label4.Text = "Nombre Usuario";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(603, 42);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(121, 23);
            cmbEspecialidad.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 45);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 7;
            label5.Text = "Especialidad";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(93, 97);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(116, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(366, 45);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(116, 23);
            txtCedula.TabIndex = 9;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(366, 102);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(116, 23);
            txtNombreUsuario.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(93, 153);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 33);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(260, 153);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 33);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(444, 153);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 33);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(518, 105);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 14;
            label6.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(603, 102);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(121, 23);
            txtPassword.TabIndex = 15;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(618, 153);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 33);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBuscarCodigo);
            groupBox1.Controls.Add(txtBuscarNombre);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(39, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 69);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Métodos de Búsqueda";
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(179, 30);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(175, 25);
            txtBuscarCodigo.TabIndex = 4;
            txtBuscarCodigo.TextChanged += txtBuscarCodigo_TextChanged;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(527, 30);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(190, 25);
            txtBuscarNombre.TabIndex = 3;
            txtBuscarNombre.TextChanged += txtBuscarNombre_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(379, 33);
            label9.Name = "label9";
            label9.Size = new Size(142, 17);
            label9.TabIndex = 2;
            label9.Text = "Buscar Por Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(37, 33);
            label8.Name = "label8";
            label8.Size = new Size(136, 17);
            label8.TabIndex = 0;
            label8.Text = "Buscar Por Código:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnLimpiar);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbEspecialidad);
            groupBox2.Controls.Add(txtCedula);
            groupBox2.Controls.Add(txtNombreUsuario);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(39, 453);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(741, 200);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de Médicos";
            // 
            // frmMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(831, 675);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(migrid);
            Name = "frmMedicos";
            Text = "Información de Médicos";
            Load += frmMedicos_Load;
            ((System.ComponentModel.ISupportInitialize)migrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView migrid;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbEspecialidad;
        private Label label5;
        private TextBox txtApellido;
        private TextBox txtCedula;
        private TextBox txtNombreUsuario;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label6;
        private TextBox txtPassword;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtBuscarNombre;
        private Label label9;
        private TextBox txtBuscarCodigo;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn idMedico;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn nombreUsuario;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn idEspecialidad;
        private DataGridViewTextBoxColumn password;
    }
}