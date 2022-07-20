using System;
using System.Runtime.InteropServices; 
using System.Windows.Forms;
using ProyectoLoboSostenido;

namespace NewReportesControlEscolar
{
    public partial class FrmRPT_Principal_RCE : Form
    {
        #region MoverFORM 
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

        public FrmRPT_Principal_RCE()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
           
                Clase_Campus clase_Campus = new Clase_Campus();
                clase_Campus.ConsultaComboCampus();
                CB_Campus.DataSource = clase_Campus.Lector.Tables[0];
                CB_Campus.DisplayMember = "Campus_Numero";
                CB_Campus.ValueMember = "ID_Campus";
                //---------------------------------------
                Clase_ReportesCE clase_ReportesCE = new Clase_ReportesCE();
                clase_ReportesCE.GetRoles();
                CB_Roles.DataSource = clase_ReportesCE.Lector.Tables[0];
                CB_Roles.DisplayMember = "Nombre_ID";
                CB_Roles.ValueMember = "ID_Rol";
            
               
        }

        private void btn1_ControlNodos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRPT_ControlNodos"] == null)
            {
                Clase_Sesion.IDEmpleado = txt_Usuario.Text;
                Clase_Sesion.Campus = CB_Campus.Text.Length > 1 ? (CB_Campus.SelectedValue == null ? CB_Campus.Text : CB_Campus.SelectedValue.ToString()) : Clase_Sesion.Campus = CB_Campus.Text.Length > 1 ? (CB_Campus.SelectedValue == null ? CB_Campus.Text : CB_Campus.SelectedValue.ToString()) : CB_Campus.Text.Length == 0 ? "01" : "0" + Int32.Parse(CB_Campus.Text);
                Clase_Sesion.Rol = CB_Roles.Text.Length > 1 ? (CB_Roles.SelectedValue == null ? CB_Roles.Text : CB_Roles.SelectedValue.ToString()) : Clase_Sesion.Campus = CB_Roles.Text.Length > 1 ? (CB_Roles.SelectedValue == null ? CB_Roles.Text : CB_Roles.SelectedValue.ToString()) : CB_Roles.Text.Length == 0 ? "01" : "0" + Int32.Parse(CB_Roles.Text);
                FrmRPT_ControlNodos frmGestionNodos = new FrmRPT_ControlNodos();
                frmGestionNodos.Show();
            }
            else
            {
                Application.OpenForms["FrmRPT_ControlNodos"].Show();
                Application.OpenForms["FrmRPT_ControlNodos"].BringToFront();
            }
            
                
        }

        private void btn2_GestionReportes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRPT_AsignacionCampusReportes"] == null)
            {
                FrmRPT_AsignacionCampusReportes frmAniadirEspecifiacionesReporte = new FrmRPT_AsignacionCampusReportes();
                frmAniadirEspecifiacionesReporte.Show();
            }
            else
            {
                Application.OpenForms["FrmRPT_AsignacionCampusReportes"].Show();
                Application.OpenForms["FrmRPT_AsignacionCampusReportes"].BringToFront();
            }
                
        }

        private void btn3_ControlArchivos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRPT_ArchivosReportes"] == null)
            {
                Clase_Sesion.IDEmpleado = txt_Usuario.Text;
                FrmRPT_ArchivosReportes frmArchivos = new FrmRPT_ArchivosReportes();
                frmArchivos.Show();
            }
            else
            {
                Application.OpenForms["FrmRPT_ArchivosReportes"].Show();
                Application.OpenForms["FrmRPT_ArchivosReportes"].BringToFront();
            }
                
        }

        private void btn4_AsignacionParametros_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRPT_AsignacionParametrosReporte"] == null)
            {
                FrmRPT_AsignacionParametrosReporte relacionParametros = new FrmRPT_AsignacionParametrosReporte();
                relacionParametros.Show();
            }
            else
            {
                Application.OpenForms["FrmRPT_AsignacionParametrosReporte"].Show();
                Application.OpenForms["FrmRPT_AsignacionParametrosReporte"].BringToFront();
            }
                
        }

        private void btn5_AsignacionBotones_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRPT_PermisosBotonReportes"] == null)
            {
                FrmRPT_PermisosBotonReportes frmRPTPermisosRol = new FrmRPT_PermisosBotonReportes();
                frmRPTPermisosRol.Show();
            }
            else
            {
                Application.OpenForms["FrmRPT_PermisosBotonReportes"].Show();
                Application.OpenForms["FrmRPT_PermisosBotonReportes"].BringToFront();
            }
                
        }

        private void btn6_RestriccionesUsuarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRPT_RestriccionesRolReportes"] == null)
            {
                FrmRPT_RestriccionesRolReportes frmRestriccionesRolesReportes = new FrmRPT_RestriccionesRolReportes();
                frmRestriccionesRolesReportes.Show();
            }
            else
            {
                Application.OpenForms["FrmRPT_RestriccionesRolReportes"].Show();
                Application.OpenForms["FrmRPT_RestriccionesRolReportes"].BringToFront();
            }
                
        }

        private void btn7_RelacionIDReportes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRPT_RelacionarReportes"] == null)
            {
                FrmRPT_RelacionarReportes relacionReportes = new FrmRPT_RelacionarReportes();
                relacionReportes.Show();
            }
            else
            {
                Application.OpenForms["FrmRPT_RelacionarReportes"].Show();
                Application.OpenForms["FrmRPT_RelacionarReportes"].BringToFront();
            }
            
        }

        private void btn8_NuevosParametros_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRPT_AddParametrosRCE"] == null)
            {
                FrmRPT_AddParametrosRCE frmAdministrarParametrosRCE = new FrmRPT_AddParametrosRCE();
                frmAdministrarParametrosRCE.Show();
            }
            else 
            {
                Application.OpenForms["FrmRPT_AddParametrosRCE"].Show();
                Application.OpenForms["FrmRPT_AddParametrosRCE"].BringToFront();
            }

            
        }

        private void btn9_RelacionNodoReporte_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRPT_EnlazarReporteNodos"] == null)
            {

                FrmRPT_EnlazarReporteNodos frmEnlazarReportesNodos = new FrmRPT_EnlazarReporteNodos();
                frmEnlazarReportesNodos.Show();
            }
            else
            {
                Application.OpenForms["FrmRPT_EnlazarReporteNodos"].Show();
                Application.OpenForms["FrmRPT_EnlazarReporteNodos"].BringToFront();
            }
        }

        private void PB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reporteador_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmReportesControlEscolar"] == null)
            {
                Clase_Sesion.IDEmpleado = txt_Usuario.Text;
                Clase_Sesion.Campus = CB_Campus.Text.Length > 1 ? (CB_Campus.SelectedValue == null ? CB_Campus.Text : CB_Campus.SelectedValue.ToString()) : Clase_Sesion.Campus = CB_Campus.Text.Length > 1 ? (CB_Campus.SelectedValue == null ? CB_Campus.Text : CB_Campus.SelectedValue.ToString()) : CB_Campus.Text.Length == 0 ? "01" : "0" + Int32.Parse(CB_Campus.Text);
                Clase_Sesion.Rol = CB_Roles.Text.Length > 1 ? (CB_Roles.SelectedValue == null ? CB_Roles.Text : CB_Roles.SelectedValue.ToString()) : Clase_Sesion.Campus = CB_Roles.Text.Length > 1 ? (CB_Roles.SelectedValue == null ? CB_Roles.Text : CB_Roles.SelectedValue.ToString()) : CB_Roles.Text.Length == 0 ? "01" : "0" + Int32.Parse(CB_Roles.Text);
                FrmReportesControlEscolar frmReportesControlEscolar = new FrmReportesControlEscolar();
                frmReportesControlEscolar.Show();
            }
            else
            {
                Application.OpenForms["FrmReportesControlEscolar"].Show();
                Application.OpenForms["FrmReportesControlEscolar"].BringToFront();
            }
               
        }
         
        private void CB_Campus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void CB_Roles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

    }

        private void Restricciones_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAgregarRestriccionesReportesRol"] == null)
            {
                FrmAgregarRestriccionesReportesRol frmAgregarRestricciones = new FrmAgregarRestriccionesReportesRol();
                frmAgregarRestricciones.Show();
            }
            else
            {
                Application.OpenForms["FrmAgregarRestriccionesReportesRol"].Show();
                Application.OpenForms["FrmAgregarRestriccionesReportesRol"].BringToFront();
            }
                
        }

        private void btn_GestionRCE_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmRPT_ControlEscolarReports"] == null)
            {
                FrmRPT_ControlEscolarReports frmGestionarReportesControl = new FrmRPT_ControlEscolarReports();
                frmGestionarReportesControl.Show();
            }
            else
            {
                Application.OpenForms["FrmRPT_ControlEscolarReports"].Show();
                Application.OpenForms["FrmRPT_ControlEscolarReports"].BringToFront();
            }
        }
    }
}

