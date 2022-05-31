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
    public partial class FrmReportesLimitarNodos : Form
    {
        public FrmReportesLimitarNodos()
        {
            InitializeComponent();
        }

        private Clase_ReportesCE cd;
        private PermisosReportes pr;
        private NodosPermisos n;

        private void FrmReportesLimitarNodos_Load(object sender, EventArgs e)
        {
            LlenadoNodosReporte(tvNodos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmReportesAsignarCampusNodos ac = new FrmReportesAsignarCampusNodos();
            ac.Show();
        }

        public void LlenadoNodosReporte(TreeView treeView)
        {
            try
            {

                cd = new Clase_ReportesCE();
                cd.OpcionesReporteControlEscolar(Clase_Sesion.Campus, Clase_Sesion.Rol);
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

        private void tvNodos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                lvCampus.Items.Clear();
                n = new NodosPermisos();
                string nodo = e.Node.Name;
                if (n.GetCampusNodos(nodo))
                {
                    for (int i = 0; i < n.Lector.Tables[0].Rows.Count; i++)
                    {
                        var item = new ListViewItem();
                        item.Text = n.Lector.Tables[0].Rows[i][0].ToString();
                        item.SubItems.Add(n.Lector.Tables[0].Rows[i][1].ToString()); // 1st column text
                        lvCampus.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK);
            }
        }

        private void btnCampus_Click(object sender, EventArgs e)
        {

        }
    }
}
