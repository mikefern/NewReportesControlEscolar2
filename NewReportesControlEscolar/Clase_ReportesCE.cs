using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FastReport; 
using FastReport.Utils;  
using System.IO;  
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

using CrystalDecisions.Windows.Forms;

namespace ProyectoLoboSostenido
{
    public class Clase_ReportesCE : Clase_Conecta
    {

        #region VARIABLES_INICIO

        #endregion

        public Clase_ReportesCE()
        {

        }

        //---------------------------------------------------------------------------------------------------------------------------
        #region FrmAdministrarParametrosRCE

        public bool MostrarParametros() 
        {
            string nomProce = "Reports_MostrarParametros";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ParametrosReportes(string tipo, string Id, string nombre, string valor) 
        {
            string nomStore = "Reports_DML_ParametrosFijosReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Tipo",tipo),
                new Clase_Parametros("Id_parametro",Id),
                new Clase_Parametros("Nombre",nombre),
                new Clase_Parametros("Valor",valor),
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
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------
        #region FrmDatosReportes

        public bool DetalleArchivoReporte(string opt, string id, string nombre, string extension, string ruta,  string ultimamodificacion, string creacion, string ultimoacceso,  string descripcionModificaciones, string id_Empleado,string peso)
        {

            string nomStore = "Reports_RegistroReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("Opt", opt),
                 new Clase_Parametros("ID",id),
                 new Clase_Parametros("NombreArchivo", nombre),
                 new Clase_Parametros("Extension",extension),
                 new Clase_Parametros("Ruta",ruta),
                 new Clase_Parametros("FechaUltimaModificacion",ultimamodificacion),
                 new Clase_Parametros("FechaCreacion",creacion),
                 new Clase_Parametros("FechaUltimoAcceso",ultimoacceso),
                 new Clase_Parametros("DescripcionModificaciones",descripcionModificaciones),
                 new Clase_Parametros("ID_Empleado",id_Empleado),
                 new Clase_Parametros("Peso",peso)
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

        //public bool GetRuta(string nombre)
        //{
        //    string nomStore = "GetRuta";
        //    List<Clase_Parametros> par = new List<Clase_Parametros>
        //    {
        //        new Clase_Parametros("NombreArchivo", nombre),
        //    };
        //    if (ConsultarParametros(nomStore, par))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool GetIDReporte(string nombre)
        {
            string nomStore = "GetIDReporte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("NombreArchivo", nombre),
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

        public bool GetNombreReporte()
        {
            string nomProce = "Reports_GetNombreReporte";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------
        #region RelacionParametrosReporte
        public bool AsignarParametros(string ID, string ID_Parametro)
        {
            string nomStore = "AsignarParametros";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Reporte",ID),
                new Clase_Parametros("ID_Parametro",ID_Parametro)
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
        public bool GetParametrosOK(string ID)
        {
            string nomStore = "GetParametrosOK";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID",ID)
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
        //----------------------------------------------------------------------------------------------------------------------------
        #region RelacionReportes

        public bool GetNombreReporteControl()
        {
            string nomProce = "GetNombreReporteControl";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IDRelacionado(string opt, string ID_Reporte, string ID_Archivo)
        {
            string nomStore = "GetIDRepRel";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Opt",opt),
                new Clase_Parametros("ID_Reporte",ID_Reporte),
                new Clase_Parametros("ID_Archivo",ID_Archivo)
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
        public bool GetIDRelacionado(string ID)
        {
            string nomStore = "GetIDReporteRel";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID",ID)
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
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmAgregarRestriccionesReportesRol

        public bool MostrarNodosRolCampus(string ID_Campus, string rol) 
        {
            string nomStore = "MostrarNodosRolCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", ID_Campus),
                new Clase_Parametros("Rol", rol)
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

        public bool GetRestriccionesUsuarioReportes(string ID)
        {
            string nomStore = "GetRestriccionesUsuarioReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_empleado",ID)
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

        public bool getRol(string id)
        {
            string nomStore = "getRolUsuario";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id",id)
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

        public bool LimpiarRestriccionesNodos(string id)
        {
            string nomStore = "LimpiarRestriccionesNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id",id)
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

        public bool Agregar_RestriccionReportesNodos(string id, string nodo)
        {
            string nomStore = "Agregar_RestriccionReportesNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id",id),
                new Clase_Parametros("nodo",nodo)
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

        public bool GetUsuarios(string Campus_ID)
        {
            string nomStore = "GetUsuariosResttriccionNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_Campus",Campus_ID)
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

        public bool GetCampus()
        {
            string nomStore = "GetCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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
        //---------------------------------------------------------------------------------------------------------------------------
        #region FrmReportesControlEscolar

        public bool OpcionesReporteControlEscolar(string ID_Campus, string rol, string Empleado)
        {
            string nomStore = "RPTGetNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", ID_Campus),
                new Clase_Parametros("Rol", rol),
                 new Clase_Parametros("Empleado", Empleado)
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

        public bool GetParametros_Reportes(string id)
        {
            string nomStore = "GetParmetros_Reportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_Reporte",id)
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

        public bool GetReportesconRVOE(string nodo, string campus)
        {
            string nomStore = "RptGetReportesconRVOE";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("nodo",nodo),
                new Clase_Parametros("campus",campus)
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

        public bool GetReporte(string nodo, string campus)
        {
            string nomStore = "GetReporte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("nodo",nodo),
                new Clase_Parametros("campus",campus)
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

        public bool GetReporteRVOE(string nodo, string campus, string rvoe)
        {
            string nomStore = "RPTGetReporteRVOE";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("nodo",nodo),
                new Clase_Parametros("campus",campus),
                new Clase_Parametros("rvoe",rvoe)
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

        public bool GetDetallesReporte(string reporte)
        {
            string nomStore = "GetDetallesReporte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("reporte",reporte)
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

        public bool GetPermisoRolReporteAbrir(string reporte, string rol, string campus)
        {
            string nomStore = "RptGetPermisoRolReporteAbrir";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("rol",rol),
                new Clase_Parametros("campus",campus)
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

        public bool RptGetRestriccionReporteEmpledo(string reporte, string empleado)
        {
            string nomStore = "RptGetRestriccionReporteEmpledo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("reporte",reporte),
                 new Clase_Parametros("empleado",empleado)
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
        //---------------------------------------------------------------------------------------------------------------------------
        #region FrmGestionNodos
        public bool LlenadoNodosReporteEscolar()
        {
            string nomStore = "Reports_GetNodos";
             
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updatepositionwhenInsert(string NodoPadre, string Nodo)
        {
            string nomProce = "Reports_OrdenamientoNodosW";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("NodoPadre", NodoPadre),
                new Clase_Parametros("Nodo", Nodo)
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
        public bool UpdatePosicionesNodos(string NodoPadre, string Nodo, string posicionOld, string posicionnew)
        {
            string nomProce = "Reports_OrdenamientoNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("NodoPadre", NodoPadre),
                new Clase_Parametros("Nodo", Nodo),
                new Clase_Parametros("PosicionViejo", posicionOld),
                new Clase_Parametros("PosicionNuevo", posicionnew)
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
        public bool DMLNodo(string tipo, string nodopadre, string texto)
        {
            string nomProce = "Reports_DMLNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Tipo", tipo),
                new Clase_Parametros("Nodo", nodopadre),
                new Clase_Parametros("Texto", texto)
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
        public bool GetCampusNodos(string nodo)
        {
            string nomStore = "RPTGetCampusNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("nodo",nodo),
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
        public bool AgregarPermisosverReportes(string CampusNodo, string campus)
        {
            string nomStore = "RPTInsertarCampusNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("CampusNodo",CampusNodo),
                new Clase_Parametros("campus",campus)
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
        public bool DeleteCampusNodos(string campus, string CampusNodo)
        {
            string nomStore = "RptDeleteCampusNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus",campus),
                new Clase_Parametros("CampusNodo",CampusNodo)
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
        public bool GetRolesCampusNodos(string campus, string CampusNodo)
        {
            string nomStore = "RPTGetRolesCampusNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("campus",campus),
                 new Clase_Parametros("CampusNodo",CampusNodo)
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
        public bool InsertarRolesCampusNodos(string campus, string CampusNodo, string rol)
        {
            string nomStore = "RPTInsertarRolesCampusNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus",campus),
                new Clase_Parametros("CampusNodo",CampusNodo),
               new Clase_Parametros("rol",rol)
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
        public bool DeleteRolesCampusNodos(string campus, string CampusNodo, string rol)
        {
            string nomStore = "RptDeleteRolesCampusNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus",campus),
                new Clase_Parametros("CampusNodo",CampusNodo),
                new Clase_Parametros("rol",rol)
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
        public bool IgualarPosicionNodo(string nodoPadre)
        {
            string nomStore = "Reports_IgualarPosicionNodo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("NodoPadre",nodoPadre) 
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
       

        #endregion
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmRPTPermisosRol

        public bool MostrarPermisosReportes()
        {
            string nomStore = "RptMostrarPermisosReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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
       
        public bool AgregarIndicePermisosReportes(string nombre)
        {
            string nomStore = "RPTAgregarIndicePermisosReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("nombre",nombre)
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

        public bool LimpiarPermisos(string rol, string campus)
        {
            string nomStore = "RPTLimpiarPermisos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("rol",rol),
                new Clase_Parametros("campus",campus)
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

        public bool AgregarPermisosverReportes(string permiso, string rol, string campus)
        {
            string nomStore = "RptAgregarPermisosverReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("permiso",permiso),
                new Clase_Parametros("rol",rol),
                new Clase_Parametros("campus",campus)
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

        public bool GetRoles()
        {
            string nomStore = "GetRoles";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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

        public bool GetPermisosRol(string rol, string campus)
        {
            string nomStore = "RptGetPermisosRol";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("rol",rol),
                 new Clase_Parametros("campus",campus)
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
        //---------------------------------------------------------------------------------------------------------------------------
        #region FrmAniadirEspecifiacionesReporte


        public bool GetCampusReportes(string idreporte)
        {
            string nomStore = "RptGetCampusReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("idreporte",idreporte)
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

        public bool MostrarRVOESCampusReportes(string campus)
        {
            string nomStore = "RptMostrarRVOECampusReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("campus",campus)
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

        public bool EliminarRelCampusReporte(string reporte, string campus)
        {
            string nomStore = "RptEliminarRelCampusReporte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("campus",campus)
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

        public bool AgregarRelCampusReporte(string reporte, string campus)
        {
            string nomStore = "RptAgregarRelCampusReporte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("campus",campus)
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

        public bool MostrarRelRolesReportes(string reporte, string campus)
        {
            string nomStore = "RptMostrarRelRolesReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("campus",campus)
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

        public bool GetRelRolesReportes(string reporte, string rol, string campus)
        {
            string nomStore = "RptGetRelRolesReporte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("rol",rol),
                new Clase_Parametros("campus",campus)

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

        public bool AgregarRelRolesReportes(string rol, string campus, string reporte)
        {
            string nomStore = "RptAgregarRelRolesReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("rol",rol),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("reporte", reporte)
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

        public bool EliminarRelRolesReportes(string rol, string campus, string reporte)
        {
            string nomStore = "RptEliminarRelRolesReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("rol",rol),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("reporte",reporte)
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

        public bool MostrarRVOECampusReporte(string reporte, string campus)
        {
            string nomStore = "RptMostrarRVOECampusReporte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("campus",campus)
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

        public bool AgregarRVOEReportes(string reporte, string RVOE)
        {
            string nomStore = "RptAgregarRVOEReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("RVOE", RVOE)
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

        public bool EliminarRVOEReportes(string reporte, string RVOE)
        {
            string nomStore = "RptEliminarRVOEReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("RVOE", RVOE)
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
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmEnlazarReportesNodos

        public bool GetReportesTodos()
        {
            string nomStore = "Reports_GetReportesTodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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

        public bool GetReportesNodo(string nodo)
        {
            string nomStore = "RptGetReportesNodo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("nodo",nodo)
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

        public bool GetNodoPadre(string nodo)
        {
            string nomStore = "RPTGetNodoPadre";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("nodo",nodo)
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

        public bool ActualizarNodoReporte(string nodo, string reporte)
        {
            string nomStore = "RptActualizarNodoReporte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("nodo",nodo),
                new Clase_Parametros("reporte",reporte)
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
        #endregion
        //-------------------------------------------------------------------------------------------------------------------
        #region FrmRestriccionesRolesReportes

        public bool GetRestriccionesReportesEmpleado(string empleado)
        {
            string nomStore = "RptGetRestriccionesReportesEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("empleado",empleado)
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
        public bool EliminarRestriccionesReportesEmpleado(string reporte, string usuario)
        {
            string nomStore = "RptEliminarRestriccionesReportesEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("empleado",usuario)
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

        public bool AgregarRestriccionesReportesEmpleado(string reporte, string empleado)
        {
            string nomStore = "RptAgregarRestriccionesReportesEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("empleado",empleado)
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
        #endregion
        //------------------------------------------------------------------------------------------------------------------
    }
     
    public class Reportes : Clase_Conecta
    {
        #region Constructores

        public Reportes()
        {
            if (Clase_Sesion.Rol == "16")
            {
                FastReport.EnvironmentSettings fsetting = new FastReport.EnvironmentSettings();
                fsetting.PreviewSettings.Buttons = PreviewButtons.All;

            }
            else if ((Clase_Sesion.Campus == "39" && (Clase_Sesion.Rol == "10" || Clase_Sesion.Rol == "11")) || Clase_Sesion.Rol == "14")
            {
                FastReport.EnvironmentSettings fsetting = new FastReport.EnvironmentSettings();
                fsetting.PreviewSettings.Buttons = PreviewButtons.Print | PreviewButtons.Close | PreviewButtons.Find | PreviewButtons.Zoom | PreviewButtons.Navigator | PreviewButtons.Save | PreviewButtons.Edit;
            }
            else
            {
                FastReport.EnvironmentSettings fsetting = new FastReport.EnvironmentSettings();
                fsetting.PreviewSettings.Buttons = PreviewButtons.Print | PreviewButtons.Close | PreviewButtons.Find | PreviewButtons.Zoom | PreviewButtons.Navigator | PreviewButtons.Save;

            }
        }

        public Reportes(string recibonuevo)
        {
            if (Clase_Sesion.Rol == "16" || Clase_Sesion.Rol == "14")
            {
                FastReport.EnvironmentSettings fsetting = new FastReport.EnvironmentSettings();
                fsetting.PreviewSettings.Buttons = PreviewButtons.All;
            }
            else
            {
                FastReport.EnvironmentSettings fsetting = new FastReport.EnvironmentSettings();
                fsetting.PreviewSettings.Buttons = PreviewButtons.Print;
            }
        }

        public Reportes(String Roles, String Id_Empleados, String Id_Usuarios)
        {

            string[] ARoles = Roles.Replace(" ", String.Empty).Split(',');
            string[] AEmpleados = Id_Empleados.Replace(" ", String.Empty).Split(',');
            string[] AUsuarios = Id_Usuarios.Replace(" ", String.Empty).Split(',');

            bool a = Array.Exists(ARoles, element => element == Clase_Sesion.Rol);
            bool b = Array.Exists(AEmpleados, element => element == Clase_Sesion.IDEmpleado);
            bool c = Array.Exists(AUsuarios, element => element == Clase_Sesion.Usuario);



            if (Clase_Sesion.Rol == "16" || a == true || b == true || c == true)
            {
                FastReport.EnvironmentSettings fsetting = new FastReport.EnvironmentSettings();
                fsetting.PreviewSettings.Buttons = PreviewButtons.All;

            }
            else
            {
                FastReport.EnvironmentSettings fsetting = new FastReport.EnvironmentSettings();
                fsetting.PreviewSettings.Buttons = PreviewButtons.Print | PreviewButtons.Close | PreviewButtons.Find | PreviewButtons.Zoom | PreviewButtons.Navigator | PreviewButtons.Save;

            }
        }
        #endregion

        #region Métodos
        public bool Consulta_Versiones_Reportes(string Reporte)
        {
            string nomProce = "Consulta_Versiones_Reportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Reporte", Reporte),
                new Clase_Parametros("Actualizacion", Clase_Sesion.Version.ToString()),
                new Clase_Parametros("Lanzamiento", Clase_Sesion.Lanzamiento.ToString())
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
        public void ReporteRPT(string reporte)
        {
            string report2;
            Reportes consu = new Reportes();
            consu.Consulta_Versiones_Reportes(reporte);
            report2 = consu.Lector.Tables[0].Rows[0][0].ToString();
            if (report2 == reporte)
            {
                System.IO.File.Copy(@"\\189.197.190.214\Sistemas\Reportes\" + reporte + ".rpt", @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".rpt", true);
                System.IO.File.Copy(@"\\189.197.190.214\Sistemas\Reportes\" + reporte + ".cs", @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".cs", true);
            }
            else
            {
                if (!System.IO.File.Exists(@"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".rpt"))
                {
                    System.IO.File.Copy(@"\\189.197.190.214\Sistemas\Reportes\" + reporte + ".rpt", @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".rpt", true);
                    System.IO.File.Copy(@"\\189.197.190.214\Sistemas\Reportes\" + reporte + ".cs", @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".cs", true);
                }
            }
            Thread.Sleep(3000);
        }
        public void ReporteFRX(string reporte)
        {
            string report2;
            Reportes consu = new Reportes();
            consu.Consulta_Versiones_Reportes(reporte);
            report2 = consu.Lector.Tables[0].Rows[0][0].ToString();
            if (report2 == reporte)
            {
                System.IO.File.Copy(@"\\189.197.190.214\Sistemas\Reportes\" + reporte + ".frx", @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".frx", true);
            }
            else
            {
                if (!System.IO.File.Exists(@"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".frx"))
                {
                    System.IO.File.Copy(@"\\189.197.190.214\Sistemas\Reportes\" + reporte + ".frx", @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".frx", true);
                }
            }
            Thread.Sleep(3000);
        }
        public void ReporteFRX2(string reporte2, string recibo2)
        {
            string report2;
            Reportes consu = new Reportes("recibo");
            consu.Consulta_Versiones_Reportes(reporte2);
            report2 = consu.Lector.Tables[0].Rows[0][0].ToString();
            if (report2 == reporte2)
            {
                System.IO.File.Copy(@"\\189.197.190.214\Sistemas\Reportes\" + reporte2 + ".frx", @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte2 + ".frx", true);
            }
            else
            {
                if (!System.IO.File.Exists(@"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte2 + ".frx"))
                {
                    System.IO.File.Copy(@"\\189.197.190.214\Sistemas\Reportes\" + reporte2 + ".frx", @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte2 + ".frx", true);
                }
            }
            Thread.Sleep(3000);
        }
        public void copyAnyFile(string reporte)
        {
            Thread.Sleep(3000);

            System.IO.File.Copy(@"\\189.197.190.214\Sistemas\Reportes\" + reporte, @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte, true);

            Thread.Sleep(3000);
        }
        #endregion
    }

    public class Clase_ParametrosReportes
    {
        #region Propiedades
        private readonly Reportes conrepor = new Reportes();
        public Report frrepForm = new Report();
        public ReportDocument CryRpt { get; } = new ReportDocument();
        private CrystalReportViewer CRViewer = new CrystalReportViewer();

        private string nomParametro;
        public string NomParametro
        {
            get => nomParametro;
            set => nomParametro = value;
        }
        private string valParametro;
        public string ValParametro
        {
            get => valParametro;
            set => valParametro = value;
        }
        #endregion
        #region Constructor
        public Clase_ParametrosReportes()
        {

        }
        #endregion
        #region Metodos
        public Clase_ParametrosReportes(string nombre, string valor)
        {
            nomParametro = nombre; valParametro = valor;
        }

        public void ShowRepo(List<Clase_ParametrosReportes> pr, string Reporte, string tipoRepor, string ruta)
        {
            try
            {
                //string miReporte = "";
                if (tipoRepor.Equals(".rpt"))
                {
                    conrepor.ReporteRPT(Reporte);
                    //miReporte = @"C:\LoboONE\LoboOne\LoboOne\Reportes\";
                    //miReporte = miReporte + Reporte + ".rpt";
                    if (File.Exists(ruta))
                    {
                        CryRpt.Load(ruta);
                        foreach (Clase_ParametrosReportes p in pr)
                        {
                            CryRpt.SetParameterValue(p.NomParametro.ToString(), p.ValParametro.ToString());
                        }

                        CryRpt.SetDatabaseLogon("5265193FDE7C660", "B2B8C6721ACFD01E5AD3047A468FEF66A9234E5D7D5BA373A47E85A3E64BC5B");
                        //FormVerReportesCristal fc = new FormVerReportesCristal();
                        //fc.Show();
                        //fc.FormVerRsCristal(CryRpt);
                    }

                }
                else
                {
                    if (tipoRepor.Equals(".frx"))
                    {
                        conrepor.ReporteFRX(Reporte);
                        string thisFolder = Config.ApplicationFolder;
                        //miReporte = @"\LoboOne\LoboONE\LoboOne\Reportes\";

                        //miReporte = miReporte + Reporte + ".frx";
                        
                        if (File.Exists(ruta))
                        {
                            
                            frrepForm.Load(ruta);
                            foreach (Clase_ParametrosReportes p in pr)
                            {
                                frrepForm.SetParameterValue(p.NomParametro, p.ValParametro);
                            }

                        }
                        else
                        {
                            MessageBox.Show("No se han encontrado el documento", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MostrarRepos(string[,] arreglo, string reporte, string tipo, string ruta)
        {
            List<Clase_ParametrosReportes> par = new List<Clase_ParametrosReportes>();
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                par.Add(new Clase_ParametrosReportes(arreglo[i, 0], arreglo[i, 1]));
            }
            ShowRepo(par, reporte, tipo,ruta);
        }
        #endregion
    }
}
