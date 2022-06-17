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
    public partial class FrmAniadirEspecifiacionesReporte : Form

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

        #endregion

        private PermisosReportes pr;
        private PermisosReportes p;
        private Clase_ReportesGenericos gn= new Clase_ReportesGenericos();
        public FrmAniadirEspecifiacionesReporte()
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
            pr = new PermisosReportes();
            pr.GetReportesTodos();
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
                gn.llenarlistview(lvReportes, dt);
            }
        }
        private void lvReportes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvReportes.SelectedItems.Count > 0)
            {
                cargarCampusReportes(lvReportes.SelectedItems[0].SubItems[0].Text);
                
                lvRVOE.Items.Clear();
            }
        }

        private void cargarCampusReportes(string id)
        {
            lvCampusEspecificos.Items.Clear();
            pr = new PermisosReportes();
            pr.GetCampusReportes(id);
            if (pr.Lector.Tables.Count > 0)
            {
                DataView dt1 = new DataView(pr.Lector.Tables[0]);
                gn.marcarnodos(lvCampus, dt1);
                gn.llenarlistview(lvCampusEspecificos, dt1);
            }
        }

        private void cargarRolesReportes(string id)
        {

            pr = new PermisosReportes();
            if (pr.MostrarRelRolesReportes(id,lvCampusEspecificos.SelectedItems[0].SubItems[0].Text))
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
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
                cargarRolesReportes(lvReportes.SelectedItems[0].SubItems[0].Text);
            }
            catch
            {

            }
        }
        private void cargarRVOE()
        {
            pr = new PermisosReportes();
            pr.MostrarRVOESCampusReportes(lvCampusEspecificos.SelectedItems[0].SubItems[0].Text);
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
                gn.llenarlistview(lvRVOE, dt);
            }
            pr = new PermisosReportes();
            if(pr.MostrarRVOECampusReporte(lvReportes.SelectedItems[0].SubItems[0].Text, lvCampusEspecificos.SelectedItems[0].SubItems[0].Text))
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
                gn.marcarnodos(lvRVOE, dt);

            }
        }

        private void btnGuardarCampus_Click(object sender, EventArgs e)
        {
            try
            {
                p = new PermisosReportes();
                string id = lvReportes.SelectedItems[0].SubItems[0].Text;
                p.GetCampusReportes(id);
                pr = new PermisosReportes();
            
                for (int i = 0; i < lvCampus.Items.Count; i++)
                {
                    string reporte = lvReportes.SelectedItems[0].SubItems[0].Text;
                    string campus = lvCampus.Items[i].Text;
                    if (lvCampus.Items[i].Checked == true)
                    {
                        DataView dv = new DataView(p.Lector.Tables[0]);
                        if (gn.checarPermiso(dv, Convert.ToInt32(campus)))
                            pr.AgregarRelCampusReporte(reporte, campus);
                    }
                    else
                        pr.EliminarRelCampusReporte(reporte, campus);
                    
                }
                MessageBox.Show("Se han guardado los campus del reporte", "Completado", MessageBoxButtons.OK);
                cargarCampusReportes(id);
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
                p = new PermisosReportes();
                string id = lvReportes.SelectedItems[0].SubItems[0].Text;
                p.MostrarRelRolesReportes(id,lvCampusEspecificos.SelectedItems[0].SubItems[0].Text );
                pr = new PermisosReportes();
            
                for(int i=0;i<lvRoles.Items.Count; i++)
                {
                    string rol = lvRoles.Items[i].Text;
                    if (lvRoles.Items[i].Checked == true)
                    {
                        DataView dv = new DataView(p.Lector.Tables[0]);
                        if (gn.checarPermiso(dv, Convert.ToInt32(rol)))
                            pr.AgregarRelRolesReportes(rol, id);
                    }
                    else
                        pr.EliminarRelRolesReportes(rol, id);
                }
                MessageBox.Show("Se han guardado los roles del reporte", "Completado", MessageBoxButtons.OK);
                cargarCampusReportes(id);
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
                p = new PermisosReportes();
                string id = lvReportes.SelectedItems[0].SubItems[0].Text;
                string campus = lvCampusEspecificos.SelectedItems[0].SubItems[0].Text;
                p.MostrarRVOECampusReporte(id, campus);
                pr = new PermisosReportes();

                for (int i = 0; i < lvRVOE.Items.Count; i++)
                {
                    string rvoe = lvRVOE.Items[i].Text;
                    if (lvRVOE.Items[i].Checked == true)
                    {
                        DataView dv = new DataView(p.Lector.Tables[0]);
                        if (gn.checarPermiso(dv, Convert.ToInt32(rvoe)))
                            pr.AgregarRVOEReportes(id, rvoe);
                    }
                    else
                        pr.EliminarRVOEReportes(id, rvoe);
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
            FrmRestriccionesRolesReportes rr = new FrmRestriccionesRolesReportes();
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

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
