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
    public partial class FrmEnlazarReportesNodos : Form
    {
        public FrmEnlazarReportesNodos()
        {
            InitializeComponent();
        }

        private Clase_ReportesGenericos gn = new Clase_ReportesGenericos();
        Clase_ReportesCE clase_ReportesCE;
        PermisosReportes pr;
        PermisosReportes p;

        public void LlenadoNodosReporte()
        {
            TreeViewNodos.Nodes.Clear();
            clase_ReportesCE = new Clase_ReportesCE();
            if (clase_ReportesCE.LlenadoNodosReporteEscolar())
            {
                if (clase_ReportesCE.Lector.Tables[0].Rows.Count > 0)
                {
                    CrearNodos(0, null);
                }
                else MessageBox.Show("No tiene Ningun Nodo Asingado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string tree = TreeViewNodos.SelectedNode.Name;
                pr = new PermisosReportes();
                pr.GetNodoPadre(tree);
                if (pr.Lector.Tables[0].Rows.Count > 0 && Convert.ToInt32(pr.Lector.Tables[0].Rows[0][0]) > 0)
                {
                    for (int i = 0; i < lvReportes.Items.Count; i++)
                    {
                        string reporte = lvReportes.Items[i].Text;
                        if (lvReportes.Items[i].Checked == true)
                        {
                            pr.ActualizarNodoReporte(tree, reporte);
                        }
                        else
                        {
                            bool check = false;
                            for (int x = 0; x < p.Lector.Tables[0].Rows.Count; x++)
                            {
                                int valortable = Convert.ToInt32(p.Lector.Tables[0].Rows[x][0]);
                                if(valortable == Convert.ToInt32(reporte)){
                                    check = true;
                                    break;
                                }
                            }
                            if (check)
                                pr.ActualizarNodoReporte("0", reporte);

                        }
                    }
                    cargarReportesnodos(tree);
                }
                else
                    MessageBox.Show("Favor de seleccionar otro nodo, ya que este es un nodo padre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error SQL", MessageBoxButtons.OK);
            }
        }

        private void FrmEnlazarReportesNodos_Load(object sender, EventArgs e)
        {
            LlenadoNodosReporte();
            cargarReportes();
        }
        private void cargarReportes()
        {
            pr = new PermisosReportes();
            pr.GetReportesTodos();
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
                gn.llenarlistview(lvReportes, dt);
            }
        }

        private void TreeViewNodos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            cargarReportesnodos(e.Node.Name);
        }
        private void cargarReportesnodos(string nodo)
        {
            try
            {
                p = new PermisosReportes();
                p.GetReportesNodo(nodo);
                if (p.Lector.Tables.Count > 0)
                {
                    DataView dt = new DataView(p.Lector.Tables[0]);
                    gn.llenarlistview(lvReportesNodo, dt);
                    gn.marcarnodos(lvReportes, dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error SQL", MessageBoxButtons.OK);
            }

        }
    }
}
