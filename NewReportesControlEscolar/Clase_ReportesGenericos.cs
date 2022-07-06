using ProyectoLoboSostenido;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewReportesControlEscolar
{
    class Clase_ReportesGenericos
    {

        public void cargarCampus(ListView lvCampus)
        {
            Clase_ReportesCE ur = new Clase_ReportesCE();
            ur.GetCampus();
            if (ur.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(ur.Lector.Tables[0]);
                llenarlistview(lvCampus, dt);
            }
        }

        public void cargarRoles(ListView lvRoles)
        {
            Clase_ReportesCE pr = new Clase_ReportesCE();
            pr.GetRoles();
            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
                llenarlistview(lvRoles, dt);
            }
        }

        public void marcarnodos(ListView list, DataView dv)
        {
            for (int i = 0; i < list.Items.Count; i++)
                list.Items[i].Checked = false;

            foreach(DataRowView drv in dv)
            {
                int dato = Convert.ToInt32(drv.Row[0]);
                for(int i=0; i<list.Items.Count; i++)
                {
                    int lv = Convert.ToInt32(list.Items[i].Text);
                    if (lv == dato)
                    {
                        list.Items[i].Checked = true;
                        break;
                    }
                }
            }
        }
        public void llenarlistview(ListView lv, DataView dv)
        {
            lv.Items.Clear();
            foreach(DataRowView drv in dv)
            {
                var item = new ListViewItem();
                item.Text = drv.Row[0].ToString();
                item.SubItems.Add(drv.Row[1].ToString());
               // item.SubItems.Add(drv.Row[2].ToString());
                lv.Items.Add(item);
            }
        }
        public bool checarPermiso(DataView dv, int comparar)
        {
            for (int x = 0; x < dv.Table.Rows.Count; x++)
            {
                int comparador = Convert.ToInt32(dv.Table.Rows[x][0]);
                if (comparar == comparador)
                    return false;
            }
            return true;
        }
    }

    public class crearNodo
    {
        public DataView dataview_Nodo = new DataView();

        public void CrearNodos(int indicePadre, TreeNode nodePadre, TreeView treeView)
        {
            DataView dataViewHijos = new DataView(dataview_Nodo.Table);
            dataViewHijos.RowFilter = dataview_Nodo.Table.Columns["NodoPadre"].ColumnName + " = " + indicePadre;
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["TextoNodo"].ToString().Trim();
                nuevoNodo.Name = dataRowCurrent["Nodo"].ToString().Trim();

                if (nodePadre == null)
                    treeView.Nodes.Add(nuevoNodo);
                else
                    nodePadre.Nodes.Add(nuevoNodo);

                CrearNodos(Int32.Parse(dataRowCurrent["nodo"].ToString()), nuevoNodo, treeView);
            }
        }

    }
}

