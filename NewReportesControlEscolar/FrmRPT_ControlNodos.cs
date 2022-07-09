using System;  
using System.Data;
using System.Drawing; 
using System.Runtime.InteropServices; 
using System.Windows.Forms;
using ProyectoLoboSostenido;

namespace NewReportesControlEscolar
{
    public partial class FrmRPT_ControlNodos : Form
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
        private void lbl_Titulo_MouseDown(object sender, MouseEventArgs e)
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
        string PositionBd;
        string NombreNodo;
        string nodopadre = "";

        //Varibales Fausto
        Clase_ReportesCE reporteCE;
        Clase_ReportesCE np;
        private Clase_ReportesGenericos reporteGenerico = new Clase_ReportesGenericos();

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
                                MessageBox.Show("Si elije este Nodo no pasara nada, necesita mover uno arriba","Nodo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                return;
                            }
                            else if (targetNode.Parent != null)
                            {
                                if (draggedNode.Parent != targetNode.Parent)
                                {
                                    MessageBox.Show("SOLO PUEDE MOVER EL Nodo de un mismo nodo PADRE , no se puede exceder de uno","Nodo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                    return;
                                }
                            }
                            if (targetNode.Parent == null)
                            {
                                MessageBox.Show("SOLO PUEDE MOVER EL Nodo de un mismo nodo PADRE , no se puede exceder de uno", "Nodo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
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
                        MessageBox.Show("Mueve el nodo dentro del nodo padre","Nodo",MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (MessageBox.Show("Esta seguro de cambiar de posicion el Nodo: " + NombreNodo, "Espera", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (targetNode.Parent != draggedNode.Parent)
                            {
                                if (targetNode.Parent != null) MessageBox.Show("Primero ingresa el nodo dentro de " + targetNode.Parent.Text,"Nodo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                else MessageBox.Show("Primero ingresa el nodo dentro de " + targetNode.Text,"Nodo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                                    posparent = draggedNode.Parent.Index;
                                }

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

                ComprobarPosicionNodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en treeNodos_AfterSelect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TreeViewNodos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                reporteCE = new Clase_ReportesCE();
                string nodo = e.Node.Name;
                btnGuardar.Enabled = true;
                lvCampus.Enabled = true;

                if (reporteCE.DMLPermisosNodosCampus("0","0","0",nodo))
                {
                    reporteGenerico = new Clase_ReportesGenericos();
                    DataView dt = new DataView(reporteCE.Lector.Tables[0]);
                    reporteGenerico.marcarnodos(lvCampus, dt);
                }
                cargarCampusSeleccion(nodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK);
            }
        }

        #endregion

        public FrmRPT_ControlNodos()
        {
            InitializeComponent();
        }

        private void FrmRPT_ControlNodos_Load(object sender, EventArgs e)
        {
            LlenadoNodosReporte();
            Clase_ReportesGenericos gn = new Clase_ReportesGenericos();
            gn.cargarRoles(lvRoles);
            gn.cargarCampus(lvCampus);
            btnGuardar.Enabled = false;
            lvCampus.Enabled = false;
        }

        private void LlenadoNodosReporte()
        {
            TreeViewNodos.Nodes.Clear();
            clase_ReportesCE = new Clase_ReportesCE();
            if (clase_ReportesCE.LlenadoNodosRCE())
            {
                if (clase_ReportesCE.Lector.Tables[0].Rows.Count > 0)
                {
                    crearNodo crearnodo = new crearNodo();
                    crearnodo.dataview_Nodo = new DataView(clase_ReportesCE.Lector.Tables[0]);
                    crearnodo.CrearNodos(0, null, TreeViewNodos);
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
                PositionBd = _elemento["Posicion"].ToString();
                NombreNodo = _elemento["TextoNodo"].ToString();
            }

            txt_IDNodo.Text = NNodo;
            txt_NodoPadre.Text = NPadre;
            txt_NombreNodo.Text = NombreNodo;
            txt_PosicionBD.Text = PositionBd;
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

        private void ExpandirNodoenInsercion(TreeNode nodo)
        {
            nodo.Expand();
            if (nodo.Parent != null)
            {
                ExpandirNodoenInsercion(nodo.Parent);
            }
        }

        private void ExpandirNodoenPosicion(TreeNode tn)
        {
            if (tn.Level == 0) tn.Expand();
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

        private void btn_AñadirNodo_Click(object sender, EventArgs e)
        {
            if (txtNombreNuevoNodo.Text.Trim() != "")
            {
                string indice;
                TreeNode NuevoNodo = new TreeNode(txtNombreNuevoNodo.Text.Trim());

                //Si no hay lo añade al nodo raíz
                if (TreeViewNodos.Nodes.Count == 0)
                {
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
                if (clase_ReportesCE.DMLNodo("1", NNodo, txtNombreNuevoNodo.Text.Trim()))
                {
                    MessageBox.Show("Nodo Insertado");
                }
                else
                {
                    MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Actualizar y expander el actual nodo
                LlenadoNodosReporte();
                TreeNode[] NodoaExpandir = TreeViewNodos.Nodes.Find(NNodo, true);
                ExpandirNodoenInsercion(NodoaExpandir[0]);
            }
            else
            {
                MessageBox.Show("No se puede ingresar un nombre al nodo, porfavor ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_AñadirNodoRaiz_Click(object sender, EventArgs e)
        {
            if(txtNombreNuevoNodo.Text.Trim() != "")
            {
                string nodopadre = "0"; 
                if (clase_ReportesCE.DMLNodo("1", nodopadre, txtNombreNuevoNodo.Text.Trim()))
                {
                    MessageBox.Show("Nodo Insertado con exito","Nodo",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void cargarCampusSeleccion(string nodo)
        {
            reporteCE = new Clase_ReportesCE();
            if (reporteCE.DMLPermisosNodosCampus("0","0","0",nodo))
            {
                DataView dt = new DataView(reporteCE.Lector.Tables[0]);
                reporteGenerico.llenarlistview(lvSeleccionarCampus, dt);
            }
            btnGuardarRoles.Enabled = false;
            lvRoles.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TreeViewNodos.SelectedNode != null)
                {
                    reporteCE = new Clase_ReportesCE();
                    string nodo = TreeViewNodos.SelectedNode.Name.ToString();
                    reporteCE.DMLPermisosNodosCampus("0","0","0",nodo);
                    np = new Clase_ReportesCE();

                    for (int x = 0; x < lvCampus.Items.Count; x++)
                    {
                        string tvName = TreeViewNodos.SelectedNode.Name.ToString();
                        string lvItem = lvCampus.Items[x].Text.ToString();
                        if (lvCampus.Items[x].Checked == true)
                        {
                            DataView dv = new DataView(reporteCE.Lector.Tables[0]);
                            if (reporteGenerico.checarPermiso(dv, Convert.ToInt32(lvItem)))
                                np.DMLPermisosNodosCampus("1",tvName, lvItem,"0");
                        }
                        else
                            np.DMLPermisosNodosCampus("2", tvName, lvItem,"0");
                    }
                    MessageBox.Show("Se han guardado los campus que pueden ver el nodo " + TreeViewNodos.SelectedNode.Text, "Confirmar", MessageBoxButtons.OK);
                    cargarCampusSeleccion(TreeViewNodos.SelectedNode.Name);

                }
                else
                {
                    MessageBox.Show("Selecciona un Nodo \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
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

                reporteCE = new Clase_ReportesCE();
                if (lvSeleccionarCampus.SelectedItems.Count > 0 && reporteCE.DMLRolesCampusNodos("0",lvSeleccionarCampus.SelectedItems[0].SubItems[0].Text, TreeViewNodos.SelectedNode.Name,"0"))
                {
                    DataView dt = new DataView(reporteCE.Lector.Tables[0]);
                    reporteGenerico.marcarnodos(lvRoles, dt);
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
                reporteCE = new Clase_ReportesCE();
                np = new Clase_ReportesCE();
                reporteCE.DMLRolesCampusNodos("0",lvSeleccionarCampus.SelectedItems[0].SubItems[0].Text, TreeViewNodos.SelectedNode.Name,"0");
                for (int x = 0; x < lvRoles.Items.Count; x++)
                {
                    string campus = lvSeleccionarCampus.SelectedItems[0].SubItems[0].Text;
                    string nodo = TreeViewNodos.SelectedNode.Name;
                    string rol = lvRoles.Items[x].Text;
                    if (Convert.ToInt32(rol) == 14 || Convert.ToInt32(rol) == 16)
                      lvRoles.Items[x].Checked = true;

                    if (lvRoles.Items[x].Checked == true)
                    {
                        DataView dv = new DataView(reporteCE.Lector.Tables[0]);
                        if (reporteGenerico.checarPermiso(dv, Convert.ToInt32(rol)))
                            np.DMLRolesCampusNodos("1",campus, nodo, rol);
                    }
                    else
                        np.DMLRolesCampusNodos("2",campus, nodo, rol);
                }
                MessageBox.Show("Se han guardados los roles del campus " + lvSeleccionarCampus.SelectedItems[0].SubItems[1].Text + " en el nodo " + TreeViewNodos.SelectedNode.Text, "Completado", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmRPT_EnlazarReporteNodos ern = new FrmRPT_EnlazarReporteNodos();
            ern.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComprobarPosicionNodo()
        {
            if (txt_Posicion.Text != txt_PosicionBD.Text)
            {
                btn_igualarPosicion.Visible = true;
            }
            else
            {
                btn_igualarPosicion.Visible = false;
            }
        }

        private void btn_igualarPosicion_Click(object sender, EventArgs e)
        {
            Clase_ReportesCE frm = new Clase_ReportesCE();
            if (frm.IgualarPosicionNodo(NPadre))
            {
                LlenadoNodosReporte();
                TreeNode[] NodoaExpandir = TreeViewNodos.Nodes.Find(NNodo, true);
                ExpandirNodoenInsercion(NodoaExpandir[0]);
                btn_igualarPosicion.Visible = false;
                txt_PosicionBD.Text = txt_Posicion.Text;
            }
            else 
            { 
                MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }//fin de clase
}
