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
using ProyectoLoboSostenido;

namespace NewReportesControlEscolar
{
    public partial class FrmRPT_AsignacionParametrosReporte : Form
    {
        string idparametro = "";
        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void RelacionParametrosReporte_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        public FrmRPT_AsignacionParametrosReporte()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarReportesDetalle()
        {
            Clase_ReportesCE mostrar = new Clase_ReportesCE();
            mostrar.GetNombreReporte();
            DGV_DetalleReporte.DataSource = mostrar.Lector.Tables[0];
            DGV_DetalleReporte.AllowUserToResizeRows = false;
            DGV_DetalleReporte.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in DGV_DetalleReporte.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            DGV_DetalleReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_DetalleReporte.AutoResizeColumns();

            DGV_DetalleReporte.Columns[0].Visible = false;
            DGV_DetalleReporte.Columns[2].Visible = false;
            DGV_DetalleReporte.Columns[3].Visible = false;
            DGV_DetalleReporte.Columns[4].Visible = false;
            DGV_DetalleReporte.Columns[5].Visible = false;
            DGV_DetalleReporte.Columns[6].Visible = false;
            DGV_DetalleReporte.Columns[7].Visible = false;
            DGV_DetalleReporte.Columns[8].Visible = false;
            DGV_DetalleReporte.Columns[9].Visible = false;

            if (DGV_DetalleReporte.RowCount > 0)
            {
                DGV_DetalleReporte.Rows[0].Selected = true;
                txtIDReporte.Text = DGV_DetalleReporte.Rows[0].Cells[0].Value.ToString();
                txtNombreReporte.Text = DGV_DetalleReporte.Rows[0].Cells[1].Value.ToString();
                getParametros();
                Guardados();
            }
        }

        private void RelacionParametrosReporte_Load(object sender, EventArgs e)
        {
            MostrarReportesDetalle();
            checkbox();
            listViewParametros.Visible = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;

        }

       

        private void getParametros()
        {
            Clase_ReportesCE parametros = new Clase_ReportesCE();
            parametros.MostrarParametros();
            listViewParametros.Items.Clear();
            if (parametros.Lector.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < parametros.Lector.Tables[0].Rows.Count; i++)
                {
                    var item = new ListViewItem();
                    item.Text = parametros.Lector.Tables[0].Rows[i][0].ToString();
                    item.SubItems.Add(parametros.Lector.Tables[0].Rows[i][1].ToString()); // 1st column text
                    listViewParametros.Items.Add(item);
                    

                }
            }
        }
       
        private void checkbox()
        {
            foreach (CheckBox c in listViewParametros.Controls)
            {
                c.Checked = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clase_ReportesCE agregar = new Clase_ReportesCE();
            //if(agregar.AsignarParametros(txtIDReporte.Text, idparametro) == true)
            //{
            //    if(agregar.Lector.Tables.Count > 0)
            //    {
            //        MessageBox.Show("El parametro ya esta asignado al reporte");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Parametro agregado");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Favor de revisar el procedimiento");
            //}

            if (txtIDReporte != null && txtNombreReporte != null)
            {

                for (int i = 0; i < listViewParametros.Items.Count; i++)
                {

                    if (listViewParametros.Items[i].Checked)
                    {
                        idparametro = idparametro + "," + listViewParametros.Items[i].Text;
                    }
                }
                if (idparametro != "") idparametro = idparametro.Substring(1);

                

                if (agregar.AsignarParametros(txtIDReporte.Text, idparametro))
                {
                    MessageBox.Show("Se han agregado los parametros", "Confirmado", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error en el procedimiento", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                idparametro = "";

                //MessageBox.Show(idparametro);
               
                listViewParametros.Visible = false;
                Guardados();
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
            }
        }
       

        private void Guardados() //Tabla RelParametroReporte
        {
            if (txtIDReporte != null)
            {
                try
                {
                    Clase_ReportesCE guardados= new Clase_ReportesCE();
                    if (guardados.GetParametrosOK(txtIDReporte.Text))
                    {
                        DGVNombreParametro.DataSource = guardados.Lector.Tables[0];
                        DGVNombreParametro.Columns[0].Visible = false;
                        DGVNombreParametro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                        for (int i = 0; i < listViewParametros.Items.Count; i++)
                            listViewParametros.Items[i].Checked = false;

                        for (int i = 0; i < listViewParametros.Items.Count; i++)
                        {
                            for (int j = 0; j < guardados.Lector.Tables[0].Rows.Count; j++)
                            {
                                if (guardados.Lector.Tables[0].Rows[j][0].ToString() == listViewParametros.Items[i].Text.ToString())
                                {
                                    listViewParametros.Items[i].Checked = true;
                                }
                            }
                               
                            
                        }
                    }
                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudieron extraer los datos de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            listViewParametros.Visible = true;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void DGV_DetalleReporte_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_DetalleReporte.SelectedRows.Count > 0)
            {
                if (DGV_DetalleReporte.CurrentRow != null)
                {
                    txtIDReporte.Text = DGV_DetalleReporte.CurrentRow.Cells[0].Value.ToString();
                    txtNombreReporte.Text = DGV_DetalleReporte.CurrentRow.Cells[1].Value.ToString();
                    Guardados();
                    listViewParametros.Visible = false;
                }
            }
        }
    }
}


