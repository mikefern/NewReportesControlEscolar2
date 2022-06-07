using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLoboSostenido;
using System.Runtime.InteropServices;

namespace NewReportesControlEscolar
{
    public partial class Nodos2 : Form
    {
        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Nodos2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        public Nodos2()
        {
            InitializeComponent();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Clase_Sesion.IDEmpleado = txtUsuario.Text;
            Clase_Sesion.Campus = txtCampus.Text;
            Clase_Sesion.Rol = txtRol.Text;
            FrmReportesControlEscolar fr = new FrmReportesControlEscolar();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReportesLimitarNodos rl = new FrmReportesLimitarNodos();
            rl.Show();
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

        private void button9_Click(object sender, EventArgs e)
        {
            DatosReportes FrmNuevoUs = new DatosReportes();
            FrmNuevoUs.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Form1 FrmNuevoUs = new Form1();
            //FrmNuevoUs.Show();
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            RelacionParametrosReporte FrmNuevoUs = new RelacionParametrosReporte();
            FrmNuevoUs.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            RelacionReportes FrmNuevoUs = new RelacionReportes();
            FrmNuevoUs.Show();
        }
    }
}
