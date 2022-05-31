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
    public partial class FrmAgregarRestriccionesReportesRol : Form
    {
        private GetUsuariosRestricciones ur;
        private Clase_ReportesCE cd;
        private ControlUsuariosRepo cu;
        private RestriccionesNodos rn;
        public FrmAgregarRestriccionesReportesRol()
        {
            InitializeComponent();
        }
        private void GetUsuarios(string campus)
        {
            try
            {
                ur = new GetUsuariosRestricciones();
                ur.GetUsuarios(campus);
                cBoxUsuarios.DataSource = ur.Lector.Tables[0];
                cBoxUsuarios.DisplayMember = "Usuario";
                cBoxUsuarios.ValueMember = "ID_Usuario";
                cBoxUsuarios.SelectedItem = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GetCampus()
        {
            try
            {
                ur = new GetUsuariosRestricciones();
                ur.GetCampus();
                cbCampus.DataSource = ur.Lector.Tables[0];
                cbCampus.DisplayMember = "Campus";
                cbCampus.ValueMember = "ID_Campus";
                cbCampus.SelectedItem = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmAgregarRestriccionesReportesRol_Load(object sender, EventArgs e)
        {
            GetCampus();
        }
        public void LlenadoNodosReporte(TreeView treeView)
        {
            try
            {
                GetRoles gr = new GetRoles();
                gr.getRol(cBoxUsuarios.SelectedValue.ToString());
                string rol = gr.Lector.Tables[0].Rows[0][0].ToString();
                cd = new Clase_ReportesCE();
                cd.OpcionesReporteControlEscolar(cbCampus.SelectedValue.ToString(), rol);
                string validar = cd.Lector.Tables[0].Rows[0][0].ToString();



                if (!validar.Equals("-1"))
                {

                    CrearNodosDelPadre(0, null, treeView);
                    btnAgregar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El usuario no tiene permisos para ver ningun reporte", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAgregar.Enabled = false;
                }
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
                MarcarNodos(nuevoNodo);
                    if (nodePadre == null)
                        treeView.Nodes.Add(nuevoNodo);
                    else
                        nodePadre.Nodes.Add(nuevoNodo);
                

                CrearNodosDelPadre(Int32.Parse(dataRowCurrent["nodo"].ToString()), nuevoNodo, treeView);
            }
        }
        private void MarcarNodos(TreeNode nodo)
            {
                 cu= new ControlUsuariosRepo();
                cu.GetRestriccionesUsuarioReportes(cBoxUsuarios.SelectedValue.ToString());
                DataView nodos = new DataView(cu.Lector.Tables[0]);

                for (int x = 0; x < nodos.Table.Rows.Count; x++)
                {
                 if (nodos.Table.Rows[x][0].ToString() == nodo.Name.ToString())
                    nodo.Checked = true;
                    
                    
            }
            
        }
        private void agregarRestriccion(string nodo)
        {
            rn.Agregar_RestriccionReportesNodos(cBoxUsuarios.SelectedValue.ToString(), nodo);
        }
        private void limpiarRestricciones()
        {
            rn = new RestriccionesNodos();
            rn.LimpiarRestriccionesNodos(cBoxUsuarios.SelectedValue.ToString());
        }
        private void VerificacionNodosRecursiva(TreeNode treeNode)
        { 
            foreach (TreeNode tn in treeNode.Nodes)
            {
                if (tn.Checked)
                    agregarRestriccion(tn.Name.ToString());
                else
                    VerificacionNodosRecursiva(tn);
            }
        }
        private void CallRecursive(TreeView treeView)
        {  
            foreach (TreeNode n in treeView.Nodes)
            {
                if (n.Checked)
                    agregarRestriccion(n.Name.ToString());
                else
                    VerificacionNodosRecursiva(n);
            }
        }
        private void cBoxUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tvPermisos.Nodes.Clear();
            if (cBoxUsuarios.SelectedValue != null)
                LlenadoNodosReporte(tvPermisos);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarRestricciones();
                CallRecursive(tvPermisos);
                MessageBox.Show("Se han agregado los cambios con exito", "Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cbCampus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tvPermisos.Nodes.Clear();
            btnAgregar.Enabled = false;
            if (cbCampus.SelectedValue != null)
            GetUsuarios(cbCampus.SelectedValue.ToString());
        }
    }
}
