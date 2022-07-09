﻿using ProyectoLoboSostenido;
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
            Clase_ReportesCE ReportesCe_NombresReportes;
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

            cargarReportesDataGriw();
            foreach (DataGridViewRow row in DGV_Reportes.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                chk.Value = chk.FalseValue;
                row.DefaultCellStyle.BackColor = Color.White;

            }
        }


        private void cargarReportesDataGriw()
        {
            var doWork = new DataGridViewCheckBoxColumn();
            doWork.Name = "Guardado";//Added so you can find the column in a row
            doWork.HeaderText = "";
            doWork.FalseValue = "0";
            doWork.TrueValue = "1";

            //Make the default checked
            doWork.CellTemplate.Value = false;
            doWork.CellTemplate.Style.NullValue = true;


            pr = new Clase_ReportesCE();
            pr.GetReportesNodo("");
            DGV_Reportes.DataSource = pr.Lector.Tables[0];
            DGV_Reportes.Columns.Insert(0, doWork);

            DGV_Reportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Reportes.AllowUserToAddRows = false;
            DGV_Reportes.AutoResizeColumns();
            DGV_Reportes.Columns[0].Width = 30;
            DGV_Reportes.Columns[1].HeaderText = "ID"; 
            DGV_Reportes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DGV_Reportes.Columns[1].Width = 50;

            foreach(DataGridViewColumn column in DGV_Reportes.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        public void LlenadoNodosReporte()
        {
            TreeViewNodos.Nodes.Clear();
            clase_ReportesCE = new Clase_ReportesCE();
            if (clase_ReportesCE.LlenadoNodosRCE())
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
                    //for (int i = 0; i < lvReportes.Items.Count; i++)
                    //    {
                    //        string reporte = lvReportes.Items[i].Text;
                    //        if (lvReportes.Items[i].Checked == true)
                    //        {
                    //            //pr.ActualizarNodoReporte(tree, reporte);
                    //        }
                    //        else
                    //        {
                    //    //        bool check = false;
                    //    //        for (int x = 0; x < p.Lector.Tables[0].Rows.Count; x++)
                    //    //        {
                    //    //            int valortable = Convert.ToInt32(p.Lector.Tables[0].Rows[x][0]);
                    //    //            if (valortable == Convert.ToInt32(reporte))
                    //    //            {
                    //    //                check = true;
                    //    //                break;
                    //    //            }
                    //    //        }
                    //    //        if (check)
                    //    //        {
                    //    //            pr.ActualizarNodoReporte("0", reporte);
                    //    //        }
                    //            Console.WriteLine("");
                    //        }
                    //}

                    for(int i = 0; i < DGV_Reportes.RowCount; i++)
                    {
                        string id_reporte = DGV_Reportes.Rows[i].Cells[1].Value.ToString().Trim();

                        DataGridViewCheckBoxCell celda_Check = (DataGridViewCheckBoxCell)DGV_Reportes.Rows[i].Cells[0];

                        if(celda_Check.Value == celda_Check.TrueValue)
                        {
                            pr.ActualizarNodoReporte(tree, id_reporte);
                        }
                        else
                        {
                            bool check = false;
                            for (int x = 0; x < ReportesCe_NombresReportes.Lector.Tables[0].Rows.Count; x++)
                            {
                                int valortable = Convert.ToInt32(ReportesCe_NombresReportes.Lector.Tables[0].Rows[x][0]);
                                if (valortable == Convert.ToInt32(id_reporte))
                                {
                                    check = true;
                                    break;
                                }
                            }
                            if (check)
                            {
                                pr.ActualizarNodoReporte("0", id_reporte);
                            }
                            
                        }
                    }

                    MessageBox.Show("Reportes Enlazados Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            pr.GetReportesNodo("");

            if (pr.Lector.Tables[0].Rows.Count > 0)
            {
                DataView dt = new DataView(pr.Lector.Tables[0]);
                //gn.llenarlistview(lvReportes, dt);
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
                ReportesCe_NombresReportes = new Clase_ReportesCE();
                ReportesCe_NombresReportes.GetReportesNodo(nodo);
                if (ReportesCe_NombresReportes.Lector.Tables.Count > 0)
                {
                    DataView DataView_NombresReportes = new DataView(ReportesCe_NombresReportes.Lector.Tables[0]);
                    gn.llenarlistview(lvReportesNodo, DataView_NombresReportes);

                    //gn.marcarnodos(lvReportes, dt);


                    //---
                    PonerTodoSinCheck();

                    foreach (DataRowView dataRenglon in DataView_NombresReportes) //recorremos los nodos que devuelve la consulta para que traego los reportes que esta relacionado al nodo
                    {
                        string id_reporte_consulta = dataRenglon.Row.ItemArray[0].ToString().Trim();
                        for (int i = 0  ; i < DGV_Reportes.Rows.Count; i++)
                        {
                            string id_reporte_Datagrid = DGV_Reportes.Rows[i].Cells[1].Value.ToString();
                            if (id_reporte_consulta == id_reporte_Datagrid)
                            {
                                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)DGV_Reportes.Rows[i].Cells[0];
                                chk.Value = chk.TrueValue;
                                DGV_Reportes.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                        }
                    }
                        //for (int i = 0; i < list.Items.Count; i++)
                        //{
                        //    list.Items[i].Checked = false;
                        //}

                        //foreach (DataRowView drv in dv)
                        //{
                        //    int dato = Convert.ToInt32(drv.Row[0]);

                        //    for (int i = 0; i < list.Items.Count; i++)
                        //    {
                        //        int lv = Convert.ToInt32(list.Items[i].Text);

                        //        if (lv == dato)
                        //        {
                        //            list.Items[i].Checked = true;
                        //            break;
                        //        }
                        //    }
                        //}


                        //-----
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error SQL", MessageBoxButtons.OK);
            }

        }

        public void PonerTodoSinCheck()
        {
            foreach (DataGridViewRow row in DGV_Reportes.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0]; //Convetimos la celda en DataGridViewCheckBoxCell
                chk.Value = chk.FalseValue;
                row.DefaultCellStyle.BackColor = Color.White;
                //----------------------------------------------------------

                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void txt_Buscador_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscador.Text.Trim() != "Buscador...")
            {
                (DGV_Reportes.DataSource as DataTable).DefaultView.RowFilter = string.Format("NombreReporte LIKE '%{0}%'", txt_Buscador.Text);
                PonerTodoSinCheck();
                DataView DataView_NombresReportes = new DataView(ReportesCe_NombresReportes.Lector.Tables[0]);
                foreach (DataRowView dataRenglon in DataView_NombresReportes)
                {
                    string id_reporte_consulta = dataRenglon.Row.ItemArray[0].ToString().Trim();
                    for (int i = 0; i < DGV_Reportes.Rows.Count; i++)
                    {
                        string id_reporte_Datagrid = DGV_Reportes.Rows[i].Cells[1].Value.ToString();
                        if (id_reporte_consulta == id_reporte_Datagrid)
                        {
                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)DGV_Reportes.Rows[i].Cells[0];
                            chk.Value = chk.TrueValue;
                            DGV_Reportes.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                }
            }

        }

        

        private void txt_Buscador_Click(object sender, EventArgs e)
        {
            if (txt_Buscador.Text.Trim() == "" || txt_Buscador.Text.Trim() == "Buscador...")
            {
                txt_Buscador.Text = "";
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

        private void DGV_Reportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                this.DGV_Reportes.CommitEdit(DataGridViewDataErrorContexts.Commit);

            ////Check the value of cell
            //if ((bool)DGV_Reportes.Rows[e.RowIndex].Cells[0].Value == true)
            //{
            //    MessageBox.Show("Queda descomentada");
            //}
            //else
            //{
            //    MessageBox.Show("Queda comentada");
            //}

            DataGridViewCheckBoxCell cell = this.DGV_Reportes.CurrentCell as DataGridViewCheckBoxCell;

            if (cell != null && !cell.ReadOnly)
            {
                if(cell.Value == cell.TrueValue)
                { 
                    DGV_Reportes.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen;

                }
                else
                { 
                    DGV_Reportes.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                }

                 
                this.DGV_Reportes.RefreshEdit();
                this.DGV_Reportes.NotifyCurrentCellDirty(true);
                
            }
        }
    }
}
