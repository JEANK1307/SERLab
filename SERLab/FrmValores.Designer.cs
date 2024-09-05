namespace SERLab
{
    partial class FrmValores
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
            migridValores = new DataGridView();
            groupBox2 = new GroupBox();
            txtUnidad = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
            txtNombre = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            label6 = new Label();
            label4 = new Label();
            txtRango = new TextBox();
            ((System.ComponentModel.ISupportInitialize)migridValores).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // migridValores
            // 
            migridValores.AllowUserToAddRows = false;
            migridValores.AllowUserToDeleteRows = false;
            migridValores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            migridValores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            migridValores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            migridValores.Location = new Point(12, 12);
            migridValores.Name = "migridValores";
            migridValores.RowTemplate.Height = 25;
            migridValores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            migridValores.Size = new Size(986, 240);
            migridValores.TabIndex = 0;
            migridValores.CellMouseClick += migridValores_CellMouseClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtUnidad);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnLimpiar);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtRango);
            groupBox2.Location = new Point(88, 292);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(836, 200);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro Valores";
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(652, 73);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(116, 23);
            txtUnidad.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 76);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(686, 153);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 33);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(116, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(501, 153);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 33);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(293, 153);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 33);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(78, 153);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 33);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(573, 76);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 14;
            label6.Text = "Unidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 76);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 5;
            label4.Text = "Rango Referencia";
            // 
            // txtRango
            // 
            txtRango.Location = new Point(388, 73);
            txtRango.Name = "txtRango";
            txtRango.Size = new Size(116, 23);
            txtRango.TabIndex = 10;
            // 
            // FrmValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 552);
            Controls.Add(groupBox2);
            Controls.Add(migridValores);
            Name = "FrmValores";
            Text = "FrmValores";
            Load += FrmValores_Load;
            ((System.ComponentModel.ISupportInitialize)migridValores).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView migridValores;
        private GroupBox groupBox2;
        private Label label1;
        private Button btnLimpiar;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private Label label6;
        private Label label4;
        private TextBox txtRango;
        private TextBox txtUnidad;
    }
}