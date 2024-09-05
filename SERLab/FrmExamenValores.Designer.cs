namespace SERLab
{
    partial class FrmExamenValores
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
            miGrid1 = new DataGridView();
            miGrid2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)miGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miGrid2).BeginInit();
            SuspendLayout();
            // 
            // miGrid1
            // 
            miGrid1.AllowUserToAddRows = false;
            miGrid1.AllowUserToDeleteRows = false;
            miGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            miGrid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            miGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miGrid1.Location = new Point(12, 12);
            miGrid1.Name = "miGrid1";
            miGrid1.RowTemplate.Height = 25;
            miGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            miGrid1.Size = new Size(865, 184);
            miGrid1.TabIndex = 0;
            miGrid1.CellMouseClick += miGrid1_CellMouseClick;
            miGrid1.CellMouseDoubleClick += miGrid1_CellMouseDoubleClick;
            // 
            // miGrid2
            // 
            miGrid2.AllowUserToAddRows = false;
            miGrid2.AllowUserToDeleteRows = false;
            miGrid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            miGrid2.Location = new Point(12, 254);
            miGrid2.Name = "miGrid2";
            miGrid2.RowTemplate.Height = 25;
            miGrid2.Size = new Size(865, 184);
            miGrid2.TabIndex = 1;
            // 
            // FrmExamenValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 450);
            Controls.Add(miGrid2);
            Controls.Add(miGrid1);
            Name = "FrmExamenValores";
            Text = "FrmExamenValores";
            Load += FrmExamenValores_Load;
            ((System.ComponentModel.ISupportInitialize)miGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)miGrid2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView miGrid1;
        private DataGridView miGrid2;
    }
}