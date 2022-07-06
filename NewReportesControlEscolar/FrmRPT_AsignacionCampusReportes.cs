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
    public partial class FrmRPT_AsignacionCampusReportes : Form

    {
        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region VARIABLES
        private Clase_ReportesCE clase_reportes;
            private Clase_ReportesCE ReportCE;
            private Clase_ReportesGenericos gn = new Clase_ReportesGenericos();
        #endregion

        public FrmRPT_AsignacionCampusReportes()
        {
            InitializeComponent();
        }

        private void FrmAniadirEspecifiacionesReporte_Load(object sender, EventArgs e)
        {
            gn.cargarCampus(lvCampus);
            gn.cargarRoles(lvRoles);
            cargarReportes();
            
        }

        private void cargarReportes()
        {
            clase_reportes = new Clase_ReportesCE();
            clase_reportes.GetReportesTodos();
            if (clase_reportes.Lector.Tables[0].Rows.Count > 0)
            {
              //  DataView dt = new DataView(clase_reportes.Lector.Tables[0]);
              //  gn.llenarlistview(lvReportes, dt);
                DGV_Reportes.DataSource = clase_reportes.Lector.Tables[0];

                DGV_Reportes.Columns[0].HeaderText = "ID"; 
               DGV_Reportes.AutoResizeColumns();
                DGV_Reportes.Columns[0].Width = 50;
            }
        }
         
        private void DGV_Reportes_SelectionChanged(object sender, EventArgs e)
        {
            if(DGV_Reportes.SelectedRows.Count > 0 )
            {
                lvCampus.Enabled = true;
                lvRVOE.Enabled = true;
                lvCampusEspecificos.Enabled = true;
                cargarCampusReportes(DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString());
                lvRVOE.Items.Clear();
                lvRoles.Enabled = false;
                btnGuardarRoles.Enabled = false;
                btnGuardarRVOE.Enabled = false;
                btnGuardarCampus.Enabled = true;
            }
        }

        private void cargarCampusReportes(string id)
        {
            lvCampusEspecificos.Items.Clear();
            clase_reportes = new Clase_ReportesCE();
            clase_reportes.GetCampusReportes(id);
            if (clase_reportes.Lector.Tables.Count > 0)
            {
                DataView dt1 = new DataView(clase_reportes.Lector.Tables[0]);
                gn.marcarnodos(lvCampus, dt1);
                gn.llenarlistview(lvCampusEspecificos, dt1);
            }
        }

        private void cargarRolesReportes(string id)
        {

            clase_reportes = new Clase_ReportesCE();
            if (clase_reportes.MostrarRelRolesReportes(id,lvCampusEspecificos.SelectedItems[0].SubItems[0].Text))
            {
                DataView dt = new DataView(clase_reportes.Lector.Tables[0]);
                gn.marcarnodos(lvRoles, dt);
            }
        }

        private void lvCampusEspecificos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (lvCampusEspecificos.SelectedItems.Count > 0)
                    cargarRVOE();
                lvRoles.Enabled = true;
                btnGuardarRoles.Enabled = true;
                btnGuardarRVOE.Enabled = true;
                 cargarRolesReportes(DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString());
                cargarRolesReportes(DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch
            {

            }
        }
        private void cargarRVOE()
        {
            clase_reportes = new Clase_ReportesCE();
            clase_reportes.MostrarRVOESCampusReportes(lvCampusEspecificos.SelectedItems[0].SubItems[0].Text);
            if (clase_reportes.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(clase_reportes.Lector.Tables[0]);
                gn.llenarlistview(lvRVOE, dt);
            }
            clase_reportes = new Clase_ReportesCE();
            if(clase_reportes.MostrarRVOECampusReporte(DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString(), lvCampusEspecificos.SelectedItems[0].SubItems[0].Text))
            {
                DataView dt = new DataView(clase_reportes.Lector.Tables[0]);
                gn.marcarnodos(lvRVOE, dt);

            }
        }

        private void btnGuardarCampus_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Reportes.SelectedRows[0] != null)
                {
                    ReportCE = new Clase_ReportesCE();
                    string id = DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString();
                    ReportCE.GetCampusReportes(id);
                    clase_reportes = new Clase_ReportesCE();

                    for (int i = 0; i < lvCampus.Items.Count; i++)
                    {
                        string reporte = DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString();
                        string campus = lvCampus.Items[i].Text;
                        if (lvCampus.Items[i].Checked == true)
                        {
                            DataView dv = new DataView(ReportCE.Lector.Tables[0]);
                            if (gn.checarPermiso(dv, Convert.ToInt32(campus)))
                                clase_reportes.AgregarRelCampusReporte("1",reporte, campus);
                        }
                        else
                            clase_reportes.AgregarRelCampusReporte("2",reporte, campus);

                    }
                    MessageBox.Show("Se han guardado los campus del reporte", "Completado", MessageBoxButtons.OK);
                    cargarCampusReportes(id);
                    lvRoles.Enabled = false;
                    btnGuardarRoles.Enabled = false;
                    btnGuardarRVOE.Enabled = false;
                }else MessageBox.Show("Selecciona un Reporte", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarRoles_Click(object sender, EventArgs e)
        {
            try
            {
                ReportCE = new Clase_ReportesCE();
                string id = lvCampusEspecificos.SelectedItems[0].SubItems[0].Text;
                string repo = DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString();
                ReportCE.MostrarRelRolesReportes(repo,id);
                clase_reportes = new Clase_ReportesCE();
                
                for(int i=0;i<lvRoles.Items.Count; i++)
                {

                    string rol = lvRoles.Items[i].Text;

                    if (Convert.ToInt32(rol) == 14 || Convert.ToInt32(rol) == 16)
                        lvRoles.Items[i].Checked = true;

                    if (lvRoles.Items[i].Checked == true)
                    {
                        DataView dv = new DataView(ReportCE.Lector.Tables[0]);
                        if (gn.checarPermiso(dv, Convert.ToInt32(rol)))
                            clase_reportes.AgregarRelRolesReportes("1",rol, id, repo);
                    }
                    else
                        clase_reportes.AgregarRelRolesReportes("2", rol, id, repo);
                }
                MessageBox.Show("Se han guardado los roles del reporte", "Completado", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarRVOE_Click(object sender, EventArgs e)
        {
            try
            {
                ReportCE = new Clase_ReportesCE();
                string id = DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString();
                string campus = lvCampusEspecificos.SelectedItems[0].SubItems[0].Text;
                ReportCE.MostrarRVOECampusReporte(id, campus);
                clase_reportes = new Clase_ReportesCE();

                for (int i = 0; i < lvRVOE.Items.Count; i++)
                {
                    string rvoe = lvRVOE.Items[i].Text;
                    if (lvRVOE.Items[i].Checked == true)
                    {
                        DataView dv = new DataView(ReportCE.Lector.Tables[0]);
                        if (gn.checarPermiso(dv, Convert.ToInt32(rvoe)))
                            clase_reportes.AgregarRVOEReportes("1",id, rvoe);
                    }
                    else
                        clase_reportes.AgregarRVOEReportes("2", id, rvoe);
                }
                MessageBox.Show("Se han guardado los RVOE del reporte", "Completado", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUsuariosReportesw_Click(object sender, EventArgs e)
        {
            FrmRPT_RestriccionesRolReportes rr = new FrmRPT_RestriccionesRolReportes();
            rr.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                (DGV_Reportes.DataSource as DataTable).DefaultView.RowFilter = string.Format("NombreReporte LIKE '%{0}%'", textBox1.Text);

                if (DGV_Reportes.SelectedRows.Count == 0)
                {
                    btnGuardarCampus.Enabled = false;
                    btnGuardarRoles.Enabled = false
                        ;
                    for (int i = 0; i < lvCampus.Items.Count; i++)
                        lvCampus.Items[i].Checked = false;
                    lvCampus.Enabled = false;

                    for (int i = 0; i < lvRVOE.Items.Count; i++) 
                        lvRVOE.Items[i].Checked = false;
                    lvRVOE.Enabled = false;

                    lvCampusEspecificos.Enabled = false;
                    lvCampusEspecificos.Items.Clear();
                }
                else
                {
                    btnGuardarCampus.Enabled = true;
                    btnGuardarRoles.Enabled = true;
                }

            }
            catch (System.Data.SyntaxErrorException error) { }
        }

        
    }
}
