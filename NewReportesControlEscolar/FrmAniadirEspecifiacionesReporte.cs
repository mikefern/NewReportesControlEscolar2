using ProyectoLoboSostenido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewReportesControlEscolar
{
    public partial class FrmAniadirEspecifiacionesReporte : Form
    {
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
                cargarRolesReportes(lvReportes.SelectedItems[0].SubItems[0].Text);
                lvRVOE.Items.Clear();
            }
        }

        private void cargarCampusReportes(string id)
        {
            lvCampusEspecificos.Items.Clear();
            pr = new PermisosReportes();
            pr.GetCampusReportes(id);
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt1 = new DataView(pr.Lector.Tables[0]);
                gn.marcarnodos(lvCampus, dt1);
                gn.llenarlistview(lvCampusEspecificos, dt1);
            }
        }

        private void cargarRolesReportes(string id)
        {
            pr = new PermisosReportes();
            if (pr.MostrarRelRolesReportes(id))
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
                gn.marcarnodos(lvRoles, dt);
            }
        }

        private void lvCampusEspecificos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvCampusEspecificos.SelectedItems.Count > 0)
                cargarRVOE();
                
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
                        bool check = true;
                        for (int x = 0; x < p.Lector.Tables[0].Rows.Count; x++)
                        {
                            int campusget = Convert.ToInt32(p.Lector.Tables[0].Rows[x][0].ToString());
                            if (campusget == Convert.ToInt32(campus))
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
                            pr.AgregarRelCampusReporte(reporte, campus);
                    }
                    else
                    {
                        pr.EliminarRelCampusReporte(reporte, campus);
                    }
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
                p.MostrarRelRolesReportes(id);
                pr = new PermisosReportes();
            
                for(int i=0;i<lvRoles.Items.Count; i++)
                {
                    string rol = lvRoles.Items[i].Text;
                    if (lvRoles.Items[i].Checked == true)
                    {
                        bool check = true;
                        for (int x = 0; x < p.Lector.Tables[0].Rows.Count; x++)
                        {
                            int rolLecto = Convert.ToInt32(p.Lector.Tables[0].Rows[x][1]);
                            if (Convert.ToInt32(rol) == rolLecto)
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
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
                        bool check = true;
                        for (int x = 0; x < p.Lector.Tables[0].Rows.Count; x++)
                        {
                            int rvo = Convert.ToInt32(p.Lector.Tables[0].Rows[x][0]);
                            if (rvo == Convert.ToInt32(rvoe))
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
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
    }
}
