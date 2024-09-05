namespace SERLab
{
    partial class FrmVerResultados
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
            miGridResultados = new DataGridView();
            miGridDetalles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)miGridResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miGridDetalles).BeginInit();
            SuspendLayout();
            // 
            // miGridResultados
            // 
            miGridResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miGridResultados.Location = new Point(12, 24);
            miGridResultados.Name = "miGridResultados";
            miGridResultados.RowTemplate.Height = 25;
            miGridResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            miGridResultados.Size = new Size(751, 150);
            miGridResultados.TabIndex = 0;
            miGridResultados.CellMouseClick += miGridResultados_CellMouseClick;
            // 
            // miGridDetalles
            // 
            miGridDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miGridDetalles.Location = new Point(12, 245);
            miGridDetalles.Name = "miGridDetalles";
            miGridDetalles.RowTemplate.Height = 25;
            miGridDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            miGridDetalles.Size = new Size(751, 150);
            miGridDetalles.TabIndex = 1;
            // 
            // FrmVerResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 430);
            Controls.Add(miGridDetalles);
            Controls.Add(miGridResultados);
            Name = "FrmVerResultados";
            Text = "FrmVerResultados";
            Load += FrmVerResultados_Load;
            ((System.ComponentModel.ISupportInitialize)miGridResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)miGridDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView miGridResultados;
        private DataGridView miGridDetalles;
    }
}