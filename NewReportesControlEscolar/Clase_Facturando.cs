using HyperSoft.ElectronicDocument.CfdiData;
using HyperSoft.ElectronicDocument.Download.Data;
using HyperSoft.ElectronicDocument.Download.Parameters;
using HyperSoft.ElectronicDocument.Printer;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Certificate;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.ECodex;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.ElectronicDocumentLibrary.StatusCfdi;
using HyperSoft.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperSoft.ElectronicDocument.Validator;
using HyperSoft.ElectronicDocument.Validator.Sat; 
using HyperSoft.ElectronicDocument.Validator.Sat.FindCfdi;

namespace ProyectoLoboSostenido
{
    public class Clase_Facturando
    {

        #region Variables Globales
#pragma warning restore CS0169 // El campo 'Clase_Facturando.bgwSat' nunca se usa
        private List<HyperSoft.ElectronicDocument.Download.Parameters.Complemento> complementos;
        private List<HyperSoft.ElectronicDocument.Download.Status> status;
        private readonly string RFC = "FEC920212PB9";
        private readonly string IdIntegrador = "034f6215-e07b-474a-8c1a-3c2c8b6b0495";
        private readonly string ClaveCiec = "LOBOS016";
        private Printer printer;
#pragma warning disable CS0649 // El campo 'Clase_Facturando.proveedor' nunca se asigna y siempre tendrá el valor predeterminado null
        private readonly Proveedor proveedor = new Proveedor().Initialization();
#pragma warning restore CS0649 // El campo 'Clase_Facturando.proveedor' nunca se asigna y siempre tendrá el valor predeterminado null
#pragma warning disable CS0169 // El campo 'Clase_Facturando.electronicDocument' nunca se usa
        //private readonly ElectronicDocument electronicDocument;
#pragma warning restore CS0169 // El campo 'Clase_Facturando.electronicDocument' nunca se usa
        public ElectronicManage manage;

        #endregion
        public Clase_Facturando() { }

        #region Licencias
        public void CargarLicenciaEDD()
        {
            // await Task.Delay(1000);
            if (HyperSoft.ElectronicDocument.Download.Activation.Activation.ActivationStatus.ToString() != "Licensed")
            {
                using (new HyperSoft.Shared.WaitCursor())
                {
                    string Licence = @"C:\LoboOne\LoboONE\LoboOne\Timbrado\ArchivosPDF\edd.license";
                    if (System.IO.File.Exists(Licence) == false)
                    {
                        HyperSoft.Shared.Gui.ShowError(string.Format("Estimado usuario:{0}{0}No es posible cargar la licencia porque no existe el archivo.{0}{0}{1}", Environment.NewLine, Licence));
                        return;
                    }
                    using (MemoryStream stream = new MemoryStream(System.IO.File.ReadAllBytes(Licence)))
                    {
                        HyperSoft.ElectronicDocument.Download.Activation.Activation.LoadLicense(stream);
                    }
                }

            }

            this.complementos = Enum.GetValues(typeof(HyperSoft.ElectronicDocument.Download.Parameters.Complemento)).Cast<HyperSoft.ElectronicDocument.Download.Parameters.Complemento>().ToList();
            this.status = Enum.GetValues(typeof(HyperSoft.ElectronicDocument.Download.Status)).Cast<HyperSoft.ElectronicDocument.Download.Status>().ToList();

        }
        public void CargarLicenciaEDR()
        {
            //    await Task.Delay(1000);
            if (HyperSoft.ElectronicDocument.Rename.Activation.Activation.ActivationStatus.ToString() != "Licensed")
            {
                using (new HyperSoft.Shared.WaitCursor())
                {
                    string Licence = @"C:\LoboOne\LoboONE\LoboOne\Timbrado\ArchivosPDF\edr.license";
                    if (System.IO.File.Exists(Licence) == false)
                    {
                        HyperSoft.Shared.Gui.ShowError(string.Format("Estimado usuario:{0}{0}No es posible cargar la licencia porque no existe el archivo.{0}{0}{1}", Environment.NewLine, Licence));
                        return;
                    }
                    using (MemoryStream stream = new MemoryStream(System.IO.File.ReadAllBytes(Licence)))
                    {
                        HyperSoft.ElectronicDocument.Rename.Activation.Activation.LoadLicense(stream);
                    }
                }
            }

        }
        public void CargarLicenciaEDP()
        {
            Thread threadEdd = new Thread(() => LeerLicenciaEdp()) { Priority = ThreadPriority.Highest };
            threadEdd.Start();
        }
        private static void LeerLicenciaEdp()
        {
            string LicenseEdp = @"C:\LoboOne\LoboONE\LoboOne\Timbrado\ArchivosPDF\edp.license";
            if (System.IO.File.Exists(LicenseEdp) == false)
                return;
            using (MemoryStream stream = new MemoryStream(System.IO.File.ReadAllBytes(LicenseEdp)))
                HyperSoft.ElectronicDocument.Printer.Activation.Activation.LoadActivationFile(stream);
            HyperSoft.ElectronicDocument.Printer.Activation.Data data = HyperSoft.ElectronicDocument.Printer.Activation.Activation.GetActivactionData();

            MessageBox.Show(HyperSoft.ElectronicDocument.Printer.Activation.Activation.ActivationStatus.ToString()+ " Vigencia: " +data.FechaInicioVigencia +" - "+ data.FechaVencimiento);
        }
        public void CargarLicenciaEDL()
        {
            Thread threadEdd = new Thread(() => LeerLicenciaEdl()) { Priority = ThreadPriority.Highest };
            threadEdd.Start();
        }
        public static void LeerLicenciaEdl()
        {
            string LicenseCfdiData = @"C:\LoboOne\LoboONE\LoboOne\Timbrado\ArchivosPDF\license.license";
            if (System.IO.File.Exists(LicenseCfdiData) == false)
                return;

            using (MemoryStream stream = new MemoryStream(System.IO.File.ReadAllBytes(LicenseCfdiData)))
            {
                HyperSoft.ElectronicDocumentLibrary.Activaction.LoadActivationFile(stream);
            }
        }
        public void CargarLicenciaEDV()
        {
            /*
            if (System.IO.File.Exists(@"C:\LoboOne\LoboONE\LoboOne\Timbrado\ArchivosPDF\edv.license") == false)
                return;

            using (MemoryStream stream = new MemoryStream(System.IO.File.ReadAllBytes(@"C:\LoboOne\LoboONE\LoboOne\Timbrado\ArchivosPDF\edv.license")))
                HyperSoft.ElectronicDocument.Validator.Activation.Activation.LoadActivationFile(stream);
            */
        }
        public void CargarCertificado()
        {
            try
            {
                while (HyperSoft.ElectronicDocumentLibrary.Activaction.ActivationStatus.ToString() != "Licensed")
                { }
                ElectronicCertificate certificate = new ElectronicCertificate();
                manage = new ElectronicManage().Initialization();
                certificate.Load(
                    @"C:\LoboOne\LoboOne\LoboONE\Field\00001000000505115757.cer",
                    @"C:\LoboOne\LoboOne\LoboONE\Field\CSD_UNIVERSIDAD_AUTONOMA_DE_DURANGO_FEC920212PB9_20200921_082151.key",
                    "LOBOS9202");

                manage.Save.AssignCertificate(certificate);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se cargo el Certificado.  " + e.Message);
            }
        }

