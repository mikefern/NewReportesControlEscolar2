using System; 
using System.Data; 
using System.Runtime.InteropServices; 
using System.Windows.Forms;
using System.Drawing;  
using System.Linq;
using ProyectoLoboSostenido;

namespace NewReportesControlEscolar
{
    public partial class FrmRPT_AsignacionCampusReportes : Form
    {
        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        #region VARIABLES
        private Clase_ReportesCE clase_reportes;
            private Clase_ReportesCE ReportCE;
            private Clase_ReportesGenericos Genericos = new Clase_ReportesGenericos();
        #endregion

        int count;
        int CCC;
        string[] nodosGuardados;
        bool ItemChecheck = true;

        private  ListView LV_RVOE_Temporal;
        private  Clase_LitViewRVOE[] ArrayRVOEListView;

        public FrmRPT_AsignacionCampusReportes()
        {
            InitializeComponent();
        }

        private void FrmRPT_AsignacionCampusReportes_Load(object sender, EventArgs e)
        {

            Genericos.cargarCampus(LV_Campus);
            Genericos.cargarRoles(LV_Roles);
            CargarReportes();
        }

        private void CargarReportes()
        {
            clase_reportes = new Clase_ReportesCE();
            clase_reportes.GetReportesNodo("");
            if (clase_reportes.Lector.Tables[0].Rows.Count > 0)
            {
                DGV_Reportes.DataSource = clase_reportes.Lector.Tables[0];
                DGV_Reportes.Columns[0].HeaderText = "ID"; 
                DGV_Reportes.AutoResizeColumns();
                DGV_Reportes.Columns[0].Width = 50;
            }
        }

