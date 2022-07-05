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
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;

namespace ProyectoLoboSostenido
{
    public partial class FrmRPT_ArchivosReportes : Form
    {
        #region VARIABLES
        Clase_ReportesCE claseParametros;
        private readonly Reportes conrepor = new Reportes();
        public ReportDocument CryRpt { get; } = new ReportDocument();
        string[,] vecParametros; 
        DateTime DT_FechaCreacion; //FechaCreacion
        DateTime DT_FechaModificacion; //FechaModificación
        DateTime DT_FechaUltimoAcceso;//FechaUltimoAcceso 
        string rutaBD;
        bool cambioRadioButton = false;
        DateTime FechaActual = DateTime.Now;

        const string TIPO_EXISTE = "0";
        const string TIPO_INSERCION = "1";
        const string TIPO_MODIFICACION = "2";
        const string TIPO_ELIMINACION = "3";
        string Descripcion_Creacion = "Creacion del Archivo Por parte de ";
        string Descripcion_modificacion = "Modificacion por parte de ";
        bool flag_Visualizar = false;
        string V_IDReporte;
        string V_NombreArchivo;
        string V_Extension;
        string V_Ruta;
        string V_Fecha_UltimaMod;
        string V_Fecha_Creacion;
        string V_Acceso;
        string V_Descripcion;
        string V_Peso;
        #endregion

        #region Tootips
        private void Tootip()
        {
            ToolTip TTbtnAbrirArchivo = new ToolTip();
            TTbtnAbrirArchivo.SetToolTip(btn_AbrirArchivo, "Abrir archivo desde el explorador");
            ToolTip TTbtnAabrirArchivoEdicion = new ToolTip();
            TTbtnAabrirArchivoEdicion.SetToolTip(btn_AbrirArchivoEdicion, "Abrir archivo en Fast Reports y Crystal Reports");
            ToolTip TTbtnAbrircarpeta = new ToolTip();
            TTbtnAbrircarpeta.SetToolTip(btn_Abrircarpeta, "Abrir carpeta contenedora de reportes");
            ToolTip TTbtnCopiar = new ToolTip();
            TTbtnCopiar.SetToolTip(btnCopiarRutaLocal, "Copiar archivo de reporte a la ruta local");
            ToolTip TTbtn_ReemplazarCarpeta = new ToolTip();
            TTbtn_ReemplazarCarpeta.SetToolTip(btn_ReemplazarCarpeta, "Cambiar la ruta local por la ruta remota");
            ToolTip TTbtnCrearCopia = new ToolTip();
            TTbtnCrearCopia.SetToolTip(btnCrearCopia, "Copiar archivo de reporte a cualquier carpeta local");
            ToolTip TTbutton4 = new ToolTip();
            TTbutton4.SetToolTip(button4, "Copiar archivo de la carpeta Reportes a la carpeta ReportesCE");
            ToolTip TTbutton1 = new ToolTip();
            TTbutton1.SetToolTip(button1, "Prototipo de la vista de la vista delreporte");
            ToolTip TTbutton3 = new ToolTip();
            TTbutton3.SetToolTip(button3, "Visualizar los parametros que contiene el reporte");
            ToolTip TTbutton6 = new ToolTip();
            TTbutton6.SetToolTip(button6, "Actualizar reportes agregados a la base de datos");
            ToolTip TTbutton2 = new ToolTip();
            TTbutton2.SetToolTip(btn_NuevoArchivoCero, "Crear nuevo archivo inexistente");
            ToolTip TTbtnModificar = new ToolTip();
            ToolTip TTbtnCrearArchivo = new ToolTip();
            TTbtnCrearArchivo.SetToolTip(btnCrearArchivo, "Crear archivo que no existe en la maquina");
            TTbtnModificar.SetToolTip(btnModificar, "Modificar información de los reportes guardados en base de datos");
            ToolTip TTbtnGuardar = new ToolTip();
            TTbtnGuardar.SetToolTip(btnGuardar, "Guardar archivo en la base de datos");
            ToolTip TTbtnEliminar = new ToolTip();
            TTbtnEliminar.SetToolTip(btnEliminar,"Eliminar reporte");
            ToolTip TTbtn_CambiarSoloRutaBD = new ToolTip();
            TTbtn_CambiarSoloRutaBD.SetToolTip(btn_CambiarSoloRutaBD, "Cambiar la ruta de archivo solamente en la base de datos");




        }
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
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        public FrmRPT_ArchivosReportes() 
        {
            InitializeComponent();
            Tootip();
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
            DGV_Reportes.Columns[1].Visible = true; //NombreArchivo
            DGV_Reportes.Columns[2].Visible = false;//Extension
            DGV_Reportes.Columns[3].Visible = false;//ruta
            DGV_Reportes.Columns[4].Visible = false;//Peso Kb
            DGV_Reportes.Columns[5].Visible = false;//FechaUltimamodificacion
            DGV_Reportes.Columns[6].Visible = false;//FechaCreacion
            DGV_Reportes.Columns[7].Visible = false;//FechaUltimoAcceso
            DGV_Reportes.Columns[8].Visible = false;//DescripcionModificaciones
            DGV_Reportes.Columns[9].Visible = false;//Id_Empleado 
        }

