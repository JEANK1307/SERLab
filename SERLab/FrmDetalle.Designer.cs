namespace SERLab
{
    partial class FrmDetalle
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
            cmbExamen = new ComboBox();
            miGrid = new DataGridView();
            groupBox2 = new GroupBox();
            txtResultado = new RichTextBox();
            txtDescripcion = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            btnSiguiente = new Button();
            btnC = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)miGrid).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbExamen);
            groupBox1.Location = new Point(264, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Examen";
            // 
            // cmbExamen
            // 
            cmbExamen.FormattingEnabled = true;
            cmbExamen.Location = new Point(6, 37);
            cmbExamen.Name = "cmbExamen";
            cmbExamen.Size = new Size(246, 23);
            cmbExamen.TabIndex = 0;
            cmbExamen.SelectedIndexChanged += cmbExamen_SelectedIndexChanged;
            // 
            // miGrid
            // 
            miGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miGrid.Location = new Point(3, 129);
            miGrid.Name = "miGrid";
            miGrid.RowTemplate.Height = 25;
            miGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            miGrid.Size = new Size(785, 158);
            miGrid.TabIndex = 1;
            miGrid.CellMouseClick += miGrid_CellMouseClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtResultado);
            groupBox2.Controls.Add(txtDescripcion);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 124);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(540, 22);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(251, 96);
            txtResultado.TabIndex = 3;
            txtResultado.Text = "";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(141, 22);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(251, 96);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(412, 53);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 1;
            label2.Text = "Resultado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 0;
            label1.Text = "Descripcion:";
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiguiente.Location = new Point(18, 441);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(149, 42);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnC.Location = new Point(623, 441);
            btnC.Name = "btnC";
            btnC.Size = new Size(149, 42);
            btnC.TabIndex = 5;
            btnC.Text = "Cancelar";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(318, 441);
            button2.Name = "button2";
            button2.Size = new Size(149, 42);
            button2.TabIndex = 6;
            button2.Text = "Finalizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(button2);
            Controls.Add(btnC);
            Controls.Add(btnSiguiente);
            Controls.Add(groupBox2);
            Controls.Add(miGrid);
            Controls.Add(groupBox1);
            Name = "FrmDetalle";
            Text = "FrmDetalle";
            Load += FrmDetalle_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)miGrid).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbExamen;
        private DataGridView miGrid;
        private GroupBox groupBox2;
        private RichTextBox txtResultado;
        private RichTextBox txtDescripcion;
        private Label label2;
        private Label label1;
        private Button btnSiguiente;
        private Button btnC;
        private Button button2;
    }
}