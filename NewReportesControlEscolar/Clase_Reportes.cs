using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLoboSostenido
{
    public class Clase_Reportes : Clase_Conecta
    {
        public bool DetalleArchivoReporte(string opt, string nombre, string ruta, string ultimamodificacion, string creacion, string ultimoacceso, string extension, string descripcionModificaciones, string id_Empleado, string id)
        {

            string nomStore = "Reports_RegistroReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("Opt", opt),
                 new Clase_Parametros("NombreArchivo", nombre),
                 new Clase_Parametros("Ruta",ruta),
                 new Clase_Parametros("FechaUltimaModificacion",ultimamodificacion),
                 new Clase_Parametros("FechaCreacion",creacion),
                 new Clase_Parametros("FechaUltimoAcceso",ultimoacceso),
                 new Clase_Parametros("Extension",extension),
                 new Clase_Parametros("DescripcionModificaciones",descripcionModificaciones),
                 new Clase_Parametros("ID_Empleado",id_Empleado),
                 new Clase_Parametros("ID",id)

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
            string nomProce = "GetNombreReporte";
           
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetRuta(string nombre)
        {
            string nomStore = "GetRuta";
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
        public bool MostrarParametros()
        {
            string nomProce = "MostrarParametros";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IDRelacionado (string opt,string ID_Reporte, string ID_Archivo)
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
        public bool EliminarParametros(string ID_Parametro)
        {
            string nomStore = "EliminarParametros";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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

        public bool ParametrosReportes(string tipo,string Id,string nombre,string valor)
        {
            string nomStore = "Reports_DML_ParametrosFijosReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Tipo",tipo),
                new Clase_Parametros("Id_parametro",Id),
                new Clase_Parametros("Nombre",nombre),
                new Clase_Parametros("Valor",valor),
            };
            if(Ejecuta(nomStore,par))
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