        private void DGV_Reportes_SelectionChanged(object sender, EventArgs e)
        {
            if (!cambioRadioButton)
            {
                V_IDReporte = DGV_Reportes.CurrentRow.Cells[0].Value.ToString().Trim();
                V_NombreArchivo = DGV_Reportes.CurrentRow.Cells[1].Value.ToString().Trim();
                V_Extension = DGV_Reportes.CurrentRow.Cells[2].Value.ToString().Trim();
                V_Ruta = DGV_Reportes.CurrentRow.Cells[3].Value.ToString().Trim();
                V_Peso = DGV_Reportes.CurrentRow.Cells[4].Value.ToString().Trim();
                V_Fecha_UltimaMod = DGV_Reportes.CurrentRow.Cells[5].Value.ToString().Trim();
                V_Fecha_Creacion = DGV_Reportes.CurrentRow.Cells[6].Value.ToString().Trim();
                V_Acceso = DGV_Reportes.CurrentRow.Cells[7].Value.ToString().Trim();
                V_Descripcion = DGV_Reportes.CurrentRow.Cells[8].Value.ToString().Trim();

                txtIDReporte.Text = V_IDReporte;
                txtNombreArchivo.Text = V_NombreArchivo;
                CB_Extension.SelectedItem = V_Extension;
                if (V_Peso == "" || V_Peso == "0") V_Peso = PesoArchivo(V_Ruta);
                txtPeso.Text = V_Peso;
                txtRuta.Text = V_Ruta;
                txtUltima_Mod.Text = V_Fecha_UltimaMod;
                txtCreacion.Text = V_Fecha_Creacion;
                txtAcceso.Text = V_Acceso;
                txtDescripcionModificaciones.Text = V_Descripcion;


                if (V_Extension == ".frx")
                {
                    pictureIcono.Image = NewReportesControlEscolar.Properties.Resources.Fast_Report_Icon;
                }
                else if (V_Extension == ".rpt")
                {
                    pictureIcono.Image = NewReportesControlEscolar.Properties.Resources.icono_crystal;
                }
                else pictureIcono.Image = null;

                ExistenciaArchivo(V_Ruta);


                Habilitar_Boton(btn_CambiarSoloRutaBD);
                Habilitar_Boton(btnModificar);
                 
                if (V_IDReporte == "")
                {
                    Habilitar_Boton(btnGuardar);
                }
                else
                {
                    DesHabilitar_Boton(btnGuardar);
                }
            }
            else cambioRadioButton = false;
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
            pictureIcono.Image = null;
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

        private void btn_AbrirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "(*.frx)|*.frx|(*.rpt)|*.rpt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                txtNombreArchivo.Text = Path.GetFileNameWithoutExtension(rutaArchivo);

                Clase_ReportesCE getid = new Clase_ReportesCE();  

                if (getid.GetIDReporte(txtNombreArchivo.Text))
                {
                    //Obtener los datos si esque esta en BD
                    if (getid.Lector.Tables.Count > 0)
                    {
                        if (getid.Lector.Tables[0].Rows.Count > 0)
                        {

                            V_IDReporte     = getid.Lector.Tables[0].Rows[0]["ID"].ToString();
                            V_NombreArchivo = txtNombreArchivo.Text.Trim();
                            V_Extension     = getid.Lector.Tables[0].Rows[0]["Extension"].ToString();
                            V_Ruta          = getid.Lector.Tables[0].Rows[0]["ruta"].ToString();
                            V_Fecha_UltimaMod = getid.Lector.Tables[0].Rows[0]["FechaUltimaModificacion"].ToString();
                            V_Fecha_Creacion = getid.Lector.Tables[0].Rows[0]["FechaCreacion"].ToString();
                            V_Acceso        = getid.Lector.Tables[0].Rows[0]["FechaUltimoAcceso"].ToString();
                            V_Descripcion   = getid.Lector.Tables[0].Rows[0]["DescripcionModificaciones"].ToString();
                            V_Peso          = getid.Lector.Tables[0].Rows[0]["pesoKb"].ToString();
                            if (V_Peso == "" || V_Peso == "0") V_Peso = PesoArchivo(V_Ruta); 

                            txtIDReporte.Text = V_IDReporte;
                            CB_Extension.SelectedItem = V_Extension;
                            txtRuta.Text = V_Ruta;
                            txtUltima_Mod.Text = V_Fecha_UltimaMod;
                            txtCreacion.Text = V_Fecha_Creacion;
                            txtAcceso.Text = V_Acceso;
                            txtDescripcionModificaciones.Text = V_Descripcion;
                            txtPeso.Text = V_Peso;
                             
                            Habilitar_Boton(btn_CambiarSoloRutaBD); 
                            Habilitar_Boton(btnModificar);
                            DesHabilitar_Boton(btnGuardar);

                        }
                        else
                        {

                            DesHabilitar_Boton(btnModificar);
                            Habilitar_Boton(btnGuardar);
                            DesHabilitar_Boton(btn_CambiarSoloRutaBD);

                            V_Ruta = rutaArchivo;
                            V_NombreArchivo = txtNombreArchivo.Text.Trim();

                            txtIDReporte.Text = String.Empty;
                            CB_Extension.SelectedItem = Path.GetExtension(rutaArchivo);
                            txtRuta.Text = rutaArchivo;
                            txtPeso.Text = PesoArchivo(rutaArchivo);//TamañoArchivo
                            DT_FechaCreacion = File.GetLastWriteTime(rutaArchivo);//Ultimamodificación
                            DT_FechaModificacion = File.GetCreationTime(rutaArchivo);//CreacionArchivo
                            DT_FechaUltimoAcceso = File.GetLastAccessTime(rutaArchivo);//Fecha de ultimo acceso
                            txtUltima_Mod.Text = DT_FechaCreacion.ToString();
                            txtCreacion.Text = DT_FechaModificacion.ToString();
                            txtAcceso.Text = DT_FechaUltimoAcceso.ToString();
                            txtDescripcionModificaciones.Text = ""; 
                        }
                    }
                    else
                    {
                        DesHabilitar_Boton(btnModificar);
                        Habilitar_Boton(btnGuardar);
                        DesHabilitar_Boton(btn_CambiarSoloRutaBD);

                        V_Ruta = rutaArchivo;
                        V_NombreArchivo = txtNombreArchivo.Text.Trim();

                        txtIDReporte.Text = String.Empty;
                        txtRuta.Text = rutaArchivo;
                        CB_Extension.SelectedItem = Path.GetExtension(rutaArchivo);
                        txtPeso.Text = PesoArchivo(rutaArchivo);
                        DT_FechaCreacion = File.GetLastWriteTime(rutaArchivo);//Ultimamodificación
                        DT_FechaModificacion = File.GetCreationTime(rutaArchivo);//CreacionArchivo
                        DT_FechaUltimoAcceso = File.GetLastAccessTime(rutaArchivo);//Fecha de ultimo acceso
                        txtUltima_Mod.Text = DT_FechaCreacion.ToString();
                        txtCreacion.Text = DT_FechaModificacion.ToString();
                        txtAcceso.Text = DT_FechaUltimoAcceso.ToString();
                        txtDescripcionModificaciones.Text = ""; 
                    }
                    ExistenciaArchivo(txtRuta.Text);
                }
                else
                {
                    MessageBox.Show("Falla en el procedimiento GetIDReporte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        public void Habilitar_Boton(Button button)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
            button.Enabled = true;
        }

        public void DesHabilitar_Boton(Button button)
        {
            button.BackColor = Color.LightGray;
            button.ForeColor = Color.Gray;
            button.Enabled = false;
        }

        public string PesoArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                FileInfo fi = new FileInfo(ruta);
                long size = fi.Length;//-- / 1000;
                return size.ToString() + " bytes";
            }
            else return 0.ToString() + " KB";
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
                    error.ToString();
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
            string soloRuta = Path.GetDirectoryName(txtRuta.Text.Trim());
            Process.Start("explorer.exe", soloRuta);
        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------------------------------------------
            //PARA CREAR UN ARCHIVO Y AGREGARLO A LA BD DE CERO
            //-------------------------------------------------------------------------------------------------------------


            if (string.IsNullOrEmpty(txtNombreArchivo.Text) || string.IsNullOrEmpty(txtRuta.Text) || string.IsNullOrEmpty(CB_Extension.SelectedItem.ToString().ToString()))
            {
                MessageBox.Show("Favor de llenar los campos Nombre Archivo, Extensión y Ruta", "Creacion de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                string path = txtRuta.Text.Trim();

                if (!File.Exists(path))
                {
                    if (txtIDReporte.Text != "")
                    {
                        if (txtExistencia.Text == "SI")
                        {    
                            if (MessageBox.Show("El archivo '" + V_NombreArchivo + "' Ya existe en la ruta \n'" + V_Ruta + "'\n Si continuas se creara un nuevo Archivo en Limpio .\n"
                                + "si Deseas mantener la informacion del archivo ya creado , selecciona 'NO' y da clic al Boton de 'Modificar Datos Reporte' para cambiarlo de ruta \n" +
                                "pero si quieres Crear el archivo de Cero entonces Selecciona 'SI'", "Alto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                try
                                {   //Creacion del Archivo

                                    CrearArchivo(path);

                                    //-------------------------------------------------------------------------------------------------------------------------
                                    //Agregar el Registro a BD o Validarlo si Ya Existe 

                                    Clase_ReportesCE reportes = new Clase_ReportesCE();
                                    txtDescripcionModificaciones.Text = txtDescripcionModificaciones.Text + "\n" + Descripcion_Creacion;
                                    if (reportes.DetalleArchivoReporte(TIPO_INSERCION, txtIDReporte.Text, txtNombreArchivo.Text, CB_Extension.SelectedItem.ToString(), txtRuta.Text, FechaActual.ToString(), FechaActual.ToString(), FechaActual.ToString(), txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtPeso.Text) == true)
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
                                        cambioRadioButton = true;
                                        MostrarReportes();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Favor de revisar los datos registrados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                catch (System.IO.DirectoryNotFoundException error)
                                {
                                    error.ToString();
                                    MessageBox.Show("No existe la Ruta: \n" + txtRuta.Text.ToString().Replace(txtNombreArchivo.Text + CB_Extension.SelectedItem.ToString(), ""), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            CrearArchivo(path);
                        }
                    } //--En dado Caso que no Existe en la base de datos
                    else
                    {
                        //Checar Primero que no existe el nombre en BD
                        Clase_ReportesCE reportesCE = new Clase_ReportesCE();
                        txtDescripcionModificaciones.Text = txtDescripcionModificaciones.Text + Descripcion_Creacion;
                        if (reportesCE.DetalleArchivoReporte(TIPO_INSERCION, txtIDReporte.Text, txtNombreArchivo.Text, CB_Extension.SelectedItem.ToString(),txtRuta.Text, FechaActual.ToString(), FechaActual.ToString(), FechaActual.ToString(),  txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtPeso.Text) == true)
                        {
                            if (reportesCE.Lector.Tables.Count > 0)
                            {
                                MessageBox.Show("El registro '"+ reportesCE.Lector.Tables[0].Rows[0][1].ToString()+"' ya existe Porfavor cambielo", "REGISTRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Registro guardado correctamente", "REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            if (File.Exists(path))
                            {
                                if (MessageBox.Show("Ya Existe un archivo en la misma Ruta\n¿Desea Sobreescribirlo", "Alto", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                                {
                                    File.Delete(path);
                                    CrearArchivo(path);
                                }
                            }
                            else
                            {
                                CrearArchivo(path);
                            }

                            Habilitar_Boton(btnModificar);
                            cambioRadioButton = true;
                            MostrarReportes();
                        }
                    }
                }
                else
                {
                        MessageBox.Show("El archivo ya existe","Detalle Reporte",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        public void CrearArchivo(string path)
        {
            string sourceFile;

            if(CB_Extension.SelectedItem.ToString() == ".rpt")
            {
                sourceFile = @"\\189.197.190.214\Sistemas\ReportesCE\ReportesBase\Informe_Cristal.rpt";
            }
            else
            {
                sourceFile = @"\\189.197.190.214\Sistemas\ReportesCE\ReportesBase\informe.frx";
            }
            
            File.Copy(sourceFile, path, true);

            txtCreacion.Text = File.GetCreationTime(path).ToString();
            txtUltima_Mod.Text = File.GetLastWriteTime(path).ToString();
            txtAcceso.Text = File.GetLastAccessTime(path).ToString();
            txtPeso.Text = path.Length.ToString();
            txtExistencia.Text = "SI";

            MessageBox.Show("El archivo fue creado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e) //Tabla DetalleArchivoReporte
        {
            Clase_ReportesCE reportes = new Clase_ReportesCE();
            if (txtNombreArchivo.Text == null || txtNombreArchivo.Text == "")
            {
                MessageBox.Show("Favor de elegir el reporte a guardar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!txtRuta.Text.Contains(txtNombreArchivo.Text.Trim() + CB_Extension.SelectedItem.ToString()))
                {
                    txtRuta.Text = txtRuta.Text + txtNombreArchivo.Text.Trim() + CB_Extension.SelectedItem.ToString();
                }

                if (VerificarDifectorio(txtRuta.Text.Trim()))
                {
                    if (reportes.DetalleArchivoReporte(TIPO_INSERCION, txtIDReporte.Text, txtNombreArchivo.Text, CB_Extension.SelectedItem.ToString(), txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text,  txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado,txtPeso.Text ) == true)
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

                    Habilitar_Boton(btnModificar);
                    cambioRadioButton = true;
                    MostrarReportes();
                }
                else
                {
                    MessageBox.Show("Ruta Especificada No existe, porfavor verifica tu ruta", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
      

        public bool VerificarDifectorio (string ruta)
        { 
            string soloRuta = Path.GetDirectoryName(ruta);

            if (Directory.Exists(soloRuta))
                return true;
            else
                return false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreArchivo.Text) || string.IsNullOrEmpty(txtRuta.Text) || string.IsNullOrEmpty(CB_Extension.SelectedItem.ToString().ToString()))
            {
                MessageBox.Show("Favor de llenar los campos Nombre Archivo & Ruta", "Creacion de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //VERIFICAR SI HEMOS MODIFICADO ALGO ( SI MODIFICAMOS ALGO ENTONCES)
                if (V_NombreArchivo != txtNombreArchivo.Text || V_Ruta != txtRuta.Text)
                {
                    //VERIFICAMOS SI YA EXISTE EL NOMBRE EN BD PARA QUE NO SE REPITA
                    Clase_ReportesCE reportes = new Clase_ReportesCE();
                    reportes.DetalleArchivoReporte(TIPO_EXISTE,"", txtNombreArchivo.Text.Trim(), "", "", "", "", "", "", "","");
                    //SI SI ENCUENTRA UN NOMBRE ENTONCES
                    if (reportes.Lector.Tables[0].Rows.Count > 0 && V_NombreArchivo != txtNombreArchivo.Text.Trim())
                    {
                        MessageBox.Show("Ya existe un archivo con el mismo Nombre en la base de datos, porfavor Cambie de nombre o modifique el archivo ya existente","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        return;
                    }
                    else //PERO SI NO EXISTE PROCEDEMOS A ACTUALIZAR
                    {
                        //PRIMERO VERIFICAMOS LA EXISTENCIA DE LA RUTA
                        if (VerificarDifectorio(txtRuta.Text))
                        {
                            MessageBox.Show("Si existe el directorio,es valido,continuamos");

                            //AHORA VERIFICAMOS SI EXISTE EL ARCHIVO PARA MOVERLO 
                            if (ExistenciaArchivo(V_Ruta))
                            {
                                //RENOMBRAMOS EL ARCHIVO SI ESQUE EXISTE
                                if (MoverArchivodeRuta(V_Ruta))
                                {
                                    txtDescripcionModificaciones.Text = txtDescripcionModificaciones.Text + "\n" + Descripcion_modificacion;
                                    if (reportes.DetalleArchivoReporte(TIPO_MODIFICACION, txtIDReporte.Text,txtNombreArchivo.Text, CB_Extension.SelectedItem.ToString(),txtRuta.Text, FechaActual.ToString(), txtCreacion.Text, txtAcceso.Text,  txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtPeso.Text) == true)
                                    {
                                        MessageBox.Show("Registro actualizado correctamente", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo actualizar el registro, contacte al departamento de sistemas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                    cambioRadioButton = true;
                                    MostrarReportes();
                            }
                        }
                        else
                        { //SI EL DIRECTORIO NO EXISTE EN NUESTRO EQUIPO PERO QUEREMOS SOLO MODIFICAR EL NOMBRE
                            if (MessageBox.Show("No existe dicha ruta en tu equipo Local , Deseas aun asi dejarlo en esa ruta?", "Error Ruta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string fullPath = Path.GetFullPath(txtRuta.Text);
                                string soloRuta = Path.GetDirectoryName(fullPath);
                                string nombreNuevo = Path.Combine(soloRuta, txtNombreArchivo.Text + CB_Extension.SelectedItem.ToString());
                                txtRuta.Text = nombreNuevo;
                                if (reportes.DetalleArchivoReporte(TIPO_MODIFICACION, txtIDReporte.Text, txtNombreArchivo.Text, CB_Extension.SelectedItem.ToString(), txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtPeso.Text) == true)
                                {
                                    MessageBox.Show("Registro actualizado correctamente", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo actualizar el registro, contacte al departamento de sistemas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                cambioRadioButton = true;
                                MostrarReportes();
                            }
                            else //SI DECIMOS QUE NO DEJAMOS TODO COMO ESTABA
                            {
                                txtNombreArchivo.Text = V_NombreArchivo;
                                txtRuta.Text = V_Ruta;
                                ExistenciaArchivo(txtRuta.Text);
                            }
                        } 
                    }
                }
            }
        }

        public bool MoverArchivodeRuta(string ruta)
        {
            string fullPath = Path.GetFullPath(ruta);
            string soloRuta = Path.GetDirectoryName(Path.GetFullPath(txtRuta.Text.Trim()));
            string nombreNuevo = Path.Combine(soloRuta, txtNombreArchivo.Text + CB_Extension.SelectedItem.ToString());

            txtRuta.Text = nombreNuevo;
            try
            {
                File.Move(fullPath, nombreNuevo);
                return true;
            }
            catch(System.IO.IOException error)
            {
                error.ToString();
                if (MessageBox.Show("Ya Existe un archivo en el directorio , desea Reemplazarlo \n", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Delete(nombreNuevo);
                    File.Move(fullPath, nombreNuevo);
                    return true;
                }
                else return false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombreArchivo.Text != null || txtNombreArchivo.Text != "")
            { 
                if (MessageBox.Show("¿Estás seguro de eliminar el reporte?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Clase_ReportesCE reportes = new Clase_ReportesCE();
                    if (reportes.DetalleArchivoReporte("3", txtIDReporte.Text, txtNombreArchivo.Text, CB_Extension.SelectedItem.ToString(),txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text,  txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtPeso.Text) == true)
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

        private void btn_CambiarSoloRutaBD_Click(object sender, EventArgs e)
        {
            if (txtNombreArchivo.Text == null || txtNombreArchivo.Text == "" || txtRuta.Text == null || txtRuta.Text == "")
            {
                MessageBox.Show("Elija el reporte y nueva ubicación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Estas seguro de cambiar la ruta del registro en BD?", "Espera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Clase_ReportesCE reportes = new Clase_ReportesCE();
                    if (reportes.DetalleArchivoReporte(TIPO_MODIFICACION, txtIDReporte.Text.Trim(), txtNombreArchivo.Text, CB_Extension.SelectedItem.ToString(), txtRuta.Text, txtUltima_Mod.Text, txtCreacion.Text, txtAcceso.Text, txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtPeso.Text))
                    {
                        MessageBox.Show("El archivo se cambió a la ruta especificada", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cambioRadioButton = true;
                        MostrarReportes();
                    }
                    else
                    {
                        MessageBox.Show("No se puede cambiar la ruta del archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void PB_AbrirDirectorioRutas_Click(object sender, EventArgs e)
        {
            bool modoOpen = false;
            if (txtNombreArchivo.Text.Trim() != "")
            {
                FolderBrowserDialog folderDlgCompartida = new FolderBrowserDialog();
                if (folderDlgCompartida.ShowDialog() == DialogResult.OK)
                {
                    if (txtIDReporte.Text == "") modoOpen = true; 

                    txtRuta.Text = folderDlgCompartida.SelectedPath + "\\" + txtNombreArchivo.Text.Trim() + CB_Extension.SelectedItem.ToString();

                    if(!ExistenciaArchivo(txtRuta.Text))
                    {
                        if(txtIDReporte.Text =="")
                        {
                            if (modoOpen)
                            {
                                DesHabilitar_Boton(btnGuardar);
                            }
                            else
                            {
                                Habilitar_Boton(btnGuardar);
                            }
                        }
                        else
                        {
                            if (modoOpen)
                            {
                                Habilitar_Boton(btnGuardar);
                            }
                            else
                            {
                                DesHabilitar_Boton(btnGuardar);
                            }
                        }
                    }
                    else
                    {
                        if(txtIDReporte.Text=="")
                        {
                            Habilitar_Boton(btnGuardar);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes Ingresar un Nombre de Archivo", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
        public bool ExistenciaArchivo(string Ruta)
        {
            bool result = File.Exists(Ruta);
            if (result == true)
            {
                txtExistencia.Text = "SI";
                DesHabilitar_Boton(btnCrearArchivo);
                return result;
            }
            else
            {
                txtExistencia.Text = "NO";
                Habilitar_Boton(btnCrearArchivo);
                return result;
            }
        }
        private void btnCopiarRutaLocal_Click(object sender, EventArgs e)
        {
            string nombreArchivo = txtNombreArchivo.Text + CB_Extension.SelectedItem.ToString();
            string rutaOriginal = txtRuta.Text.Replace("\\"+nombreArchivo,"");
            var RutaLocalReportes = System.Reflection.Assembly.GetExecutingAssembly().Location.ToString().Replace("bin\\Debug\\NewReportesControlEscolar.exe", "LoboOne\\Reportes"); 
            

            string sourceFile = System.IO.Path.Combine(rutaOriginal, nombreArchivo);
            string destFile = System.IO.Path.Combine(RutaLocalReportes.ToString(), nombreArchivo);

            System.IO.Directory.CreateDirectory(RutaLocalReportes.ToString());

            if (System.IO.Directory.Exists(rutaOriginal))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
                MessageBox.Show("Archivo Copiado a la ruta de proyecto Reportes");
            }
            else
            {
                MessageBox.Show("Error no se encontro la ruta \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (CB_Extension.SelectedItem.ToString() == ".frx")
            //{
            //    previewReportes.Visible = true;
            //    preview_Crystal.Visible = false;
            //}
            //else
            //{
            //    previewReportes.Visible = false;
            //    preview_Crystal.Visible = true;
            //}

            if (txtIDReporte.Text != "")
            {

                claseParametros = new Clase_ReportesCE();
                claseParametros.GetParametros_Reportes(txtIDReporte.Text);

                if (claseParametros.Lector.Tables[0].Rows.Count > 0)
                {

                    int tamVector = claseParametros.Lector.Tables[0].Rows.Count;
                    vecParametros = new string[tamVector, 2];

                    if (File.Exists(V_Ruta))
                    {
                        if (CB_Extension.SelectedItem.ToString() == ".frx")
                        {
                            previewReportes.Visible = true;
                            preview_Crystal.Visible = false;
                       
                            Report frxReport = new Report();
                            previewReportes.OutlineVisible = false;
                            previewReportes.ZoomPageWidth();
                            frxReport.Preview = previewReportes;
                            frxReport.Load(V_Ruta);

                            int parametrosInternosReporte = frxReport.Parameters.Count;
                            int parametrosAsignadosenBD = tamVector;

                            if (parametrosInternosReporte == parametrosAsignadosenBD)
                            {
                                //llenamos la lista de los parametros internos del Archivo fast
                                if (frxReport.Parameters.Count > 0) for (int x = 0; x < frxReport.Parameters.Count; x++) listBox1.Items.Add(frxReport.Parameters[x].Name.ToString());


                                for (int i = 0; i < tamVector; i++)  //para sacar los parametros relacionados en BD
                                {

                                    vecParametros[i, 0] = claseParametros.Lector.Tables[0].Rows[i][1].ToString(); //esto es para el nombre del parametros
                                    vecParametros[i, 1] = claseParametros.Lector.Tables[0].Rows[i][2].ToString(); // esto es para el valor 
                                    //si el parametro relacionado de la BD esta dentro de la lista de los parametros internos del archivo entonces
                                    if(listBox1.Items.Contains(vecParametros[i, 0]))
                                    {   //lo agrega
                                        frxReport.SetParameterValue(vecParametros[i, 0], vecParametros[i, 1]);
                                    }
                                    else // de lo contrario se producira un error al no coincidir los nombres - entonces rompemos el metodo y enviamos un mensaje 
                                    {
                                        MessageBox.Show("El parametros relacionado en la BD No se encuentra dentro de los que pide el Reporte , porfavor Relaciona correctamente los parametros,\n" +
                                            "Nota: Los paratros que deben estar relacionados deben de ser los mismos que estan en la lista amarrilla","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                frxReport.Show();
                                flag_Visualizar = false;

                            }
                            else MessageBox.Show("Los parametros del reporte no coincide con el numero de parametros relacionado en la bd , porfavor comprueba la relacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          
                        }
                        else //reportes cristal
                        {
                            Console.WriteLine("cristal");
                        }
                    }
                    else MessageBox.Show("El Archivo no existe \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                else
                {
                    if (MessageBox.Show("El reporte guardado en BD no tiene parametros relacionados , ve a la pantalla de relacion de parametros para asignar uno al reporte \n " +
                      "o deseas abrir el reporte con sus datos precargados ", "espera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        visualizarReporte_Parametros();
                    }

                }
            }
            else
            {
                label11.Visible = true;
                MessageBox.Show("El Reporte no se encuentra registrado en la base de datos , puede registrarlo ya sea en crear archivo o guardar reporte", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
         
         
        private void btn_ReemplazarCarpeta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreArchivo.Text))
            {
                txtRuta.Text = @"\\189.197.190.214\Sistemas\ReportesCE\" + txtNombreArchivo.Text.Trim() + CB_Extension.SelectedItem.ToString();
                ExistenciaArchivo(txtRuta.Text.Trim());
            }
            else
            {
                MessageBox.Show("por favor ingresa un nombre al archivo \n", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            cambioRadioButton = true;
            this.DGV_Reportes.Sort(this.DGV_Reportes.Columns["ID"], ListSortDirection.Ascending);
        }
         

        private void radioButton1_Click(object sender, EventArgs e)
        {
            cambioRadioButton = true;
            this.DGV_Reportes.Sort(this.DGV_Reportes.Columns["NombreArchivo"], ListSortDirection.Ascending);
        }

        private void btn_NuevoArchivoCero_Click(object sender, EventArgs e)
        {
            Limpiar();
            DesHabilitar_Boton(btnModificar); 
        }
         
        private void btnCrearCopia_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombreArchivo.Text.Trim()))
            {
                Clase_ReportesCE reportes = new Clase_ReportesCE();
                reportes.DetalleArchivoReporte(TIPO_EXISTE, "", txtNombreArchivo.Text.Trim(), "", "", "", "", "", "", "", "");
                if (reportes.Lector.Tables[0].Rows.Count > 0 && V_NombreArchivo != txtNombreArchivo.Text.Trim())
                {
                    MessageBox.Show("Ya existe un archivo con el mismo Nombre en la base de datos, porfavor Cambie de nombre o modifique el archivo ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Esta Seguro de Crear una copia del Archivo ubicado en:\n" + V_Ruta + "'\n" + "" + "para que finalmente quede en la ubicacion :\n" + "'" + txtRuta.Text.Trim() + "'", "Espera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (reportes.DetalleArchivoReporte(TIPO_INSERCION, txtIDReporte.Text, txtNombreArchivo.Text, CB_Extension.SelectedItem.ToString(), txtRuta.Text, FechaActual.ToString(), FechaActual.ToString(), FechaActual.ToString(), txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtPeso.Text) == true)
                        {
                            if (reportes.Lector.Tables[0].Rows.Count > 0)
                            {
                                MessageBox.Show("El registro ya existe", "REGISTRO EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Registro guardado correctamente", "REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        if (File.Exists(V_Ruta))
                        {
                            string soloRuta = Path.GetDirectoryName(txtRuta.Text.Trim());
                            string rutaReal = soloRuta + "\\" + txtNombreArchivo.Text + CB_Extension.SelectedItem.ToString();
                            if (V_Ruta != rutaReal) CopiarArchivo(V_Ruta, rutaReal);
                        }
                        else
                        {
                            MessageBox.Show("Para copiar el Reporte , debe tener la existencia del archivo", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        cambioRadioButton = true;
                        MostrarReportes();
                    }
                }
            }
            else
            {
                MessageBox.Show("el Nombre del archivo no debe quedar vacio , porfavor ingresa un nombre\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public void CopiarArchivo(string rutaOrigen,string rutaDestino)
        {
            try
            {
                if (!File.Exists(rutaDestino))
                {

                    File.Copy(rutaOrigen, rutaDestino, true);

                    if(CB_Extension.SelectedItem.ToString()==".rpt")
                    {
                        if(File.Exists(rutaOrigen.Replace(".rpt",".cs")))
                        {
                            File.Copy(rutaOrigen.Replace(".rpt", ".cs"), rutaDestino.Replace(".rpt", ".cs"), true);
                        }
                    }

                    MessageBox.Show("Archivo Copiado Con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(MessageBox.Show("El Archivo ya existe en la ruta ¿ si presionas 'SI' el archivo se sobreescribira, presiona 'NO' si quieres mantener el archivo ya existente","Alto",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                    {
                        File.Copy(rutaOrigen, rutaDestino, true);
                        if (CB_Extension.SelectedItem.ToString() == ".rpt")
                        {
                            if (File.Exists(rutaOrigen.Replace(".rpt", ".cs")))
                            {
                                File.Copy(rutaOrigen.Replace(".rpt", ".cs"), rutaDestino.Replace(".rpt", ".cs"), true);
                            }
                        }
                        MessageBox.Show("Archivo Copiado Con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch(System.IO.IOException error) { MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtExistencia.Text=="SI")
            {

                visualizarReporte_Parametros();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string soloRuta = Path.GetDirectoryName(txtRuta.Text.Trim());
            string rutaReal = @"\\189.197.190.214\Sistemas\ReportesCE\" + txtNombreArchivo.Text + CB_Extension.SelectedItem.ToString();

            if (V_Ruta != rutaReal) CopiarArchivo(txtRuta.Text, rutaReal);

            Clase_ReportesCE reportes = new Clase_ReportesCE();
            txtDescripcionModificaciones.Text = txtDescripcionModificaciones.Text + "\n" + Descripcion_Creacion;
            if (reportes.DetalleArchivoReporte(TIPO_INSERCION, txtIDReporte.Text, txtNombreArchivo.Text, CB_Extension.SelectedItem.ToString(), rutaReal, FechaActual.ToString(), FechaActual.ToString(), FechaActual.ToString(), txtDescripcionModificaciones.Text, Clase_Sesion.IDEmpleado, txtPeso.Text) == true)
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
                cambioRadioButton = true;
                MostrarReportes();
            }
            else
            {
                MessageBox.Show("Favor de revisar los datos registrados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cambioRadioButton = true;
            MostrarReportes();
        }

        private void btn_MostrarReporte_Click(object sender, EventArgs e)
        {
            flag_Visualizar = true;
            visualizarReporte_Parametros();
        }

        public void visualizarReporte_Parametros()
        {
            if (CB_Extension.SelectedItem.ToString() == ".frx")
            {
                previewReportes.Visible = true;
                preview_Crystal.Visible = false;
                Report frxReport = new Report();
                if (File.Exists(V_Ruta))
                {
                    previewReportes.OutlineVisible = false;
                    previewReportes.ZoomPageWidth();
                    frxReport.Preview = previewReportes;
                    frxReport.Load(V_Ruta);
                    listBox1.Items.Clear();
                    if (frxReport.Parameters.Count > 0) for (int x = 0; x < frxReport.Parameters.Count; x++) listBox1.Items.Add(frxReport.Parameters[x].Name.ToString());
                    if (flag_Visualizar) frxReport.Show();
                    flag_Visualizar = false;
                }
            }
            else
            {
                if (File.Exists(V_Ruta))
                {
                    previewReportes.Visible = false;
                    preview_Crystal.Visible = true;
                    conrepor.ReporteRPT(V_NombreArchivo + CB_Extension); CryRpt.Load(V_Ruta);
                    //CryRpt.SetParameterValue("@ID_Alumno", gridViewAlumnos.Rows[ro].Cells[0].Value.ToString());
                    CryRpt.SetDatabaseLogon("5265193FDE7C660", "B2B8C6721ACFD01E5AD3047A468FEF66A9234E5D7D5BA373A47E85A3E64BC5B");
                    preview_Crystal.ReuseParameterValuesOnRefresh = true;
                    preview_Crystal.ShowGroupTreeButton = false;
                    listBox1.Items.Clear();

                    //if (flag_Visualizar) 
                    preview_Crystal.ReportSource = CryRpt;
                    if (preview_Crystal.ParameterFieldInfo.Count > 0) for (int x = 0; x < preview_Crystal.ParameterFieldInfo.Count; x++) listBox1.Items.Add(preview_Crystal.ParameterFieldInfo[x].Name.ToString());
                    preview_Crystal.ReportSource = null;
                    flag_Visualizar = false;
                }
            }
        }
    }

}






