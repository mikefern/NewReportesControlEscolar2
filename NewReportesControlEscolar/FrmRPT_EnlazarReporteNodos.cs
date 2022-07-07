using ProyectoLoboSostenido;
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

namespace NewReportesControlEscolar
{
    public partial class FrmRPT_EnlazarReporteNodos : Form
    {

        #region VARIABLES
            Clase_ReportesGenericos gn = new Clase_ReportesGenericos();
            Clase_ReportesCE clase_ReportesCE;
            Clase_ReportesCE pr;
            Clase_ReportesCE p;
        #endregion
        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        public FrmRPT_EnlazarReporteNodos()
        {
            InitializeComponent();
        }
       
        private void FrmEnlazarReportesNodos_Load(object sender, EventArgs e)
        {
            LlenadoNodosReporte();
            cargarReportes();
        }

        public void LlenadoNodosReporte()
        {
            TreeViewNodos.Nodes.Clear();
            clase_ReportesCE = new Clase_ReportesCE();
            if (clase_ReportesCE.LlenadoNodosReporteEscolar())
            {
                if (clase_ReportesCE.Lector.Tables.Count > 0)
                {
                    crearNodo cn = new crearNodo();
                    cn.dataview_Nodo = new DataView(clase_ReportesCE.Lector.Tables[0]);
                    cn.CrearNodos(0, null, TreeViewNodos);
                }
                else 
                    MessageBox.Show("No tiene Ningun Nodo Asingado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string tree = TreeViewNodos.SelectedNode.Name;
                pr = new Clase_ReportesCE();
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
                                if (valortable == Convert.ToInt32(reporte))
                                {
                                    check = true;
                                    break;
                                }
                            }
                            if (check)
                            {
                                pr.ActualizarNodoReporte("0", reporte);
                            }
                        }
                    }
                    cargarReportesnodos(tree);
                }
                else
                {
                    MessageBox.Show("Favor de seleccionar otro nodo, ya que este es un nodo padre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error SQL", MessageBoxButtons.OK);
            }
        }

        private void cargarReportes()
        {
            pr = new Clase_ReportesCE();
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
                p = new Clase_ReportesCE();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        } 
        
    }
}
