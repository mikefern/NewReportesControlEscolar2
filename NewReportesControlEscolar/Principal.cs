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

namespace NewReportesControlEscolar
{
    public partial class Principal : Form
    {
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
    }
}