        #endregion

        #region MetodosDescarga EDD *Utilizar UNICAMENTE en descargas masivas
        public string EjecutarDescarga(int tipo, string fecha, string fecha2)
        {
            string resultado = "Error en parametros";
            HyperSoft.ElectronicDocument.Download.Parameters.ByTime parameters = new HyperSoft.ElectronicDocument.Download.Parameters.ByTime();
            parameters.Integrador.Rfc = RFC;
            parameters.Integrador.Identificador = IdIntegrador;
            parameters.Login.Rfc = RFC;
            parameters.Login.Ciec = ClaveCiec;
            parameters.Tipo = tipo == 1 ? HyperSoft.ElectronicDocument.Download.Parameters.Tipo.Recibidos
                : HyperSoft.ElectronicDocument.Download.Parameters.Tipo.Emitidos;
            parameters.Process = HyperSoft.ElectronicDocument.Download.Parameters.Process.Descargar;
            parameters.FechaInicial = Convert.ToDateTime(fecha);
            parameters.FechaFinal = Convert.ToDateTime(fecha2);
            this.complementos = Enum.GetValues(typeof(HyperSoft.ElectronicDocument.Download.Parameters.Complemento)).Cast<HyperSoft.ElectronicDocument.Download.Parameters.Complemento>().ToList();
            this.status = Enum.GetValues(typeof(HyperSoft.ElectronicDocument.Download.Status)).Cast<HyperSoft.ElectronicDocument.Download.Status>().ToList();
            parameters.Complemento = this.complementos[0];
            parameters.Status = this.status[0];
            parameters.Total.MinValue = decimal.MinValue;
            parameters.Total.MaxValue = decimal.MaxValue;
            parameters.Download.Repository = DownloadRepository.Disk;
            if (parameters.Download.Repository == DownloadRepository.Disk)
            {
                parameters.Download.Edr = new HyperSoft.ElectronicDocument.Rename.Edr
                {
                    DirectoryBase = tipo == 1 ? @"\\189.197.190.214\Sistemas\Timbrado\xml\RECIBIDAS\FEC920212PB9" : @"\\189.197.190.214\Sistemas\Timbrado\xml\EMITIDAS\FEC920212PB9",
                    DirectoryStructure = tipo == 1 ? @"[AÑO_DOCUMENTO]\[MES_DOCUMENTO]\[DIA_DOCUMENTO]" : @"[AÑO_DOCUMENTO]\[MES_DOCUMENTO]\\[DIA_DOCUMENTO]\[TIPO_COMPROBANTE]",
                    FileStructure = "[UUID].xml",
                    OverwriteFile = true,
                    PrettyPrintXml = true
                };
            }
            HyperSoft.ElectronicDocument.Download.Edd edd = new HyperSoft.ElectronicDocument.Download.Edd();
            HyperSoft.ElectronicDocument.Download.Resumen.Result result = edd.Execute(parameters);
            if (result.Error.Type != HyperSoft.ElectronicDocument.Download.ErrorType.NONE)
            {
                resultado = "Error: " + HyperSoft.ElectronicDocument.Download.Progress.Download.Error;
            }
            else
            {
                resultado = "Encontrados: " + HyperSoft.ElectronicDocument.Download.Progress.Query.Encontrados;
                if (tipo == 1)
                {
                    string[] files;
                    int anio, mes, dia;
                    DateTime fecha1 = Convert.ToDateTime(fecha);
                    anio = fecha1.Year;
                    mes = fecha1.Month;
                    dia = fecha1.Day;
                    files = System.IO.Directory.GetFiles(@"\\189.197.190.214\Sistemas\Timbrado\xml\RECIBIDAS\FEC920212PB9\" + Convert.ToString(anio) + @"\" +
                            (mes < 10 ? "0" + Convert.ToString(mes) : Convert.ToString(mes)) + @"\" +
                        (dia < 10 ? "0" + Convert.ToString(dia) : Convert.ToString(dia))
                        );
                    System.IO.Directory.CreateDirectory(@"\\10.11.10.10\c\BovedaCFDI\" + Convert.ToString(anio) + @"\" +
                            (mes < 10 ? "0" + Convert.ToString(mes) : Convert.ToString(mes)) + @"\" +
                        (dia < 10 ? "0" + Convert.ToString(dia) : Convert.ToString(dia))
                        );
                    foreach (string s in files)
                    {
                        string fileName = System.IO.Path.GetFileName(s);
                        System.IO.File.Copy(s, @"\\10.11.10.10\c\BovedaCFDI\" + Convert.ToString(anio) + @"\" +
                            (mes < 10 ? "0" + Convert.ToString(mes) : Convert.ToString(mes)) + @"\" +
                        (dia < 10 ? "0" + Convert.ToString(dia) : Convert.ToString(dia))
                        + "\\" + fileName, true);
                    }
                    foreach (Cfdi comprobante in result.Cfdi)
                    {
                        switch (comprobante.Status)
                        {
                            case HyperSoft.ElectronicDocument.Download.Data.Status.Vigente:
                                {
                                    Clase_Contabilidad Cancelado = new Clase_Contabilidad();
                                    Cancelado.Insert_XML_Recibos_Cancelados(comprobante.Uuid, "Si", comprobante.RfcEmisor, comprobante.RazonSocialEmisor, comprobante.FechaEmision.ToShortDateString(), comprobante.FechaCertificacion.ToShortDateString(), comprobante.Total.ToString(), "Vigente", comprobante.FechaCancelacion.ToString());
                                }
                                break;
                            case HyperSoft.ElectronicDocument.Download.Data.Status.Cancelado:
                                {
                                    Clase_Contabilidad Cancelado = new Clase_Contabilidad();
                                    Cancelado.Insert_XML_Recibos_Cancelados(comprobante.Uuid, "No", comprobante.RfcEmisor, comprobante.RazonSocialEmisor, comprobante.FechaEmision.ToShortDateString(), comprobante.FechaCertificacion.ToShortDateString(), comprobante.Total.ToString(), "Cancelado", comprobante.FechaCancelacion.ToString());
                                }
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                    Clase_Contabilidad uno = new Clase_Contabilidad();
                    uno.XML_Recibidos_Archivos_Informacion(fecha1.Year.ToString("0000"), fecha1.Month.ToString("00"), fecha1.Day.ToString("00"));
                    Clase_Contabilidad dos = new Clase_Contabilidad();
                    dos.XML_Recibidos_Archivos_Conceptos(fecha1.Year.ToString("0000"), fecha1.Month.ToString("00"), fecha1.Day.ToString("00"));
                    Clase_Contabilidad tres = new Clase_Contabilidad();
                    tres.XML_Recibidos_Archivos_Impuestos(fecha1.Year.ToString("0000"), fecha1.Month.ToString("00"), fecha1.Day.ToString("00"));
                    Clase_Contabilidad cuatro = new Clase_Contabilidad();
                    cuatro.XML_Recibidos_Archivos_Impuestos_Retenidos(fecha1.Year.ToString("0000"), fecha1.Month.ToString("00"), fecha1.Day.ToString("00"));
                }
            }
            return resultado;
        }
        public bool DescargaPorUUID(string[] uuid)
        {
            string resultado = "Error en parametros";
            HyperSoft.ElectronicDocument.Download.Parameters.ByUuid parameters = new HyperSoft.ElectronicDocument.Download.Parameters.ByUuid();
            parameters.Integrador.Rfc = RFC;
            parameters.Integrador.Identificador = IdIntegrador;
            parameters.Login.Rfc = RFC;
            parameters.Login.Ciec = ClaveCiec;
            parameters.Tipo = HyperSoft.ElectronicDocument.Download.Parameters.Tipo.Recibidos;
            parameters.Process = HyperSoft.ElectronicDocument.Download.Parameters.Process.Descargar;
            foreach (string t in uuid)
            {
                parameters.Uuid.Add(t);
            }

            parameters.Download.Repository = DownloadRepository.Disk;

            parameters.Download.Edr = new HyperSoft.ElectronicDocument.Rename.Edr
            {
                DirectoryBase = @"LoboOne\",
                DirectoryStructure = @"[AÑO_DOCUMENTO]\[MES_DOCUMENTO]\[DIA_DOCUMENTO]",
                FileStructure = "[UUID].xml",
                OverwriteFile = true,
                PrettyPrintXml = true
            };

            HyperSoft.ElectronicDocument.Download.Edd edd = new HyperSoft.ElectronicDocument.Download.Edd();
            HyperSoft.ElectronicDocument.Download.Resumen.Result result = edd.Execute(parameters);

            MostrarCfdiConsulta(result.Cfdi);

            if (result.Error.Type != HyperSoft.ElectronicDocument.Download.ErrorType.NONE)
            {
                resultado = "Error: " + HyperSoft.ElectronicDocument.Download.Progress.Download.Error;
                return false;
            }
            else
            {
                resultado = "Encontrados: " + HyperSoft.ElectronicDocument.Download.Progress.Query.Encontrados;
                return true;
            }

        }
        public string EjecutarConsulta(int tipo, string fecha, string fecha2)//tipo 1: recibidos
        {
            string resultado = "Error en parametros";
            HyperSoft.ElectronicDocument.Download.Parameters.ByTime parameters = new HyperSoft.ElectronicDocument.Download.Parameters.ByTime();
            parameters.Integrador.Rfc = RFC;
            parameters.Integrador.Identificador = IdIntegrador;
            parameters.Login.Rfc = RFC;
            parameters.Login.Ciec = ClaveCiec;
            parameters.Tipo = tipo == 1 ? HyperSoft.ElectronicDocument.Download.Parameters.Tipo.Recibidos
                : HyperSoft.ElectronicDocument.Download.Parameters.Tipo.Emitidos;
            parameters.Process = HyperSoft.ElectronicDocument.Download.Parameters.Process.Consultar;
            parameters.FechaInicial = Convert.ToDateTime(fecha);
            parameters.FechaFinal = Convert.ToDateTime(fecha2);
            this.complementos = Enum.GetValues(typeof(HyperSoft.ElectronicDocument.Download.Parameters.Complemento)).Cast<HyperSoft.ElectronicDocument.Download.Parameters.Complemento>().ToList();
            this.status = Enum.GetValues(typeof(HyperSoft.ElectronicDocument.Download.Status)).Cast<HyperSoft.ElectronicDocument.Download.Status>().ToList();
            parameters.Complemento = this.complementos[0];
            parameters.Status = this.status[0];
            parameters.Total.MinValue = decimal.MinValue;
            parameters.Total.MaxValue = decimal.MaxValue;
            /* parameters.Download.Repository = DownloadRepository.Disk;
             if (parameters.Download.Repository == DownloadRepository.Disk)
             {
                 parameters.Download.Edr = new HyperSoft.ElectronicDocument.Rename.Edr
                 {
                     DirectoryBase = tipo == 1 ? @"\\189.197.190.214\Sistemas\Timbrado\xml\RECIBIDAS\FEC920212PB9" : @"\\189.197.190.214\Sistemas\Timbrado\xml\EMITIDAS\FEC920212PB9",
                     DirectoryStructure = tipo == 1 ? @"[AÑO_DOCUMENTO]\[MES_DOCUMENTO]\[DIA_DOCUMENTO]" : @"[AÑO_DOCUMENTO]\[MES_DOCUMENTO]\\[DIA_DOCUMENTO]\[TIPO_COMPROBANTE]",
                     FileStructure = "[UUID].xml",
                     OverwriteFile = true,
                     PrettyPrintXml = true
                 };
             }*/
            HyperSoft.ElectronicDocument.Download.Edd edd = new HyperSoft.ElectronicDocument.Download.Edd();
            HyperSoft.ElectronicDocument.Download.Resumen.Result result = edd.Execute(parameters);
            if (result.Error.Type != HyperSoft.ElectronicDocument.Download.ErrorType.NONE)
            {
                resultado = "Error: " + HyperSoft.ElectronicDocument.Download.Progress.Download.Error;
            }
            else
            {
                resultado = "Encontrados: " + HyperSoft.ElectronicDocument.Download.Progress.Query.Encontrados;
                if (tipo == 1)
                {
                    string[] files;
                    int anio, mes, dia;
                    DateTime fecha1 = Convert.ToDateTime(fecha);
                    anio = fecha1.Year;
                    mes = fecha1.Month;
                    dia = fecha1.Day;
                    files = System.IO.Directory.GetFiles(@"\\189.197.190.214\Sistemas\Timbrado\xml\RECIBIDAS\FEC920212PB9\" + Convert.ToString(anio) + @"\" +
                            (mes < 10 ? "0" + Convert.ToString(mes) : Convert.ToString(mes)) + @"\" +
                        (dia < 10 ? "0" + Convert.ToString(dia) : Convert.ToString(dia))
                        );
                    System.IO.Directory.CreateDirectory(@"\\10.11.10.10\c\BovedaCFDI\" + Convert.ToString(anio) + @"\" +
                            (mes < 10 ? "0" + Convert.ToString(mes) : Convert.ToString(mes)) + @"\" +
                        (dia < 10 ? "0" + Convert.ToString(dia) : Convert.ToString(dia))
                        );
                    foreach (string s in files)
                    {
                        string fileName = System.IO.Path.GetFileName(s);
                        System.IO.File.Copy(s, @"\\10.11.10.10\c\BovedaCFDI\" + Convert.ToString(anio) + @"\" +
                            (mes < 10 ? "0" + Convert.ToString(mes) : Convert.ToString(mes)) + @"\" +
                        (dia < 10 ? "0" + Convert.ToString(dia) : Convert.ToString(dia))
                        + "\\" + fileName, true);
                    }
                    foreach (Cfdi comprobante in result.Cfdi)
                    {
                        switch (comprobante.Status)
                        {
                            case HyperSoft.ElectronicDocument.Download.Data.Status.Vigente:
                                {
                                    Clase_Contabilidad Cancelado = new Clase_Contabilidad();
                                    Cancelado.Insert_XML_Recibos_Cancelados(comprobante.Uuid, "No", comprobante.RfcEmisor, comprobante.RazonSocialEmisor, comprobante.FechaEmision.ToShortDateString(), comprobante.FechaCertificacion.ToShortDateString(), comprobante.Total.ToString(), "Vigente", comprobante.FechaCancelacion.ToString());
                                }
                                break;
                            case HyperSoft.ElectronicDocument.Download.Data.Status.Cancelado:
                                {
                                    Clase_Contabilidad Cancelado = new Clase_Contabilidad();
                                    Cancelado.Insert_XML_Recibos_Cancelados(comprobante.Uuid, "No", comprobante.RfcEmisor, comprobante.RazonSocialEmisor, comprobante.FechaEmision.ToShortDateString(), comprobante.FechaCertificacion.ToShortDateString(), comprobante.Total.ToString(), "Cancelado", comprobante.FechaCancelacion.ToString());
                                }
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                    /* Clase_Contabilidad uno = new Clase_Contabilidad();
                     uno.XML_Recibidos_Archivos_Informacion(fecha1.Year.ToString("0000"), fecha1.Month.ToString("00"), fecha1.Day.ToString("00"));
                     Clase_Contabilidad dos = new Clase_Contabilidad();
                     dos.XML_Recibidos_Archivos_Conceptos(fecha1.Year.ToString("0000"), fecha1.Month.ToString("00"), fecha1.Day.ToString("00"));
                     Clase_Contabilidad tres = new Clase_Contabilidad();
                     tres.XML_Recibidos_Archivos_Impuestos(fecha1.Year.ToString("0000"), fecha1.Month.ToString("00"), fecha1.Day.ToString("00"));
                     Clase_Contabilidad cuatro = new Clase_Contabilidad();
                     cuatro.XML_Recibidos_Archivos_Impuestos_Retenidos(fecha1.Year.ToString("0000"), fecha1.Month.ToString("00"), fecha1.Day.ToString("00"));*/
                }
            }
            return resultado;
        }
        public string ConsultaEmitidosPorFecha(DateTime fecha1, DateTime fecha2)
        {
            string resultado = "Error en parametros";
            HyperSoft.ElectronicDocument.Download.Parameters.ByTime parameters = new HyperSoft.ElectronicDocument.Download.Parameters.ByTime();
            parameters.Integrador.Rfc = RFC;
            parameters.Integrador.Identificador = IdIntegrador;
            parameters.Login.Rfc = RFC;
            parameters.Login.Ciec = ClaveCiec;
            parameters.Tipo = HyperSoft.ElectronicDocument.Download.Parameters.Tipo.Emitidos;


            parameters.Process = HyperSoft.ElectronicDocument.Download.Parameters.Process.Consultar;
            parameters.FechaInicial = fecha1;
            parameters.FechaFinal = fecha2;
            this.complementos = Enum.GetValues(typeof(HyperSoft.ElectronicDocument.Download.Parameters.Complemento)).Cast<HyperSoft.ElectronicDocument.Download.Parameters.Complemento>().ToList();
            this.status = Enum.GetValues(typeof(HyperSoft.ElectronicDocument.Download.Status)).Cast<HyperSoft.ElectronicDocument.Download.Status>().ToList();
            parameters.Complemento = Complemento.All;

            parameters.Status = this.status[0];
            parameters.Total.MinValue = decimal.MinValue;
            parameters.Total.MaxValue = decimal.MaxValue;


            HyperSoft.ElectronicDocument.Download.Edd edd = new HyperSoft.ElectronicDocument.Download.Edd();
            HyperSoft.ElectronicDocument.Download.Resumen.Result result = edd.Execute(parameters);
            if (result.Error.Type != HyperSoft.ElectronicDocument.Download.ErrorType.NONE)
            {
                resultado = "Error: " + HyperSoft.ElectronicDocument.Download.Progress.Download.Error;
            }
            else
            {
                resultado = "Encontrados: " + HyperSoft.ElectronicDocument.Download.Progress.Query.Encontrados;
                MostrarCfdiConsulta(result.Cfdi);
            }
            return resultado;
        }
        private void MostrarCfdiConsulta(IEnumerable<Cfdi> cfdis)
        {
            StringBuilder sb = new StringBuilder();
            Clase_Contabilidad aaa = new Clase_Contabilidad();
            foreach (Cfdi cfdi in cfdis)
            {
                aaa.InsertCFDIRev(cfdi);
            }

        }
        #endregion
        #region MetodosDescarga EDL.ECodex
        public bool DescargarCfdi(string uuid, string file)
        {

            ObtenerCfdiParameters parameters = new ObtenerCfdiParameters().Initialization();
            try
            {

                HyperSoft.ElectronicDocumentLibrary.ECodex.ObtenerCfdi.Informacion informacion = new HyperSoft.ElectronicDocumentLibrary.ECodex.ObtenerCfdi.Informacion().Initialization();

                parameters.Informacion = informacion;
                parameters.TestMode = false;
                parameters.Rfc.Value = "FEC920212PB9";
                parameters.Uuid.Value = uuid;
                parameters.IdTransaccion.Value = long.MaxValue;

                ProcessProviderResult result = this.proveedor.ObtenerCfdi(parameters);
                HyperSoft.Shared.Chronometer.Instance.Stop();


                // Se genera el XML
                string texto = this.FormatInformationObtenerCfdi(parameters.IdTransaccion.Value, informacion, result);

                string folder = file;
                while (folder[folder.Length - 1] != '\\')
                {
                    folder = folder.Remove(folder.Length - 1);
                }
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                if (System.IO.File.Exists(file))
                {
                    System.IO.File.Delete(file);
                    System.Threading.Thread.Sleep(1500);
                }
                FileStream fs2 = System.IO.File.Create(file);
                fs2.Close();
                Thread.Sleep(1500);

                System.IO.File.WriteAllText(file, informacion.Xml.Value);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error");
                return false;
            }
            finally
            {
                parameters.Dispose();
                HyperSoft.Shared.Chronometer.Instance.Stop();
            }

            return true;
        }
        public bool DescargarCfdi2(string uuid, string file)
        {


            ObtenerCfdiParameters parameters = new ObtenerCfdiParameters().Initialization();
            try
            {

                HyperSoft.ElectronicDocumentLibrary.ECodex.ObtenerCfdi.Informacion informacion = new HyperSoft.ElectronicDocumentLibrary.ECodex.ObtenerCfdi.Informacion().Initialization();

                parameters.Informacion = informacion;
                parameters.TestMode = false;
                parameters.Rfc.Value = "FEC920212PB9";
                parameters.Uuid.Value = uuid;
                parameters.IdTransaccion.Value = long.MaxValue;
                /*
                     HyperSoft.ElectronicDocument.Download.Edd edd = new HyperSoft.ElectronicDocument.Download.Edd();
            HyperSoft.ElectronicDocument.Download.Resumen.Result result = edd.Execute(parameters);
                 */
                ProcessProviderResult result = this.proveedor.ObtenerCfdi(parameters);
                HyperSoft.Shared.Chronometer.Instance.Stop();


                // Se genera el XML
                string texto = this.FormatInformationObtenerCfdi(parameters.IdTransaccion.Value, informacion, result);

                string folder = file;
                while (folder[folder.Length - 1] != '\\')
                {
                    folder = folder.Remove(folder.Length - 1);
                }
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                if (System.IO.File.Exists(file))
                {
                    System.IO.File.Delete(file);
                    System.Threading.Thread.Sleep(1500);
                }
                FileStream fs2 = System.IO.File.Create(file);
                fs2.Close();
                Thread.Sleep(1500);

                System.IO.File.WriteAllText(file, informacion.Xml.Value);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error");
                return false;
            }
            finally
            {
                parameters.Dispose();
                HyperSoft.Shared.Chronometer.Instance.Stop();
            }

            return true;
        }

        public bool DescargarCfdi3(string uuid, string file)
        {


            ObtenerCfdiParameters parameters = new ObtenerCfdiParameters().Initialization();
            try
            {

                HyperSoft.ElectronicDocumentLibrary.ECodex.ObtenerCfdi.Informacion informacion = new HyperSoft.ElectronicDocumentLibrary.ECodex.ObtenerCfdi.Informacion().Initialization();

                parameters.Informacion = informacion;
                parameters.TestMode = false;
                parameters.Rfc.Value = "FEC920212PB9";
                parameters.Uuid.Value = uuid;
                parameters.IdTransaccion.Value = long.MaxValue;


                /*
                     HyperSoft.ElectronicDocument.Download.Edd edd = new HyperSoft.ElectronicDocument.Download.Edd();
            HyperSoft.ElectronicDocument.Download.Resumen.Result result = edd.Execute(parameters);
                 */
                ProcessProviderResult result = this.proveedor.ObtenerCfdi(parameters);
                HyperSoft.Shared.Chronometer.Instance.Stop();


                // Se genera el XML
                string texto = this.FormatInformationObtenerCfdi(parameters.IdTransaccion.Value, informacion, result);

                string folder = file;
                while (folder[folder.Length - 1] != '\\')
                {
                    folder = folder.Remove(folder.Length - 1);
                }
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                if (System.IO.File.Exists(file))
                {
                    System.IO.File.Delete(file);
                    System.Threading.Thread.Sleep(1500);
                }
                FileStream fs2 = System.IO.File.Create(file);
                fs2.Close();
                Thread.Sleep(1500);

                System.IO.File.WriteAllText(file, informacion.Xml.Value);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error");
                return false;
            }
            finally
            {
                parameters.Dispose();
                HyperSoft.Shared.Chronometer.Instance.Stop();
            }

            return true;
        }
        private string FormatInformationObtenerCfdi(long idTransaccion, HyperSoft.ElectronicDocumentLibrary.ECodex.ObtenerCfdi.Informacion informacion, ProcessProviderResult providerResult)
        {
            StringBuilder text = new StringBuilder();

            if (informacion.Xml.IsAssigned)
            {
                text.AppendLine(string.Empty);
                text.AppendLine("INFORMACION");
                text.AppendLine("=================================================");
                text.AppendLine("Xml : " + informacion.Xml.Value);
            }

            if (idTransaccion != 0)
            {
                text.AppendLine(string.Empty);
                text.AppendLine("INFORMACION DE LA TRANSACCION");
                text.AppendLine("=================================================");
                text.AppendLine("Número de transacción         : " + idTransaccion);
            }

            if (!informacion.Error.IsAssigned)
            {
                return text.ToString();
            }

            this.FormatTypeError(text, providerResult);

            text.AppendLine("ERROR QUE SE GENERO EN EL PROCESO");
            text.AppendLine("=================================================");
            text.AppendLine("Número      : " + informacion.Error.Numero.Value);
            text.AppendLine("Descripción : " + informacion.Error.Descripcion.Value);

            return text.ToString();
        }
        private void FormatTypeError(StringBuilder text, ProcessProviderResult providerResult)
        {
            if (providerResult == ProcessProviderResult.Ok)
            {
                return;
            }

            text.AppendLine();
            text.AppendLine();
            text.AppendLine("=================================================");
            switch (providerResult)
            {
                case ProcessProviderResult.ErrorInDocument:
                    text.AppendLine("EL ERROR SE PRESENTO AL GENERAR LOS PARAMETROS,");
                    text.AppendLine("ANTES DE EJECUTAR LA OPERACION CON EL PAC.");
                    break;

                case ProcessProviderResult.ErrorWithProvider:
                    text.AppendLine("EL ERROR FUE GENERADO POR EL PAC.");
                    break;

                case ProcessProviderResult.ErrorInConnectionWithProvider:
                    text.AppendLine("EL ERROR SE PRESENTO AL CONTACTAR EL SERVIDOR DEL PAC.");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            text.AppendLine("=================================================");
            text.AppendLine();
            text.AppendLine();
        }
        #endregion
        #region MetodosPDF
        /// <summary>
        /// <param name="tipo">
        /// Tipo 0: CFDI
        /// Tipo 1: Nomina
        /// Tipo 2: Constancia
        /// Tipo 3: AcuseCancelacion
        /// </param>
        /// </summary>
        
       
        public bool GenerarPdf(out string fileName, string xml, string emp, string ruta, string rutaExt, int tipo, string campus, bool mostrar, int tipo2 = 0)
        {
            string fileMove = "";
            xml = xml.Replace('/', '\\');
            using (MemoryStream resultFile = new MemoryStream())
            {
                if (ValidarDllRequeridas())
                {
                    printer = new Printer();

                    if (tipo2 != 0)
                    {
                        AsignarFormatos(tipo2.ToString());
                    }
                    else
                    {
                        AsignarFormatos("3");

                    }
                    if (campus == "46")
                    {
                        AsignarLogo(@"C:\LoboOne\LoboONE\LoboOne\Timbrado\ArchivosPDF\ArenaLobos.png");
                    }
                    else
                    {
                        AsignarLogo(@"C:\LoboOne\LoboONE\LoboOne\Timbrado\ArchivosPDF\logoinstitucional.png");
                    }


                    Options options = SetParameters(tipo.ToString());

                    MemoryStream xmlFile = new MemoryStream(System.IO.File.ReadAllBytes(xml));
                    if (this.printer.Execute(xmlFile, options, resultFile) == false)
                    {

                        Chronometer.Instance.Stop();
                        fileName = string.Format("Se generó un error al crear la representación impresa.{0}{0}{1}", Environment.NewLine, string.Format("Número: {1}{0}Descripción: {2}", Environment.NewLine, printer.Error.Number, printer.Error.Description));
                        if (tipo2 == 0)
                        {
                            MessageBox.Show(fileName);
                        }
                        else
                        {
                            string error = string.Format("Número: {1}{0}Descripción: {2}", Environment.NewLine, printer.Error.Number, printer.Error.Description);
                            Gui.ShowError(string.Format("Se generó un error al crear la representación impresa.{0}{0}{1}", Environment.NewLine, error));

                        }
                        return false;
                    }
                    Chronometer.Instance.Stop();


                    fileName = emp + "." + options.PrintType.ToString().ToLower();
                    fileMove = Path.Combine(rutaExt, fileName);
                    fileName = Path.Combine(ruta, fileName);
                    //WriteAllBytes


                    System.IO.File.WriteAllBytes(fileName, resultFile.ToArray());

                    xmlFile.Close();

                    xmlFile.Dispose();

                    resultFile.Close();

                    resultFile.Dispose();
                }
                else
                {
                    fileName = "";
                    return false;
                }

            }

            if (fileName != fileMove)
            {

                System.IO.File.Copy(fileName, fileMove, true);


            }
            if (mostrar)
            {
                ShowFile(fileName);
            }
            return true;


        }
        private void TipoArchivoGenerar(Options options)
        {
            switch (0)
            {
                case 0:
                    options.PrintType = PrintType.Pdf;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        private Options SetParameters(string tipo)
        {
            // Creamos el objeto de los parámetros y el cual define el comportamiento de la librería.
            Options options = new Options
            {
                // Con esta línea establedemos que estamos trabajando con un comprobante (XML) de pruebas
                // *** ELIMINAR ESTA LÍNEA EN PRODUCION ***
                //Demo = true
                Stats = StatsType.None
            };
            options.Cfdi.PrintClaveProductoDescripcion = true;
            options.Cfdi.PrintClaveUnidadDescripcion = true;
            options.Cfdi.PrintDescription = true;
            options.Cfdi.PrintNumreroIdentificacion = true;
            options.Cfdi.PrintUnidad = true;
            // Asignamos el tipo de documento (XML) que estamos leyendo
            this.TipoDocumento(options, tipo); // *** Ver nota # 1 al final de este archivo ***

            // Indicamos el tipo de archivo a generar (PDF, PNG, HTML, etc).
            this.TipoArchivoGenerar(options); // *** Ver nota # 2 al final de este archivo ***

            // Con esta opción indicamos si se desea que se valide el XML antes de generar la
            // representación impresa.
            options.ValidateDocument = false; // *** Ver nota # 3 al final de este archivo ***

            // Con esta opción se generar el código de barras y se agregar a la
            // representación impresa
            options.QrCode = true; // *** Ver nota # 4 al final de este archivo ***

            // Por defecto la librería usa el texto de la moneda en el importe con letra,
            // si deseamos cambiarlo podemos usar este código.
            options.Money.Name = "pesos mexicanos";  // *** Ver nota # 5 al final de este archivo ***
            options.Money.ShortName = "M.N.";  // *** Ver nota # 5 al final de este archivo ***

            // A continuación podemos definir algunas características del archivo de salida
            // *** Ver nota # 6 al final de este archivo ***
            if (options.PrintType == PrintType.Pdf)
            {
                // Con esta opción el PDF generado será del menor tamaño posible
                // options.Pdf.Compressed = true;

                // Con este código las imágenes contenidas en el reporte se convierten a formato JPEG 
                // reduciendo el tamaño final del reporte.
                options.Pdf.ConvertImagesToJpeg = true;

                // Definimos la calidad de las imágenes
                this.CalidadImagen(options.Pdf);
                //options.Pdf.Security.OpenPassword = "lobos";

                options.Pdf.Security.Permissions.EnableCopying = true;
                // *** Ver nota # 10 al final de este archivo ***
                options.Pdf.Security.Permissions.ChangingPermissions = PdfChangingPermissions.None;
                options.Pdf.Security.Permissions.PermissionsPassword = true ? string.Empty : "password";

                // *** Ver nota # 11 al final de este archivo ***
                options.Pdf.Label.Title = "";
                options.Pdf.Label.Subject = "";
                options.Pdf.Label.Keywords = "";
                options.Pdf.Label.Creator = "";
            }
            if (options.DocumentType == DocumentType.Cfdi)
            {
                // Con esta opcción las series de una parte se imprimirán como series
                // del concepto
                options.Cfdi.JoinSerie = false; // *** Ver nota # 7 al final de este archivo ***

                // Definimos que los datos de la adenda NO estarán disponibles
                // para ser usados en la representación impresa
                options.Cfdi.DeleteAddenda = false;
            }

            this.DatosAdicionales(options);
            return options;
        }
        private void CalidadImagen(HyperSoft.ElectronicDocument.Printer.Export.Pdf.Options pdf)
        {
            switch (2)
            {
                case 2:
                    pdf.ImageQuality = ImageQualityType.Medium;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        private void DatosAdicionales(Options options)
        {
            options.Additional.Documento.Text1 = "";
            options.Additional.Documento.Text2 = "";
            options.Additional.Documento.Text3 = "";
            options.Additional.Documento.Text4 = "";
            options.Additional.Documento.Text5 = "";

            options.Additional.Emisor.Text1 = "";
            options.Additional.Emisor.Text2 = "";
            options.Additional.Emisor.Text3 = "";

            options.Additional.Receptor.Text1 = string.Empty;
            options.Additional.Receptor.Text2 = string.Empty;
            options.Additional.Receptor.Text3 = string.Empty;

            HyperSoft.ElectronicDocument.Printer.Concepto concepto = new HyperSoft.ElectronicDocument.Printer.Concepto
            {
                Index = 0,
                Text1 = "",
                Text2 = ""
            };

            options.Additional.Conceptos.Add(concepto);
        }
        private void AsignarFormatos(string tipo)
        {
            string message = string.Empty;

            // Leemos y asigamos el formato para el RECIBO DE NÓMINA
            if (tipo == "1")
            {
                byte[] file = System.IO.File.ReadAllBytes("C:\\LoboONE\\LoboONE\\LoboONE\\Timbrado\\ArchivosPDF\\Nomina12_Cfdi33.repx");
                using (MemoryStream stream = new MemoryStream(file))
                {
                    if (printer.SetFormat(stream, DocumentType.Nomina, "3.3-1.2") == false)
                    {
                        Gui.ShowError(string.Format("Se generó un error al asignar el formato: {1}{0}{0}", Environment.NewLine, printer.Error));
                    }
                }
            }
            // Leemos y asigamos el formato para el RECIBO DE NÓMINA
            if (tipo == "2")
            {
                byte[] file = System.IO.File.ReadAllBytes("C:\\LoboONE\\LoboONE\\LoboONE\\Timbrado\\ArchivosPDF\\Nomina12_Cfdi33_ASI.repx");
                using (MemoryStream stream = new MemoryStream(file))
                {
                    if (printer.SetFormat(stream, DocumentType.Nomina, "3.3-1.2") == false)
                    {
                        Gui.ShowError(string.Format("Se generó un error al asignar el formato: {1}{0}{0}", Environment.NewLine, printer.Error));
                    }
                }
            }
            if (tipo == "3")
            {
                //byte[] file = System.IO.File.ReadAllBytes("C:\\LoboONE\\LoboONE\\LoboONE\\Timbrado\\ArchivosPDF\\Cfdi33.repx");
                //using (MemoryStream stream = new MemoryStream(file))
                //{
                //    if (printer.SetFormat(stream, DocumentType.Cfdi, "3.3") == false)
                //    {
                //        Gui.ShowError(string.Format("Se generó un error al asignar el formato: {1}{0}{0}", Environment.NewLine, printer.Error));
                //    }
                //}

                byte[] file = System.IO.File.ReadAllBytes("C:\\LoboONE\\LoboONE\\LoboONE\\Timbrado\\ArchivosPDF\\Cfdi40.repx");
                using (MemoryStream stream = new MemoryStream(file))
                {
                    if (printer.SetFormat(stream, DocumentType.Cfdi, "4.0") == false)
                    {
                        Gui.ShowError(string.Format("Se generó un error al asignar el formato: {1}{0}{0}", Environment.NewLine, printer.Error));
                    }
                    else if (printer.SetFormat(stream, DocumentType.Cfdi, "3.3") == false)
                    {
                        Gui.ShowError(string.Format("Se generó un error al asignar el formato: {1}{0}{0}", Environment.NewLine, printer.Error));
                    }
                }
            }
            if (tipo == "4")
            {
                byte[] file = System.IO.File.ReadAllBytes("C:\\LoboONE\\LoboONE\\LoboONE\\Timbrado\\ArchivosPDF\\AcuseCancelacion.repx");
                using (MemoryStream stream = new MemoryStream(file))
                {
                    if (printer.SetFormat(stream, DocumentType.AcuseCancelacion, "3.3") == false)
                    {
                        Gui.ShowError(string.Format("Se generó un error al asignar el formato: {1}{0}{0}", Environment.NewLine, printer.Error));
                    }
                }
            }
            if (string.IsNullOrWhiteSpace(message) == false)
            {
                Gui.ShowError(string.Format("Se generó un error al asignar los formatos.{0}{0}{1}", Environment.NewLine, message));
            }
        }
        private bool ValidarDllRequeridas()
        {
            int count = 1;
            while (HyperSoft.ElectronicDocument.Printer.Activation.Activation.ActivationStatus.ToString() != "Licensed")
            {
#pragma warning disable CS4014 // Como esta llamada no es 'awaited', la ejecución del método actual continuará antes de que se complete la llamada. Puede aplicar el operador 'await' al resultado de la llamada.
                CargarLicenciaEDP();
#pragma warning restore CS4014 // Como esta llamada no es 'awaited', la ejecución del método actual continuará antes de que se complete la llamada. Puede aplicar el operador 'await' al resultado de la llamada.
                count++;
                if (count == 6)
                {
                    return false;

                }
                Thread.Sleep(5000);
            }


            string origin = Path.GetFullPath(@"LoboOne\Timbrado\ArchivosPDF\");
            string destination = @"LoboOne\Timbrado\Generados\";

            if (System.IO.File.Exists(@"LoboOne\Timbrado\ArchivosPDF\DevExpress.Data.v21.1.dll"))
            {
                return true;
            }
            else
            {
                string question =
                  "Para el correcto funcionamiento de este sistema es necesario que copie" + Environment.NewLine +
                  "los archivos que se encuentra en la carpeta DLL a la carpeta donde está" + Environment.NewLine +
                  "el ejecutable; este procedimiento también es requerido llevarlo a cabo" + Environment.NewLine +
                  "en su aplicación." + Environment.NewLine + Environment.NewLine +
                  "Origen:" + Environment.NewLine + origin + Environment.NewLine + Environment.NewLine +
                  "Destino:" + Environment.NewLine + destination + Environment.NewLine + Environment.NewLine +
                  "¿Desea que sean copiados estos archivos en este momento?";


                if (Gui.ShowQuestion(question) == false)
                {
                    return false;
                }

                CopyFolder(origin, destination, "*.dll");

                return true;
            }

        }
        private void AsignarLogo(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                printer.ClearLogo();
                Gui.ShowMessage("El logotipo ha sido limpiado, no saldra en la representacion impresa");
                return;
            }
            byte[] file = System.IO.File.ReadAllBytes(fileName);
            using (MemoryStream logoStream = new MemoryStream(file))
            {
                printer.SetLogo(logoStream);
            }
        }
        private void TipoDocumento(Options options, string tipo)
        {
            switch (tipo)
            {
                case "0":
                    options.DocumentType = DocumentType.Cfdi;
                    break;
                case "1":
                    options.DocumentType = DocumentType.Nomina;
                    break;
                case "2":
                    options.DocumentType = DocumentType.Nomina;
                    break;
                case "3":
                    options.DocumentType = DocumentType.Cfdi;
                    break;
                default:
                    options.DocumentType = DocumentType.Cfdi;
                    break;
            }
        }
        public void ShowFile(string fileName)
        {
            string message = string.Format("El archivo fue generado con éxito.{0}{0}{1}{0}{0}¿Desea abrir el archivo generado?", Environment.NewLine, fileName);
            if (Gui.ShowQuestion(message))
            {
                System.Diagnostics.Process.Start(Path.GetFullPath(fileName));
            }
        }
        private static void CopyFolder(string origin, string destination, string searchPattern)
        {
            System.IO.Directory.CreateDirectory(destination);

            string[] files = System.IO.Directory.GetFiles(origin, searchPattern);
            foreach (string file in files)
            {
                string fileName = System.IO.Path.GetFileName(file);
                if (System.IO.File.Exists(fileName) == false)
                {
                    System.IO.File.Copy(file, System.IO.Path.Combine(destination, fileName));
                }
            }
        }

        #endregion
        #region Validar XML
        public int statusProfe = 0;
        public string totalProfe = "0";
        public string fechaEmision = "";
        public void VerificarCfdiSat(string rfcEmisor, string recReceptor, string uuid, string total)
        {

            //using (HyperSoft.ElectronicDocument.Validator.SslValidator sslValidator = new HyperSoft.ElectronicDocument.Validator.SslValidator())
            //{
            //    sslValidator.Initialization();

            //    Sat sat = new Sat();
            //    HyperSoft.ElectronicDocument.Validator.Sat.FindCfdi.Result result;
            //    HyperSoft.ElectronicDocument.Validator.Sat.FindCfdi.Parameters parameters = new HyperSoft.ElectronicDocument.Validator.Sat.FindCfdi.Parameters();

            //    parameters.RfcEmisor = rfcEmisor;
            //    parameters.RfcReceptor = recReceptor;
            //    parameters.Uuid = uuid;
            //    parameters.Total = decimal.Parse(total);

            //    // Con esta línea realizamos la consulta
            //    HyperSoft.ElectronicDocument.Validator.Sat.ProcessResult processResult = sat.FindCfdi(parameters, out result);

            //    // Detenemos el cronómetro que mide el tiempo que toma hacer el proceso
            //    Chronometer.Instance.Stop();


            //    // Mostrar el resultado en pantalla
            //    string resul = this.MostrarResultado(processResult, result);
            //    //MessageBox.Show(resul);
                statusProfe = 1;
                // Se genera el reporte (PDF) del SAT
                //if ((processResult == ProcessResult.Ok) && 
                //    (result.Status == HyperSoft.ElectronicDocument.Validator.SatStatusType.Active || result.Status == HyperSoft.ElectronicDocument.Validator.SatStatusType.Canceled))
                //    this.GenerarReporteSat(result);
           // }

        }

        private string MostrarResultado(HyperSoft.ElectronicDocument.Validator.Sat.ProcessResult processResult, Result result)
        {
            
            // A continuacion se lee el resultado de la validación y se le da formato para mostrarlo
            // en la pantalla.
            StringBuilder sb = new StringBuilder();

            // Se muestra el resultado del proceso, no confundir con el resultado de la validación, 
            // el resultado que se muestra a continuación quiere decir si se pudo o no hacer la validación.

            sb.AppendLine("RESUMEN DEL PROCESO");

            switch (processResult)
            {
                case HyperSoft.ElectronicDocument.Validator.Sat.ProcessResult.Ok:
                    sb.AppendLine("El proceso fue ejecutado correctamente.");
                    statusProfe = 1;
                    break;

                case HyperSoft.ElectronicDocument.Validator.Sat.ProcessResult.ErrorInData:
                    sb.AppendLine("No pudo ser ejecutado el proceso porque existe un error en los datos proporcionados.");
                    break;

                
                case HyperSoft.ElectronicDocument.Validator.Sat.ProcessResult.ErrorWithProvider:
                    sb.AppendLine("El servidor ha retorando un error.");
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(processResult), processResult, null);
            }

            // Si se generó un error en el proceso lo mostramos
            if (processResult != HyperSoft.ElectronicDocument.Validator.Sat.ProcessResult.Ok)
            {
                sb.AppendLine("ERROR");
                sb.AppendLine("Descripción " + result.ErrorDescription);

                return sb.ToString();
            }

            // Se muestra el resultado de la validación
            sb.AppendLine(string.IsNullOrEmpty(result.RazonSocialEmisor)
              ? "CFDI EN EL SAT - USANDO WEB SERVICE DEL SAT"
              : "CFDI EN EL SAT");


            switch (result.Status)
            {
                case HyperSoft.ElectronicDocument.Validator.SatStatusType.UnKnow:
                    sb.AppendLine("STATUS                    : Desconocido, esto es, se generó un error al tratar de conectarse con el SAT");
                    break;

                case HyperSoft.ElectronicDocument.Validator.SatStatusType.NotFound:
                    sb.AppendLine("STATUS                    : No esta registrado el CFDI en el SAT");
                    break;

                case HyperSoft.ElectronicDocument.Validator.SatStatusType.Active:
                    sb.AppendLine("STATUS                    : El CFDI esta registrado en el SAT y se encuentra activo.");
                    break;

                case HyperSoft.ElectronicDocument.Validator.SatStatusType.Canceled:
                    sb.AppendLine("STATUS                    : El CFDI esta registrado en el SAT y se encuentra CANCELADO.");
                    sb.AppendLine("Fecha de cancelación     " + result.FechaCancelacion);

                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            switch (result.StatusCancelacion)
            {
                case HyperSoft.ElectronicDocument.Validator.StatusCancelacionType.UnKnow:
                    sb.AppendLine("STATUS DE LA CANCELACION  : ");
                    break;

                case HyperSoft.ElectronicDocument.Validator.StatusCancelacionType.NoCancelable:
                    sb.AppendLine("STATUS DE LA CANCELACION  : No cancelable");
                    statusProfe = 1;

                    break;

                case HyperSoft.ElectronicDocument.Validator.StatusCancelacionType.CancelableSinAceptacion:
                    sb.AppendLine("STATUS DE LA CANCELACION  : Cancelable sin aceptación");
                    statusProfe = 1;

                    break;

                case HyperSoft.ElectronicDocument.Validator.StatusCancelacionType.CancelableConAceptacion:
                    sb.AppendLine("STATUS DE LA CANCELACION  : Cancelable con aceptación");
                    statusProfe = 1;

                    break;

                case HyperSoft.ElectronicDocument.Validator.StatusCancelacionType.EnProceso:
                    sb.AppendLine("STATUS DE LA CANCELACION  : En proceso");
                    break;

                case HyperSoft.ElectronicDocument.Validator.StatusCancelacionType.SolicitudRechazada:
                    sb.AppendLine("STATUS DE LA CANCELACION  : Solicitud rechazada");
                    break;

                case HyperSoft.ElectronicDocument.Validator.StatusCancelacionType.CanceladoPlazoVencido:
                    sb.AppendLine("STATUS DE LA CANCELACION  : Cancelado plazo vencido");
                    break;

                case HyperSoft.ElectronicDocument.Validator.StatusCancelacionType.CanceladoConAceptacion:
                    sb.AppendLine("STATUS DE LA CANCELACION  : Cancelado con aceptación");
                    break;

                case HyperSoft.ElectronicDocument.Validator.StatusCancelacionType.CanceladoSinAceptacion:
                    sb.AppendLine("STATUS DE LA CANCELACION  : Cancelado sin aceptación");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (string.IsNullOrEmpty(result.RazonSocialEmisor))
                return sb.ToString();

            // Datos obtenidos del servidor del SAT
            sb.AppendLine("");
            sb.AppendLine("RFC del emisor           " + result.RfcEmisor);
            sb.AppendLine("Razón social del emisor  " + result.RazonSocialEmisor);
            sb.AppendLine("RFC del receptor         " + result.RfcReceptor);
            sb.AppendLine("Razón social del receptor" + result.RazonSocialReceptor);
            sb.AppendLine("Folio fiscal             " + result.Uuid);
            sb.AppendLine("Fecha de expedición      " + result.FechaEmision);
            sb.AppendLine("Fecha de certificación   " + result.FechaCertificacion);
            sb.AppendLine("PAC                      " + result.RfcPac);
            sb.AppendLine("Total                    " + result.Total);
            sb.AppendLine("Efecto                   " + result.Efecto);

            totalProfe = result.Total.ToString();
            fechaEmision = result.FechaEmision.ToString();


            return sb.ToString();
        }


        #endregion
    }


    public class Clase_Facturacion : Clase_Conecta
    {
        public Clase_Facturacion() { }

        public bool facturas_getAlumno(string id_alumno)
        {
            string nomProce = "facturas_getAlumno";
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

        public List<string> descargarXML(string fechaini, string fechafin, string id_Campus)
        {
            List<string> noDescargados = new List<string>();
            Clase_Facturando facturar = Clase_Sesion.licencias;
            facturas_periodo(id_Campus, fechaini, fechafin);

            for (int j = 0; j < this.Lector.Tables[0].Rows.Count; j++)
            {
                //Parameters parameters2 = new Parameters
                //{
                //    RfcEmisor = "FEC920212PB9",

                //    Uuid = this.Lector.Tables[0].Rows[j][1].ToString()

                //};
                //parameters2.ValidBeforeExecute = false;
                //HyperSoft.ElectronicDocumentLibrary.StatusCfdi.Information information2;
                //// Ejecutamos la consulta
                //StatusCfdi statusCfdi = new StatusCfdi();
                //ProcessProviderResult result = statusCfdi.Execute(parameters2, out information2);

                //if (information2.Status == SatStatusType.Active)
                //{
                if (!facturar.DescargarCfdi2(this.Lector.Tables[0].Rows[j][1].ToString(), @"C:\LoboONE\Facturas\" + fechaini.Replace('/', '-') + " al " + fechafin.Replace('/', '-') + @"\" + this.Lector.Tables[0].Rows[j][0].ToString() +
                @"\" + this.Lector.Tables[0].Rows[j][2].ToString() + "-" + this.Lector.Tables[0].Rows[j][1].ToString() + ".xml"))
                {

                    noDescargados.Add(this.Lector.Tables[0].Rows[j][1].ToString());
                }
                //}
                //else
                //{

                //    noDescargados.Add(this.Lector.Tables[0].Rows[j][1].ToString());
                //}

            }
            return noDescargados;
        }

        public bool facturas_periodo(string id_Campus, string fechaini, string fechaifn)
        {
            string nomProce = "getFacturasPeriodo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_Campus", id_Campus),
                new Clase_Parametros("fechaini", fechaini),
                new Clase_Parametros("fechafin", fechaifn),
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

}
