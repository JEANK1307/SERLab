namespace SERLab
{
    partial class FrmResultado
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
            cmbMedico = new ComboBox();
            groupBox2 = new GroupBox();
            cmbPaciente = new ComboBox();
            groupBox3 = new GroupBox();
            txtObservacion = new RichTextBox();
            btnContinuar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbMedico);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medico";
            // 
            // cmbMedico
            // 
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(6, 22);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(258, 23);
            cmbMedico.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbPaciente);
            groupBox2.Location = new Point(417, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 61);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Paciente";
            // 
            // cmbPaciente
            // 
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(22, 22);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(258, 23);
            cmbPaciente.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtObservacion);
            groupBox3.Location = new Point(12, 167);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(691, 131);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Observacion";
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(17, 22);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(668, 96);
            txtObservacion.TabIndex = 0;
            txtObservacion.Text = "";
            // 
            // btnContinuar
            // 
            btnContinuar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.Location = new Point(30, 350);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(149, 42);
            btnContinuar.TabIndex = 3;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(531, 350);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 42);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmResultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 404);
            Controls.Add(btnCancelar);
            Controls.Add(btnContinuar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmResultado";
            Text = "FrmResultado";
            Load += FrmResultado_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbMedico;
        private GroupBox groupBox2;
        private ComboBox cmbPaciente;
        private GroupBox groupBox3;
        private RichTextBox txtObservacion;
        private Button btnContinuar;
        private Button btnCancelar;
    }
}