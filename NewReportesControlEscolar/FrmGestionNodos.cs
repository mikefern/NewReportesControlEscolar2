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
using ProyectoLoboSostenido;

namespace NewReportesControlEscolar
{
    public partial class FrmGestionNodos : Form
    {
        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmGestionNodos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
        #region VARIABLES
        Clase_ReportesCE clase_ReportesCE;
        int LadoClick;
        string NNodo;
        string NPadre;
        string Position;
        string NombreNodo;
        string nodopadre = "";

        //Varibales Fausto
        NodosPermisos n;
        NodosPermisos np;
        private Clase_ReportesGenericos gn = new Clase_ReportesGenericos();

        #endregion

        #region TreeViewNodos Events
        private void TreeViewNodos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LadoClick = 0;
            }
            if (e.Button == MouseButtons.Right)
            {
                LadoClick = 1;
            }
        }
        private void TreeViewNodos_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);

            }
            if (e.Button == MouseButtons.Right)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);

            }
        }
        private void TreeViewNodos_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            e.Effect = DragDropEffects.Move;
        }
        private void TreeViewNodos_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = TreeViewNodos.PointToClient(new Point(e.X, e.Y));
            TreeViewNodos.SelectedNode = TreeViewNodos.GetNodeAt(targetPoint);
        }
        private void TreeViewNodos_DragDrop(object sender, DragEventArgs e)
        {
            if (LadoClick == 0) //si es con CLIC IZQUIERDO
            {

                String Mode;
                Point targetPoint = TreeViewNodos.PointToClient(new Point(e.X, e.Y));
                TreeNode targetNode = TreeViewNodos.GetNodeAt(targetPoint);
                TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

                if (draggedNode != targetNode)
                {
                    if (draggedNode.Parent != targetNode)
                    {
                        if (e.KeyState == 4)
                        {
                            if (targetNode == draggedNode.PrevNode)
                            {
                                MessageBox.Show("si elije este nodo no pasara nada, necesita mover uno arriba");
                                return;
                            }
                            else if (targetNode.Parent != null)
                            {
                                if (draggedNode.Parent != targetNode.Parent)
                                {
                                    MessageBox.Show("SOLO PUEDE MOVER Nodo de un mismo nodo padre , no se puede exceder de uno");
                                    return;
                                }
                            }
                            if (targetNode.Parent == null)
                            {
                                MessageBox.Show("SOLO PUEDE MOVER Nodo de un mismo nodo padre , no se puede exceder de uno"); return;
                            }
                            Mode = "Mover";
                        }
                        else
                        {
                            Mode = "Modificar";
                        }


                        if (MessageBox.Show("Esta seguro de " + Mode + " el Nodo?:", "Espera", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (targetNode != null)
                            {
                                TreeNode parentNode = targetNode;

                                if (!draggedNode.Equals(targetNode) && targetNode != null)
                                {
                                    bool canDrop = true;
                                    while (canDrop && (parentNode != null))
                                    {
                                        canDrop = !Object.ReferenceEquals(draggedNode, parentNode);
                                        parentNode = parentNode.Parent;
                                    }
                                    if (canDrop)
                                    {
                                        draggedNode.Remove();
                                        if (e.KeyState == 4)
                                        {
                                            if (targetNode.Parent == null) TreeViewNodos.Nodes.Insert(targetNode.Index + 1, draggedNode);
                                            else targetNode.Parent.Nodes.Insert(targetNode.Index + 1, draggedNode);

                                            InsertarNodos(NNodo, draggedNode.Name);
                                            LlenadoNodosReporte();
                                            TreeNode[] NodoaExpandir = TreeViewNodos.Nodes.Find(NNodo, true);
                                            ExpandirNodoenInsercion(NodoaExpandir[0]);
                                        }
                                        else
                                        {
                                            targetNode.Nodes.Add(draggedNode);
                                            InsertarNodos(NNodo, draggedNode.Name);
                                            LlenadoNodosReporte();
                                            TreeNode[] NodoaExpandir = TreeViewNodos.Nodes.Find(NNodo, true);
                                            ExpandirNodoenInsercion(NodoaExpandir[0]);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                draggedNode.Remove();
                                TreeViewNodos.Nodes.Add(draggedNode);
                                InsertarNodos("0", draggedNode.Name);
                            }
                        }
                    }
                }
            }
            if (LadoClick == 1) //si es con clic derecho
            {

                Point targetPoint = TreeViewNodos.PointToClient(new Point(e.X, e.Y));
                TreeNode targetNode = TreeViewNodos.GetNodeAt(targetPoint);
                TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

                if (!draggedNode.Equals(targetNode) && targetNode != null)
                {
                    if (draggedNode.Parent == targetNode)
                    {
                        MessageBox.Show("mueve el nodo dentro del nodo padre");
                    }
                    else
                    {
                        if (MessageBox.Show("Esta seguro de cambiar de posicion el Nodo: " + NombreNodo, "Espera", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (targetNode.Parent != draggedNode.Parent)
                            {
                                if (targetNode.Parent != null) MessageBox.Show("primero ingresa el noodo dentro de " + targetNode.Parent.Text);
                                else MessageBox.Show("primero ingresa el noodo dentro de " + targetNode.Text);
                            }
                            else
                            {
                                string nodo = draggedNode.Name;
                                string posold = draggedNode.Index.ToString();
                                string posnew = targetNode.Index.ToString();
                                int posparent = 0;




                                if (draggedNode.Parent == null)
                                {
                                    draggedNode.Nodes.Insert(targetNode.Index, draggedNode.Text);
                                    nodopadre = "0";
                                }
                                else
                                {
                                    nodopadre = draggedNode.Parent.Name;
                                    //draggedNode.Parent.Nodes.Insert(targetNode.Index, draggedNode.Text);
                                    posparent = draggedNode.Parent.Index;
                                }

                                // draggedNode.Remove();


                                if (clase_ReportesCE.UpdatePosicionesNodos(nodopadre, nodo, posold, posnew))
                                {
                                    MessageBox.Show("Nodo Cambiado de posición con exito", "Nodos", MessageBoxButtons.OK);
                                }

                                LlenadoNodosReporte();
                                if(posparent > 0)ExpandirNodoenPosicion(TreeViewNodos.Nodes[posparent]);
                            }
                        }
                    }
                }
            }
        }
        private void TreeViewNodos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // btn_Cambiarnombre.Text = "Cambiar Nombre Nodo";
            txt_NombreNodo.ReadOnly = true;

            try
            {
                cargaElementos(TreeViewNodos.SelectedNode.Name.Trim());

                if (e.Node.Parent != null && e.Node.Parent.GetType() == typeof(TreeNode))
                {
                    txt_NodoPadre.Text = txt_NodoPadre.Text + " - " + e.Node.Parent.Text;
                }
                else txt_NodoPadre.Text = "0";

                txt_Posicion.Text = e.Node.Index.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en treeNodos_AfterSelect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        public FrmGestionNodos()
        {
            InitializeComponent();
            LlenadoNodosReporte();
        }

        

        public void LlenadoNodosReporte()
        {
            TreeViewNodos.Nodes.Clear();
            clase_ReportesCE = new Clase_ReportesCE();
            if (clase_ReportesCE.LlenadoNodosReporteEscolar())
            {
                if (clase_ReportesCE.Lector.Tables[0].Rows.Count > 0)
                {
                    crearNodo cn = new crearNodo();
                    cn.dt = new DataView(clase_ReportesCE.Lector.Tables[0]);
                    cn.CrearNodos(0, null, TreeViewNodos);
                    //CrearNodos(0, null);
                }
                else MessageBox.Show("No tiene Ningun Nodo Asingado" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CrearNodos(int indicePadre, TreeNode nodePadre)
        {
            DataView dataViewHijos = new DataView(clase_ReportesCE.Lector.Tables[0]);
            dataViewHijos.RowFilter = clase_ReportesCE.Lector.Tables[0].Columns["NodoPadre"].ColumnName + " = " + indicePadre;
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["TextoNodo"].ToString().Trim();
                nuevoNodo.Name = dataRowCurrent["Nodo"].ToString().Trim();
                if (nodePadre == null)
                    TreeViewNodos.Nodes.Add(nuevoNodo);
                else
                    nodePadre.Nodes.Add(nuevoNodo);

                CrearNodos(Int32.Parse(dataRowCurrent["Nodo"].ToString()), nuevoNodo);
            }
        }

        private void cargaElementos(string nodo)
        {
                DataRow[] elements = clase_ReportesCE.Lector.Tables[0].Select("nodo =" + nodo.Trim());
                foreach (DataRow _elemento in elements)
                {
                    NNodo = _elemento["Nodo"].ToString();
                    NPadre = _elemento["NodoPadre"].ToString();
                    Position = _elemento["Posicion"].ToString();
                    NombreNodo = _elemento["TextoNodo"].ToString();
                }

                txt_IDNodo.Text = NNodo;
                txt_NodoPadre.Text = NPadre;
                txt_NombreNodo.Text = NombreNodo;
        }

        private void InsertarNodos(String NodoPadre, String Nodo)
        {
             
            if (clase_ReportesCE.updatepositionwhenInsert(NodoPadre, Nodo))
            {
                MessageBox.Show("Nodo Actualizado", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Error en cargaListaNodos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ExpandirNodoenInsercion(TreeNode nodo)
        {
            nodo.Expand();
            if (nodo.Parent != null)
            {
                ExpandirNodoenInsercion(nodo.Parent);
            }

            
        }

        public void ExpandirNodoenPosicion(TreeNode tn)
        {
            if (tn.Level == 0) tn.Expand();
        }

        private void btn_EliminarNodo_Click(object sender, EventArgs e)
        {
            //Si se ha seleccionado un nodo
            if (TreeViewNodos.SelectedNode != null)
            {
                if (TreeViewNodos.SelectedNode.Nodes.Count == 0)
                {
                    if (MessageBox.Show("Esta seguro de Eliminar el '" + TreeViewNodos.SelectedNode + "'?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string nodo = TreeViewNodos.SelectedNode.Name.Trim();
                        if (clase_ReportesCE.DMLNodo("3", nodo, ""))
                        {
                            MessageBox.Show("Nodo Eliminado Exitosamente");
                            LlenadoNodosReporte();
                        }
                        else MessageBox.Show("Error en el Procedimiento de eliminar nodo \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Existen nodos que cuelgan de éste.  Elimínelos primero para poder eliminar éste.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Inicializa el nodo seleccionado
                TreeViewNodos.SelectedNode = null;
            }
            else
            {
                MessageBox.Show("Debe seleccionar el Nodo que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AñadirNodo_Click(object sender, EventArgs e)
        {
            string indice = "";

            if (txtNombreNuevoNodo.Text.Trim() == "")
            {
                MessageBox.Show("No se puede ingresar un nombre al nodo, porfavor ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TreeNode NuevoNodo = new TreeNode(txtNombreNuevoNodo.Text.Trim());

            //Si no hay lo añade al nodo raíz
            if (TreeViewNodos.Nodes.Count == 0)
            {   
               // nodoP = "";
               // nodo = NuevoNodo.Text;
                TreeViewNodos.Nodes.Add(NuevoNodo);
            }
            else
            {
                if (TreeViewNodos.SelectedNode != null)
                {
                    //Añadimos el nodo al treeView
                    TreeViewNodos.SelectedNode.Nodes.Add(NuevoNodo);
                    //Guardamos la posición del nodo añadido
                    indice = recuperaindiceNodo(TreeViewNodos.SelectedNode);
                }
                else
                {
                    MessageBox.Show("Selecciona el nodo donde quieres insertar el nuevo subnodo");
                    return;
                }
            }

            //metodo para insertar
            if(clase_ReportesCE.DMLNodo("1",NNodo, txtNombreNuevoNodo.Text.Trim()))
            {
                MessageBox.Show("Nodo Insertado");
            }
            else
            {
                 MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LlenadoNodosReporte();

            TreeNode[] NodoaExpandir = TreeViewNodos.Nodes.Find(NNodo, true);
            ExpandirNodoenInsercion(NodoaExpandir[0]); 


        }

        private string recuperaindiceNodo(TreeNode nodo)
        {
            try
            {
                //Recuperamos la posición del nodo añadido
                TreeNode Tnodo = new TreeNode();
                string indice = TreeViewNodos.SelectedNode.Index.ToString();
                Tnodo = TreeViewNodos.SelectedNode.Parent;
                while (Tnodo != null)
                {
                    indice = Tnodo.Index.ToString() + TreeViewNodos.PathSeparator + indice;
                    Tnodo = Tnodo.Parent;
                }

                return indice;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + "\n" + ex.Message, "Error en recuperaindiceNodo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void TreeViewNodos_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_AñadirNodoRaiz_Click(object sender, EventArgs e)
        {
            if(txtNombreNuevoNodo.Text.Trim() != "")
            {
                string nodopadre = "0"; 
                if (clase_ReportesCE.DMLNodo("1", nodopadre, txtNombreNuevoNodo.Text.Trim()))
                {
                    MessageBox.Show("Nodo Insertado");
                    LlenadoNodosReporte();
                    txtNombreNuevoNodo.Text = "";
                }
                else
                {
                    MessageBox.Show("Existre un error en el procedimiento con ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe teclear un Nodo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btn_CambiarNombreNodo_Click(object sender, EventArgs e)
        {
            if (txtNombreNuevoNodo.Text.Trim() != "")
            {
                if (TreeViewNodos.SelectedNode != null) { 
                    if (MessageBox.Show("Esta seguro de cambiar de nombre al nodo '" + TreeViewNodos.SelectedNode + "'?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string nodo = TreeViewNodos.SelectedNode.Name.ToString();
                        if (clase_ReportesCE.DMLNodo("2", nodo, txtNombreNuevoNodo.Text.Trim()))
                        {
                            MessageBox.Show("Nodo Modificado con Exito");
                            LlenadoNodosReporte();
                            txtNombreNuevoNodo.Text = "";
                        }
                        else MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }
                else MessageBox.Show("Seleccione un Nodo \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("ingresa un nombre en la caja de NUEVO NOMBRE NODO \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void TreeViewNodos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {

                n = new NodosPermisos();
                string nodo = e.Node.Name;
                if (n.GetCampusNodos(nodo))
                {
                    gn = new Clase_ReportesGenericos();
                    DataView dt = new DataView(n.Lector.Tables[0]);
                    gn.marcarnodos(lvCampus, dt);
                }
                cargarCampusSeleccion(nodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK);
            }
        }

        private void cargarCampusSeleccion(string nodo)
        {
            n = new NodosPermisos();
            if (n.GetCampusNodos(nodo))
            {
                DataView dt = new DataView(n.Lector.Tables[0]);
                gn.llenarlistview(lvSeleccionarCampus, dt);
            }
            btnGuardarRoles.Enabled = false;
            lvRoles.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                n = new NodosPermisos();
                string nodo = TreeViewNodos.SelectedNode.Name.ToString();
                n.GetCampusNodos(nodo);
                np = new NodosPermisos();

                for (int x = 0; x < lvCampus.Items.Count; x++)
                {
                    string tvName = TreeViewNodos.SelectedNode.Name.ToString();
                    string lvItem = lvCampus.Items[x].Text.ToString();
                    if (lvCampus.Items[x].Checked == true)
                    {
                        DataView dv = new DataView(n.Lector.Tables[0]);
                        if (gn.checarPermiso(dv, Convert.ToInt32(lvItem)))
                            np.AgregarPermisosverReportes(tvName, lvItem);
                    }
                    else
                        np.DeleteCampusNodos(lvItem, tvName);
                }
                MessageBox.Show("Se han guardado los campus que pueden ver el nodo " + TreeViewNodos.SelectedNode.Text, "Confirmar", MessageBoxButtons.OK);
                cargarCampusSeleccion(TreeViewNodos.SelectedNode.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK);
            }
        }

        private void lvSeleccionarCampus_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                for (int i = 0; i < lvRoles.Items.Count; i++)
                    lvRoles.Items[i].Checked = false;

                n = new NodosPermisos();
                if (lvSeleccionarCampus.SelectedItems.Count > 0 && n.GetRolesCampusNodos(lvSeleccionarCampus.SelectedItems[0].SubItems[0].Text, TreeViewNodos.SelectedNode.Name))
                {
                    DataView dt = new DataView(n.Lector.Tables[0]);
                    gn.marcarnodos(lvRoles, dt);
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
                n.GetRolesCampusNodos(lvSeleccionarCampus.SelectedItems[0].SubItems[0].Text, TreeViewNodos.SelectedNode.Name);
                for (int x = 0; x < lvRoles.Items.Count; x++)
                {
                    string campus = lvSeleccionarCampus.SelectedItems[0].SubItems[0].Text;
                    string nodo = TreeViewNodos.SelectedNode.Name;
                    string rol = lvRoles.Items[x].Text;
                    //if (Convert.ToInt32(rol) == 14)
                      //  lvRoles.Items[x].Checked = true;

                    if (lvRoles.Items[x].Checked == true)
                    {
                        DataView dv = new DataView(n.Lector.Tables[0]);
                        if (gn.checarPermiso(dv, Convert.ToInt32(rol)))
                            np.InsertarRolesCampusNodos(campus, nodo, rol);
                    }
                    else
                        np.DeleteRolesCampusNodos(campus, nodo, rol);
                }
                MessageBox.Show("Se han guardados los roles del campus " + lvSeleccionarCampus.SelectedItems[0].SubItems[1].Text + " en el nodo " + TreeViewNodos.SelectedNode.Text, "Completado", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmGestionNodos_Load(object sender, EventArgs e)
        {
            Clase_ReportesGenericos gn = new Clase_ReportesGenericos();
            gn.cargarRoles(lvRoles);
            gn.cargarCampus(lvCampus);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmEnlazarReportesNodos ern = new FrmEnlazarReportesNodos();
            ern.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//fin de clase
}
