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
    public partial class RelacionReportes : Form
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

        public RelacionReportes()
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
            Clase_Reportes mostrar = new Clase_Reportes();
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
            GridViewDetalles.Columns[9].Visible = false;

            if (GridViewControl.RowCount > 0)
            {
                // MessageBox.Show("Reportes en DB");
            }
            else
            {
                //MessageBox.Show("No se puede mostrar la información");
            }
        }
        private void MostrarReportesControl()
        {
            Clase_Reportes mostrar1 = new Clase_Reportes();
            mostrar1.GetNombreReporteControl();
            GridViewControl.DataSource = mostrar1.Lector.Tables[0];
            GridViewControl.AllowUserToResizeRows = false;
            GridViewControl.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in GridViewControl.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            GridViewControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewControl.AutoResizeColumns();
            GridViewControl.Columns[0].Visible = false;
            GridViewControl.Columns[1].Visible = false;
            GridViewControl.Columns[2].Visible = false;
            GridViewControl.Columns[3].Visible = false;
            GridViewControl.Columns[5].Visible = false;
            GridViewControl.Columns[6].Visible = false;
            GridViewControl.Columns[7].Visible = false;
            GridViewControl.Columns[8].Visible = false;
            GridViewControl.Columns[9].Visible = false;

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
            if (txtIDControl.Text == null || txtIDControl.Text== "" || txtIDDetalle.Text== null || txtIDDetalle.Text== "")
            {
                MessageBox.Show("El campo ID no debe estar vacío");
                txtIDDetalle.Text = string.Empty;
                txtIDControl.Text = string.Empty;
            }
                
            else
            {
                RelacionarID();
            }
        }
        private void RelacionarID()
        {
            Clase_Reportes relaciona = new Clase_Reportes();

            if (relaciona.IDRelacionado(txtIDDetalle.Text,txtIDControl.Text) == true)
            {

                MessageBox.Show("Se ha guardado el ID", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puedo relacionar el ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridViewDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDDetalle.Text = GridViewDetalles.CurrentRow.Cells[0].Value.ToString();

        }

        private void GridViewControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDControl.Text = GridViewControl.CurrentRow.Cells[0].Value.ToString();
        }
    }
}


