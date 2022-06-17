using NewReportesControlEscolar;
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

namespace ProyectoLoboSostenido
{
    public partial class FrmRPTPermisosRol : Form
    {

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

        public FrmRPTPermisosRol()
        {
            InitializeComponent();
        }
        private PermisosReportes pr;
        Clase_ReportesGenericos gn = new Clase_ReportesGenericos();

        private void FmrRPTPermisosRol_Load(object sender, EventArgs e)
        {
            cargarRoles();
            getPermisos();
            getCampus();

        }

        private void cbRoles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            marcarpuntos();
        }

        private void cbCampus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            marcarpuntos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pr = new PermisosReportes();
            if (cbRoles.SelectedItem != null && cbCampus.SelectedItem != null)
            {
                string rol = cbRoles.SelectedValue.ToString();
                string campus = cbCampus.SelectedValue.ToString();
                pr.LimpiarPermisos(rol, campus);
                for(int i=0; i < lvPermisos.Items.Count; i++)
                {
                    if (lvPermisos.Items[i].Checked)
                    {
                        pr.AgregarPermisosverReportes(lvPermisos.Items[i].Text.ToString(), rol, campus);
                    }
                }
                MessageBox.Show("Se han agregado los permisos", "Confirmado", MessageBoxButtons.OK);
            }
        } 

        private void cargarRoles()
        {
            pr = new PermisosReportes();
            pr.GetRoles();
            cbRoles.DataSource = pr.Lector.Tables[0];
            cbRoles.DisplayMember = "Descripcion";
            cbRoles.ValueMember = "ID_Rol";
            cbRoles.SelectedItem = null;
        }
        private void getPermisos()
        {
            pr = new PermisosReportes();
            pr.MostrarPermisosReportes();
            lvPermisos.Items.Clear();
            if (pr.Lector.Tables[0].Rows.Count>0)
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
                gn.llenarlistview(lvPermisos, dt);
            }

        }
        private void getCampus()
        {
            GetUsuariosRestricciones ur =  new GetUsuariosRestricciones();
            ur.GetCampus();
            cbCampus.DataSource = ur.Lector.Tables[0];
            cbCampus.DisplayMember = "Campus";
            cbCampus.ValueMember = "ID_Campus";
            cbCampus.SelectedItem = null;
        }

        
        private void marcarpuntos()
        {
            if (cbRoles.SelectedItem != null && cbCampus.SelectedItem != null)
            {
                try
                {
                    pr = new PermisosReportes();
                    if (pr.GetPermisosRol(cbRoles.SelectedValue.ToString(), cbCampus.SelectedValue.ToString()))
                    {
                        DataView dt = new DataView(pr.Lector.Tables[0]);
                        gn.marcarnodos(lvPermisos, dt);
                    }
                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_AgregarPermisos_Click(object sender, EventArgs e)
        {
            string nombre = tbPermisosReporte.Text;
            pr = new PermisosReportes();
            pr.AgregarIndicePermisosReportes(nombre);
            getPermisos();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
