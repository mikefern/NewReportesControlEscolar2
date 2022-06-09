﻿using NewReportesControlEscolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLoboSostenido
{
    public partial class FrmRPTPermisosRol : Form
    {
        public FrmRPTPermisosRol()
        {
            InitializeComponent();
        }
        private PermisosReportes pr;

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
                for (int i=0; i< pr.Lector.Tables[0].Rows.Count; i++)
                {
                    var item = new ListViewItem();
                    item.Text = pr.Lector.Tables[0].Rows[i][0].ToString();
                    item.SubItems.Add(pr.Lector.Tables[0].Rows[i][1].ToString()); // 1st column text
                    lvPermisos.Items.Add(item);
                }
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

                        for (int i = 0; i<lvPermisos.Items.Count; i++ )
                            lvPermisos.Items[i].Checked = false;
                        
                        for (int i = 0; i < pr.Lector.Tables[0].Rows.Count; i++)
                        {
                            for (int x = 0; x < lvPermisos.Items.Count; x++)
                            {
                                if (Convert.ToInt32(pr.Lector.Tables[0].Rows[i][0]) == Convert.ToInt32(lvPermisos.Items[x].Text.ToString()))
                                    lvPermisos.Items[x].Checked = true;
                            }
                        }
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
    }
}
