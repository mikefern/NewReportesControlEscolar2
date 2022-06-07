using System.Collections.Generic;
using System.Data;
namespace ProyectoLoboSostenido
{
    public class Clase_Sesion
    {
        #region Propiedades
        private Clase_Conecta objConexion;
        public Clase_Conecta ObjConexion
        {
            get => objConexion;
            set => objConexion = value;
        }
        public static string IDUsuario { get; set; }
        public static string IDEmpleado { get; set; }
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }
        public static string campus;
        public static string Campus { get => campus; set => campus = value; }
        public static string CampusReal;
        public static string Mail { get; set; }
        public static string Password_mail { get; set; }
        public static string Rol { get; set; }
        public static int Version { get; set; }
        public static int Lanzamiento { get; set; }
        private static byte[] firma;
        public static string Timbrado_Sistemas { get; set; }

        public static Clase_Facturando licencias { get; set; }
        public static string Servidor { get; set; }
        public static byte[] Firma
        {
            get => firma;
            set => firma = value;
        }
        #endregion
        #region Constructores
        public Clase_Usuario ObjUsuario { get; set; }
        public Clase_Sesion(string iDUsuario, string iDEmpleado, string usuario, string contraseña, string campus, string mail, string password_mail, string rol, byte[] Firma)
        {
            IDUsuario = iDUsuario;
            IDEmpleado = iDEmpleado;
            Usuario = usuario;
            Contraseña = contraseña;
            Clase_Campus objCampus = new Clase_Campus();
            objCampus.ConsultaComboCampusContadores(IDEmpleado);
            if (objCampus.Lector.Tables[0].Rows.Count > 0)
            {
                Campus = objCampus.Lector.Tables[0].Rows[0][0].ToString();
                //CampusReal = objCampus.Lector.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                Campus = campus;
                //CampusReal = campus;
            }
            CampusReal = campus;
            Mail = mail;
            Password_mail = password_mail;
            Rol = rol;
            firma = Firma;
            Version = 58;
            Lanzamiento = 5;

            //Procedimiento para llenar el objeto usuario
            ObjUsuario = new Clase_Usuario
            {
                IdEmpleado = iDEmpleado,
                Condicion = iDUsuario,
                User = usuario,
                Password = contraseña,
                Mail = mail,
                Password_mail = password_mail,
                Rol = rol
            };
        }

        public Clase_Sesion(string iDUsuario, string iDEmpleado, string usuario, string contraseña, string campus, string mail, string password_mail, string rol)
        {
            IDUsuario = iDUsuario;
            IDEmpleado = iDEmpleado;
            Usuario = usuario;
            Contraseña = contraseña;
            Clase_Campus objCampus = new Clase_Campus();
            objCampus.ConsultaComboCampusContadores(IDEmpleado);
            if (objCampus.Lector.Tables[0].Rows.Count > 0)
            {
                Campus = objCampus.Lector.Tables[0].Rows[0][0].ToString();
                //CampusReal= objCampus.Lector.Tables[0].Rows[0][0].ToString(); 
            }
            else
            {
                Campus = campus;
                //CampusReal = campus;
            }
            CampusReal = campus;
            Mail = mail;
            //Password_mail = password_mail;
            Rol = rol;
            Version = 58;
            Lanzamiento = 5;
            //Procedimiento para llenar el objeto usuario
            ObjUsuario = new Clase_Usuario
            {
                IdEmpleado = iDEmpleado,
                Condicion = iDUsuario,
                User = usuario,
                Password = contraseña,
                Mail = mail,
                Password_mail = password_mail,
                Rol = rol
            };
        }
        public Clase_Sesion(string usuario, string contraseña)
        {
            Usuario = usuario;
            Contraseña = contraseña;
        }
        public Clase_Sesion()
        {
        }
        #endregion
        #region Métodos
        public bool BuscaCampus()
        {
            objConexion = new Clase_Conecta();
            string nomProce = "buscacampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("condicion", IDEmpleado)
            };

