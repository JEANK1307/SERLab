namespace SERLab
{
    partial class FrmPacientes
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
            txtBuscarCedula = new MaskedTextBox();
            migrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            chkMasculino = new CheckBox();
            gbSexo = new GroupBox();
            chkFemenino = new CheckBox();
            txtDireccion = new TextBox();
            dtFecha = new DateTimePicker();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            groupBox2 = new GroupBox();
            btnLimpiarPaciente = new Button();
            btnEliminarPaciente = new Button();
            btnEditarPaciente = new Button();
            btnGuardarPaciente = new Button();
            txtCedula = new MaskedTextBox();
            groupBox3 = new GroupBox();
            txtBuscarNombre = new TextBox();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)migrid).BeginInit();
            gbSexo.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscarCedula
            // 
            txtBuscarCedula.Location = new Point(91, 35);
            txtBuscarCedula.Name = "txtBuscarCedula";
            txtBuscarCedula.Size = new Size(345, 25);
            txtBuscarCedula.TabIndex = 23;
            txtBuscarCedula.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtBuscarCedula.MaskInputRejected += txtBuscarCedula_MaskInputRejected;
            txtBuscarCedula.TextChanged += txtBuscarCedula_TextChanged;
            // 
            // migrid
            // 
            migrid.AllowUserToAddRows = false;
            migrid.AllowUserToDeleteRows = false;
            migrid.AllowUserToResizeColumns = false;
            migrid.AllowUserToResizeRows = false;
            migrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            migrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            migrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            migrid.Location = new Point(32, 165);
            migrid.Name = "migrid";
            migrid.ReadOnly = true;
            migrid.RowTemplate.Height = 25;
            migrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            migrid.Size = new Size(890, 479);
            migrid.TabIndex = 0;
            migrid.CellMouseClick += migrid_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 52);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 113);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 3;
            label3.Text = "Cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 145);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 175);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 5;
            label5.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(81, 167);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(130, 23);
            txtCorreo.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(81, 138);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 23);
            txtTelefono.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(81, 76);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(130, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 208);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 247);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 11;
            label7.Text = "Fecha Nacimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(229, 113);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 12;
            // 
            // chkMasculino
            // 
            chkMasculino.AutoSize = true;
            chkMasculino.Location = new Point(20, 22);
            chkMasculino.Name = "chkMasculino";
            chkMasculino.Size = new Size(81, 19);
            chkMasculino.TabIndex = 13;
            chkMasculino.Text = "Masculino";
            chkMasculino.UseVisualStyleBackColor = true;
            chkMasculino.MouseClick += chkMasculino_MouseClick;
            // 
            // gbSexo
            // 
            gbSexo.Controls.Add(chkFemenino);
            gbSexo.Controls.Add(chkMasculino);
            gbSexo.Location = new Point(24, 318);
            gbSexo.Name = "gbSexo";
            gbSexo.Size = new Size(200, 54);
            gbSexo.TabIndex = 14;
            gbSexo.TabStop = false;
            gbSexo.Text = "Sexo";
            // 
            // chkFemenino
            // 
            chkFemenino.AutoSize = true;
            chkFemenino.Location = new Point(109, 22);
            chkFemenino.Name = "chkFemenino";
            chkFemenino.Size = new Size(79, 19);
            chkFemenino.TabIndex = 14;
            chkFemenino.Text = "Femenino";
            chkFemenino.UseVisualStyleBackColor = true;
            chkFemenino.MouseClick += chkFemenino_MouseClick;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(94, 205);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(217, 23);
            txtDireccion.TabIndex = 15;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(24, 276);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(215, 23);
            dtFecha.TabIndex = 16;
            dtFecha.Value = new DateTime(2024, 8, 20, 0, 0, 0, 0);
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(628, 29);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(628, 70);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(628, 109);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(628, 143);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLimpiarPaciente);
            groupBox2.Controls.Add(btnEliminarPaciente);
            groupBox2.Controls.Add(btnEditarPaciente);
            groupBox2.Controls.Add(btnGuardarPaciente);
            groupBox2.Controls.Add(txtCedula);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(btnLimpiar);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dtFecha);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtDireccion);
            groupBox2.Controls.Add(gbSexo);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtTelefono);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(928, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 479);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de Pacientes";
            // 
            // btnLimpiarPaciente
            // 
            btnLimpiarPaciente.Location = new Point(136, 434);
            btnLimpiarPaciente.Name = "btnLimpiarPaciente";
            btnLimpiarPaciente.Size = new Size(93, 39);
            btnLimpiarPaciente.TabIndex = 25;
            btnLimpiarPaciente.Text = "Limpiar";
            btnLimpiarPaciente.UseVisualStyleBackColor = true;
            btnLimpiarPaciente.Click += btnLimpiarPaciente_Click;
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.Location = new Point(250, 388);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(93, 39);
            btnEliminarPaciente.TabIndex = 24;
            btnEliminarPaciente.Text = "Eliminar";
            btnEliminarPaciente.UseVisualStyleBackColor = true;
            btnEliminarPaciente.Click += btnEliminarPaciente_Click;
            // 
            // btnEditarPaciente
            // 
            btnEditarPaciente.Location = new Point(136, 388);
            btnEditarPaciente.Name = "btnEditarPaciente";
            btnEditarPaciente.Size = new Size(93, 39);
            btnEditarPaciente.TabIndex = 23;
            btnEditarPaciente.Text = "Editar";
            btnEditarPaciente.UseVisualStyleBackColor = true;
            btnEditarPaciente.Visible = false;
            btnEditarPaciente.Click += btnEditarPaciente_Click;
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.Location = new Point(24, 388);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new Size(93, 39);
            btnGuardarPaciente.TabIndex = 22;
            btnGuardarPaciente.Text = "Guardar";
            btnGuardarPaciente.UseVisualStyleBackColor = true;
            btnGuardarPaciente.Click += btnGuardarPaciente_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(81, 108);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(130, 23);
            txtCedula.TabIndex = 21;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBuscarCedula);
            groupBox3.Controls.Add(txtBuscarNombre);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(32, 55);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1254, 95);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Métodos de Búsqueda";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(708, 35);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(370, 25);
            txtBuscarNombre.TabIndex = 3;
            txtBuscarNombre.TextChanged += txtBuscarNombre_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(625, 41);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 1;
            label10.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 41);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 0;
            label9.Text = "Cédula:";
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 686);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(migrid);
            Name = "FrmPacientes";
            Text = "Información de Pacientes";
            Load += FrmPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)migrid).EndInit();
            gbSexo.ResumeLayout(false);
            gbSexo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView migrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox chkMasculino;
        private GroupBox gbSexo;
        private CheckBox chkFemenino;
        private TextBox txtDireccion;
        private DateTimePicker dtFecha;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label10;
        private Label label9;
        private TextBox txtBuscarNombre;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox txtBuscarCedula;
        private MaskedTextBox txtCedula;
        private Button btnEditarPaciente;
        private Button btnGuardarPaciente;
        private Button btnEliminarPaciente;
        private Button btnLimpiarPaciente;
    }
}