using ProyectoLoboSostenido;
using System; 
using System.Data; 
using System.Runtime.InteropServices; 
using System.Windows.Forms;

namespace NewReportesControlEscolar
{
    public partial class FrmRPT_RestriccionesRolReportes : Form
    {
        #region VARIABLES
        Clase_ReportesCE ReportesCE;
        Clase_ReportesGenericos ReportesGenerico = new Clase_ReportesGenericos();
        #endregion
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
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
        #endregion

        public FrmRPT_RestriccionesRolReportes()
        {
            InitializeComponent();
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

        private void cbCampus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCampus.SelectedValue != null)
            {
                GetUsuarios(cbCampus.SelectedValue.ToString());
                cbUsuarios.Enabled = true;
                lvReportes.Enabled = false;
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
       
        private void cbUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbUsuarios.SelectedValue != null)
                {
                    lvReportes.Enabled = true;
                    ReportesCE = new Clase_ReportesCE();
                    if (ReportesCE.GetRestriccionesReportesEmpleado(cbUsuarios.SelectedValue.ToString()))
                    {
                        DataView dt = new DataView(ReportesCE.Lector.Tables[0]);
                        ReportesGenerico.marcarnodos(lvReportes, dt);
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargarReportes()
        {
            Clase_ReportesCE pr = new Clase_ReportesCE();
            pr.GetReportesTodos();
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
                ReportesGenerico.llenarlistview(lvReportes, dt);
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
                        DataView dv = new DataView(ReportesCE.Lector.Tables[0]);
                        if (ReportesGenerico.checarPermiso(dv, Convert.ToInt32(reporte)))
                            pr.AgregarRestriccionesReportesEmpleado("1",reporte, empleado);
                    }
                    else
                        pr.AgregarRestriccionesReportesEmpleado("2", reporte, empleado);
                }
                MessageBox.Show("Se han guardado las restricciones al usuario ", "Completado", MessageBoxButtons.OK);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
