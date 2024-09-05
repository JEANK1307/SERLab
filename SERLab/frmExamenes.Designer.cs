namespace SERLab
{
    partial class frmExamenes
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
            groupBox1 = new GroupBox();
            txtBuscarNombre = new TextBox();
            txtBuscarCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            groupBox2 = new GroupBox();
            Guardar = new Button();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            cmbTipo = new ComboBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnEdi = new Button();
            ((System.ComponentModel.ISupportInitialize)migrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // migrid
            // 
            migrid.AllowUserToAddRows = false;
            migrid.AllowUserToDeleteRows = false;
            migrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            migrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            migrid.Location = new Point(154, 396);
            migrid.Name = "migrid";
            migrid.ReadOnly = true;
            migrid.RowTemplate.Height = 25;
            migrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            migrid.Size = new Size(989, 347);
            migrid.TabIndex = 0;
            migrid.CellMouseClick += migrid_CellMouseClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBuscarNombre);
            groupBox1.Controls.Add(txtBuscarCodigo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(154, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(989, 92);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Métodos de Búsqueda";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(699, 41);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(244, 25);
            txtBuscarNombre.TabIndex = 4;
            txtBuscarNombre.TextChanged += txtBuscarNombre_TextChanged;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(202, 41);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(244, 25);
            txtBuscarCodigo.TabIndex = 2;
            txtBuscarCodigo.TextChanged += txtBuscarCodigo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(520, 44);
            label2.Name = "label2";
            label2.Size = new Size(151, 18);
            label2.TabIndex = 3;
            label2.Text = "Buscar Por Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 44);
            label1.Name = "label1";
            label1.Size = new Size(146, 18);
            label1.TabIndex = 2;
            label1.Text = "Buscar Por Código:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(154, 759);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(123, 57);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Seleccionar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(974, 759);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 57);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(Guardar);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(txtDescripcion);
            groupBox2.Controls.Add(cmbTipo);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(154, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(989, 232);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nuevo Análisis ";
            // 
            // Guardar
            // 
            Guardar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Guardar.Location = new Point(425, 176);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(110, 38);
            Guardar.TabIndex = 10;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(671, 128);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(226, 26);
            txtPrecio.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(671, 51);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(226, 26);
            txtDescripcion.TabIndex = 8;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(127, 127);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(225, 27);
            cmbTipo.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 26);
            txtNombre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 132);
            label5.Name = "label5";
            label5.Size = new Size(44, 18);
            label5.TabIndex = 5;
            label5.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(571, 56);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
            label4.TabIndex = 4;
            label4.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(571, 133);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 3;
            label3.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(591, 130);
            label6.Name = "label6";
            label6.Size = new Size(0, 19);
            label6.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(35, 56);
            label7.Name = "label7";
            label7.Size = new Size(68, 18);
            label7.TabIndex = 1;
            label7.Text = "Nombre:";
            // 
            // btnEdi
            // 
            btnEdi.Location = new Point(579, 759);
            btnEdi.Name = "btnEdi";
            btnEdi.Size = new Size(123, 57);
            btnEdi.TabIndex = 6;
            btnEdi.Text = "Editar";
            btnEdi.UseVisualStyleBackColor = true;
            // 
            // frmExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 844);
            Controls.Add(btnEdi);
            Controls.Add(groupBox2);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(groupBox1);
            Controls.Add(migrid);
            Name = "frmExamenes";
            Text = "Mantenimiento Análisis";
            Load += frmAnalisis_Load;
            ((System.ComponentModel.ISupportInitialize)migrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtBuscarNombre;
        private TextBox txtBuscarCodigo;
        private DataGridView migrid;
        private Button btnEditar;
        private Button btnEliminar;
        private GroupBox groupBox2;
        private Button Guardar;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private ComboBox cmbTipo;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Button btnEdi;
    }
}