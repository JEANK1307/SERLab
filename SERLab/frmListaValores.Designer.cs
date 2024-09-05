namespace SERLab
{
    partial class frmListaValores
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
            groupBox1 = new GroupBox();
            txtBuscarNombre = new TextBox();
            txtBuscarCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            migridHijo = new DataGridView();
            btnConfirmar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)migridHijo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBuscarNombre);
            groupBox1.Controls.Add(txtBuscarCodigo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(migridHijo);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(27, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(836, 455);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccione los Valores que Desea Agregar";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(602, 46);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(211, 26);
            txtBuscarNombre.TabIndex = 4;
            txtBuscarNombre.TextChanged += txtBuscarNombre_TextChanged;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(183, 46);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(211, 26);
            txtBuscarCodigo.TabIndex = 3;
            txtBuscarCodigo.TextChanged += txtBuscarCodigo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(436, 49);
            label2.Name = "label2";
            label2.Size = new Size(150, 18);
            label2.TabIndex = 2;
            label2.Text = "Buscar Por Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 49);
            label1.Name = "label1";
            label1.Size = new Size(146, 18);
            label1.TabIndex = 1;
            label1.Text = "Buscar Por Código:";
            // 
            // migridHijo
            // 
            migridHijo.AllowUserToAddRows = false;
            migridHijo.AllowUserToDeleteRows = false;
            migridHijo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            migridHijo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            migridHijo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            migridHijo.ImeMode = ImeMode.On;
            migridHijo.Location = new Point(21, 101);
            migridHijo.Name = "migridHijo";
            migridHijo.ReadOnly = true;
            migridHijo.RowTemplate.Height = 25;
            migridHijo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            migridHijo.Size = new Size(792, 334);
            migridHijo.TabIndex = 0;
            migridHijo.DoubleClick += migrid_DoubleClick;
            migridHijo.MouseClick += migridHijo_MouseClick;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(388, 512);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(108, 35);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // frmListaValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 583);
            Controls.Add(btnConfirmar);
            Controls.Add(groupBox1);
            Name = "frmListaValores";
            Text = "Lista de Valores";
            Load += frmListaValores_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)migridHijo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView midatagrid;
        private Label label2;
        private Label label1;
        private TextBox txtBuscarNombre;
        private TextBox txtBuscarCodigo;
        private Button btnConfirmar;
        public DataGridView migridHijo;
    }
}