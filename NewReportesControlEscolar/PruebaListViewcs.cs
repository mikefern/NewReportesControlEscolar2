using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLoboSostenido; 

namespace NewReportesControlEscolar
{    
    public partial class PruebaListViewcs : Form
    {
        private Clase_ReportesCE clase_reportes;
        private Clase_ReportesCE clase_reporteX;

        private Clase_ReportesGenericos gn = new Clase_ReportesGenericos();


        private static ListView mylistView;
        private static TextBox searchTxt;
        private static Form myForm;
        private static Clase_LitViewRVOE[] ArrayRVOEListView;
        private static bool selected;
        private int count = 0;



        public PruebaListViewcs()
        {
            InitializeComponent();

            clase_reportes = new Clase_ReportesCE();
            clase_reportes.MostrarRVOESCampusReportes("02");


            if (clase_reportes.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dataview_lector = new DataView(clase_reportes.Lector.Tables[0]);
                //gn.llenarlistview(lvRVOE, dt);

                //asignamos variables inicio
                count = 0;
                //limpiar la Lista
                lvRVOE.Items.Clear();
                //Creacion y Definicion de Tamaño
                ArrayRVOEListView = new Clase_LitViewRVOE[clase_reportes.Lector.Tables[0].Rows.Count];
                //recorremos los renglones de la info que llenaremos en la lista
                foreach (DataRowView renglon in dataview_lector)
                {
                    string ID = renglon.Row[0].ToString();
                    string Rvoe = renglon.Row[1].ToString();
                    //en cada posicion del array le asignamos dicha informacion instanciada con la ClaseParaLista
                    ArrayRVOEListView[count] = new Clase_LitViewRVOE { V_ID = ID, V_RVOE = Rvoe, };
                    //incrementamos el count
                    count = count + 1;
                }

                //llenamos el listview
                foreach (Clase_LitViewRVOE item in ArrayRVOEListView)
                {
                    lvRVOE.Items.Add(new ListViewItem(new[] { item.V_ID, item.V_RVOE }));
                }


                clase_reporteX = new Clase_ReportesCE();
                if (clase_reporteX.DMLRVOEReportes("0", "687", "0", "02"))
                {
                    DataView dt = new DataView(clase_reporteX.Lector.Tables[0]);
                    gn.marcarnodos(lvRVOE, dt);

                }

                 

            }





        }

        private void SearchData(string texto)
        {


            lvRVOE.Items.Clear();
            foreach (Clase_LitViewRVOE item in ArrayRVOEListView)
            {
                if (item.V_RVOE.ToLower().Contains(texto.ToLower()))
                {
                    lvRVOE.Items.Add(new ListViewItem(new[] { item.V_ID, item.V_RVOE}));
                }
            }
        }

        string[] nodosGuardados;

        int CCC;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (nodosGuardados == null)
            { 
                nodosGuardados = new string[clase_reportes.Lector.Tables[0].Rows.Count];
                //CCC = 0; 
            }
            CCC = 0;

            //1 - Guardamos Los Id que esten Chequeados

            for (int y = 0; y < lvRVOE.Items.Count; y++)
            {
                if (lvRVOE.Items[y].Checked)
                {
                    if (nodosGuardados[CCC] == null)
                    {
                        nodosGuardados[CCC] = lvRVOE.Items[y].Text;
                    }
                    else
                    {
                        if (!nodosGuardados.Contains(lvRVOE.Items[y].Text))
                        { 
                            CCC = CCC + 1;
                            nodosGuardados[CCC] = lvRVOE.Items[y].Text;
                        }
                    }
                }
            }





            //foreach (DataRowView drv in new DataView(clase_reportes.Lector.Tables[0]))
            //{


            //    //int dato = Convert.ToInt32(drv.Row[0]);
            //    //



            //    for (int i = 0; i < lvRVOE.Items.Count; i++)
            //    {
            //        int idRvoe = Convert.ToInt32(lvRVOE.Items[i].Text);

            //        // nodosGuardados[]
            //    }
            //}

            //2 - Buscas el dato
            ItemChecheck = false;
            SearchData(textBox1.Text);
            ItemChecheck = true;

            for (int x = 0; x< lvRVOE.Items.Count; x++)
            {
               string id_rvoe_actual = lvRVOE.Items[x].Text; 

                 for( int y=0;y<nodosGuardados.Length;y++)
                 {
                    if (nodosGuardados[y] != null)
                    {
                       string id_rvoe_guardado = nodosGuardados[y].ToString();

                        if (id_rvoe_guardado == id_rvoe_actual)
                        {
                            lvRVOE.Items[x].Checked = true;
                        }
                    }
                 }
            }




           
        }







        //--------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            new FrmRPT_Principal_RCE().Show();
        }

        public bool ItemChecheck = true;
        private void lvRVOE_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (ItemChecheck)
            {
                if (!e.Item.Checked)
                {
                    if (nodosGuardados != null)
                    {
                        string id_rvoe_Actual = e.Item.Text.ToString();
                        for (int i = 0; i < nodosGuardados.Length; i++)
                        {
                            if (nodosGuardados[i] == id_rvoe_Actual)
                            {
                                nodosGuardados[i] = null;
                            }
                        }
                    }
                }
            }


        }
    }

    class Clase_LitViewRVOE
    {
        public string V_ID { get; set; }

        public string V_RVOE { get; set; }
    }


}
