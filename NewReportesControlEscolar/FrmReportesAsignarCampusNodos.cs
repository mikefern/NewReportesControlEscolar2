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
    public partial class FrmReportesAsignarCampusNodos : Form
    {
        public FrmReportesAsignarCampusNodos()
        {
            InitializeComponent();
        }
        private Clase_ReportesCE cd;
        private PermisosReportes pr;
        private NodosPermisos n;
        private NodosPermisos np;

        private void FmrReportesAsignarCampusNodos_Load(object sender, EventArgs e)
        {
            LlenadoNodosReporte(tvNodos);
            cargarCampus();
            cargarRoles();
        }
        private void tvNodos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                for (int i = 0; i < lvCampus.Items.Count; i++)
                lvCampus.Items[i].Checked = false;
                
                n = new NodosPermisos();
                string nodo = e.Node.Name;
                if (n.GetCampusNodos(nodo))
                {
                    for (int i = 0; i < n.Lector.Tables[0].Rows.Count; i++)
                    {
                        int dato = Convert.ToInt32(n.Lector.Tables[0].Rows[i][0].ToString());
                        for (int x = 0; x < lvCampus.Items.Count; x++)
                        {
                            if (Convert.ToInt32(lvCampus.Items[x].Text) == dato)
                                lvCampus.Items[x].Checked = true;
                        }
                    }
                }
                cargarCampusSeleccion(nodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                n = new NodosPermisos();
                string nodo = tvNodos.SelectedNode.Name.ToString();
                n.GetCampusNodos(nodo);
                np = new NodosPermisos();

                for (int x = 0; x < lvCampus.Items.Count; x++)
                {
                    if (lvCampus.Items[x].Checked == true)
                    {
                        bool check = true;
                        int CampusListView;
                        int CampusLector;
                        for (int i = 0; i < n.Lector.Tables[0].Rows.Count; i++)
                        {
                            CampusListView = Convert.ToInt32(lvCampus.Items[x].Text);
                            CampusLector = Convert.ToInt32(n.Lector.Tables[0].Rows[i][0].ToString());
                            if (CampusLector == CampusListView)
                                check = false;
                        }
                        if (check)
                            np.AgregarPermisosverReportes(tvNodos.SelectedNode.Name.ToString(), lvCampus.Items[x].Text.ToString());
                    }
                    else
                    {
                        np.DeleteCampusNodos(lvCampus.Items[x].Text.ToString(), tvNodos.SelectedNode.Name.ToString());

                    }
                }
                MessageBox.Show("Se han guardado los campus que pueden ver el nodo "+tvNodos.SelectedNode.Text, "Confirmar", MessageBoxButtons.OK);
                cargarCampusSeleccion(tvNodos.SelectedNode.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK);
            }
        }

        public void LlenadoNodosReporte(TreeView treeView)
        {
            try
            {

                cd = new Clase_ReportesCE();
                cd.RPTMostrarNodos();
                string validar = cd.Lector.Tables[0].Rows[0][0].ToString();



                if (!validar.Equals("-1"))
                {
                    CrearNodosDelPadre(0, null, treeView);
                }
                else
                    MessageBox.Show("No tiene permitido ingresar a este campus con su rol actual", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CrearNodosDelPadre(int indicePadre, TreeNode nodePadre, TreeView treeView)
        {
            DataView dataViewHijos = new DataView(cd.Lector.Tables[0]);
            dataViewHijos.RowFilter = cd.Lector.Tables[0].Columns["nodo_Padre"].ColumnName + " = " + indicePadre;
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["nodo_text"].ToString().Trim();
                nuevoNodo.Name = dataRowCurrent["nodo"].ToString().Trim();
                if (nodePadre == null)
                    treeView.Nodes.Add(nuevoNodo);
                else
                    nodePadre.Nodes.Add(nuevoNodo);

                CrearNodosDelPadre(Int32.Parse(dataRowCurrent["nodo"].ToString()), nuevoNodo, treeView);
            }
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
                    item.SubItems.Add(ur.Lector.Tables[0].Rows[i][1].ToString()); // 1st column text
                    lvCampus.Items.Add(item);
                }
            }
        }
        private void cargarCampusSeleccion(string nodo)
        {

            lvSeleccionarCampus.Items.Clear();
            n = new NodosPermisos();
            if (n.GetCampusNodos(nodo))
            {
                for (int i = 0; i < n.Lector.Tables[0].Rows.Count; i++)
                {
                    var item = new ListViewItem();
                    item.Text = n.Lector.Tables[0].Rows[i][0].ToString();
                    item.SubItems.Add(n.Lector.Tables[0].Rows[i][1].ToString()); // 1st column text
                    lvSeleccionarCampus.Items.Add(item);
                }
            }
            btnGuardarRoles.Enabled = false;
            lvRoles.Enabled = false;
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
                    item.SubItems.Add(pr.Lector.Tables[0].Rows[i][1].ToString()); // 1st column text
                    lvRoles.Items.Add(item);
                }
            }
        }

        private void lvSeleccionarCampus_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                for (int i = 0; i < lvRoles.Items.Count; i++)
                    lvRoles.Items[i].Checked = false;

                n = new NodosPermisos();
                if( lvSeleccionarCampus.SelectedItems.Count >0 && n.GetRolesCampusNodos(lvSeleccionarCampus.SelectedItems[0].SubItems[0].Text, tvNodos.SelectedNode.Name))
                {
                    for(int i=0; i < n.Lector.Tables[0].Rows.Count; i++)
                    {
                        int dato = Convert.ToInt32(n.Lector.Tables[0].Rows[i][1]);
                        for (int x=0; x < lvRoles.Items.Count; x++)
                        {
                            if (Convert.ToInt32(lvRoles.Items[x].Text) == dato)
                                lvRoles.Items[x].Checked = true;
                        }
                    }
                }
                btnGuardarRoles.Enabled = true;
                lvRoles.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardarRoles_Click(object sender, EventArgs e)
        {
            try
            {
                n = new NodosPermisos();
                np = new NodosPermisos();
                n.GetRolesCampusNodos(lvSeleccionarCampus.SelectedItems[0].SubItems[0].Text,tvNodos.SelectedNode.Name);
                for(int x=0; x < lvRoles.Items.Count; x++)
                {
                    if (lvRoles.Items[x].Checked == true)
                    {
                        bool check = true;
                        int RolesListView;
                        int RolesLector;
                        for (int i=0; i< n.Lector.Tables[0].Rows.Count; i++)
                        {
                            RolesListView =Convert.ToInt32(lvRoles.Items[x].Text);
                            RolesLector = Convert.ToInt32(n.Lector.Tables[0].Rows[i][1]);
                            if (RolesLector == RolesListView)
                                check = false;
                        }
                        if (check) {
                            string campus = lvSeleccionarCampus.SelectedItems[0].SubItems[0].Text;
                            string nodo = tvNodos.SelectedNode.Name;
                            string rol = lvRoles.Items[x].Text;
                            np.InsertarRolesCampusNodos(campus,nodo,rol);
                        }

                    }
                    else
                    {
                        string campus = lvSeleccionarCampus.SelectedItems[0].SubItems[0].Text;
                        string nodo = tvNodos.SelectedNode.Name;
                        string rol = lvRoles.Items[x].Text;
                        np.DeleteRolesCampusNodos(campus, nodo, rol);
                    }
                }
                MessageBox.Show("Se han guardados los roles del campus " + lvSeleccionarCampus.SelectedItems[0].SubItems[1].Text + " en el nodo " + tvNodos.SelectedNode.Text,"Completado",MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
