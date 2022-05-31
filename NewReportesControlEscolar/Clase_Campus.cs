using System;
using System.Collections.Generic;

namespace ProyectoLoboSostenido
{
    public class Clase_Campus : Clase_Conecta
    {
        #region Propiedades
        private string idcampus;
        public string Idcampus
        {
            get => idcampus;
            set => idcampus = value;
        }
        private string campus1;
        public string Campus1
        {
            get => campus1;
            set => campus1 = value;
        }
        private string domicilioCampus;
        public string DomicilioCampus
        {
            get => domicilioCampus;
            set => domicilioCampus = value;
        }
        private string cPCampus;

        public string CPCampus
        {
            get => cPCampus;
            set => cPCampus = value;
        }
        private string telefonosCampus;

        public string TelefonosCampus
        {
            get => telefonosCampus;
            set => telefonosCampus = value;
        }
        private string municipio;

        public string Municipio
        {
            get => municipio;
            set => municipio = value;
        }
        private string estado;

        public string Estado
        {
            get => estado;
            set => estado = value;
        }
        private string claveContable;

        public string ClaveContable
        {
            get => claveContable;
            set => claveContable = value;
        }
        private Boolean activo;

        public Boolean Activo
        {
            get => activo;
            set => activo = value;
        }
        private string nRP;

        public string NRP
        {
            get => nRP;
            set => nRP = value;
        }
        private string claveEscuela;

        public string ClaveEscuela
        {
            get => claveEscuela;
            set => claveEscuela = value;
        }
        private string representanteLegal;

        public string RepresentanteLegal
        {
            get => representanteLegal;
            set => representanteLegal = value;
        }
        private string testigo1;

        public string Testigo1
        {
            get => testigo1;
            set => testigo1 = value;
        }
        private string testigo2;

        public string Testigo2
        {
            get => testigo2;
            set => testigo2 = value;
        }
        private byte[] rutaImagen;

        public byte[] RutaImagen
        {
            get => rutaImagen;
            set => rutaImagen = value;
        }
        private byte[] logo;

        public byte[] Logo
        {
            get => logo;
            set => logo = value;
        }
        private byte[] logooficial;
        public byte[] LogoOficial
        {
            get => logooficial;
            set => logooficial = value;
        }
        private string colonia;

        public string Colonia
        {
            get => colonia;
            set => colonia = value;
        }
        private string numero;

        public string Numero
        {
            get => numero;
            set => numero = value;
        }

        private string ciudadCampus;
        public string CiudadCampus
        {
            get => ciudadCampus;
            set => ciudadCampus = value;
        }
        #endregion
        #region Constructores
        public Clase_Campus(string idcampus, string campus1, string domicilioCampus, string cPCampus, string telefonosCampus, string municipio, string colonia, string numero,
        string claveContable, Boolean activo, string nRP, string claveEscuela, string representanteLegal, string testigo1, string testigo2, byte[] rutaImagen, byte[] rutalogo, string estado, byte[] logoOfi
         ,string cdCampus)
        {
            Idcampus = idcampus;
            Campus1 = campus1;
            DomicilioCampus = domicilioCampus;
            CPCampus = cPCampus;
            TelefonosCampus = telefonosCampus;
            Municipio = municipio;
            Colonia = colonia;
            Numero = numero;
            ClaveContable = claveContable;
            Activo = activo;
            Estado = estado;
            NRP = nRP;
            ClaveEscuela = claveEscuela;
            RepresentanteLegal = representanteLegal;
            Testigo1 = testigo1;
            Testigo2 = testigo2;
            RutaImagen = rutaImagen;
            Logo = rutalogo;
            logooficial = logoOfi;
            CiudadCampus = cdCampus;
        }

