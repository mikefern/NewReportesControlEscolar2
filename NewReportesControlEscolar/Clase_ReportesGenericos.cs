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
            GetUsuariosRestricciones ur = new GetUsuariosRestricciones();
            ur.GetCampus();
            if (ur.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(ur.Lector.Tables[0]);
                llenarlistview(lvCampus, dt);
            }
        }

        public void cargarRoles(ListView lvRoles)
        {
            PermisosReportes pr = new PermisosReportes();
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
                lv.Items.Add(item);
            }
        }
    }
}

