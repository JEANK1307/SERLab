namespace SERLab
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            barraTitulo = new Panel();
            btnMin = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            menuVertical = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            btnAnalisis = new Button();
            panel2 = new Panel();
            btnPaciente = new Button();
            panel1 = new Panel();
            btnMedicos = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            barraTitulo.Controls.Add(btnMin);
            barraTitulo.Controls.Add(btnMaximizar);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1201, 35);
            barraTitulo.TabIndex = 0;
            barraTitulo.MouseDown += barraTitulo_MouseDown;
            // 
            // btnMin
            // 
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(1111, 3);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(25, 25);
            btnMin.SizeMode = PictureBoxSizeMode.Zoom;
            btnMin.TabIndex = 2;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1142, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1173, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.FromArgb(26, 32, 40);
            menuVertical.Controls.Add(panel5);
            menuVertical.Controls.Add(button1);
            menuVertical.Controls.Add(panel4);
            menuVertical.Controls.Add(button4);
            menuVertical.Controls.Add(panel3);
            menuVertical.Controls.Add(btnAnalisis);
            menuVertical.Controls.Add(panel2);
            menuVertical.Controls.Add(btnPaciente);
            menuVertical.Controls.Add(panel1);
            menuVertical.Controls.Add(btnMedicos);
            menuVertical.Controls.Add(pictureBox1);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 35);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(252, 613);
            menuVertical.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(0, 388);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 43);
            panel5.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 387);
            button1.Name = "button1";
            button1.Size = new Size(240, 42);
            button1.TabIndex = 9;
            button1.Text = "Ver Resultados";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 339);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 43);
            panel4.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(26, 32, 40);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(9, 339);
            button4.Name = "button4";
            button4.Size = new Size(240, 42);
            button4.TabIndex = 7;
            button4.Text = "Crear Resultado";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(2, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 43);
            panel3.TabIndex = 6;
            // 
            // btnAnalisis
            // 
            btnAnalisis.BackColor = Color.FromArgb(26, 32, 40);
            btnAnalisis.FlatAppearance.BorderSize = 0;
            btnAnalisis.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAnalisis.FlatStyle = FlatStyle.Flat;
            btnAnalisis.ForeColor = Color.White;
            btnAnalisis.Location = new Point(11, 290);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(240, 42);
            btnAnalisis.TabIndex = 5;
            btnAnalisis.Text = "Análisis";
            btnAnalisis.UseVisualStyleBackColor = false;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(2, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 43);
            panel2.TabIndex = 4;
            // 
            // btnPaciente
            // 
            btnPaciente.BackColor = Color.FromArgb(26, 32, 40);
            btnPaciente.FlatAppearance.BorderSize = 0;
            btnPaciente.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnPaciente.FlatStyle = FlatStyle.Flat;
            btnPaciente.ForeColor = Color.White;
            btnPaciente.Location = new Point(11, 241);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(240, 42);
            btnPaciente.TabIndex = 3;
            btnPaciente.Text = "Pacientes";
            btnPaciente.UseVisualStyleBackColor = false;
            btnPaciente.Click += btnPaciente_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(3, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 43);
            panel1.TabIndex = 2;
            // 
            // btnMedicos
            // 
            btnMedicos.BackColor = Color.FromArgb(26, 32, 40);
            btnMedicos.FlatAppearance.BorderSize = 0;
            btnMedicos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnMedicos.FlatStyle = FlatStyle.Flat;
            btnMedicos.ForeColor = Color.White;
            btnMedicos.Location = new Point(12, 193);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Size = new Size(240, 42);
            btnMedicos.TabIndex = 1;
            btnMedicos.Text = "Médicos";
            btnMedicos.UseVisualStyleBackColor = false;
            btnMedicos.Click += btnMedicos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(252, 35);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(949, 613);
            panelContenedor.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 648);
            Controls.Add(panelContenedor);
            Controls.Add(menuVertical);
            Controls.Add(barraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel barraTitulo;
        private Panel menuVertical;
        private Panel panelContenedor;
        private PictureBox btnCerrar;
        private PictureBox btnMin;
        private PictureBox btnMaximizar;
        private Button btnMedicos;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel4;
        private Button button4;
        private Panel panel3;
        private Button btnAnalisis;
        private Panel panel2;
        private Button btnPaciente;
        private Panel panel5;
        private Button button1;
    }
}