        public Clase_Campus() { }
        #endregion
        #region Métodos
        public bool GetBandera(string ID_Campus, string tipo, string rol = "0")
        {
            string nomStore = "getBanderaCampus";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("tipo", tipo),
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
        public bool ActualizaRegion()
        {
            string nomProce = "upCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("idcampus", idcampus),
                new Clase_Parametros("Campus", Campus1),
                new Clase_Parametros("DomicilioCampus", DomicilioCampus),
                new Clase_Parametros("CPCampus", CPCampus),
                new Clase_Parametros("TelefonosCampus", TelefonosCampus),
                new Clase_Parametros("Municipio", Municipio),
                new Clase_Parametros("Colonia", Colonia),
                new Clase_Parametros("Numero", Numero),
                new Clase_Parametros("Estado", Estado),
                new Clase_Parametros("ClaveContable", ClaveContable),
                new Clase_Parametros("Activo", Activo.ToString()),
                new Clase_Parametros("NRP", NRP),
                new Clase_Parametros("ClaveEscuela", ClaveEscuela),
                new Clase_Parametros("RepresentanteLegal", RepresentanteLegal),
                new Clase_Parametros("Testigo1", Testigo1),
                new Clase_Parametros("Testigo2", Testigo2),
                new Clase_Parametros("RutaImagen", RutaImagen),
                new Clase_Parametros("logo", Logo),
                new Clase_Parametros("logoOf", logooficial),
                new Clase_Parametros("CdCampus", CiudadCampus)
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
        public bool ConsultaCampus()
        {
            string nomStore = "ConsultaCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", Clase_Sesion.Campus)
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
        public bool ConsultaMensajeCampus()
        {
            string nomStore = "ConsultaMensajeLoboone";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_campus", Clase_Sesion.Campus)
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
        public bool ConsultaComboCampus()
        {
            string nomStore = "comboCampus";
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaComboCampusContadores(string ID_Empleado)
        {
            string nomStore = "comboCampusContadores";
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
        public bool ConsultacboCampus()
        {
            string nomStore = "comboCampus2";
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
        public bool ConsultacboCampus2()
        {
            string nomStore = "comboCampus3";
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
        public bool ConsultacboModalidad(string id_campus)
        {
            string nomStore = "ComboCampusModalidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", id_campus)
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
        public bool ConsultaNomCampus(string ID_Campus)
        {
            string nomStore = "buscacampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id", ID_Campus.ToString())
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
        public bool Consultaestado()
        {
            string nomStore = "ConsultaEstados";
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Consultamunicipio(string id)
        {
            string nomStore = "ConsultaMunicipios";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id", id)
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
        public bool ConsultacboCicloEscolar(string ID_Campus, string Modalidad)
        {
            string nomStore = "CombodboCicloEscolar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_Campus", ID_Campus),
                new Clase_Parametros("TipoPlan", Modalidad)
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
        public bool ConsultacboCicloEscolarFechas(string ID_CEscolar)
        {
            string nomStore = "CombodboCicloEscolarFechas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_CEscolar", ID_CEscolar)
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
        public bool ConsultaFechasUnidad(string campus, string modalidad, string periodo)
        {
            string nomStore = "ConsultaFechasUnidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("Tipo_Plan", modalidad),
                new Clase_Parametros("id_Periodo", periodo)
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
        public bool AddCampusSucursal(string ID_Campus, string Sucursal)
        {
            string nomProce = "addCampusSucursal";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", ID_Campus),
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
        public bool ConsultaSucursal(string sucursal)
        {
            string nomStore = "ConsultaSucursal";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Sucursal", sucursal)
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

        public bool ActualizaCampusEnvioHistorialPagosCorte(string campus, DateTime fecha, int idarqueo)
        {
            string nomProce = "ActualizaCampusEnvioHistorialPagosCorte";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("idcampus",    campus),
                new Clase_Parametros("fechaArqueo", fecha.ToString()),
                new Clase_Parametros("fechaEnvio", DateTime.Now.ToString()),
                new Clase_Parametros("idEmpEnvio",Clase_Sesion.IDEmpleado),
                new Clase_Parametros("idArqueo",    idarqueo.ToString())
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
    public class Clase_DatosEspecialidadCampus : Clase_Conecta
    {
        #region Propiedades
        private int condicion;

        public int Condicion
        {
            get => condicion;
            set => condicion = value;
        }
        private string especialidad;

        public string Especialidad
        {
            get => especialidad;
            set => especialidad = value;
        }
        private string campus;

        public string Campus
        {
            get => campus;
            set => campus = value;
        }
        private int rvoea;

        public int Rvoea
        {
            get => rvoea;
            set => rvoea = value;
        }
        private Boolean tronco;

        public Boolean Tronco
        {
            get => tronco;
            set => tronco = value;
        }
        private string sinodal1;

        public string Sinodal1
        {
            get => sinodal1;
            set => sinodal1 = value;
        }
        private string sinodal2;

        public string Sinodal2
        {
            get => sinodal2;
            set => sinodal2 = value;
        }
        private string antecedentes;

        public string Antecedentes
        {
            get => antecedentes;
            set => antecedentes = value;
        }
        private string director;

        public string Director
        {
            get => director;
            set => director = value;
        }
        private float calificacionmin;

        public float Calificacionmin
        {
            get => calificacionmin;
            set => calificacionmin = value;
        }
        #endregion
        #region Constructores
        public Clase_DatosEspecialidadCampus(int condicion, string especialidad, string campus, int rvoea, Boolean tronco, string sinodal1, string sinodal2, string antecedentes, string director, float calificacionmin)
        {
            Condicion = condicion;
            Especialidad = especialidad;
            Campus = campus;
            Rvoea = rvoea;
            Tronco = tronco;
            Sinodal1 = sinodal1;
            Sinodal2 = sinodal2;
            Antecedentes = antecedentes;
            Director = director;
            Calificacionmin = calificacionmin;
        }
        #endregion
        #region Métodos
        public bool InsertarDatosEspecialidadCampus()
        {
            string nomProce = "addDatosEspecialidadCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("especialidad", especialidad),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("rvoea", rvoea.ToString()),
                new Clase_Parametros("tronco", tronco.ToString()),
                new Clase_Parametros("sinodal1", sinodal1),
                new Clase_Parametros("sinodal2", sinodal2),
                new Clase_Parametros("antecedentes", antecedentes),
                new Clase_Parametros("director", director),
                new Clase_Parametros("calificacionmin", calificacionmin.ToString())
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

        public bool ActualizarDatosEspecialidadCampus()
        {
            string nomProce = "upDatosEspecialidadCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("condicion", condicion.ToString()),
                new Clase_Parametros("especialidad", especialidad),
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("rvoea", rvoea.ToString()),
                new Clase_Parametros("tronco", tronco.ToString()),
                new Clase_Parametros("sinodal1", sinodal1),
                new Clase_Parametros("sinodal2", sinodal2),
                new Clase_Parametros("antecedentes", antecedentes),
                new Clase_Parametros("director", director),
                new Clase_Parametros("calificacionmin", calificacionmin.ToString())
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
}

