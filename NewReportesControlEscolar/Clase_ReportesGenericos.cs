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
                for (int i = 0; i < ur.Lector.Tables[0].Rows.Count; i++)
                {
                    var item = new ListViewItem();
                    item.Text = ur.Lector.Tables[0].Rows[i][0].ToString();
                    item.SubItems.Add(ur.Lector.Tables[0].Rows[i][1].ToString()); // 1st column text
                    lvCampus.Items.Add(item);
                }
            }
        }

        public void cargarRoles(ListView lvRoles)
        {
            PermisosReportes pr = new PermisosReportes();
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
                        list.Items[i].Checked = true;
                }
            }
        }



    }
}

