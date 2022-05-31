using System;
using System.Collections.Generic;

namespace ProyectoLoboSostenido
{
    public class Clase_Tipo_Beca : Clase_Conecta
    {
        public bool ConsultaTipoBeca()
        {
            string nomStore = "ComboTipoBeca";
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class Clase_Alumnos : Clase_Personas
    {
        #region Propiedades
        public string Alumno { get; set; }
        public string Fecha_Registro { get; set; }
        public string Tipo_Plan { get; set; }
        public string Especialidad { get; set; }
        public string ID_Campus { get; set; }
        public string Generacion { get; set; }
        public string Num_Semestre { get; set; }
        public string Grupo { get; set; }
        public string ID_Status { get; set; }
        public string Periodo_Ingreso { get; set; }
        public byte[] Fotografia { get; set; }
        public string Nombre1 { get; set; }
        public string Paterno1 { get; set; }
        public string Materno1 { get; set; }
        public string Calle1 { get; set; }
        public string Colonia1 { get; set; }
        public string Cp1 { get; set; }
        public string RIF { get; set; }
        public string Id_CEscolar { get; set; }
        public string Opt { get; set; }
        #endregion

        #region Constructores
        public Clase_Alumnos()
        {
        }

        public Clase_Alumnos(string ID_Alumno, byte[] foto)
        {
            Alumno = ID_Alumno;
            Fotografia = foto;
        }

        public Clase_Alumnos(string ID_Alumno)
        {
            Alumno = ID_Alumno;
        }

        public Clase_Alumnos(string ID_Alumno, byte[] foto, string nombreC, string paternoC, string maternoC, string calleC, string coloniaC, string cpC)
        {
            Alumno = ID_Alumno;
            Fotografia = foto;
            Nombre1 = nombreC;
            Paterno1 = paternoC;
            Materno1 = maternoC;
            Calle1 = calleC;
            Colonia1 = coloniaC;
            Cp1 = cpC;
        }

        public Clase_Alumnos(string IDAlumno, string FechaRegistro, string TipoPlan, string IDEspecialidad, string IDCampus, string generacion, string NumeroSemestre, string grupo, string IDStatus, string PeriodoIngreso,
                        string Curp, string Nombre, string Paterno, string Materno, string Calle, string Colonia, string CP, string LugarNacimiento, string Nacionalidad, string EstadoCivil, string Telefono, string Celular, string Correo, string RFC, string FechaNacimiento, string Sexo, string Campus)
            : base(Curp, Nombre, Paterno, Materno, Calle, Colonia, CP, LugarNacimiento, Nacionalidad, EstadoCivil, Telefono, Celular, Correo, RFC, FechaNacimiento, Sexo, Campus)
        {
            Alumno = IDAlumno;
            Fecha_Registro = FechaRegistro;
            Tipo_Plan = TipoPlan;
            Especialidad = IDEspecialidad;
            ID_Campus = IDCampus;
            Generacion = generacion;
            Num_Semestre = NumeroSemestre;
            Grupo = grupo;
            ID_Status = IDStatus;
            Periodo_Ingreso = PeriodoIngreso;
        }

        public Clase_Alumnos(string IDAlumno, byte[] foto, string FechaRegistro, string TipoPlan, string IDEspecialidad, string IDCampus, string generacion, string NumeroSemestre, string grupo, string IDStatus, string PeriodoIngreso,
                        string Curp, string Nombre, string Paterno, string Materno, string Calle, string Colonia, string CP, string LugarNacimiento, string Nacionalidad, string EstadoCivil, string Telefono, string Celular, string Correo, string RFC, string FechaNacimiento, string Sexo, string Campus)
            : base(Curp, Nombre, Paterno, Materno, Calle, Colonia, CP, LugarNacimiento, Nacionalidad, EstadoCivil, Telefono, Celular, Correo, RFC, FechaNacimiento, Sexo, Campus)
        {
            Alumno = IDAlumno;
            Fecha_Registro = FechaRegistro;
            Tipo_Plan = TipoPlan;
            Especialidad = IDEspecialidad;
            ID_Campus = IDCampus;
            Generacion = generacion;
            Num_Semestre = NumeroSemestre;
            Grupo = grupo;
            ID_Status = IDStatus;
            Periodo_Ingreso = PeriodoIngreso;
            Fotografia = foto;
        }
        #endregion

        #region Métodos

        /*========================================================================================================*/

        public bool Inserta_Alumno_SinFoto(string ID_Persona, string ID_EscuelaProcedencia, string RazonSocial, string DomicilioFiscal, string RIF, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosCompletosSinFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", RIF),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("correoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString())
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Inserta_Alumno_SinFoto2(string ID_Persona, string ID_EscuelaProcedencia, string RazonSocial, string DomicilioFiscal, string RIF, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string CorreoPortal, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosCompletosSinFoto2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", RIF),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("correoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString()),
                new Clase_Parametros("CorreoPortal", CorreoPortal)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno_ConFoto(string ID_Persona, string ID_EscuelaProcedencia, byte[] Fotografia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosCompletosConFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", Fotografia),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("RIF",rif),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("correoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString())
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Inserta_Alumno_ConFoto2(string ID_Persona, string ID_EscuelaProcedencia, byte[] Fotografia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string CorreoPortal, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosCompletosConFoto2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", Fotografia),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("RIF",rif),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("correoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString()),
                new Clase_Parametros("CorreoPortal", CorreoPortal)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno_DatosFam_ConFoto(string ID_Persona, string ID_EscuelaProcedencia, byte[] ID_Fotografia, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosFamiliaresConFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", ID_Fotografia),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("correoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString())
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Inserta_Alumno_DatosFam_ConFoto2(string ID_Persona, string ID_EscuelaProcedencia, byte[] ID_Fotografia, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string CorreoPortal)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosFamiliaresConFoto2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", ID_Fotografia),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("correoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString()),
                new Clase_Parametros("CorreoPortal", CorreoPortal)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno_DatosFam_SinFoto(string ID_Persona, string ID_EscuelaProcedencia, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosFamiliaresSinFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CorreoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString())
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Inserta_Alumno_DatosFam_SinFoto2(string ID_Persona, string ID_EscuelaProcedencia, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string CorreoPortal)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosFamiliaresSinFoto2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CorreoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString()),
                new Clase_Parametros("CorreoPortal", CorreoPortal)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno_DatosFis_ConFoto(string ID_Persona, string ID_EscuelaProcedencia, byte[] ID_Fotografia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosFiscalesConFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", ID_Fotografia),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", rif),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString())
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Inserta_Alumno_DatosFis_ConFoto2(string ID_Persona, string ID_EscuelaProcedencia, byte[] ID_Fotografia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string CorreoPortal, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosFiscalesConFoto2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", ID_Fotografia),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", rif),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString()),
                new Clase_Parametros("CorreoPortal", CorreoPortal)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno_DatosFis_SinFoto(string ID_Persona, string ID_EscuelaProcedencia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosFiscalesSinFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", rif),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString())
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Inserta_Alumno_DatosFis_SinFoto2(string ID_Persona, string ID_EscuelaProcedencia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string CorreoPortal, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmAddNuevoAlumnoDatosFiscalesSinFoto2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", rif),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString()),
                new Clase_Parametros("CorreoPortal", CorreoPortal)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_NuevoAlumno_SinFoto(string ID_Persona, string ID_EscuelaProcedencia, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev)
        {
            string nomProce = "FrmaddNuevoAlumnoSinFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString())
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Inserta_NuevoAlumno_SinFoto2(string ID_Persona, string ID_EscuelaProcedencia, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, bool Rev, string CorreoPortal)
        {
            string nomProce = "FrmaddNuevoAlumnoSinFoto2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),
                new Clase_Parametros("Revalidacion", Rev.ToString()),
                new Clase_Parametros("CorreoPortal", CorreoPortal)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Actualizar_Alumno_ConFoto(string ID_Persona, string ID_EscuelaProcedencia, byte[] Fotografia, string RazonSocial, string DomicilioFiscal, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, /*string FechaBaja, string MotivoBaja, string Empleado,*/string pass, string IngresoProcedencia, string EgresoProcedencia, string bajaAdmin, bool Rev, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmupAlumnosConFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),          /*PARA HACER EL UPDATE*/
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),

                new Clase_Parametros("Alumno", Alumno),                  /*PARA HACER EL UPDATE*/
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", Fotografia),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CorreoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),

               /* new Clase_Parametros("FechaBaja", FechaBaja),
                new Clase_Parametros("MotivoBaja", MotivoBaja),
                new Clase_Parametros("Empleado", Empleado),*/
                new Clase_Parametros("pass", pass),
                new Clase_Parametros("bajaAdmin",bajaAdmin),
                new Clase_Parametros("Revalidacion", Rev.ToString())
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Actualizar_Alumno_ConFoto2(string ID_Persona, string ID_EscuelaProcedencia, byte[] Fotografia, string RazonSocial, string DomicilioFiscal, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string pass, string IngresoProcedencia, string EgresoProcedencia, string bajaAdmin, bool Rev, string correoPortal, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmupAlumnosConFoto2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),          /*PARA HACER EL UPDATE*/
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),

                new Clase_Parametros("Alumno", Alumno),                  /*PARA HACER EL UPDATE*/
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", Fotografia),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CorreoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),

                new Clase_Parametros("pass", pass),
                new Clase_Parametros("bajaAdmin",bajaAdmin),
                new Clase_Parametros("Revalidacion", Rev.ToString()),
                new Clase_Parametros("CorreoMoodle", correoPortal)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Actualizar_Alumno_SinFoto(string ID_Persona, string ID_EscuelaProcedencia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, /*string FechaBaja, string MotivoBaja, string Empleado,*/string pass, string IngresoProcedencia, string EgresoProcedencia, string bajaAdmin, bool Rev, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmupAlumnosSinFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),          /*PARA HACER EL UPDATE*/
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),

                new Clase_Parametros("Alumno", Alumno),                  /*PARA HACER EL UPDATE*/
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CorreoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", rif),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),

                /*new Clase_Parametros("FechaBaja", FechaBaja),
                new Clase_Parametros("MotivoBaja", MotivoBaja),
                new Clase_Parametros("Empleado", Empleado),*/
                new Clase_Parametros("pass", pass),
                new Clase_Parametros("bajaAdmin",bajaAdmin),
                new Clase_Parametros("Revalidacion",Rev.ToString())
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Actualizar_Alumno_SinFoto2(string ID_Persona, string ID_EscuelaProcedencia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, /*string FechaBaja, string MotivoBaja, string Empleado,*/string pass, string IngresoProcedencia, string EgresoProcedencia, string bajaAdmin, bool Rev, string correoPortal, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "FrmupAlumnosSinFoto2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),          /*PARA HACER EL UPDATE*/
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),

                new Clase_Parametros("Alumno", Alumno),                  /*PARA HACER EL UPDATE*/
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CorreoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", rif),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),

                new Clase_Parametros("pass", pass),
                new Clase_Parametros("bajaAdmin",bajaAdmin),
                new Clase_Parametros("Revalidacion",Rev.ToString()),
                new Clase_Parametros("CorreoMoodle", correoPortal)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*========================================================================================================*/

        public bool ConsultaAlumnoByID(string ID_Alumno)
        {
            string nomProce = "ConsultaAlumnoByID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaAlumnoCorreo(string ID_Alumno)
        {
            string nomProce = "ConsultaCorreoAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Consulta_LBS_DatosAlumno(string ID_Alumno)
        {
            string nomProce = "Consulta_LBS_DatosAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaDatosLBS_Alumno(string ID_Alumno)
        {
            string nomProce = "ConsultaDatosLBS_Alumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Consulta_LBS_DatosDocente(string ID_Empleado)
        {
            string nomProce = "Consulta_LBS_DatosDocente";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", ID_Empleado)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Consulta_LBS_AdeudoCampus2()
        {
            Consulta_LBS_AdeudoCampus();
        }
        public bool Consulta_LBS_AdeudoCampus()
        {
            string nomProce = "Consulta_LBS_AdeudoCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        string ID_AlumnoLBS = "";
        public void Consulta_LBS_AdeudoAlumno3(string ID_Alumno)
        {
            this.ID_AlumnoLBS = ID_Alumno;
        }

        public void Consulta_LBS_AdeudoAlumno2()
        {
            Consulta_LBS_AdeudoAlumno(ID_AlumnoLBS);
        }
        public bool Consulta_LBS_AdeudoAlumno(string ID_Alumno)
        {
            string nomProce = "Consulta_LBS_AdeudoAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ConsultaAlumnosCorreos(string grupo)
        {
            string nomProce = "ConsultaCorreoAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", grupo)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateAutorizado(string grupo, bool autorizado)
        {
            string nomProce = "upAutorizado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", grupo),
                new Clase_Parametros("autorizado", autorizado.ToString())
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaAlumnos(string codigo)
        {
            string nomProce = "ComboAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", codigo)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		#region Arena Lobos
		public bool ConsultaListaArena()
		{
            string nomProce = "getArenaLobosListado";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaSocioArena(string id_socio)
        {
            string nomProce = "getArenaLobosSocio";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_codigo", id_socio)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AgregarSocioLista(string id_socio, string id_empleado)
        {
            string nomProce = "addArenaSocioLista";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_codigo", id_socio),
                new Clase_Parametros("Id_Empleado", id_empleado)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarSocioLista(string id_socio)
        {
            string nomProce = "deleteArenaLoboSocio";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_codigo", id_socio)  
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		#endregion
		public bool ConsultaReferencia(string Referencia)
        {
            string nomProce = "fndBusquedaReferencia";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("referencia", Referencia)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaAlumnosProrroga(string id_alumno, string id_periodo)
        {
            string nomProce = "getBecasAlumnosProrroga";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", id_alumno),
                new Clase_Parametros("ID_Periodo", id_periodo)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpAlumnosProrrogaCiclo(string id, string fechaProrrogaBeca)
        {
            string nomProce = "upBecasAlumnosProrrogaFecha";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_BecaProrroga", id),
                new Clase_Parametros("fechaProrrogaBeca", fechaProrrogaBeca)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaActasAlumnos(string idAlumno)
        {
            string nomProce = "ConsultaActasAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", idAlumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaActasAlumnosTipo(string idAlumno, string tipo)
        {
            string nomProce = "ConsultaActasAlumnosTipo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", idAlumno),
                new Clase_Parametros("Tipo",tipo)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaStatus(string codigo)
        {
            string nomProce = "consultarStatusXAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", codigo)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaCargosAlumnos(string ID_Alumno)
        {
            string nomProce = "ConsultaCargosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaCargosAlumnosDifer(string ID_Alumno)
        {
            string nomProce = "ConsultaCargosAlumnosDifer";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetCargosAlumnosBecas(string ID_Alumno, string ID_Periodo = "TODOS")
        {
            string nomProce = "getCargosAlumnosBecas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("ID_Periodo", ID_Periodo)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetVencimientoArena(string ID_Alumno)
        {
            string nomProce = "getVencimientoArena2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetVencimientoAlberca()
        {
            string nomProce = "actualizarPermisoAlberca";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaBecasAlumnos(string ID_Alumno)
        {
            string nomProce = "getBecasAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaBecaPerdida(string ID_Alumno)
        {
            string nomProce = "getBecasAlumnosPerdida";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ConsultaPromos(string ID_Alumno)
        {
            string nomProce = "Promo_BuscaPromosVigentes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddRecargoInscripcion(string ID_Alumno)
        {
            string nomProce = "addRecargoInscripcion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", ID_Alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaCmdAlumno(string valor, int estado, string tipo, string Campus)
        {
            string nomStore = "fndcmdAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("nombre", valor),
                new Clase_Parametros("estado", estado.ToString()),
                new Clase_Parametros("tipo", tipo),
                new Clase_Parametros("Campus", Campus.ToString()),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
            };
            if (ConsultarParametros(nomStore, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddForma13(string id_alumno, string FechaReg, string id_periodo, string id_especialidad, string grupo, string tipo)
        {
            string nomStore = "addForma13";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Alumno", id_alumno),
                new Clase_Parametros("FechaReg", FechaReg),
                new Clase_Parametros("ID_Periodo", id_periodo),
                new Clase_Parametros("ID_Especialidad", id_especialidad),
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("tipo", tipo)
            };
            if (Ejecuta(nomStore, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BorrarCargosBaja(string id_alumno, string FechaBaja)
        {
            string nomStore = "AlumnosBorrarCargosBaja";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Alumno", id_alumno),
                new Clase_Parametros("FechaBaja", FechaBaja)
            };

            if (Ejecuta(nomStore, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaStatus()
        {
            string nomProce = "ConsultaCargosAlumnos";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ComboPaises()
        {
            string nomProce = "ComboPaises";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AlumnosXEspecialidadXCicloEscolar(int opt, string Id_CEscolar)
        {
            string nomProce = "AlumnosXEspecialidadXCicloEscolar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("opt", opt.ToString()),
                new Clase_Parametros("Id_CEscolar", Id_CEscolar)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AlumnosXModalidadXCicloExcolar(int opt)
        {
            string nomProce = "AlumnosXModalidadXCicloExcolar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("opt", opt.ToString())
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaAlumnosXCID()
        {
            string nomProce = "ConsultaAlumnosXCID";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BuscaDatosAlumno(string ID_Persona, string ID_Alumno)
        {
            string nomProce = "BuscaDatosAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ConsultaAlumnosXEspecialidad(string ID_Especialidad, string status, string nivel, string gen, string grupo)
        {
            string nomProce = "ConsultaAlumnosXEspecialidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Especialidad", ID_Especialidad),
                new Clase_Parametros("ID_Status", status),
                new Clase_Parametros("NumSem", nivel),
                new Clase_Parametros("Gene", gen),
                new Clase_Parametros("Grupo", grupo),
                new Clase_Parametros("campus", Clase_Sesion.campus)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaAlumnosXGrupo(string grupo)
        {
            string nomProce = "ConsultaAlumnosXGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", grupo)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaGrupoparaFolios(string grupo)
        {
            string nomProce = "ConsultaGrupoparaFolios";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_grupo", grupo)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizaFolios(string ID_Alumno, string id_periodo, string FolioIni, string FolioFin)
        {
            string nomProce = "ActualizaFoliosAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("ID_Periodo", id_periodo),
                new Clase_Parametros("FolioInicial", FolioIni),
                new Clase_Parametros("FolioFinal", FolioFin)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizaFoliosEntregado(string ID_Alumno, string id_periodo)
        {
            string nomProce = "ActualizaFoliosAlumnoEntregado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("ID_Periodo", id_periodo)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaGrupoAutorizado(String grupo)
        {
            string nomProce = "ConsultaGrupoAutorizado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", grupo)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaAlumnosXCicloyModalidad(string ciclo, string modalidad)
        {
            string nomProce = "ConsultaAlumnosXCicloyModalidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("CicloEscolar", ciclo),
                new Clase_Parametros("Modalidad", modalidad)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaAlumnosXGrupoEmail(String grupo)
        {
            string nomProce = "ConsultaAlumnosXGrupoEmail";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", grupo)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaNumAlumnosXMateria(string materia, string grupo)
        {
            string nomProce = "ConsultaNumAlumnosXMateria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Materia", materia),
                new Clase_Parametros("ID_Grupo", grupo)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaAlumnosenArqueosCampus(string campus)
        {
            string nomProce = "[ConsultaAlumnosenArqueosCampus]";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("idcampus", campus)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaAlumnoCampusInsCol(string id_Alumno, string Tipo)
        {
            string nomProce = "[ConsultaFiltroCartaCumplimientoPagos]";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", id_Alumno),
                new Clase_Parametros("Tipo", Tipo)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Actualiza_Cliente(string ID_Alumno, string Nombre, string Paterno, string Materno, string Email, string Telefono,
            string Celular, string RIF, string RazonSocial, string RFC, string PaisOrigen, string Ciudad, string DomicilioFiscal, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "upClienteALCC";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Email", Email),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("RIF", RIF),
                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("RFC", RFC),
                new Clase_Parametros("PaisOrigen", PaisOrigen),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("tipo", "1"),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Add_Cliente(string ID_Alumno, string Nombre, string Paterno, string Materno, string Email, string Telefono,
            string Celular, string RIF, string RazonSocial, string RFC, string PaisOrigen, string Ciudad, string DomicilioFiscal, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "upClienteALCC";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Email", Email),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("RIF", RIF),
                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("RFC", RFC),
                new Clase_Parametros("PaisOrigen", PaisOrigen),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("tipo", "2"),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno(string ID_Persona, string ID_EscuelaProcedencia, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia)
        {
            string nomProce = "AddNuevoAlumnoSinFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno(string ID_Persona, string ID_EscuelaProcedencia, byte[] ID_Fotografia, string Expediente_SEP, string IngresoProcedencia, string EgresoProcedencia)
        {
            string nomProce = "AddNuevoAlumnoConFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", ID_Fotografia),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Expediente_SEP)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno(string ID_Persona, string ID_EscuelaProcedencia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "AddNuevoAlumnoDatosFiscalesSinFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", rif),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno(string ID_Persona, string ID_EscuelaProcedencia, byte[] ID_Fotografia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "AddNuevoAlumnoDatosFiscalesConFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", ID_Fotografia),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", rif),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno(string ID_Persona, string ID_EscuelaProcedencia, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, string vacio)
        {
            string nomProce = "AddNuevoAlumnoDatosFamiliaresSinFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CorreoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno(string ID_Persona, string ID_EscuelaProcedencia, byte[] ID_Fotografia, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, string vacio)
        {
            string nomProce = "AddNuevoAlumnoDatosFamiliaresConFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", ID_Fotografia),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("correoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno(string ID_Persona, string ID_EscuelaProcedencia, string RazonSocial, string DomicilioFiscal, string RIF, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "AddNuevoAlumnoDatosCompletosSinFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", RIF),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("correoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Inserta_Alumno(string ID_Persona, string ID_EscuelaProcedencia, byte[] Fotografia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, string IngresoProcedencia, string EgresoProcedencia, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "AddNuevoAlumnoDatosCompletosConFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("ID_Campus", Campus),

                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecha_Registro),
                new Clase_Parametros("TipoPlan", Tipo_Plan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", Fotografia),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("RIF",rif),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("correoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Actualizar_AlumnoSinFoto(string ID_Persona, string ID_EscuelaProcedencia, string RazonSocial, string DomicilioFiscal, string rif, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, /*string FechaBaja, string MotivoBaja, string Empleado,*/string pass, string IngresoProcedencia, string EgresoProcedencia, string bajaAdmin, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "upAlumnosSinFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),          /*PARA HACER EL UPDATE*/
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),

                new Clase_Parametros("Alumno", Alumno),                  /*PARA HACER EL UPDATE*/
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CorreoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("RIF", rif),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),

                /*new Clase_Parametros("FechaBaja", FechaBaja),
                new Clase_Parametros("MotivoBaja", MotivoBaja),
                new Clase_Parametros("Empleado", Empleado),*/
                new Clase_Parametros("pass", pass),
                new Clase_Parametros("bajaAdmin",bajaAdmin)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddBajaAlumno(string id_Alum, string FechaBaja, string MotivoBaja, string Empleado, string ID_Stat)
        {
            string nomProce = "addBajaAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", id_Alum),                  /*PARA HACER EL UPDATE*/
                new Clase_Parametros("ID_Status", ID_Stat),
                new Clase_Parametros("FechaBaja", FechaBaja),
                new Clase_Parametros("MotivoBaja", MotivoBaja),
                new Clase_Parametros("Empleado", Empleado)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Actualizar_Alumno(string ID_Persona, string ID_EscuelaProcedencia, byte[] Fotografia, string RazonSocial, string DomicilioFiscal, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama, string Expediente_SEP, string Folio_SEP, /*string FechaBaja, string MotivoBaja, string Empleado,*/string pass, string IngresoProcedencia, string EgresoProcedencia, string bajaAdmin, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "upAlumnosConFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),          /*PARA HACER EL UPDATE*/
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", Cp),
                new Clase_Parametros("LugarNacimiento", Lugarnacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("EdoCivil", EdoCivil),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),

                new Clase_Parametros("Alumno", Alumno),                  /*PARA HACER EL UPDATE*/
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Num_Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("PeriodoIngreso", Periodo_Ingreso),
                new Clase_Parametros("Fotografia", Fotografia),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("ID_EscuelaProcedencia", ID_EscuelaProcedencia),
                new Clase_Parametros("IngresoProcedencia", IngresoProcedencia),
                new Clase_Parametros("EgresoProcedencia", EgresoProcedencia),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CorreoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),

                new Clase_Parametros("Expediente_SEP", Expediente_SEP),
                new Clase_Parametros("Folio_SEP", Folio_SEP),

               /* new Clase_Parametros("FechaBaja", FechaBaja),
                new Clase_Parametros("MotivoBaja", MotivoBaja),
                new Clase_Parametros("Empleado", Empleado),*/
                new Clase_Parametros("pass", pass),
                new Clase_Parametros("bajaAdmin",bajaAdmin)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BuscaBajaAlumno(string ID_Alumno)
        {
            string nomProce = "BuscaBajaAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarTempAlumnos()
        {

            string nomProce = "EliminarTempAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertarTempAlumnos(string alumno)
        {
            string nomProce = "insertarTempAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", alumno),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertarActaExamen(string ID_Alumno, string ID_TipoActa, string sinodal1, string sinodal2, string sinodal3, string sinodal4, string sinodal5, string opcion, string tema, string fechaexamen, string horaentrada, string horasalida, string resultado, string duracion, string acta, string libro, string hoja, string oficio, string autorizacion, string fecha, string certificado, string fechacertificado, string id_Materia)
        {
            string nomProce = "AddAlumnoActaExamen";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("ID_Tipo_Acta", ID_TipoActa),
                new Clase_Parametros("sinodal1", sinodal1),
                new Clase_Parametros("sinodal2", sinodal2),
                new Clase_Parametros("sinodal3", sinodal3),
                new Clase_Parametros("sinodal4", sinodal4),
                new Clase_Parametros("sinodal5", sinodal5),
                new Clase_Parametros("opcion", opcion),
                new Clase_Parametros("tema", tema),
                new Clase_Parametros("fechaexamen", fechaexamen),
                new Clase_Parametros("horaentrada", horaentrada),
                new Clase_Parametros("horasalida", horasalida),
                new Clase_Parametros("resultado", resultado),
                new Clase_Parametros("duracion", duracion),
                new Clase_Parametros("acta", acta),
                new Clase_Parametros("libro", libro),
                new Clase_Parametros("hoja", hoja),
                new Clase_Parametros("oficio", oficio),
                new Clase_Parametros("autorizacion", autorizacion),
                new Clase_Parametros("fecha", fecha),
                new Clase_Parametros("Certificado", certificado),
                new Clase_Parametros("FechaCertificado", fechacertificado),
                new Clase_Parametros("ID_Materia", id_Materia)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertarActaExamenPrepa(string ID_Alumno, string ID_TipoActa, string sinodal1, string sinodal2,
            string sinodal3, string acta, string libro, string hoja, string id_Materia)
        {
            string nomProce = "addAlumnoActaExamenPrepa";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("ID_Tipo_Acta", ID_TipoActa),
                new Clase_Parametros("sinodal1", sinodal1),
                new Clase_Parametros("sinodal2", sinodal2),
                new Clase_Parametros("sinodal3", sinodal3),
                new Clase_Parametros("acta", acta),
                new Clase_Parametros("libro", libro),
                new Clase_Parametros("hoja", hoja),
                new Clase_Parametros("ID_Materia", id_Materia)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertarActaExamen2(string ID_Alumno, string sinodal1, string sinodal2, string sinodal3, string sinodal4, string sinodal5, string opcion, string tema, string fechaexamen, string horaentrada, string horasalida, string resultado, string duracion, string acta, string libro, string hoja, string oficio, string autorizacion, string fecha, string certificado, string fechacertificado)
        {
            string nomProce = "AddAlumnoActaExamen";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("ID_Tipo_Acta", "2"),
                new Clase_Parametros("sinodal1", sinodal1),
                new Clase_Parametros("sinodal2", sinodal2),
                new Clase_Parametros("sinodal3", sinodal3),
                new Clase_Parametros("sinodal4", sinodal4),
                new Clase_Parametros("sinodal5", sinodal5),
                new Clase_Parametros("opcion", opcion),
                new Clase_Parametros("tema", tema),
                new Clase_Parametros("fechaexamen", fechaexamen),
                new Clase_Parametros("horaentrada", horaentrada),
                new Clase_Parametros("horasalida", horasalida),
                new Clase_Parametros("resultado", resultado),
                new Clase_Parametros("duracion", duracion),
                new Clase_Parametros("acta", acta),
                new Clase_Parametros("libro", libro),
                new Clase_Parametros("hoja", hoja),
                new Clase_Parametros("oficio", oficio),
                new Clase_Parametros("autorizacion", autorizacion),
                new Clase_Parametros("fecha", fecha),
                new Clase_Parametros("Certificado", certificado),
                new Clase_Parametros("FechaCertificado", fechacertificado)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertarActaExamen3(string ID_Alumno, string sinodal1, string sinodal2, string sinodal3, string sinodal4, string sinodal5, string opcion, string tema, string fechaexamen, string horaentrada, string horasalida, string resultado, string duracion, string acta, string libro, string hoja, string oficio, string autorizacion, string fecha, string certificado, string fechacertificado)
        {
            string nomProce = "AddAlumnoActaExamen";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("ID_Tipo_Acta", "3"),
                new Clase_Parametros("sinodal1", sinodal1),
                new Clase_Parametros("sinodal2", sinodal2),
                new Clase_Parametros("sinodal3", sinodal3),
                new Clase_Parametros("sinodal4", sinodal4),
                new Clase_Parametros("sinodal5", sinodal5),
                new Clase_Parametros("opcion", opcion),
                new Clase_Parametros("tema", tema),
                new Clase_Parametros("fechaexamen", fechaexamen),
                new Clase_Parametros("horaentrada", horaentrada),
                new Clase_Parametros("horasalida", horasalida),
                new Clase_Parametros("resultado", resultado),
                new Clase_Parametros("duracion", duracion),
                new Clase_Parametros("acta", acta),
                new Clase_Parametros("libro", libro),
                new Clase_Parametros("hoja", hoja),
                new Clase_Parametros("oficio", oficio),
                new Clase_Parametros("autorizacion", autorizacion),
                new Clase_Parametros("fecha", fecha),
                new Clase_Parametros("Certificado", certificado),
                new Clase_Parametros("FechaCertificado", fechacertificado)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Rdprofesional(string alumno)
        {
            string nomProce = "ConsultaAlumnoActaExamen";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", alumno),
                new Clase_Parametros("id_tipo_acta", "1")
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Rdmaestria(string alumno)
        {
            string nomProce = "ConsultaAlumnoActaExamen";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", alumno),
                new Clase_Parametros("id_tipo_acta", "2")
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Rddoctorado(string alumno)
        {
            string nomProce = "ConsultaAlumnoActaExamen";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", alumno),
                new Clase_Parametros("id_tipo_acta", "3")
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RdPreparatoria(string alumno)
        {
            string nomProce = "ConsultaAlumnoActaExamen";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", alumno),
                new Clase_Parametros("id_tipo_acta", "4")
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertarServicioSocial(string ID_Alumno, string FechaRegistro, string Dependencia, string EncargadoDependencia,
            string PuestoEncargado, string DomicilioDependencia, string TelefonoDependencia, string Programa, string Objetivo,
            string Actividades, string FechaInicio, string FechaFinal, string HorarioESSR, string HorarioSSSR, string Expediente, string Horas)
        {
            string nomProce = "AddServicioSocialPracticas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_TipoReporte", "1"),
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("FechaRegistro", FechaRegistro),
                new Clase_Parametros("Dependencia", Dependencia),
                new Clase_Parametros("EncargadoDependencia", EncargadoDependencia),
                new Clase_Parametros("PuestoEncargado", PuestoEncargado),
                new Clase_Parametros("DomicilioDependencia", DomicilioDependencia),
                new Clase_Parametros("TelefonoDependencia", TelefonoDependencia),
                new Clase_Parametros("Programa", Programa),
                new Clase_Parametros("Objetivo", Objetivo),
                new Clase_Parametros("Actividades", Actividades),
                new Clase_Parametros("FechaInicio", FechaInicio),
                new Clase_Parametros("FechaFinal", FechaFinal),
                new Clase_Parametros("HorarioESSR", HorarioESSR),
                new Clase_Parametros("HorarioSSSR", HorarioSSSR),
                new Clase_Parametros("Expediente", Expediente),
                new Clase_Parametros("Horas", Horas)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertarPracticaProfesional(string ID_Alumno, string FechaRegistro, string Dependencia, string EncargadoDependencia, string PuestoEncargado, string DomicilioDependencia, string TelefonoDependencia, string Programa, string Objetivo, string Actividades, string FechaInicio, string FechaFinal, string HorarioESSR, string HorarioSSSR, string Expediente, string Horas)
        {
            string nomProce = "AddServicioSocialPracticas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_TipoReporte", "2"),
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("FechaRegistro", FechaRegistro),
                new Clase_Parametros("Dependencia", Dependencia),
                new Clase_Parametros("EncargadoDependencia", EncargadoDependencia),
                new Clase_Parametros("PuestoEncargado", PuestoEncargado),
                new Clase_Parametros("DomicilioDependencia", DomicilioDependencia),
                new Clase_Parametros("TelefonoDependencia", TelefonoDependencia),
                new Clase_Parametros("Programa", Programa),
                new Clase_Parametros("Objetivo", Objetivo),
                new Clase_Parametros("Actividades", Actividades),
                new Clase_Parametros("FechaInicio", FechaInicio),
                new Clase_Parametros("FechaFinal", FechaFinal),
                new Clase_Parametros("HorarioESSR", HorarioESSR),
                new Clase_Parametros("HorarioSSSR", HorarioSSSR),
                new Clase_Parametros("Expediente", Expediente),
                new Clase_Parametros("Horas", Horas)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaSS(string ID_Alumno)
        {
            string nomProce = "ConsultaServicioSocial";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_alumno", ID_Alumno)
            };
            //par.Add(new Clase_Parametros("ID_TipoReporte", "1"));
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaPP(string ID_Alumno)
        {
            string nomProce = "ConsultaPracticasProfesionales";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_alumno", ID_Alumno)
            };
            //par.Add(new Clase_Parametros("ID_TipoReporte", "2"));
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaListaAlumnos(string ID_Status, string modalidad, string especialidad, string generacion, string semestre, string grupo, string orden)
        {
            string nomProce = "ConsultaListaAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("ID_TipoPlan", modalidad),
                new Clase_Parametros("ID_Especialidad", especialidad),
                new Clase_Parametros("Generacion", generacion),
                new Clase_Parametros("NumSem", semestre),
                new Clase_Parametros("Grupo", grupo),
                new Clase_Parametros("Orden", orden),
                new Clase_Parametros("ID_Campus", Clase_Sesion.campus)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaListaAlumnosSexo(string ID_Status, string modalidad, string especialidad, string generacion, string semestre, string grupo, string orden)
        {
            string nomProce = "ConsultaListaAlumnosSexo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Status", ID_Status),
                new Clase_Parametros("id_TipoPlan", modalidad),
                new Clase_Parametros("ID_Especialidad", especialidad),
                new Clase_Parametros("Generacion", generacion),
                new Clase_Parametros("NumSem", semestre),
                new Clase_Parametros("Grupo", grupo),
                new Clase_Parametros("Orden", orden),
                new Clase_Parametros("ID_Campus", Clase_Sesion.campus)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AgregarCredencial(string alumno, string clave, string numero, string nombre)
        {
            string nomProce = "Acceso";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Alumno", alumno),
                new Clase_Parametros("Clave", clave),
                new Clase_Parametros("Numero", numero),
                new Clase_Parametros("nombre", nombre)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AgregarCredencial2(string alumno, string clave, string numero, string nombre)
        {
            string nomProce = "Acceso";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Alumno", alumno),
                new Clase_Parametros("Clave", clave),
                new Clase_Parametros("Numero", numero),
                new Clase_Parametros("nombre", nombre)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BuscaCredencial(string alumno, string clave, string numero, string nombre)
        {
            string nomProce = "AccesoBusca";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Alumno", alumno),
                new Clase_Parametros("Clave", clave),
                new Clase_Parametros("Numero", numero),
                new Clase_Parametros("nombre", nombre)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BuscaCredencial2(string ID_Persona)
        {
            string nomProce = "AccesoDatosPersona";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpFoto()
        {
            string nomProce = "upFotoAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", Alumno),
                new Clase_Parametros("Foto", Fotografia),

            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaDocumentosCampus(string Especialidad, string campus)
        {
            string nomProce = "ConsultaDocumentosCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Especialidad", Especialidad),
                new Clase_Parametros("campus", campus)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaDocumentosAlumno(string opcion, string ID_Persona, string ID_Alumno)
        {
            string nomProce = "ConsultaDocumentosAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("opcion", opcion),
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaAlumnosCargosGenerados(string ID_periodo)
        {
            string nomProce = "RPT_CargosGeneradosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Periodo", ID_periodo)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaAlumnosCicloEscolarVirtual()
		{
            string nomProce = "DatosAlumnosVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", Alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ComboGruposVirtual(string ciclo,string gpo,string rvoe)
        {
            string nomProce = "GetDatosComboGruposVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("CicloEscolar", ciclo),
                new Clase_Parametros("gpo", gpo),
                new Clase_Parametros("rvoe", rvoe),

            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GetMateriasDocentesVirtual(string id_alumno, string grupo)
        {
            
            string nomProce = "GetDatosMateriasDocentesVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Alumno", id_alumno),
                new Clase_Parametros("Id_grupo", grupo) 

            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OrdenamientoCiclosEscolaresVirtual()
        {

            string nomProce = "AcomodoCiclosEscolaresVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Alumno", Alumno) 

            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool getGruposCiclos(string persona)
        {

            string nomProce = "ConsultarGruposXAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", persona)

            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        #region AsignarContraseñaPortal
        public bool SetPassword_Alumno(string id_alumno, string pass)
        {
            string nomProce = "SetPassword_Alumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", id_alumno),
                new Clase_Parametros("Pass", pass)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #endregion
    }
    public class Clase_Alumno_DatosFiscales : Clase_Personas
    {
        #region Propiedades
        public string RFC { get; set; }
        public string Razon_Social { get; set; }
        public string DomicilioFiscal { get; set; }
        public string Ciudad { get; set; }
        public string RIF { get; set; }
        #endregion

        #region Constructores
        public Clase_Alumno_DatosFiscales()
        { }
        public Clase_Alumno_DatosFiscales(string rfc, string razonsocial, string domiciliofiscal, string ciudad, string rIF, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            RFC = rfc;
            Razon_Social = razonsocial;
            DomicilioFiscal = domiciliofiscal;
            Ciudad = ciudad;
            RIF = rIF;
        }
        #endregion

        #region Métodos
        public bool AddFacturaIndependienteMovs(string id_factura, string cantidad, string concepto, string pUnitario, string importe)
        {
            string nomProce = "addFacturaIndependienteMovs";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_factura", id_factura),
                new Clase_Parametros("cantidad", cantidad),
                new Clase_Parametros("concepto", concepto),
                new Clase_Parametros("pUnitario", pUnitario),
                new Clase_Parametros("importe", importe),
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddFacturaIndependienteRecibos(string id_factura, string recibo, string id_alumno)
        {
            string nomProce = "addFacturaIndependienteRecibos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_factura", id_factura),
                new Clase_Parametros("recibo", recibo),
                new Clase_Parametros("id_alumno", id_alumno),

            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool BuscaAlumnoDatosFiscales(string ID_Persona)
        {
            string nomProce = "BuscaPersonaDatosFiscales";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DatosFiscales(string id_alumno)
        {
            string nomProce = "ConsultaDatosAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", id_alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FormaPago(string id_alumno, string recibo)
        {
            string nomProce = "ConsultaRecibo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Recibo", recibo),
                new Clase_Parametros("ID_Alumno", id_alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FormaPago_ConcentradoraFormaPago(string id_alumno, string recibo)
        {
            string nomProce = "ConsultaRecibo_ConcentradoraFormaPago";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Recibo", recibo),
                new Clase_Parametros("ID_Alumno", id_alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpDatosFiscales(string id_alumno, string rfc, string curp, string razonsocial, string correo, string Nacionalidad, string rif, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "upDatosFiscalesAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("RFC", rfc),
                new Clase_Parametros("CURP", curp),
                new Clase_Parametros("RazonSocial", razonsocial),
                new Clase_Parametros("correo", correo),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("RIF", rif),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpUsoCFDI(string id_alumno, string recibo, string usoCFDI, string RFC)
        {
            string nomProce = "upUsoCFDI";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("recibo", recibo),
                new Clase_Parametros("usoCFDI", usoCFDI),
                new Clase_Parametros("RFC", RFC)

            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpFormaPago(string forma, string id_alumno, string recibo)
        {
            string nomProce = "upFormaPago";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("formaPago", forma),
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("recibo", recibo)

            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Combo_Regimen_fiscal(string tipo)
        {
            string nomProce = "Combo_RegimenFiscal";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo", tipo)

            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaUsoCFDI(string RFC)
        {
            string nomProce = "consultaUsoCFDI";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("RFC", RFC)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DelFacturaDiferidaMovs(int id_factura)
        {
            string nomProce = "delFacturaDiferidaMovs";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_factura", id_factura.ToString()),

            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddFacturaDiferidaMovs(int id_factura, double cantidad, string id_cargo, string id_alumno)
        {
            string nomProce = "addFacturaDiferidaMovs";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_factura", id_factura.ToString()),
                new Clase_Parametros("cantidad", cantidad.ToString()),
                new Clase_Parametros("id_cargo", id_cargo),
                new Clase_Parametros("id_alumno", id_alumno),

            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddFacturaDiferida(string id_alumno, string usoCFDI)
        {
            string nomProce = "addFacturaDiferida";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("uso_CFDI", usoCFDI),

            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddFacturaIndependiente(string rfc, string usoCFDI, string razonSocial, string correoElectronico, string rif, string formaPago, string paisOrigen, string claveProducto, string tipo_persona, string regimen, string cpfiscal, string noregimentributario, string paisfactura, string emailfactura)
        {
            string nomProce = "addFacturaIndependiente";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("rfc", rfc),
                new Clase_Parametros("usoCFDI", usoCFDI),
                new Clase_Parametros("razonSocial", razonSocial),
                new Clase_Parametros("correoElectronico", correoElectronico),
                new Clase_Parametros("rif", rif),
                new Clase_Parametros("formaPago", formaPago),
                new Clase_Parametros("paisOrigen", paisOrigen),
                new Clase_Parametros("id_campus", Clase_Sesion.Campus),
                new Clase_Parametros("claveProducto", claveProducto),
                new Clase_Parametros("Tipo_persona", tipo_persona),
                new Clase_Parametros("Regimen", regimen),
                new Clase_Parametros("CP_Fiscal", cpfiscal),
                new Clase_Parametros("PaisFactura", paisfactura),
                new Clase_Parametros("emailfactura", emailfactura),
                new Clase_Parametros("Num_Regimen_Tributario", noregimentributario)

            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
    public class Clase_Becas : Clase_Conecta
    {
        #region Propiedades
        public string Alumno { set; get; }
        public string Beca { set; get; }
        public string Periodo { set; get; }
        public string Observaciones { set; get; }
        public bool Activada { set; get; }
        public bool Vacaciones { set; get; }
        #endregion

        #region Constructores
        public Clase_Becas()
        { }
        public Clase_Becas(string alumno, string periodo, string observaciones, bool activada, bool vacaciones)
        {
            Alumno = alumno;
            Periodo = periodo;
            Observaciones = observaciones;
            Activada = activada;
            Vacaciones = vacaciones;
        }
        public Clase_Becas(string alumno, string periodo)
        {
            Alumno = alumno;
            Periodo = periodo;
        }
        #endregion

        #region Métodos
        public bool InsertarBecas(string alumno, string periodo)
        {
            string nomProce = "addBecas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Alumno", alumno),
                new Clase_Parametros("ID_Periodo", periodo),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
            };
            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpBecas(string id_beca, string beca, string observaciones, bool activada, bool vacaciones, bool prorrateo, string tipbeca)
        {
            string nomProce = "upBecas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("Condicion", id_beca),
                new Clase_Parametros("PorcentajeBeca", beca),
                new Clase_Parametros("Observaciones", observaciones),
                new Clase_Parametros("Activada", activada.ToString()),
                new Clase_Parametros("Vacaciones", vacaciones.ToString()),
                new Clase_Parametros("Prorrateo", prorrateo.ToString()),
                new Clase_Parametros("TipoBeca",tipbeca)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GenerarBecas(string ID_Periodo)
        {
            string nomProce = "GenerarBecas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Id_Periodo", ID_Periodo)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GenerarBecas(string ID_Periodo, string ID_Especialidad)
        {
            string nomProce = "GenerarBecasXEspecialidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Id_Periodo", ID_Periodo),
                new Clase_Parametros("ID_Especialidad", ID_Especialidad)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GeneraBecasAlumno(string ID_Alumno)
        {
            string nomProce = "GenerarBecas_Alumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaBecaAlumnos(string cicloE, string especialidad)
        {
            string nomStore = "ConsAlumnosBeca";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("CicloE", cicloE),
                new Clase_Parametros("Especialidades", especialidad)
            };

            if (ConsultarParametros(nomStore, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaBecaAlumnosEsp(string ciclo, string id_esp)
        {
            string nomStore = "ConsAlumnosBeca";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("CicloE", ciclo),
                new Clase_Parametros("Especialidad", id_esp)
            };
            if (ConsultarParametros(nomStore, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaBecaAlumnos(string ciclo)
        {
            string nomStore = "ConsAlumnosBecaCiclo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("CicloE", ciclo)
            };

            if (ConsultarParametros(nomStore, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
    public class Clase_PorcentajesBeca : Clase_Conecta
    {
        #region Propiedades
        public string Condicion { set; get; }
        public string Beca { set; get; }
        public float Porcentaje { set; get; }
        public string Campus { set; get; }
        #endregion

        #region Cosntructores
        public Clase_PorcentajesBeca() { }
        public Clase_PorcentajesBeca(string condicion, string beca, float porcentaje, string campus)
        {
            Condicion = condicion;
            Beca = beca;
            Porcentaje = porcentaje;
            Campus = campus;
        }
        #endregion

        #region Métodos

        public bool InsertarPorcentajesBeca()
        {
            string nomProce = "addPorcentajesBeca";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("IdBecas", Beca),
                new Clase_Parametros("Porcentaje", Porcentaje.ToString()),
                new Clase_Parametros("ID_Campus", Campus)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizarPorcentajesBeca()
        {
            string nomProce = "upPorcentajesBeca";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("condicion", Condicion.ToString()),
                new Clase_Parametros("Porcentaje", Porcentaje.ToString()),
                new Clase_Parametros("ID_Campus", Campus)
            };


            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
    public class Clase_CorreccionInformacion : Clase_Conecta
    {
        #region Propiedades
        public string ID_Persona { set; get; }
        public string ID_Alumno { set; get; }
        public string ID_Status { set; get; }
        public string ID_Modalidad { set; get; }
        public string ID_Especialidad { set; get; }
        /*******/
        public string Nombre { set; get; }
        public string Paterno { set; get; }
        public string Materno { set; get; }
        public string Calle { set; get; }
        public string Colonia { set; get; }
        public string CP { set; get; }
        public string FechaNacimiento { set; get; }
        public string Nacionalidad { set; get; }
        public string LugarNacimiento { set; get; }
        public string Correo { set; get; }
        public string CorreoPlataforma { set; get; }
        public string Telefono { set; get; }
        public string Celular { set; get; }
        public string Sexo { set; get; }
        public string PeriodoIngreso { set; get; }
        public string Generacion { set; get; }
        public string Semestre { set; get; }
        public string Grupo { set; get; }
        public string Listas { set; get; }
        public string Curp { set; get; }
        public string NombrePapa { set; get; }
        public string CelularPapa { set; get; }
        public string EmailPapa { set; get; }
        public string NombreMama { set; get; }
        public string CelularMama { set; get; }
        public string EmailMama { set; get; }

        #endregion

        #region Constructores
        public Clase_CorreccionInformacion()
        { }
        public Clase_CorreccionInformacion(string id_persona, string id_alumno, string id_modalidad, string id_especialidad, string nombre, string paterno, string materno, string calle, string colonia, string cp,
            string fechanacimiento, string nacionalidad, string lugarnacimiento, string correo, string correoPlataforma, string telefono, string celular, string sexo, string periodoingreso,
            string generacion, string semestre, string grupo, string curp, string nombrePapa, string celularPapa, string emailPapa, string nombreMama, string celularMama, string emailMama)
        {
            ID_Persona = id_persona;
            ID_Alumno = id_alumno;
            ID_Modalidad = id_modalidad;
            ID_Especialidad = id_especialidad;
            Nombre = nombre;
            Paterno = paterno;
            Materno = materno;
            Calle = calle;
            Colonia = colonia;
            CP = cp;
            FechaNacimiento = fechanacimiento;
            Nacionalidad = nacionalidad;
            LugarNacimiento = lugarnacimiento;
            Correo = correo;
            CorreoPlataforma = correoPlataforma;
            Telefono = telefono;
            Celular = celular;
            Sexo = sexo;
            PeriodoIngreso = periodoingreso;
            Generacion = generacion;
            Semestre = semestre;
            Grupo = grupo;
            Curp = curp;
            NombrePapa = nombrePapa;
            CelularPapa = celularPapa;
            EmailPapa = emailPapa;
            NombreMama = nombreMama;
            CelularMama = celularMama;
            EmailMama = emailMama;
        }
        #endregion

        #region Métodos
        public bool ConsultarInformacion(string id_status, string modalidad, string especialidad, string semestre, string gen, string gpo)
        {
            string nomProce = "CorreccionInformacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Status", id_status),
                new Clase_Parametros("Modalidad",modalidad),
                new Clase_Parametros("Especialidad", especialidad),
                new Clase_Parametros("NumSemestre", semestre),
                new Clase_Parametros("Campus", Clase_Sesion.campus),
                new Clase_Parametros("generacion", gen),
                new Clase_Parametros("grupo", gpo)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizarInformacion(string id_persona, string id_alumno)
        {
            string nomProce = "ActualizarInformacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", id_persona),
                new Clase_Parametros("ID_Alumno", id_alumno),
                new Clase_Parametros("Paterno", Paterno),
                new Clase_Parametros("Materno", Materno),
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("CURP", Curp),
                new Clase_Parametros("Sexo", Sexo),
                new Clase_Parametros("Calle", Calle),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("CP", CP),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Nacionalidad", Nacionalidad),
                new Clase_Parametros("LugarNacimiento", LugarNacimiento),
                new Clase_Parametros("Correo", Correo),
                new Clase_Parametros("CorreoPlataforma", CorreoPlataforma),
                new Clase_Parametros("Telefono", Telefono),
                new Clase_Parametros("Celular", Celular),
                new Clase_Parametros("PeriodoIngreso", PeriodoIngreso),
                new Clase_Parametros("Generacion", Generacion),
                new Clase_Parametros("NumSem", Semestre),
                new Clase_Parametros("Grupo", Grupo),
                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("EmailPapa", EmailPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CelularMama", CelularMama),
                new Clase_Parametros("EmailMama", EmailMama)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
    public class Clase_Credenciales : Clase_Conecta
    {
        #region Propiedades
        public int ID_Credencial { set; get; }
        public string ID_Campus { set; get; }
        public string ID_TipoPlan { set; get; }
        public string ID_Especialidad { set; get; }
        public byte[] FotoFrente { set; get; }
        public byte[] FotoReverso { set; get; }
        #endregion

        #region Constructores
        public Clase_Credenciales() { }
        public Clase_Credenciales(int iD_Credencial, string iD_Campus, string iD_TipoPlan, string iD_Especialidad, byte[] fotoFrente, byte[] fotoReverso)
        {
            ID_Credencial = iD_Credencial;
            ID_Campus = iD_Campus;
            ID_TipoPlan = iD_TipoPlan;
            ID_Especialidad = iD_Especialidad;
            FotoFrente = fotoFrente;
            FotoReverso = fotoReverso;
        }
        #endregion

        #region Métodos
        public void Credeciales(int idCredencial, string idCampus, string IdTipoPlan, string idEspecialidad, byte[] fFrente, byte[] fReverso)
        {
            ID_Credencial = idCredencial;
            ID_Campus = idCampus;
            ID_TipoPlan = IdTipoPlan;
            ID_Especialidad = idEspecialidad;
            FotoReverso = fReverso;
            FotoFrente = fFrente;
        }
        public bool ConsultaCredencial()
        {
            return false;
        }
        public bool ConsultaCredencial(string campus, string tipoplan, string especialidad)
        {
            string nomProce = "consultaCredencial";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", campus),
                new Clase_Parametros("TipoPlan", tipoplan),
                new Clase_Parametros("Especialidad", especialidad)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InsertaCredencial()
        {
            string nomProce = "insertaCredencial";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("credencial", ID_Credencial.ToString()),
                new Clase_Parametros("campus", ID_Campus.ToString()),
                new Clase_Parametros("tipoPlan", ID_TipoPlan.ToString()),
                new Clase_Parametros("especialidad", ID_Especialidad.ToString()),
                new Clase_Parametros("frente ", FotoFrente),
                new Clase_Parametros("reverso", FotoReverso)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InsertaCredencial(string credencial, string campus, string tipoplan, string especialidad, byte[] frente, byte[] reverso)
        {
            string nomProce = "insertaCredencial";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("credencial", credencial),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("tipoPlan", tipoplan),
                new Clase_Parametros("especialidad", especialidad),
                new Clase_Parametros("frente ", frente),
                new Clase_Parametros("reverso", reverso)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActulizaCredencial()
        {
            string nomProce = "ActualizaCredencial";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("credencial", ID_Credencial.ToString()),
                new Clase_Parametros("campus", ID_Campus.ToString()),
                new Clase_Parametros("tipoPlan", ID_TipoPlan.ToString()),
                new Clase_Parametros("especialidad", ID_Especialidad.ToString()),
                new Clase_Parametros("frente ", FotoFrente),
                new Clase_Parametros("reverso", FotoReverso)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActulizaCredencial(string credencial, string campus, string tipoplan, string especialidad, byte[] frente, byte[] reverso)
        {
            string nomProce = "ActualizaCredencial";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("credencial", credencial),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("tipoPlan", tipoplan),
                new Clase_Parametros("especialidad", especialidad),
                new Clase_Parametros("frente ", frente),
                new Clase_Parametros("reverso", reverso)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
    public class Clase_DatosFamiliares : Clase_Conecta
    {
        #region Propiedades
        public int Condicion { set; get; }
        public string Persona { set; get; }
        public string Nombrepapa { set; get; }
        public string Apellidospapa { set; get; }
        public string Nombremama { set; get; }
        public string Apellidosmama { set; get; }
        public string Telefonopapa { set; get; }
        public string Telefonomama { set; get; }
        public string Celularpapa { set; get; }
        public string Celularmama { set; get; }
        public string Emailpapa { set; get; }
        public string Emailmama { set; get; }
        public string Observaciones { set; get; }
        #endregion

        #region Constructores
        public Clase_DatosFamiliares() { }
        public Clase_DatosFamiliares(string persona, string nombrepapa, string apellidospapa, string nombremama, string apellidosmama, string telefonopapa, string telefonomama, string celularpapa, string celularmama, string emailpapa, string emailmama, string observaciones, int condicion)
        {
            Condicion = condicion;
            Persona = persona;
            Nombrepapa = nombrepapa;
            Apellidospapa = apellidospapa;
            Nombremama = nombremama;
            Apellidosmama = apellidosmama;
            Telefonopapa = telefonopapa;
            Telefonomama = telefonomama;
            Celularpapa = celularpapa;
            Celularmama = celularmama;
            Emailpapa = emailpapa;
            Emailmama = emailmama;
            Observaciones = observaciones;
        }
        #endregion

        #region Métodos
        public bool InsertarDatosFamiliares()
        {
            string nomProce = "addDatosFamiliares";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("persona", Persona),
                new Clase_Parametros("nombrepapa", Nombrepapa),
                new Clase_Parametros("apellidospapa", Apellidospapa),
                new Clase_Parametros("nombremama", Nombremama),
                new Clase_Parametros("apellidosmama", Apellidosmama),
                new Clase_Parametros("telefonopapa", Telefonopapa),
                new Clase_Parametros("telefonomama", Telefonomama),
                new Clase_Parametros("celularpapa", Celularpapa),
                new Clase_Parametros("celularmama", Celularmama),
                new Clase_Parametros("emailpapa", Emailpapa),
                new Clase_Parametros("emailmama", Emailmama),
                new Clase_Parametros("observaciones", Observaciones)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizarDatosFamiliares()
        {
            string nomProce = "upDatosFamiliares";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("condicion", Condicion.ToString()),
                new Clase_Parametros("persona", Persona),
                new Clase_Parametros("nombrepapa", Nombrepapa),
                new Clase_Parametros("apellidospapa", Apellidospapa),
                new Clase_Parametros("nombremama", Nombremama),
                new Clase_Parametros("apellidosmama", Apellidosmama),
                new Clase_Parametros("telefonopapa", Telefonopapa),
                new Clase_Parametros("telefonomama", Telefonomama),
                new Clase_Parametros("celularpapa", Celularpapa),
                new Clase_Parametros("celularmama", Celularmama),
                new Clase_Parametros("emailpapa", Emailpapa),
                new Clase_Parametros("emailmama", Emailmama),
                new Clase_Parametros("observaciones", Observaciones)
            };


            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool BuscaDatosFamiliares(string ID_Persona)
        {
            string nomProce = "BuscaDatosFamiliares";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool InsertarDatosContacto(string ID_Alumno, string nombre, string paterno, string materno, string parenesco, string email, string telefono, string celular)
        {
            string nomProce = "addContactoAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("nombre", nombre),
                new Clase_Parametros("paterno", paterno),
                new Clase_Parametros("materno", materno),
                new Clase_Parametros("parentesco", parenesco),
                new Clase_Parametros("email", email),
                new Clase_Parametros("telefono", telefono),
                new Clase_Parametros("celular", celular)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BuscaDatosContacto(string ID_Alumno)
        {
            string nomProce = "getContactoAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }






        #endregion
    }
    public class Clase_PersonaDocumentos : Clase_Conecta
    {
        #region Propiedades
        public string ID_Persona { set; get; }
        public string Documento { set; get; }
        public string Fechaentrega { set; get; }
        public string Ruta { set; get; }
        public string Observaciones { set; get; }
        public string FechaPrestamo { set; get; }
        public bool Prestamo { set; get; }
        public string ID_Viatico { set; get; }
        #endregion

        #region Constructores
        public Clase_PersonaDocumentos() { }
        public Clase_PersonaDocumentos(string idpersona, string documento, string fechaentrega, string ruta, string observaciones)
        {
            ID_Persona = idpersona;
            Documento = documento;
            Fechaentrega = fechaentrega;
            Ruta = ruta;
            Observaciones = observaciones;
        }
        public Clase_PersonaDocumentos(string idpersona, string documento, string fechaentrega, string ruta, string observaciones, string id_viatico)
        {
            ID_Persona = idpersona;
            Documento = documento;
            Fechaentrega = fechaentrega;
            Ruta = ruta;
            Observaciones = observaciones;
            ID_Viatico = id_viatico;
        }
        public Clase_PersonaDocumentos(string iD_Persona, string documento, string observaciones, string fechaPrestamo)
        {
            ID_Persona = iD_Persona;
            Documento = documento;
            Observaciones = observaciones;
            FechaPrestamo = fechaPrestamo;
        }
        #endregion

        #region Métodos
        public bool InsertaDocumentos()
        {
            string nomProce = "addPersonaDocumentos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("IdPersona", ID_Persona),
                new Clase_Parametros("Documento", Documento),
                new Clase_Parametros("FechaEntregaDocumento", Fechaentrega),
                new Clase_Parametros("RutaDocumento", Ruta),
                new Clase_Parametros("ObservacionesDocumentos", Observaciones),
                new Clase_Parametros("ID_Viatico", ID_Viatico)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool BorrarDocumentos()
        {

            string nomProce = "BorrarDocumento";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("Documento", Documento)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RegistrarPrestamoDocumento()
        {
            string nomProce = "RegistrarPrestamoDocumento";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("Documento", Documento),
                new Clase_Parametros("Observaciones", Observaciones),
                new Clase_Parametros("FechaPrestamo", FechaPrestamo)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeshabilitarPrestamoDocumento()
        {
            string nomProce = "DeshabilitarPrestamoDocumento";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("Documento", Documento),
                new Clase_Parametros("Observaciones", Observaciones),
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaValidaciones_Documentos(string NomDoc)
        {
            string nomProce = "ConsultaValidaciones_Documentos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Documento", NomDoc)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertaDocumentosExtra(string ID_Alumno)
        {
            string nomProce = "AddDocumentosExtraAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
    public class Clase_Status : Clase_Conecta
    {
        #region Propiedades
        public string Campo_Status { set; get; }
        #endregion

        #region Constructores
        public Clase_Status(string campostatus)
        {
            Campo_Status = campostatus;
        }
        public Clase_Status() { }
        #endregion

        #region Métodos
        public bool InsertarStatus()
        {
            string nomProce = "addStatus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("status", Campo_Status)
            };

            if (Ejecuta(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool ConsultarStatus()
        {
            string nomStore = "consultarStatus";

            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultarStatusListaAlumnos()
        {
            string nomStore = "consultarStatusListaAlumnos";

            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
