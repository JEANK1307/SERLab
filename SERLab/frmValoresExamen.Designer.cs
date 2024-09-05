namespace SERLab
{
    partial class frmValoresExamen
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
            btnListaValores = new Button();
            btnLimpiar = new Button();
            migrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Presencia = new DataGridViewTextBoxColumn();
            Aspecto = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Rango = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            btnAgregarExamen = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)migrid).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnListaValores
            // 
            btnListaValores.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnListaValores.Location = new Point(435, 480);
            btnListaValores.Name = "btnListaValores";
            btnListaValores.Size = new Size(110, 38);
            btnListaValores.TabIndex = 10;
            btnListaValores.Text = "Lista Valores";
            btnListaValores.UseVisualStyleBackColor = true;
            btnListaValores.Click += btnListaValores_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(772, 480);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 38);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // migrid
            // 
            migrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            migrid.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Presencia, Aspecto, Estado, Rango, Unidad, Eliminar });
            migrid.Location = new Point(22, 25);
            migrid.Name = "migrid";
            migrid.RowTemplate.Height = 25;
            migrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            migrid.Size = new Size(873, 299);
            migrid.TabIndex = 1;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Presencia
            // 
            Presencia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Presencia.HeaderText = "Presencia";
            Presencia.Name = "Presencia";
            // 
            // Aspecto
            // 
            Aspecto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aspecto.HeaderText = "Aspecto";
            Aspecto.Name = "Aspecto";
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // Rango
            // 
            Rango.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Rango.HeaderText = "Rango de Referencia";
            Rango.Name = "Rango";
            // 
            // Unidad
            // 
            Unidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Unidad.HeaderText = "Unidad";
            Unidad.Name = "Unidad";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            // 
            // btnAgregarExamen
            // 
            btnAgregarExamen.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarExamen.Location = new Point(141, 480);
            btnAgregarExamen.Name = "btnAgregarExamen";
            btnAgregarExamen.Size = new Size(110, 38);
            btnAgregarExamen.TabIndex = 12;
            btnAgregarExamen.Text = "Agregar";
            btnAgregarExamen.UseVisualStyleBackColor = true;
            btnAgregarExamen.Click += btnAgregarExamen_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(migrid);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(69, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(913, 343);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Valores Previos";
            // 
            // frmValoresExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 574);
            Controls.Add(btnListaValores);
            Controls.Add(groupBox2);
            Controls.Add(btnAgregarExamen);
            Controls.Add(btnLimpiar);
            Name = "frmValoresExamen";
            Text = "Valores de los Análisis ";
            Load += frmValoresExamen_Load;
            ((System.ComponentModel.ISupportInitialize)migrid).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnListaValores;
        private Button btnLimpiar;
        private Button btnAgregarExamen;
        private GroupBox groupBox2;
        public DataGridView migrid;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Presencia;
        private DataGridViewTextBoxColumn Aspecto;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Rango;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewImageColumn Eliminar;
    }
}