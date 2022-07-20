using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLoboSostenido;

namespace NewReportesControlEscolar
{
    public partial class FrmRPT_ControlEscolarReports : Form
    {
        public string V_Ruta { get; private set; }
        public string V_NombreReporte { get; private set; }
        public string V_Campus { get; private set; }
        public string V_RVOE { get; private set; }
        public string V_Archivo { get; private set; }
        public object V_NombreArchivo { get; private set; }
        public string V_IDReporte { get; private set; }
        public string V_IDNodo { get; private set; }
        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmRPTControlEscolarReports_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
        public FrmRPT_ControlEscolarReports()
        {
            InitializeComponent();
        }

        private void MostrarReportesControl()
        {
            Clase_ReportesCE mostrar = new Clase_ReportesCE();
            mostrar.GetDatosReportesControl();
            DGV_ReportesCE.DataSource = mostrar.Lector.Tables[0];
            DGV_ReportesCE.AllowUserToResizeRows = false;
            DGV_ReportesCE.AllowUserToAddRows = false;
            DGV_ReportesCE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_ReportesCE.AutoResizeColumns();

            DGV_ReportesCE.Columns[0].Visible = false;
            DGV_ReportesCE.Columns[1].Visible = false;
            DGV_ReportesCE.Columns[3].Visible = false;
            DGV_ReportesCE.Columns[4].Visible = false;
            DGV_ReportesCE.Columns[5].Visible = false;
            DGV_ReportesCE.Columns[6].Visible = false;

            (DGV_ReportesCE.DataSource as DataTable).DefaultView.RowFilter = string.Format("NombreReporte LIKE '%{0}%'", "");
            txtBuscador.Text = "Buscador...";
            txtBuscador.ForeColor = Color.Silver;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "(*.frx)|*.frx|(*.rpt)|*.rpt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                txtNombreReporte.Text = Path.GetFileNameWithoutExtension(rutaArchivo);

            }
        }

        private void Limpiar()
        {
            foreach (Control ctrl1 in groupBox1.Controls)
            {
                if (ctrl1 is RichTextBox)
                {
                    ctrl1.Text = string.Empty;

                }
            }
        }

        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombreReporte.Text.Trim() == null || txtNombreReporte.Text.Trim() == "")
            {
                MessageBox.Show("Favor de elegir el reporte a guardar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clase_ReportesCE reportes = new Clase_ReportesCE();
                //Tabla ReportesControlEscolar
                {

                    if (reportes.ReportesControlEscolar("1", txtNodo.Text, txtNombreReporte.Text, txtRelCampus.Text, txtRelRvoe.Text, txtRelArchivo.Text) == true)
                    {
                        if (reportes.Lector.Tables.Count > 0)
                        {
                            MessageBox.Show("El Registro ya Existe", "REGISTRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registro guardado correctamente", "REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor de revisar los datos registrados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MostrarReportesControl();
                }
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)

        {
            if (txtNombreReporte.Text.Trim() == null || txtNombreReporte.Text.Trim() == "")
            {
                MessageBox.Show("Favor de elegir el reporte a guardar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clase_ReportesCE reportes = new Clase_ReportesCE();
                //Tabla ReportesControlEscolar
                {
                    if (reportes.ReportesControlEscolar("2", txtNodo.Text, txtNombreReporte.Text, txtRelCampus.Text, txtRelRvoe.Text, txtRelArchivo.Text) == true)
                    {
                        if (reportes.Lector.Tables.Count > 0)
                        {
                            MessageBox.Show("El Registro se actualizo correcramente", "REGISTRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registro actualizado correctamente", "REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor de revisar los datos registrados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MostrarReportesControl();
                }
            }

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtNombreReporte.Text.Trim() == null || txtNombreReporte.Text.Trim() == "")
            {
                MessageBox.Show("Favor de elegir el reporte a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clase_ReportesCE reportes = new Clase_ReportesCE();
                //Tabla ReportesControlEscolar
                {
                    if (reportes.ReportesControlEscolar("3", txtNodo.Text, txtNombreReporte.Text, txtRelCampus.Text, txtRelRvoe.Text, txtRelArchivo.Text) == true)
                    {
                        if (reportes.Lector.Tables.Count > 0)
                        {
                            MessageBox.Show("El Registro ha sido eliminado", "REGISTRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registro eliminado correctamente", "REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor de revisar el procedimiento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MostrarReportesControl();
                }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FrmRPTControlEscolarReports_Load(object sender, EventArgs e)
        {
            MostrarReportesControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRPT_RelacionarReportes relacionReportes = new FrmRPT_RelacionarReportes();
            relacionReportes.Show();
        }

        private void txtBuscador_Click_1(object sender, EventArgs e)
        {
            if (txtBuscador.Text.Trim() == "" || txtBuscador.Text.Trim() == "Buscador...")
            {
                txtBuscador.Text = "";
            }
        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtBuscador.ForeColor = Color.Black;
        }

        private void txtBuscador_Leave_1(object sender, EventArgs e)
        {
            if (txtBuscador.Text.Trim() == "" || txtBuscador.Text.Trim() == "Buscador...")
            {
                txtBuscador.Text = "Buscador...";
                txtBuscador.ForeColor = Color.Silver;
            }
        }

        private void txtBuscador_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscador.Text.Trim() != "Buscador...")
                (DGV_ReportesCE.DataSource as DataTable).DefaultView.RowFilter = string.Format("NombreReporte LIKE '%{0}%'", txtBuscador.Text);
        }

        private void DGV_ReportesCE_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_ReportesCE.SelectedRows.Count > 0)
            {
                V_IDReporte = DGV_ReportesCE.SelectedRows[0].Cells[0].Value.ToString().Trim();
                V_IDNodo = DGV_ReportesCE.SelectedRows[0].Cells[1].Value.ToString().Trim();
                V_NombreReporte = DGV_ReportesCE.SelectedRows[0].Cells[2].Value.ToString().Trim();
                V_Campus = DGV_ReportesCE.SelectedRows[0].Cells[3].Value.ToString().Trim();
                V_RVOE = DGV_ReportesCE.SelectedRows[0].Cells[5].Value.ToString().Trim();
                V_Archivo = DGV_ReportesCE.SelectedRows[0].Cells[6].Value.ToString().Trim();

                txtIDReporte.Text = V_IDReporte;
                txtNodo.Text = V_IDNodo;
                txtNombreReporte.Text = V_NombreReporte;
                txtRelCampus.Text = V_Campus;
                txtRelRvoe.Text = V_RVOE;
                txtRelArchivo.Text = V_Archivo;
            }
        }


    }

}














