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
        Clase_ReportesGenericos gn = new Clase_ReportesGenericos();
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
                    p = new PermisosReportes();
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
                            if (Convert.ToInt32(p.Lector.Tables[0].Rows[x][0]) == Convert.ToInt32(reporte))
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
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
    }
}
