using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoLoboSostenido
{
    public class InformacionMatricula : Clase_Conecta
    {
        #region Constructores
        public InformacionMatricula() { }
        #endregion
        #region Métodos
        public bool GetTipoUniv(string ID_Alumno)
        {
            string nomProce = "getEspecialidadVirtual";
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
    public class Clase_Empleados : Clase_Personas
    {
        #region Propiedades
        public string Empleado { set; get; }
        public string Tipo { set; get; }
        public string Fechaingreso { set; get; }
        public string Ctabanco { set; get; }
        public string Region { set; get; }
        public string Persona { set; get; }
        public string Foto { set; get; }
        public string Area { set; get; }
        //-------- se agrega puesto y estado
        public string Puesto { set; get; }
        public bool Estado { set; get; }
        public int CheadoEspecial { set; get; }
        #endregion

        #region Constructores
        public Clase_Empleados()
        {

        }
        public Clase_Empleados(string empleado)
        {
            Empleado = empleado;
        }
        public Clase_Empleados(string empleado, string tipo, string fechaingreso, string ctabanco, string region, string persona, string foto, string area, string puesto, bool estado, string curp, string nombre, string paterno, string materno, string calle, string colonia, string cp, /*string lugarnacimiento,*/ string nacionalidad, string edoCivil, string telefono, string celular, string correo, string rfc, string fechaNacimiento, string sexo, string campus) :
            base(curp, nombre, paterno, materno, calle, colonia, cp, /* lugarnacimiento,*/  nacionalidad, edoCivil, telefono, celular, correo, rfc, fechaNacimiento, sexo, campus)
        {
            Empleado = empleado;
            Tipo = tipo;
            Fechaingreso = fechaingreso;
            Ctabanco = ctabanco;
            Region = region;
            Persona = persona;
            Foto = foto;
            Area = area;
            //se agreha puesto y estado
            Puesto = puesto;
            Estado = estado;
        }
        public Clase_Empleados(string empleado, string tipo, string fechaingreso, string ctabanco, string region, string persona, string foto, string area, string puesto, bool estado, string curp, string nombre, string paterno, string materno, string calle, string colonia, string cp, string lugarnacimiento, string nacionalidad, string edoCivil, string telefono, string celular, string correo, string rfc, string fechaNacimiento, string sexo, string campus)
            : base(curp, nombre, paterno, materno, calle, colonia, cp, lugarnacimiento, nacionalidad, edoCivil, telefono, celular, correo, rfc, fechaNacimiento, sexo, campus)
        {
            Empleado = empleado;
            Tipo = tipo;
            Fechaingreso = fechaingreso;
            Ctabanco = ctabanco;
            Region = region;
            Persona = persona;
            Foto = foto;
            Area = area;
            //se agreha puesto y estado
            Puesto = puesto;
            Estado = estado;
        }
        #endregion

        #region Métodos
        public bool ConsultaDatosEmpleado(string ID_Empleado)
        {
            string nomStore = "ConsultaDatosEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Empleado", ID_Empleado)
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

        public bool ConsultaEmpleadosActivos()
        {
            string nomStore = "getEmpleadosActivos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("id_Campus", Clase_Sesion.Campus)
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
        public bool ConsultaCorreosEmpleadoMasivo()
        {
            string nomStore = "ConsultaCorreoMasivoEmpleados";

            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaCorreosAlumnoMasivo()
        {
            string nomStore = "ConsultaCorreoMasivoAumnos";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus.ToString())
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
        public bool ConsultaCorreosSistemasMasivo()
        {
            string nomStore = "ConsultaCorreoSistemasMasivo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
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
        public bool ConsultaTipoIncapacidad(string id_emp, string FechaDel, string FechaAl)
        {
            string nomStore = "ConsultaTipoIncapacidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Empleado", id_emp),
                new Clase_Parametros("FechaDel", FechaDel),
                new Clase_Parametros("FechaAl", FechaAl)
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

        public bool AddAutorizacionResetPassword(string usuario, string id_empleado)
        {
            string nomProce = "usuarios_addSolicitud";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                new Clase_Parametros("usuario", usuario),
                new Clase_Parametros("Empleado", id_empleado),
                new Clase_Parametros("Tipo", "Restaurar Contraseña"),
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("ID_Rol", ""),

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

        public bool AddAutorizacionCambiarNombre(string usuario, string id_empleado)
        {
            string nomProce = "usuarios_addSolicitud";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                new Clase_Parametros("usuario", usuario),
                new Clase_Parametros("Empleado", id_empleado),
                new Clase_Parametros("Tipo", "Cambiar Nombre"),
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("ID_Rol", ""),

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
        public bool AddAutorizacionNuevoUsuario(string usuario, string id_empleado, string rol)
        {
            string nomProce = "usuarios_addSolicitud";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                new Clase_Parametros("usuario", usuario),
                new Clase_Parametros("Empleado", id_empleado),
                new Clase_Parametros("Tipo", "Nuevo Usuario"),
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("ID_Rol", rol),

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

        public bool UPUUIDAsi(string id_nom, string id_emp, string uuid)
        {
            string nomProce = "upUUIDNominaDocente";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Nomina", id_nom),
                new Clase_Parametros("ID_Empleado", id_emp),
                new Clase_Parametros("UUID", uuid)
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
        public bool UPUUIDFL(string id_emp, string uuid)
        {
            string nomProce = "upUUIDNominaFiniquitoLiquidacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", id_emp),
                new Clase_Parametros("UUID", uuid)
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
        public bool UPUUIDDS(string id_nom, string id_emp, string uuid)
        {
            string nomProce = "upUUIDNominaDS";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Nomina", id_nom),
                new Clase_Parametros("ID_Empleado", id_emp),
                new Clase_Parametros("UUID", uuid)
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
        public bool UPUUID(string id_nom, string id_emp, string uuid)
        {
            string nomProce = "upUUIDNominaADM";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Nomina", id_nom),
                new Clase_Parametros("ID_Empleado", id_emp),
                new Clase_Parametros("UUID", uuid)
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
        public bool UPUUIDFA(string id_nom, string id_emp, string uuid)
        {
            string nomProce = "upUUIDNominaFA";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Nomina", id_nom),
                new Clase_Parametros("ID_Empleado", id_emp),
                new Clase_Parametros("UUID", uuid)
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
        public bool UPUUIDFANomina(string id_nom, string id_emp, string uuid)
        {
            string nomProce = "upUUIDFANomina";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Nomina", id_nom),
                new Clase_Parametros("ID_Empleado", id_emp),
                new Clase_Parametros("UUID", uuid)
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

        public bool InsertarEmpleados()
        {
            string nomProce = "addEmpleados";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("tipo", Tipo),
                new Clase_Parametros("fechaingreso", Fechaingreso.ToString()),
                new Clase_Parametros("ctabanco", Ctabanco),
                new Clase_Parametros("region", Region),
                new Clase_Parametros("persona", Persona),
                new Clase_Parametros("foto", Foto),
                new Clase_Parametros("area", Area),
                new Clase_Parametros("puesto", Puesto),
                new Clase_Parametros("estado", Estado.ToString())
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
        public bool AgregarFechaContratoEmpleado(string ID_Empleado, string FechaIni, string FechaFin)
        {
            string nomStore = "SetFechaContratoEmp";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Empleado", ID_Empleado),
                new Clase_Parametros("FechaInicio", FechaIni),
                new Clase_Parametros("FechaFin", FechaFin)
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
        public bool ConsultaConfiguraciones()
        {
            string nomProce = "ConsultaConfiguraciones";
            //List<Clase_Parametros> par = new List<Clase_Parametros>{};

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InsertaFiniquito(string ID_Empleado, string ID_Campus, string Empleado, string RFC, string CURP, string Tipo, string SalarioBaseCalculo, string FechaIngreso, string FechaEgreso,
             string Aguinaldo, string PrimaAntiguedad, string Indemnizacion, string PrimaVacacional,
             string Vacaciones, string FondoAhorroPatron, string FondoAhorroTrabajador, string DiasPendientesPago, string Comisiones,
             string NetoPagarPorFiniquito, string TotalPercepciones, string FondoAhorroExento, string PercepcionGrabada, string ISR, string CuotaObrero,
             string CreditoInfonavit, string Prestamos, string TotalDescuentos, string ImporteNeto, string FechaPago, string UUID, string Cuenta_Prima_Antiguedad,
             string Cuenta_Indenmizacion, string UltimoSueldo, string SalarioDevengado, string TotalExento, string AguinaldoExento, string PrimaVExenta, string RetiroExento, string ImpuestoIndemnizacion, string timbrar, string OtrosDescuentos, string Subsidio, string InfonavitFavor, string VacacionesExenta, string FONACOT)
        {
            string nomProce = "addFiniquito";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Empleado", ID_Empleado),
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("Empleado", Empleado),
                new Clase_Parametros("RFC", RFC),
                new Clase_Parametros("CURP", CURP),
                new Clase_Parametros("Tipo", Tipo),
                new Clase_Parametros("SalarioBaseCalculo", SalarioBaseCalculo),
                new Clase_Parametros("FechaIngreso", FechaIngreso),
                new Clase_Parametros("FechaEgreso", FechaEgreso),
                new Clase_Parametros("Aguinaldo", Aguinaldo),
                new Clase_Parametros("PrimaAntiguedad", PrimaAntiguedad),
                new Clase_Parametros("Indemnizacion", Indemnizacion),
                new Clase_Parametros("PrimaVacacional", PrimaVacacional),
                new Clase_Parametros("Vacaciones", Vacaciones),
                new Clase_Parametros("FondoAhorroPatron", FondoAhorroPatron),
                new Clase_Parametros("FondoAhorroTrabajador", FondoAhorroTrabajador),
                new Clase_Parametros("DiasPendientesPago", DiasPendientesPago),
                new Clase_Parametros("Comisiones", Comisiones),
                new Clase_Parametros("NetoPagarPorFiniquito", NetoPagarPorFiniquito),
                new Clase_Parametros("TotalPercepciones", TotalPercepciones),
                new Clase_Parametros("FondoAhorroExento", FondoAhorroExento),
                new Clase_Parametros("PercepcionGrabada", PercepcionGrabada),
                new Clase_Parametros("ISR", ISR),
                new Clase_Parametros("CuotaObrero", CuotaObrero),
                new Clase_Parametros("CreditoInfonavit", CreditoInfonavit),
                new Clase_Parametros("Prestamos", Prestamos),
                new Clase_Parametros("TotalDescuentos", TotalDescuentos),
                new Clase_Parametros("ImporteNeto", ImporteNeto),
                new Clase_Parametros("FechaPago", FechaPago),
                new Clase_Parametros("UUID", UUID),
                new Clase_Parametros("Cuenta_Prima_Antiguedad", Cuenta_Prima_Antiguedad),
                new Clase_Parametros("Cuenta_Indenmizacion", Cuenta_Indenmizacion),
                new Clase_Parametros("UltimoSueldo", UltimoSueldo),
                new Clase_Parametros("SalarioDevengado", SalarioDevengado),
                new Clase_Parametros("TotalExento", TotalExento),
                new Clase_Parametros("AguinaldoExento", AguinaldoExento),
                new Clase_Parametros("PrimaVExenta", PrimaVExenta),
                new Clase_Parametros("RetiroExento", RetiroExento),
                new Clase_Parametros("ImpuestoIndemnizacion", ImpuestoIndemnizacion),
                new Clase_Parametros("timbrar", timbrar),
                new Clase_Parametros("OtrosDescuentos", OtrosDescuentos),
                new Clase_Parametros("Subsidio", Subsidio),
                new Clase_Parametros("InfonavitFavor", InfonavitFavor),
                new Clase_Parametros("VacacionesExenta", VacacionesExenta),
                new Clase_Parametros("FONACOT", FONACOT)
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

        public bool ListoTimbrar(string ID_Empleado, string ID_Campus, string listo)
        {
            string nomProce = "listoTimbrar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_empleado", ID_Empleado),
                new Clase_Parametros("id_campus", ID_Campus),
                new Clase_Parametros("listo", listo)

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
        public bool UpdateFiniquito(string ID_Empleado, string ID_Campus, string Empleado, string RFC, string CURP, string Tipo, string SalarioBaseCalculo,
            string FechaIngreso, string FechaEgreso, string Aguinaldo, string PrimaAntiguedad, string Indemnizacion, string PrimaVacacional,
            string Vacaciones, string FondoAhorroPatron, string FondoAhorroTrabajador, string DiasPendientesPago, string Comisiones,
            string NetoPagarPorFiniquito, string TotalPercepciones, string FondoAhorroExento, string PercepcionGrabada, string ISR, string CuotaObrero,
            string CreditoInfonavit, string Prestamos, string TotalDescuentos, string ImporteNeto, string FechaPago, string UUID, string Cuenta_Prima_Antiguedad,
            string Cuenta_Indenmizacion, string UltimoSueldo, string SalarioDevengado, string TotalExento, string AguinaldoExento, string PrimaVExenta,
            string RetiroExento, string ImpuestoIndemnizacion, string timbrar, string OtrosDescuentos, string Subsidio, string InfonavitFavor, string VacacionesExenta, string FONACOT)
        {
            string nomProce = "upFiniquito";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Empleado", ID_Empleado),
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("Empleado", Empleado),
                new Clase_Parametros("RFC", RFC),
                new Clase_Parametros("CURP", CURP),
                new Clase_Parametros("Tipo", Tipo),
                new Clase_Parametros("SalarioBaseCalculo", SalarioBaseCalculo),
                new Clase_Parametros("FechaIngreso", FechaIngreso),
                new Clase_Parametros("FechaEgreso", FechaEgreso),
                new Clase_Parametros("Aguinaldo", Aguinaldo),
                new Clase_Parametros("PrimaAntiguedad", PrimaAntiguedad),
                new Clase_Parametros("Indemnizacion", Indemnizacion),
                new Clase_Parametros("PrimaVacacional", PrimaVacacional),
                new Clase_Parametros("Vacaciones", Vacaciones),
                new Clase_Parametros("FondoAhorroPatron", FondoAhorroPatron),
                new Clase_Parametros("FondoAhorroTrabajador", FondoAhorroTrabajador),
                new Clase_Parametros("DiasPendientesPago", DiasPendientesPago),
                new Clase_Parametros("Comisiones", Comisiones),
                new Clase_Parametros("NetoPagarPorFiniquito", NetoPagarPorFiniquito),
                new Clase_Parametros("TotalPercepciones", TotalPercepciones),
                new Clase_Parametros("FondoAhorroExento", FondoAhorroExento),
                new Clase_Parametros("PercepcionGrabada", PercepcionGrabada),
                new Clase_Parametros("ISR", ISR),
                new Clase_Parametros("CuotaObrero", CuotaObrero),
                new Clase_Parametros("CreditoInfonavit", CreditoInfonavit),
                new Clase_Parametros("Prestamos", Prestamos),
                new Clase_Parametros("TotalDescuentos", TotalDescuentos),
                new Clase_Parametros("ImporteNeto", ImporteNeto),
                new Clase_Parametros("FechaPago", FechaPago),
                new Clase_Parametros("UUID", UUID),
                new Clase_Parametros("Cuenta_Prima_Antiguedad", Cuenta_Prima_Antiguedad),
                new Clase_Parametros("Cuenta_Indenmizacion", Cuenta_Indenmizacion),
                new Clase_Parametros("UltimoSueldo", UltimoSueldo),
                new Clase_Parametros("SalarioDevengado", SalarioDevengado),
                new Clase_Parametros("TotalExento", TotalExento),
                new Clase_Parametros("AguinaldoExento", AguinaldoExento),
                new Clase_Parametros("PrimaVExenta", PrimaVExenta),
                new Clase_Parametros("RetiroExento", RetiroExento),
                new Clase_Parametros("ImpuestoIndemnizacion", ImpuestoIndemnizacion),
                new Clase_Parametros("timbrar", timbrar),
                new Clase_Parametros("OtrosDescuentos", OtrosDescuentos),
                new Clase_Parametros("Subsidio", Subsidio),
                new Clase_Parametros("InfonavitFavor", InfonavitFavor),
                new Clase_Parametros("VacacionesExenta", VacacionesExenta),
                new Clase_Parametros("FONACOT", FONACOT)
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

        public bool ActualizaEmleadosTipo(string id, string tip)
        {
            string nomProce = "upEmpleados";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("idEmp", id),
                new Clase_Parametros("tipo", tip)
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
        public bool ConsultaNRP()
        {
            string nomProce = "ConsultaNRP";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EmpleadosCuentasContables(string id_emp, string cuenta, string descripcion)
        {
            string nomProce = "AddEmpleadoCuentaContable";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", id_emp),
                new Clase_Parametros("Cuenta", cuenta),
                new Clase_Parametros("Descripcion", descripcion)
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
        public bool ConsultEmpleado()
        {
            string nomProce = "consultEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id", Empleado)
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
        public bool ActualizaEmpleados(string id, string tip, string fi, string ct, string reg,
            string per, byte[] fot, string are, string pues, bool esta, string camp,
            string tit, string empleadobancario, string tipobanco)
        {
            string nomProce = "upEmpleados1";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("idEmp", id),
                new Clase_Parametros("tipo", tip),
                new Clase_Parametros("fechaingreso", fi),
                new Clase_Parametros("ctabanco", ct),
                new Clase_Parametros("region", reg),
                new Clase_Parametros("persona", per),
                new Clase_Parametros("foto", fot),
                new Clase_Parametros("area", are),
                new Clase_Parametros("puesto", pues),
                new Clase_Parametros("estado", esta.ToString()),
                new Clase_Parametros("campus", camp),
                new Clase_Parametros("titulo", tit),
                new Clase_Parametros("empleadobancario", empleadobancario),
                new Clase_Parametros("tipobancario", tipobanco)
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

        /*COMAEM*/
        public bool ActualizaEmpleados2(string id, string tip, string fi, string ct, string reg,
            string per, byte[] fot, string are, string pues, bool esta, string camp,
            string tit, string empleadobancario, string tipobanco, string instruccionProf, string cedula)
        {
            string nomProce = "upEmpleados1";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("idEmp", id),
                new Clase_Parametros("tipo", tip),
                new Clase_Parametros("fechaingreso", fi),
                new Clase_Parametros("ctabanco", ct),
                new Clase_Parametros("region", reg),
                new Clase_Parametros("persona", per),
                new Clase_Parametros("foto", fot),
                new Clase_Parametros("area", are),
                new Clase_Parametros("puesto", pues),
                new Clase_Parametros("estado", esta.ToString()),
                new Clase_Parametros("campus", camp),
                new Clase_Parametros("titulo", tit),
                new Clase_Parametros("empleadobancario", empleadobancario),
                new Clase_Parametros("tipobancario", tipobanco),
                new Clase_Parametros("InstruccionProfesional", instruccionProf),
                new Clase_Parametros("Cedula", cedula)

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

        public bool ConsultaCmdEmple(string valor, int estado, string tipo, string Campus)
        {
            string nomStore = "fndcmdEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("nombre", valor),
                new Clase_Parametros("tipo", tipo),
                new Clase_Parametros("estado", estado.ToString()),
                new Clase_Parametros("campus", Campus.ToString()),
                //new Clase_Parametros("rol", Campus.ToString()),
                //new Clase_Parametros("idUsuario", Campus.ToString())
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
        public bool ConsultatipoEmpleado(string tip, string campu)
        {
            string nomStore = "tipoEmpleado";
            string valor = tip;
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("tipo", valor),
                new Clase_Parametros("cam", campu)
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
        public bool ConsultImage(string id)
        {
            string nomStore = "consultImage";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("idEmp", id)
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
        public bool ConsultaDatosContables(string id)
        {
            string nomStore = "ConsultaDatosContablesXEmpleado";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Empleado", id)
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
        public bool ConsultaCuentasContables(string id, string descripcion)
        {
            string nomStore = "ConsultaCuentasContablesEmpleado";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Empleado", id),
                new Clase_Parametros("Descripcion", descripcion)
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
        public bool ConsultaComision(string id)
        {
            string nomStore = "ConsultaComision";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Empleado", id)
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
        public bool AddComision(string id, string descripcion, string monto, string fecha, string horasDocentes = "Comision")
        {
            string nomStore = "addComision";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", id),
                new Clase_Parametros("Descripcion", descripcion),
                new Clase_Parametros("Monto", monto),
                //new Clase_Parametros("Fecha", fecha),
                new Clase_Parametros("ID_Nomina", fecha),
                new Clase_Parametros("tipo", horasDocentes)
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
        public bool SimuladorComision(string id, string ID_Campus, string monto, string id_nomina, string tipo)
        {
            string nomStore = "simuladorComisiones";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", id),
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("cantidadSimulador", monto),
                new Clase_Parametros("ID_Nomina", id_nomina),
                new Clase_Parametros("tipoSimulador", tipo)
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
        public bool ActualizaEmleadosBiblioteca(string id, string pers, byte[] foto)
        {
            string nomProce = "upEmpleadoFoto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Empleado", id),
                new Clase_Parametros("id_persona", pers),
                new Clase_Parametros("ID_Fotografia", foto),

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
        public bool ConsultaEncargadosCampus()
        {
            string nomStore = "ConsultaEncargadosCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Clase_Sesion.campus)
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


        public bool getCiclosDocentes_Virtual(string id_Empleado)
        {
            string nomStore = "getCiclosDocentes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", id_Empleado)

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

        public bool getCiclosDocentesContratos_Virtual(string id_Empleado, string id_periodo)
        {
            string nomStore = "getCiclosDocentesContratos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", id_Empleado),
                new Clase_Parametros("ID_Periodo", id_periodo)
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

        public bool getCiclosDocentesContratosD_Virtual(string id_Empleado, string fechas)
        {
            string nomStore = "getCiclosDocentesContratosDetalle";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", id_Empleado),
                new Clase_Parametros("fechas", fechas)
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

        public bool LlenarDTFaltas()
        {
            string nomStore = "ConsultaEmpleados3FaltasMes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_Campus", Clase_Sesion.campus)
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
        /*COMAEM*/
        public bool ConsultaAsimiladoCOMAEM(string ID_Empleado)
        {
            string nomStore = "ConsultaAsimiladoCOMAEM";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", ID_Empleado)
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

        /* Fallas exraordinarias campus*/
        public bool ReportesIncidenciasCampusChecadores(string ID_Campus)
        {
            string nomStore = "ReportesIncidenciasCampusChecadores";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", ID_Campus)
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

        public bool ReportesIncidenciasCampusChecadores_Sesion(string Sesion)
        {
            string nomStore = "ReportesIncidenciasCampusChecadores_Sesion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Checador", Sesion)
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

        public bool ReportesIncidenciasCampusTipoFalla()
        {
            string nomStore = "ReportesIncidenciasCampusTipoFalla";
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ReportesIncidenciasCampusInsertar(string id_campus, string tipofalla, string iD_Checador, string iD_Empleado, string fechaIni, string fechaFin, string horaIni, string horaFin, string obs, string noReporte)
        {
            string nomStore = "ReportesIncidenciasCampusInsertarIncidencia";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", id_campus),
                new Clase_Parametros("TipoFalla", tipofalla),
                new Clase_Parametros("ID_Checador", iD_Checador),
                new Clase_Parametros("ID_Empleado", iD_Empleado),
                new Clase_Parametros("FechaIni", fechaIni),
                new Clase_Parametros("FechaFin", fechaFin),
                new Clase_Parametros("HoraIni", horaIni),
                new Clase_Parametros("HoraFin", horaFin),
                new Clase_Parametros("Obs", obs),
                new Clase_Parametros("NoReporte", noReporte)
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

        public bool HabilitarFRMSoporteVirtual()
        {
            string nomStore = "SetPantallasLoboONE";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_empleado", Clase_Sesion.IDEmpleado)
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
        public bool GetChecadoEspecial_Empleado()
        {
            string nomStore = "GetChecadoEspecial_Empleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", Empleado),//Empleado que se busca,
                new Clase_Parametros("ID_EmpleadoPersonal", Clase_Sesion.IDEmpleado), //Personal Administrativo que realiza la búsqueda
                new Clase_Parametros("Usuario", Clase_Sesion.Usuario) //UsuarioLobOone
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

        public bool UpdateChecadoEspecial()
        {
            string nomStore = "UpdateChecadoEspecial";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", Empleado),
                new Clase_Parametros("ChecadoEspecial", CheadoEspecial.ToString())
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
    public class Clase_Prospectos : Clase_Personas
    {
        #region Propiedades
        public string IdProspecto { set; get; }
        public string EscuelaProcedencia { set; get; }
        public string Periodo { set; get; }
        public string FechaRegistro { set; get; }
        public string Especialidad { set; get; }
        public string Tipoplan { set; get; }
        public string Motivo { set; get; }
        public bool Revalidacion { set; get; }
        public string Persona { set; get; }
        public string Estatusprospecto { set; get; }
        public string ID_Empleado { set; get; }
        public string Observaciones { set; get; }
        public bool Convenio { set; get; }
        public string ID_Convenio { set; get; }
        public string ID_Status_Seguimiento { set; get; }
        #endregion

        #region Constructores
        public Clase_Prospectos(string curp, string nombre, string paterno, string materno, string calle, string colonia, string cp, string lugarnacimiento, string nacionalidad, string edoCivil, string telefono, string celular, string correo, string rfc, string fechaNacimiento, string sexo, string idCampus,
              string idProspecto, string tipoPlan, string idEspecialidad, string estatusProspecto, string statusSeguimiento, string periodo, string idEscuelaProcedencia, bool convenio, string idConvenio, bool revalidacion, string observaciones, string motivo, string fechaRegistro, string idEmpleado)
            : base(curp, nombre, paterno, materno, calle, colonia, cp, lugarnacimiento, nacionalidad, edoCivil, telefono, celular, correo, rfc, fechaNacimiento, sexo, idCampus)
        {
            IdProspecto = idProspecto;
            Tipoplan = tipoPlan;
            Especialidad = idEspecialidad;
            Estatusprospecto = estatusProspecto;
            ID_Status_Seguimiento = statusSeguimiento;
            Periodo = periodo;
            EscuelaProcedencia = idEscuelaProcedencia;
            Convenio = convenio;
            ID_Convenio = idConvenio;
            Revalidacion = revalidacion;
            Observaciones = observaciones;
            Motivo = motivo;
            FechaRegistro = fechaRegistro;
            ID_Empleado = idEmpleado;
        }


        public Clase_Prospectos()
        {
        }
        #endregion

        #region Métodos
        public bool ConsultaCampusXModalidad(string campus, string modalidad)
        {
            string nomStore = "FrmCampusMercaXModalidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ID_Mod", modalidad)
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
        public bool ConsultaCmdProspecto(string valor, int estado, string tipo, string campus)
        {
            string nomStore = "fndcmdProspecto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("nombre", valor),
                new Clase_Parametros("estado", estado.ToString()),
                new Clase_Parametros("tipo", tipo),
                new Clase_Parametros("campus", campus)
            };
            if (Clase_Sesion.Rol == "18" || Clase_Sesion.Rol == "14")
            {
                par.Add(new Clase_Parametros("Gral", "1"));
            }
            else
            {
                par.Add(new Clase_Parametros("Gral", "0"));
            }

            if (ConsultarParametros(nomStore, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool BuscaDatosProspecto(string ID_Persona, string ID_Prospecto)//BuscaDatosProspecto
        {
            string nomProce = "BuscaDatosProspecto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("ID_Prospecto", ID_Prospecto)
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
        public bool InsertarProspectos(string ID_Persona, string nombrePapa, string telPapa, string celPapa, string correoPapa, string nombreMama, string telMama, string celMama, string correoMama, string RazonSocial, string DomicilioFiscal, string Ciudad)
        {
            string nomProce = "AddNuevoProspecto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Persona", ID_Persona),
                new Clase_Parametros("CURP", Curp.ToString()),
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
                //Datos de Prospectos
                new Clase_Parametros("ID_Prospecto", IdProspecto),
                new Clase_Parametros("ID_Tipo_Plan", Tipoplan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("ID_Status_Prospecto", Estatusprospecto),
                new Clase_Parametros("ID_Status_Seguimiento", ID_Status_Seguimiento),
                new Clase_Parametros("ID_Periodo_Ingreso", Periodo),
                new Clase_Parametros("ID_Escuela_Procedencia", EscuelaProcedencia),
                new Clase_Parametros("Convenio", Convenio.ToString()),
                new Clase_Parametros("ID_Convenio", ID_Convenio),
                new Clase_Parametros("Revalidacion", Revalidacion.ToString()),
                new Clase_Parametros("Observaciones", Observaciones),
                new Clase_Parametros("Comentarios", Motivo),
                new Clase_Parametros("Fecha_Registro", FechaRegistro),
                new Clase_Parametros("ID_Empleado", ID_Empleado),
                //Datos Familiares
                new Clase_Parametros("NombrePapa", nombrePapa),
                new Clase_Parametros("CorreoPapa", correoPapa),
                new Clase_Parametros("TelefonoPapa", telPapa),
                new Clase_Parametros("CelularPapa", celPapa),
                new Clase_Parametros("NombreMama", nombreMama),
                new Clase_Parametros("CorreoMama", correoMama),
                new Clase_Parametros("TelefonoMama", telMama),
                new Clase_Parametros("CelularMama", celMama),
                //DatosFiscales
                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal),
                new Clase_Parametros("Ciudad", Ciudad)
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
        public bool ActualizarProspectos(string ID_Persona, string RazonSocial, string DomicilioFiscal, string Ciudad, string NombrePapa, string TelefonoPapa, string CelularPapa, string EmailPapa, string NombreMama, string TelefonoMama, string CelularMama, string EmailMama)
        {
            string nomProce = "upProspectos";
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
                new Clase_Parametros("RFC", Rfc),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento),
                new Clase_Parametros("Sexo", Sexo),

                new Clase_Parametros("ID_Prospecto", IdProspecto),
                new Clase_Parametros("ID_Tipo_Plan", Tipoplan),
                new Clase_Parametros("ID_Especialidad", Especialidad),
                new Clase_Parametros("ID_Periodo_Ingreso", Periodo),
                new Clase_Parametros("ID_Escuela_Procedencia", EscuelaProcedencia),
                new Clase_Parametros("Convenio", Convenio.ToString()),
                new Clase_Parametros("ID_Convenio", ID_Convenio),
                new Clase_Parametros("Revalidacion", Revalidacion.ToString()),
                new Clase_Parametros("Observaciones", Observaciones),
                new Clase_Parametros("Comentarios", Motivo),

                new Clase_Parametros("NombrePapa", NombrePapa),
                new Clase_Parametros("CorreoPapa", EmailPapa),
                new Clase_Parametros("TelefonoPapa", TelefonoPapa),
                new Clase_Parametros("CelularPapa", CelularPapa),
                new Clase_Parametros("NombreMama", NombreMama),
                new Clase_Parametros("CorreoMama", EmailMama),
                new Clase_Parametros("TelefonoMama", TelefonoMama),
                new Clase_Parametros("CelularMama", CelularMama),

                new Clase_Parametros("RazonSocial", RazonSocial),
                new Clase_Parametros("Ciudad", Ciudad),
                new Clase_Parametros("DomicilioFiscal", DomicilioFiscal)
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
        public bool Load_StatusProspecto(int Estado)
        {
            string nomStore = "CargarStatusProspecto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Estado", Estado.ToString())
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
        public bool Load_StatusSeguimiento(int Estado)
        {
            string nomStore = "CargarStatusSeguimiento";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Estado", Estado.ToString())
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
        public bool Load_TipoContacto(int Estado)
        {
            string nomStore = "CargarTipoContactoProspecto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("State", Estado.ToString())
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
        public bool ComboProspectos(string ID_Campus, int Value)
        {
            string nomStore = "ComboProspectos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("Value", Value.ToString())
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
        public bool ComboPromotores(string ID_Campus, int Value)
        {
            string nomStore = "ComboPromotores";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("Value", Value.ToString())
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
        /*public bool ListaDeProspectos(string ID_Promotor, string ID_Modalidad, string ID_Especialidad, int ID_Status_Prospecto, int ID_Status_Seguimiento, int ID_Contacto, string FechaI, string FechaT, string FechaNacimiento, string Hombre, string Mujer)
        {
            string nomProce = "ListaSeguimientoPromotores"; 
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Promotor", ID_Promotor),
                new Clase_Parametros("ID_Modalidad", ID_Modalidad),
                new Clase_Parametros("ID_Especialidad", ID_Especialidad),
                new Clase_Parametros("ID_Status_Prospecto", ID_Status_Prospecto.ToString()),
                new Clase_Parametros("ID_Status_Seguimiento", ID_Status_Seguimiento.ToString()),
                new Clase_Parametros("ID_Contacto", ID_Contacto.ToString()),
                new Clase_Parametros("FechaI", FechaI),
                new Clase_Parametros("FechaT", FechaT),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento.ToString()),
                new Clase_Parametros("Hombre", Hombre.ToString()),
                new Clase_Parametros("Mujer", Mujer.ToString())
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }*/
        /*public bool ListaDeProspectosCampus(string campus, string ID_Promotor, string ID_Modalidad, string ID_Especialidad, int ID_Status_Prospecto, int ID_Status_Seguimiento, int ID_Contacto, string FechaI, string FechaT, string FechaNacimiento, string Hombre, string Mujer, string cescolar)
        {
            string nomProce = "ListaSeguimientoPromotoresCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("ID_Promotor", ID_Promotor),
                new Clase_Parametros("ID_Modalidad", ID_Modalidad),
                new Clase_Parametros("ID_Especialidad", ID_Especialidad),
                new Clase_Parametros("ID_Status_Prospecto", ID_Status_Prospecto.ToString()),
                new Clase_Parametros("ID_Status_Seguimiento", ID_Status_Seguimiento.ToString()),
                new Clase_Parametros("ID_Contacto", ID_Contacto.ToString()),
                new Clase_Parametros("FechaI", FechaI),
                new Clase_Parametros("FechaT", FechaT),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento.ToString()),
                new Clase_Parametros("Hombre", Hombre.ToString()),
                new Clase_Parametros("Mujer", Mujer.ToString()),
                new Clase_Parametros("ID_Periodo", cescolar.ToString())
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }*/
        public bool FrmListaDeProspectosCampus(string campus, string ID_Promotor, string ID_Modalidad, string ID_Especialidad, int ID_Status_Prospecto, int ID_Status_Seguimiento, int ID_Contacto, string FechaI, string FechaT, string FechaNacimiento, string Hombre, string Mujer, string cescolar)
        {
            string nomProce = "FrmListaSeguimientoPromotoresXCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("ID_Promotor", ID_Promotor),
                new Clase_Parametros("ID_Modalidad", ID_Modalidad),
                new Clase_Parametros("ID_Especialidad", ID_Especialidad),
                new Clase_Parametros("ID_Status_Prospecto", ID_Status_Prospecto.ToString()),
                new Clase_Parametros("ID_Status_Seguimiento", ID_Status_Seguimiento.ToString()),
                new Clase_Parametros("ID_Contacto", ID_Contacto.ToString()),
                new Clase_Parametros("FechaI", FechaI),
                new Clase_Parametros("FechaT", FechaT),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento.ToString()),
                new Clase_Parametros("Hombre", Hombre.ToString()),/*1 = hombre ok; 0 = hombre no*/
                new Clase_Parametros("Mujer", Mujer.ToString()),/*1 = muejr ok; 0 = mujer no*/
                new Clase_Parametros("ID_Periodo", cescolar.ToString())/*1 = muejr ok; 0 = mujer no*/
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
        /*public bool ListaDeProspectosCampusEmail(string campus, string ID_Promotor, string ID_Modalidad, string ID_Especialidad, int ID_Status_Prospecto, int ID_Status_Seguimiento, int ID_Contacto, string FechaI, string FechaT, string FechaNacimiento, string Hombre, string Mujer, string cescolar = "")
        {
            string nomProce = "ListaSeguimientoPromotoresCampusEmail";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("ID_Promotor", ID_Promotor),
                new Clase_Parametros("ID_Modalidad", ID_Modalidad),
                new Clase_Parametros("ID_Especialidad", ID_Especialidad),
                new Clase_Parametros("ID_Status_Prospecto", ID_Status_Prospecto.ToString()),
                new Clase_Parametros("ID_Status_Seguimiento", ID_Status_Seguimiento.ToString()),
                new Clase_Parametros("ID_Contacto", ID_Contacto.ToString()),
                new Clase_Parametros("FechaI", FechaI),
                new Clase_Parametros("FechaT", FechaT),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento.ToString()),
                new Clase_Parametros("Hombre", Hombre.ToString()),
                new Clase_Parametros("Mujer", Mujer.ToString()),
                new Clase_Parametros("ID_Periodo", cescolar == null ? "" : cescolar.ToString())
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }*/
        public bool ListaDeProspectosCampusEmail(string campus, string ID_Promotor, string ID_Modalidad, string ID_Especialidad, int ID_Status_Prospecto, int ID_Status_Seguimiento, int ID_Contacto, string FechaI, string FechaT, string FechaNacimiento, string Hombre, string Mujer, string cescolar = "")
        {
            string nomProce = "FrmListaSeguimientoPromotoresCampusEmailXCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("ID_Promotor", ID_Promotor),
                new Clase_Parametros("ID_Modalidad", ID_Modalidad),
                new Clase_Parametros("ID_Especialidad", ID_Especialidad),
                new Clase_Parametros("ID_Status_Prospecto", ID_Status_Prospecto.ToString()),
                new Clase_Parametros("ID_Status_Seguimiento", ID_Status_Seguimiento.ToString()),
                new Clase_Parametros("ID_Contacto", ID_Contacto.ToString()),
                new Clase_Parametros("FechaI", FechaI),
                new Clase_Parametros("FechaT", FechaT),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento.ToString()),
                new Clase_Parametros("Hombre", Hombre.ToString()),/*1 = hombre ok; 0 = hombre no*/
                new Clase_Parametros("Mujer", Mujer.ToString()),/*1 = muejr ok; 0 = mujer no*/
                new Clase_Parametros("ID_Periodo", cescolar == null ? "" : cescolar.ToString())/*1 = muejr ok; 0 = mujer no*/
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
        //PRUEBAS 
        public bool ListaDeProspectosCampusEmail13(string ID_Promotor, string ID_Modalidad, string ID_Especialidad, int ID_Status_Prospecto, int ID_Status_Seguimiento, int ID_Contacto, string FechaI, string FechaT, string FechaNacimiento, string Hombre, string Mujer)
        {
            string nomProce = "ListaSeguimientoPromotoresEmail_13";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //new Clase_Parametros("campus", campus),
                new Clase_Parametros("ID_Promotor", ID_Promotor),
                new Clase_Parametros("ID_Modalidad", ID_Modalidad),
                new Clase_Parametros("ID_Especialidad", ID_Especialidad),
                new Clase_Parametros("ID_Status_Prospecto", ID_Status_Prospecto.ToString()),
                new Clase_Parametros("ID_Status_Seguimiento", ID_Status_Seguimiento.ToString()),
                new Clase_Parametros("ID_Contacto", ID_Contacto.ToString()),
                new Clase_Parametros("FechaI", FechaI),
                new Clase_Parametros("FechaT", FechaT),
                new Clase_Parametros("FechaNacimiento", FechaNacimiento.ToString()),
                new Clase_Parametros("Hombre", Hombre.ToString()),/*1 = hombre ok; 0 = hombre no*/
                new Clase_Parametros("Mujer", Mujer.ToString())/*1 = muejr ok; 0 = mujer no*/
                //new Clase_Parametros("ID_Periodo", cescolar == null ? "" : cescolar.ToString())/*1 = muejr ok; 0 = mujer no*/
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
        public bool NumeroProspectosLista(string Empleado, string Periodo)
        {
            string nomProce = "FrmNumeroProspectosPorPromotor";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Empleado", Empleado),
                new Clase_Parametros("Periodo", Periodo)
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
        public bool NumeroProspectosListaXCampus(string Campus, string Periodo)
        {
            string nomProce = "FrmNumeroProspectosPorCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("Periodo", Periodo)
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
        /*public bool NumeroProspectosLista(string ID_Promotor, string FechaI, string FechaT)
        {
            string nomProce = "NumeroProspectosPorPromotor";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Promotor", ID_Promotor),
                new Clase_Parametros("FechaI", FechaI),
                new Clase_Parametros("FechaT", FechaT)
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }*/
        /*public bool NumeroProspectosLista(string id_campus, string ID_Promotor, string FechaI, string FechaT)
        {
            string nomProce = "NumeroProspectosPorCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", id_campus),
                new Clase_Parametros("ID_Promotor", ID_Promotor),
                new Clase_Parametros("FechaI", FechaI),
                new Clase_Parametros("FechaT", FechaT)
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }*/
        public bool CampusPromotores()
        {
            string nomProce = "get_Campus_Promotores";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
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
        public bool ConsultaTipoPlanPromotores(string ID_Campus)
        {
            string nomProce = "ConsultaTipoPlanPromotores";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", ID_Campus)
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

        public bool Load_StatusSeguimiento_Prospecto(string ID_Prospecto)
        {
            string nomProce = "Load_StatusSeguimiento_Prospecto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Prospecto", ID_Prospecto)
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }
        #endregion
    }
    public static class Clase_ConvertImage
    {
        #region Métodos
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }
        public static byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        #endregion
    }
}
