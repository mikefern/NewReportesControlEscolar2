using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace ProyectoLoboSostenido
{
    public class Clase_DocumentosCampus : Clase_Conecta
    {
        #region Métodos
        public bool ConsultaModalidad(string campus)
        {
            string nomProce = "FrmConsultaModalidadDocsCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
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

        public bool ConsultaEspecialidad(string campus, string modalidad)
        {
            string nomProce = "FrmConsultaEspDocsCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ID_Mod", modalidad)
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

        public bool ConsultaDocsEliminar(string campus, string modalidad, string especialidad)
        {
            string nomProce = "FrmConsultaDocsCampusEliminar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ID_Mod", modalidad),
                new Clase_Parametros("ID_Esp", especialidad)
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

        public bool ConsultaDocumentoCampusByID(string ID_DocumentoCampus)
        {
            string nomProce = "ConsultaDocumentoCampusByID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_DocumentoCampus", ID_DocumentoCampus)
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

        public bool ConsultaDocsCampusCat()
        {
            string nomStore = "FrmConsultaDocsCampusCatalogo";
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DocsCampusEliminar(string documento)
        {
            string nomProce = "FrmDocsCampusEliminar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_DocumentoCampus", documento)
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

        public bool DocsCampusAgregar(string documento, string campus, string especialidad, string activa, string modalidad)
        {
            string nomProce = "FrmDocsCampusAgregar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_TipoDocumento", documento),
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ID_Especialidad", especialidad),
                new Clase_Parametros("Activa", activa),
                new Clase_Parametros("ID_Mod", modalidad)
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

    public class Clase_ConsultaHorariosCampus : Clase_Conecta
    {
        #region Métodos
        public bool ConsultaComboCampus()
        {
            string nomStore = "ComboCampusHorarios";
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaMateriasXEspecialidad(string campus, string modalidad)
        {
            string nomProce = "ConsultaMateriasXEspecialidadCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("Especialidad", ""),
                new Clase_Parametros("Rvoe", "0"),
                new Clase_Parametros("Gpo", ""),
                new Clase_Parametros("tipo", modalidad)
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

        public bool ConsultaMateriasXEspecialidad(string campus, string especialidad, string modalidad)
        {
            string nomProce = "ConsultaMateriasXEspecialidadCampus";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("Especialidad", especialidad),
                new Clase_Parametros("Rvoe", "0"),
                new Clase_Parametros("Gpo", ""),
                 new Clase_Parametros("tipo", modalidad)
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

        public bool ConsultaMateriasXEspecialidad(string campus, string especialidad, string rvoe, string modalidad)
        {
            string nomProce = "ConsultaMateriasXEspecialidadCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("Especialidad", especialidad),
                new Clase_Parametros("Rvoe", rvoe),
                new Clase_Parametros("Gpo", ""),
                 new Clase_Parametros("tipo", modalidad)
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

        public bool ConsultaMateriasXEspecialidad(string campus, string especialidad, string rvoe, string gpo, string modalidad)
        {
            string nomProce = "ConsultaMateriasXEspecialidadCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("Especialidad", especialidad),
                new Clase_Parametros("Rvoe", rvoe),
                new Clase_Parametros("Gpo", gpo),
                new Clase_Parametros("tipo", modalidad)

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

        public bool ConsultaMateriasXEspecialidad(string campus, string especialidad, string rvoe, string gpo, string modalidad, string ciclo)
        {
            string nomProce = "ConsultaMateriasXEspecialidadCampus_CONCICLO";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("Especialidad", especialidad),
                new Clase_Parametros("Rvoe", rvoe),
                new Clase_Parametros("Gpo", gpo),
                new Clase_Parametros("tipo", modalidad),
                new Clase_Parametros("cicloEscolar", ciclo)

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

    public class Clase_InfoAcademica_CID : Clase_Conecta
    {
        #region Métodos
        public bool ConsultaInfoAcademicaAlumnoCID(string ID_Alumno)
        {
            string nomProce = "ConsultaInfoAcademicaAlumnoCID";
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

    public class Clase_Control_Escolar : Clase_Conecta
    {
        #region Propiedades
        public string Id { set; get; }
        public string Id_materia { set; get; }
        public string DescripcionMateria { set; get; }
        public string Id_alumno { set; get; }
        public string Alumno { set; get; }
        public string Unidad1 { get; set; }
        public string Faltas1 { get; set; }
        public string Unidad2 { get; set; }
        public string Faltas2 { get; set; }
        public string Unidad3 { get; set; }
        public string Faltas3 { get; set; }
        public string Promedio { get; set; }
        public string Ordinario { get; set; }
        public string FolioOrdinario { get; set; }
        public string FechaOrdinario { get; set; }
        public string Extraordinario { get; set; }
        public string FolioExtraordinario { get; set; }
        public string FechaExtraordinario { get; set; }
        public string Extraordinario2 { get; set; }
        public string FolioExtraordinario2 { get; set; }
        public string FechaExtraordinario2 { get; set; }
        public string Titulo { get; set; }
        public string FolioTitulo { get; set; }
        public string FechaTitulo { get; set; }
        public string Repeticion { get; set; }
        public string Revalidada { get; set; }
        public string Equivalencia { get; set; }
        public string FolioEquivalencia { get; set; }
        public string FechaEquivalencia { get; set; }
        public string FechaEquivalenciaTermino { get; set; }
        public string CriterioPromedio { get; set; }
        public string Columna { get; set; }
        public string Tipo { get; set; }
        public string TipoEquivalencia { get; set; }
        #endregion

        #region Constructores
        public Clase_Control_Escolar(string id, string id_materia, string descripcionMateria, string id_alumno, string alumno, string unidad1,
                                        string faltas1, string unidad2, string faltas2, string unidad3, string faltas3, string promedio, string ordinario,
                                        string folioOrdinario, string fechaOrdinario, string extraordinario, string folioExtraordinario, string fechaExtraordinario,
                                        string extraordinario2, string folioExtraordinario2, string fechaExtraordinario2, string titulo, string folioTitulo,
                                        string fechaTitulo, string repeticion, string revalidada, string equivalencia, string folioEquivalencia,
                                        string fechaEquivalencia, string fechaEquivalenciaTermino, string criterioPromedio, string columna, string tipo)
        {
            Id = id;
            Id_materia = id_materia;
            DescripcionMateria = descripcionMateria;
            Id_alumno = id_alumno;
            Alumno = alumno;
            Unidad1 = unidad1;
            Faltas1 = faltas1;
            Unidad2 = unidad2;
            Faltas2 = faltas2;
            Unidad3 = unidad3;
            Faltas3 = faltas3;
            Promedio = promedio;
            Ordinario = ordinario;
            FolioOrdinario = folioOrdinario;
            FechaOrdinario = fechaOrdinario;
            Extraordinario = extraordinario;
            FolioExtraordinario = folioExtraordinario;
            FechaExtraordinario = fechaExtraordinario;
            Extraordinario2 = extraordinario2;
            FolioExtraordinario2 = folioExtraordinario2;
            FechaExtraordinario2 = fechaExtraordinario2;
            Titulo = titulo;
            FolioTitulo = folioTitulo;
            FechaTitulo = fechaTitulo;
            Repeticion = repeticion;
            Revalidada = revalidada;
            Equivalencia = equivalencia;
            FolioEquivalencia = folioEquivalencia;
            FechaEquivalencia = fechaEquivalencia;
            FechaEquivalenciaTermino = fechaEquivalenciaTermino;
            CriterioPromedio = criterioPromedio;
            Columna = columna;
            this.Tipo = tipo;
        }
        public Clase_Control_Escolar()
        { }
        #endregion

        #region Métodos
        public bool CalificacionesxGrupo(string grupo)
        {
            string nomProce = "CalificacionesXGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo)
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
        public bool GetCalificaciones(string grupo, string materia, string alumno, string tipo)
        {
            try
            {
                string nomProce = "getCalificaciones";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("grupo", grupo),
                    new Clase_Parametros("materia", materia),
                    new Clase_Parametros("alumno", alumno),
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool CalificacionesxGrupoPrepa(string grupo)
        {
            string nomProce = "CalificacionesXGrupoPrepa";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo)
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
        public bool CalificacionesxGrupoAlumno(string grupo, string id_alumno)
        {
            string nomProce = "CalificacionesXGrupoAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo),
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
        public bool FechasActas(string grupo)
        {
            string nomProce = "ConsultaFechasActasMaterias";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_grupo", grupo)
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
        public bool CampusEspecialidad(string grupo)
        {
            string nomProce = "ConsCampusEspecialidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_grupo", grupo)
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
        public bool UpFechasActas(string id_materia_grupo, string grupo, string ordinario, string extra, string extra2, string titulo)
        {
            string nomProce = "UpFechasActasMaterias";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_materia_grupo", id_materia_grupo),
                new Clase_Parametros("id_grupo", grupo),
                new Clase_Parametros("fechaordinario", ordinario),
                new Clase_Parametros("fechaextraordinario", extra),
                new Clase_Parametros("fechaextraordinario2", extra2),
                new Clase_Parametros("fechatitulo", titulo)
                //new Clase_Parametros("idMateria",idMateria)
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
        public bool CalificacionesMateriaGrupo(string grupo, string materia)
        {
            string nomProce = "CalificacionesMateriaGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("materia", materia)
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
        public bool CalificacionesMateriaGrupoPrepa(string grupo, string materia)
        {
            string nomProce = "CalificacionesMateriaGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("materia", materia)
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
        public bool CalificacionesMateriaGrupoAlumno(string grupo, string materia, string id_alumno)
        {
            string nomProce = "CalificacionesMateriaGrupoAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("materia", materia),
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
        public bool ConsultaPeriodosBajaAlumno(string id_alumno)
        {
            string nomProce = "consultaPeriodosBajaAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("idAlumno", id_alumno)
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
        public bool ConsultaPeriodosGrupoAlumno(string id_alumno)
        {
            string nomProce = "consultaPeriodosGrupoAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("idAlumno", id_alumno)
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
        public bool FolioMateria(string materia, string grupo, string ciclo, string tipo)
        {
            string nomProce = "ConsultaFolio";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("materia", materia),
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("ciclo", ciclo),
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
        public bool CalificacionMinima(string especialidad)
        {
            string nomProce = "CalificacionMinima";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("especialidad", especialidad),
                new Clase_Parametros("ID_Campus", Clase_Sesion.campus)
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
        public bool CalificacionExentar(string especialidad)
        {
            string nomProce = "CalificacionExentar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("especialidad", especialidad),
                new Clase_Parametros("ID_Campus", Clase_Sesion.campus)
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
        public bool ActualizarCalificacion(Clase_Control_Escolar c)
        {
            try
            {
                string nomProce = "ActualizarCalificacion";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("id", c.Id.ToString()),
                    new Clase_Parametros("columna", c.Columna),
                    new Clase_Parametros("unidad1", c.Unidad1 ?? string.Empty ),
                    new Clase_Parametros("faltas1", c.Faltas1 ?? string.Empty ),
                    new Clase_Parametros("unidad2", c.Unidad2 ?? string.Empty ),
                    new Clase_Parametros("faltas2", c.Faltas2 ?? string.Empty ),
                    new Clase_Parametros("unidad3", c.Unidad3 ?? string.Empty ),
                    new Clase_Parametros("faltas3", c.Faltas3 ?? string.Empty ),
                    new Clase_Parametros("promedio", c.Promedio ?? string.Empty ),
                    new Clase_Parametros("ordinario", c.Ordinario ?? string.Empty ),
                    new Clase_Parametros("extraordinario", c.Extraordinario ?? string.Empty ),
                    new Clase_Parametros("extraordinario2", c.Extraordinario2 ?? string.Empty ),
                    new Clase_Parametros("titulo", c.Titulo ?? string.Empty ),
                    new Clase_Parametros("revalidada", c.Revalidada ?? "0" ),
                    new Clase_Parametros("equivalencia", c.Equivalencia ?? string.Empty ),
                    new Clase_Parametros("tipo", c.Tipo ?? string.Empty ),
                    new Clase_Parametros("fechaEquivIni",c.FechaEquivalencia ?? string.Empty ),
                    new Clase_Parametros("fechaEquivTer",c.FechaEquivalenciaTermino ?? string.Empty ),
                    new Clase_Parametros("tipoEquiv", c.TipoEquivalencia ?? "0" ),
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public bool ActualizarFolioEquivalencia(Clase_Control_Escolar c)
        {
            try
            {
                string nomProce = "ActualizarFolioEquivalencia";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("id", c.Id.ToString()),
                    new Clase_Parametros("folioEquivalencia", c.FolioEquivalencia ?? string.Empty )
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
                throw new Exception(ex.Message);
            }


        }
        public bool ActualizarCalificacion2(string id, string id_alumno, string un1, string un2, string un3, string fin,
                                            string ord, string ext, string tit, string folord, string folext,
                                            string foltit, string fechaord, string fechaext, string fechatit)
        {
            string nomProce = "ActualizarCalificacionAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id", id),
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("unidad1", un1),
                new Clase_Parametros("unidad2", un2),
                new Clase_Parametros("unidad3", un3),
                new Clase_Parametros("promedio", fin),
                new Clase_Parametros("ordinario", ord),
                new Clase_Parametros("folioOrdinario", folord),
                new Clase_Parametros("fechaOrdinario", fechaord),
                new Clase_Parametros("extraordinario", ext),
                new Clase_Parametros("folioExtraordinario", folext),
                new Clase_Parametros("fechaExtraordinario", fechaext),
                new Clase_Parametros("titulo", tit),
                new Clase_Parametros("folioTitulo", foltit),
                new Clase_Parametros("fechaTitulo", fechatit)
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
        public bool ActualizarEstatusMatAlumno(string idCalificacion, string banderaEstatus)
        {
            try
            {
                string nomProce = "actualizarEstatusMatAlumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("idCalificacion", idCalificacion),
                    new Clase_Parametros("banderaEstatus", banderaEstatus)
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
                throw new Exception(ex.Message);
            }
        }
        public bool GetBanderaEstatus(string idCalif)
        {
            try
            {
                string nomProce = "getBanderaEstatus";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("idCalificacion", idCalif)
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
                throw new Exception(ex.Message);
            }
        }
        public bool PromedioCriterio(string campus, string modalidad)
        {

            string nomProce = "ConsultaPromedioCalificaciones";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", campus),
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
        public bool ConsultaInfoAcademicaAlumno(string ID_Alumno)
        {
            string nomProce = "ConsultaInfoAcademicaAlumno";
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
        public bool BusquedaInfoAlumnosRN(string tipo, string idRvoe, string idTipoPlan, string clave, string ciclo, string gpo,
                                            string tipoCombo, string cicloBusAl, string numSemBusAl, string gpoBusAl, DataTable idsMatRep)
        {
            try
            {
                string nomStore = "busquedaInfoAlumnosRN";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("tipo",tipo),
                    new Clase_Parametros("idRvoe",idRvoe),
                    new Clase_Parametros("idTipoPlan",idTipoPlan),
                    new Clase_Parametros("clave",clave),
                    new Clase_Parametros("ciclo",ciclo),
                    new Clase_Parametros("gpo",gpo),
                    new Clase_Parametros("tipoCombo",tipoCombo),
                    new Clase_Parametros("cicloBusAl",cicloBusAl),
                    new Clase_Parametros("numSemBusAl",numSemBusAl),
                    new Clase_Parametros("gpoBusAl",gpoBusAl),
                    new Clase_Parametros("idsMatRep",idsMatRep)

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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ConsultaPromedioAlumno(string ID_Alumno)
        {
            string nomProce = "getPromedioAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Alumno", ID_Alumno)
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
        public bool GetCorreosCoordinador(string id_Grupo)
        {
            string nomProce = "GetCorreosCoordinador";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", id_Grupo)
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
        public bool DatosAlumnoReporteSSPP(string id_alumno)
        {
            string nomProce = "DatosAlumnoReporteSSPP";
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
        
        public bool DatosAlumnoReportes()
        {
            string nomProce = "DatosAlumnoReporteSSPP";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", Id_alumno)
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
        public bool ConsultaRvoeGrupo(string id_grupo)
        {
            string nomProce = "ConsultaRVOEGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", id_grupo)
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
        public bool InformacionAcademica(string id_alumno)
        {
            string nomProce = "InformacionAcademica";
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
        public bool GetDatosAlumnosIrregulares(string id_alumno)
        {
            string nomProce = "GetDatosAlumnosIrregulares";
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
        public bool ActualizarCalificacion2_2(string id, string id_alumno, string un1, string un2, string un3, string prom, string ord, string ext, string tit)
        {
            string nomProce = "ActualizarCalificacionAlumno2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id", id),
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("unidad1", un1),
                new Clase_Parametros("unidad2", un2),
                new Clase_Parametros("unidad3", un3),
                new Clase_Parametros("promedio", prom),
                new Clase_Parametros("ordinario", ord),
                new Clase_Parametros("extra", ext),
                new Clase_Parametros("titulo", tit),
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
        public bool MostrarCardexMateria(string id_calif, bool MostrarCardex)
        {
            string nomProce = "ActualizarMostrarCardexMateria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id", id_calif.ToString()),
                new Clase_Parametros("MostrarCardex", MostrarCardex.ToString())
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
        public bool ConsultaInfoAcademicaAlumno2(string ID_Alumno)
        {
            string nomProce = "ConsultaInfoAcademicaAlumno2";
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

        //INFORMACION ACADEMICA ALUMNO POR FILA
        public bool ConsultaInfoAcademicaIdCalif(string ID_Calif)
        {
            string nomProce = "ConsultaInfoAcademicaIdCalif";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Calif", ID_Calif)
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
        public bool GetMaxSemestreRVOE(string ID_Rvoe, string ID_Grupo)
        {
            string nomProce = "GetMaxSemestreRVOE";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo),
                new Clase_Parametros("ID_RVOE", ID_Rvoe)
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
        public bool ActualizarStatusAlumnoPasante(string ID_Grupo)
        {
            string nomProce = "ActualizarStatusAlumnoPasante";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo)
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

        #region NuevosMétodosCalificaciones
        public bool GetCalificaciones_Grupo(int ID_Grupo)
        {
            try
            {
                string nomProce = "GetCalificaciones_Grupo";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo.ToString())
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
                MessageBox.Show("Error al ejecutar el procedimiento para obtener calificaciones. " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificaciones_Grupo_Materia(int ID_Grupo, int ID_Materia)
        {
            try
            {
                string nomProce = "GetCalificaciones_Grupo_Materia";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo.ToString()),
                    new Clase_Parametros("ID_Materia", ID_Materia.ToString())
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
                MessageBox.Show("Error al ejecutar el procedimiento para obtener calificaciones. " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificaciones_Grupo_Alumno(int ID_Grupo, string ID_Alumno)
        {
            try
            {
                string nomProce = "GetCalificaciones_Grupo_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo.ToString()),
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
                MessageBox.Show("Error al ejecutar el procedimiento para obtener calificaciones. " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificaciones_Grupo_Materia_Alumno(int ID_Grupo, int ID_Materia, string ID_Alumno)
        {
            try
            {
                string nomProce = "GetCalificaciones_Grupo_Materia_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo.ToString()),
                    new Clase_Parametros("ID_Materia", ID_Materia.ToString()),
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
                MessageBox.Show("Error al ejecutar el procedimiento para obtener calificaciones. " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        public bool AddAceptarPoliticas(string id_alumno, string correo)
        {
            string nomProce = "addAceptarPoliticas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_alumno", id_alumno),
                new Clase_Parametros("correo", correo),
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

    public class Clase_Recursamiento : Clase_Conecta
    {

        #region Propiedades
        public string ID_Alumno { get; set; }
        public int ID_Grupo { get; set; }
        public int ID_Materia { get; set; }
        public DateTime FechaRegsitro { get; }
        public DateTime FechaRegistro { get; set; }
        public string ID_Empleado { get; set; }
        #endregion

        #region Constructores
        public Clase_Recursamiento()
        {

        }
        /// <summary>
        /// Constructor de la clase Recursamiento que permite agregar a un alumno y una materia a la vez en otro grupo para tomar una clase en recursamiento
        /// </summary>
        /// <param name="ID_Alumno">Matricula del alumno</param>
        /// <param name="ID_Grupo">Grupo al que se agrega alumno para que tome materia en recursamiento</param>
        /// <param name="ID_Materia">Materia que se quiere agregar en recursamiento</param>
        /// <param name="FechaRegsitro">Fecha actual</param>
        /// <param name="ID_Empleado">Persona que registra</param>
        public Clase_Recursamiento(string ID_Alumno, int ID_Grupo, int ID_Materia, DateTime FechaRegsitro, string ID_Empleado)
        {
            this.ID_Alumno = ID_Alumno;
            this.ID_Grupo = ID_Grupo;
            this.ID_Materia = ID_Materia;
            this.FechaRegistro = FechaRegsitro;
            this.ID_Empleado = ID_Empleado;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Ejecuta el procedimiento dbo.AlumnoMateriasReprobadas para obtener las materias que el alumno reprobo.
        /// Solo mostrará las materias que sean iguales a las materias del grupo al que se agregara el alumno en recursamiento
        /// </summary>
        /// <returns></returns>
        public bool AlumnoMateriasReprobadas(string ID_Alumno, int ID_Grupo)
        {
            string nombreProc = "AlumnoMateriasReprobadas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("ID_Grupo", ID_Grupo.ToString())
            };

            if (ConsultarParametros(nombreProc, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AgregarAlumnoRecursamiento(string idGrupo, string idEmpleado, string clave, DataTable listAMAdd)
        {
            try
            {
                string nombreProc = "agregarAlumnosRN";
                List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("idGrupo", idGrupo),
                new Clase_Parametros("idEmpleado", idEmpleado),
                new Clase_Parametros("clave", clave),
                new Clase_Parametros("listAMAdd", listAMAdd)
            };

                if (ConsultarParametros(nombreProc, par))
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
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarRecursamientoNoAprob(string idGrupo, DataTable lidtIdAlum)
        {
            try
            {
                string nombreProc = "eliminarAlumnoGrupoRN";
                List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("idGrupo", idGrupo),
                new Clase_Parametros("lidtIdAlum", lidtIdAlum)
            };

                if (ConsultarParametros(nombreProc, par))
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
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Busca si un Alumno seleccionado en un Grupo esta en Recursamiento
        /// </summary>
        /// <param name="ID_Alumno"></param>
        /// <param name="ID_Grupo"></param>
        /// <returns></returns>
        public bool BuscaAlumnoRecursamiento(string ID_Alumno, int ID_Grupo)
        {
            string nombreProc = "BuscaAlumnoRecursamiento";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno),
                new Clase_Parametros("ID_Grupo", ID_Grupo.ToString())
            };

            if (ConsultarParametros(nombreProc, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaAlumPorGpoRN(string idGrupo, string idCampus)
        {
            try
            {
                string nombreProc = "consultaAlumPorGpoRN";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("idGrupo", idGrupo),
                    new Clase_Parametros("idCampus",idCampus)
                };

                if (ConsultarParametros(nombreProc, par))
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
                throw new Exception(ex.Message);
            }
        }
        public bool AgregarMateriasAlumnosIrregulares(string idGrupo, string idEmpleado, string claveEstatusMateria, DataTable listAMAdd)
        {
            try
            {
                string nombreProc = "agregarMateriasAlumnosIrregulares";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("idGrupo", idGrupo),
                    new Clase_Parametros("idEmpleado", idEmpleado),
                    new Clase_Parametros("claveEstatusMateria", claveEstatusMateria),
                    new Clase_Parametros("listAMAdd", listAMAdd)
                };

                if (ConsultarParametros(nombreProc, par))
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
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }

    public class Clase_CalificacionesCID : Clase_Conecta
    {
        #region Propiedades
        public string Id { get; set; }
        public string Id_materia { get; set; }
        public string DescripcionMateria { get; set; }
        public string Id_alumno { get; set; }
        public string Alumno { get; set; }
        public string Unidad1 { get; set; }
        public string Asistencias1 { get; set; }
        public string Faltas1 { get; set; }
        public string Conducta1 { get; set; }
        public string Unidad2 { get; set; }
        public string Asistencias2 { get; set; }
        public string Faltas2 { get; set; }
        public string Conducta2 { get; set; }
        public string Unidad3 { get; set; }
        public string Asistencias3 { get; set; }
        public string Faltas3 { get; set; }
        public string Conducta3 { get; set; }
        public string Unidad4 { get; set; }
        public string Asistencias4 { get; set; }
        public string Faltas4 { get; set; }
        public string Conducta4 { get; set; }
        public string Unidad5 { get; set; }
        public string Asistencias5 { get; set; }
        public string Faltas5 { get; set; }
        public string Conducta5 { get; set; }
        public string Unidad6 { get; set; }
        public string Asistencias6 { get; set; }
        public string Faltas6 { get; set; }
        public string Conducta6 { get; set; }
        public string Unidad7 { get; set; }
        public string Asistencias7 { get; set; }
        public string Faltas7 { get; set; }
        public string Conducta7 { get; set; }
        public string Unidad8 { get; set; }
        public string Asistencias8 { get; set; }
        public string Faltas8 { get; set; }
        public string Conducta8 { get; set; }
        public string Unidad9 { get; set; }
        public string Asistencias9 { get; set; }
        public string Faltas9 { get; set; }
        public string Conducta9 { get; set; }
        public string Unidad10 { get; set; }
        public string Asistencias10 { get; set; }
        public string Faltas10 { get; set; }
        public string Conducta10 { get; set; }
        public string Promedio1 { get; set; }
        public string Promedio2 { get; set; }
        public string Promedio3 { get; set; }
        public string Promedio4 { get; set; }
        public string Promedio5 { get; set; }
        public string PromedioFinal { get; set; }
        public string InglesNivel { get; set; }
        public string FolioOrdinario { get; set; }
        public string FechaOrdinario { get; set; }
        public string Extraordinario { get; set; }
        public string FolioExtraordinario { get; set; }
        public string FechaExtraordinario { get; set; }
        public string Titulo { get; set; }
        public string FolioTitulo { get; set; }
        public string FechaTitulo { get; set; }
        public string Observaciones { get; set; }
        public string CriterioPromedio { get; set; }
        public string ID_Gpo_Alumnos { get; set; }
        public string Valor { get; set; }
        public string Columna { get; set; }
        #endregion

        #region Constructores
        public Clase_CalificacionesCID(string id, string id_materia, string descripcionMateria, string id_alumno, string alumno, string unidad1, string asistencias1, string faltas1, string conducta1,
                                        string unidad2, string asistencias2, string faltas2, string conducta2, string unidad3, string asistencias3, string faltas3, string conducta3, string unidad4,
                                        string asistencias4, string faltas4, string conducta4, string unidad5, string asistencias5, string faltas5, string conducta5, string unidad6, string asistencias6,
                                        string faltas6, string conducta6, string unidad7, string asistencias7, string faltas7, string conducta7, string unidad8, string asistencias8, string faltas8,
                                        string conducta8, string unidad9, string asistencias9, string faltas9, string conducta9, string unidad10, string asistencias10, string faltas10, string conducta10,
                                        string promedio1, string promedio2, string promedio3, string promedio4, string promedio5, string promedioFinal, string inglesNivel, string folioOrdinario,
                                        string fechaOrdinario, string extraordinario, string folioExtraordinario, string fechaExtraordinario, string titulo, string folioTitulo, string fechaTitulo,
                                        string observaciones, string criterioPromedio, string id_gpo_alumnos)
        {
            Id = id;
            Id_materia = id_materia;
            DescripcionMateria = descripcionMateria;
            Id_alumno = id_alumno;
            Alumno = alumno;
            Unidad1 = unidad1;
            Asistencias1 = asistencias1;
            Faltas1 = faltas1;
            Conducta1 = conducta1;
            Unidad2 = unidad2;
            Asistencias2 = asistencias2;
            Faltas2 = faltas2;
            Conducta2 = conducta2;
            Unidad3 = unidad3;
            Asistencias3 = asistencias3;
            Faltas3 = faltas3;
            Conducta3 = conducta3;
            Unidad4 = unidad4;
            Asistencias4 = asistencias4;
            Faltas4 = faltas4;
            Conducta4 = conducta4;
            Unidad5 = unidad5;
            Asistencias5 = asistencias5;
            Faltas5 = faltas5;
            Conducta5 = conducta5;
            Unidad6 = unidad6;
            Asistencias6 = asistencias6;
            Faltas6 = faltas6;
            Conducta6 = conducta6;
            Unidad7 = unidad7;
            Asistencias7 = asistencias7;
            Faltas7 = faltas7;
            Conducta7 = conducta7;
            Unidad8 = unidad8;
            Asistencias8 = asistencias8;
            Faltas8 = faltas8;
            Conducta8 = conducta8;
            Unidad9 = unidad9;
            Asistencias9 = asistencias9;
            Faltas9 = faltas9;
            Conducta9 = conducta9;
            Unidad10 = unidad10;
            Asistencias10 = asistencias10;
            Faltas10 = faltas10;
            Conducta10 = conducta10;
            Promedio1 = promedio1;
            Promedio2 = promedio2;
            Promedio3 = promedio3;
            Promedio4 = promedio4;
            Promedio5 = promedio5;
            PromedioFinal = promedioFinal;
            InglesNivel = inglesNivel;
            FolioOrdinario = folioOrdinario;
            FechaOrdinario = fechaOrdinario;
            Extraordinario = extraordinario;
            FolioExtraordinario = folioExtraordinario;
            FechaExtraordinario = fechaExtraordinario;
            Titulo = titulo;
            FolioTitulo = folioTitulo;
            FechaTitulo = fechaTitulo;
            Observaciones = observaciones;
            CriterioPromedio = criterioPromedio;
            ID_Gpo_Alumnos = id_gpo_alumnos;
        }
        public Clase_CalificacionesCID(string id, string id_gpo_alumnos, string valor, string columna)
        {
            Id = id;
            ID_Gpo_Alumnos = id_gpo_alumnos;
            Valor = valor;
            Columna = columna;
        }
        public Clase_CalificacionesCID() { }
        #endregion

        #region Métodos

        #region Métodos Generales
        public bool CalificacionMinima(string especialidad)
        {
            string nomProce = "CalificacionMinima";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("especialidad", especialidad),
                new Clase_Parametros("ID_Campus", Clase_Sesion.campus)
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
        public bool CalificacionesxGrupoCID(string grupo)
        {
            string nomProce = "CalificacionesXGrupoCID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo)
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
        public bool CalificacionesxGrupoCIDAlumno(string grupo, string id_alumno)
        {
            string nomProce = "CalificacionesXGrupoCIDAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo),
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
        public bool CalificacionesMateriaGrupoCID(string grupo, string materia)
        {
            string nomProce = "CalificacionesMateriaGrupoCID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("materia", materia)
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
        public bool CalificacionesMateriaGrupoCIDAlumno(string grupo, string materia, string ID_Alumno)
        {
            string nomProce = "CalificacionesMateriaGrupoCIDAlumno";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("materia", materia),
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
        public bool CalificacionesInglesGrupoCID(string nivel)
        {
            string nomProce = "CalificacionesxGrupoInglesCID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("nivel", nivel)
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
        public bool NivelesIngles()
        {
            string nomProce = "NivelesInglesCID";

            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Seriada(string materia)
        {
            string nomProce = "MateriaSeriada";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("materia", materia)
            };

            ConsultarParametros(nomProce, par);

            if (this.Lector.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ActualizarCalificacionCID(Clase_CalificacionesCID c)
        {
            string nomProce = "ActualizarCalificacionCID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id", c.Id),
                new Clase_Parametros("unidad1", c.Unidad1),
                new Clase_Parametros("asistencias1", c.Asistencias1),
                new Clase_Parametros("faltas1", c.Faltas1),
                new Clase_Parametros("conducta1", c.Conducta1),
                new Clase_Parametros("unidad2", c.Unidad2),
                new Clase_Parametros("asistencias2", c.Asistencias2),
                new Clase_Parametros("faltas2", c.Faltas2),
                new Clase_Parametros("conducta2", c.Conducta2),
                new Clase_Parametros("promedio1", c.Promedio1),
                new Clase_Parametros("unidad3", c.Unidad3),
                new Clase_Parametros("asistencias3", c.Asistencias3),
                new Clase_Parametros("faltas3", c.Faltas3),
                new Clase_Parametros("conducta3", c.Conducta3),
                new Clase_Parametros("unidad4", c.Unidad4),
                new Clase_Parametros("asistencias4", c.Asistencias4),
                new Clase_Parametros("faltas4", c.Faltas4),
                new Clase_Parametros("conducta4", c.Conducta4),
                new Clase_Parametros("promedio2", c.Promedio2),
                new Clase_Parametros("unidad5", c.Unidad5),
                new Clase_Parametros("asistencias5", c.Asistencias5),
                new Clase_Parametros("faltas5", c.Faltas5),
                new Clase_Parametros("conducta5", c.Conducta5),
                new Clase_Parametros("unidad6", c.Unidad6),
                new Clase_Parametros("asistencias6", c.Asistencias6),
                new Clase_Parametros("faltas6", c.Faltas6),
                new Clase_Parametros("conducta6", c.Conducta6),
                new Clase_Parametros("promedio3", c.Promedio3),
                new Clase_Parametros("unidad7", c.Unidad7),
                new Clase_Parametros("asistencias7", c.Asistencias7),
                new Clase_Parametros("faltas7", c.Faltas7),
                new Clase_Parametros("conducta7", c.Conducta7),
                new Clase_Parametros("unidad8", c.Unidad8),
                new Clase_Parametros("asistencias8", c.Asistencias8),
                new Clase_Parametros("faltas8", c.Faltas8),
                new Clase_Parametros("conducta8", c.Conducta8),
                new Clase_Parametros("promedio4", c.Promedio4),
                new Clase_Parametros("unidad9", c.Unidad9),
                new Clase_Parametros("asistencias9", c.Asistencias9),
                new Clase_Parametros("faltas9", c.Faltas9),
                new Clase_Parametros("conducta9", c.Conducta9),
                new Clase_Parametros("unidad10", c.Unidad10),
                new Clase_Parametros("asistencias10", c.Asistencias10),
                new Clase_Parametros("faltas10", c.Faltas10),
                new Clase_Parametros("conducta10", c.Conducta10),
                new Clase_Parametros("promedio5", c.Promedio5),
                new Clase_Parametros("promedioFinal", c.PromedioFinal),
                new Clase_Parametros("ingles", c.InglesNivel),
                new Clase_Parametros("observaciones", c.Observaciones),
                new Clase_Parametros("criterioPromedio", c.CriterioPromedio)
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
        public bool ActualizarCalificacionCIDPrepa(Clase_CalificacionesCID c)
        {
            string nomProce = "ActualizarCalificacionCIDPrepa";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id", c.Id),
                new Clase_Parametros("unidad1", c.Unidad1),
                new Clase_Parametros("asistencias1", c.Asistencias1),
                new Clase_Parametros("faltas1", c.Faltas1),
                new Clase_Parametros("conducta1", c.Conducta1),
                new Clase_Parametros("unidad2", c.Unidad2),
                new Clase_Parametros("asistencias2", c.Asistencias2),
                new Clase_Parametros("faltas2", c.Faltas2),
                new Clase_Parametros("conducta2", c.Conducta2),
                new Clase_Parametros("promedio1", c.Promedio1),
                new Clase_Parametros("unidad3", c.Unidad3),
                new Clase_Parametros("asistencias3", c.Asistencias3),
                new Clase_Parametros("faltas3", c.Faltas3),
                new Clase_Parametros("conducta3", c.Conducta3),
                new Clase_Parametros("promedio2", c.Promedio2),
                new Clase_Parametros("promedio3", c.Promedio3),
                new Clase_Parametros("promedio5", c.Promedio5),
                new Clase_Parametros("promedioFinal", c.PromedioFinal),
                new Clase_Parametros("ingles", c.InglesNivel),
                new Clase_Parametros("observaciones", c.Observaciones),
                new Clase_Parametros("FolioOrdinario", c.FolioOrdinario),
                new Clase_Parametros("FechaOrdinario", c.FechaOrdinario.ToString()),
                new Clase_Parametros("Extraordinario", c.Extraordinario),
                new Clase_Parametros("FolioExtraordinario", c.FolioExtraordinario),
                new Clase_Parametros("FechaExtraordinario", c.FechaExtraordinario.ToString()),
                new Clase_Parametros("Titulo", c.Titulo),
                new Clase_Parametros("FolioTitulo", c.FolioTitulo),
                new Clase_Parametros("FechaTitulo", c.FechaTitulo.ToString()),
                new Clase_Parametros("criterioPromedio", c.CriterioPromedio)
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
        public bool PromedioCriterio(string campus)
        {

            string nomProce = "CriterioPromedio";
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
        public bool CalificacionExentar(string especialidad)
        {
            string nomProce = "CalificacionExentar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("especialidad", especialidad),
                new Clase_Parametros("ID_Campus", Clase_Sesion.campus)
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
        public bool FolioMateria(string materia, string grupo, string ciclo, string tipo)
        {
            string nomProce = "ConsultaFolioCID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("materia", materia),
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("ciclo", ciclo),
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
        #endregion

        #region Métodos CIA-CID SEP 2018
        public bool InsertarMateriasGrupoCID(string id_grupo)
        {
            try
            {
                string nomProce = "InsertarMateriasGrupoCID";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al generar los registros de calificaciones de las materias del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region GetCalificacionesPrimariaSecundaria
        public bool GetCalifcacionesGrupo(string id_grupo)
        {
            try
            {
                string nomProce = "GetCalifcacionesGrupo";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalifcacionesGrupo_Alumno(string id_grupo, string id_alumno)
        {
            try
            {
                string nomProce = "GetCalifcacionesGrupo_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_grupo"></param>
        /// <param name="materia">Descripción de la materia</param>
        /// <returns></returns>
        public bool GetCalifcacionesGrupo_Materia(string id_grupo, string materia)
        {
            try
            {
                string nomProce = "GetCalifcacionesGrupo_Materia";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
                    new Clase_Parametros("Materia", materia)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_grupo"></param>
        /// <param name="id_alumno"></param>
        /// <param name="materia">Descripción de la materia</param>
        /// <returns></returns>
        public bool GetCalifcacionesGrupo_Materia_Alumno(string id_grupo, string id_alumno, string materia)
        {
            try
            {
                string nomProce = "GetCalifcacionesGrupo_Materia_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
                    new Clase_Parametros("ID_Alumno", id_alumno),
                    new Clase_Parametros("Materia", materia)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region GetCalificacionesPrepa
        public bool GetCalifcacionesGrupoPrepa(string id_grupo)
        {
            try
            {
                string nomProce = "GetCalifcacionesGrupoPrepa";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalifcacionesGrupoPrepa_Alumno(string id_grupo, string id_alumno)
        {
            try
            {
                string nomProce = "GetCalifcacionesGrupoPrepa_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_grupo"></param>
        /// <param name="materia">Descripción de la materia</param>
        /// <returns></returns>
        public bool GetCalifcacionesGrupoPrepa_Materia(string id_grupo, string materia)
        {
            try
            {
                string nomProce = "GetCalifcacionesGrupoPrepa_Materia";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
                    new Clase_Parametros("Materia", materia)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_grupo"></param>
        /// <param name="id_alumno"></param>
        /// <param name="materia">Descripción de la materia</param>
        /// <returns></returns>
        public bool GetCalifcacionesGrupoPrepa_Materia_Alumno(string id_grupo, string id_alumno, string materia)
        {
            try
            {
                string nomProce = "GetCalifcacionesGrupoPrepa_Materia_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
                    new Clase_Parametros("ID_Alumno", id_alumno),
                    new Clase_Parametros("Materia", materia)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region GetCalificacionesGrupoOptativa_PrimariaSecundaria
        public bool GetCalificacionesGrupoOptativa(string id_grupo)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupoOptativa";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificacionesGrupo_MateriaOptativa(string id_grupo, string materia)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupo_MateriaOpt";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
                    new Clase_Parametros("Materia", materia)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalifcacionesGrupo_Materia_AlumnoOptativa(string id_grupo, string id_alumno, string materia)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupo_Materia_AlumnoOpt";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
                    new Clase_Parametros("ID_Alumno", id_alumno),
                    new Clase_Parametros("Materia", materia)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificacionesGrupo_Alumno_Optativa(string id_grupo, string id_alumno)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupo_AlumnoOpt";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region GetCalificacionesGrupoIngles_PrimariaSecundaria
        public bool GetCalificacionesGrupoIngles(string id_grupo)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupoIngles";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificacionesGrupoIngles_Alumno(string id_grupo, string id_alumno)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupoIngles_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_grupo"></param>
        /// <param name="materia">Descripción de la materia</param>
        /// <returns></returns>
        public bool GetCalificacionesGrupoIngles_Materia(string id_grupo, string materia)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupoIngles_Materia";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
                    new Clase_Parametros("Materia", materia)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_grupo"></param>
        /// <param name="materia">Descripción del alumno</param>
        /// <param name="id_alumno"></param>
        /// <returns></returns>
        public bool GetCalificacionesGrupoIngles_Materia_Alumno(string id_grupo, string materia, string id_alumno)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupoIngles_Materia_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
                    new Clase_Parametros("Materia", materia),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region GetCalificacionesGrupoPrepaIngles_Prepa
        public bool GetCalificacionesGrupoInglesPrepa(string id_grupo)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupoInglesPrepa";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificacionesGrupoInglesPrepa_Alumno(string id_grupo, string id_alumno)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupoInglesPrepa_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_grupo"></param>
        /// <param name="materia">Descripción de la materia</param>
        /// <returns></returns>
        public bool GetCalificacionesGrupoInglesPrepa_Materia(string id_grupo, string materia)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupoInglesPrepa_Materia";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
                    new Clase_Parametros("Materia", materia)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_grupo"></param>
        /// <param name="materia">Descripción del alumno</param>
        /// <param name="id_alumno"></param>
        /// <returns></returns>
        public bool GetCalificacionesGrupoInglesPrepa_Materia_Alumno(string id_grupo, string materia, string id_alumno)
        {
            try
            {
                string nomProce = "GetCalificacionesGrupoInglesPrepa_Materia_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo),
                    new Clase_Parametros("Materia", materia),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalifcacionesGrupoPrepa_ID(string id_calificacionesCID)
        {
            try
            {
                string nomProce = "GetCalifcacionesGrupoPrepa_ID";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_CalificacionesCID", id_calificacionesCID)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificacionPrimariaSecundaria_ID(string id_calificacionesCID)
        {
            try
            {
                string nomProce = "GetCalificacionPrimariaSecundaria_ID";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_CalificacionesCID", id_calificacionesCID)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region UpdateCalificaciones
        public bool UpdateCalificacionesPrimaria(Clase_CalificacionesCID c)
        {
            try
            {
                string nomProce = "UpdateCalificacionesPrimaria";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_CalificacionesCID", c.Id),
                    new Clase_Parametros("ID_Gpo_Alumnos", c.ID_Gpo_Alumnos),
                    new Clase_Parametros("Valor", c.Valor),
                    new Clase_Parametros("Columna", c.Columna)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al actualizar la calificación!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateCalificacionesSecundaria(Clase_CalificacionesCID c)
        {
            try
            {
                string nomProce = "UpdateCalificacionesSecundaria";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_CalificacionesCID", c.Id),
                    new Clase_Parametros("ID_Gpo_Alumnos", c.ID_Gpo_Alumnos),
                    new Clase_Parametros("Valor", c.Valor),
                    new Clase_Parametros("Columna", c.Columna)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al actualizar la calificación!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateCalificacionesPrepa(Clase_CalificacionesCID c)
        {
            try
            {
                string nomProce = "UpdateCalificacionesPrepa";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_CalificacionesCID", c.Id),
                    new Clase_Parametros("ID_Gpo_Alumnos", c.ID_Gpo_Alumnos),
                    new Clase_Parametros("Valor", c.Valor),
                    new Clase_Parametros("Columna", c.Columna)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al actualizar la calificación!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateCalificacionesIngles(Clase_CalificacionesCID c)
        {
            try
            {
                string nomProce = "UpdateCalificacionesIngles";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_CalificacionesCID", c.Id),
                    new Clase_Parametros("ID_Gpo_Alumnos", c.ID_Gpo_Alumnos),
                    new Clase_Parametros("Valor", c.Valor),
                    new Clase_Parametros("Columna", c.Columna)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al actualizar la calificación!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateCalificacionesInglesPrepa(Clase_CalificacionesCID c)
        {
            try
            {
                string nomProce = "UpdateCalificacionesInglesPrepa";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_CalificacionesCID", c.Id),
                    new Clase_Parametros("ID_Gpo_Alumnos", c.ID_Gpo_Alumnos),
                    new Clase_Parametros("Valor", c.Valor),
                    new Clase_Parametros("Columna", c.Columna)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al actualizar la calificación!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #endregion

        #endregion
    }

    public class Clase_Calificaciones : Clase_Conecta
    {
        #region Constructores
        public Clase_Calificaciones() { }
        public Clase_Calificaciones(string iD_Calificacion, string iD_Gpo_Alumnos, string iD_Alumno, string iD_Materia, string unidad1, string faltas1, string unidad2, string faltas2,
                                    string unidad3, string faltas3, string promedio, string faltasT, string ordinario, string folioOrdinario, string extraordinario, string folioExtraordinario,
                                    string extraordinario2, string folioExtraordinario2, string titulo, string folioTitulo, string repeticion, string revalida, string equivalencia, string folioEquivalencia,
                                    string fechaEquivalencia, string fechaEquivalenciaTermino, string tipoEquivalencia, string iD_Cat_Estatus_MateriaAlumno, string estatus, string iD_Periodo,
                                    string descripcionCE, string iD_Grupo, string grupo, string grupoModular, string iD_Rvoe, string rvoe, string materia, string columna, string valor, string iD_Empleado, int iD_Formato)
        {
            ID_Calificacion = iD_Calificacion;
            ID_Gpo_Alumnos = iD_Gpo_Alumnos;
            ID_Alumno = iD_Alumno;
            ID_Materia = iD_Materia;
            Unidad1 = unidad1;
            Faltas1 = faltas1;
            Unidad2 = unidad2;
            Faltas2 = faltas2;
            Unidad3 = unidad3;
            Faltas3 = faltas3;
            Promedio = promedio;
            FaltasT = faltasT;
            Ordinario = ordinario;
            FolioOrdinario = folioOrdinario;
            Extraordinario = extraordinario;
            FolioExtraordinario = folioExtraordinario;
            Extraordinario2 = extraordinario2;
            FolioExtraordinario2 = folioExtraordinario2;
            Titulo = titulo;
            FolioTitulo = folioTitulo;
            Repeticion = repeticion;
            Revalida = revalida;
            Equivalencia = equivalencia;
            FolioEquivalencia = folioEquivalencia;
            FechaEquivalencia = fechaEquivalencia;
            FechaEquivalenciaTermino = fechaEquivalenciaTermino;
            TipoEquivalencia = tipoEquivalencia;
            ID_Cat_Estatus_MateriaAlumno = iD_Cat_Estatus_MateriaAlumno;
            Estatus = estatus;
            ID_Periodo = iD_Periodo;
            DescripcionCE = descripcionCE;
            ID_Grupo = iD_Grupo;
            Grupo = grupo;
            GrupoModular = grupoModular;
            ID_Rvoe = iD_Rvoe;
            Rvoe = rvoe;
            Materia = materia;
            Columna = columna;
            Valor = valor;
            ID_Empleado = iD_Empleado;
            ID_Formato = iD_Formato;
        }

        public Clase_Calificaciones(string iD_Calificacion, string columna, string valor, string id_empleado)
        {
            ID_Calificacion = iD_Calificacion;
            Columna = columna;
            Valor = valor;
            ID_Empleado = id_empleado;
        }
        public Clase_Calificaciones(string iD_Grupo, string iD_Materia, string iD_Alumno)
        {
            ID_Grupo = iD_Grupo;
            ID_Materia = iD_Materia;
            ID_Alumno = iD_Alumno;
        }
        public Clase_Calificaciones(string iD_Grupo, string iD_Calificacion)
        {
            ID_Grupo = iD_Grupo;
            ID_Calificacion = iD_Calificacion;
        }
        #endregion

        #region Propiedades
        public string ID_Calificacion { set; get; }
        public string ID_Gpo_Alumnos { set; get; }
        public string ID_Alumno { set; get; }
        public string ID_Materia { set; get; }
        public string Unidad1 { set; get; }
        public string Faltas1 { set; get; }
        public string Unidad2 { set; get; }
        public string Faltas2 { set; get; }
        public string Unidad3 { set; get; }
        public string Faltas3 { set; get; }
        public string Promedio { set; get; }
        public string FaltasT { set; get; }
        public string Ordinario { set; get; }
        public string FolioOrdinario { set; get; }
        public string Extraordinario { set; get; }
        public string FolioExtraordinario { set; get; }
        public string Extraordinario2 { set; get; }
        public string FolioExtraordinario2 { set; get; }
        public string Titulo { set; get; }
        public string FolioTitulo { set; get; }
        public string Repeticion { set; get; }
        public string Revalida { set; get; }
        public string Equivalencia { set; get; }
        public string FolioEquivalencia { set; get; }
        public string FechaEquivalencia { set; get; }
        public string FechaEquivalenciaTermino { set; get; }
        public string TipoEquivalencia { set; get; }
        public string ID_Cat_Estatus_MateriaAlumno { set; get; }
        public string Estatus { set; get; }
        public string ID_Periodo { set; get; }
        public string DescripcionCE { set; get; }
        public string ID_Grupo { set; get; }
        public string Grupo { set; get; }
        public string GrupoModular { set; get; }
        public string ID_Rvoe { set; get; }
        public string Rvoe { set; get; }
        public string Materia { set; get; }

        public string Columna { set; get; }
        public string Valor { set; get; }
        public string ID_Empleado { set; get; }
        public int ID_Formato { get; set; }
        #endregion

        #region Métodos

        #region GetCalificaciones
        public bool GetCalificaciones_Grupo()
        {
            try
            {
                string nomProce = "GetCalificaciones_Grupo";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificaciones_Grupo_Alumno()
        {
            try
            {
                string nomProce = "GetCalificaciones_Grupo_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificaciones_Grupo_Materia()
        {
            try
            {
                string nomProce = "GetCalificaciones_Grupo_Materia";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo),
                    new Clase_Parametros("ID_Materia", ID_Materia)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificaciones_Grupo_Materia_Alumno()
        {
            try
            {
                string nomProce = "GetCalificaciones_Grupo_Materia_Alumno";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo),
                    new Clase_Parametros("ID_Alumno", ID_Alumno),
                    new Clase_Parametros("ID_Materia", ID_Materia)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetCalificaciones_Grupo_ID()
        {
            try
            {
                string nomProce = "GetCalificaciones_Grupo_ID";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo),
                    new Clase_Parametros("ID_Calificacion", ID_Calificacion)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool RPTSEPyCCalificacionesByIdGrupo(string idGrupo)
        {
            try
            {
                string nomProce = "RPTSEPyCCuadroConcentradoCalificaciones";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", idGrupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RPTSEPyCMateriasByIdGrupo(string idGrupo)
        {
            try
            {
                string nomProce = "RPTSEPyCCuadroConcentradoMaterias";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", idGrupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RPTSEPyCCalificacionesByIdGrupoIdMateria(string idGrupo, string idMateria)
        {
            try
            {
                string nomProce = "RPTSEPyCCalificacionesByIDMateria";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", idGrupo),
                    new Clase_Parametros("ID_Materia", idMateria)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RPTSEPyCCalificaciones_CompleAlta(string idGrupo)
        {
            try
            {
                string nomProce = "RPTSEPyCCuadroConcentradoCalificaciones_CompleAlta";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", idGrupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RPTSEPyCCalificaciones_CompleAltaByIDMateria(string idGrupo, string idMateria)
        {
            try
            {
                string nomProce = "RPTSEPyCCuadroConcentradoCalificaciones_CompleAltaByIDMateria";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", idGrupo),
                    new Clase_Parametros("ID_Materia", idMateria)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error obtener la información!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region UpdateCalificaciones
        public bool UpdateCalificaciones_FormatoI(Clase_Calificaciones c)
        {
            try
            {
                string nomProce = "UpdateCalificaciones_FormatoI";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Calificacion", c.ID_Calificacion),
                    new Clase_Parametros("Columna", c.Columna),
                    new Clase_Parametros("Valor", c.Valor),
                    new Clase_Parametros("ID_Empleado", c.ID_Empleado),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al actualizar la calificación!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateCalificaciones_FormatoII(Clase_Calificaciones c)
        {
            try
            {
                string nomProce = "UpdateCalificaciones_FormatoII";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Calificacion", c.ID_Calificacion),
                    new Clase_Parametros("Columna", c.Columna),
                    new Clase_Parametros("Valor", c.Valor),
                    new Clase_Parametros("ID_Empleado", c.ID_Empleado),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al actualizar la calificación!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateCalificaciones_FormatoIII(Clase_Calificaciones c)
        {
            try
            {
                string nomProce = "UpdateCalificaciones_FormatoIII";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Calificacion", c.ID_Calificacion),
                    new Clase_Parametros("Columna", c.Columna),
                    new Clase_Parametros("Valor", c.Valor),
                    new Clase_Parametros("ID_Empleado", c.ID_Empleado),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al actualizar la calificación!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateCalificaciones_FormatoIV(Clase_Calificaciones c)
        {
            try
            {
                string nomProce = "UpdateCalificaciones_FormatoIV";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Calificacion", c.ID_Calificacion),
                    new Clase_Parametros("Columna", c.Columna),
                    new Clase_Parametros("Valor", c.Valor),
                    new Clase_Parametros("ID_Empleado", c.ID_Empleado),
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al actualizar la calificación!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #endregion
    }


    public class Clase_CiclosEscolares : Clase_Conecta
    {
        #region Propiedades
        //Faltan todos los campos de la tabla con sus getset
        private string idCEscolas;

        public string IdCEscolas
        {
            get => idCEscolas;
            set => idCEscolas = value;
        }
        private string descripcion;

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        private string fechaI;

        public string FechaI
        {
            get => fechaI;
            set => fechaI = value;
        }
        private string fechaF;

        public string FechaF
        {
            get => fechaF;
            set => fechaF = value;
        }
        private string idCAnterior;

        public string IdCAnterior
        {
            get => idCAnterior;
            set => idCAnterior = value;
        }
        private string idCampus;

        public string IdCampus
        {
            get => idCampus;
            set => idCampus = value;
        }
        private string tipoU;

        public string TipoU
        {
            get => tipoU;
            set => tipoU = value;
        }
        private bool activo;

        public bool Activo
        {
            get => activo;
            set => activo = value;
        }
        private bool mkt;

        public bool Mkt
        {
            get => mkt;
            set => mkt = value;
        }
        private bool caja;

        public bool Caja
        {
            get => caja;
            set => caja = value;
        }
        #endregion

        #region Constructores
        //Falta su constructor
        public Clase_CiclosEscolares(string idCEscolas, string descripcion, string fechaI, string fechaF, string idCAnterior, string idCampus, string tipoU, bool activo, bool marketing, bool cajaa)
        {
            IdCEscolas = idCEscolas;
            Descripcion = descripcion;
            FechaI = fechaI;
            FechaF = fechaF;
            IdCAnterior = idCAnterior;
            IdCampus = idCampus;
            TipoU = tipoU;
            Activo = activo;
            Mkt = marketing;
            Caja = cajaa;
        }
        public Clase_CiclosEscolares(string idCEscolas, bool activo, bool marketing, bool cajaa)
        {
            IdCEscolas = idCEscolas;
            Activo = activo;
            Mkt = marketing;
            Caja = cajaa;
        }
        public Clase_CiclosEscolares()
        {
            // TODO: Complete member initialization
        }
        #endregion

        #region Métodos
        //faltan los metodos de Alta, Consulta
        public bool InsertarCicloEscolar()
        {
            string nomProce = "addCiclosEscolares";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("idCEscolas", IdCEscolas),
                new Clase_Parametros("descripcion", Descripcion),
                new Clase_Parametros("fechaI", FechaI),
                new Clase_Parametros("fechaF", FechaF),
                new Clase_Parametros("idCAnterior", IdCAnterior),
                new Clase_Parametros("idCampus", IdCampus),
                new Clase_Parametros("tipoU", TipoU),
                new Clase_Parametros("activo", Activo.ToString()),
                new Clase_Parametros("mkt", Mkt.ToString()),
                new Clase_Parametros("caja", Caja.ToString())
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
        public bool ActualizarCicloEscolar()
        {
            string nomProce = "upCiclosEscolares";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Condicion", IdCEscolas),
                new Clase_Parametros("Descripcion", Descripcion),
                new Clase_Parametros("FechaI", FechaI.ToString()),
                new Clase_Parametros("FechaF", FechaF.ToString()),
                new Clase_Parametros("IdCAnterior", IdCAnterior),
                new Clase_Parametros("Activo", Activo.ToString()),
                new Clase_Parametros("mkt", Mkt.ToString()),
                new Clase_Parametros("caja", Caja.ToString())
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

        public bool ActualizaCicloGpoVirtual(string grupo, string periodo)
        {
            string nomProce = "actualizaCicloGpoVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Grupo", grupo),
                 new Clase_Parametros("ID_CEscolar", periodo)
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
        public bool ConsultaCiclos()
        {
            string nomProce = "ConsultaCiclosEscolares";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", Clase_Sesion.campus)
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
        public bool ConsultaEspecialidadesCiclo(string id_periodo)
        {
            string nomProce = "ConsultaEspecialidadesporCicloEscolar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Periodo", id_periodo)
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
        public bool ConsultaComboCiclos(string campus)
        {
            string nomStore = "comboCicloEscolar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", campus)
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
        public bool ConsultaComboCicloEscolarActivo(string ID_Campus)
        {
            string nomStore = "ComboCicloEscolarActivo";
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

        public bool ComboCicloEscolarActivosTodos(string soloActivos, string Id_Campus)
        {
            string nomStore = "ComboCicloEscolarActivosTodos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("soloActivos", soloActivos),
                new Clase_Parametros("ID_Campus", Id_Campus)
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

        public bool ComboCicloEscolarCursosTitulacion()
        {
            string nomStore = "Titulacion_GetCicloEscolar";
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

        public bool ConsultaComboCiclosCaja(string campus)
        {
            string nomStore = "comboCicloEscolarCaja";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", campus)
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
        public bool ConsultaComboColeg(string ID_Periodo, string Tipo)
        {
            string nomStore = "ConsultaComboColeg";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Periodo", ID_Periodo),
                new Clase_Parametros("Tipo", Tipo)
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
        public bool ConsultaCliclos(string var)
        {
            string nomStore = "consultaCliclos";
            string opcion = var;

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Condicion", opcion)
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
        public bool ConsultaPlan()
        {
            string nomStore = "ComboPlan";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("campus", Clase_Sesion.campus)
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
        public bool HabilitarCiclos()
        {
            try
            {
                string nomProce = "habilitarCiclos";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_CEscolar", IdCEscolas),
                    new Clase_Parametros("CE", Activo.ToString()),
                    new Clase_Parametros("Mkt", Mkt.ToString()),
                    new Clase_Parametros("Caja", Caja.ToString())
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
            catch (Exception)
            {
                return false;
            }

        }
        public bool GetDatosCicloEscolar(string Periodo)
        {
            string nomStore = "GetDatosCicloEscolar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Periodo", Periodo)
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

    public class Clase_Materias : Clase_Conecta
    {
        #region Propiedades
        public string Id_Materia { set; get; }
        public string Clave { set; get; }
        public string Seriacion { set; get; }
        public string DescripcionMateria { set; get; }
        public string Id_RVOE { set; get; }
        public string NumSemestre { set; get; }
        public string Creditos { set; get; }
        public string HorasTeoricas { set; get; }
        public string HorasPracticas { set; get; }
        public string HorasCiclo { set; get; }
        public string DescripcionAbrev { set; get; }
        public bool MPractica { set; get; }
        private bool MLibros;
        public bool MLibros1 { get => MLibros; set => MLibros = value; }
        public int Categoria { set; get; }
        public int PosicionBoleta { set; get; }
        public int Id_AreaMedicina { set; get; }
        #endregion

        #region Constructores
        #region ConstructoresGenerales
        public Clase_Materias()
        {

        }
        public Clase_Materias(string id_Materia, string clave, string seriacion, string descripcionMateria, string id_RVOE, string numSemestre, string creditos, string horasTeoricas, string horasPracticas, string horasCiclo, string descripcionAbrev, bool mPractica, bool mLibrosAlpha, int posBoleta)
        {
            Id_Materia = id_Materia;
            Clave = clave;
            Seriacion = seriacion;
            DescripcionMateria = descripcionMateria;
            Id_RVOE = id_RVOE;
            NumSemestre = numSemestre;
            Creditos = creditos;
            HorasTeoricas = horasTeoricas;
            HorasPracticas = horasPracticas;
            HorasCiclo = horasCiclo;
            DescripcionAbrev = descripcionAbrev;
            MPractica = mPractica;
            MLibros = mLibrosAlpha;
            PosicionBoleta = posBoleta;
        }
        public Clase_Materias(string clave, string seriacion, string descripcionMateria, string id_RVOE, string numSemestre, string creditos, string horasTeoricas, string horasPracticas, string horasCiclo, string descripcionAbrev, bool mPractica, bool mLibrosAlpha, int posBoleta)
        {
            Clave = clave;
            Seriacion = seriacion;
            DescripcionMateria = descripcionMateria;
            Id_RVOE = id_RVOE;
            NumSemestre = numSemestre;
            Creditos = creditos;
            HorasTeoricas = horasTeoricas;
            HorasPracticas = horasPracticas;
            HorasCiclo = horasCiclo;
            DescripcionAbrev = descripcionAbrev;
            MPractica = mPractica;
            MLibros = mLibrosAlpha;
            PosicionBoleta = posBoleta;
        }
        #endregion

        #region Constructores (CIA-CID) SEP 2018
        //CONSULTAS PARA PLAN SEP 2018 DE CID Y CIA
        public Clase_Materias(string id_Materia, string clave, string seriacion, string descripcionMateria, string id_RVOE, string numSemestre, string creditos, string horasTeoricas, string horasPracticas, string horasCiclo, string descripcionAbrev, bool mPractica, bool mLibrosAlpha, int categoria, int posBoleta)
        {
            Id_Materia = id_Materia;
            Clave = clave;
            Seriacion = seriacion;
            DescripcionMateria = descripcionMateria;
            Id_RVOE = id_RVOE;
            NumSemestre = numSemestre;
            Creditos = creditos;
            HorasTeoricas = horasTeoricas;
            HorasPracticas = horasPracticas;
            HorasCiclo = horasCiclo;
            DescripcionAbrev = descripcionAbrev;
            MPractica = mPractica;
            MLibros = mLibrosAlpha;
            Categoria = categoria;
            PosicionBoleta = posBoleta;
        }
        public Clase_Materias(string clave, string seriacion, string descripcionMateria, string id_RVOE, string numSemestre, string creditos, string horasTeoricas, string horasPracticas, string horasCiclo, string descripcionAbrev, bool mPractica, bool mLibrosAlpha, int categoria, int posBoleta)
        {
            Clave = clave;
            Seriacion = seriacion;
            DescripcionMateria = descripcionMateria;
            Id_RVOE = id_RVOE;
            NumSemestre = numSemestre;
            Creditos = creditos;
            HorasTeoricas = horasTeoricas;
            HorasPracticas = horasPracticas;
            HorasCiclo = horasCiclo;
            DescripcionAbrev = descripcionAbrev;
            MPractica = mPractica;
            MLibros = mLibrosAlpha;
            Categoria = categoria;
            PosicionBoleta = posBoleta;
        }
        #endregion
        #endregion

        #region Métodos
        #region Métodos Generales
        public bool InsertarMaterias()
        {
            string nomProce = "addMaterias";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("clave", Clave),
                new Clase_Parametros("seriacion", Seriacion),
                new Clase_Parametros("descripcionmateria", DescripcionMateria),
                new Clase_Parametros("rvoe", Id_RVOE),
                new Clase_Parametros("numsemestre", NumSemestre),
                new Clase_Parametros("creditos", Creditos),
                new Clase_Parametros("horasteo", HorasTeoricas),
                new Clase_Parametros("horasprac", HorasPracticas),
                new Clase_Parametros("horasciclo", HorasCiclo),
                new Clase_Parametros("descripcionabrev", DescripcionAbrev),
                new Clase_Parametros("mPractica", MPractica.ToString()),
                new Clase_Parametros("mLibrosAlpha",MLibros.ToString()),
                new Clase_Parametros("PosicionBoleta", PosicionBoleta.ToString())
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
        public bool ActualizarMaterias()
        {
            string nomProce = "upMaterias";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_Materia", Id_Materia),
                new Clase_Parametros("clave", Clave),
                new Clase_Parametros("seriacion", Seriacion),
                new Clase_Parametros("descripcionmateria", DescripcionMateria),
                new Clase_Parametros("rvoe", Id_RVOE),
                new Clase_Parametros("numsemestre", NumSemestre),
                new Clase_Parametros("creditos", Creditos),
                new Clase_Parametros("horasteo", HorasTeoricas),
                new Clase_Parametros("horasprac", HorasPracticas),
                new Clase_Parametros("horasciclo", HorasCiclo),
                new Clase_Parametros("descripcionabrev", DescripcionAbrev),
                new Clase_Parametros("mPractica", MPractica.ToString()),
                new Clase_Parametros("mLibrosAlpha",MLibros.ToString()),
                new Clase_Parametros("PosicionBoleta",PosicionBoleta.ToString())
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
        public bool UpMateriasMedicina()
        {
            string nomProce = "upMateriasMedicina";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
            //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_Materia", Id_Materia),
                new Clase_Parametros("clave", Clave),
                new Clase_Parametros("seriacion", Seriacion),
                new Clase_Parametros("descripcionmateria", DescripcionMateria),
                new Clase_Parametros("rvoe", Id_RVOE),
                new Clase_Parametros("numsemestre", NumSemestre),
                new Clase_Parametros("creditos", Creditos),
                new Clase_Parametros("horasteo", HorasTeoricas),
                new Clase_Parametros("horasprac", HorasPracticas),
                new Clase_Parametros("horasciclo", HorasCiclo),
                new Clase_Parametros("descripcionabrev", DescripcionAbrev),
                new Clase_Parametros("mPractica", MPractica.ToString()),
                new Clase_Parametros("mLibrosAlpha",MLibros.ToString()),
                new Clase_Parametros("ID_AreaMedicina", Categoria.ToString()),
                new Clase_Parametros("PosicionBoleta",PosicionBoleta.ToString())
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
        public bool ConsultaComboMaterias()
        {
            string nomStore = "comboMaterias";
            //List<Parametros> par = new List<Parametros>();
            //estamos poniendo el nombre del parametro en la tabla y el valor
            // par.Add(new Parametros("condicion", condicion1));

            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaComboMaterias2(string ID_Alumno)
        {
            string nomStore = "comboMaterias2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Alumno", ID_Alumno)
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
        public bool ConsultaMaterias(string var)
        {
            string nomStore = "consultaMaterias";
            string opcion = var;

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Condicion", opcion)
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
        public bool ConsultaMateriasXGrupo(string grupo)
        {
            string nomStore = "ConsultaMateriasXGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_grupo", grupo)
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

        

        public bool ConsultaMateriasXGrupoCID(string grupo)
        {
            string nomStore = "ConsultaMateriasXGrupoCID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_grupo", grupo)
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
        public bool ConsultaMateriasGrupo(string grupo)
        {
            string nomStore = "GetMateriasGrupos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_grupo", grupo)
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
        public bool ConsultaMateriasxNivel(string nivel, string rvoe)
        {
            string nomStore = "ConsultaMateriasXNivel";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("semestre", nivel),
                new Clase_Parametros("rvoe", rvoe)
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

        public bool ConsultaMateriasxNivel2(int id_grupo)
        {
            string nomStore = "ConsultaMateriasXNivel2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", id_grupo.ToString())
            };

            if (ConsultarParametros(nomStore, par))
                return true;
            else
                return false;
        }

        public bool ConsultaMateriasXNivelGpoRotacion(string nivel, string rvoe)
        {
            string nomStore = "ConsultaMateriasXNivelGpoRotacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("semestre", nivel),
                new Clase_Parametros("rvoe", rvoe)
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
        public bool ConsultaInfoMateriaGrupo(string grupo, string materia)
        {
            string nomStore = "ConsultaInfoMateria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Materia", materia),
                new Clase_Parametros("ID_Grupo", grupo)
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
        public bool ConsultaInfoMateriaGrupo(string grupo, string materia, DateTime hora)
        {
            string nomStore = "ConsultaMateriaEnHora";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Materia", materia),
                new Clase_Parametros("ID_Grupo", grupo),
                new Clase_Parametros("hora", hora.ToString("HH:mm:ss"))
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
        public bool ConsultaDatosMateria(string ID_Materia)
        {
            string nomStore = "ConsultaDatosMateria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Materia", ID_Materia)
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
        public bool GetMateriasByID_Rvoe(string ID_Rvoe)
        {
            string nomStore = "GetMateriasByID_Rvoe";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Rvoe", ID_Rvoe)
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

        public bool GetDatosMaestroMateria(string ID_Rvoe)
        {
            string nomStore = "GetDatosMaestroMateria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Rvoe", ID_Rvoe)
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

        public bool GetDatosMaestroMateriaSemestre(string ID_Rvoe, string Semestre)
        {
            string nomStore = "GetDatosMaestroMateriaSemestre";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Rvoe", ID_Rvoe),
                new Clase_Parametros("Semestre", Semestre)
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

        public bool GetGrupoMaterias_LibroAlfa(string ID_Grupo)
        {
            string nomStore = "GetGrupoMaterias_LibroAlfa";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo)
            };

            if (ConsultarParametros(nomStore, par))
                return true;
            else
                return false;
        }
        #endregion

        #region Métodos (CIA- CID) SEP 2018
        public bool ConsultaDatosMateriaSEP2018(string ID_Materia)
        {
            string nomStore = "ConsultaDatosMateriaSEP2018";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Materia", ID_Materia)
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
        public bool InsertarMateriasSEP2018()
        {
            string nomProce = "addMateriasSEP2018";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor

                new Clase_Parametros("clave", Clave),
                new Clase_Parametros("seriacion", Seriacion),
                new Clase_Parametros("descripcionmateria", DescripcionMateria),
                new Clase_Parametros("rvoe", Id_RVOE),
                new Clase_Parametros("numsemestre", NumSemestre),
                new Clase_Parametros("creditos", Creditos),
                new Clase_Parametros("horasteo", HorasTeoricas),
                new Clase_Parametros("horasprac", HorasPracticas),
                new Clase_Parametros("horasciclo", HorasCiclo),
                new Clase_Parametros("descripcionabrev", DescripcionAbrev),
                new Clase_Parametros("mPractica", MPractica.ToString()),
                new Clase_Parametros("mLibrosAlpha",MLibros.ToString()),
                new Clase_Parametros("ID_TipoCID",Categoria.ToString()),
                new Clase_Parametros("PosicionBoleta",PosicionBoleta.ToString())
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
        public bool ActualizarMateriasSEP2018()
        {
            string nomProce = "upMateriasSEP2018";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_Materia", Id_Materia),
                new Clase_Parametros("clave", Clave),
                new Clase_Parametros("seriacion", Seriacion),
                new Clase_Parametros("descripcionmateria", DescripcionMateria),
                new Clase_Parametros("rvoe", Id_RVOE),
                new Clase_Parametros("numsemestre", NumSemestre),
                new Clase_Parametros("creditos", Creditos),
                new Clase_Parametros("horasteo", HorasTeoricas),
                new Clase_Parametros("horasprac", HorasPracticas),
                new Clase_Parametros("horasciclo", HorasCiclo),
                new Clase_Parametros("descripcionabrev", DescripcionAbrev),
                new Clase_Parametros("mPractica", MPractica.ToString()),
                new Clase_Parametros("mLibrosAlpha",MLibros.ToString()),
                new Clase_Parametros("TipoCID",Categoria.ToString()),
                new Clase_Parametros("PosBoleta", PosicionBoleta.ToString())
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
        #endregion
    }

    public class Clase_planes : Clase_Conecta
    {
        #region Constructor
        public Clase_planes() { }
        #endregion

        #region Métodos
        public bool Consultaplan(string campus)
        {
            string nomProce = "ConsultaTipoPlanPyP";
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
        public bool Consultaesp(string tipoplan)
        {
            string nomProce = "ConsultaEspecialidadPyP";
            string campus = Clase_Sesion.campus;
            if (tipoplan == "8" && campus == "02")
            {
                campus = "35";
            }
            else if (tipoplan == "12" && campus == "01")
            {
                campus = "47";
            }
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Tipoplan", tipoplan),
                new Clase_Parametros("Id_Campus", campus)
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
        public bool Consultavigencia(string vigencia, string tipoplan)
        {
            string nomProce = "ConsultaVigenciasPyP";
            string campus = Clase_Sesion.campus;
            if (tipoplan == "8" && campus == "02")
            {
                campus = "35";
            }
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Especialidad", vigencia),
                new Clase_Parametros("Id_Campus", campus)
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
        public bool Consultavigencia2(string vigencia, string tipoplan)
        {
            string nomProce = "ConsultaVigenciasPyP2";
            string campus = Clase_Sesion.campus;
            if (tipoplan == "8" && campus == "02")
            {
                campus = "35";
            }
            else if (tipoplan == "12" && campus == "01")
            {
                campus = "47";
            }
            else if (tipoplan == "18" && campus != "55")
            {
                campus = "18";
            }

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Especialidad", vigencia),
                new Clase_Parametros("Id_Campus", campus)
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
        public bool ConsultatvSem(string IDRVOE)
        {
            string nomProce = "ConsultaSemestresPYP";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_RVOE", IDRVOE)
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
        public bool ConsultaDatosEspecialidad(string id_especialidad, string id_rvoe, string tipoplan)
        {
            string nomProce = "ConsultaInfoEspecialidadPyP";
            string campus = Clase_Sesion.campus;
            if (tipoplan == "8" && campus == "02")
            {
                campus = "35";
            }
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Especialidad", id_especialidad),
                new Clase_Parametros("Id_Campus", campus),
                new Clase_Parametros("Id_RVOE", id_rvoe)
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
        public bool ConsultaCboDirectores()
        {
            string nomProce = "ConsultaComboDirectoresPyP";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Campus", Clase_Sesion.campus)
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
        public bool Consultatv(string rvoe, string NoSem)
        {
            string nomProce = "ConsultaMateriasPYP";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_RVOE", rvoe),
                new Clase_Parametros("numSem", NoSem)
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

        public bool ConsultaMateriasPYPV2Cursar(string rvoe)
        {
            string nomProce = "ConsultaMateriasPYPV2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_RVOE", rvoe)
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

        public bool ConsultaMateriasPYPV2Oficial(string rvoe)
        {
            string nomProce = "ConsultaMateriasPYPV2Oficial";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_RVOE", rvoe)
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

        public bool LigarMateriasPlanes(string id_materia_cursar, string id_materia_oficial)
        {
            string nomProce = "ligarMateriasPlanes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_materia_cursar", id_materia_cursar),
                new Clase_Parametros("id_materia_oficial", id_materia_oficial)
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

        public bool InformaciontvPyP(string Id_Materia)
        {
            string nomProce = "InfoMateriasPyP";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Materia", Id_Materia)
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
        public bool ConsultaUltimaEsp(string NumEspecialidad)
        {
            string nomProce = "ConsultaUltimaEspPyP";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("NumEspecialidad", NumEspecialidad),
                new Clase_Parametros("id_campus", Clase_Sesion.campus)
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
        public bool ConsultaIDESP(string IdTipoPlan)
        {
            string nomProce = "addID_ESP_PyP";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_TipoPlan", IdTipoPlan),
                new Clase_Parametros("Id_Campus", Clase_Sesion.campus)
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
        public bool ConsultaRVOEAct(string IdESPE, string IdREVO)
        {
            string nomProce = "CosultaRVOEActivo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Especialidad", IdESPE),
                new Clase_Parametros("Id_RVOE", IdREVO)
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
        public bool ConsultaDirectorPyP(string id_Empleado)
        {
            string nomProce = "ConsultaDirPyP";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Empleado", id_Empleado)
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
        public bool ActualizaDatos(string NumeroEspecialidad, string Clave, string Nombre_Corto, string Medida, string Semestres, string Turno, string CalificacionMinima, string Director, string Sinodal1, string Sinodal2, bool Activada, string vigencia)
        {
            string nomProce = "upDatosPyP";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("numeroespecialidad", NumeroEspecialidad),
                new Clase_Parametros("clave", Clave),
                new Clase_Parametros("nombre_Corto", Nombre_Corto),
                new Clase_Parametros("medida", Medida),
                new Clase_Parametros("semestres", Semestres),
                new Clase_Parametros("turno", Turno),
                new Clase_Parametros("calificacionMinima", CalificacionMinima),
                new Clase_Parametros("director", Director),
                new Clase_Parametros("sinodal1", Sinodal1),
                new Clase_Parametros("sinodal2", Sinodal2),
                new Clase_Parametros("activada", Activada.ToString())
                
                //Agregado el viernes 02 de Marzo para poder deshabilitar un rvoe de una especialidad
                ,new Clase_Parametros("id_rvoe", vigencia.ToString())
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
        public bool ConsultarCategoriasMateriasCID(int activo)
        {
            string nomProce = "ConsultarCategoriasMateriasCID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("activo", activo.ToString())
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
        public bool ConsultaRVOETotalCuenta(string iD_Especialiadad)
        {
            string nomProce = "ConsultaRVOETotalCuenta";
            string campus = Clase_Sesion.campus;
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Especialidad", iD_Especialiadad),
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

        public bool ConsultaCatergoriaMateriaMedicina()
        {
            string nomProce = "ConsultaCatergoriaMateriaMedicina";

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
    }

    public class Clase_RVOE : Clase_Conecta
    {
        #region Propiedades
        public int Condicion { get; set; }
        public string Campus { get; set; }
        public string Rvoe { get; set; }
        public string Descripcionrvoe { get; set; }
        public string Fecharvoe { get; set; }
        public string Reforma { get; set; }
        public string Periodo { get; set; }
        public string Especialidad { get; set; }
        public string Modalidad { get; set; }
        public string Id_Rvoe { get; set; }
        public string Id_TipoPlan { get; set; }
        #endregion

        #region Constructores
        public Clase_RVOE(string campus, string rvoe, string descripcionrvoe, string fecharvoe, string reforma, string periodo, string modalidad, string especialidad)
        {
            Campus = campus;
            Rvoe = rvoe;
            Descripcionrvoe = descripcionrvoe;
            Fecharvoe = fecharvoe;
            Reforma = reforma;
            Periodo = periodo;
            //activadaR = ActivadaR;
            Modalidad = modalidad;
            Especialidad = especialidad;
        }
        public Clase_RVOE(string campus, string id_Rvoe, string id_TipoPlan)
        {
            Campus = campus;
            Id_Rvoe = id_Rvoe;
            Id_TipoPlan = id_TipoPlan;
        }
        public Clase_RVOE()
        { }
        public Clase_RVOE(int condicion, string campus, string rvoe, string descripcionrvoe, string fecharvoe, string reforma, string periodo, string especialidad, string modalidad, string id_Rvoe, string id_TipoPlan)
        {
            Condicion = condicion;
            Campus = campus;
            Rvoe = rvoe;
            Descripcionrvoe = descripcionrvoe;
            Fecharvoe = fecharvoe;
            Reforma = reforma;
            Periodo = periodo;
            Especialidad = especialidad;
            Modalidad = modalidad;
            Id_Rvoe = id_Rvoe;
            Id_TipoPlan = id_TipoPlan;
        }
        #endregion

        #region Métodos
        public bool ConsultaBusquedaRVOE(string campus, string tipo)
        {
            string nomStore = "comboBusquedaRvoe";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_campus", campus),
                new Clase_Parametros("Id_TipoPlan", tipo)
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
        public bool InsertarRVOE()
        {
            string nomProce = "addRVOE";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Campus", Campus),
                new Clase_Parametros("RVOE", Rvoe),
                new Clase_Parametros("Descripcion_RVOE", Descripcionrvoe),
                new Clase_Parametros("Fecha_RVOE", Fecharvoe),
                new Clase_Parametros("Reforma", Reforma),
                new Clase_Parametros("Periodo_RVOE", Periodo),
                //   par.Add(new Parametros("Activada", activadaR.ToString()));
                new Clase_Parametros("Tipo_plan_Campus", Modalidad),
                new Clase_Parametros("Especialidad", Especialidad)
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
        public bool ActualizarrRVOE(string id_Rvoe)
        {
            string nomProce = "upRVOE";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("condicion", Condicion.ToString()),
                new Clase_Parametros("Id_Campus", Campus),
                new Clase_Parametros("Id_Rvoe", id_Rvoe),
                new Clase_Parametros("RVOE", Rvoe),
                new Clase_Parametros("Descripcion_RVOE", Descripcionrvoe),
                new Clase_Parametros("Fecha_RVOE", Fecharvoe),
                new Clase_Parametros("Reforma", Reforma),
                new Clase_Parametros("Periodo_RVOE", Periodo)
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
        public bool ConsultaRVOExEspecialidad(string campus, string especialidad)
        {
            string nomProce = "RVOExEspecialidades";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("ID_Especialidad", especialidad)
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
        public bool ConsultaRVOExEspecialidad2(string campus, string especialidad)
        {
            string nomProce = "RVOExEspecialidadesPlaneacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("ID_Especialidad", especialidad)
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
        public bool RVOExEspecialidadesAltaGrupo(string campus, string especialidad)
        {
            string nomProce = "RVOExEspecialidadesAltaGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", campus),
                new Clase_Parametros("ID_Especialidad", especialidad)
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
        public bool LlenadoRVOE(string id_Rvoe, string id_TipoPlan)
        {
            string nomStore = "LlenarFrmRVOE";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Id_Rvoe", id_Rvoe),
                new Clase_Parametros("Id_TipoPlan", id_TipoPlan)
            };
            //par.Add(new Parametros("campus", campus));
            //  par.Add(new Parametros("ID_Especialidad", especialidad));

            if (ConsultarParametros(nomStore, par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetRvoeCicloEscolarEspecialidad(string ID_Periodo, string ID_Especialidad)
        {
            string nomProce = "GetRvoeCicloEscolarEspecialidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Periodo", ID_Periodo),
                new Clase_Parametros("ID_Especialidad", ID_Especialidad)
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

    public class Clase_Salon : Clase_Conecta
    {
        #region Propiedades
        public int Condicion { get; set; }
        public string Id_Salon { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Id_Campus { get; set; }
        #endregion

        #region Constructores
        public Clase_Salon(int condicion, string idSalon, string nombre, string descripcion, string tipo, string idCampus)
        {
            Condicion = condicion;
            Id_Salon = idSalon;
            Nombre = nombre;
            Descripcion = descripcion;
            Tipo = tipo;
            Id_Campus = idCampus;
        }
        public Clase_Salon()
        {

        }
        #endregion

        #region Métodos
        public bool InsertarSalon()
        {
            string nomProce = "addSalon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("nombre", Nombre),
                new Clase_Parametros("descripcion", Descripcion),
                new Clase_Parametros("tipo", Tipo),
                new Clase_Parametros("Id_Campus", Id_Campus)
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
        public bool ActualizarSalon()
        {
            string nomProce = "upSalon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Id_Salon", Id_Salon),
                new Clase_Parametros("nombre", Nombre),
                new Clase_Parametros("descripcion", Descripcion),
                new Clase_Parametros("tipo", Tipo),
                new Clase_Parametros("Id_Campus", Id_Campus)
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
        public bool ConsultaSiExisteSalon()
        {
            string nomStore = "ConsultaSiExisteSalon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Nombre", Nombre),
                new Clase_Parametros("Descripcion", Descripcion),
                new Clase_Parametros("Id_Campus", Id_Campus)
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
        public bool GetSalonByID()
        {
            string nomStore = "GetSalonByID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Salon", Id_Salon)
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
        public bool DeleteSalon()
        {
            string nomStore = "DeleteSalon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Salon", Id_Salon)
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

        public bool ConsultaComboSalon()
        {
            string nomStore = "comboSalon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", Clase_Sesion.campus)
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
        public bool SalonGrupo(string grupo)
        {
            string nomStore = "GrupoSalon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo)
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

    public class Clase_Optativa : Clase_Conecta
    {
        #region Métodos
        public bool ConsultaComboOpt()
        {
            string nomStore = "ComboOpt";

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

    public class Clase_ServicioSocialPracticasReportes : Clase_Conecta
    {
        #region Propiedades
        public int Condicion { get; set; }
        public int Ssp { get; set; }
        public DateTime Fechareportessp { get; set; }
        public string Numeroreportessp { get; set; }
        #endregion

        #region Constructores
        public Clase_ServicioSocialPracticasReportes(int condicion, int ssp, DateTime fechareporte, string numeroreportessp)
        {
            Condicion = condicion;
            Ssp = ssp;
            Fechareportessp = fechareporte;
            Numeroreportessp = numeroreportessp;
        }
        public Clase_ServicioSocialPracticasReportes()
        {
        }
        #endregion

        #region Métodos
        public bool InsertarServicioSocialPracticasReportes()
        {
            string nomProce = "addServicioSocialPracticasReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("SSP", Ssp.ToString()),
                new Clase_Parametros("FechaReporteSSP", Fechareportessp.ToString()),
                new Clase_Parametros("NumeroReporteSSP", Numeroreportessp)
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
        public bool ActualizarServicioSocialPracticasReportes()
        {
            string nomProce = "upServicioSocialPracticasReportes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("condicion", Condicion.ToString()),
                new Clase_Parametros("ID_SSP", Ssp.ToString()),
                new Clase_Parametros("FechaReporteSSP", Fechareportessp.ToString()),
                new Clase_Parametros("NumeroReporteSSP", Numeroreportessp)
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

    public class Clase_ServicioSocialPracticas : Clase_Conecta
    {
        #region Propiedades
        public int Condicion { get; set; }
        public string Alumno { get; set; }
        public DateTime Fecharegistro { get; set; }
        public string Dependencia { get; set; }
        public string Encargadodependencia { get; set; }
        public string Puestoencargado { get; set; }
        public string Domiciliodependencia { get; set; }
        public string Telefonodependencia { get; set; }
        public string Programa { get; set; }
        public string Objetivo { get; set; }
        public string Actividades { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafinal { get; set; }
        public string Horariossr { get; set; }
        public string Tipossr { get; set; }
        #endregion

        #region Constructores
        public Clase_ServicioSocialPracticas(int condicion, string alumno, DateTime fecharegistro, string dependencia, string encargadodependencia, string puestoencargado, string domiciliodependencia,
                                           string telefonodependencia, string programa, string objetivo, string actividades, DateTime fechainicio, DateTime fechafinal, string horariossr, string tipossr)
        {
            Condicion = condicion;
            Alumno = alumno;
            Fecharegistro = fecharegistro;
            Dependencia = dependencia;
            Encargadodependencia = encargadodependencia;
            Puestoencargado = puestoencargado;
            Domiciliodependencia = domiciliodependencia;
            Telefonodependencia = telefonodependencia;
            Programa = programa;
            Objetivo = objetivo;
            Actividades = actividades;
            Fechainicio = fechainicio;
            Fechafinal = fechafinal;
            Horariossr = horariossr;
            Tipossr = tipossr;
        }
        public Clase_ServicioSocialPracticas() { }
        #endregion

        #region Métodos
        public bool InsertarServicioSocialPraccticas()
        {
            string nomProce = "addServicioSocialPracticas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecharegistro.ToString()),
                new Clase_Parametros("Dependencia", Dependencia),
                new Clase_Parametros("EncargadoDependencia", Encargadodependencia),
                new Clase_Parametros("PuestoEncargado", Puestoencargado),
                new Clase_Parametros("DomicilioDependencia", Domiciliodependencia),
                new Clase_Parametros("TelefonoDependencia", Telefonodependencia),
                new Clase_Parametros("Programa", Programa),
                new Clase_Parametros("Objetivo", Objetivo),
                new Clase_Parametros("Actividades", Actividades),
                new Clase_Parametros("FechaInicio", Fechainicio.ToString()),
                new Clase_Parametros("FechaFinal", Fechafinal.ToString()),
                new Clase_Parametros("HorarioSSR", Horariossr),
                new Clase_Parametros("TipoSSR", Tipossr)
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
        public bool ActualizarServicioSocialPraccticas()
        {
            string nomProce = "upServicioSocialPracticas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {

                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("condicion", Condicion.ToString()),
                new Clase_Parametros("ID_Alumno", Alumno),
                new Clase_Parametros("FechaRegistro", Fecharegistro.ToString()),
                new Clase_Parametros("Dependencia", Dependencia),
                new Clase_Parametros("EncargadoDependencia", Encargadodependencia),
                new Clase_Parametros("PuestoEncargado", Puestoencargado),
                new Clase_Parametros("DomicilioDependencia", Domiciliodependencia),
                new Clase_Parametros("TelefonoDependencia", Telefonodependencia),
                new Clase_Parametros("Programa", Programa),
                new Clase_Parametros("Objetivo", Objetivo),
                new Clase_Parametros("Actividades", Actividades),
                new Clase_Parametros("FechaInicio", Fechainicio.ToString()),
                new Clase_Parametros("FechaFinal", Fechafinal.ToString()),
                new Clase_Parametros("HorarioSSR", Horariossr),
                new Clase_Parametros("TipoSSR", Tipossr)
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

    public class Clase_MateriasDetallesHorarios : Clase_Conecta
    {
        #region Propiedades
        public int Materiagrupo { get; set; }
        public int Horario { get; set; }
        public int Dia { get; set; }
        public string Fecharegistro { get; set; }
        public bool Compartida { get; set; }
        public string Empleado { get; set; }
        public bool Cubierta { get; set; }
        #endregion

        #region Constructores
        public Clase_MateriasDetallesHorarios(int materiagrupo, int horario, int dia, string fecharegistro, bool compartida, string empleado, bool cubierta)
        {
            Materiagrupo = materiagrupo;
            Horario = horario;
            Dia = dia;
            Fecharegistro = fecharegistro;
            Compartida = compartida;
            Empleado = empleado;
            Cubierta = cubierta;
        }
        public Clase_MateriasDetallesHorarios() { }
        #endregion

        #region Métodos
        public bool InsertarMateriasDetallesHorarios()
        {
            string nomProce = "addMateriasDetallesHorarios";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("materiagrupo", Materiagrupo.ToString()),
                new Clase_Parametros("horario", Horario.ToString()),
                new Clase_Parametros("dia", Dia.ToString()),
                new Clase_Parametros("fecharegistro", Fecharegistro.ToString()),
                new Clase_Parametros("compartida", Compartida.ToString()),
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("cubierta", Cubierta.ToString())
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
        public bool ActualizarMateriasDetallesHorarios()
        {
            string nomProce = "upMateriasDetallesHorarios";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("materiagrupo", Materiagrupo.ToString()),
                new Clase_Parametros("horario", Horario.ToString()),
                new Clase_Parametros("dia", Dia.ToString()),
                new Clase_Parametros("fecharegistro", Fecharegistro.ToString()),
                new Clase_Parametros("compartida", Compartida.ToString()),
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("cubierta", Cubierta.ToString())
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

    public class Clase_MateriasGrupos : Clase_Conecta
    {
        #region Propiedades
        public int ID_Grupo { get; set; }
        public string ID_Materia_Grupo { get; set; }
        public int Materia { get; set; }
        public string Empleado { get; set; }
        public string Fechainicio { get; set; }
        public string Fechatermino { get; set; }
        public int Grupo { get; set; }
        public string Modulo { set; get; }
        public bool Activo { set; get; }
        public string ID_Empleado2 { set; get; }
        public int ID_TipoClase { set; get; }
        public string ID_Salon { set; get; }

        public string Teoria { get; set; }
        public string Practica { get; set; }


        #endregion

        #region Constructores
        public Clase_MateriasGrupos()
        {

        }
        public Clase_MateriasGrupos(int materia, string empleado, string fechainicio, string fechatermino, int grupo)
        {
            Materia = materia;
            Empleado = empleado;
            Fechainicio = fechainicio;
            Fechatermino = fechatermino;
            Grupo = grupo;
        }
        public Clase_MateriasGrupos(int id_grupo)
        {
            ID_Grupo = id_grupo;
        }
        public Clase_MateriasGrupos(string id_materiaGrupo, bool activo)
        {
            ID_Materia_Grupo = id_materiaGrupo;
            Activo = activo;
        }
        public Clase_MateriasGrupos(string id_materiaGrupo, int id_tipoclase)
        {
            ID_Materia_Grupo = id_materiaGrupo;
            ID_TipoClase = id_tipoclase;
        }
        #endregion

        #region Métodos
        public bool InsertarMateriasGrupos()
        {
            string nomProce = "addMateriasGrupos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("materia", Materia.ToString()),
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("fechainicio", Fechainicio.ToString()),
                new Clase_Parametros("fechatermino", Fechatermino.ToString()),
                new Clase_Parametros("grupo", Grupo.ToString())
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
        public bool ActualizarMateriasGrupos()
        {
            string nomProce = "upMateriasGrupos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("materia", Materia.ToString()),
                new Clase_Parametros("empleado", Empleado),
                new Clase_Parametros("fechainicio", Fechainicio.ToString()),
                new Clase_Parametros("fechatermino", Fechatermino.ToString()),
                new Clase_Parametros("grupo", Grupo.ToString())
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
        public bool UpMonto(string ID_grupo, string materia, string ID_empleado, string monto)
        {
            string nomProce = "UpMontoMateria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("grupo", ID_grupo),
                new Clase_Parametros("ID_Materia", materia),
                new Clase_Parametros("id_empleado", ID_empleado),
                new Clase_Parametros("monto", monto)
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
        public bool ConsultaMateriasGrupos(int mat, string emp, int grup)
        {
            string nomStore = "consultaMateriasGrupos";
            int opcion1 = mat;
            string opcion2 = emp;
            int opcion3 = grup;

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("condicion1", opcion1.ToString()),
                new Clase_Parametros("condicion2", opcion2),
                new Clase_Parametros("condicion3", opcion3.ToString())
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
        public bool ConsultasMaestrosMateriasGrupos()
        {
            try
            {
                string nomProce = "ConsultasMaestrosMateriasGrupos";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                   new Clase_Parametros("ID_Grupo", ID_Grupo.ToString())
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
            catch (Exception)
            {
                return false;
            }

        }
        public bool ActivarMaestrosMateriasGrupo()
        {
            string nomProce = "ActivarMaestrosMateriasGrupos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_MateriaGrupo", ID_Materia_Grupo),
                new Clase_Parametros("Activo", Activo.ToString())
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
        public bool ConsultasMaestrosMateriasGrupos2()
        {
            try
            {
                string nomProce = "ConsultasMaestrosMateriasGrupos2";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                   new Clase_Parametros("ID_Grupo", ID_Grupo.ToString())
                   //new Clase_Parametros("ID_Grupo","73085")
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
            catch (Exception)
            {
                return false;
            }

        }
        public bool UpdateMaestrosMateriasGrupo()
        {
            string nomProce = "UpdateMaestrosMateriasGrupos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_MateriaGrupo", ID_Materia_Grupo),
                new Clase_Parametros("ID_Empleado2", ID_Empleado2.ToString())
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

        public bool UpdateMaestrosMateriasSalon()
        {
            string nomProce = "UpdateMaestrosMateriasSalon";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_MateriaGrupo", ID_Materia_Grupo),
                new Clase_Parametros("ID_Salon", ID_Salon.ToString())
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

        public bool UpdateRolTeoriaMaterias(string idPortal)
        {
            string nomProce = "UpdateRolTeoriaMaterias";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_MateriaGrupo", ID_Materia_Grupo),
                new Clase_Parametros("teoria", Teoria),
                new Clase_Parametros("IDPortal", idPortal),
                new Clase_Parametros("User", Clase_Sesion.IDEmpleado)
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

        public bool UpdateRolPracticaMaterias(string idPortal)
        {
            string nomProce = "UpdateRolPracticaMaterias";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_MateriaGrupo", ID_Materia_Grupo),
                new Clase_Parametros("practica", Practica),
                new Clase_Parametros("IDPortal", idPortal),
                new Clase_Parametros("User", Clase_Sesion.IDEmpleado)
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

        public bool validaDocenteRotacion(string rol)
        {
            string nomProce = "verificaDocenteRotacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Grupo", ID_Grupo.ToString()),
                new Clase_Parametros("Materia", Materia.ToString()),
                new Clase_Parametros("Docente", Empleado.ToString()),
                new Clase_Parametros("@Rol", rol)
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


        public bool ActualizaDocenteHoraVirtual(string idGrupo, string idMateria, string idEmpleado)
        {
            string nomProce = "actualizaDocenteHoraVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("@ID_Materia", idMateria),
                new Clase_Parametros("@ID_Grupo", idGrupo),
                new Clase_Parametros("@ID_EmpleadoDocente", idEmpleado)
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

        public bool ConsultaMedicinaTipoClase()
        {
            string nomStore = "ConsultaMedicinaTipoClase";
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultaRolClase(int area)
        {
            string nomProce = "ConsultaRolClase";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("@Area", area.ToString())
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

        public bool ConsultaRolClase(int area, int tipoRol)
        {
            string nomProce = "ConsultaRolClase";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("@Area", area.ToString()),
                new Clase_Parametros("@TipoRol", tipoRol.ToString())
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
        public bool UpdateTipoClaseMateriasGrupos()
        {
            string nomProce = "UpdateTipoClaseMateriasGrupos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_MateriaGrupo", ID_Materia_Grupo),
                new Clase_Parametros("ID_TipoClase", ID_TipoClase.ToString())
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

        public bool verificaDocenteRotacion(string rol)
        {
            try
            {
                string nomProce = "verificaDocenteRotacion";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                   new Clase_Parametros("Grupo", ID_Grupo.ToString()),
                   new Clase_Parametros("Materia", Materia.ToString()),
                   new Clase_Parametros("Docente", this.ID_Empleado2.ToString()),
                   new Clase_Parametros("Rol", rol)
                   //new Clase_Parametros("ID_Grupo","73085")
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
            catch (Exception)
            {
                return false;
            }

        }
        public bool GetBloqueoHorarios()
        {
            string nomProce = "GetBloqueoHorarios";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo.ToString())
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


        public bool NuevoBloqueoHorario(string campus, string tipoPlan, string idEspecialidad,
        string idGrupo, string tipoBloqueo, string bloqueoCoordinador,
        string bloqueoTodos, string bloqueoHorario, string activo)
        {
            string nomProce = "nuevoBloqueoHorario";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("@Campus", campus),
                 new Clase_Parametros("@TipoPlan", tipoPlan),
                 new Clase_Parametros("@ID_Especialidad", idEspecialidad),
                 new Clase_Parametros("@ID_Grupo", idGrupo),
                 new Clase_Parametros("@TipoBloqueo", tipoBloqueo),
                 new Clase_Parametros("@BloqueoCoordinador", bloqueoCoordinador),
                 new Clase_Parametros("@BloqueoTodos", bloqueoTodos),
                 new Clase_Parametros("@BloqueoHorario", bloqueoHorario),
                 new Clase_Parametros("@Activo", activo)
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

        public bool NuevoBloqueoHorario(string campus, string tipoPlan, string idEspecialidad,
            string idGrupo, string tipoBloqueo, string bloqueoCoordinador,
            string bloqueoTodos, string bloqueoHorario, string activo, string idPeriodo)
        {
            string nomProce = "nuevoBloqueoHorario";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                 new Clase_Parametros("@Campus", campus),
                 new Clase_Parametros("@TipoPlan", tipoPlan),
                 new Clase_Parametros("@ID_Especialidad", idEspecialidad),
                 new Clase_Parametros("@ID_Grupo", idGrupo),
                 new Clase_Parametros("@TipoBloqueo", tipoBloqueo),
                 new Clase_Parametros("@BloqueoCoordinador", bloqueoCoordinador),
                 new Clase_Parametros("@BloqueoTodos", bloqueoTodos),
                 new Clase_Parametros("@BloqueoHorario", bloqueoHorario),
                 new Clase_Parametros("@Activo", activo),
                 new Clase_Parametros("@IDPeriodo", idPeriodo)
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
        public bool ConsultaBloqueoHorario(string grupo, int tipoBloq)
        {
            string nomProce = "ConsultaBloqueoHorario";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("@ID_Grupo", grupo),
                new Clase_Parametros("@TipoBloqueo", tipoBloq.ToString()),
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
        public bool GetHorarioVirtual()
        {
            string nomProce = "GetHorarioVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo.ToString())
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

        public bool consultaGruposDocumentos()
        {
            string nomProce = "consultaGruposDocumentos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo.ToString())
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

    public class Clase_EspecialidadesFinanciero : Clase_Conecta
    {
        #region Propiedades
        public int Condicion { get; set; }
        public string Especialidad { get; set; }
        public float Costohora { get; set; }
        public float Recargoins { get; set; }
        public float Recargocol { get; set; }
        public float Inscripcion { get; set; }
        public float Colegiatura { get; set; }
        #endregion

        #region Constructores
        /*private Clase_EspecialidadesFinanciero(int condicion, string especialidad, float costohora, float recargoins, float recargocol, float inscripcion, float colegiatura)
        {
            Condicion = condicion;
            Especialidad = especialidad;
            Costohora = costohora;
            Recargoins = recargoins;
            Recargocol = recargocol;
            Inscripcion = inscripcion;
            Colegiatura = colegiatura;
        }*/
        private Clase_EspecialidadesFinanciero() { }
        #endregion

        #region Métodos
        public bool InsertarEspecialidadesFinanciero()
        {
            string nomProce = "addEspecialidadesFinanciero";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("especialidad", Especialidad),
                new Clase_Parametros("costohora", Costohora.ToString()),
                new Clase_Parametros("recargoins", Recargoins.ToString()),
                new Clase_Parametros("recargocol", Recargocol.ToString()),
                new Clase_Parametros("inscripcion", Inscripcion.ToString()),
                new Clase_Parametros("colegiatura", Colegiatura.ToString())
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
        public bool ActualizarEspecialidadesFinanciero()
        {
            string nomProce = "upEspecialidadesFinanciero";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("condicion", Condicion.ToString()),
                new Clase_Parametros("especialidad", Especialidad),
                new Clase_Parametros("costohora", Costohora.ToString()),
                new Clase_Parametros("recargoins", Recargoins.ToString()),
                new Clase_Parametros("recargocol", Recargocol.ToString()),
                new Clase_Parametros("inscripcion", Inscripcion.ToString()),
                new Clase_Parametros("colegiatura", Colegiatura.ToString())
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


    public class Clase_Especialidades : Clase_Conecta
    {
        #region Propiedades
        public string ID_Especialidad { get; set; }
        public string Descripcion { get; set; }
        public string NombreCorto { get; set; }
        public string Clave { get; set; }
        public string Semestres { get; set; }
        public string Medida { get; set; }
        public string TipoUniv { get; set; }
        public string ID_Campus { get; set; }
        public string Turno { get; set; }
        public bool Activada { get; set; }
        public decimal CalificacionMinima { get; set; }
        public int Condicion { get; set; }
        public string Especialidad { get; set; }
        public string NivelEspecialidad { get; set; }
        public bool Modular { get; set; }
        public decimal CalificacionExcentar { get; set; }
        public string DuracionAnios { get; set; }
        public string DuracionMeses { get; set; }

        public string Antecedentes { get; set; }

        #endregion

        #region Constructores
        public Clase_Especialidades(int condicion, string especialidad, string descripcion, string clave, string nombre, string medida, string semestres, string turno, bool activada, string tipoUniv, string iD_Campus, string nivel_esp)
        {
            Condicion = condicion;
            Especialidad = especialidad;
            Descripcion = descripcion;
            Clave = clave;
            NombreCorto = nombre;
            Medida = medida;
            Semestres = semestres;
            Turno = turno;
            Activada = activada;
            TipoUniv = tipoUniv;
            ID_Campus = iD_Campus;
            NivelEspecialidad = nivel_esp;
        }
        public Clase_Especialidades(string especialidad, string descripcion, string clave, string nombre, string medida, string semestres, string turno, bool activada, string tipoUniv, string iD_Campus)
        {
            Especialidad = especialidad;
            Descripcion = descripcion;
            Clave = clave;
            NombreCorto = nombre;
            Medida = medida;
            Semestres = semestres;
            Turno = turno;
            Activada = activada;
            TipoUniv = tipoUniv;
            ID_Campus = iD_Campus;
        }
        public Clase_Especialidades(string id_especialidad, string id_campus)
        {
            ID_Especialidad = id_especialidad;
            ID_Campus = id_campus;
        }
        public Clase_Especialidades()
        {
        }

        public Clase_Especialidades(string iD_Especialidad, string descripcion, string nombreCorto, string clave, string semestres, string medida, string tipoUniv, string iD_Campus, string turno, bool activada, decimal calificacionMinima, string nivel_esp)
        {
            ID_Especialidad = iD_Especialidad;
            Descripcion = descripcion;
            NombreCorto = nombreCorto;
            Clave = clave;
            Semestres = semestres;
            Medida = medida;
            TipoUniv = tipoUniv;
            ID_Campus = iD_Campus;
            Turno = turno;
            Activada = activada;
            CalificacionMinima = calificacionMinima;
            NivelEspecialidad = nivel_esp;
        }

        public Clase_Especialidades(string iD_Especialidad, string descripcion, string nombreCorto, string clave, string semestres, string medida,
    string tipoUniv, string iD_Campus, string turno, bool activada, decimal calificacionMinima, string nivel_esp,
    bool modular, decimal calificacionExcentar, string duracionAnios, string duracionMeses, string antecedentes)
        {
            ID_Especialidad = iD_Especialidad;
            Descripcion = descripcion;
            NombreCorto = nombreCorto;
            Clave = clave;
            Semestres = semestres;
            Medida = medida;
            TipoUniv = tipoUniv;
            ID_Campus = iD_Campus;
            Turno = turno;
            Activada = activada;
            CalificacionMinima = calificacionMinima;
            NivelEspecialidad = nivel_esp;

            Modular = modular;
            CalificacionExcentar = calificacionExcentar;
            DuracionAnios = duracionAnios;
            DuracionMeses = duracionMeses;
            Antecedentes = antecedentes;
        }
        #endregion

        #region Métodos
        public bool SAC_GetInformacionCarrera(string campus, string especialidad)
        {
            string nomProce = "SAC_GetInformacionCarrera";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ID_Especialidad", especialidad)
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

        public bool SAC_GuardarInformacionCarrera(string ID, string campus, string especialidad, string introduccion, byte[] banner)
        {
            string nomStore = "SAC_GuardarInformacionCarrera";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_", Clase_Sesion.Campus),
                new Clase_Parametros("ID_Campus", campus),
                new Clase_Parametros("ID_Especialidad", especialidad),
                new Clase_Parametros("Introduccion", introduccion),
                new Clase_Parametros("Banner", banner)
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
        public bool InsertarEspecialidades()
        {
            string nomProce = "addEspecialidades";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("Descripcion", Descripcion),
                new Clase_Parametros("NombreCorto", NombreCorto),
                new Clase_Parametros("Clave", Clave),
                new Clase_Parametros("Semestres", Semestres),
                new Clase_Parametros("Medida", Medida),
                new Clase_Parametros("TipoUniv", TipoUniv),
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("Turno", Turno),
                new Clase_Parametros("CalificacionMinima", CalificacionMinima.ToString()),
                new Clase_Parametros("Activada", Convert.ToInt16(Activada).ToString()),
                new Clase_Parametros("NivelEsp",NivelEspecialidad),
                new Clase_Parametros("Modular",Modular.ToString()),
                new Clase_Parametros("CalificacionExcentar",CalificacionExcentar.ToString()),
                new Clase_Parametros("DuracioAnio",DuracionAnios.ToString()),
                new Clase_Parametros("DuracioMeses",DuracionMeses.ToString()),
                new Clase_Parametros("Antecedentes",Antecedentes.ToString())

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
        public bool ActualizarEspecialidades()
        {
            string nomProce = "updateEspecialidades";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Especialidad", ID_Especialidad),
                new Clase_Parametros("Descripcion", Descripcion),
                new Clase_Parametros("NombreCorto", NombreCorto),
                new Clase_Parametros("Clave", Clave),
                new Clase_Parametros("Semestres", Semestres),
                new Clase_Parametros("Medida", Medida),
                new Clase_Parametros("TipoUniv", TipoUniv),
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("Turno", Turno),
                new Clase_Parametros("CalificacionMinima", CalificacionMinima.ToString()),
                new Clase_Parametros("Activada", Convert.ToInt16(Activada).ToString()),
                new Clase_Parametros("NivelEsp",NivelEspecialidad)
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
        public bool ConsultaComboEspecialidad(string campus)
        {
            string nomStore = "comboEspecialidades";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", campus)
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
        public bool ConsultaEspecialidades(string Tipo, string Campus)
        {
            string nomProce = "consultaEspecialidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("tipo", Tipo.ToString()),
                new Clase_Parametros("campus", Campus.ToString())
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
        public bool ConsultaCostoEspecialidad(string Campus, string Especialidad)
        {
            string nomProce = "ConsultaEspecialidadesCosto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_campus", Campus),
                new Clase_Parametros("id_especialidad", Especialidad)
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
        public bool MatriculaSinConsecutivo(string Especialidad, string Campus)
        {
            string nomProce = "matriculaSinConsecutivo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("idespecialidad", Especialidad.ToString()),
                new Clase_Parametros("campus", Campus.ToString())
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
        public bool MatriculaConsecutivo(string Especialidad, string Campus)
        {
            string nomProce = "MatriculaConsecutivo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Especialidad", Especialidad.ToString()),
                new Clase_Parametros("ID_Campus", Campus.ToString())
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
        public bool EsModular(string especialidad, string campus)
        {
            string nomProce = "ConsultaEspecialidadEsModular";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("especialidad", especialidad),
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
        public bool ConsultaEncargadoCECampus()
        {
            string nomProce = "ConsultaEncargadoCECampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Campus", Clase_Sesion.campus)
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
        public bool ConsultaEncargadoCE()
        {
            string nomProce = "ConsultaEncargadoCE";
            return Consultar(nomProce);
        }
        public bool AddTempEspeAdeudos(string ID_Esp, string Tipo)
        {
            string nomStore = "AddTempEspeAdeudos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("TipoPlan", Tipo),
                new Clase_Parametros("ID_Especialidades", ID_Esp),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
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
        public bool DeleteTempEspeAdeudos(string ID_Esp, string Tipo)
        {
            string nomStore = "DeleteTempEspeAdeudos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("TipoPlan", Tipo),
                new Clase_Parametros("ID_Especialidades", ID_Esp),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
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
        public bool ConsultaTempEspeAdeudos(string ID_Esp)
        {
            string nomStore = "ConsultaTempEspAdeudos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado),
                new Clase_Parametros("ID_Esp", ID_Esp)
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
        public bool AddTempEspAdeudos(string tipo)
        {
            string nomStore = "AddTempEspeAdeudos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("TipoPlan", tipo),
                new Clase_Parametros("ID_Especialidades", ""),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
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
        public bool ConsultaTempTipoAdeudos(string ID_Esp)
        {
            string nomStore = "ConsultaTempTipoAdeudos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado),
                new Clase_Parametros("Tipo", ID_Esp)
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
        public bool DeleteTempTipoAdeudos(string Tipo)
        {
            string nomStore = "DeleteTempEspeAdeudos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("TipoPlan", Tipo),
                new Clase_Parametros("ID_Especialidades", ""),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
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
        public bool DeleteTempTipoAdeudosTodo()
        {
            string nomStore = "DeleteTempEspeAdeudosTodo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
                new Clase_Parametros("ID_Empleado", Clase_Sesion.IDEmpleado)
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
        public bool ConsultaTVReporteadorF(string campus, string Tipo)
        {
            string nomStore = "ConsultaEspecialidadCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", campus),
                new Clase_Parametros("TipoPlan", Tipo)
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
        public bool MatriculaConsecutivo(string Modalidad, string Especialidad, string Campus)
        {
            string nomProce = "MatriculaConsecutivo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Campus),
                new Clase_Parametros("Modalidad", Modalidad),
                new Clase_Parametros("ID_Especialidad", Especialidad)
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
        public bool MatriculaProspecto(string Modalidad, string Especialidad, string Campus)
        {
            string nomProce = "MatriculaProspecto";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Campus", Campus),
                new Clase_Parametros("Modalidad", Modalidad),
                new Clase_Parametros("ID_Especialidad", Especialidad)
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
        public bool ConsultaMateriasXEspecialidad(string periodo)
        {
            string nomProce = "ConsultaMateriasXEspecialidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Periodo", periodo),
                new Clase_Parametros("Especialidad", ""),
                new Clase_Parametros("Rvoe", "0")
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
        public bool ConsultaMateriasXEspecialidad(string periodo, string especialidad)
        {
            string nomProce = "ConsultaMateriasXEspecialidad";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Periodo", periodo),
                new Clase_Parametros("Especialidad", especialidad),
                new Clase_Parametros("Rvoe", "0")
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
        public bool ConsultaMateriasXEspecialidad(string periodo, string especialidad, string rvoe)
        {
            string nomProce = "ConsultaMateriasXEspecialidad";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Periodo", periodo),
                new Clase_Parametros("Especialidad", especialidad),
                new Clase_Parametros("Rvoe", rvoe)
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
        public bool ConsultaNivelEspecialidad()
        {
            string nomStore = "ConsultaNivelEspecialidad";
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Consultas para Agregar Especialidades(nuevo)
        public bool GetDatosEspecialidadByID()
        {
            try
            {
                string nomProce = "GetDatosEspecialidadByID";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Campus",ID_Campus),
                    new Clase_Parametros("ID_Especialidad", ID_Especialidad)
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
                MessageBox.Show("Error al consultar la información de la especialidad. " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetModalidadesByID_Campus()
        {
            try
            {
                string nomProce = "GetModalidadesByID_Campus";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Campus",ID_Campus)
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
                MessageBox.Show("Error al consultar la información de las modalidades del Campus. " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool GetDatosCampus()
        {
            try
            {
                string nomProce = "GetDatosCampus";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Campus",ID_Campus)
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
                MessageBox.Show("Error al consultar la información de las modalidades del Campus. " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool GetCarrerasVirtual()
        {
            try
            {
                string nomProce = "GetCarrerasVirtual";

                if (Consultar(nomProce))
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
                MessageBox.Show("Error al consultar la información. " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        public bool GetEspecialidadesTipoPlanCicloEscolar(string ID_Periodo, string ID_Modalidad)
        {
            string nomProce = "GetEspecialidadesTipoPlanCicloEscolar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Periodo", ID_Periodo),
                new Clase_Parametros("ID_Modalidad", ID_Modalidad),
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
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
        #endregion
    }

    public class Clase_Grupos : Clase_Conecta
    {
        #region Propiedades
        public int Condicion { get; set; }
        public string Periodo { get; set; }
        public int Rvoe { get; set; }
        public string Gpo { get; set; }
        public int Salon { get; set; }
        public int Ingles { get; set; }
        public int GpoGeneracion { get; set; }
        public string ID_Grupo { get; set; }
        public string TipoOpt { get; set; }
        public string PeriodoVirtual { get; set; }

        public string ID_Empleado_Docente { get; set; }//Para asignar un docente a los grupos de inglés
        public string ID_GrupoIngles_NombreGrupo { set; get; }
        #endregion

        #region Constructores
        public Clase_Grupos() { }
        public Clase_Grupos(int condicion, string periodo, int rvoe, string gpo, int salon, int ingles)
        {
            Condicion = condicion;
            Periodo = periodo;
            Rvoe = rvoe;
            Salon = salon;
            Gpo = gpo;
            Ingles = ingles;
        }
        public Clase_Grupos(int condicion, string periodo, int rvoe, string gpo, int salon, int ingles, string id_empleado_docente)
        {
            Condicion = condicion;
            Periodo = periodo;
            Rvoe = rvoe;
            Salon = salon;
            Gpo = gpo;
            Ingles = ingles;
            ID_Empleado_Docente = id_empleado_docente;
        }
        public Clase_Grupos(string id_grupo) { ID_Grupo = id_grupo; }
        public Clase_Grupos(int condicion, string periodo, int rvoe, string gpo, int salon, int ingles, int generacion, string tipOpt)
        {
            Condicion = condicion;
            Periodo = periodo;
            Rvoe = rvoe;
            Salon = salon;
            Gpo = gpo;
            Ingles = ingles;
            GpoGeneracion = generacion;
            TipoOpt = tipOpt;
        }
        public Clase_Grupos(int condicion, string periodo, int rvoe, string gpo, int salon, int ingles, int generacion, string tipOpt, string id_empleado_docente)
        {
            Condicion = condicion;
            Periodo = periodo;
            Rvoe = rvoe;
            Salon = salon;
            Gpo = gpo;
            Ingles = ingles;
            GpoGeneracion = generacion;
            TipoOpt = tipOpt;
            ID_Empleado_Docente = id_empleado_docente;
        }
        public Clase_Grupos(int condicion, string periodo, int rvoe, string gpo)
        {
            Condicion = condicion;
            Periodo = periodo;
            Rvoe = rvoe;
            Gpo = gpo;
        }
        public Clase_Grupos(string periodo, int rvoe, string gpo, int salon, int ingles, int gpoGeneracion, string tipoOpt, string iD_Empleado_Docente, string iD_GrupoIngles_NombreGrupo)
        {
            Periodo = periodo;
            Rvoe = rvoe;
            Gpo = gpo;
            Salon = salon;
            Ingles = ingles;
            GpoGeneracion = gpoGeneracion;
            TipoOpt = tipoOpt;
            ID_Empleado_Docente = iD_Empleado_Docente;
            ID_GrupoIngles_NombreGrupo = iD_GrupoIngles_NombreGrupo;
        }

        #endregion

        #region Métodos
        public bool InsertarGrupos()
        {
            string nomProce = "addGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("periodo", Periodo),
                new Clase_Parametros("rvoe", Rvoe.ToString()),
                new Clase_Parametros("gpo", Gpo),
                new Clase_Parametros("salon", Salon.ToString()),
                new Clase_Parametros("ingles", Ingles.ToString()),
                new Clase_Parametros("generacion", GpoGeneracion.ToString()),
                new Clase_Parametros("opt", TipoOpt.ToString())
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
        public bool InsertarGrupoCID()
        {
            string nomProce = "InsertarGrupoCID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Periodo", Periodo),
                new Clase_Parametros("ID_Rvoe", Rvoe.ToString()),
                new Clase_Parametros("Grupo", Gpo),
                new Clase_Parametros("ID_Salon", Salon.ToString()),
                new Clase_Parametros("Ingles", Ingles.ToString()),
                new Clase_Parametros("Generacion", GpoGeneracion.ToString()),
                new Clase_Parametros("ID_Optativa", TipoOpt.ToString()),
                new Clase_Parametros("ID_Empleado_Docente", ID_Empleado_Docente),
                new Clase_Parametros("ID_GrupoIngles_NombreGrupo", ID_GrupoIngles_NombreGrupo)
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
        public bool InsertarGruposVirtual()
        {
            string nomProce = "addGrupoVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("periodo", Periodo),
                new Clase_Parametros("rvoe", Rvoe.ToString()),
                new Clase_Parametros("gpo", Gpo)
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
        public bool UpdateGrupo(string ID_Grupo, string ID_Salon, string GpoGeneracion)
        {
            string nomStore = "UpdateGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo),
                new Clase_Parametros("ID_Salon", ID_Salon),
                new Clase_Parametros("GpoGeneracion", GpoGeneracion)
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
        public bool UpdateGrupoCID(string ID_Grupo, string ID_Salon, string GpoGeneracion, string ID_Optativa, string ID_Empleado_Docente, string ID_GrupoIngles_NombreGrupo)
        {
            string nomProce = "UpdateGrupoCID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo),
                new Clase_Parametros("ID_Salon", ID_Salon),
                new Clase_Parametros("GpoGeneracion", GpoGeneracion),
                new Clase_Parametros("ID_Optativa", ID_Optativa),
                new Clase_Parametros("ID_Empleado_Docente", ID_Empleado_Docente),
                new Clase_Parametros("ID_GrupoIngles_NombreGrupo", ID_GrupoIngles_NombreGrupo)

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
        public bool ConsultaComboGrupos()
        {
            string nomStore = "comboGrupo";
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConsultaHorariosXGrupo(string grupo)
        {
            string nomProce = "ConsultaHorariosXGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo)
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
        public bool ConsultaHorariosXGrupoExamen(string grupo, string id_materia, string tipo)
        {
            string nomProce = "ConsultaHorariosExamen";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("id_materia", id_materia),
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
        public bool ConsultaHorariosXMateria(string id_materia_grupo)
        {
            string nomProce = "GetMateriasGrupoHorario";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_materia_grupo", id_materia_grupo)
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
        public bool SaveHorarioTemporal(string id_materia_grupo, string dia, string hora)
        {
            string nomProce = "SaveHorarioTemporal";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_materia_grupo", id_materia_grupo),
                new Clase_Parametros("dia", dia),
                new Clase_Parametros("hora", hora),
                new Clase_Parametros("id_empleado", Clase_Sesion.IDEmpleado),
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
       
        public bool CambiaDocente(string id_materia_grupo, string id_docente, string observaciones, string fecha_inicio, string fecha_termino)
        {
            string nomProce = "CambioDocente";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_materia_grupo", id_materia_grupo),
                new Clase_Parametros("fecha_inicio", fecha_inicio),
                new Clase_Parametros("fecha_termino", fecha_termino),

                new Clase_Parametros("id_empleado_nuevo",id_docente),
                new Clase_Parametros("observaciones",observaciones),
                new Clase_Parametros("tipo","2"),
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
        public bool ValidaDocente(string id_materia_grupo, string id_docente, string fecha_inicio)
        {
            string nomProce = "GetEmpalmeDocente";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_materia_grupo", id_materia_grupo),
                new Clase_Parametros("fecha_inicio", fecha_inicio),
           
                new Clase_Parametros("id_empleado",id_docente),
                new Clase_Parametros("tipo","2"),
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
        public bool ConsultaGpo_Grupo(string ID_Grupo)
        {
            string nomProce = "Consulta_Gpo_Grupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo)
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
        public bool GetGrupoDatosParaModificar()
        {
            string nomStore = "GetGrupoDatosParaModificar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo)
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
        public bool ConsultaHorariosXGrupoModular(string grupo, string modulo)
        {
            string nomProce = "ConsultaHorariosXGrupoModular";

            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("modulo", modulo)
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
        public bool ConsultaHorariosXProfesor(string profesor, string cicloescolar)
        {
            string nomProce = "ConsultaHorariosXProfesor";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("cicloescolar", cicloescolar)
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
        public bool ConsultaHorariosXProfesorModular(string profesor, string cicloescolar, string Modular)
        {
            string nomProce = "ConsultaHorariosXProfesorModular";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("cicloescolar", cicloescolar),
                new Clase_Parametros("Modulo", Modular)
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
        public bool ConsultaGruposXEspecialidadCampus(string ID_Especialidad, string ID_Campus, string ID_RVOE, string tipo)
        {
            string nomStore = "consultaGruposXEspecialidadCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Especialidad", ID_Especialidad),
                new Clase_Parametros("ID_Campus", ID_Campus),
                new Clase_Parametros("ID_RVOE", ID_RVOE),
                new Clase_Parametros("tipo", tipo)
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
        public bool ActualizarHorariosClase(string hora, string dia, string profesor, string grupo, string materia, bool compartida, string empleado, bool virt)
        {
            string nomProce = "addHorariosdeClase";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("hora", hora),
                new Clase_Parametros("dia", dia),
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("materia", materia),
                new Clase_Parametros("compartida", compartida.ToString()),
                new Clase_Parametros("id_empleado", empleado),
                new Clase_Parametros("virtual", virt.ToString())
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
        public bool InsertarLibrosAlphaXMateria(string grupo, string materia)
        {
            string nomProce = "InsertarLibrosAlphaXMaterias";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("materia", materia)
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
        public bool ActualizarHorariosClaseModular(string hora, string dia, string profesor, string grupo, string materia, bool compartida, string empleado, string modulo, string fechaI, string fechaT)
        {
            string nomProce = "addHorariosdeClaseModulo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("hora", hora),
                new Clase_Parametros("dia", dia),
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("materia", materia),
                new Clase_Parametros("compartida", compartida.ToString()),
                new Clase_Parametros("id_empleado", empleado),
                new Clase_Parametros("modulo", modulo),
                new Clase_Parametros("FechaInicio", fechaI),
                new Clase_Parametros("FechaTermino", fechaT)
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
        public bool ActualizaHoraClaseMod_Virtual(string hora, string dia, string profesor, string grupo, string materia, bool compartida, string empleado, string modulo, string fechaI, string fechaT)
        {
            string nomProce = "addHorariosdeClaseModulo_Virtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("hora", hora),
                new Clase_Parametros("dia", dia),
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("materia", materia),
                new Clase_Parametros("compartida", compartida.ToString()),
                new Clase_Parametros("id_empleado", empleado),
                new Clase_Parametros("modulo", modulo),
                new Clase_Parametros("FechaInicio", fechaI),
                new Clase_Parametros("FechaTermino", fechaT)
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
        public bool EliminarGrupoModular(string materia, string modulo)
        {
            string nomProce = "dltMateriasXGrupoModulo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("materia", materia),
                new Clase_Parametros("modulo", modulo)
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
        public bool EliminarGrupo(string materia)
        {
            string nomProce = "dltMateriasXGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("materia", materia)
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
        public bool RevisarEmpalmes(string profesor, string hora, string dia, string grupo, string ciclo)
        {
            string nomProce = "ConsultaEmpalmesProfesores";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("hora", hora),
                new Clase_Parametros("dia", dia),
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("ciclo", ciclo)
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
        public bool RevisarEmpalmesModular(string profesor, string hora, string dia, string grupo, string ciclo, string modulo, string fechaInicio)
        {
            string nomProce = "ConsultaEmpalmesProfesoresModulo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("hora", hora),
                new Clase_Parametros("dia", dia),
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("ciclo", ciclo),
                new Clase_Parametros("modulo", modulo),
                new Clase_Parametros("fechaInicio", fechaInicio)
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
        public bool RevisarEmpalmesModularFecha(string profesor, string hora, string dia, string grupo, string ciclo, string modulo, string inicio, string termino)
        {
            string nomProce = "ConsultaEmpalmesProfModFecha";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("hora", hora),
                new Clase_Parametros("dia", dia),
                new Clase_Parametros("grupo", grupo),
                new Clase_Parametros("ciclo", ciclo),
                new Clase_Parametros("modulo", modulo),
                new Clase_Parametros("fInicio", Convert.ToDateTime(inicio).ToString("yyyyMMdd")),
                new Clase_Parametros("fTermino", Convert.ToDateTime(termino).ToString("yyyyMMdd"))
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
        public bool NumeroHorasXMateria(string materia)
        {
            string nomProce = "NumeroHorasXMateria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("materia", materia)
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
        public bool NumeroHorasXMateria2(string materia, string id_grupo)
        {
            string nomProce = "NumeroHorasXMateria2";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("materia", materia),
                new Clase_Parametros("id_grupo", id_grupo)
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
        public bool SaveHorarioExamen(string id_materia_grupo, string tipo, string fecha, string id_empleadoReg, DataTable table, string id_grupo, string vir)
        {
            string nomProce = "Registro_HorarioExamenes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("id_materia_grupo", id_materia_grupo),
                new Clase_Parametros("id_grupo", id_grupo),
                new Clase_Parametros("tipo", tipo),
                new Clase_Parametros("fecha", fecha),
                new Clase_Parametros("id_empleadoReg", id_empleadoReg),
                new Clase_Parametros("horario", table),
                new Clase_Parametros("virtual", vir),
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
        public bool NumeroHorasXMateriaEnGrupo(string materia, string grupo)
        {
            string nomProce = "NumeroHorasXMateriaEnGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("materia", materia),
                new Clase_Parametros("grupo", grupo)
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
        public bool NumeroHorasXMateriaEnGrupo_Modular(string id_materia, string id_grupo, string modulo)
        {
            string nomProce = "NumeroHorasXMateriaEnGrupo_Modular";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Materia", id_materia),
                new Clase_Parametros("ID_Grupo", id_grupo),
                new Clase_Parametros("Modulo", modulo)
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
        public bool NumeroHorasProfesorenGrupos(string profesor, string cicloescolar, string fechaInicio, string fechaTermino)
        {
            string nomProce = "NumeroHorasProfesorenGrupos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("cicloescolar", cicloescolar),
                new Clase_Parametros("FechaInicio", fechaInicio),
                new Clase_Parametros("FechaTermino", fechaTermino)
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
        public bool NumeroHorasPermitidasXProfesor(string profesor)
        {
            string nomProce = "NumeroHorasPermitidasXProfesor";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("profesor", profesor)
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
        public bool ConsultaInformacionGrupo()
        {
            string nomProce = "ConsultaInformacionGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_grupo", ID_Grupo)
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
        #region CódigoComentado
        /*
        public bool NumeroHorasProfesorenGruposModular(string profesor, string cicloescolar, string modulo)
        {

            string nomProce = "NumeroHorasProfesorenGruposModular";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("cicloescolar", cicloescolar),
                new Clase_Parametros("modulo", modulo)
            };
            if (ConsultarParametros(nomProce, par))
                return true;
            else
                return false;
        }
        */
        #endregion
        public bool AutorizacionModificarHorarios(string campus)
        {
            string nomProce = "AutorizacionModificarHorarios";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("@ID_Campus", campus)
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
        public bool NumeroHorasProfesorenGruposModular(string profesor, string cicloescolar, string FechaInicio, string FechaTermino/*string modulo*/)
        {
            string nomProce = "NumeroHorasProfesorenGruposModular";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("profesor", profesor),
                new Clase_Parametros("cicloescolar", cicloescolar),
                new Clase_Parametros("fechaInicio", FechaInicio),
                new Clase_Parametros("fechaTermino",FechaTermino)
                //new Clase_Parametros("modulo", modulo)
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
        public bool ConsultaHorariosClase(string grupo)
        {
            string nomProce = "HorasXMateria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("grupo", grupo)
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
        public bool ActualizarGrupoModuloPartes(bool moduloParte)
        {
            string nomProce = "ActualizarGrupoModuloPartes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", ID_Grupo),
                new Clase_Parametros("ModuloPartes", moduloParte.ToString())
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
        public bool ConsultaHorasCargadasGrupo(string modulo)
        {
            try
            {
                string nomProce = "ConsultaHorasCargadasGrupo";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo),
                    new Clase_Parametros("Modulo", modulo)
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
            catch (Exception)
            {
                return false;
            }
        }
        public bool GetGrupoModular()
        {
            try
            {
                string nomProce = "GetGrupoModular";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo)
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
            catch (Exception)
            {
                return false;
            }
        }
        public bool GetGrupoCicloEscolarEspecialidadRvoe(string ID_Periodo, string ID_Especialidad, string ID_Rvoe)
        {
            try
            {
                string nomProce = "GetGrupoCicloEscolarEspecialidadRvoe";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Periodo", ID_Periodo),
                    new Clase_Parametros("ID_Especialidad", ID_Especialidad),
                    new Clase_Parametros("ID_Rvoe", ID_Rvoe),
                    new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
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
            catch (Exception)
            {
                return false;
            }
        }

        public bool GetGrupoCursoTitulacion(string ID_Periodo)
        {
            try
            {
                string nomProce = "Titulacion_GetGrupos";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("id_periodo", ID_Periodo),
                    new Clase_Parametros("id_campus", Clase_Sesion.Campus),


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
            catch (Exception)
            {
                return false;
            }
        }
        public bool Grupo_Horas_Alumnos()
        {
            try
            {
                string nomProce = "Grupo_Horas_Alumnos";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", ID_Grupo)
                };

                if (ConsultarParametros(nomProce, par))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CambiodeGrupovirtual(string Alumno,string grupo_actual, string grupo_nuevo,string empleado)
		{
            try
            {
                string nomProce = "CambiarAlumnoGrupoVirtual";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {

                    new Clase_Parametros("Id_Alumno", Alumno),
                    new Clase_Parametros("ID_Grupo", grupo_actual),
                    new Clase_Parametros("ID_GrupoNuevo", grupo_nuevo),
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
            catch (Exception)
            {
                return false;
            }
        }


        #endregion
    }

    public class Clase_TablaMaterias
    {
        #region Propiedades
        public string Materia { set; get; }
        public string Profesor { set; get; }
        public string Dia { set; get; }
        public string Hora { set; get; }
        public string Grupo { set; get; }
        public bool Compartida { set; get; }
        public string Empleado { set; get; }
        public string Salon { set; get; }
        public string Gpo { set; get; }
        public string Especialidad { set; get; }
        public string Rvoe { set; get; }
        public string Modulo { set; get; }
        public string Costo { set; get; }
        public string FechaI { set; get; }
        public string FechaT { set; get; }
        public bool Virtual { set; get; }
        #endregion

        #region Constructores
        public Clase_TablaMaterias(string mat, string p1, string dia1, string p2, string p3, bool p4, string p5, string salon, string gpo, string especialidad, string rvoe, string modulo, string costoMa, string feI, string feT, bool virt)
        {
            Materia = mat;
            Profesor = p1;
            Dia = dia1;
            Hora = p2;
            Grupo = p3;
            Compartida = p4;
            Empleado = p5;
            Salon = salon;
            Gpo = gpo;
            Especialidad = especialidad;
            Rvoe = rvoe;
            Modulo = modulo;
            Costo = costoMa;
            FechaI = feI;
            FechaT = feT;
            Virtual = virt;
        }
        public Clase_TablaMaterias() { }

        #endregion

        #region Métodos
        public bool EsIgual(string dia, string hora)
        {
            return Dia == dia && Hora == hora;
        }
        #endregion
    }

    public class Clase_TipoPlan : Clase_Conecta
    {
        #region Propiedades
        public string Idtipoplan { get; set; }
        public string Descripcionplan { get; set; }
        public string Abreviaturaplan { get; set; }
        #endregion

        #region Constructores
        public Clase_TipoPlan(string idtipoplan, string descripcionplan, string abreviaturaplan)
        {
            Idtipoplan = idtipoplan;
            Descripcionplan = descripcionplan;
            Abreviaturaplan = abreviaturaplan;
        }
        public Clase_TipoPlan() { }
        #endregion

        #region Métodos
        public bool InsertarTipoPlan()
        {
            string nomProce = "addTipoPlan";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("tipoplan", Idtipoplan),
                new Clase_Parametros("descripcion", Descripcionplan),
                new Clase_Parametros("abreviatura", Abreviaturaplan)
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
        public bool ConsultaComboTipoPlan(string campus)
        {
            string nomStore = "comboPlan";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("campus", campus)
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
        public bool ConsultaTipoPlan(string TipoPlan)
        {
            string nomProce = "ConsultaTipoPlan";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", TipoPlan)
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

        public bool GetTipoPlanCicloEscolar(string ID_Periodo)
        {
            string nomProce = "GetTipoPlanCicloEscolar";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Periodo", ID_Periodo),
                new Clase_Parametros("ID_Campus", Clase_Sesion.Campus),
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

        public bool ConsultaTipoPlanXCicloEscolar(string ID_CEscolar)
        {
            string nomProce = "consultaTipoPlanXCiclo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_CEscolar", ID_CEscolar)
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

    public class Clase_TipoPlanCampus : Clase_Conecta
    {
        #region Propiedades
        public string Tipoplan { get; set; }
        public string Campus { get; set; }
        #endregion

        #region Consrtuctores
        public Clase_TipoPlanCampus(string tipoplan, string campus)
        {
            Tipoplan = tipoplan;
            Campus = campus;
        }
        public Clase_TipoPlanCampus() { }
        #endregion

        #region Métodos
        public bool InsertarTipoPlanCampus()
        {
            string nomProce = "addTipoPlanCampus";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("TipoPlan", Tipoplan),
                new Clase_Parametros("Campus", Campus)
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

    public class Clase_Tipo_Plan_Fechas : Clase_Conecta
    {
        #region Propiedades
        public string ID_Movimiento { get; set; }
        public string ID_Campus { get; set; }
        public string ID_Periodo { get; set; }
        public int Unidad { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Termino { get; set; }
        #endregion

        #region Constructores
        public Clase_Tipo_Plan_Fechas(string iD_Movimiento, string iD_Campus, string iD_Periodo, int unidad, DateTime fecha_Inicio, DateTime fecha_Termino)
        {
            ID_Movimiento = iD_Movimiento;
            ID_Campus = iD_Campus;
            ID_Periodo = iD_Periodo;
            Unidad = unidad;
            Fecha_Inicio = fecha_Inicio;
            Fecha_Termino = fecha_Termino;
        }
        public Clase_Tipo_Plan_Fechas() { }
        #endregion

        #region Métodos
        public bool ConsultaTipoPlanFechas(string campus, string modalidad, string periodo)
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
        public bool AddTipoPlanFechas(string campus, string modalidad, string periodo, string unidad, string inicio, string termino)
        {
            string nomStore = "addTipoPlanFechas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", campus),
                new Clase_Parametros("TipoPlan", modalidad),
                new Clase_Parametros("Periodo", periodo),
                new Clase_Parametros("Unidad", unidad),
                new Clase_Parametros("FechaInicio", inicio),
                new Clase_Parametros("FechaTermino", termino)
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
        public bool ActualizaTipoPlanFechas(string campus, string modalidad, string periodo, string unidad, string inicio, string termino)
        {
            string nomStore = "upTipoPlanFechas";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("Campus", campus),
                new Clase_Parametros("TipoPlan", modalidad),
                new Clase_Parametros("Periodo", periodo),
                new Clase_Parametros("Unidad", unidad),
                new Clase_Parametros("FechaInicio", inicio),
                new Clase_Parametros("FechaTermino", termino)
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

    public sealed class Clase_Variables
    {
        #region Propiedades
        public const string CRITERIO_PROMEDIO_REDONDEO_ENTERO = "ENTERO";
        public const string CRITERIO_PROMEDIO_REDONDEO_1DECIMAL = "1 DECIMAL";
        public const string CRITERIO_PROMEDIO_REDONDEO_2DECIMALES = "2 DECIMALES";
        #endregion
    }

    public class Clase_Grupos_Alumnos : Clase_Conecta
    {
        #region Propeidades
        public string Condicion { set; get; }
        public string Gpo { set; get; }
        public string Alumno { set; get; }
        public DateTime Fechareg { set; get; }
        public string Empleado { set; get; }
        #endregion

        #region Constructores
        public Clase_Grupos_Alumnos()
        {

        }
        public Clase_Grupos_Alumnos(string condicion, string gpo, string alumno, DateTime fechareg, string empleado)
        {
            Condicion = condicion;
            Gpo = gpo;
            Alumno = alumno;
            Fechareg = fechareg;
            Empleado = empleado;
        }
        #endregion

        #region Métodos
        public bool EliminarGrupos_Alumnos(int grupo)
        {
            string nomProce = "EliminarAlumnoDeGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Grupo", grupo.ToString()),
                new Clase_Parametros("ID_Alumno", Alumno)
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
        public bool InsertarGrupos_Alumnos()
        {
            string nomProce = "pasarAlumnoAGrupo";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("nivel", Condicion.ToString()),
                new Clase_Parametros("gpo", Gpo.ToString()),
                new Clase_Parametros("alumno", Alumno),
                new Clase_Parametros("fechareg", Fechareg.ToString()),
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
        #region Nuevo Proceso para generaCalificaciones
        public bool InsertarMateriasGrupo(string id_grupo)
        {
            try
            {
                string nomProce = "InsertarMateriasGrupo";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                    new Clase_Parametros("ID_Grupo", id_grupo)
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
            catch (Exception e)
            {
                MessageBox.Show("¡Ocurrio un error al generar los registros de calificaciones de las materias del grupo!. " + e.HResult + "\n" + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #endregion
    }

    public class Clase_Horarios : Clase_Conecta
    {
        #region Propiedades
        public int Condicion { set; get; }
        public string IdHorario { set; get; }
        public string Descripcion { set; get; }
        public DateTime Hora { set; get; }
        #endregion

        #region Constructores
        public Clase_Horarios(string idHorario, string descripcion, DateTime hora)
        {
            _ = Condicion;
            IdHorario = idHorario;
            Descripcion = descripcion;
            Hora = hora;
        }
        public Clase_Horarios()
        {
        }
        #endregion

        #region Métodos
        public bool InsertarHorarios()
        {
            string nomProce = "addHorarios";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("idHorario", IdHorario),
                new Clase_Parametros("Descripcion", Descripcion),
                new Clase_Parametros("hora", Hora.ToString())
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
        public bool ActualizarHorarios()
        {
            string nomProce = "upHorarios";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("condicion", Condicion.ToString()),
                new Clase_Parametros("Descripcion", Descripcion),
                new Clase_Parametros("hora", Hora.ToString())
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
        public bool ConsultaComboHorarios()
        {
            string nomStore = "comboHorario";
            if (Consultar(nomStore))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpCubierta()
        {
            string nomProce = "upCubierta";
            if (Consultar(nomProce))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InfoEmpleado(string id)
        {
            string nomProce = "InfoEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id", id)
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

        public bool ValidarComprobantes(string id_empleado, string fecha_inicio, string fecha_termino)
        {
            string nomProce = "validarComprobantes";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("id_empleado", id_empleado),
                new Clase_Parametros("fecha_i_contrato", fecha_inicio),
                new Clase_Parametros("fecha_f_contrato", fecha_termino),
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

        public bool addContratosDocente(string id_periodo,string id_empleado, string fecha_inicio, string fecha_termino,string rutacontrato)
        {
            string nomProce = "addContratoDocente";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Periodo", id_periodo),
                new Clase_Parametros("ID_Empleado", id_empleado),
                new Clase_Parametros("FI", fecha_inicio),
                new Clase_Parametros("FF", fecha_termino),
                new Clase_Parametros("RutaContrato", rutacontrato)
            };
            if (Ejecuta(nomProce,par))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarDocumentacion(string id_empleado)
        {
            string nomProce = "contratos_revDocumentacion";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
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
        public bool BorrarGrupo(string grupo)
        {
            string nomProce = "DeleteGrupos";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                //estamos poniendo el nombre del parametro en la tabla y el valor
                new Clase_Parametros("ID_Grupo", grupo)
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

        public bool GenHorarioVirtual(string grupo)
        {
            string nomProce = "genHorarioVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("@ID_Grupo", grupo)
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

        public bool EliminaMateriaGrupoVirtual(string grupo, string materia)
        {
            string nomProce = "eliminaMateriaGrupoVirtual";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("@ID_Materia", materia),
                new Clase_Parametros("@ID_Grupo", grupo)
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

    public class CalendarColumn : DataGridViewColumn
    {
        #region Constructores
        public CalendarColumn() : base(new CalendarCell()) { }
        #endregion

        #region Método
        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                // Ensure that the cell used for the template is a CalendarCell.
                if (value != null && !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
        }
        #endregion
    }

    public class TimeColumn : DataGridViewColumn
    {
        #region Constructores
        public TimeColumn() : base(new TimeCell()) { }
        public TimeColumn(string frm) : base(new TimeCell(frm)) { }

        #endregion

        #region Métodos
        public void SetValue(string frm) { base.CellTemplate.Value = frm; }
        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(TimeCell)))
                {
                    throw new InvalidCastException("Must be a TimeCell");
                }
                base.CellTemplate = value;
            }
        }
        #endregion
    }

    public class TimeCell : DataGridViewTextBoxCell
    {
        #region Constructores
        public TimeCell() : base()
        {
            this.Style.Format = "hh:mm tt";
        }
        public TimeCell(string frm) : base()
        {
            this.Style.Format = frm;
        }
        #endregion

        #region Métodos
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            try
            {
                base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
                TimeEditingControl ctl = DataGridView.EditingControl as TimeEditingControl;
                ctl.Format = DateTimePickerFormat.Time;
                ctl.ShowUpDown = true;
                ctl.Value = (DateTime)this.Value;
            }
            catch { }
        }
        public override Type EditType => typeof(TimeEditingControl);
        public override Type ValueType => typeof(DateTime);
        public override object DefaultNewRowValue => DateTime.Now;
        #endregion
    }

    //public class StripeColumn : DataGridViewColumn
    //{
    //    #region Constructores
    //    //string color;
    //    /*
    //    public StripeColumn() : base(new StripeCell())
    //    {
    //        ReadOnly = true;
    //    }
    //    */
    //    #endregion
    //}

    //public class StripeCell : DataGridViewTextBoxCell
    //{
    //    #region Métodos
    //    //String color;
    //    public StripeCell() : base()
    //    {
    //        //color = columna;
    //    }

    //    /* protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,
    //         object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
    //     {
    //         base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

    //         var cellValue = (string)value;
    //         //const int vertoffset = 0;
    //         const int horizontaloffset = 0;
    //         var newRect = new Rectangle(
    //            cellBounds.X + horizontaloffset,
    //            cellBounds.Y + cellBounds.Height - 10,
    //            cellBounds.Width,
    //            8);
    //         graphics.FillRectangle(new SolidBrush(GetColor(cellValue)), newRect);
    //     }

    //     void DrawString(Graphics graphics, Rectangle cellBounds, DataGridViewElementStates cellState, string cellText)
    //     {
    //         Font fnt = new Font("Arial", 12, GraphicsUnit.Pixel);
    //         //SizeF textSize = graphics.MeasureString(cellText, fnt);

    //         Color textColor = Color.Black;
    //         if ((cellState & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
    //             textColor = InheritedStyle.SelectionForeColor;

    //         using (SolidBrush brush = new SolidBrush(textColor))
    //         {
    //             graphics.DrawString(cellText, fnt, brush,
    //             cellBounds.X,
    //             cellBounds.Y);
    //         }
    //     }
    //     */
    //    /*private static Color GetColor()
    //    {
    //        #region CódigoComentado
    //        //if (data == "Lunes")
    //        //Red
    //        //if (data == "Martes")
    //        //Blue
    //        //return Color.FromArgb(51, 153, 255);

    //        // if (data == "Miercoles")
    //        //Yellow
    //        //return Color.FromArgb(255, 204, 102);

    //        // if (data == "Jueves")
    //        //Green
    //        //return Color.FromArgb(0, 204, 0);

    //        // if (data == "Viernes")
    //        //Gray
    //        //return Color.FromArgb(Color.Gray.ToArgb());

    //        //if (data == "Sabado")
    //        //Brown
    //        //return Color.FromArgb(Color.Brown.ToArgb());

    //        // if (data == "Domingo")
    //        //Magenta    
    //        //return Color.FromArgb(Color.Magenta.ToArgb());

    //        //return Color.White; 
    //        #endregion

    //        return Color.FromArgb(255, 51, 0);
    //    }*/
    //    #endregion
    //}

    internal class TimeEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        #region Constructor
        public TimeEditingControl()
        {
            Format = DateTimePickerFormat.Custom;
        }
        #endregion

        #region Métodos
        public object EditingControlFormattedValue
        {
            get => Value.ToShortTimeString();
            set
            {
                if (value is string newValue)
                {
                    Value = DateTime.Parse(newValue);
                }
            }
        }
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
        }
        public int EditingControlRowIndex { get; set; }
        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                case Keys.Tab:
                    return true;
                default:
                    return false;
            }
        }
        public void PrepareEditingControlForEdit(bool selectAll) { }
        public bool RepositionEditingControlOnValueChange => false;
        public DataGridView EditingControlDataGridView { get; set; }
        public bool EditingControlValueChanged { get; set; } = false;
        public Cursor EditingPanelCursor => base.Cursor;
        protected override void OnValueChanged(EventArgs eventargs)
        {
            EditingControlValueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
        #endregion
    }

    internal class CalendarCell : DataGridViewTextBoxCell
    {
        #region Constructor
        public CalendarCell()
            : base()
        {
            // Use the short date format.
            this.Style.Format = "dd MMM yy";
        }
        #endregion

        #region Métodos
        public override void InitializeEditingControl(int rowIndex, object
        initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            CalendarEditingControl ctl = DataGridView.EditingControl as CalendarEditingControl;
            try
            {
                if (this.Value != DBNull.Value)
                {
                    ctl.Value = (DateTime)this.Value;
                }
            }
            catch { }
        }
        public override Type EditType =>
                // Return the type of the editing contol that CalendarCell uses.
                typeof(CalendarEditingControl);
        public override Type ValueType =>
                // Return the type of the value that CalendarCell contains.
                typeof(DateTime);
        public override object DefaultNewRowValue =>
                // Use the current date and time as the default value.
                "";///DateTime.Now;

        #endregion
    }

    internal class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        #region Constructor
        public CalendarEditingControl()
        {
            this.Format = DateTimePickerFormat.Short;
        }
        #endregion

        #region Métodos
        // Implements the IDataGridViewEditingControl.EditingControlFormattedValue
        // property.
        public object EditingControlFormattedValue
        {
            get => this.Value.ToShortDateString();
            set
            {
                if (value is string)
                {
                    this.Value = DateTime.Parse((String)value);
                }
            }
        }

        // Implements the
        // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
        public object GetEditingControlFormattedValue(
        DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        // Implements the
        // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
        public void ApplyCellStyleToEditingControl(
        DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            CalendarForeColor = dataGridViewCellStyle.ForeColor;
            CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        // Implements the IDataGridViewEditingControl.EditingControlRowIndex
        // property.
        public int EditingControlRowIndex { get; set; }

        // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey
        // method.
        public bool EditingControlWantsInputKey(
        Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit
        // method.
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // No preparation needs to be done.
        }

        // Implements the IDataGridViewEditingControl
        // .RepositionEditingControlOnValueChange property.
        public bool RepositionEditingControlOnValueChange => false;

        // Implements the IDataGridViewEditingControl
        // .EditingControlDataGridView property.
        public DataGridView EditingControlDataGridView { get; set; }

        // Implements the IDataGridViewEditingControl
        // .EditingControlValueChanged property.
        public bool EditingControlValueChanged { get; set; } = false;

        // Implements the IDataGridViewEditingControl
        // .EditingPanelCursor property.
        public Cursor EditingPanelCursor => base.Cursor;

        protected override void OnValueChanged(EventArgs eventargs)
        {
            // Notify the DataGridView that the contents of the cell
            // have changed.
            EditingControlValueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
        #endregion
    }

    public class Clase_MaestroMateria_Virtual : Clase_Conecta
    {
        #region Propiedades
        public int ID_MaestroMateria_Virtual { get; set; }
        public string ID_Empleado { get; set; }
        public int ID_Materia { get; set; }

        public decimal Costo { get; set; }

        #endregion

        #region Constructor
        public Clase_MaestroMateria_Virtual(int iD_MaestroMateria_Virtual, string iD_Empleado, int iD_Materia, decimal costo)
        {
            ID_MaestroMateria_Virtual = iD_MaestroMateria_Virtual;
            ID_Empleado = iD_Empleado;
            ID_Materia = iD_Materia;
            this.Costo = costo;
        }

        public Clase_MaestroMateria_Virtual(int iD_MaestroMateria_Virtual, string iD_Empleado, int iD_Materia)
        {
            ID_MaestroMateria_Virtual = iD_MaestroMateria_Virtual;
            ID_Empleado = iD_Empleado;
            ID_Materia = iD_Materia;
        }
        public Clase_MaestroMateria_Virtual(int iD_MaestroMateria_Virtual)
        {
            ID_MaestroMateria_Virtual = iD_MaestroMateria_Virtual;
        }

        public Clase_MaestroMateria_Virtual(string id_empleado)
        {
            ID_Empleado = id_empleado;
        }


        public Clase_MaestroMateria_Virtual()
        {

        }
        #endregion

        #region Métodos
        public bool GetMaestroMateriaByID()
        {
            string nomProce = "GetMaestroMateriaByID";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_MaestroMateria_Virtual", ID_MaestroMateria_Virtual.ToString())
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

        public bool GetMaestroMateriaByEmpleado()
        {
            string nomProce = "GetMaestroMateriaByEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", ID_Empleado.ToString())
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

        public bool UpdateMaestroMateria()
        {
            string nomProce = "UpdateMaestroMateria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_MaestroMateria_Virtual", ID_MaestroMateria_Virtual.ToString()),
                new Clase_Parametros("ID_Empleado", ID_Empleado),
                new Clase_Parametros("ID_Materia", ID_Materia.ToString()),
                new Clase_Parametros("Costo", Costo.ToString())
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

        public bool DeleteMaestroMateria()
        {
            string nomProce = "DeleteMaestroMateria";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_MaestroMateria_Virtual", ID_MaestroMateria_Virtual.ToString())
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

        public bool ConsultaMateriasVirtualPorEmpleado()
        {
            string nomProce = "ConsultaMateriasVirtualPorEmpleado";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_Empleado", ID_Empleado.ToString())
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

        public bool ConsultaMateriasVirtualPorIDMMV()
        {
            string nomProce = "ConsultaMateriasVirtualPorIDMMV";
            List<Clase_Parametros> par = new List<Clase_Parametros>
            {
                new Clase_Parametros("ID_MaestroMateria_Virtual", ID_MaestroMateria_Virtual.ToString())
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

    public class Clase_CalificacionesVirtualPlataforma : Clase_Conecta
    {
        #region Propiedades
        public string Alumno { get; set; }
        public bool Actualiza { get; set; }
        public string ClaveOne { get; set; }
        public string ClavePlataforma { get; set; }
        public decimal CalificacionOne { get; set; }
        public decimal CalificacionPlataforma { get; set; }
        public string Materia { get; set; }
        #endregion

        #region Constructor
        public Clase_CalificacionesVirtualPlataforma()
        {

        }
        #endregion

        #region Métodos
        public bool ConsultaConfigServersVirtual()
        {
            string nomProce = "ConsultaConfigServersVirtual";

            //List<Clase_Parametros> par = new List<Clase_Parametros>;


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
    }

    public class Clase_GruposDocumentos : Clase_Conecta
    {
        #region Propiedades
        public string ID_Grupo { get; set; }
        public string ID_Materia_Grupo { get; set; }
        public string NombreDocumento { get; set; }
        public string RutaDocumento { get; set; }
        public string ID_Empleado { get; set; }
        public DateTime FechaEntrega { get; set; }
        public Int32 Parcial { get; set; }
        public Boolean General { get; set; }
        public string ObservacionesDocto { get; set; }
        public Boolean Activo { get; set; }
        #endregion

        #region Constructor
        public Clase_GruposDocumentos()
        {

        }
        public Clase_GruposDocumentos(string grupo, string materiaGrupo, string nombreDocumento, string rutaDocumento, string empleado,
                DateTime fechaEntrega, int parcial, Boolean general, string observa, Boolean activo)
        {
            ID_Grupo = grupo;
            ID_Materia_Grupo = materiaGrupo; string
            NombreDocumento = nombreDocumento;
            ID_Empleado = empleado;
            FechaEntrega = fechaEntrega;
            Parcial = parcial;
            General = general;
            ObservacionesDocto = observa;
            Activo = activo;
        }


        #endregion

        #region Métodos
        public bool addGrupoDocumento()
        {
            try
            {
                string nomProce = "addGrupoDocumento";
                List<Clase_Parametros> par = new List<Clase_Parametros>
                {
                new Clase_Parametros("idMateriaGrupo", ID_Materia_Grupo),
                new Clase_Parametros("grupo", ID_Grupo),
                new Clase_Parametros("nombreDocumento", NombreDocumento),
                new Clase_Parametros("rutaDocumento", RutaDocumento),
                new Clase_Parametros("Empleado", ID_Empleado),
                //new Clase_Parametros("fechaEntrega", DateTime.Now.ToString("yyyyyMMDD")),
                new Clase_Parametros("Parcial", Parcial.ToString()),
                new Clase_Parametros("General", General.ToString()),
                new Clase_Parametros("Observaciones", ObservacionesDocto ),
                new Clase_Parametros("Activo", Activo.ToString())
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
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}