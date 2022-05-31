using HyperSoft.ElectronicDocument.Download.Data;
using System.Collections.Generic;

namespace ProyectoLoboSostenido
{
    public class Clase_Contabilidad : Clase_Conecta
    {
        #region Métodos
        public bool Consulta_XMLRecibidos(string uuid, string rfc, string razon, string date, string date2, string importe)
        {
            string nomProce = "Consulta_XMLRecibidos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("UUID",uuid),
                new Clase_Parametros("RFC_Emisor",rfc),
                new Clase_Parametros("Nombre_Emisor",razon),
                new Clase_Parametros("Fecha_Emision",date),
                new Clase_Parametros("Fecha_Emision2",date2),
                new Clase_Parametros("Importe",importe)
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
        public bool MigrarContpaq()
        {
            string nomProce = "CONTPAQ_MigrarXcampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_campus",Clase_Sesion.Campus)
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
        public bool Insert_XML_Recibos_Cancelados(string uuid, string descargado, string rfc_emisor, string nombre_emisor, string fecha_emision, string fecha_certificacion, string total, string estado, string fecha_cancelacion)
        {
            string nomProce = "XML_Recibos_General_Insert";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("UUID",uuid),
                new Clase_Parametros("DESCARGADO",descargado),
                new Clase_Parametros("RFC_EMISOR",rfc_emisor),
                new Clase_Parametros("NOMBRE_EMISOR",nombre_emisor),
                new Clase_Parametros("FECHA_EMISION",fecha_emision),
                new Clase_Parametros("FECHA_CERTIFICACION",fecha_certificacion),
                new Clase_Parametros("TOTAL",total),
                new Clase_Parametros("ESTADO",estado),
                new Clase_Parametros("FECHA_CANCELACION",fecha_cancelacion)
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
        public bool XML_Recibidos_Archivos_Conceptos(string anio, string mes, string dia)
        {
            string nomProce = "XML_Recibidos_Conceptos_Insert";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Anio",anio),
                new Clase_Parametros("Mes",mes),
                new Clase_Parametros("Dia",dia)
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
        public bool XML_Recibidos_Archivos_Impuestos(string anio, string mes, string dia)
        {
            string nomProce = "XML_Recibidos_Impuestos_Insert";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Anio",anio),
                new Clase_Parametros("Mes",mes),
                new Clase_Parametros("Dia",dia)
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
        public bool XML_Recibidos_Archivos_Impuestos_Retenidos(string anio, string mes, string dia)
        {
            string nomProce = "XML_Recibidos_Impuestos_Retenciones_Insert";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Anio",anio),
                new Clase_Parametros("Mes",mes),
                new Clase_Parametros("Dia",dia)
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
        public bool XML_Recibidos_Archivos_Informacion(string anio, string mes, string dia)
        {
            string nomProce = "XML_Recibidos_Insert";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Anio",anio),
                new Clase_Parametros("Mes",mes),
                new Clase_Parametros("Dia",dia)
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
        public bool ConsultaTransferencias(string campus)
        {
            string nomProce = "ConsultaTransferencias";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus",campus)
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
        public bool BuscaXMLRecibidos(string buscar)
        {
            string nomProce = "BuscaXMLRecibidos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Buscar",buscar)
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
        public bool BuscaXMLRelacionados(string transferencia)
        {
            string nomProce = "BuscaXMLRelacionados";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Transferencia",transferencia)
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
        public bool UpXMLRelacionados(string transferencia, string xmlRecibido, string relacionar)
        {
            string nomProce = "upXMLRelacionados";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Transferencia",transferencia),
                new Clase_Parametros("xmlRecibido",xmlRecibido),
                new Clase_Parametros("Relacionar",relacionar),
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
        public bool Inventario_ServiciosGralesConsultaReg(string ID_Campus)
        {
            string nomProce = "Inventario_ServiciosGralesConsultaReg";
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
        public bool Operaciones_Almacen(string ID_Campus, string Operacion, string id, string nombre, string rfc, string tipoT, string tipoO, string cuenta)
        {
            string nomProce = "Operaciones_Almacen";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus",ID_Campus),
                new Clase_Parametros("Operacion",Operacion),
                new Clase_Parametros("id",id),
                new Clase_Parametros("Descripcion",nombre),
                new Clase_Parametros("rfc",rfc),
                new Clase_Parametros("tipoT",tipoT),
                new Clase_Parametros("tipoO",tipoO),
                new Clase_Parametros("cuenta",cuenta)
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
        public bool Consulta_Proveedores(string Operacion, string id, string nombre, string rfc, string tipoT, string tipoO, string cuenta)
        {
            string nomProce = "Operaciones_Proveedores";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Operacion",Operacion),
                new Clase_Parametros("id",id),
                new Clase_Parametros("nombre",nombre),
                new Clase_Parametros("rfc",rfc),
                new Clase_Parametros("tipoT",tipoT),
                new Clase_Parametros("tipoO",tipoO),
                new Clase_Parametros("cuenta",cuenta)
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
        public bool Consulta_ProveedoresPago(string Operacion,string nombre,string Operacion2)
        {
            string nomProce = "GetContabilidadOrdenCompra";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Operacion",Operacion),

                new Clase_Parametros("nombre",nombre),
                new Clase_Parametros("Operacion2",Operacion2)
              
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
        public bool ConsultaComboTiposPliza(string ID_Campus)
        {
            string nomStore = "GetContabilidadTiposPoliza";
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
        public bool Proveedores_Up_Add(string Operacion, string id, string nombre, string rfc, string tipoT, string tipoO, string cuentaContable, string fecha_Constitucion,string nom_Notario,string num_Notario, string id_mun,string iD_Estado, string RegPubProp, string no_PoderNotarial, string CURPProv, string domicilioFiscal, string iD_Banco, string claveInterProv, string cuentaProv, string email,string regimenFiscal, string repLegal
            , string cdProv, string tel_Prov, string tit_Notario, string fecha_RPP, string no_RPP, string fecha_EscrituraPub, string id_Est_Notario, string id_Mun_Notario,string cd_Notario
            ,string titNotPoder,string nomNotPoder, string numNotPoder, string numRegNotPoder,string fecha_RegNotPoder,string idEstadoNotPoder,string id_MunicipioNotPoder, string id_cdNotPoder)
        {
            string nomProce = "Proveedores_Alta_Guardar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Operacion",Operacion),
                new Clase_Parametros("id",id),
                new Clase_Parametros("nombre",nombre),
                new Clase_Parametros("prov_rfc",rfc),
                new Clase_Parametros("tipotercero",tipoT),
                new Clase_Parametros("tipooperacion",tipoO),
                new Clase_Parametros("cuentaclabe",cuentaContable),
                new Clase_Parametros("Fecha_Constitucion",fecha_Constitucion),
                new Clase_Parametros("Nom_Notario",nom_Notario),
                new Clase_Parametros("Num_Notario",num_Notario),
                new Clase_Parametros("ID_Municipio",id_mun),
                new Clase_Parametros("ID_Estado",iD_Estado),
                new Clase_Parametros("RegistroPublicoPropiedad",RegPubProp),
                new Clase_Parametros("No_PoderNotarial",no_PoderNotarial),
                new Clase_Parametros("prov_CURP",CURPProv),
                new Clase_Parametros("DomicilioFiscal",domicilioFiscal),
                new Clase_Parametros("ID_Banco_Deposito",iD_Banco),
                new Clase_Parametros("prov_ClaveInterbancaria",claveInterProv),
                new Clase_Parametros("prov_Cuenta",cuentaProv),
                new Clase_Parametros("CorreoElectronico",email),
                new Clase_Parametros("RegimenFiscal",regimenFiscal),
                new Clase_Parametros("RepLegal",repLegal),

                new Clase_Parametros("Cd_Proveedor",cdProv),
                new Clase_Parametros("Tel_Prov",tel_Prov),
                new Clase_Parametros("Titulo_Notario",tit_Notario),
                new Clase_Parametros("FechaRegistroPublicoPropiedad",fecha_RPP),
                new Clase_Parametros("No_EscrituraPublica",no_RPP),
                new Clase_Parametros("Fecha_EscrituraPublica",fecha_EscrituraPub),
                new Clase_Parametros("ID_Estado_Notario",id_Est_Notario),
                new Clase_Parametros("ID_Municipio_Notario",id_Mun_Notario),
                new Clase_Parametros("Cd_Notario",cd_Notario),

                new Clase_Parametros("TitNotPoder",titNotPoder),
                new Clase_Parametros("NomNotPoder",nomNotPoder),
                new Clase_Parametros("NumNotPoder",numNotPoder),
                new Clase_Parametros("NumRegistroNotPoder",numRegNotPoder),
                new Clase_Parametros("FechaRegistroNotPoder",fecha_RegNotPoder),
                new Clase_Parametros("ID_EstNotPoder",idEstadoNotPoder),
                new Clase_Parametros("ID_MunNotPoder",id_MunicipioNotPoder),
                new Clase_Parametros("ID_CdNotPoder",id_cdNotPoder)


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
        public bool BuscaExpediente(string ID_Prov)
        {
            string nomProce = "BuscaExpedienteProveedor";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Proveedor", ID_Prov)
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

        public bool Proveedores_ConsultaDocumentos(string tipo)
        {
            string nomProce = "Proveedores_ConsultaDocumentos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Tipo", tipo)
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

        public bool Proveedores_ConsultaDocumentosElegido(string DocProv)
        {
            string nomProce = "Proveedores_ConsultaDocumentosElegido";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("DocProv", DocProv)
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
        public bool InsertEncabezadoPoliza(string Ejercicio, string Periodo, string ID_Tipo_Poliza, string Concepto,string Cargo,string Abono,string ID_Campus,string ID_orden)
        {
            string nomStore = "Contabilidad_Add_Encabezado_Poliza";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Ejercicio", Ejercicio),
                new Clase_Parametros("Periodo", Periodo),
                new Clase_Parametros("ID_Tipo_Poliza",ID_Tipo_Poliza),
                new Clase_Parametros("Concepto",Concepto),
                new Clase_Parametros("Cargo",Cargo),
                new Clase_Parametros("Abono",Abono),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado),
                new Clase_Parametros("ID_Campus",ID_Campus),
                new Clase_Parametros("orden",ID_orden)
                
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
        public bool Prov_Bancos()
        {
            string nomProce = "Proveedores_Bancos";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool InsertaDocumentos(string ID_Prov, string Documento, string Fechaentrega, string Ruta, string Observaciones)
        {
            string nomProce = "addProveedoresDocumentos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("IdPersona", ID_Prov),
                new Clase_Parametros("Documento", Documento),
                new Clase_Parametros("FechaEntregaDocumento", Fechaentrega),
                new Clase_Parametros("RutaDocumento", Ruta),
                new Clase_Parametros("ObservacionesDocumentos", Observaciones)
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

        public bool InsertCFDIRev(Cfdi cfdi)
        {
            string nomProce = "insertCFDIRev";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("UUID",cfdi.Uuid),
                new Clase_Parametros("rfc_receptor",cfdi.RfcReceptor),
                new Clase_Parametros("estado",cfdi.Status.ToString()),
                new Clase_Parametros("efecto",cfdi.Efecto.ToString()),
                new Clase_Parametros("fecha_cancelacion", cfdi.FechaCancelacion == null ? "" :  cfdi.FechaCancelacion.ToString()),/////////////////////////////
                new Clase_Parametros("fecha_certificacion",cfdi.FechaCertificacion.ToString()),
                new Clase_Parametros("fecha_emision",cfdi.FechaEmision.ToString()),
                new Clase_Parametros("folio",cfdi.Folio ?? ""),
                new Clase_Parametros("formapago",cfdi.FormaPago ?? ""),
                new Clase_Parametros("metodopago",cfdi.MetodoPago ?? ""),
                new Clase_Parametros("RazonSocialEmisor",cfdi.RazonSocialEmisor),
                new Clase_Parametros("Serie",cfdi.Serie ?? ""),
                new Clase_Parametros("Satus",cfdi.Status.ToString()),
                new Clase_Parametros("StatusCancelacion",cfdi.StatusCancelacion.ToString()),
                new Clase_Parametros("Subtotal",cfdi.SubTotal == null ? "0" : cfdi.SubTotal.ToString()),
                new Clase_Parametros("total",cfdi.Total.ToString()),
                new Clase_Parametros("totalimpuestosretenidos",cfdi.TotalImpuestosRetenidos == null ? "0" : cfdi.TotalImpuestosRetenidos.ToString()),
                new Clase_Parametros("totalimpuestostrasladados", cfdi.TotalImpuestosTrasladados == null ? "0" : cfdi.TotalImpuestosTrasladados.ToString())
             
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

        public bool Insert_Poliza_Encabezado(string ID_Campus, string ID_Nomina,string Tipo_Nomina, string NombreTipo, string Fecha, string TipoPol, string Folio, string Clase, string IdDiario, string Concepto, string SistOrig, string Impresa, string Ajuste, string GUID)
        {
            string nomProce = "Insert_Polizas_encabezado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("ID_Nomina", ID_Nomina),
                new Clase_Parametros("Tipo_Nomina", Tipo_Nomina),
                new Clase_Parametros("NombreTipo", NombreTipo),
                new Clase_Parametros("Fecha", Fecha),
                new Clase_Parametros("TipoPol", TipoPol),
                new Clase_Parametros("Folio", Folio),
                new Clase_Parametros("Clase", Clase),
                new Clase_Parametros("IdDiario", IdDiario),
                new Clase_Parametros("Concepto", Concepto),
                new Clase_Parametros("SistOrig", SistOrig),
                new Clase_Parametros("Impresa", Impresa),
                new Clase_Parametros("Ajuste", Ajuste),
                new Clase_Parametros("GUID", GUID)
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
        public bool Insert_Poliza_Movimiento(string ID_Poliza_Encabezado, string movtopoliza, string IdCuenta, string Referencia, string TipoMovto, string Importe, string IdDiario, string ImporteME, string Concepto, string IdSegNeg, string Guid)
        {
            string nomProce = "Insert_Poliza_Movimientos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Poliza_Encabezado", ID_Poliza_Encabezado),
                new Clase_Parametros("movtopoliza", movtopoliza),
                new Clase_Parametros("IdCuenta", IdCuenta),
                new Clase_Parametros("Referencia", Referencia),
                new Clase_Parametros("TipoMovto", TipoMovto),
                new Clase_Parametros("Importe", Importe),
                new Clase_Parametros("IdDiario", IdDiario),
                new Clase_Parametros("ImporteME", ImporteME),
                new Clase_Parametros("Concepto", Concepto),
                new Clase_Parametros("IdSegNeg", IdSegNeg),
                new Clase_Parametros("GUID", Guid)
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
        public bool Insert_Poliza_UUID(string ID_Poliza_Encabezado)
        {
            string nomProce = "Insert_polizas_UUID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID", ID_Poliza_Encabezado)
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
        public bool Consulta_Poliza_UUID(string ID_Poliza_Encabezado,string ID_M)
        {
            string nomProce = "Insert_Polizas_ConsultaUUID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID", ID_Poliza_Encabezado),
                new Clase_Parametros("ID_M", ID_M)
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
        public bool Consulta_Poliza_Movimientos(string ID_Poliza_Encabezado)
        {
            string nomProce = "Insert_Polizas_ConsultaMovimientos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID", ID_Poliza_Encabezado)
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
        public bool Consulta_Poliza_Encabezado(string ID_Poliza_Encabezado)
        {
            string nomProce = "Insert_Polizas_ConsultaEncabezado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID", ID_Poliza_Encabezado)
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
        public bool Consulta_Poliza_UUIDMasivo(string ID_Poliza_Encabezado)
        {
            string nomProce = "Insert_Poliza_MasivoUUID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID", ID_Poliza_Encabezado)
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
        
        public bool ConsultaFechaAutorizada()
        {
            string nomProce = "ConsultaFechaViatAutorizada";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_campus",Clase_Sesion.Campus)
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