            if (ObjConexion.ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaUsuarioFecha(string user)
        {
            objConexion = new Clase_Conecta();
            string nomProce = "ConsultaFechaUsuario";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("user", user)
            };

            if (ObjConexion.ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaUsuario(string Frase)
        {
            objConexion = new Clase_Conecta();
            string nomProce = "ConsultaUsuarios";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("usuario", Usuario),
                new Clase_Parametros("pass", Contraseña),
                new Clase_Parametros("Frase", Frase)
            };

            if (ObjConexion.ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaDatUsuario(string ID_Emp)
        {
            objConexion = new Clase_Conecta();
            string nomProce = "ConsultaDatosUsuario";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Empleado", ID_Emp.ToString())
            };

            if (ObjConexion.ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaPlan(string ID_Empleado)
        {
            objConexion = new Clase_Conecta();
            string nomProce = "consultaPlan";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", ID_Empleado.ToString())
            };

            if (objConexion.ConsultarParametros(nomProce, par))
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
    public class Clase_Usuario : Clase_Conecta
    {
        #region Propiedades
        private string condicion;
        public string Condicion
        {
            get => condicion;
            set => condicion = value;
        }
        private string user;
        public string User
        {
            get => user;
            set => user = value;
        }
        private string password;
        public string Password
        {
            get => password;
            set => password = value;
        }
        private string idEmpleado;
        public string IdEmpleado
        {
            get => idEmpleado;
            set => idEmpleado = value;
        }
        private string mail;
        public string Mail
        {
            get => mail;
            set => mail = value;
        }
        private string password_mail;
        public string Password_mail
        {
            get => password_mail;
            set => password_mail = value;
        }
        private string rol;
        public string Rol
        {
            get => rol;
            set => rol = value;
        }
        private byte[] firma;
        public byte[] Firma
        {
            get => firma;
            set => firma = value;
        }
        #endregion
        #region Constructores
        public Clase_Usuario(string condicion, string user, string password, string idEmpleado, string mail, string password_mail, string rol, byte[] Firma)
        {
            Condicion = condicion;
            User = user;
            Password = password;
            IdEmpleado = idEmpleado;
            Mail = mail;
            Password_mail = password_mail;
            Rol = rol;
            firma = Firma;
        }
        public Clase_Usuario()
        {

        }
        public Clase_Usuario(string user, string password)
        {
            User = user;
            Password = password;
        }
        #endregion
        #region Métodos
        public bool InsertarUsuario(string user, string pass, string id_emp, string mail, string passmail, byte[] firma, string campus)
        {
            string nomProce = "addUsuario";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("user", user),
                new Clase_Parametros("password", pass),
                new Clase_Parametros("idEmpleado", id_emp),
                new Clase_Parametros("email", mail),
                new Clase_Parametros("passmail", passmail),
                new Clase_Parametros("Activo", "1"),
                new Clase_Parametros("firma", firma),
                new Clase_Parametros("ID_Campus", campus)
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
        public bool InsertarUsuario(string user, string pass, string id_emp, string mail, string passmail, string campus)
        {
            string nomProce = "addUsuario2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("user", user),
                new Clase_Parametros("password", pass),
                new Clase_Parametros("idEmpleado", id_emp),
                new Clase_Parametros("email", mail),
                new Clase_Parametros("passmail", passmail),
                new Clase_Parametros("Activo", "1"),
                new Clase_Parametros("ID_Campus", campus)
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
        public bool ActualizarUsuario2(string user, string pass, string id_emp, string mail, string passmail, string campus, string Frase, string date)
        {
            string nomProce = "upUsuario";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("user", user),
                new Clase_Parametros("password", pass),
                new Clase_Parametros("idEmpleado", id_emp),
                new Clase_Parametros("email", mail),
                new Clase_Parametros("passmail", passmail),
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("FraseSecreta",Frase),
                new Clase_Parametros("FechaCambioPass",date)
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
        public bool ActualizarUsuario(string user, string pass, string id_emp, string mail, string passmail, byte[] firma, string campus, string Frase, string date)
        {
            string nomProce = "upUsuario2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("user", user),
                new Clase_Parametros("password", pass),
                new Clase_Parametros("idEmpleado", id_emp),
                new Clase_Parametros("email", mail),
                new Clase_Parametros("passmail", passmail),
                new Clase_Parametros("firma", firma),
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("FraseSecreta",Frase),
                new Clase_Parametros("FechaCambioPass",date)
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
        public bool ConsultaUsuario()
        {
            string nomProce = "ConsultaUsuarios";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("usuario", User),
                new Clase_Parametros("pass", Password)
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
        public bool ConsultaEmpleados()
        {
            string nomProce = "ConsultaEmpleadosUsuarios";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Campus", Clase_Sesion.campus == null? "":Clase_Sesion.Campus),
            };
            if (ConsultarParametros (nomProce,par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool MarcoEjemploConsulta(string validacion)
        {
           
            string nomProce = "MarcoEjemplo";
           // string prueba = "todos";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("user", validacion)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaUsuarioDatos(string usuario)
        {

            string nomProce = "ConsultaUsuarioDatos";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("user", usuario)
            };

            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaUsuariosDatos()
        {
            string campus;
            string nomProce = "ConsultaUsuariosDatos";
            if (Clase_Sesion.Rol == "14")
            {
                campus = "todos";
            }
            else
            {
                campus = Clase_Sesion.Campus;
            }
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("ID_Campus", campus)
            };
            if (ConsultarParametros(nomProce, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaRolUser()
        {
            string nomProce = "ConsultaUsuarios";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("user", Clase_Sesion.IDUsuario)
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
    public class Clase_Roles : Clase_Conecta
    {
        #region Constructores
        public Clase_Roles()
        { }
        #endregion
        #region Métodos
        public bool ConsultaRoles()
        {
            string nomProce = "ConsultarRoles";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InsertRol(string descripcion)
        {
            string nomProce = "AddRol";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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
        public bool InsertUsuarioRol(string user, string rol)
        {
            string nomProce = "AddUsuarioRol";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Usuario", user),
                new Clase_Parametros("Rol", rol)
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
        public bool ConsultaUsuarios()
        {
            string nomProce = "ComboConsultaUsuarios";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaRolTV(string ID_Rol)
        {
            string nomProce = "ConsultaRolesTV";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Rol", ID_Rol)
            };

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
    public class Clase_Parametros
    {
        #region Propiedades
        public DataTable ParamLista { get; set; }
        private byte[] imagen;
        public byte[] Imagen
        {
            get => imagen;
            set => imagen = value;
        }
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
        public Clase_Parametros(string nombre, string valor)
        {
            nomParametro = nombre; valParametro = valor;
        }
        public Clase_Parametros(string nombre, byte[] valor)
        {
            nomParametro = nombre; imagen = valor;
        }
        public Clase_Parametros(string nombre, DataTable valor)
        {
            nomParametro = nombre;
            ParamLista = valor;
        }
        #endregion
    }
    public class Clase_ObjetoSesion : Clase_Conecta
    {
        #region Propiedades
        private string idUsuario;

        public string IdUsuario
        {
            get => idUsuario;
            set => idUsuario = value;
        }
        private string idEmpleado;

        public string IdEmpleado
        {
            get => idEmpleado;
            set => idEmpleado = value;
        }
        private string contraseña;

        public string Contraseña
        {
            get => contraseña;
            set => contraseña = value;
        }
        private string nombreUsuario;

        public string NombreUsuario
        {
            get => nombreUsuario;
            set => nombreUsuario = value;
        }
        private string correo;

        public string Correo
        {
            get => correo;
            set => correo = value;
        }
        private string nombreAP;

        public string NombreAP
        {
            get => nombreAP;
            set => nombreAP = value;
        }
        private string campus;

        public string Campus
        {
            get => campus;
            set => campus = value;
        }

        //private string idUsuario;
        //private string idEmpleado;
        //private string contraseña;
        //private string nombreUsuario;
        //private string correo;
        //private string nombreAP;
        //private string campus;
        #endregion
        #region Constructores
        public Clase_ObjetoSesion(string idUsuario, string idEmpleado, string contraseña, string nombreUsuario, string correo, string nombreAP, string campus)
        {
            IdUsuario = idUsuario;
            IdEmpleado = idEmpleado;
            Contraseña = contraseña;
            NombreUsuario = nombreUsuario;
            Correo = correo;
            NombreAP = nombreAP;
            Campus = campus;
        }
        #endregion
        #region Métodos
        public bool ConsultaObjetoSesion(string usu, string pas)
        {
            string nomStore = "consultaObjetoSesion";
            _ = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("usuario", usu),
                new Clase_Parametros("pass", pas)
            };


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
}
