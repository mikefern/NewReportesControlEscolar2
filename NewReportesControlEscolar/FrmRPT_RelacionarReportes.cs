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
using NewReportesControlEscolar;

namespace NewReportesControlEscolar
{
    public partial class FrmRPT_RelacionarReportes : Form
    {

        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void RelacionReportes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        public FrmRPT_RelacionarReportes()
        {
            InitializeComponent();
        }
        private void RelacionReportes_Load(object sender, EventArgs e)
        {
            MostrarReportesDetalle();
            MostrarReportesControl();

        }
        private void MostrarReportesDetalle()
        {
            Clase_ReportesCE mostrar = new Clase_ReportesCE();
            mostrar.GetNombreReporte();
            GridViewDetalles.DataSource = mostrar.Lector.Tables[0];
            GridViewDetalles.AllowUserToResizeRows = false;
            GridViewDetalles.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in GridViewControl.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            GridViewDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewDetalles.AutoResizeColumns();

            GridViewDetalles.Columns[0].Visible = false;
            GridViewDetalles.Columns[2].Visible = false;
            GridViewDetalles.Columns[3].Visible = false;
            GridViewDetalles.Columns[4].Visible = false;
            GridViewDetalles.Columns[5].Visible = false;
            GridViewDetalles.Columns[6].Visible = false;
            GridViewDetalles.Columns[7].Visible = false;
            GridViewDetalles.Columns[8].Visible = false; 

           
        }
        private void MostrarReportesControl()
        {
            Clase_ReportesCE mostrar1 = new Clase_ReportesCE();
            mostrar1.GetReportesNodo("");
            GridViewControl.DataSource = mostrar1.Lector.Tables[0];
            GridViewControl.AllowUserToResizeRows = false;
            GridViewControl.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in GridViewControl.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            GridViewControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewControl.AutoResizeColumns();
            GridViewControl.Columns[0].Visible = false;

            /* GridViewControl.Columns[0].Visible = false;
             GridViewControl.Columns[1].Visible = false;
             GridViewControl.Columns[3].Visible = false;
             GridViewControl.Columns[4].Visible = false;
             GridViewControl.Columns[5].Visible = false;
             GridViewControl.Columns[6].Visible = false;*/


            if (GridViewControl.RowCount > 0)
            {
                //MessageBox.Show("Reportes en DB");
            }
            else
            {
                //MessageBox.Show("No se puede mostrar la información");
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelacionar_Click(object sender, EventArgs e)
        {
            if (txtIDControl.Text == null || txtIDControl.Text == "" || txtIDDetalle.Text == null || txtIDDetalle.Text == "")
            {
                MessageBox.Show("Favor de elegir los reportes a relacionar", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtIDDetalle.Text = string.Empty;
                txtIDControl.Text = string.Empty;
            }

            else
            {
                RelacionarID();
                
            }
        }
        private void RelacionarID() // Tabla ReportesControlEscolar 
        {
            Clase_ReportesCE relaciona = new Clase_ReportesCE();

            if (relaciona.DML_ReportesControlEscolar("1",txtIDControl.Text, txtIDDetalle.Text) == true)//GetIDRepRel
            {

                MessageBox.Show("Se ha guardado el ID", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("No se pudo relacionar el ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EliminarRelacion()
        {
            Clase_ReportesCE relaciona = new Clase_ReportesCE();

            if (relaciona.DML_ReportesControlEscolar("2", txtIDControl.Text, txtIDDetalle.Text) == true)//GetIDRepRel
            {

                MessageBox.Show("Se ha eliminado la relación", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la relación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtIDDetalle.Text = string.Empty;
            txtRelacionado.Text = string.Empty;
            MostrarReportesControl();
            
        }
        


        private void GridViewDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDDetalle.Text = GridViewDetalles.CurrentRow.Cells[0].Value.ToString();

        }

        private void GridViewControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDControl.Text = GridViewControl.CurrentRow.Cells[0].Value.ToString();
            Clase_ReportesCE getID = new Clase_ReportesCE(); //Procedimiento para obtener el IDReporte 

            if (getID.DML_ReportesControlEscolar("0",txtIDControl.Text,""))
            {

                if (getID.Lector.Tables.Count > 0)
                {
                    if (getID.Lector.Tables[0].Rows.Count > 0)
                    {
                        //MessageBox.Show("ID Reporte Encontrado");
                        string idreporte = getID.Lector.Tables[0].Rows[0]["ID_RelArchivoReporte"].ToString();
                        txtRelacionado.Text = idreporte;
                        txtIDDetalle.Text = idreporte;
                    }
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarRelacion_Click(object sender, EventArgs e)
        {
            if (txtIDControl.Text == null || txtIDControl.Text == "" || txtIDDetalle.Text == null || txtIDDetalle.Text == "")
            {
                MessageBox.Show("Favor de elegir la relación a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDDetalle.Text = string.Empty;
                txtIDControl.Text = string.Empty;
            }
            else
            {
                EliminarRelacion();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}




