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
using ProyectoLoboSostenido;

namespace NewReportesControlEscolar
{
    public partial class Principal : Form
        

    {
        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        public Principal()
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

        private void button1_Click(object sender, EventArgs e)
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

        private void btnInformación(object sender, EventArgs e)
        {
            DatosReportes ARR = new DatosReportes();
            ARR.Show();
        }

        private void btnAsignarParametros(object sender, EventArgs e)
        {
            RelacionParametrosReporte ARR = new RelacionParametrosReporte();
            ARR.Show();
        }

        private void btnRelacionReportes(object sender, EventArgs e)
        {
            RelacionReportes ARR = new RelacionReportes();
            ARR.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnactualizar_Click_1(object sender, EventArgs e)
        {
            Clase_Sesion.IDEmpleado = textBox1.Text;
            Clase_Sesion.Campus = textBox2.Text;
            Clase_Sesion.Rol = textBox3.Text;
            FrmReportesControlEscolar rce = new FrmReportesControlEscolar();
            rce.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmAdministrarParametrosRCE ARR = new FrmAdministrarParametrosRCE();
            ARR.Show();
        }
    }
}
