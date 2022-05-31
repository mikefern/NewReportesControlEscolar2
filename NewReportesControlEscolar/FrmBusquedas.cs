using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoLoboSostenido
{
    public partial class FrmBusquedas : Form
    {
        private Clase_Alumnos objAlumno;
        private Clase_Empleados objEmpleado;
        private Clase_Prospectos objProspecto;
        private int tipo;
        private int activos = 1;
        private string check;
        public int Tipo
        {
            get => tipo;
            set => tipo = value;
        }
        public string IdPersona { get; set; }
        public string IdCodigo { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Status { get; set; }
        public byte[] Fotografia { get; set; }

        public FrmBusquedas(int tipo)
        {
            InitializeComponent();
            Tipo = tipo;

            if (Clase_Sesion.Usuario == "Caja_AL1" || Clase_Sesion.Usuario == "Caja_AL2" || Clase_Sesion.Usuario == "AL_Gerencia" || Clase_Sesion.Usuario == "AL_Administrador")
            {
                this.BackColor = Color.FromArgb(0, 0, 0);
                this.btnAceptar.BackgroundImage = null;
                this.btnAceptar.BackColor = Color.FromArgb(255, 109, 0);
                this.btnAceptar.Text = "Seleccionar";
                this.lbxNombres.Font = new Font("Bahnschrift", 10);
                this.btnAceptar.Font = new Font("Bahnschrift", 14);
                this.label9.Font = new Font("Bahnschrift", 10);
                this.gpbDatos.Font = new Font("Bahnschrift", 10);
                this.lblEspecialidad.Font = new Font("Bahnschrift", 10);
                this.txbEspecialidad.Font = new Font("Bahnschrift", 10);
                this.lblSemCua.Font = new Font("Bahnschrift", 10);
                this.txbCuatri.Font = new Font("Bahnschrift", 10);
                this.lblStatus.Font = new Font("Bahnschrift", 10);
                this.txbStatus.Font = new Font("Bahnschrift", 10);
                this.txbCampus.Font = new Font("Bahnschrift", 10);
                this.label13.Font = new Font("Bahnschrift", 10);
                this.cbxActivos.Font = new Font("Bahnschrift", 10);
                this.lblMatriEmple.Font = new Font("Bahnschrift", 10);
                //NO LO BORRES SAUL
            }
        }


        //public frmBusquedas()
        //{
        //    InitializeComponent();
        //}
        private void FrmBusquedas_Load(object sender, EventArgs e)
        {
            string aux = Clase_Sesion.Campus;
            Clase_Campus objCampus = new Clase_Campus();
            objCampus.ConsultaComboCampus();
            cboCampus.Visible = true;
            cboCampus.DataSource = objCampus.Lector.Tables[0];
            cboCampus.DisplayMember = "Campus";
            cboCampus.ValueMember = "ID_Campus";
            cboCampus.SelectedValue = aux;
            Clase_Sesion.Campus = cboCampus.SelectedValue.ToString();
            cboCampus.Show();
            switch (Tipo)
            {
                case 0:
                    {
                        //Prospecto
                        lblMatriEmple.Text = "Num. Prospecto";
                        objProspecto = new Clase_Prospectos();
                        break;
                    }
                case 1:
                    {
                        //alumno
                        lblMatriEmple.Text = "Matricula";
                        objAlumno = new Clase_Alumnos();
                        break;
                    }
                case 2:
                    {
                        lblMatriEmple.Text = "Clave";
                        objEmpleado = new Clase_Empleados();
                        lblSemCua.Visible = false;
                        lblStatus.Visible = false;
                        txbCuatri.Visible = false;
                        txbStatus.Visible = false;
                        lblEspecialidad.Visible = false;
                        txbEspecialidad.Visible = false;
                        label1.Visible = false;
                        cboCampus.Visible = false;
                        checkBox1.Visible = false;

                        break;
                    }
            }
            if (Clase_Sesion.Rol == "14"|| Clase_Sesion.Rol == "1"|| Clase_Sesion.Rol == "2" || Clase_Sesion.Rol == "7" || Clase_Sesion.Rol == "8")
            {
                label1.Visible = true;
                cboCampus.Visible = true;
                checkBox1.Visible = true;
            }
            cboCampus.Enabled = true;
        }
        private void TxbNombre_KeyUp(object sender, KeyEventArgs e)
        {
            Busqueda(e.KeyCode);
        }
        public void Busqueda(Keys e)
        {
            try
            {
                if (e != Keys.Enter)
                {
                    if (txbNombre.Text.Contains(" "))
                    {
                        if (checkBox1.Checked)
                        {
                            check = "Todos";
                        }
                        else
                        {
                            check = "";
                        }
                        switch (Tipo)
                        {
                            case 0:
                                {
                                    //Prospectos
                                    lbxNombres.DataSource = null;
                                    lbxNombres.Items.Clear();
                                    objProspecto.Lector.Clear();
                                    objProspecto.ConsultaCmdProspecto(txbNombre.Text, activos, check, Clase_Sesion.campus);
                                    lbxNombres.DataSource = objProspecto.Lector.Tables[0];
                                    lbxNombres.DisplayMember = "nombre";
                                    lbxNombres.ValueMember = "Personas.Id_persona";
                                    break;
                                }
                            case 1:
                                {
                                    try
                                    {
                                        //Alumnos
                                        lbxNombres.DataSource = null;
                                        lbxNombres.Items.Clear();
                                        objAlumno.Lector.Clear();
                                        objAlumno.ConsultaCmdAlumno(txbNombre.Text, activos, check, Clase_Sesion.Campus);
                                        lbxNombres.DataSource = objAlumno.Lector.Tables[0];
                                        lbxNombres.DisplayMember = "nombre";
                                        lbxNombres.ValueMember = "Alumnos.ID_Alumno";
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.ToString());
                                    }

                                    break;
                                }
                            case 2:
                                {
                                    //Empleados
                                   lbxNombres.DataSource = null;
                                    lbxNombres.Items.Clear();
                                    objEmpleado.Lector.Clear();
                                    /////////////////////////////////
                                    if (Clase_Sesion.Rol == "4" || Clase_Sesion.Rol == "5" || Clase_Sesion.Rol == "6" || Clase_Sesion.Rol == "13"
                                        || Clase_Sesion.Rol == "14" || Clase_Sesion.Rol == "15" || Clase_Sesion.Rol == "16" || Clase_Sesion.Rol == "17" || Clase_Sesion.Rol == "19")
                                    {
                                        objEmpleado.ConsultaCmdEmple(txbNombre.Text, activos, check, Clase_Sesion.Campus);
                                    }
                                    else
                                    {
                                        objEmpleado.ConsultaCmdEmple(txbNombre.Text, activos, "Docente", Clase_Sesion.Campus);
                                    }
                                    lbxNombres.DataSource = objEmpleado.Lector.Tables[0];
                                    lbxNombres.DisplayMember = "nombre";
                                    lbxNombres.ValueMember = "Personas.Id_persona";
                                    break;
                                }
                        }
                    }
                }
                if (e == Keys.Down)
                {
                    lbxNombres.Focus();
                    lbxNombres.SelectedIndex = 0;
                    LbxNombres_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception)
            {
                // ex.ToString();
            }
        }
        private void CbxActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxActivos.Checked)
            {
                activos = 1;
            }
            else
            {
                activos = 0;
            }

            Busqueda(Keys.A);
        }
        private void LbxNombres_Click(object sender, EventArgs e)
        {
            switch (Tipo)
            {
                case 0:
                    {
                        try
                        {
                            //Prospectos
                            foreach (DataRow row in objProspecto.Lector.Tables[0].Rows)
                            {
                                if (row["id_persona"].ToString() == lbxNombres.SelectedValue.ToString())
                                {
                                    txbCampus.Text = row["Campus"].ToString();
                                    txbEspecialidad.Text = row["Descripcion"].ToString();
                                    txbNombre.Text = row["Nombre"].ToString();
                                    txbCodigo.Text = row["ID_Prospecto"].ToString();
                                    IdCodigo = row["ID_Prospecto"].ToString();
                                    IdPersona = row["Id_persona"].ToString();
                                    Nombre = row["nombre"].ToString();
                                    txbStatus.Text = row["Status_Prospecto"].ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        break;
                    }
                case 1:
                    {
                        try
                        {
                            //Alumnos
                            foreach (DataRow row in objAlumno.Lector.Tables[0].Rows)
                            {
                                if (row["ID_Alumno"].ToString() == lbxNombres.SelectedValue.ToString())
                                {
                                    txbCampus.Text = row["campus"].ToString();
                                    txbEspecialidad.Text = row["Descripcion"].ToString();
                                    txbCuatri.Text = row["numsem"].ToString();
                                    txbCodigo.Text = row["ID_Alumno"].ToString();
                                    IdCodigo = row["ID_Alumno"].ToString();
                                    IdPersona = row["Id_persona"].ToString();
                                    Especialidad = row["ID_Especialidad"].ToString();
                                    txbNombre.Text = row["nombre"].ToString();
                                    Nombre = row["nombre"].ToString();
                                    txbStatus.Text = row["Status"].ToString();
                                    Status = row["Status"].ToString();

                                    if (row["ID_Fotografia"].ToString().Length >= 2)
                                    {
                                        imgFotografia.Image = Clase_ConvertImage.ByteArrayToImage((byte[])row["ID_Fotografia"]);
                                    }
                                    else
                                    {
                                        imgFotografia.Image = NewReportesControlEscolar.Properties.Resources.icono_perfil_azul;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        break;
                    }
                case 2:
                    {
                        //Empleados
                        foreach (DataRow row in objEmpleado.Lector.Tables[0].Rows)
                        {
                            if (row["id_persona"].ToString() == lbxNombres.SelectedValue.ToString())
                            {
                                txbCampus.Text = row["campus"].ToString();
                                txbCodigo.Text = row["ID_Empleado"].ToString();
                                IdCodigo = row["ID_Empleado"].ToString();
                                IdPersona = row["Id_persona"].ToString();
                                Nombre = row["nombre"].ToString();
                                

                                if (row["ID_Fotografia"].ToString().Length >= 2)
                                {
                                    imgFotografia.Image = Clase_ConvertImage.ByteArrayToImage((byte[])row["ID_Fotografia"]);
                                    Fotografia = (byte[])row["ID_Fotografia"];
                                }
                                else
                                {
                                    imgFotografia.Image = NewReportesControlEscolar.Properties.Resources.icono_perfil_azul;
                                }
                                break;
                            }
                        }
                        break;
                    }
            }
        }
        private void TxbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                if (checkBox1.Checked)
                {
                    check = "Todos";
                }
                else
                {
                    check = "codigo";
                }
                switch (Tipo)
                {
                    case 0:
                        {
                            //Prospectos
                            lbxNombres.DataSource = null;
                            lbxNombres.Items.Clear();
                            objProspecto.Lector.Clear();
                            objProspecto.ConsultaCmdProspecto(txbCodigo.Text, activos, check, Clase_Sesion.campus);
                            lbxNombres.DataSource = objProspecto.Lector.Tables[0];
                            lbxNombres.DisplayMember = "nombre";
                            lbxNombres.ValueMember = "Personas.Id_persona";
                            break;
                        }
                    case 1:
                        {
                            //Alumnos
                            lbxNombres.DataSource = null;
                            lbxNombres.Items.Clear();
                            objAlumno.Lector.Clear();
                            /////////////////////////////////
                            objAlumno.ConsultaCmdAlumno(txbCodigo.Text, activos, check, Clase_Sesion.Campus);
                            lbxNombres.DataSource = objAlumno.Lector.Tables[0];
                            lbxNombres.DisplayMember = "nombre";
                            lbxNombres.ValueMember = "Alumnos.ID_Alumno";
                            break;
                        }
                    case 2:
                        {
                            //Empleados
                            lbxNombres.DataSource = null;
                            lbxNombres.Items.Clear();
                            objEmpleado.Lector.Clear();
                            /////////////////////////////////
                            objEmpleado.ConsultaCmdEmple(txbCodigo.Text, activos, check, Clase_Sesion.campus);
                            lbxNombres.DataSource = objEmpleado.Lector.Tables[0];
                            lbxNombres.DisplayMember = "nombre";
                            lbxNombres.ValueMember = "Personas.Id_persona";
                            break;
                        }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                lbxNombres.Focus();
                lbxNombres.SelectedIndex = 0;
                LbxNombres_SelectedIndexChanged(null, null);
            }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void LbxNombres_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                switch (Tipo)
                {
                    case 0:
                        {
                            try
                            {
                                //Prospectos
                                foreach (DataRow row in objProspecto.Lector.Tables[0].Rows)
                                {
                                    if (row["id_persona"].ToString() == lbxNombres.SelectedValue.ToString())
                                    {
                                        txbCampus.Text = row["Campus"].ToString();
                                        txbEspecialidad.Text = row["Descripcion"].ToString();
                                        txbNombre.Text = row["Nombre"].ToString();
                                        txbCodigo.Text = row["ID_Prospecto"].ToString();
                                        IdCodigo = row["ID_Prospecto"].ToString();
                                        IdPersona = row["Id_persona"].ToString();
                                        Nombre = row["nombre"].ToString();
                                        txbStatus.Text = row["Status_Prospecto"].ToString();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                    case 1:
                        {
                            try
                            {
                                //Alumnos
                                foreach (DataRow row in objAlumno.Lector.Tables[0].Rows)
                                {
                                    if (row["ID_Alumno"].ToString() == lbxNombres.SelectedValue.ToString())
                                    {
                                        txbCampus.Text = row["campus"].ToString();
                                        txbEspecialidad.Text = row["Descripcion"].ToString();
                                        txbCuatri.Text = row["numsem"].ToString();
                                        txbCodigo.Text = row["ID_Alumno"].ToString();
                                        IdCodigo = row["ID_Alumno"].ToString();
                                        IdPersona = row["Id_persona"].ToString();
                                        Especialidad = row["ID_Especialidad"].ToString();
                                        txbNombre.Text = row["nombre"].ToString();
                                        Nombre = row["nombre"].ToString();
                                        txbStatus.Text = row["Status"].ToString();
                                        Status = row["Status"].ToString();

                                        if (row["ID_Fotografia"].ToString().Length >= 2)
                                        {
                                            imgFotografia.Image = Clase_ConvertImage.ByteArrayToImage((byte[])row["ID_Fotografia"]);
                                        }
                                        else
                                        {
                                            imgFotografia.Image = NewReportesControlEscolar.Properties.Resources.icono_perfil_azul;
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            //Empleados
                            foreach (DataRow row in objEmpleado.Lector.Tables[0].Rows)
                            {
                                if (row["id_persona"].ToString() == lbxNombres.SelectedValue.ToString())
                                {
                                    txbCampus.Text = row["campus"].ToString();
                                    txbCodigo.Text = row["ID_Empleado"].ToString();
                                    IdCodigo = row["ID_Empleado"].ToString();
                                    IdPersona = row["Id_persona"].ToString();
                                    Nombre = row["nombre"].ToString();


                                    if (row["ID_Fotografia"].ToString().Length >= 2)
                                    {
                                        imgFotografia.Image = Clase_ConvertImage.ByteArrayToImage((byte[])row["ID_Fotografia"]);
                                        Fotografia = (byte[])row["ID_Fotografia"];
                                    }
                                    else
                                    {
                                        imgFotografia.Image = NewReportesControlEscolar.Properties.Resources.icono_perfil_azul;
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                }
            }
        }

        private void LbxNombres_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void TxbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                lbxNombres.Focus();
                lbxNombres.SelectedIndex = 0;
                LbxNombres_SelectedIndexChanged(null, null);
            }
        }

        private void LbxNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }

        }

        private void LbxNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Tipo)
            {
                case 0:
                    {
                        try
                        {
                            //Prospectos
                            foreach (DataRow row in objProspecto.Lector.Tables[0].Rows)
                            {
                                if (lbxNombres.SelectedValue == null)
                                {
                                    break;
                                }
                                if (row["id_persona"].ToString() == lbxNombres.SelectedValue.ToString())
                                {
                                    txbCampus.Text = row["Campus"].ToString();
                                    txbEspecialidad.Text = row["Descripcion"].ToString();
                                    IdCodigo = row["ID_Prospecto"].ToString();
                                    IdPersona = row["Id_persona"].ToString();
                                    Nombre = row["nombre"].ToString();
                                    txbStatus.Text = row["Status_Prospecto"].ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        break;
                    }
                case 1:
                    {
                        try
                        {
                            //Alumnos
                            foreach (DataRow row in objAlumno.Lector.Tables[0].Rows)
                            {
                                if (lbxNombres.SelectedValue == null)
                                {
                                    break;
                                }
                                if (row["ID_Alumno"].ToString() == lbxNombres.SelectedValue.ToString())
                                {
                                    txbCampus.Text = row["campus"].ToString();
                                    txbEspecialidad.Text = row["Descripcion"].ToString();
                                    txbCuatri.Text = row["numsem"].ToString();
                                    IdCodigo = row["ID_Alumno"].ToString();
                                    IdPersona = row["Id_persona"].ToString();
                                    Especialidad = row["ID_Especialidad"].ToString();
                                    Nombre = row["nombre"].ToString();
                                    txbStatus.Text = row["Status"].ToString();
                                    Status = row["Status"].ToString();

                                    if (row["ID_Fotografia"].ToString().Length >= 2)
                                    {
                                        imgFotografia.Image = Clase_ConvertImage.ByteArrayToImage((byte[])row["ID_Fotografia"]);
                                    }
                                    else
                                    {
                                        imgFotografia.Image = NewReportesControlEscolar.Properties.Resources.icono_perfil_azul;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        break;
                    }
                case 2:
                    {
                        //Empleados
                        foreach (DataRow row in objEmpleado.Lector.Tables[0].Rows)
                        {
                            if (lbxNombres.SelectedValue == null)
                            {
                                break;
                            }

                            if (row["id_persona"].ToString() == lbxNombres.SelectedValue.ToString())
                            {
                                txbCampus.Text = row["campus"].ToString();
                                IdCodigo = row["ID_Empleado"].ToString();
                                IdPersona = row["Id_persona"].ToString();
                                Nombre = row["nombre"].ToString();


                                if (row["ID_Fotografia"].ToString().Length >= 2)
                                {
                                    imgFotografia.Image = Clase_ConvertImage.ByteArrayToImage((byte[])row["ID_Fotografia"]);
                                    Fotografia = (byte[])row["ID_Fotografia"];
                                }
                                else
                                {
                                    imgFotografia.Image = NewReportesControlEscolar.Properties.Resources.icono_perfil_azul;
                                }
                                break;
                            }
                        }
                        break;
                    }
            }
        }

        private void TxbNombre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cboCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clase_Sesion.Campus = cboCampus.SelectedValue.ToString();
            Busqueda(Keys.A);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Busqueda(Keys.A);
        }

        public void BusquedaParaVirtuasl()
		{

            string aux = Clase_Sesion.Campus;
            Clase_Campus objCampus = new Clase_Campus();
            objCampus.ConsultaComboCampus();
            cboCampus.Visible = true;
            cboCampus.DataSource = objCampus.Lector.Tables[0];
            cboCampus.DisplayMember = "Campus";
            cboCampus.ValueMember = "ID_Campus";
            cboCampus.SelectedValue = aux;

            Clase_Sesion.Campus = cboCampus.SelectedValue.ToString();
            cboCampus.Show();
            switch (Tipo)
            {
                case 0:
                    {
                        //Prospecto
                        lblMatriEmple.Text = "Num. Prospecto";
                        objProspecto = new Clase_Prospectos();
                        break;
                    }
                case 1:
                    {
                        //alumno
                        lblMatriEmple.Text = "Matricula";
                        objAlumno = new Clase_Alumnos();
                        break;
                    }
                case 2:
                    {
                        lblMatriEmple.Text = "Clave";
                        objEmpleado = new Clase_Empleados();
                        lblSemCua.Visible = false;
                        lblStatus.Visible = false;
                        txbCuatri.Visible = false;
                        txbStatus.Visible = false;
                        lblEspecialidad.Visible = false;
                        txbEspecialidad.Visible = false;
                        label1.Visible = false;
                        cboCampus.Visible = false;
                        checkBox1.Visible = false;

                        break;
                    }
            }
            if (Clase_Sesion.Rol == "14" || Clase_Sesion.Rol == "1" || Clase_Sesion.Rol == "2" || Clase_Sesion.Rol == "7" || Clase_Sesion.Rol == "8")
            {
                label1.Visible = true;
                cboCampus.Visible = true;
                checkBox1.Visible = true;
            }

            cboCampus.Enabled = true;

            cboCampus.SelectedValue = "18"; 
            cboCampus.Enabled = false;
            cbxActivos.Checked = false;

        }
    }
}