        private void DGV_Reportes_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_Reportes.SelectedRows.Count > 0)
            {
                LV_Campus.Enabled = true;
                LV_RVOE.Enabled = true;
                LV_CampusEspecificos.Enabled = true;

                CargarCampusReportes(DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString());

                LV_RVOE.Items.Clear();
                LV_Roles.Enabled = false;
                btnGuardarRoles.Enabled = false;
                btnGuardarRVOE.Enabled = false;
                btnGuardarCampus.Enabled = true;
            }
        }

        private void CargarCampusReportes(string Id_Reporte)
        {
            LV_CampusEspecificos.Items.Clear();
            clase_reportes = new Clase_ReportesCE();
            clase_reportes.DMLRelCampusReporte("0",Id_Reporte,"0");//Select 
            if (clase_reportes.Lector.Tables.Count > 0)
            {
                DataView dt1 = new DataView(clase_reportes.Lector.Tables[0]);
                Genericos.marcarnodos(LV_Campus, dt1);
                Genericos.llenarlistview(LV_CampusEspecificos, dt1);
            }
        }

        private void lvCampusEspecificos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (LV_CampusEspecificos.SelectedItems.Count > 0)
                {
                    cargarRVOE();
                }
                LV_Roles.Enabled = true;
                btnGuardarRoles.Enabled = true;
                btnGuardarRVOE.Enabled = true;
                txt_BuscadorRVOE.Text = "Buscador...";
                txt_BuscadorRVOE.ForeColor = Color.Silver;

                CB_Maestria.Checked = false;
                CB_Doctorado.Checked = false;
                CB_Other.Checked = false;
                CB_All_None.Checked = false;
                CargarRolesReportes(DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString());

                //CargarRolesReportes(DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch
            {

            }
        }

        private void CargarRolesReportes(string id_reporte)
        {
            clase_reportes = new Clase_ReportesCE();
            string id_campus = LV_CampusEspecificos.SelectedItems[0].SubItems[0].Text;
            if (clase_reportes.DMLRelRolesReportes("0","0", id_campus, id_reporte))
            {
                DataView dt = new DataView(clase_reportes.Lector.Tables[0]);
                Genericos.marcarnodos(LV_Roles, dt);
            }
        }


        private void cargarRVOE()
        {
            string id_reporte = DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString();
            string id_campus = LV_CampusEspecificos.SelectedItems[0].SubItems[0].Text;

            /*clase_reportes = new Clase_ReportesCE();
            clase_reportes.MostrarRVOESCampusReportes(id_campus);

            if (clase_reportes.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(clase_reportes.Lector.Tables[0]);
                Genericos.llenarlistview(LV_RVOE, dt);
            }

            clase_reportes = new Clase_ReportesCE();
            if(clase_reportes.DMLRVOEReportes("0", id_reporte, "0", id_campus)) //consultar
            {
                DataView dt = new DataView(clase_reportes.Lector.Tables[0]);
                Genericos.marcarnodos(LV_RVOE, dt);
            }*/

            Cargar_Lista_RVOE(id_campus);

            clase_reportes = new Clase_ReportesCE();
            if (clase_reportes.DMLRVOEReportes("0", id_reporte, "0", id_campus)) //consultar
            {
                DataView dt = new DataView(clase_reportes.Lector.Tables[0]);
                Genericos.marcarnodos(LV_RVOE, dt);
            }

        }
        /**********************************************************************************************************************************************/
        private void Cargar_Lista_RVOE(string id_campus)
        {

            clase_reportes = new Clase_ReportesCE();
            clase_reportes.MostrarRVOESCampusReportes(id_campus);
            if (clase_reportes.Lector.Tables[0].Rows.Count > 0)
            {
                nodosGuardados = new string[clase_reportes.Lector.Tables[0].Rows.Count];
                DataView dataview_lector = new DataView(clase_reportes.Lector.Tables[0]);
                //asignamos variables inicio
                count = 0;
                //limpiar la Lista
                LV_RVOE.Items.Clear();
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
                    LV_RVOE.Items.Add(new ListViewItem(new[] { item.V_ID, item.V_RVOE }));
                }

                LV_RVOE_Temporal = LV_RVOE;

            }
        }

        private void btnGuardarCampus_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Reportes.SelectedRows[0] != null)
                {
                    ReportCE = new Clase_ReportesCE();
                    string id_reporte = DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString();
                    ReportCE.DMLRelCampusReporte("0",id_reporte,"0");

                    clase_reportes = new Clase_ReportesCE();
                    for (int i = 0; i < LV_Campus.Items.Count; i++)
                    {
                        string reporte = DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString();
                        string campus = LV_Campus.Items[i].Text;
                        if (LV_Campus.Items[i].Checked == true)
                        {
                            DataView dv = new DataView(ReportCE.Lector.Tables[0]);
                            if (Genericos.checarPermiso(dv, Convert.ToInt32(campus)))
                                clase_reportes.DMLRelCampusReporte("1",reporte, campus);
                        }
                        else
                            clase_reportes.DMLRelCampusReporte("2",reporte, campus);

                    }
                    MessageBox.Show("Se han guardado los campus del reporte", "Completado", MessageBoxButtons.OK);
                    CargarCampusReportes(id_reporte);
                    LV_Roles.Enabled = false;
                    btnGuardarRoles.Enabled = false;
                    btnGuardarRVOE.Enabled = false;
                }else MessageBox.Show("Selecciona un Reporte", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarRoles_Click(object sender, EventArgs e)
        {
            try
            {
                ReportCE = new Clase_ReportesCE();
                string id = LV_CampusEspecificos.SelectedItems[0].SubItems[0].Text;
                string repo = DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString();
                ReportCE.DMLRelRolesReportes("0","0",id,repo);
                clase_reportes = new Clase_ReportesCE();
                
                for(int i=0;i<LV_Roles.Items.Count; i++)
                {

                    string rol = LV_Roles.Items[i].Text;

                    if (Convert.ToInt32(rol) == 14 || Convert.ToInt32(rol) == 16)
                        LV_Roles.Items[i].Checked = true;

                    if (LV_Roles.Items[i].Checked == true)
                    {
                        DataView dv = new DataView(ReportCE.Lector.Tables[0]);
                        if (Genericos.checarPermiso(dv, Convert.ToInt32(rol)))
                            clase_reportes.DMLRelRolesReportes("1",rol, id, repo);
                    }
                    else
                        clase_reportes.DMLRelRolesReportes("2", rol, id, repo);
                }
                MessageBox.Show("Se han guardado los roles del reporte", "Completado", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarRVOE_Click(object sender, EventArgs exx)
        {
            try
            {
                string Id_Reporte = DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString();
                string id_campus = LV_CampusEspecificos.SelectedItems[0].SubItems[0].Text;
                ReportCE = new Clase_ReportesCE();
                ReportCE.DMLRVOEReportes("0",Id_Reporte,"0", id_campus);

                clase_reportes = new Clase_ReportesCE();
 
                Anadir_Array_RVOE_Checados();

                string cadena_Rvoes = "";
                cadena_Rvoes = String.Join(",", nodosGuardados.Where(s => !string.IsNullOrEmpty(s))).Replace(",,","");
                if (cadena_Rvoes.Length > 0)
                {
                    if (cadena_Rvoes.Substring(cadena_Rvoes.Length - 1)== ",")
                    {
                        cadena_Rvoes = cadena_Rvoes.Remove(cadena_Rvoes.Length - 1);
                    }
                }

                clase_reportes.DMLRVOEReportes("1", Id_Reporte, cadena_Rvoes,LV_CampusEspecificos.SelectedItems[0].Text);

                //---------------------------------------------
                //for (int i = 0; i < LV_RVOE.Items.Count; i++)
                //{
                //    string rvoe = LV_RVOE.Items[i].Text;
                //    if (LV_RVOE.Items[i].Checked == true)
                //    {
                //        DataView dv = new DataView(ReportCE.Lector.Tables[0]);
                //        //if (Genericos.checarPermiso(dv, Convert.ToInt32(rvoe)))
                //            //clase_reportes.DMLRVOEReportes("1",Id_Reportes, rvoe,"0"); //insert 
                //    }
                //    //aqui es donde voy a eliminar todos (sin filtro) excepto los que estan en el array
                //    //else
                //      //  clase_reportes.DMLRVOEReportes("2", Id_Reportes, rvoe,"0"); //Delete
                //}




                MessageBox.Show("Se han guardado los RVOE del reporte", "Completado", MessageBoxButtons.OK);
                txt_BuscadorRVOE.Text = "";
                txt_BuscadorRVOE.Text = "Buscador...";
                txt_BuscadorRVOE.ForeColor = Color.Silver;

                cargarRVOE();
                //clase_reportes = new Clase_ReportesCE();
                //if (clase_reportes.DMLRVOEReportes("0", Id_Reporte, "0", id_campus)) //consultar
                //{
                //    DataView dt = new DataView(clase_reportes.Lector.Tables[0]);
                //    Genericos.marcarnodos(LV_RVOE, dt);
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUsuariosReportesw_Click(object sender, EventArgs e)
        {
            FrmRPT_RestriccionesRolReportes rr = new FrmRPT_RestriccionesRolReportes();
            rr.Show();
        }
                 
       

       

        class Clase_LitViewRVOE
        {
            public string V_ID { get; set; }

            public string V_RVOE { get; set; }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txt_BuscadorRVOE.Text.Trim() == "" || txt_BuscadorRVOE.Text.Trim() == "Buscador...")
            {
                txt_BuscadorRVOE.Text = "";
            }
        }

        private void txt_BuscadorRVOE_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_BuscadorRVOE.ForeColor = Color.Black;
        }

        private void txt_BuscadorRVOE_Leave(object sender, EventArgs e)
        {
            if (txt_BuscadorRVOE.Text.Trim() == "" || txt_BuscadorRVOE.Text.Trim() == "Buscador...")
            {
                txt_BuscadorRVOE.Text = "Buscador...";
                txt_BuscadorRVOE.ForeColor = Color.Silver;
            }
        }

        private void txt_BuscadorRVOE_TextChanged(object sender, EventArgs e)
        {
            if (!txt_BuscadorRVOE.Text.Trim().Equals("Buscador...") )
            {
                if (nodosGuardados == null)
                {
                    nodosGuardados = new string[clase_reportes.Lector.Tables[0].Rows.Count];
                }
                CCC = 0;
                //------------------------------------------
                //1 - Guardamos Los Id que esten Chequeados
                Anadir_Array_RVOE_Checados();
                //---------------------------------------------
                //2 - Ejecutamos la busqueda
                ItemChecheck = false;
                SearchData(txt_BuscadorRVOE.Text.Trim());
                ItemChecheck = true;
                //-------------------------------------------
                //3 - poner los checks previamente guardados de nuevo en true o false
                for (int x = 0; x < LV_RVOE.Items.Count; x++)
                {
                    string id_rvoe_actual = LV_RVOE.Items[x].Text;

                    for (int y = 0; y < nodosGuardados.Length; y++)
                    {
                        if (nodosGuardados[y] != null)
                        {
                            string id_rvoe_guardado = nodosGuardados[y].ToString();

                            if (id_rvoe_guardado == id_rvoe_actual)
                            {
                                LV_RVOE.Items[x].Checked = true;
                            } 
                        }
                    }
                }
                //----------------------------------------------------

            }
        }

        public void Anadir_Array_RVOE_Checados()
        {
            for (int y = 0; y < LV_RVOE.Items.Count; y++)
            {
                if (LV_RVOE.Items[y].Checked)
                {
                    if (nodosGuardados[CCC] == null)
                    {
                        nodosGuardados[CCC] = LV_RVOE.Items[y].Text;
                    }
                    else
                    {
                        if (!nodosGuardados.Contains(LV_RVOE.Items[y].Text))
                        {
                            while (nodosGuardados[CCC] != null)
                            {
                                CCC = CCC + 1;
                            }
                            nodosGuardados[CCC] = LV_RVOE.Items[y].Text;
                        }
                    }
                }
            }
        }

        private void SearchData(string texto)
        {
            LV_RVOE.Items.Clear();
            if (ArrayRVOEListView != null)
            {
                foreach (Clase_LitViewRVOE item in ArrayRVOEListView)
                {
                    if (item.V_RVOE.ToLower().Contains(texto.ToLower()))
                    {
                        LV_RVOE.Items.Add(new ListViewItem(new[] { item.V_ID, item.V_RVOE }));
                    }
                }
            }
        }

        private void LV_RVOE_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (ItemChecheck)
            {
                if (!e.Item.Checked)
                {
                    //e.Item.BackColor = Color.White;
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
                //else e.Item.BackColor = Color.LightGreen;
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LV_CampusEspecificos.Items.Count; i++)
            {
                LV_CampusEspecificos.Items[i].Selected = true;

                try
                {
                    ReportCE = new Clase_ReportesCE();
                    string id = LV_CampusEspecificos.SelectedItems[0].SubItems[0].Text;
                    string repo = DGV_Reportes.SelectedRows[0].Cells[0].Value.ToString();
                    ReportCE.DMLRelRolesReportes("0", "0", id, repo);
                    clase_reportes = new Clase_ReportesCE();

                    for (int x = 0; x < LV_Roles.Items.Count; x++)
                    {

                        string rol = LV_Roles.Items[x].Text;

                        if (Convert.ToInt32(rol) == 14 || Convert.ToInt32(rol) == 16)
                            LV_Roles.Items[x].Checked = true;

                        if (LV_Roles.Items[x].Checked == true)
                        {
                            DataView dv = new DataView(ReportCE.Lector.Tables[0]);
                            if (Genericos.checarPermiso(dv, Convert.ToInt32(rol)))
                                clase_reportes.DMLRelRolesReportes("1", rol, id, repo);
                        }
                        else
                            clase_reportes.DMLRelRolesReportes("2", rol, id, repo);
                    }
                    MessageBox.Show("Se han guardado los roles del reporte", "Completado", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txt_Buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_Buscador.ForeColor = Color.Black;
        }

        

        private void txt_Buscador_Leave(object sender, EventArgs e)
        {
            if (txt_Buscador.Text.Trim() == "" || txt_Buscador.Text.Trim() == "Buscador...")
            {
                txt_Buscador.Text = "Buscador...";
                txt_Buscador.ForeColor = Color.Silver;
            }
        }
        private void txt_Buscador_Click(object sender, EventArgs e)
        {
            if (txt_Buscador.Text.Trim() == "" || txt_Buscador.Text.Trim() == "Buscador...")
            {
                txt_Buscador.Text = "";
            }
        }
        private void txt_Buscador_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                (DGV_Reportes.DataSource as DataTable).DefaultView.RowFilter = string.Format("NombreReporte LIKE '%{0}%'", txt_Buscador.Text);

                if (DGV_Reportes.SelectedRows.Count == 0)
                {
                    btnGuardarCampus.Enabled = false;
                    btnGuardarRoles.Enabled = false;

                    for (int i = 0; i < LV_Campus.Items.Count; i++)
                        LV_Campus.Items[i].Checked = false;
                    LV_Campus.Enabled = false;

                    for (int i = 0; i < LV_RVOE.Items.Count; i++)
                        LV_RVOE.Items[i].Checked = false;
                    LV_RVOE.Enabled = false;

                    LV_CampusEspecificos.Enabled = false;
                    LV_CampusEspecificos.Items.Clear();
                }
                else
                {
                    btnGuardarCampus.Enabled = true;
                    btnGuardarRoles.Enabled = true;
                }
            }
            catch (System.Data.SyntaxErrorException error) { error.ToString(); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LV_RVOE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_Maestria_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < LV_RVOE.Items.Count; y++)
            {
                LV_RVOE.Items[y].Checked = true;
            }
        }

        private void CB_Maestria_CheckedChanged_1(object sender, EventArgs e)
        {
            if(CB_Maestria.Checked)
            {
                for (int i = 0; i < LV_RVOE.Items.Count; i++)
                {
                    if(LV_RVOE.Items[i].SubItems[1].Text.Contains("Maest"))
                    {
                        LV_RVOE.Items[i].Checked = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < LV_RVOE.Items.Count; i++)
                {
                    if (LV_RVOE.Items[i].SubItems[1].Text.Contains("Maest"))
                    {
                        LV_RVOE.Items[i].Checked = false;
                    }
                }
            }
        }

        private void CB_Doctorado_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Doctorado.Checked)
            {
                for (int i = 0; i < LV_RVOE.Items.Count; i++)
                {
                    if (LV_RVOE.Items[i].SubItems[1].Text.Contains("Doct"))
                    {
                        LV_RVOE.Items[i].Checked = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < LV_RVOE.Items.Count; i++)
                {
                    if (LV_RVOE.Items[i].SubItems[1].Text.Contains("Doct"))
                    {
                        LV_RVOE.Items[i].Checked = false;
                    }
                }
            }
        }

        private void CB_Other_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Other.Checked)
            {
                for (int i = 0; i < LV_RVOE.Items.Count; i++)
                {
                    if (!LV_RVOE.Items[i].SubItems[1].Text.Contains("Doct") && !LV_RVOE.Items[i].SubItems[1].Text.Contains("Maest"))
                    {
                        LV_RVOE.Items[i].Checked = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < LV_RVOE.Items.Count; i++)
                {
                    if (!LV_RVOE.Items[i].SubItems[1].Text.Contains("Doct") && !LV_RVOE.Items[i].SubItems[1].Text.Contains("Maest"))
                    {
                        LV_RVOE.Items[i].Checked = false;
                    }
                }
            }
        }

        private void CB_All_None_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_All_None.Checked)
            {
                CB_All_None.Text = "Quitar Todo";
                for (int i = 0; i < LV_RVOE.Items.Count; i++)
                {
                    LV_RVOE.Items[i].Checked = true;
                }
            }
            else
            {
                CB_All_None.Text = "Seleccionar Todo";
                for (int i = 0; i < LV_RVOE.Items.Count; i++)
                {
                     LV_RVOE.Items[i].Checked = false;
                }
            }
        }
    }
}
