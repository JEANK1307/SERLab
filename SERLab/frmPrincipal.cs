using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SERLab
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedicos medicos = new frmMedicos();
            medicos.ShowDialog();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            FrmPacientes pacientes = new FrmPacientes();
            pacientes.ShowDialog();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            frmExamenes analisis = new frmExamenes();
            analisis.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVerResultados resultados = new FrmVerResultados();
            resultados.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmResultado resultado = new FrmResultado();
            resultado.ShowDialog();
        }
    }
}
