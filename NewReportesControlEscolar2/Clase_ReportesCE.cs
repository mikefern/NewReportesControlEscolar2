using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLoboSostenido
{
    public class Clase_ReportesCE : Clase_Conecta
    {
        public bool OpcionesReporteControlEscolar(string ID_Campus, string rol)
        {
            string nomStore = "RPTGetNodos";
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
        public bool RPTMostrarNodos()
        {
            string nomStore = "RPTMostrarNodos";
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
        public bool GetParmetros_Reportes(string id)
        {
            string nomStore = "GetParmetros_Reportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_Reporte",id),
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
        public bool GetReporte(string nodo, string RVOE)
        {
            string nomStore = "GetReporte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("nodo",nodo),
                new Clase_Parametros("RVOE",RVOE),


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

    }
    public class NodosReportesControlEscolar : Clase_Conecta
    {
        public bool GetNodosReportesControlEscolar(string ID_Campus)
        {
            string nomStore = "GetNodosReportesControlEscolar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_CAMPUS",ID_Campus)
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
    }
    public class ControlUsuariosRepo : Clase_Conecta
    {
        public bool GetRestriccionesUsuarioReportes(string ID)
        {
            string nomStore = "GetRestriccionesUsuarioReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_usuario",ID)
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

    }
    public class GetUsuariosRestricciones : Clase_Conecta
    {
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
    }
    public class GetRoles : Clase_Conecta
    {
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
    }
    public class RestriccionesNodos : Clase_Conecta
    {
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

    }

    public class PermisosReportes : Clase_Conecta
    {
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


    }
    public class NodosPermisos : Clase_Conecta
    {
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

        public bool DeleteRolesCampusNodos(string campus, string CampusNodo,string rol)
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
    }
}
