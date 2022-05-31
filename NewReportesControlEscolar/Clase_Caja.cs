using System;
using System.Collections.Generic;

namespace ProyectoLoboSostenido
{
    public class Clase_Caja : Clase_Conecta
    {
        #region Constructores
        public Clase_Caja() { }

        #endregion
        #region Métodos

        public bool ConsultaCargoConceptoporID(string id_cargo)
        {
            string nomProce = "ConsultaCargoConceptoporID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Cargo", id_cargo)
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


        public bool ComboTipoConceptoGeneral()
        {
            string nomProce = "comboTipoConceptoGeneral";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Consultaboton()
        {
            string nomProce = "consultaboton";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaBancos()
        {
            string nomProce = "ConsultaBancos";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaCicloAlumno(string ID_Alumno)
        {
            string nomProce = "ConsultaCicloActivoxAlumno";
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

        public bool ConsultaRecibosSinBanco(string fecha1, string fecha2, string id_campus)
        {
            string nomProce = "ingresos_RecibosSinBanco";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("@fechainicio", fecha1),
                 new Clase_Parametros("@fechafin", fecha2),
                 new Clase_Parametros("@id_campus", id_campus)
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

        public bool SaveRecibosSinBanco(string recibo, string banco, string id_campus, string fechaDeposito)
        {
            string nomProce = "ingresos_SaveBancoRecibo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("@id_banco", banco),
                 new Clase_Parametros("@recibo", recibo),
                 new Clase_Parametros("@id_campus", id_campus),
                 new Clase_Parametros("@fechaDeposito", fechaDeposito)
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

        public bool GetUltimoTurno()
        {
            string nomProce = "getTurnoCaja";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetTurno(int tipo)
        {
            string nomProce = "addTurnoCaja";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("tipo", tipo.ToString())
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
        public bool Bloqueo_politicas(string campus, string especialidad,string modalidad)
        {
            string nomProce = "Consulta_BloqueoPoliticas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("campus", campus),
                 new Clase_Parametros("id_especialidad", especialidad),
                 new Clase_Parametros("modalidad", modalidad)
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
        public bool GetPromos(string tipo, string campus)
        {
            string nomProce = "getPromos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("ID_Campus", campus),
                 new Clase_Parametros("tipo", tipo.ToString())
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

        public bool AddPromo(string fecha_inicio,
                    string fecha_termino,
                    string modalidad,
                    string especialidad,
                    string cantidadDescuento,
                    string tipoDescuento,
                    string requisito,
                    string cantidadReq,
                    string tipoReq,
                    string obs, string campus, string maxAlum, string codigo, string campa)
        {
            string nomProce = "addPromos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("ID_Campus", campus),

                 new Clase_Parametros("fecha_inicio", fecha_inicio.Substring(0,10)),
                 new Clase_Parametros("fecha_termino", fecha_termino.Substring(0,10)),
                 new Clase_Parametros("modalidad", modalidad.ToString()),
                 new Clase_Parametros("especialidad", especialidad.ToString()),
                 new Clase_Parametros("cantidadDescuento", cantidadDescuento.ToString()),
                 new Clase_Parametros("tipoDescuento", tipoDescuento.ToString()),
                 new Clase_Parametros("requisito", requisito.ToString()),
                 new Clase_Parametros("cantidadReq", cantidadReq.ToString()),
                 new Clase_Parametros("tipoReq", tipoReq.ToString()),
                 new Clase_Parametros("obs", obs.ToString()),
                 new Clase_Parametros("maxAlum", maxAlum.ToString()),
                 new Clase_Parametros("codigo", codigo.ToString()),
                 new Clase_Parametros("campania", campa),
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
        public bool ConsultaAutorizacionReporteRecibos(string campus)
        {

            string nomProce = "ConsultaAutorizacionReporteRecibos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("Campus", campus)
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

        public bool ConsultaBonificacionesAutorizadas(string campus)
        {

            string nomProce = "ConsultaBonificacionesAutorizadas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("Campus", campus)
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
        public bool ConsultaRecibosImpresos(string reciboInicio, string reciboFin, string campus)
        {

            string nomProce = "ConsultaRecibosImpresos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("ReciboInicio", reciboInicio),
                 new Clase_Parametros("ReciboFin", reciboFin),
                 new Clase_Parametros("Campus", campus)
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
        public bool ConsultaReciboImpreso(string recibo, string alumno)
        {

            string nomProce = "ConsultaReciboImpreso";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("Recibo", recibo),
                 new Clase_Parametros("ID_Alumno", alumno)
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
        public bool UpReciboImpreso(string recibo, string alumno)
        {

            string nomProce = "upReciboImpreso";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("Recibo", recibo),
                 new Clase_Parametros("ID_Alumno", alumno)
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
        public bool ComboCargosAlumnos(string id_alumno)
        {

            string nomProce = "ComboCargosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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

        public bool GetCreditoEducativoListado()
        {

            string nomProce = "getCreditoEducativoListado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("id_campus", Clase_Sesion.Campus)
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

        public bool AutorizarCreditoEducativo(string id)
        {

            string nomProce = "autorizarCreditoEducativo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("id_credito", id),
                 new Clase_Parametros("id_Empleado", Clase_Sesion.IDEmpleado),
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
        public bool Consultaxml_cancelar()
        {

            string nomProce = "XML_Cancelar_Datos";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpXML_Ingresos(string uuid)
        {

            string nomProce = "up_XML_Ingresos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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

        public bool AddObservacionesAlumnoCargo(string id_alumno, string fecha, string observaciones, string id_empleado, string id_cargo)
        {

            string nomProce = "AddObservacionesAlumnoCargo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("id_alumno", id_alumno),
                 new Clase_Parametros("fecha", fecha),
                 new Clase_Parametros("observaciones", observaciones),
                 new Clase_Parametros("id_empleado", id_empleado),
                 new Clase_Parametros("id_cargo", id_cargo)
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
        public bool AddObservacionesAlumno(string id_alumno, string fecha, string observaciones, string id_empleado)
        {

            string nomProce = "AddObservacionesAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("id_alumno", id_alumno),
                 new Clase_Parametros("fecha", fecha),
                 new Clase_Parametros("observaciones", observaciones),
                 new Clase_Parametros("id_empleado", id_empleado)
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
        public bool ConsultaObservacionesAlumnos(string id_alumno)
        {

            string nomProce = "ConsultaObservacionesAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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
        public bool ConsultaBancos2()
        {
            string nomProce = "ConsultaBancos2";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Tarjetas(string ID_Alumno, string Empleado, string notas, string abono, string fecha_abono, string formapago,
            string campus, string banco, string turno, string FechaConcentradora, string libros, string id_Promo1 = "0", string id_Promo2 = "0",
            string meses = "0")
        {
            string nomProce = "addAbonosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", ID_Alumno),
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("notas", notas),
                new Clase_Parametros("abono", abono),
                new Clase_Parametros("fechaabono", fecha_abono),
                new Clase_Parametros("FechaConcentradora", FechaConcentradora),
                new Clase_Parametros("formapago", formapago),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("banco", banco),
                new Clase_Parametros("turno", turno),
                new Clase_Parametros("libros", libros),
                new Clase_Parametros("meses", meses),
                new Clase_Parametros("id_Promo1", id_Promo1),

                new Clase_Parametros("id_Promo2", id_Promo2),

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
        public bool Concentradora(string ID_Alumno, string Empleado, string notas, string abono, string fecha_abono,
            string formapago, string campus, string banco, string turno, string FechaConcentradora, string libros, string pagado,
            string id_Promo1 = "0", string id_Promo2 = "0")
        {
            string nomProce = "addAbonosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", ID_Alumno),
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("notas", notas),
                new Clase_Parametros("abono", abono),
                new Clase_Parametros("fechaabono", fecha_abono),
                new Clase_Parametros("FechaConcentradora", FechaConcentradora),
                new Clase_Parametros("formapago", formapago),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("banco", banco),
                new Clase_Parametros("turno", turno),
                new Clase_Parametros("libros", libros),
                new Clase_Parametros("pagado", pagado),
                new Clase_Parametros("id_Promo1", id_Promo1),
                new Clase_Parametros("id_Promo2", id_Promo2)
            }; if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Concentradora_ConcentrasNoAplicadas(string ID_Alumno, string Empleado, string notas, string abono, string fecha_abono,
            string formapago, string campus, string banco, string turno, string FechaConcentradora, string libros, string pagado, string mesespasados,
            string id_Promo1 = "0", string id_Promo2 = "0")
        {
            string nomProce = "addAbonosAlumnos_ConcentrasNoAplicadas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", ID_Alumno),
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("notas", notas),
                new Clase_Parametros("abono", abono),
                new Clase_Parametros("fechaabono", fecha_abono),
                new Clase_Parametros("FechaConcentradora", FechaConcentradora),
                new Clase_Parametros("formapago", formapago),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("banco", banco),
                new Clase_Parametros("turno", turno),
                new Clase_Parametros("libros", libros),
                new Clase_Parametros("pagado", pagado),
                new Clase_Parametros("meses", mesespasados),
                new Clase_Parametros("id_Promo1", id_Promo1),
                new Clase_Parametros("id_Promo2", id_Promo2)
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
        public bool Efectivo(string ID_Alumno, string Empleado, string notas, string abono, string fecha_abono, string formapago,
            string campus, string banco, string turno, string FechaConcentradora, string libros, string id_Promo1 = "0", string id_Promo2 = "0")
        {
            string nomProce = "addAbonosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", ID_Alumno),
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("notas", notas),
                new Clase_Parametros("abono", abono),
                new Clase_Parametros("fechaabono", fecha_abono),
                new Clase_Parametros("FechaConcentradora", FechaConcentradora),
                new Clase_Parametros("formapago", formapago),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("banco", banco),
                new Clase_Parametros("turno", turno),
                new Clase_Parametros("libros", libros),
                 new Clase_Parametros("id_Promo1", id_Promo1),
                new Clase_Parametros("id_Promo2", id_Promo2)
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

        public bool EfectivoSAC(string ID_referencia, string formapago, string banco, string notas, string Empleado)
        {
            string nomProce = "addAbonosAlumnosLoboOneSAC";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("referencia", ID_referencia),
                new Clase_Parametros("id_forma_pago", formapago),
                new Clase_Parametros("id_banco", banco),
                new Clase_Parametros("notas", notas),
                new Clase_Parametros("id_empleado", Empleado)
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


        //
        public bool BonificacionNueva(string ID_Alumno, string Empleado, string notas, string abono, string turno)
        {
            string nomProce = "addBonificacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", ID_Alumno),
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("notas", notas),
                new Clase_Parametros("abono", abono),
                new Clase_Parametros("turno", turno),
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

        public bool AddCreditoEducativo(string id_campus, string descripcion, string id_banco)
        {
            string nomProce = "addCreditoEducativo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("param1", id_campus),
                new Clase_Parametros("param2", descripcion),
                new Clase_Parametros("tipo", "1"),
                new Clase_Parametros("id_banco", id_banco),

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
        public bool AddCreditoEducativoMov(string id_creditoeducativo, string id_alumno, string transferencia, string bonificacion, string id_banco)
        {
            string nomProce = "addCreditoEducativo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("param1", id_creditoeducativo),
                new Clase_Parametros("param2", id_alumno),
                new Clase_Parametros("tipo", "2"),
                new Clase_Parametros("transferencia", transferencia),
                new Clase_Parametros("bonificacion", bonificacion),
                new Clase_Parametros("id_banco", id_banco),

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


        public bool AdPagosCredito(string id_creditoeducativo)
        {
            string nomProce = "addAbonosCreditoducativo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_CreditoEducativo", id_creditoeducativo),
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

        public bool Bonificacion(string ID_Alumno, string Empleado, string notas, string abono, string fecha_abono, string formapago,
            string campus, string banco, string turno, string FechaConcentradora, string libros, string id_Promo1 = "0", string id_Promo2 = "0")
        {
            string nomProce = "addAbonosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", ID_Alumno),
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("notas", notas),
                new Clase_Parametros("abono", abono),
                new Clase_Parametros("fechaabono", fecha_abono),
                new Clase_Parametros("FechaConcentradora", FechaConcentradora),
                new Clase_Parametros("formapago", formapago),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("banco", banco),
                new Clase_Parametros("turno", turno),
                new Clase_Parametros("libros", libros),
                new Clase_Parametros("id_Promo1", id_Promo1),

                new Clase_Parametros("id_Promo2", id_Promo2),

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
        public bool CancelarFactura(string id_alumno, string recibo)
        {
            string nomProce = "CancelarFactura";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("Recibo", recibo)
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

        public bool UpUUIDFactura(string id_alumno, string recibo, string UUID, string tipo, string uuidgen="")
        {
            string nomProce = "upUUIDFactura";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("Recibo", recibo),
                new Clase_Parametros("UUID", UUID),
                new Clase_Parametros("tipo",tipo),
                new Clase_Parametros("UUIDGEN", uuidgen)
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
        public bool UpUUIDFacturaDifer(string id_factura, string UUID)
        {
            string nomProce = "upUUIDFacturaDifer";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_factura", id_factura),
                new Clase_Parametros("UUID", UUID)
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
        public bool UpUUIDFacturaIndep(string id_factura, string UUID, string tiposust, string olduuid = "0")
        {
            string nomProce = "upUUIDFacturaIndep";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_factura", id_factura),
                new Clase_Parametros("UUID", UUID),
                new Clase_Parametros("tipo", tiposust),
                new Clase_Parametros("olduuid", olduuid)
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
        public bool UpUUIDNominaADMCancelado(string uuid)
        {
            string nomProce = "upUUIDNominaADMCancelado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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
        public bool UpUUIDNominaDocenteCancelado(string uuid)
        {
            string nomProce = "upUUIDNominaDocenteCancelado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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
        public bool UpUUIDNominaDocenteDSCancelado(string uuid)
        {
            string nomProce = "upUUIDNominaDSCancelado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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
        public bool UpUUIDFACancelado(string uuid)
        {
            string nomProce = "upUUIDFACancelado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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
        public bool Consulta_Recibos_NoFactura(string id_alumno,string recibo)
        {
            string nomProce = "Consulta_Recibos_NoFactura";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", id_alumno),
                new Clase_Parametros("Recibo", recibo)
            };
            if (ConsultarParametros(nomProce,par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpUUIDFacturaGenerica(string Fecha1, string Fecha2, string UUID, string serie, string folio)
        {
            string nomProce = "upUUIDFacturaGenerica";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha1", Fecha1),
                new Clase_Parametros("Fecha2", Fecha2),
                new Clase_Parametros("UUID", UUID),
                new Clase_Parametros("Serie", serie),
                new Clase_Parametros("Folio", folio)
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

        public bool UpUUIDFacturaRelacionada(string ID_Alumno, string Recibo, string UUID)
        {
            string nomProce = "AddFacRelUUID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", ID_Alumno),
                new Clase_Parametros("recibo", Recibo),
                new Clase_Parametros("uuid", UUID)
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
        public bool ConsultaTurnos(string ID_Campus, string ID_Area, string ID_Empleado)
        {
            string nomProce = "ConsultaEncargados";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("ID_Area", ID_Area),
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

        public bool ConsultaNumTurno()
        {
            string nomProce = "consultanumturno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

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
        public bool ConsultaNumTurnoPase(int tipo, string id_empleado)
        {
            string nomProce = "ConsultaNumTurnoPase";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo", tipo.ToString()),
                new Clase_Parametros("id_empleado", id_empleado)
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
        public bool ConsultaConvenios(string id_alumno)
        {
            string nomProce = "ConsultaAlumnosConveniosCaja";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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
        public bool InsertarConcentradora(string ID_Alumno, string banco, string abono, string Fecha, string campus, string archivo, string FechaConcentra, int formaPago=2)
        {
            string nomProce = "addConcentradora_Movimientos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("Banco", banco),
                new Clase_Parametros("Cantidad", abono),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", campus),
                new Clase_Parametros("Archivo", archivo),
                new Clase_Parametros("FechaConcentra", FechaConcentra),
                new Clase_Parametros("formaPago", formaPago.ToString()),
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
        public bool RevisarArchivoConcentra(string file)
        {
            string nomProce = "revisarArchivoConcentra";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("@File", file)
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
        public bool RevisaConcentraFecha(string FechaConcentra, string Banco)
        {
            string nomProce = "RevisaConcentraFecha";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("FechaConcentra", FechaConcentra),
                new Clase_Parametros("Banco", Banco)
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
        public bool RevisarConcentraCampusAlumno(string iD_Alumno)
        {
            string nomProce = "getCampusAlumnoConcentradora";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", iD_Alumno)
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
        public bool AddMovimientosTPV_Comision_IVA(string id_mov, string fecha, string monto, string Afiliacion, string Banco, string Sucursal)
        {
            string nomProce = "AddMovimientos_Bancarios_TPV";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Mov", id_mov),
                new Clase_Parametros("Fecha", fecha),
                new Clase_Parametros("Monto", monto),
                new Clase_Parametros("Afiliacion", Afiliacion),
                new Clase_Parametros("ID_Banco", Banco),
                new Clase_Parametros("Sucursal", Sucursal)
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
        public bool AddMovimientosBancariosDocumento(string fecha, string movimiento, string monto, string campusEnvia, string bancoEnvia, string cuentaEnvia, string campusRecibe, string bancoRecibe, string cuentaRecibe, string notas)
        {
            string nomProce = "addMovimientosBancariosDocumento";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", fecha),
                new Clase_Parametros("Movimiento", movimiento),
                new Clase_Parametros("Monto", monto),
                new Clase_Parametros("CampusEnvia", campusEnvia),
                new Clase_Parametros("BancoEnvia", bancoEnvia),
                new Clase_Parametros("CuentaEnvia", cuentaEnvia),
                new Clase_Parametros("CampusRecibe", campusRecibe),
                new Clase_Parametros("BancoRecibe", bancoRecibe),
                new Clase_Parametros("CuentaRecibe", cuentaRecibe),
                new Clase_Parametros("Notas", notas)
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
        public bool ConsultaCampusCorte()
        {
            string nomProce = "ConsultaCampusEmpleado";
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
        public bool ConsultaListView(string Campus, string turno, string DeFecha, string AFecha)
        {
            string nomProce = "ConsultaCorteCaja";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DeFecha", DeFecha),
                new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("Turno", turno)
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
        public bool ConsultaListView2(string Campus, string DeFecha, string AFecha)
        {
            string nomProce = "ConsultaCorteCaja2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DeFecha", DeFecha),
                new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus)
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
        public bool ConsultaListView3(string Campus, string DeFecha, string AFecha)
        {
            string nomProce = "ConsultaRecibosNoFacturados";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DeFecha", DeFecha),
                new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus)
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
        public bool ConsultaListaNotas(string Campus, string DeFecha, string AFecha)
        {
            string nomProce = "ConsultaListaNotas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DeFecha", DeFecha),
                new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus)
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

        public bool ConsulFacturas(string Campus)
        {
            string nomProce = "ConsultaFacturasGenericaxCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
              //  new Clase_Parametros("DeFecha", DeFecha),
                //new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus)
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


        public bool ConsulFacturasEspecificas(string DeFecha, string AFecha, string Campus)
        {
            string nomProce = "ConsultaFacturasEspecificasxCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DeFecha", DeFecha),
                new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus)
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

        public bool ConsulFacturasEspecificasdelAnio(string DeFecha, string AFecha, string Campus)
        {
            string nomProce = "ConsultaFacturasEspecificasAnioxCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DeFecha", DeFecha),
                new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus)
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
        public bool ConsRecibosGen(string Campus, string uuid)
        {
            string nomProce = "ConsultaRecibosGenerica";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
              //  new Clase_Parametros("DeFecha", DeFecha),
                //new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("UUID", uuid)
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

        public bool ConsRecibosGenxFecha(string DeFecha, string AFecha, string Campus, string uuid)
        {
            string nomProce = "ConsultaRecibosGenericaxFecha";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DeFecha", DeFecha),
                new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("UUID", uuid)
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

        public bool ConsRecibosGenxCampusFecha(string Campus, string Fecha)
        {
            string nomProce = "ConsultaFacturasGenericaxCampusFecha";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("FechaAbono", Fecha)
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

        public bool ConsRecibosGenxFechaAbono(string DeFecha, string Campus)
        {
            string nomProce = "ConsultaRecibosGenericaxFechaAbono";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("FechaAbono", DeFecha),
                new Clase_Parametros("Campus", Campus)
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
        public bool ConsultaMontoConcentra(string Campus, string DeFecha, string AFecha)
        {
            string nomProce = "ConsultaMontoConcentradora";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha1", DeFecha),
                new Clase_Parametros("Fecha2", AFecha),
                new Clase_Parametros("ID_Campus", Campus)
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
        public bool ConsultaUltRecibo(string alumno, string fecha)
        {

            string nomProce = "ConsultaUltRecibo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", alumno),
                new Clase_Parametros("fechareg", fecha)
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
        public bool ConsultatRecibo(string recibo, string id_alumno)
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
        public bool ConsultaUltimosRecibo(string Campus, string turno, string DeFecha, string AFecha)
        {

            string nomProce = "ConsultaRecibos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DeFecha", DeFecha),
                new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("Turno", turno)
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
        public bool ConsultaUltimosReciboBon(string Campus, string turno, string DeFecha, string AFecha)
        {

            string nomProce = "ConsultaRecibosBon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DeFecha", DeFecha),
                new Clase_Parametros("AFecha", AFecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("Turno", turno)
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
        public bool ConsultaArqueoCampusEmpleado(string Empleado,string Fecha)
        {
            string nomProce = "getArqueosCampusEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", Empleado),
                new Clase_Parametros("Fecha", Fecha)
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

        public bool ConsultaArqueoCampusEmpleadoBonificaciones(string Empleado, string Fecha)
        {
            string nomProce = "getArqueosCampusEmpleadoBonificaciones";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", Empleado),
                new Clase_Parametros("Fecha", Fecha)
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



        public bool getRecibosMes(string fechaini, string fechafin)
        {
            string nomProce = "Ingresos_ResumenRecibos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("fechaini", fechaini),
                new Clase_Parametros("fechafin", fechafin)
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

        //public bool RevisarConcentraCampusAlumno(string iD_Alumno)
        //{
        //    string nomProce = "getCampusAlumnoConcentradora";
        //    List<Clase_Parametros> par = new List<Clase_Parametros>
        //    {
        //        new Clase_Parametros("ID_Alumno", iD_Alumno)
        //    };
        //    if (ConsultarParametros(nomProce, par))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool ConsultaArqueoGeneradosEmpleado(string Empleado, string Fecha)
        {
            string nomProce = "[ConsultaArqueoGeneradosEmpleado]";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", Empleado),
                new Clase_Parametros("Fecha", Fecha)
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
        public bool ConsultaArqueo(string Fecha, string Campus, string Empleado)
        {
            string nomProce = "ConsultaArqueo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("ID_Empleado", Empleado)
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
        public bool ConsultaArqueoBonificaciones(string Fecha, string Campus, string Empleado)
        {
            string nomProce = "ConsultaArqueoBon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("ID_Empleado", Empleado)
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
        public bool ConsultaArqueoGral(string ID_ArqueoGral)
        {
            string nomProce = "ConsultaArqueoGral";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_ArqueoGral", ID_ArqueoGral)
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

        public bool ConsultaArqueosDiaGral(string Fecha, string Campus)
        {
            string nomProce = "ConsultaArqueosDiaGral";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", Campus)
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

        public bool ConsultaArqueoComplemento(string Fecha, string Campus, string Empleado, string ID_Arqueo)
        {
            string nomProce = "ConsultaArqueoComplemento";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("ID_Empleado", Empleado),
                new Clase_Parametros("ID_Arqueo", ID_Arqueo)
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
        public bool ConsultaArqueoBon(string Fecha, string Campus, string Empleado)
        {
            string nomProce = "ConsultaArqueoBon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("ID_Empleado", Empleado)
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

        public bool ConsultaArqueoTotalAbonoEmpleados(string Empleado, string Fecha, string Campus)
        {
            string nomProce = "getArqueosCampusEmpleadoTotalAbono";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("ID_Empleado", Empleado)
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

        public bool ConsultaArqueoTotalAbonoEmpleadosBon(string Empleado, string Fecha, string Campus)
        {
            string nomProce = "getArqueosCampusEmpleadoTotalAbonoBonificacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("ID_Empleado", Empleado)
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

        public bool ConsultaArqueoTotalAbonoCampus(string Fecha, string Campus)
        {
            string nomProce = "getArqueosCampusTotalAbono";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", Campus)
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
        public bool ConsultaArqueoTotalAbonoCampusBon(string Fecha, string Campus)
        {
            string nomProce = "getArqueosCampusTotalAbonoBonificacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", Campus)
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

        public bool ConsultaArqueoGralTotalAbonoCampus(string Fecha, string Campus)
        {
            string nomProce = "getArqueoGralCampusTotalAbono";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Campus", Campus)
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

        public bool InsertarArqueo(string campus, string ReciboDel, string ReciboAl, string Total, string Neto, string Faltante, string Fecha, string Cajera, string ResponsableADM, string ResponsableCont)
        {
            string nomProce = "addArqueos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ReciboDel", ReciboDel),
                new Clase_Parametros("ReciboAl", ReciboAl),
                new Clase_Parametros("Total", Total),
                new Clase_Parametros("Neto", Neto),
                new Clase_Parametros("FaltanteSobrante", Faltante),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Cajera", Cajera),
                new Clase_Parametros("ResponsableAdm", ResponsableADM),
                new Clase_Parametros("ResponsableCont", ResponsableCont)
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
        public bool InsertarArqueoGral(string campus, string ReciboDel, string ReciboAl, string Total, string Faltante, string Fecha)
        {
            string nomProce = "addArqueosGral";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ReciboDel", ReciboDel),
                new Clase_Parametros("ReciboAl", ReciboAl),
                new Clase_Parametros("Total", Total),
                new Clase_Parametros("FaltanteSobrante", Faltante),
                new Clase_Parametros("Fecha", Fecha)
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
        public bool InsertarArqueoComplemento(string ID_Arqueo)
        {
            string nomProce = "addArqueosComplemento";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Arqueo", ID_Arqueo)
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
        public bool InsertarArqueoBon(string campus, string ReciboDel, string ReciboAl, string Total, string Neto, string Faltante, string Fecha, string Cajera, string ResponsableADM, string ResponsableCont)
        {
            string nomProce = "addArqueosBon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ReciboDel", ReciboDel),
                new Clase_Parametros("ReciboAl", ReciboAl),
                new Clase_Parametros("Total", Total),
                new Clase_Parametros("Neto", Neto),
                new Clase_Parametros("FaltanteSobrante", Faltante),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Cajera", Cajera),
                new Clase_Parametros("ResponsableAdm", ResponsableADM),
                new Clase_Parametros("ResponsableCont", ResponsableCont)
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
        public bool InsertarArqueoM(string ID_Arqueo, string Fecha, string FormaPago, string Banco, string Cuenta, string Importe, string Turno)
        {
            string nomProce = "AddArqueosMovimientos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Arqueo", ID_Arqueo),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("FormaPago", FormaPago),
                new Clase_Parametros("Banco", Banco),
                new Clase_Parametros("Cuenta", Cuenta),
                new Clase_Parametros("Importe", Importe),
                new Clase_Parametros("Turno", Turno)
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
        public bool InsertarArqueoBonM(string ID_Arqueo, string Fecha, string FormaPago, string Banco, string Cuenta, string Importe, string Turno)
        {
            string nomProce = "AddArqueosBonMovimientos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Arqueo", ID_Arqueo),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("FormaPago", FormaPago),
                new Clase_Parametros("Banco", Banco),
                new Clase_Parametros("Cuenta", Cuenta),
                new Clase_Parametros("Importe", Importe),
                new Clase_Parametros("Turno", Turno)
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
        public bool ConsultaUltArqueo(string campus, string ReciboDel, string ReciboAl, string Total, string Faltante, string Fecha, string Cajera, string ResponsableADM, string ResponsableCont)
        {
            string nomProce = "ConsultaUltArqueo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ReciboDel", ReciboDel),
                new Clase_Parametros("ReciboAl", ReciboAl),
                new Clase_Parametros("Total", Total),
                new Clase_Parametros("FaltanteSobrante", Faltante),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Cajera", Cajera),
                new Clase_Parametros("ResponsableAdm", ResponsableADM),
                new Clase_Parametros("ResponsableCont", ResponsableCont)
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
        public bool ConsultaUltArqueoBon(string campus, string ReciboDel, string ReciboAl, string Total, string Faltante, string Fecha, string Cajera, string ResponsableADM, string ResponsableCont)
        {
            string nomProce = "ConsultaUltArqueoBonificacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ReciboDel", ReciboDel),
                new Clase_Parametros("ReciboAl", ReciboAl),
                new Clase_Parametros("Total", Total),
                new Clase_Parametros("FaltanteSobrante", Faltante),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Cajera", Cajera),
                new Clase_Parametros("ResponsableAdm", ResponsableADM),
                new Clase_Parametros("ResponsableCont", ResponsableCont)
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

        public bool ConsultaUltArqueoGral(string campus, string ReciboDel, string ReciboAl, string Total, string Faltante, string Fecha)
        {
            string nomProce = "ConsultaUltArqueoGral";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ReciboDel", ReciboDel),
                new Clase_Parametros("ReciboAl", ReciboAl),
                new Clase_Parametros("Total", Total),
                new Clase_Parametros("FaltanteSobrante", Faltante),
                new Clase_Parametros("Fecha", Fecha)
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

        public bool ConsultaArqueoExistente(string campus, string ReciboDel, string Fecha, string Cajera)
        {
            string nomProce = "ConsultaArqueoExistente";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("Recibo", ReciboDel),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Cajera", Cajera)
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

        public bool ConsultaArqueoExistenteBon(string campus, string ReciboDel, string Fecha, string Cajera)
        {
            string nomProce = "ConsultaArqueoExistenteBonificaciones";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("Recibo", ReciboDel),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Cajera", Cajera)
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
        public bool ConsultaArqueoExistenteGral(string campus, string Fecha)
        {
            string nomProce = "ConsultaArqueoExistenteGral";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("Fecha", Fecha)
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
        public bool ConsultaUltBonArqueo(string campus, string ReciboDel, string ReciboAl, string Total, string Faltante, string Fecha, string Cajera, string ResponsableADM, string ResponsableCont)
        {
            string nomProce = "ConsultaUltBonArqueo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ReciboDel", ReciboDel),
                new Clase_Parametros("ReciboAl", ReciboAl),
                new Clase_Parametros("Total", Total),
                new Clase_Parametros("FaltanteSobrante", Faltante),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("Cajera", Cajera),
                new Clase_Parametros("ResponsableAdm", ResponsableADM),
                new Clase_Parametros("ResponsableCont", ResponsableCont)
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
        public bool ConsultaArqueoFRM(string ID_Arqueo)
        {
            string nomProce = "ConsultaArqueoFRM";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Arqueo", ID_Arqueo)
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

        public bool ConsultaArqueoFRMSistemas(string ID_Arqueo, string tipoArqueo)
        {
            string nomProce = "ConsultaArqueoFRMSistemas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Arqueo", ID_Arqueo)
                ,new Clase_Parametros("tipoArqueo", tipoArqueo)
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

        public bool BorrarArqueoFRMSistemas(string ID_Arqueo, string tipoArqueo)
        {
            string nomProce = "Sistemas_BorrarArqueo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Arqueo", ID_Arqueo)
                ,new Clase_Parametros("tipoArqueo", tipoArqueo)
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
        public bool ConsultaArqueoBonFRM(string ID_Arqueo)
        {
            string nomProce = "ConsultaArqueoBonFRM";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Arqueo", ID_Arqueo)
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
        public bool ConsultaArqueoMovs(string ID_Arqueo)
        {
            string nomProce = "ConsultaArqueoMovsFRM";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Arqueo", ID_Arqueo)
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
        public bool ConsultaArqueoBonMovs(string ID_Arqueo)
        {
            string nomProce = "ConsultaArqueoBonMovsFRM";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Arqueo", ID_Arqueo)
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
        public bool ConsultaAjusteColeg(string ID_Alumno, string Concepto)
        {
            string nomProce = "ConsultaAjustesColeg";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("idalumno", ID_Alumno),
                new Clase_Parametros("concepto", Concepto)
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
        public bool UpAjusteColeg(string ID_Alumno, string Concepto, string importe, string diferencia, string fecha)
        {
            string nomProce = "UpAjusteColegiatura";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("Concepto", Concepto),
                new Clase_Parametros("importe", importe),
                new Clase_Parametros("Diferencia", diferencia),
                new Clase_Parametros("Fecha", fecha),
                new Clase_Parametros("quitarRecargo", "0")

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
        public bool UpQuitarRecargo(string ID_Alumno, string Concepto)
        {
            string nomProce = "UpAjusteColegiatura";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("Concepto", Concepto),
                new Clase_Parametros("importe", "0"),
                new Clase_Parametros("Diferencia", "0"),
                new Clase_Parametros("Fecha", "0"),
                new Clase_Parametros("quitarRecargo", "1")
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

        public bool UpdateListCorte(string iD_Alumno, string iD_Empleado, string recibo, bool isracumulable)
        {
            string nomProce = "upListVCortes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", iD_Alumno),
                new Clase_Parametros("ID_Empleado", iD_Empleado),
                new Clase_Parametros("Recibo", recibo),
                new Clase_Parametros("ISRAcumulable", isracumulable.ToString())
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
        public bool UpdateListCorte2(string iD_Alumno, string iD_Empleado, string recibo, string tpvpendientes)
        {
            string nomProce = "upListVCortesTPV";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", iD_Alumno),
                new Clase_Parametros("ID_Empleado", iD_Empleado),
                new Clase_Parametros("Recibo", recibo),
                new Clase_Parametros("TPVPendientes", tpvpendientes)
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
        public bool UpdateListCorte3(string iD_Alumno, string iD_Empleado, string recibo, bool mespasado)
        {
            string nomProce = "upListVCortesMesP";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", iD_Alumno),
                new Clase_Parametros("ID_Empleado", iD_Empleado),
                new Clase_Parametros("Recibo", recibo),
                new Clase_Parametros("MesPasado", mespasado.ToString())
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
        public bool UpdateListCorte4(string iD_Alumno, string iD_Empleado, string recibo, bool chequeentransito)
        {
            string nomProce = "upListVCortesCheque";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", iD_Alumno),
                new Clase_Parametros("ID_Empleado", iD_Empleado),
                new Clase_Parametros("Recibo", recibo),
                new Clase_Parametros("chequeentransito", chequeentransito.ToString())
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
        public bool DesactivarCargo(string ID_Cargo, string Descripcion)
        {
            string nomProce = "desactivarCargoAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Cargo", ID_Cargo),
                new Clase_Parametros("Descripcion", Descripcion),
                new Clase_Parametros("bitSeguridad", Clase_Sesion.Rol=="14"?"1":"0")
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
        public bool CancelarAbono(string ID_Recibo, string ID_Alumno, string motivo)
        {
            string nomProce = "cancelarRecibos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Recibo", ID_Recibo),
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("motivo", motivo),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado),
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
        public bool DevolucionMasivo(string ID_Recibo, string ID_Alumno, string motivo, string FormaP, string banco)
        {
            string nomProce = "devolucionRecibos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Recibo", ID_Recibo),
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("motivo", motivo),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado),
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("FormaP", FormaP),
                new Clase_Parametros("banco", banco),
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
        public bool Devolucion(string ID_Recibo, string ID_Alumno, string motivo, string FormaP, string banco, string montodev)
        {
            string nomProce = "addAutorizar_Devolucion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("Recibo", ID_Recibo),
                new Clase_Parametros("Observacion", motivo),
                new Clase_Parametros("FormaPago", FormaP),
                new Clase_Parametros("Banco", banco),
                new Clase_Parametros("id_campus", Clase_Sesion.Campus),
                new Clase_Parametros("id_Empleado", Clase_Sesion.IDEmpleado),
                new Clase_Parametros("montoDevolver", montodev),

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

        public bool ConsultaDevolciones()
        {
            string nomProce = "getDevoluciones";


            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ConsultaDesactivados()
        {
            string nomProce = "getDesactivados";
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
        public bool GetDatosAlumno(string ID_Alumno)
        {
            string nomProce = "getAlumno";
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
        public bool RecibosAlumno(string ID_Alumno)
        {
            string nomProce = "recibosAlumno";
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
        public bool UpdateCargo(string ID_Cargo, int tipo)
        {
            string nomProce = "updateCargo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Cargo", ID_Cargo),
                new Clase_Parametros("Tipo", tipo.ToString())
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
        public bool ValidaAdeudo(string ID_Alumno)
        {
            string nomProce = "ValidarAlumnoAdeudo";
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

        public bool ValidaAdeudoCredenciales(string ID_Alumno)
        {
            string nomProce = "ValidarAlumnoAdeudoCredenciales";
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

        public bool InsertRecibosNotas(string ID_Alumno, string Recibo, int id_Nota, string tipo)
        {
            string nomProce = "insertarTempRecibosNotas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("Recibo", Recibo),
                new Clase_Parametros("ID_Nota",id_Nota.ToString()),
                new Clase_Parametros("tipo",tipo)
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

        public bool Consulta_GenericaUUID(string UUID, string campus, string tipo)
        {
            string nomProce = "ConsultaFacturasGenericaxUUID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("UUID", UUID),
                new Clase_Parametros("campus", campus),
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

        public bool Getid(string tipo)
        {
            string nomProce = "GetIDNota";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo",tipo)
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

        public bool ConsFacturasxFecha(string DeFecha, string AFecha)
        {
            string nomProce = "ConsultaFacturasCampusxFecha";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DeFecha", DeFecha),
                new Clase_Parametros("AFecha", AFecha)
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

        public bool ConsutaAutorizacion(string ID_alumno, string empleado)
        {
            string nomProce = "ConsAutorizacion_CartaGarantia";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_alumno),
                new Clase_Parametros("ID_Empleado", empleado)
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
        public bool ConsutaAutorizacionApoyoAccidentes(string ID_alumno, string empleado)
        {
            string nomProce = "ConsAutorizacion_CartaApoyoAccidentes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_alumno),
                new Clase_Parametros("ID_Empleado", empleado)
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
        public bool AddAutorizacionBon(string Bonif, string observ)
        {
            string nomProce = "SolicitarBonificaciones";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("NumBonif", Bonif),
                new Clase_Parametros("Observacion", observ),
                new Clase_Parametros("id_campus", Clase_Sesion.Campus),
                new Clase_Parametros("id_Empleado", Clase_Sesion.IDEmpleado)
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

        public bool AddAutorizacionBonAlumno(string ID_Alumno, string motivo, string monto, string id_campus)
        {
            string nomProce = "SolicitarBonificacionesAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("Monto", monto),
                new Clase_Parametros("Motivo", motivo),
                new Clase_Parametros("ID_Campus", id_campus),
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

        public bool AddAutoriFacturaDifer(string Tipo, string observ, string monto)
        {
            string nomProce = "addAutoriFactura";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo", Tipo),
                new Clase_Parametros("Observacion", observ),
                new Clase_Parametros("Monto", monto),
                new Clase_Parametros("id_campus", Clase_Sesion.Campus),
                new Clase_Parametros("id_Empleado", Clase_Sesion.IDEmpleado)
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
        public bool UpEncargadosArea(string ID_Empleado, string ID_Area, string Puesto)
        {
            string nomProce = "UpEncargosArea";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                 new Clase_Parametros("ID_Area", ID_Area),
                 new Clase_Parametros("ID_Empleado", ID_Empleado),
                 new Clase_Parametros("Puesto", Puesto)
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
    public class Clase_Convenios : Clase_Conecta
    {
        #region Propiedades
        private int id_convenio;
        public int Convenio
        {
            get => id_convenio;
            set => id_convenio = value;
        }

        private string empresa;
        public string Empresa
        {
            get => empresa;
            set => empresa = value;
        }

        private string motivo_convenio;
        public string Motivo_Convenio
        {
            get => motivo_convenio;
            set => motivo_convenio = value;
        }

        private string contacto;
        public string Contacto
        {
            get => contacto;
            set => contacto = value;
        }

        private string telefono_contacto;
        public string Telefono_Contacto
        {
            get => telefono_contacto;
            set => telefono_contacto = value;
        }

        private string correocontacto;
        public string Correo_Contacto
        {
            get => correocontacto;
            set => correocontacto = value;
        }

        private string fecha_inicio;
        public string Fecha_Inicio
        {
            get => fecha_inicio;
            set => fecha_inicio = value;
        }

        private string fecha_termino;
        public string Fecha_Termino
        {
            get => fecha_termino;
            set => fecha_termino = value;
        }

        private string fecha_registro;
        public string Fecha_Registro
        {
            get => fecha_registro;
            set => fecha_registro = value;
        }

        private bool vigente;
        public bool Vigente
        {
            get => vigente;
            set => vigente = value;
        }

        private string id_campus;
        public string ID_Campus
        {
            get => id_campus;
            set => id_campus = value;
        }
        #endregion
        #region Constructores
        public Clase_Convenios()
        { }

        public Clase_Convenios(int ID_Convenio, string Empresa, string Motivo_Convenio, string Contacto, string Telefono_Contacto, string Correo_Contacto, string Fecha_Inicio, string Fecha_Termino, string Fecha_Registro, bool Vigente, string ID_Campus)
        {
            this.Convenio = ID_Convenio;
            this.Empresa = Empresa;
            this.Motivo_Convenio = Motivo_Convenio;
            this.Contacto = Contacto;
            this.Telefono_Contacto = Telefono_Contacto;
            this.Correo_Contacto = Correo_Contacto;
            this.Fecha_Inicio = Fecha_Inicio;
            this.Fecha_Termino = Fecha_Termino;
            this.Fecha_Registro = Fecha_Registro;
            this.Vigente = Vigente;
            this.ID_Campus = ID_Campus;
        }
        #endregion
        #region Métodos
        public bool Insertar_Convenio()/*AGREGA UN VCONVENIO*/
        {
            try
            {
                string nomProce = "AddConvenio";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("Empresa", Empresa),
                    new Clase_Parametros("Motivo_Convenio", Motivo_Convenio),
                    new Clase_Parametros("Contacto", Contacto),
                    new Clase_Parametros("TelefonoContacto", Telefono_Contacto),
                    new Clase_Parametros("CorreoContacto", Correo_Contacto),
                    new Clase_Parametros("FechaInicio", Fecha_Inicio),
                    new Clase_Parametros("FechaTermino", Fecha_Termino),
                    new Clase_Parametros("Vigente", Vigente.ToString()),
                    new Clase_Parametros("ID_Campus", ID_Campus)
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
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }

        public bool Consulta_Convenios(int ID_Convenio)/*TRAE TODA LA INFORMACIÓN DE UN CONVENIO*/
        {
            string nomProce = "ConsultaConvenios";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Convenio", ID_Convenio.ToString())
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

        public bool Actualizar_Convenio()/*ACTUALIZA LA INFORMACIÓN DE LOS CONVENIOS*/
        {
            string nomProce = "upConvenio";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Convenio", Convenio.ToString()),
                new Clase_Parametros("Empresa", Empresa),
                new Clase_Parametros("Motivo_Convenio", Motivo_Convenio),
                new Clase_Parametros("Contacto", Contacto),
                new Clase_Parametros("TelefonoContacto", Telefono_Contacto),
                new Clase_Parametros("CorreoContacto", Correo_Contacto),
                new Clase_Parametros("FechaInicio", Fecha_Inicio),
                new Clase_Parametros("FechaTermino", Fecha_Termino),
                new Clase_Parametros("Vigente", Vigente.ToString()),
                new Clase_Parametros("ID_Campus", ID_Campus)
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

        public bool Combo_Convenios(string ID_Campus)/*LLENA EL COMBO DE CONVENIOS, PARA PODER SELECIONAR UNO Y MOSTRAR LA INFORMACIÓN*/
        {
            string nomProce = "ComboConvenios";

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

        public bool ComboCampusConvenios(string ID_Campus)
        {
            string nomProce = "ComboCampusConvenios";

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
        public bool Insertar_Alumnos_Convenio(string ID_Alumno, bool Convenio, string Observaciones, string FechaI, string FechaF)/*AGREGA UN VCONVENIO*/
        {
            try
            {
                string nomProce = "AddAlumnosConvenios";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Alumno", ID_Alumno),
                    new Clase_Parametros("Convenio", Convenio.ToString()),
                    new Clase_Parametros("Observaciones", Observaciones),
                    new Clase_Parametros("fechaI", FechaI),
                    new Clase_Parametros("fechaF", FechaF)
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
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }
        public bool Actualizar_Alumnos_Convenio(string ID_Movimiento, string ID_Alumno, bool Convenio, string Observaciones, string FechaI, string FechaF)/*AGREGA UN VCONVENIO*/
        {
            try
            {
                string nomProce = "UpAlumnosConvenios";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Movimiento", ID_Movimiento),
                    new Clase_Parametros("ID_Alumno", ID_Alumno),
                    new Clase_Parametros("Convenio", Convenio.ToString()),
                    new Clase_Parametros("Observaciones", Observaciones),
                    new Clase_Parametros("fechaI", FechaI),
                    new Clase_Parametros("fechaF", FechaF)
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
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }
        public bool Consultar_Alumnos_Convenio(string ID_Alumno)/*AGREGA UN VCONVENIO*/
        {
            try
            {
                string nomProce = "ConsultaAlumnosConvenios";
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
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }
        #endregion
    }
    public class Clase_CargosAlumnos : Clase_Conecta
    {
        #region Propiedades
        private string alumno;

        public string Alumno
        {
            get => alumno;
            set => alumno = value;
        }
        private int concepto;

        public int Concepto
        {
            get => concepto;
            set => concepto = value;
        }
        private DateTime fechacargo;

        public DateTime Fechacargo
        {
            get => fechacargo;
            set => fechacargo = value;
        }
        private string empleado;

        public string Empleado
        {
            get => empleado;
            set => empleado = value;
        }
        #endregion
        #region Constructores
        public Clase_CargosAlumnos(string alumno, int concepto, DateTime fechacargo, string empleado)
        {
            Alumno = alumno;
            Concepto = concepto;
            Fechacargo = fechacargo;
            Empleado = empleado;
        }

        public Clase_CargosAlumnos()
        {

        }
        #endregion
        #region Métodos
        public bool ConsultaCargoxTipo(string tipo)
        {
            string nomProce = "ConsultaCargoxTipo";
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

        public bool ConsultaCargoxTipoCiclo(string tipo,string ciclo,string especialidad)
        {
            string nomProce = "ConsultaCargoxTipoCiclo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo", tipo),
                new Clase_Parametros("ciclo", ciclo),
                new Clase_Parametros("especialidad", especialidad),
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
        public bool ConsultaPagosPendientes(string id_Campus)
        {
            string nomProce = "ConsultaPagosPendientes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", id_Campus)
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
        public bool InsertaCargosAlumnos()
        {
            string nomProce = "addCargosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("alumno", Alumno),
                new Clase_Parametros("concepto", Concepto.ToString()),
                new Clase_Parametros("fechacargo", Fechacargo.ToString()),
                new Clase_Parametros("empleado", Empleado)
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

        public bool ActualizarCargosAlumnos()
        {
            string nomProce = "upCargosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("alumno", Alumno),
                new Clase_Parametros("concepto", Concepto.ToString()),
                new Clase_Parametros("fechacargo", Fechacargo.ToString()),
                new Clase_Parametros("empleado", Empleado)
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
    public class Clase_CargosConceptos : Clase_Conecta
    {
        #region Propiedades
        private string descripcion;
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        private string fechalimite;
        public string Fechalimite
        {
            get => fechalimite;
            set => fechalimite = value;
        }
        private string monto;
        public string Monto
        {
            get => monto;
            set => monto = value;
        }
        private string periodo;
        public string Periodo
        {
            get => periodo;
            set => periodo = value;
        }
        private string categoria;
        public string Categoria
        {
            get => categoria;
            set => categoria = value;
        }
        private string recargo;
        public string Recargo
        {
            get => recargo;
            set => recargo = value;
        }
        private string id_especialidad;
        public string Id_especialidad
        {
            get => id_especialidad;
            set => id_especialidad = value;
        }
        private string id_colegiatura;
        public string ID_Colegiatura
        {
            get => id_colegiatura;
            set => id_colegiatura = value;
        }
        private string seguro;
        public string Seguro
        {
            get => seguro;
            set => seguro = value;
        }
        private string LBS;
        public string lbs
        {
            get => lbs;
            set => lbs = value;
        }
        #endregion
        #region Constructores
        public Clase_CargosConceptos() { }
        public Clase_CargosConceptos(string descripcion2, string fechalimite2, string monto2, string periodo2, string categoria2, string Recargo2, string id_esp, string id_colegiatura2, string seguro1, string LBS1="")
        {
            Descripcion = descripcion2;
            Fechalimite = fechalimite2;
            Monto = monto2;
            Periodo = periodo2;
            Categoria = categoria2;
            Recargo = Recargo2;
            Id_especialidad = id_esp;
            ID_Colegiatura = id_colegiatura2;
            Seguro = seguro1;
            LBS = LBS1;
        }
        #endregion
        #region Métodos
        public Clase_CargosConceptos(string descripcion, /*string mes,*/ string monto, string tipoCargo/*, string anio*/, string fechalimite)
        {
            //string fechalimite = "01";
            //if (mes == "Diciembre")
            //{
            //    fechalimite += "-12-" + anio;
            //}
            //else if (mes == "Noviembre")
            //{
            //    fechalimite += "-11-" + anio;
            //}
            //else if (mes == "Octubre")
            //{
            //    fechalimite += "-10-" + anio;
            //}
            //else if (mes == "Septiembre")
            //{
            //    fechalimite += "-09-" + anio;
            //}
            //else if (mes == "Agosto")
            //{
            //    fechalimite += "-08-" + anio;
            //}
            //else if (mes == "Julio")
            //{
            //    fechalimite += "-07-" + anio;
            //}
            //else if (mes == "Junio")
            //{
            //    fechalimite += "-06-" + anio;
            //}
            //else if (mes == "Mayo")
            //{
            //    fechalimite += "-05-" + anio;
            //}
            //else if (mes == "Abril")
            //{
            //    fechalimite += "-04-" + anio;
            //}
            //else if (mes == "Marzo")
            //{
            //    fechalimite += "-03-" + anio;
            //}
            //else if (mes == "Febrero")
            //{
            //    fechalimite += "-02-" + anio;
            //}
            //else
            //{
            //    fechalimite += "-01-" + anio;
            //}

            //if (tipoCargo == "Anualidad" || tipoCargo == "Mensualidad")
            //    categoria = "2COL";
            //if (tipoCargo == "Membresia")
            //    categoria = "1INS";
            //else
            //    categoria = "3OTR";

            this.Descripcion = descripcion;
            this.Fechalimite = fechalimite;
            this.Monto = monto;
            this.Categoria = tipoCargo;

        }
        public bool InsertaCargosConceptos()
        {
            string nomProce = "addCargosConceptos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("descripcion", descripcion),
                new Clase_Parametros("fechalimite", fechalimite),
                new Clase_Parametros("monto", monto),
                new Clase_Parametros("periodo", periodo),
                new Clase_Parametros("categoria", categoria),
                new Clase_Parametros("Recargo", recargo),
                new Clase_Parametros("ID_Esp", id_especialidad),
                new Clase_Parametros("ID_Colegiatura", ID_Colegiatura),
                new Clase_Parametros("seguro", Seguro),
                new Clase_Parametros("LBS", LBS),
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
        public bool ConsultaConceptosGenerales(string campus)
        {
            string nomProce = "ConsultaConceptosGenerales";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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
        public bool InsertaCargosConceptosGenerales(string desc, string cantidad, string ciclo, string tipo_concepto, string especialidad, string tipo, string campus)
        {
            string nomProce = "addCargosConceptosGenerales";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("descripcion", desc),
                new Clase_Parametros("monto", cantidad),
                new Clase_Parametros("periodo", ciclo),
                new Clase_Parametros("categoria", tipo_concepto),
                new Clase_Parametros("ID_Esp", especialidad),
                new Clase_Parametros("tipo", tipo),
                new Clase_Parametros("campus", campus)
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
        public bool InsertaCargosConceptosArena(int siFecha, string fecha, string cantidad, string medida, string contenido, int meses, string membresia, string vigencia, string anio)
        {
            string nomProce = "addCargosConceptosAL";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("descripcion", descripcion),
                new Clase_Parametros("fechalimite", fechalimite),
                new Clase_Parametros("monto", monto),
                new Clase_Parametros("categoria", categoria),
                new Clase_Parametros("siFecha", siFecha.ToString()),
                new Clase_Parametros("fecha", fecha),
                new Clase_Parametros("cantidad", cantidad.ToString()),
                new Clase_Parametros("medida", medida),
                new Clase_Parametros("contenido", contenido),
                new Clase_Parametros("meses", meses.ToString()),
                new Clase_Parametros("membresia", membresia.ToString()),
                new Clase_Parametros("vigencia", vigencia.ToString()),
                new Clase_Parametros("anio", anio.ToString()),
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

        public bool ActualizarCargosConceptos(string ID_Concepto, string id_esp)
        {
            string nomProce = "upCargosConceptos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Condicion", ID_Concepto),
                new Clase_Parametros("descripcion", descripcion),
                new Clase_Parametros("fechalimite", fechalimite),
                new Clase_Parametros("monto", monto.ToString()),
                new Clase_Parametros("periodo", periodo),
                new Clase_Parametros("categoria", categoria),
                new Clase_Parametros("Recargo", recargo),
                new Clase_Parametros("ID_Esp", id_esp)
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
        public bool BorrarCargosConceptos(string ID_Conceto)
        {
            string nomProce = "BorrarConceptoCargo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Concepto", ID_Conceto)
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

        public bool InsertaCargos(string Cargo, string Tipo, string Recargo)
        {
            string nomProce = "addCargos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("cargo", Cargo),
                new Clase_Parametros("categoria", Tipo),
                new Clase_Parametros("recargo", Recargo)
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
    public class Clase_Generar_cargos_Clase : Clase_Conecta
    {
        private string cicloEsc;
        public string CicloEsc
        {
            get => cicloEsc;
            set => cicloEsc = value;
        }
        public static string iD_Alumno;
        public static string ID_Alumno
        {
            get => iD_Alumno;
            set => iD_Alumno = value;
        }
        public Clase_Generar_cargos_Clase() { }
        public Clase_Generar_cargos_Clase(string ID_Alu)
        {
            ID_Alumno = ID_Alu;
        }
        public bool LlenarDT(string cicloEsc, string id_esp)
        {
            string nomProce = "ConsultaConceptosxCiclo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Ciclo", cicloEsc),
                new Clase_Parametros("ID_Esp", id_esp)
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

        public bool upCostoAutorizado(string autorizado, string id)
        {
            string nomProce = "upCostosAutorizados";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_empleado", Clase_Sesion.IDEmpleado),
                new Clase_Parametros("id_movimiento", id),
                new Clase_Parametros("autorizado", autorizado),
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

        /*
         @id_periodo nvarchar(8),
@monto money,
@generacion int,
@id_tipoplan int,
@id_especialidad nvarchar(3),
@tipo nvarchar(4)

         */
        public bool addCostoAutorizado(string id_periodo, string monto, string generacion, 
            string id_tipoplan, string id_especialidad, string tipo)
        {
            string nomProce = "addCostosAutorizados";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_periodo", id_periodo),
                new Clase_Parametros("monto", monto),
                new Clase_Parametros("generacion", generacion),
                new Clase_Parametros("id_tipoplan", id_tipoplan),
                new Clase_Parametros("id_especialidad", id_especialidad),
                new Clase_Parametros("tipo", tipo),
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


        public bool getCostoAutorizado()
        {
            string nomProce = "getCostosAutorizados";
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
        public bool ActualizarFechaPagoAL(string id_alumno, string fechavencimiento, string frasesecreta)
        {
            string nomProce = "actualizarFechaPagoAL";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("@ID_Alumno", id_alumno),
                new Clase_Parametros("@fechaVencimiento", fechavencimiento),
                new Clase_Parametros("@fraseSecreta", frasesecreta),
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
        public bool LlenarDTOtros(string cicloEsc)
        {
            string nomProce = "ConsultaConceptosxCicloOtros";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Ciclo", cicloEsc)
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
        public bool ConsultaCargosIns(string Tipo, string periodo, string id_esp)
        {
            string nomProce = "ConsultaCargos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Tipo", Tipo),
                new Clase_Parametros("Periodo", periodo),
                new Clase_Parametros("ID_Esp", id_esp)
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

        public bool ConsultaCargosALFiltro(string mes, string anio, string tipoConcepto,
            string area, string tipoSocio, string contenido, string descripcion)
        {
            string nomProce = "ConsultaCargosALFiltro";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("anio", anio),
                new Clase_Parametros("mes", mes),
                new Clase_Parametros("tipoConcepto", tipoConcepto),
                new Clase_Parametros("area", area),
                new Clase_Parametros("tipoSocio", tipoSocio),
                new Clase_Parametros("contenido", contenido),
                new Clase_Parametros("descripcion", descripcion),
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
        public bool ConsultaCargosAL(string Tipo, string mes, string anio)
        {
            if (Clase_Sesion.Campus == "49")
            {
                string nomProce = "ConsultaCargosAL";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("Tipo", "3OTR"),
                    new Clase_Parametros("Mes", mes),
                    new Clase_Parametros("Anio", anio),
                    new Clase_Parametros("alcc", "1")

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
            else
            {
                string nomProce = "ConsultaCargosALFiltro";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("Tipo", Tipo),
                    new Clase_Parametros("Mes", mes),
                    new Clase_Parametros("Anio", anio)
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

        }

        public bool ConsultaCargosCol(string Tipo, string periodo, string id_esp)
        {
            string nomProce = "ConsultaCargos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Tipo", Tipo),
                new Clase_Parametros("Periodo", periodo),
                new Clase_Parametros("ID_Esp", id_esp)
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
        public bool ConsultaCargosOtros(string Tipo, string periodo)
        {
            string nomProce = "ConsultaCargos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Tipo", Tipo),
                new Clase_Parametros("Periodo", periodo)
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
        public bool ConsultaCargosCom(string Tipo, string periodo)
        {
            string nomProce = "ConsultaCargos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Tipo", Tipo),
                new Clase_Parametros("Periodo", periodo)
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
        public bool ConsCargosIDAL(string ID_Cargo, string ID_Alumno)
        {
            string nomProce = "ConsultaCargosporIDAL";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Concepto", ID_Cargo),
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
        public bool ConsCargosID(string ID_Cargo)
        {
            string nomProce = "ConsultaCargosporID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Cargo", ID_Cargo)
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
        public bool InsertarCargosAlumno(string ID_Cargo, string FechaCargo, string ID_Emp, string importe)
        {
            string nomProce = "addCargosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", iD_Alumno),
                new Clase_Parametros("concepto", ID_Cargo),
                new Clase_Parametros("fechacargo", FechaCargo),
                new Clase_Parametros("empleado", ID_Emp),
                new Clase_Parametros("Importe", importe),
                new Clase_Parametros("Diferencia", importe),
                new Clase_Parametros("Tipo", "1"),
                new Clase_Parametros("ID_Materia", "")
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
        public bool InsertarCargosAlumno2(string id_alumno, string ID_Cargo, string FechaCargo, string ID_Emp, string importe, string ID_Materia = "")
        {
            string nomProce = "addCargosAlumnos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", id_alumno),
                new Clase_Parametros("concepto", ID_Cargo),
                new Clase_Parametros("fechacargo", FechaCargo),
                new Clase_Parametros("empleado", ID_Emp),
                new Clase_Parametros("Importe", importe),
                new Clase_Parametros("Diferencia", importe),
                new Clase_Parametros("Tipo", "2"),
                new Clase_Parametros("ID_Materia", ID_Materia)
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
        public bool InsertarCargoGeneral(string ID_Alumno, string ID_Cargo, string FechaCargo, string ID_Emp, string importe)
        {
            string nomProce = "addCargosGenerales";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("alumno", ID_Alumno),
                new Clase_Parametros("concepto", ID_Cargo),
                new Clase_Parametros("fechacargo", FechaCargo),
                new Clase_Parametros("empleado", ID_Emp),
                new Clase_Parametros("Importe", importe)
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
        public bool EliminarCargosGenerales()
        {
            string nomProce = "EliminarCargosGenerales";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaCargosExistentes(string ID_Cargo)
        {
            string nomProce = "ConsultarCargosExistentes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", iD_Alumno),
                new Clase_Parametros("ID_Cargo", ID_Cargo)
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
        public bool GetCargoExamen(string ID_Periodo, int tipo)
        {
            string nomProce = "getCargoExamen";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Periodo", ID_Periodo),
                new Clase_Parametros("tipo", tipo.ToString())
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
        public bool ConsultaCargosExistentesM(string id_alu, string ID_Cargo)
        {
            string nomProce = "ConsultarCargosExistentes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", id_alu),
                new Clase_Parametros("ID_Cargo", ID_Cargo)
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

        public bool ConsultaTotalCargosVirtual(string id_alu, string ID_Cargo)
        {
            string nomProce = "consultaTotalCargosVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("idalumno", id_alu),
                new Clase_Parametros("idcargo", ID_Cargo)
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

        public bool ConsultaTotalCargosColVirtual(string id_alu)
        {
            string nomProce = "consultaTotalCargosColVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("idalumno", id_alu)
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

        public bool ConsultarTotalCargosXAlumno(string id_alu)
        {
            string nomProce = "ConsultarTotalCargosXAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", id_alu)
                //new Clase_Parametros("ID_Cargo", ID_Cargo)
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

        public bool ConsultaParamCargosVirtual(string campus)
        {
            string nomProce = "consultaParamCargosVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("idCampus", campus)
                //new Clase_Parametros("ID_Cargo", ID_Cargo)
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

        public bool ConsultarTotalCargosXAlumno(string id_alu, string pagados)
        {
            string nomProce = "ConsultarTotalCargosXAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", id_alu),
                new Clase_Parametros("Pagados", pagados)
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

        



        #region CargoExamenExtraordinario_Califiaciones
        public bool GetConceptoExtraordinarioCiclo(string ID_Periodo)
        {
            string nomProce = "GetConceptoExtraordinarioCiclo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Periodo", ID_Periodo)
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }
        public bool GetCargosExamenExtraordionario_Ciclo(string ID_Periodo)
        {
            string nomProce = "GetCargosExamenExtraordionario_Ciclo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Periodo", ID_Periodo)
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }
        public bool GetCargosExamenExtraordionario_Grupo(int ID_Grupo)
        {
            string nomProce = "GetCargosExamenExtraordionario_Grupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo.ToString())
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }

        public bool SetCargosExamenExtraordionario_Ciclo(string ID_Periodo)
        {
            string nomProce = "SetCargosExamenExtraordionario_Ciclo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Periodo", ID_Periodo),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }
        public bool SetCargosExamenExtraordionario_Grupo(int ID_Grupo)
        {
            string nomProce = "SetCargosExamenExtraordionario_Grupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo.ToString()),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
            };

            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        } 
        #endregion

    }
    public class Clase_ComprobantesCampus : Clase_Conecta
    {
        #region Propiedades
        private int condicion;

        public int Condicion
        {
            get => condicion;
            set => condicion = value;
        }
        private string campus;

        public string Campus
        {
            get => campus;
            set => campus = value;
        }
        private string recibo;

        public string Recibo
        {
            get => recibo;
            set => recibo = value;
        }
        private string letra;

        public string Letra
        {
            get => letra;
            set => letra = value;
        }
        private string bonletra;

        public string Bonletra
        {
            get => bonletra;
            set => bonletra = value;
        }
        private string bonificacion;

        public string Bonificacion
        {
            get => bonificacion;
            set => bonificacion = value;
        }
        #endregion
        #region Constructores
        public Clase_ComprobantesCampus(int condicion, string campus, string recibo, string letra, string bonletra, string bonificacion)
        {
            Condicion = condicion;
            Campus = campus;
            Recibo = recibo;
            Letra = letra;
            Bonletra = bonletra;
            Bonificacion = bonificacion;
        }
        #endregion
        #region Métodos
        public bool InsertarComprobantesCampus()
        {
            string nomProce = "addComprobantesCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("campus", Campus),
                new Clase_Parametros("recibo", Recibo),
                new Clase_Parametros("letra", Letra),
                new Clase_Parametros("bonletra", Bonletra),
                new Clase_Parametros("bonificacion", Bonificacion)
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

        public bool ActualizarComprobantesCampus()
        {
            string nomProce = "upComprobantesCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("condicion", Condicion.ToString()),
                new Clase_Parametros("campus", Campus),
                new Clase_Parametros("recibo", Recibo),
                new Clase_Parametros("letra", Letra),
                new Clase_Parametros("bonletra", Bonletra),
                new Clase_Parametros("bonificacion", Bonificacion)
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
    public class Clase_Bancos : Clase_Conecta
    {
        #region Constructores
        public Clase_Bancos()
        {
        }
        #endregion
        #region Métodos
        public bool AddSaldosFinales(string cuenta5692, string cuenta1719, string cuenta1466, string cuenta6999, string cuenta7991, string cuenta1037, string cuenta3489, string cuenta1050, string cuenta6502, string cuenta8992, string cuenta1408)
        {
            string nomProce = "addSaldosFinales";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("5692", cuenta5692),
                new Clase_Parametros("1719", cuenta1719),
                new Clase_Parametros("1466", cuenta1466),
                new Clase_Parametros("6999", cuenta6999),
                new Clase_Parametros("7991", cuenta7991),
                new Clase_Parametros("1037", cuenta1037),
                new Clase_Parametros("3489", cuenta3489),
                new Clase_Parametros("1050", cuenta1050),
                new Clase_Parametros("6502", cuenta6502),
                new Clase_Parametros("8992", cuenta8992),
                new Clase_Parametros("1408", cuenta1408)
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
        public bool ConsultaErroresBancarios(string fechaInicio, string fechaFin)
        {
            string nomProce = "ConsultaLogsErroresBancarios";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("FechaInicio", fechaInicio),
                new Clase_Parametros("FechaFin", fechaFin)
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
        public bool ConsultaSaldosFinales(string fecha)
        {
            string nomProce = "ConsultaSaldosFinales";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha", fecha)
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
        public bool ConsultaSucursales()
        {
            string nomProce = "ConsultaSucursales";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ComboMovimientosBancarios()
        {
            string nomProce = "comboMovimientosBancarios";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaBancos()
        {
            string nomProce = "ConsultaBancosCuentas";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaMovimientosBancarios(string fechaInicio, string fechaFin)
        {
            string nomProce = "ConsultaMovimientosBancarios";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("fechaInicio", fechaInicio),
                new Clase_Parametros("fechaFin", fechaFin)
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

        public bool AddMovimientosBancariosDetalles(string movBancario, string fecha, string monto, string campusEnviar, string campusRecibir, string bancoEnviar, string bancoRecibir, string cuentaEnviar, string cuentaRecibir, string notas)
        {
            string nomProce = "addMovimientosBancariosDetalles";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Mov_Bancario", movBancario),
                new Clase_Parametros("Fecha", fecha),
                new Clase_Parametros("Monto", monto),
                new Clase_Parametros("ID_Campus_Enviar", campusEnviar),
                new Clase_Parametros("ID_Banco_Enviar", bancoEnviar),
                new Clase_Parametros("Cuenta_Enviar", cuentaEnviar),
                new Clase_Parametros("ID_Campus_Recibir", campusRecibir),
                new Clase_Parametros("ID_Banco_Recibir", bancoRecibir),
                new Clase_Parametros("Cuenta_Recibir", cuentaRecibir),
                new Clase_Parametros("Notas", notas)
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
        public bool DelMovimientoBancarioDetalle(string movBancario)
        {
            string nomProce = "delMovimientoBancario";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("idMov", movBancario),
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
    public class Clase_Facturas : Clase_Conecta
    {
        #region Constructores
        public Clase_Facturas()
        {

        }
        #endregion
        #region Métodos

        

        public bool facturas_facturaCaja(string id_alumno)
        {
            string nomProce = "facturas_facturaCaja";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
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

        public bool ConsultaFacturasPorFecha(string ID_Campus, string FechaInicio, string FechaFin)
        {
            string nomProce = "consultaFacturasPorFecha";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("FechaInicio", FechaInicio),
                new Clase_Parametros("FechaFin", FechaFin)
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
        public bool ConceptosSATProdServ()
        {

            string nomProce = "ConsultaSATClaveProductoServicio";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GenerarFacturas(string id_alumno, string recibo, string tipo)
        {
            string nomProce = "GenerarFactura";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("recibo", recibo),
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
        public bool GetDatosRecibo(string recibo)
        {
            string nomProce = "getDatosRecibo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_campus", Clase_Sesion.Campus),
                new Clase_Parametros("recibo", recibo),

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

        public bool GetDatosReciboComp(string recibo, string campus = "0")
        {
            string nomProce = "getDatosReciboUUID";
            if (campus == "0")
            {
                campus = Clase_Sesion.Campus;
            }
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_campus", campus),
                new Clase_Parametros("recibo", recibo),

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

        public bool GenFacturas(string id_alumno, string recibo, string tipo)
        {
            string nomProce = "GenerarNota";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("recibo", recibo),
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
        public bool GenerarNotaLibreria(string id_alumno, string recibo, string tipo)
        {
            string nomProce = "GenerarNotaLibreria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_libro", id_alumno),
                new Clase_Parametros("Recibo", recibo),
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
        public bool DelNDnoTimbradoNC(string id_alumno, string recibo, string tipo)
        {
            string nomProce = "GenerarNota";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("recibo", recibo),
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
        public bool DelNDnoTimbrado(string id_alumno, string recibo, string tipo)
        {
            string nomProce = "GenerarNota";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("recibo", recibo),
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
        public bool GetDatosFacturasDifer(int id_alumno, double monto)
        {
            string nomProce = "getDatosFacturaDifer";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_factura", id_alumno.ToString()),
                new Clase_Parametros("monto", monto.ToString())
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


        public bool GetDatosFacturasIndep(int id_factura, double bruto, double neto)
        {
            string nomProce = "getDatosFacturaIndep";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_factura", id_factura.ToString()),
                new Clase_Parametros("bruto", bruto.ToString()),
                new Clase_Parametros("neto", neto.ToString()),
                new Clase_Parametros("id_campus", Clase_Sesion.Campus)
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
        public bool GetDatosComplementoPago()
        {
            string nomProce = "getDatosComplementoPago";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_campus", Clase_Sesion.Campus)
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

        public bool GenerarFacturasGenerica(string Fecha1, string Fecha2, string campus)
        {
            string nomProce = "GenerarFacturaGenerica";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Fecha1", Fecha1),
                new Clase_Parametros("Fecha2", Fecha2),
                new Clase_Parametros("ID_Campus",campus)
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

        public bool ConsultaFacturasDifer(string id_alumno)
        {
            string nomProce = "ConsultaFacturaDifer";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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

        public bool ConsultaFacturasDiferDatos(string id_alumno, string recibo)
        {
            string nomProce = "ConsultaFacturaDiferDatos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", id_alumno),
                new Clase_Parametros("Recibo", recibo)
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

        public bool ConsultaFacturas(string id_alumno, string recibo)
        {
            string nomProce = "ConsultaFactura";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", id_alumno),
                new Clase_Parametros("Recibo", recibo)
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
        public bool ConsultaFacturasGenerica(string Fecha1, string Fecha2, string id_campus)
        {
            string nomProce = "ConsultaFacturaGenerica";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha1", Fecha1),
                new Clase_Parametros("Fecha2", Fecha2),
                new Clase_Parametros("id_campus", id_campus)
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
        public bool ConsultaFacturasGenericasuma(string Fecha1, string Fecha2, string id_campus)
        {
            string nomProce = "ConsultaFacturaGenericaSuma";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha1", Fecha1),
                new Clase_Parametros("Fecha2", Fecha2),
                new Clase_Parametros("id_campus", id_campus)
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
        public bool DeleteNoFactura(string id_alumno, string recibo)
        {
            string nomProce = "DeleteFacturaNogenerada";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

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
        public bool DeleteFacturasGenerica(string Fecha1, string Fecha2, string id_campus)
        {
            string nomProce = "DeleteFacturaNoGenerica";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Fecha1", Fecha1),
                new Clase_Parametros("Fecha2", Fecha2),
                new Clase_Parametros("id_campus", id_campus)
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

        public bool ConsultaFacturaIndependienteDiferida(string uuid)
        {
            string nomProce = "ConsultaFacturaIndependienteDiferida";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("UUID", uuid)
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
        public bool UpFacturaIndependienteDiferida(string uuid, string insuto, string olduuid, string SaldoAnterior, string pagado)
        {
            string nomProce = "UpFacturaIndependienteDiferida";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("UUID", uuid),
                new Clase_Parametros("Insoluto", insuto),
                new Clase_Parametros("olduuid", olduuid),
                new Clase_Parametros("SaldoAnterior", SaldoAnterior),
                new Clase_Parametros("pagado", pagado)
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
}
