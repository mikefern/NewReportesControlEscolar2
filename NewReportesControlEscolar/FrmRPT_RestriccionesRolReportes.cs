using ProyectoLoboSostenido;
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

namespace NewReportesControlEscolar
{
    public partial class FrmRPT_RestriccionesRolReportes : Form
    {
        public FrmRPT_RestriccionesRolReportes()
        {
            InitializeComponent();
        }

        private Clase_ReportesCE p;
        Clase_ReportesGenericos gn = new Clase_ReportesGenericos();

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

        private void cbCampus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCampus.SelectedValue != null)
            {
                GetUsuarios(cbCampus.SelectedValue.ToString());
                cbUsuarios.Enabled = true;
                lvReportes.Enabled = false;
            }
        }

        private void FrmRestriccionesRolesReportes_Load(object sender, EventArgs e)
        {
            getCampus();
            cargarReportes();
        }

        private void getCampus()
        {
            Clase_ReportesCE ur = new Clase_ReportesCE();
            ur.GetCampus();
            cbCampus.DataSource = ur.Lector.Tables[0];
            cbCampus.DisplayMember = "Campus";
            cbCampus.ValueMember = "ID_Campus";
            cbCampus.SelectedItem = null;
        }
        private void cargarReportes()
        {
            Clase_ReportesCE pr = new Clase_ReportesCE();
            pr.GetReportesTodos();
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
                gn.llenarlistview(lvReportes, dt);
            }
        }

        private void cbUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbUsuarios.SelectedValue != null)
                {
                    lvReportes.Enabled = true;
                    p = new Clase_ReportesCE();
                    if (p.GetRestriccionesReportesEmpleado(cbUsuarios.SelectedValue.ToString()))
                    {
                        DataView dt = new DataView(p.Lector.Tables[0]);
                        gn.marcarnodos(lvReportes, dt);
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GetUsuarios(string campus)
        {
            try
            {
                Clase_ReportesCE ur = new Clase_ReportesCE();
                ur.GetUsuarios(campus);
                cbUsuarios.DataSource = ur.Lector.Tables[0];
                cbUsuarios.DisplayMember = "Usuario";
                cbUsuarios.ValueMember = "ID_Empleado";
                cbUsuarios.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Clase_ReportesCE pr = new Clase_ReportesCE();
                string empleado = cbUsuarios.SelectedValue.ToString();
                for (int i = 0; i < lvReportes.Items.Count; i++)
                {
                    string reporte = lvReportes.Items[i].Text;
                    if (lvReportes.Items[i].Checked == true)
                    {
                        DataView dv = new DataView(p.Lector.Tables[0]);
                        if (gn.checarPermiso(dv, Convert.ToInt32(reporte)))
                            pr.AgregarRestriccionesReportesEmpleado(reporte, empleado);
                    }
                    else
                        pr.EliminarRestriccionesReportesEmpleado(reporte, empleado);
                }
                MessageBox.Show("Se han guardado las restricciones al usuario ", "Completado", MessageBoxButtons.OK);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
