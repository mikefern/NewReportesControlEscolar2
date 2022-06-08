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
    public partial class FrmRestriccionesRolesReportes : Form
    {
        public FrmRestriccionesRolesReportes()
        {
            InitializeComponent();
        }

        private PermisosReportes p;

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
            GetUsuariosRestricciones ur = new GetUsuariosRestricciones();
            ur.GetCampus();
            cbCampus.DataSource = ur.Lector.Tables[0];
            cbCampus.DisplayMember = "Campus";
            cbCampus.ValueMember = "ID_Campus";
            cbCampus.SelectedItem = null;
        }
        private void cargarReportes()
        {
            PermisosReportes pr = new PermisosReportes();
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

        private void cbUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbUsuarios.SelectedValue != null)
                {
                    lvReportes.Enabled = true;
                    for (int i = 0; i < lvReportes.Items.Count; i++)
                        lvReportes.Items[i].Checked = false;

                    p = new PermisosReportes();
                    if (p.GetRestriccionesReportesEmpleado(cbUsuarios.SelectedValue.ToString()))
                    {

                        for (int i = 0; i < p.Lector.Tables[0].Rows.Count; i++)
                        {
                            int dato = Convert.ToInt32(p.Lector.Tables[0].Rows[i][0]);
                            for (int x = 0; x < lvReportes.Items.Count; x++)
                            {
                                int lv = Convert.ToInt32(lvReportes.Items[x].Text);
                                if (lv == dato)
                                    lvReportes.Items[x].Checked = true;
                            }
                        }
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
                GetUsuariosRestricciones ur = new GetUsuariosRestricciones();
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
                PermisosReportes pr = new PermisosReportes();
                string empleado = cbUsuarios.SelectedValue.ToString();
                for (int i = 0; i < lvReportes.Items.Count; i++)
                {
                    string reporte = lvReportes.Items[i].Text;
                    if (lvReportes.Items[i].Checked == true)
                    {
                        bool check = true;
                        for(int x=0; x< p.Lector.Tables[0].Rows.Count; x++)
                        {
                            if (Convert.ToInt32(p.Lector.Tables[0].Rows[x][0]) == Convert.ToInt32(lvReportes.Items[i].Text))
                                check = false;
                        }
                        if (check)
                            pr.AgregarRestriccionesReportesEmpleado(reporte, empleado);
                    }
                    else
                    {
                        pr.EliminarRestriccionesReportesEmpleado(reporte, empleado);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
