using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewReportesControlEscolar2
{
    public partial class Form1 : Form

    {
        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Clase_Sesion.IDEmpleado = textBox1.Text;
            Clase_Sesion.Campus = textBox2.Text;
            Clase_Sesion.Rol = textBox3.Text;
            FrmReportesControlEscolar fr = new FrmReportesControlEscolar();
            fr.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FrmAniadirEspecifiacionesReporte fa = new FrmAniadirEspecifiacionesReporte();
            fa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRPTPermisosRol pr = new FrmRPTPermisosRol();
            pr.Show();
        }

        private void btn_Restricciones_Click(object sender, EventArgs e)
        {
            FrmAgregarRestriccionesReportesRol ARR = new FrmAgregarRestriccionesReportesRol();
            ARR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clase_Sesion.IDEmpleado = textBox1.Text;
            Clase_Sesion.Campus = textBox2.Text;
            Clase_Sesion.Rol = textBox3.Text;
            FrmGestionNodos frmGestionNodos = new FrmGestionNodos();
            frmGestionNodos.Show();
        }
    }
}
