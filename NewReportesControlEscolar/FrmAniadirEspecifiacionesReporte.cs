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
        public FrmAniadirEspecifiacionesReporte()
        {
            InitializeComponent();
        }
        
        private void FrmAniadirEspecifiacionesReporte_Load(object sender, EventArgs e)
        {
            cargarCampus();
            cargarRoles();
            cargarReportes();
        }
        private void cargarCampus()
        {
            GetUsuariosRestricciones ur = new GetUsuariosRestricciones();
            ur.GetCampus();
            if (ur.Lector.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ur.Lector.Tables[0].Rows.Count; i++)
                {
                    var item = new ListViewItem();
                    item.Text = ur.Lector.Tables[0].Rows[i][0].ToString();
                    item.SubItems.Add(ur.Lector.Tables[0].Rows[i][1].ToString());
                    lvCampus.Items.Add(item);
                }
            }
        }

        private void cargarRoles()
        {
            pr = new PermisosReportes();
            pr.GetRoles();
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < pr.Lector.Tables[0].Rows.Count; i++)
                {
                    var item = new ListViewItem();
                    item.Text = pr.Lector.Tables[0].Rows[i][0].ToString();
                    item.SubItems.Add(pr.Lector.Tables[0].Rows[i][1].ToString());
                    lvRoles.Items.Add(item);
                }
            }
        }

        private void cargarReportes()
        {
            pr = new PermisosReportes();
            pr.GetReportesTodos();
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < pr.Lector.Tables[0].Rows.Count; i++)
                {
                    var item = new ListViewItem();
                    item.Text = pr.Lector.Tables[0].Rows[i][0].ToString();
                    item.SubItems.Add(pr.Lector.Tables[0].Rows[i][4].ToString());
                    lvReportes.Items.Add(item);
                }
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
                for (int i = 0; i < pr.Lector.Tables[0].Rows.Count; i++)
                {
                    var item = new ListViewItem();
                    item.Text = pr.Lector.Tables[0].Rows[i][0].ToString();
                    item.SubItems.Add(pr.Lector.Tables[0].Rows[i][1].ToString());
                    lvCampusEspecificos.Items.Add(item);

                }

                for (int i = 0; i < lvCampus.Items.Count; i++)
                    lvCampus.Items[i].Checked = false;

                for (int i = 0; i < pr.Lector.Tables[0].Rows.Count; i++)
                {
                    int dato = Convert.ToInt32(pr.Lector.Tables[0].Rows[i][0]);
                    for (int x = 0; x < lvCampus.Items.Count; x++)
                    {
                        int lv = Convert.ToInt32(lvCampus.Items[x].Text);
                        if (lv == dato)
                            lvCampus.Items[x].Checked = true;
                    }
                }
            }
        }
        private void cargarRolesReportes(string id)
        {
            pr = new PermisosReportes();
            pr.MostrarRelRolesReportes(id);
            for (int i = 0; i < lvRoles.Items.Count; i++)
                lvRoles.Items[i].Checked = false;

            for (int i = 0; i < pr.Lector.Tables[0].Rows.Count; i++)
            {
                int dato = Convert.ToInt32(pr.Lector.Tables[0].Rows[i][1]);
                for (int x = 0; x < lvRoles.Items.Count; x++)
                {
                    int lv = Convert.ToInt32(lvRoles.Items[x].Text);
                    if (lv == dato)
                        lvRoles.Items[x].Checked = true;
                }
            }

        }


        private void lvCampusEspecificos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvCampusEspecificos.SelectedItems.Count > 0)
                cargarRVOE();
                
        }
        private void cargarRVOE()
        {
            lvRVOE.Items.Clear();

            pr = new PermisosReportes();
            pr.MostrarRVOESCampusReportes(lvCampusEspecificos.SelectedItems[0].SubItems[0].Text);
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < pr.Lector.Tables[0].Rows.Count; i++)
                {
                    var item = new ListViewItem();
                    item.Text = pr.Lector.Tables[0].Rows[i][0].ToString();
                    item.SubItems.Add(pr.Lector.Tables[0].Rows[i][1].ToString());
                    lvRVOE.Items.Add(item);

                }
            }
            pr = new PermisosReportes();
            pr.MostrarRVOECampusReporte(lvReportes.SelectedItems[0].SubItems[0].Text, lvCampusEspecificos.SelectedItems[0].SubItems[0].Text);
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                for (int x = 0; x < lvRVOE.Items.Count; x++)
                {
                    for (int i = 0; i < pr.Lector.Tables[0].Rows.Count; i++)
                    {
                        if (Convert.ToInt32(lvRVOE.Items[x].Text) == Convert.ToInt32(pr.Lector.Tables[0].Rows[i][1]))
                            lvRVOE.Items[x].Checked = true;

                    }
                }
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
                                check = false;
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
                                check = false;
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
                            int rvo = Convert.ToInt32(p.Lector.Tables[0].Rows[x][1]);
                            if (rvo == Convert.ToInt32(rvoe))
                                check = false;
                        }
                        if (check)
                            pr.AgregarRVOEReportes(id, rvoe);
                    }
                    else
                    {
                        pr.EliminarRVOEReportes(id, rvoe);
                    }
                }
                MessageBox.Show("Se han guardado los RVOE del reporte", "Completado", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
