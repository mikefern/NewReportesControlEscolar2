using FastReport;
using FastReport.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms; 
using System.Net;
using NewReportesControlEscolar;
using System.ComponentModel;

namespace ProyectoLoboSostenido
{
    public partial class FrmDatosReportes : Form
    {

        #region VARIABLES
        Clase_ReportesCE claseParametros;
        string[,] vecParametros;
        string idreporte;
        string rutaArchivo = string.Empty;
        DateTime DT_FechaCreacion; //FechaCreacion
        DateTime DT_FechaModificacion; //FechaModificación
        DateTime DT_FechaUltimoAcceso;//FechaUltimoAcceso 
        string rutaBD;
        #endregion

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
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lbltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        public FrmDatosReportes()
        {
            InitializeComponent();
        }

        private void DatosReportes_Load(object sender, EventArgs e)
        {
            Habilitar();

            txtIDReporte.Enabled = false;
            txtPeso.Enabled = false;
            txtUltima_Mod.Enabled = false;
            txtAcceso.Enabled = false;
            txtCreacion.Enabled = false;
            CB_Extension.Enabled = true;
            pictureIcono.Image = null;
            CB_Extension.SelectedIndex = 0;
            MostrarReportes();
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

        public void Limpiar()
        {
            foreach (Control ctrl1 in groupBox1.Controls)
            {
                if (ctrl1 is RichTextBox)
                {
                    ctrl1.Text = string.Empty;

                }
            }
        }

        

        private void label1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btn_AbrirArchivo_Click(object sender, EventArgs e)
        {
            string filename = rutaArchivo;
            string result;
            string extension;
            int numerototalnombre;

            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.InitialDirectory = "c:\\";
            OpenFileDialog.Filter = "(*.frx)|*.frx|(*.rpt)|*.rpt";
            OpenFileDialog.FilterIndex = 1;
            OpenFileDialog.RestoreDirectory = true;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = OpenFileDialog.FileName; //rutaArchivo
                txtRuta.Text = rutaArchivo;
                txtPeso.Text = Convert.ToString(rutaArchivo.Length + " " + "bytes");//TamañoArchivo
                DT_FechaCreacion = File.GetLastWriteTime(rutaArchivo);//Ultimamodificación
                DT_FechaModificacion = File.GetCreationTime(rutaArchivo);//CreacionArchivo
                DT_FechaUltimoAcceso = File.GetLastAccessTime(rutaArchivo);//Fecha de ultimo acceso
                txtUltima_Mod.Text = DT_FechaCreacion.ToString();
                txtCreacion.Text = DT_FechaModificacion.ToString();
                txtAcceso.Text = DT_FechaUltimoAcceso.ToString();
                result = Path.GetFileNameWithoutExtension(rutaArchivo);//Nombre de archivo sin extensión
                txtNombreArchivo.Text = result;
                extension = Path.GetExtension(rutaArchivo);
                CB_Extension.SelectedItem = extension;
                numerototalnombre = txtNombreArchivo.Text.Length + CB_Extension.SelectedItem.ToString().ToString().Length;

                Clase_ReportesCE getid = new Clase_ReportesCE(); //Procedimiento para obtener el IDReporte 

                if (getid.GetIDReporte(txtNombreArchivo.Text))
                {
                    if (getid.Lector.Tables.Count > 0)
                    {
                        if (getid.Lector.Tables[0].Rows.Count > 0)
                        {
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
            else
            {
                MessageBox.Show("Favor de abrir un archivo", "ATENCION",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_AbrirArchivoEdicion_Click(object sender, EventArgs e)
        {
            if (txtRuta.Text != "")
            {
                try
                {
                    Process proceso = new Process();
                    proceso.StartInfo.FileName = txtRuta.Text;
                    proceso.Start();
                }
                catch (System.ComponentModel.Win32Exception error)
                {
                    MessageBox.Show("No se encuentra el archivo en la ruta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor de abrir un archivo", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btn_Abrircarpeta_Click(object sender, EventArgs e)
        {
            string Ruta = @"\\10.11.10.230";
            System.Diagnostics.Process.Start("explorer.exe", Ruta);
        }


        public void visualizarReporte()
        {

            


            label11.Visible = false;
            string miReporte = @"\Loboone\Reportes\" + txtNombreArchivo.Text + CB_Extension.SelectedItem.ToString();// rptCertificadoNvo_18_251.frx";  //Loboone\Reportes\RPTCardexGenericoAlumno.frx
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

                    //for(int y= 0; y<vecParametros.Length;y++)
                    //{
                    //    string NombreParamtreo = vecParametros[y, 0].ToString().Trim();
                    //    string valor = vecParametros[y, 1].ToString().Trim();

                    // if(valor!="")
                    //frxReport.SetParameterValue("@ID_Empleado", "1815251004");
                   // MessageBox.Show(frxReport.Parameters[0].Name + frxReport.Parameters[0].Expression);//+ "" + frxReport.GetParameterValue());
                        // frxReport.SetParameterValue("@x", "1815251004");

                    //}

                    frxReport.Show();
                    previewReportes.ZoomPageWidth();
                    break;
                }
                thisFolder += @"..\";
            }
            Clase_ParametrosReportes pr = new Clase_ParametrosReportes();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombreArchivo.Text) || string.IsNullOrEmpty(txtRuta.Text) || string.IsNullOrEmpty(CB_Extension.SelectedItem.ToString().ToString()))
            {
                MessageBox.Show("Favor de llenar los campos Nombre Archivo, Extensión y Ruta", "Creacion de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string path = txtRuta.Text;

                if (!File.Exists(path))
                {
                    try 
                    { 
                        File.Create(path);
                        txtCreacion.Text = File.GetCreationTime(path).ToString();
                        txtUltima_Mod.Text = File.GetLastWriteTime(path).ToString();
                        txtAcceso.Text = File.GetLastAccessTime(path).ToString();
                        txtPeso.Text = path.Length.ToString();

                        MessageBox.Show("El archivo fue creado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clase_ReportesCE reportes = new Clase_ReportesCE();

                        if (reportes.DetalleArchivoReporte("1", txtNombreArchivo.Text, txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, CB_Extension.SelectedItem.ToString(), txtDescripcionModificaciones.Text, "0010040031", txtIDReporte.Text) == true)
                        {
                            if (reportes.Lector.Tables.Count > 0)
                            {
                                MessageBox.Show("El registro ya existe", "REGISTRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Registro guardado correctamente", "REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                                btnModificar.Enabled = true;

                                MostrarReportes();
                        }
                        else
                        {
                            MessageBox.Show("Favor de revisar los datos registrados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch(System.IO.DirectoryNotFoundException error)
                    {
                        MessageBox.Show("No Existe la ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo ya existe","Detalle Reporte",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

              
            }
            
        }



        private void btnGuardarDB(object sender, EventArgs e) //Tabla DetalleArchivoReporte

        {
            Clase_ReportesCE reportes = new Clase_ReportesCE();
            if (txtNombreArchivo.Text == null || txtNombreArchivo.Text == "")
            {
                MessageBox.Show("Favor de elegir el reporte a guardar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (reportes.DetalleArchivoReporte("1", txtNombreArchivo.Text, txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, CB_Extension.SelectedItem.ToString(), txtDescripcionModificaciones.Text, "001040031", txtIDReporte.Text) == true)
                {
                    if (reportes.Lector.Tables.Count > 0)
                    {
                        MessageBox.Show("El registro ya Existe", "REGISTRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
        private void btnGuardarCambios(object sender, EventArgs e)
        {
            Clase_ReportesCE reportes = new Clase_ReportesCE();
            if (txtNombreArchivo.Text != null || txtNombreArchivo.Text != "")
            {

                reportes.DetalleArchivoReporte("0", txtNombreArchivo.Text.Trim(), "", "", "", "", "", "", "", "");

                //verificar si ya existe un reporte con el mismo nombre
                if(reportes.Lector.Tables[0].Rows.Count>0)
                {
                    MessageBox.Show("ya existe un archivo con el mismo Nombre, porfavor Cambie de nombre o modifique el archivo ya existente");

                }
                else
                {

                    string ruta = reportes.Lector.Tables[0].Rows[0][2].ToString();

                    if (ruta != txtRuta.Text.Trim())
                    {


                    }
                    //Cambiar nombre del archivo en el directorio
                    string fullPath = Path.GetFullPath(txtRuta.Text);
                    //Con esta instrucción obtienes la ruta donde está el archivo origen
                    string soloRuta = Path.GetDirectoryName(fullPath);

                    //Con esta instrucción combinas la ruta de origen con el nuevo nombre de archivo
                    string nombreNuevo = Path.Combine(soloRuta, txtNombreArchivo.Text + CB_Extension.SelectedItem.ToString());

                    txtRuta.Text = nombreNuevo;
                    File.Move(fullPath, nombreNuevo);

                    if (reportes.DetalleArchivoReporte("2", txtNombreArchivo.Text, txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, CB_Extension.SelectedItem.ToString(), txtDescripcionModificaciones.Text, "001040031", txtIDReporte.Text) == true)
                    {

                        MessageBox.Show("Registro actualizado correctamente", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro, contacte al departamento de sistemas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    MostrarReportes();
                }

               
            }
            else
            {
                MessageBox.Show("El nombre del Archivo no puede quedar vacio", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }


        }

        private void MostrarReportes()
        {
            Clase_ReportesCE clase_reportes = new Clase_ReportesCE();
            clase_reportes.GetNombreReporte();

            DGV_Reportes.DataSource = clase_reportes.Lector.Tables[0];
            DGV_Reportes.AllowUserToResizeRows = false;
            DGV_Reportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Reportes.AllowUserToAddRows = false;
            DGV_Reportes.AutoResizeColumns();
            foreach (DataGridViewColumn column in DGV_Reportes.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;

            DGV_Reportes.Columns[0].Visible = false;//ID
            DGV_Reportes.Columns[2].Visible = false;//Ruta
            DGV_Reportes.Columns[3].Visible = false;//FechaUltimaModificacion
            DGV_Reportes.Columns[4].Visible = false;//FechaCreacion
            DGV_Reportes.Columns[5].Visible = false;//FechaUltimoAcceso
            DGV_Reportes.Columns[6].Visible = false;//Extension
            DGV_Reportes.Columns[7].Visible = false;//Descripcion
            DGV_Reportes.Columns[8].Visible = false;//Id_Empleado
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtNombreArchivo.Text != null || txtNombreArchivo.Text != "")
            { 
                if (MessageBox.Show("¿Estás seguro de eliminar el reporte?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Clase_ReportesCE reportes = new Clase_ReportesCE();
                    if (reportes.DetalleArchivoReporte("3", txtNombreArchivo.Text, txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, CB_Extension.SelectedItem.ToString(), txtDescripcionModificaciones.Text, "001040031", txtIDReporte.Text) == true)
                    {
                        MessageBox.Show("El registro ha sido eliminado", "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el reporte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Eliminar el reporte de la carpeta
                    string archivo = txtRuta.Text;
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

                    MostrarReportes();
                }
                else
                {
                    MessageBox.Show("El reporte no ha sido eliminado", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor de elegir el reporte a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtNombreArchivo.Text == null || txtNombreArchivo.Text == "" || txtRuta.Text == null || txtRuta.Text == "")
            {
                MessageBox.Show("Elija el reporte y nueva ubicación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Mover archivo de ruta 
                string ruta1 = rutaBD;
                string ruta2 = txtRuta.Text;
                File.Move(ruta1, ruta2);

                Clase_ReportesCE reportes = new Clase_ReportesCE();

                if (reportes.DetalleArchivoReporte("2", txtNombreArchivo.Text, txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, CB_Extension.SelectedItem.ToString(), txtDescripcionModificaciones.Text, "001040031", txtIDReporte.Text))
                {

                    MessageBox.Show("El archivo se cambió a la ruta especificada", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede cambiar la ruta del archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
                

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (txtNombreArchivo.Text.Trim() != "")
            {
                FolderBrowserDialog folderDlgCompartida = new FolderBrowserDialog();
                if (folderDlgCompartida.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = folderDlgCompartida.SelectedPath + "\\" + txtNombreArchivo.Text + CB_Extension.SelectedItem.ToString();
                }
            }
            else
            {
                MessageBox.Show("Debes Ingresar un Nombre de Archivo", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar(object sender, EventArgs e)
        {
            Limpiar();
        }


        string V_IDReporte;
        string V_NombreArchivo;
        string V_Extension;
        string V_Ruta;
        string V_Fecha_UltimaMod;
        string V_Fecha_Creacion;
        string V_Acceso;
        string V_Descripcion;

        private void DGV_Reportes_SelectionChanged(object sender, EventArgs e)
        {


            V_IDReporte = DGV_Reportes.CurrentRow.Cells[0].Value.ToString().Trim();
            V_NombreArchivo = DGV_Reportes.CurrentRow.Cells[1].Value.ToString().Trim();
            V_Extension = DGV_Reportes.CurrentRow.Cells[6].Value.ToString().Trim();
            V_Ruta = DGV_Reportes.CurrentRow.Cells[2].Value.ToString().Trim();
            V_Fecha_UltimaMod = DGV_Reportes.CurrentRow.Cells[3].Value.ToString().Trim();
            V_Fecha_Creacion = DGV_Reportes.CurrentRow.Cells[4].Value.ToString().Trim();
            V_Acceso = DGV_Reportes.CurrentRow.Cells[5].Value.ToString().Trim();
            V_Descripcion = DGV_Reportes.CurrentRow.Cells[7].Value.ToString().Trim();

            txtIDReporte.Text = V_IDReporte;
            txtNombreArchivo.Text = V_NombreArchivo;
            CB_Extension.SelectedItem = V_Extension;
            txtRuta.Text = V_Ruta;
            txtUltima_Mod.Text = V_Fecha_UltimaMod;
            txtCreacion.Text = V_Fecha_Creacion;
            txtAcceso.Text = V_Acceso;
            txtDescripcionModificaciones.Text = V_Descripcion;


            bool result = File.Exists(V_Ruta);
            if (result == true)
            {
                txtExistencia.Text = "SI";
            }
            else
            {
                txtExistencia.Text = "NO";
            }

            //Clase_ReportesCE getruta = new Clase_ReportesCE();

            //if (getruta.GetRuta(txtNombreArchivo.Text))
            //{

            //    if (getruta.Lector.Tables.Count > 0)
            //    {
            //        if (getruta.Lector.Tables[0].Rows.Count > 0)
            //        {
            //            rutaBD = getruta.Lector.Tables[0].Rows[0]["Ruta"].ToString();
            //            txtRuta.Text = rutaBD;
            //        }
            //    }
            //}
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            string nombreArchivo = txtNombreArchivo.Text + CB_Extension.SelectedItem.ToString();
            string rutaOriginal = txtRuta.Text.Replace("\\"+nombreArchivo,"");
            var RutaLocalReportes = System.Reflection.Assembly.GetExecutingAssembly().Location.ToString().Replace("bin\\Debug\\NewReportesControlEscolar.exe", "LoboOne\\Reportes"); 
            CopiarArchivo(nombreArchivo, rutaOriginal, RutaLocalReportes.ToString());
        }

        public void CopiarArchivo(string fileName, string sourcePath, string targetPath)
        {
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            System.IO.Directory.CreateDirectory(targetPath);

            if (System.IO.Directory.Exists(sourcePath))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
                MessageBox.Show("Archivo Copiado a la ruta de proyecto Reportes");
            }
            else
            {
                MessageBox.Show("Error no se encontro la ruta \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public string networkPath = @"\\10.11.10.230";
        NetworkCredential credentials = new NetworkCredential(@"{sistemas}", "{Kp91S!NPBt0U}");
        public string myNetworkPath = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            if (CB_Extension.SelectedItem.ToString() == ".frx")
            {
                previewReportes.Visible = true;
                crystalReport.Visible = false;
            }
            else
            {
                previewReportes.Visible = false;
                crystalReport.Visible = true;
            }

            if (txtIDReporte.Text != "")
            {

                claseParametros = new Clase_ReportesCE();
                claseParametros.GetParametros_Reportes(txtIDReporte.Text);

                if (claseParametros.Lector.Tables[0].Rows.Count > 0)
                {


                    int tamVector = claseParametros.Lector.Tables[0].Rows.Count;
                    vecParametros = new string[tamVector, 2];

            Clase_ReportesCE getruta = new Clase_ReportesCE();

                    for (int i = 0; i < tamVector; i++)
                    {

                        vecParametros[i, 0] = claseParametros.Lector.Tables[0].Rows[i][1].ToString();
                        vecParametros[i, 1] = claseParametros.Lector.Tables[0].Rows[i][2].ToString();
                    }

                    Console.WriteLine(vecParametros);

                    visualizarReporte();
                }
                else
                {
                    if (MessageBox.Show("El reporte guardado en BD no tiene parametros relacionados , ve a la pantalla de relacion de parametros para asignar uno al reporte \n " +
                      "o deseas abrir el reporte con sus datos precargados ", "espera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        visualizarReporte();
                    }

                }
            }
            else
            {
                label11.Visible = true;
            }
        }
         
         
        private void btn_ReemplazarCarpeta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreArchivo.Text))
            {
                txtRuta.Text = @"\\189.197.190.214\Sistemas\ReportesCE\" + txtNombreArchivo.Text.Trim() + CB_Extension.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("por favor ingresa un nombre al archivo \n", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}






