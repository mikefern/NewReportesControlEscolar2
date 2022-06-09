using FastReport;
using FastReport.Utils;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;



namespace ProyectoLoboSostenido
{

    public partial class DatosReportes : Form
    {

        public string nombre { get; private set; }
        public string ruta { get; private set; }
        public string ultimamodificacion { get; private set; }
        public string creacion { get; private set; }
        public string ultimoacceso { get; private set; }
        public string extension { get; private set; }
        public string descripcionModificaciones { get; private set; }
        public string id_Empleado { get; private set; }
        public string opt { get; private set; }
        public object actualizar_automatico { get; private set; }

        public string idreporte;
        string rutaArchivo = string.Empty;
        int numerototalnombre;
        DateTime dt; //FechaCreacion
        DateTime dateTime; //FechaModificación
        DateTime datet;//FechaUltimoAcceso 
        string rutaBD;


        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void DatosReportes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }
        #endregion


        public DatosReportes()
        {
            InitializeComponent();


        }

        public void Habilitar()
        {
            foreach (Control ctrl1 in groupBox1.Controls)
            {
                if (ctrl1 is RichTextBox)
                {
                    ctrl1.Enabled = true;

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnAbrircarpeta_Click(object sender, EventArgs e)
        {
            Process.Start(@"\\10.11.10.12");
        }
        private void label1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirarchivo_Click(object sender, EventArgs e)
        {


            string filename = rutaArchivo;
            string result;
            string extension;

            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = OpenFileDialog.FileName; //rutaArchivo
            }
            txtRuta.Text = rutaArchivo;
            txtPeso.Text = Convert.ToString(rutaArchivo.Length + " " + "bytes");//TamañoArchivo
            dt = File.GetLastWriteTime(rutaArchivo);//Ultimamodificación
            dateTime = File.GetCreationTime(rutaArchivo);//CreacionArchivo
            datet = File.GetLastAccessTime(rutaArchivo);//Fecha de ultimo acceso
            txtUltima_Mod.Text = dt.ToString();
            txtCreacion.Text = dateTime.ToString();
            txtAcceso.Text = datet.ToString();
            result = Path.GetFileNameWithoutExtension(rutaArchivo);//Nombre de archivo sin extensión
            txtNombreArchivo.Text = result;
            extension = Path.GetExtension(rutaArchivo);
            txtExtension.Text = extension;
            numerototalnombre = txtNombreArchivo.Text.Length + txtExtension.Text.Length;
            //Imprimir reporte FastReport
            string miReporte = @"Loboone\Reportes\rptCertificadoNvo_18.frx";  //Loboone\Reportes\RPTCardexGenericoAlumno.frx
            string thisFolder = Config.ApplicationFolder;
            Report frxReport = new Report();
            for (int i = 1; i < 6; i++)
            {
                if (File.Exists(thisFolder + miReporte))
                {

                    previewReportes.Buttons = PreviewButtons.Print | PreviewButtons.Zoom | PreviewButtons.Navigator; //Print reporte 
                    previewReportes.ZoomPageWidth();
                    frxReport.Preview = previewReportes;
                    frxReport.Load(thisFolder + miReporte);
                    frxReport.SetParameterValue("@ID_Alumno", "3919045025");
                    frxReport.Show();
                    previewReportes.ZoomPageWidth();
                    break;
                }
                thisFolder += @"..\";
            }

            Clase_Reportes getid = new Clase_Reportes(); //Procedimiento para obtener el IDReporte 

            if (getid.GetIDReporte(txtNombreArchivo.Text))
            {

                if (getid.Lector.Tables.Count > 0)
                {
                    if (getid.Lector.Tables[0].Rows.Count > 0)
                    {
                        //MessageBox.Show("ID Reporte Encontrado");
                        idreporte = getid.Lector.Tables[0].Rows[0]["ID"].ToString();
                        txtIDReporte.Text = idreporte;
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = true;


                    }
                    else
                    {
                        btnModificar.Enabled = false;
                        btnGuardar.Enabled = true;
                        txtIDReporte.Text = String.Empty;
                    }
                }
                else
                {
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = true;
                    txtIDReporte.Text = String.Empty;
                }
            }

            else
            {
                MessageBox.Show("Falla en el procedimiento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void DatosReportes_Load(object sender, EventArgs e)
        {
            Habilitar();
            //........
            txtIDReporte.Enabled = false;
            txtPeso.Enabled = false;
            txtUltima_Mod.Enabled = false;
            txtAcceso.Enabled = false;
            txtCreacion.Enabled = false;
            txtExtension.Enabled = true;
            // MessageBox.Show("En caso de realizar alguna modificación en los reportes, favor de comentar su nombre completo, nombre de archivo y cambios realizados en el apartado Decripción de Modificaciones", "DESCRIPCION DE MODIFICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MostrarReportes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string path = txtRuta.Text;
            if (!File.Exists(path))
            {
                File.Create(path);
                txtCreacion.Text = File.GetCreationTime(path).ToString();
                txtUltima_Mod.Text = File.GetLastWriteTime(path).ToString();
                txtAcceso.Text = File.GetLastAccessTime(path).ToString();
                txtPeso.Text = path.Length.ToString();

                MessageBox.Show("El archivo fue creado");
            }
            else
            {
                MessageBox.Show("El archivo ya existe");
            }


            Clase_Reportes reportes = new Clase_Reportes();

            if (reportes.DetalleArchivoReporte("1", txtNombreArchivo.Text, txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, txtExtension.Text, txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtIDReporte.Text) == true)
            {
                if (reportes.Lector.Tables.Count > 0)
                {
                    MessageBox.Show("El registro ya existe", "REGISTRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            btnModificar.Enabled = true;

            //System.Diagnostics.Process.Start(@"C:\Program Files (x86)\FastReports\FastReport.Net Demo\Designer.exe");//abrir el exe de fastreports
            MostrarReportes();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnGuardarDB(object sender, EventArgs e)

        {
            Clase_Reportes reportes = new Clase_Reportes();

            if (reportes.DetalleArchivoReporte("1", txtNombreArchivo.Text, txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, txtExtension.Text, txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtIDReporte.Text) == true)
            {
                if (reportes.Lector.Tables.Count > 0)
                {
                    MessageBox.Show("El registro ya existe", "REGISTRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            btnModificar.Enabled = true;

            MostrarReportes();
        }
        private void btnGuardarCambios(object sender, EventArgs e)
        {


            Clase_Reportes reportes = new Clase_Reportes();

            if (reportes.DetalleArchivoReporte("2", txtNombreArchivo.Text, txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, txtExtension.Text, txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtIDReporte.Text) == true)
            {

                MessageBox.Show("Registro actualizado correctamente", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el registro, contacte al departamento de sistemas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Cambiar nombre del archivo en el directorio
            string fullPath = Path.GetFullPath(txtRuta.Text);
            //Con esta instrucción obtienes la ruta donde está el archivo origen
            string soloRuta = Path.GetDirectoryName(fullPath);

            //Con esta instrucción combinas la ruta de origen con el nuevo nombre de archivo
            string nombreNuevo = Path.Combine(soloRuta, txtNombreArchivo.Text + txtExtension.Text);

            File.Move(fullPath, nombreNuevo);
            MostrarReportes();
        }

        private void MostrarReportes()
        {
            Clase_Reportes mostrar = new Clase_Reportes();
            mostrar.GetNombreReporte();
            GridViewReportes.DataSource = mostrar.Lector.Tables[0];
            GridViewReportes.AllowUserToResizeRows = false;
            GridViewReportes.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in GridViewReportes.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            GridViewReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewReportes.AutoResizeColumns();

            GridViewReportes.Columns[0].Visible = false;
            GridViewReportes.Columns[2].Visible = false;
            GridViewReportes.Columns[3].Visible = false;
            GridViewReportes.Columns[4].Visible = false;
            GridViewReportes.Columns[5].Visible = false;
            GridViewReportes.Columns[6].Visible = false;
            GridViewReportes.Columns[7].Visible = false;
            GridViewReportes.Columns[8].Visible = false;
            GridViewReportes.Columns[9].Visible = false;
           // this.GridViewReportes.Refresh();
            
            if (GridViewReportes.RowCount > 0)
            {
                //MessageBox.Show("Reportes en DB");
            }
            else
            {
                MessageBox.Show("No se puede mostrar la información");

            }
        }

        private void GridViewReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDReporte.Text = GridViewReportes.CurrentRow.Cells[0].Value.ToString();
            txtNombreArchivo.Text = GridViewReportes.CurrentRow.Cells[1].Value.ToString();
            txtRuta.Text = GridViewReportes.CurrentRow.Cells[2].Value.ToString();
            txtUltima_Mod.Text = GridViewReportes.CurrentRow.Cells[3].Value.ToString();
            txtCreacion.Text = GridViewReportes.CurrentRow.Cells[4].Value.ToString();
            txtAcceso.Text = GridViewReportes.CurrentRow.Cells[5].Value.ToString();
            txtExtension.Text = GridViewReportes.CurrentRow.Cells[6].Value.ToString();
            txtDescripcionModificaciones.Text = GridViewReportes.CurrentRow.Cells[7].Value.ToString();

            Clase_Reportes getruta = new Clase_Reportes();

            if (getruta.GetRuta(txtNombreArchivo.Text))
            {

                if (getruta.Lector.Tables.Count > 0)
                {
                    if (getruta.Lector.Tables[0].Rows.Count > 0)
                    {
                        rutaBD = getruta.Lector.Tables[0].Rows[0]["Ruta"].ToString();
                        txtRuta.Text = rutaBD;
                    }
                }
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clase_Reportes reportes = new Clase_Reportes();

            if (reportes.DetalleArchivoReporte("3", txtNombreArchivo.Text, txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, txtExtension.Text, txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtIDReporte.Text) == true)
            {

                MessageBox.Show("El registro ha sido eliminado", "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el reporte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string archivo = txtRuta.Text; //Eliminar el reporte de la carpeta
            try
            {
                File.Delete(archivo);
                if (File.Exists(archivo))
                {
                    MessageBox.Show("No se pudo eliminar el reporte");
                }
                else
                {
                    MessageBox.Show("Reporte eliminado");
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar el reporte");
            }

 
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            //Mover archivo de ruta 
            string ruta1 = rutaBD;
            string ruta2 = txtRuta.Text;
            File.Move(ruta1, ruta2);

            Clase_Reportes reportes = new Clase_Reportes();

            if (reportes.DetalleArchivoReporte("2", txtNombreArchivo.Text, txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, txtExtension.Text, txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtIDReporte.Text))
            {

                MessageBox.Show("El archivo se cambió a la ruta especificada", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede cambiar la ruta del archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            FolderBrowserDialog folderDlgCompartida = new FolderBrowserDialog();
            if (folderDlgCompartida.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderDlgCompartida.SelectedPath + "\\" + txtNombreArchivo.Text + txtExtension.Text;

            }
        }
    }

}














