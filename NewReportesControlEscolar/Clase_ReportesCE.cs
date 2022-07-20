using System;
using System.Collections.Generic; 
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

        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmRPT_AddParametrosRCE

        public bool DML_ParametrosFijosRCE(string Tipo, string Id, string Nombre, string Valor) 
        {
            string nomStore = "Reports_DML_ParametrosFijosRCE";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Tipo",Tipo),
                new Clase_Parametros("Id_parametro",Id),
                new Clase_Parametros("Nombre",Nombre),
                new Clase_Parametros("Valor",Valor),
            };
            if (string.IsNullOrEmpty(Tipo) || Tipo == "0") //si es tipo cero hace consulta a puro Select
            {
                if (ConsultarParametros(nomStore, par))
                    return true;
                else return false;
            }
            else  // de lo contrario hace ejecucion de (inser,update,delete) 
            { 
                if (Ejecuta(nomStore, par))
                    return true;
                else return false;
            }
        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmRPT_AgregarRestriccionesReportesRol

        public bool MostrarNodosRolCampus(string ID_Campus, string rol) 
        {
            string nomStore = "Reports_MostrarNodosRolCampus";
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

        public bool getRol(string id)
        {
            string nomStore = "Reports_getRolUsuario";
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

        public bool DML_RestriccionReportesNodos(string tipo,string id, string nodo)
        {
            string nomStore = "Reports_DML_RestriccionReportesNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo",tipo),
                new Clase_Parametros("id",id),
                new Clase_Parametros("nodo",nodo)
            };
            if (tipo.Equals("0"))
            {
                if (ConsultarParametros(nomStore, par))
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
                if (Ejecuta(nomStore, par))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool GetUsuarios(string Campus_ID)
        {
            string nomStore = "Reports_GetUsuariosRestriccionNodos";
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
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmRPT_ArchivosReportes

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
        #region FrmRPT_AsignacionCampusReportes


        public bool MostrarRVOESCampusReportes(string campus)
        {
            string nomStore = "Reports_MostrarRVOECampusReportes";
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

        public bool DMLRelCampusReporte(string tipo, string reporte, string campus)
        {
            string nomStore = "Reports_DML_RelCampusReporte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo",tipo),
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("campus",campus)
            };
            if (tipo.Equals("0"))
            {
                if (ConsultarParametros(nomStore, par))
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
                if (Ejecuta(nomStore, par))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DMLRelRolesReportes(string tipo, string rol, string campus, string reporte)
        {
            string nomStore = "Reports_DML_RelRolesReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo",tipo),
                new Clase_Parametros("rol",rol),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("reporte", reporte)
            };

            if (tipo.Equals("0"))
            {
                if (ConsultarParametros(nomStore, par))
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
                if (Ejecuta(nomStore, par))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DMLRVOEReportes(string tipo, string reporte, string RVOE, string campus)
        {
            string nomStore = "Reports_DML_RVOEReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo",tipo),
                new Clase_Parametros("reporte",reporte),
                new Clase_Parametros("RVOE", RVOE),
                new Clase_Parametros("campus",campus)
            };

            if (tipo.Equals("0"))
            {
                if (ConsultarParametros(nomStore, par))
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
                if (Ejecuta(nomStore, par))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        #endregion
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmRPT_AsignacionParametrosReporte


        public bool AsignarParametros(string ID, string ID_Parametro)
        {
            string nomStore = "Reports_AsignarParametros";
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
            string nomStore = "Reports_GetParametrosOK";
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
        #region FrmRPT_ControlNodos


        public bool LlenadoNodosRCE()
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
            string nomProce = "Reports_OrdenamientoNodos_Insert";
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

        public bool DMLPermisosNodosCampus(string tipo, string CampusNodo, string campus, string nodo)
        {
            string nomStore = "Reports_DML_CampusNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo",tipo),
                new Clase_Parametros("CampusNodo",CampusNodo),
                new Clase_Parametros("campus",campus),
                new Clase_Parametros("nodo",nodo)
            };

            if (tipo.Equals("0"))
            {
                if (ConsultarParametros(nomStore, par))
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
                if (Ejecuta(nomStore, par))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DMLRolesCampusNodos(string tipo,string campus, string CampusNodo, string rol)
        {
            string nomStore = "Reports_DML_RolesCampusNodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo",tipo),
                new Clase_Parametros("campus",campus),
                new Clase_Parametros("CampusNodo",CampusNodo),
                new Clase_Parametros("rol",rol)
            };

            if (tipo.Equals("0"))
            {
                if (ConsultarParametros(nomStore, par))
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
                if (Ejecuta(nomStore, par))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        #endregion
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmRPT_EnlazarReporteNodos
        
        public bool GetReportesNodo(string nodo)
        {
            string nomStore = "Reports_GetReportesNodo";
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
            string nomStore = "Reports_GetNodoPadre";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("Nodo",nodo)
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
            string nomStore = "Reports_ActualizarNodoReporte";
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
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmRPT_PermisosBotonReportes

        public bool MostrarPermisosReportes()
        {
            string nomStore = "Reports_MostrarPermisosReportes";
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
            string nomStore = "Reports_AddIndicePermisosReportes";
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

        public bool DML_PermisosVerReportes(string tipo, string permiso, string rol, string campus)
        {
            string nomStore = "Reports_DML_PermisosVerReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo",tipo),
                new Clase_Parametros("permiso",permiso),
                new Clase_Parametros("rol",rol),
                new Clase_Parametros("campus",campus)
            };

            if (string.IsNullOrEmpty(tipo) || tipo == "0") //si es tipo cero hace consulta a puro Select
            {
                if (ConsultarParametros(nomStore, par))
                    return true;
                else return false;
            }
            else  // de lo contrario hace ejecucion de (inser,update,delete) 
            {
                if (Ejecuta(nomStore, par))
                    return true;
                else return false;
            }
            
        }
         
        public bool GetRoles()
        {
            string nomStore = "Reports_GetRoles";
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
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmRPT_RelacionarReportes
         
        public bool DML_ReportesControlEscolar(string opt, string ID_Reporte, string ID_Archivo)
        {
            string nomStore = "Reports_DML_ReportesControlEscolar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Tipo",opt),
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
         
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmRPT_RestriccionesRolReportes
         

        public bool GetRestriccionesReportesEmpleado(string empleado)
        {
            string nomStore = "Reports_getRestriccionesReportesEmpleado";
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

        public bool AgregarRestriccionesReportesEmpleado(string tipo,string reporte, string empleado)
        {
            string nomStore = "Reports_RestriccionesReportesEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("tipo",tipo),
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
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmReportesControlEscolar

        public bool GetNodosControlEscolar(string ID_Campus, string rol, string Empleado)
        {
            string nomStore = "Reports_GetNodosCampusRol";
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
            string nomStore = "Reports_GetParametros_Reportes";
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
            string nomStore = "Reports_GetReportesconRVOE";
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

        public bool GetReporteCampus(string nodo, string campus)
        {
            string nomStore = "Reports_GetReporteCampus";
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
            string nomStore = "Reports_GetReporteRVOE";
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
            string nomStore = "Reports_GetDetallesReporte";
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
            string nomStore = "Reports_GetPermisoRolReporteAbrir";
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
            string nomStore = "Reports_GetRestriccionReporteEmpledo";
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
        //----------------------------------------------------------------------------------------------------------------------------
        #region FrmRPTControlEscolarReports
        public bool GetDatosReportesControl()
        {
            string nomProce = "Reports_GetDatosReportesControl";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ReportesControlEscolar(string opt, /*string id_reporte,*/ string nodo, string nombre_reporte, string ID_RelCampus, string ID_RelRvoe, string ID_RelArchivo )
        {
            string nomStore = "Reports_RegistroReportesControl";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("Opt", opt),
                 new Clase_Parametros("Nodo", nodo),
                 new Clase_Parametros("NombreReporte",nombre_reporte),
                 new Clase_Parametros("ID_RelCampus",ID_RelCampus),
                 new Clase_Parametros("ID_RelRVOE",ID_RelRvoe),
                 new Clase_Parametros("ID_RelArchivoReporte",ID_RelArchivo)
               
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

    public class Reportes: Clase_Conecta
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
                reporte = reporte.Replace("System.Windows.Forms.ComboBox, Items.Count: 2", "");
                if (!System.IO.File.Exists(@"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".rpt"))
                {
                    System.IO.File.Copy(@"\\189.197.190.214\Sistemas\ReportesCE\" + reporte + ".rpt", @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".rpt", true);
                    System.IO.File.Copy(@"\\189.197.190.214\Sistemas\ReportesCE\" + reporte + ".cs", @"C:\LoboONE\LoboOne\LoboOne\Reportes\" + reporte + ".cs", true);
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
