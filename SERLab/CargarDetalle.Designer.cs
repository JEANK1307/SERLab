namespace SERLab
{
    partial class CargarDetalle
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
            miGridResultado = new DataGridView();
            miGridDetalles = new DataGridView();
            btnExportarPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)miGridResultado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miGridDetalles).BeginInit();
            SuspendLayout();
            // 
            // miGridResultado
            // 
            miGridResultado.AllowUserToAddRows = false;
            miGridResultado.AllowUserToDeleteRows = false;
            miGridResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miGridResultado.Location = new Point(12, 21);
            miGridResultado.Name = "miGridResultado";
            miGridResultado.RowTemplate.Height = 25;
            miGridResultado.Size = new Size(776, 150);
            miGridResultado.TabIndex = 0;
            // 
            // miGridDetalles
            // 
            miGridDetalles.AllowUserToAddRows = false;
            miGridDetalles.AllowUserToDeleteRows = false;
            miGridDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miGridDetalles.Location = new Point(12, 237);
            miGridDetalles.Name = "miGridDetalles";
            miGridDetalles.RowTemplate.Height = 25;
            miGridDetalles.Size = new Size(776, 150);
            miGridDetalles.TabIndex = 1;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportarPDF.Location = new Point(305, 411);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(166, 39);
            btnExportarPDF.TabIndex = 2;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // CargarDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(btnExportarPDF);
            Controls.Add(miGridDetalles);
            Controls.Add(miGridResultado);
            Name = "CargarDetalle";
            Text = "CargarDetalle";
            Load += CargarDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)miGridResultado).EndInit();
            ((System.ComponentModel.ISupportInitialize)miGridDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView miGridResultado;
        private DataGridView miGridDetalles;
        private Button btnExportarPDF;
    }
}