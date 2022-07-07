using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoLoboSostenido
{
    public class Clase_Conecta
    {
        private string[] reservedWords = {
       " ADD "," EXTERNAL "," PROCEDURE "," ALL "," FETCH "," PUBLIC "," ALTER "," FILE "," RAISERROR "," AND "," FILLFACTOR "," READ "," ANY ",
           " FOR "," READTEXT "," AS "," FOREIGN "," RECONFIGURE "," ASC "," FREETEXT "," REFERENCES "," AUTHORIZATION ",
           " FREETEXTTABLE "," REPLICATION "," BACKUP "," FROM "," RESTORE "," BEGIN "," FULL "," RESTRICT "," BETWEEN "," FUNCTION "," RETURN ",
           " BREAK "," GOTO "," REVERT "," BROWSE "," GRANT "," REVOKE "," BULK "," GROUP "," RIGHT "," BY "," HAVING "," ROLLBACK "," CASCADE ",
           " HOLDLOCK "," ROWCOUNT "," CASE "," IDENTITY "," ROWGUIDCOL "," CHECK "," IDENTITY_INSERT "," RULE "," CHECKPOINT ",
           " IDENTITYCOL "," SAVE "," CLOSE "," IF "," SCHEMA "," CLUSTERED "," IN "," SECURITYAUDIT "," COALESCE "," INDEX "," SELECT "," COLLATE ",
           " INNER "," SEMANTICKEYPHRASETABLE "," COLUMN "," INSERT "," SEMANTICSIMILARITYDETAILSTABLE "," COMMIT "," INTERSECT ",
           " SEMANTICSIMILARITYTABLE "," COMPUTE "," INTO "," SESSION_USER "," CONSTRAINT "," IS "," SET "," CONTAINS "," JOIN ",
           " SETUSER "," CONTAINSTABLE "," KEY "," SHUTDOWN "," CONTINUE "," KILL "," SOME "," CONVERT "," LEFT "," STATISTICS "," CREATE ",
           " LIKE "," SYSTEM_USER "," CROSS "," LINENO "," TABLE "," NULL "," CURRENT "," LOAD "," TABLESAMPLE "," CURRENT_DATE "," MERGE "," TEXTSIZE ",
           " CURRENT_TIME "," NATIONAL "," THEN "," CURRENT_TIMESTAMP "," NOCHECK "," TO "," CURRENT_USER "," NONCLUSTERED "," TOP ",
           " CURSOR "," NOT "," TRAN "," DATABASE "," TRANSACTION "," DBCC "," NULLIF "," TRIGGER "," DEALLOCATE "," OF "," TRUNCATE ",
           " DECLARE "," OFF "," TRY_CONVERT "," DEFAULT "," OFFSETS "," TSEQUAL "," DELETE "," ON "," UNION "," DENY "," OPEN "," UNIQUE "," DESC ",
           " OPENDATASOURCE "," UNPIVOT "," DISK "," OPENQUERY "," UPDATE "," DISTINCT "," OPENROWSET "," UPDATETEXT "," DISTRIBUTED ",
           " OPENXML "," USE "," DOUBLE "," OPTION "," USER "," DROP "," OR "," VALUES "," DUMP "," ORDER "," VARYING "," ELSE "," OUTER ",
           " VIEW "," END "," OVER "," WAITFOR "," ERRLVL "," PERCENT "," WHEN "," ESCAPE "," PIVOT "," WHERE "," EXCEPT "," PLAN "," WHILE "," EXEC ",
           " PRECISION "," WITH "," EXECUTE "," PRIMARY "," WITHIN GROUP "," EXISTS "," PRINT "," WRITETEXT "," EXIT "," PROC "
        };
        #region Propiedades
        // Sesion objSesion= new Sesion();
        private readonly SqlConnection con;
        private SqlCommand comando;
        public DataSet Lector { get; } = new DataSet();

        private SqlDataAdapter adaptador;
        protected string Usuario { get; }
        protected string Pass { get; }
        protected string error;
        public string Error
        {
            get => error;
            set => error = value;
        }
        #endregion
        #region Constructores
        public Clase_Conecta()
        {
            con = new SqlConnection();
            if (Clase_Sesion.Rol == "14")
            {
                con.ConnectionString = "Password=B2B8C6721ACFD01E5AD3047A468FEF66A9234E5D7D5BA373A47E85A3E64BC5B;Persist Security Info=True;User ID=5265193FDE7C660;Initial Catalog="+Clase_Sesion.Servidor+";Server=189.197.190.209";
            }
            else
            {
                con.ConnectionString = "Password=B2B8C6721ACFD01E5AD3047A468FEF66A9234E5D7D5BA373A47E85A3E64BC5B;Persist Security Info=True;User ID=5265193FDE7C660;Initial Catalog=ServerLobos;Server=189.197.190.209";
                //con.ConnectionString = "Persist Security Info=False;Integrated Security=true;Initial Catalog=kenworthSep27;Timbrado_Sistemas=SOTO";
            }
           
        }
        #endregion
        #region Métodos
        public bool validaParametros(List<Clase_Parametros> parametro)
        {
            int a = 0;
            for (int i = 0; i < parametro.Count; i++)
            {
                for (int j = 0; j < reservedWords.Length; j++)
                {
                    if (parametro[i].ValParametro != null && parametro[i].ValParametro.Contains(reservedWords[j]))
                    {
                        a++;
                        if (a >= 2)
                        {
                            MessageBox.Show(reservedWords[j].ToString());
                            return false;
                        }
                    }

                }
            }
            return true;
        }
        public bool Abrir()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                return true;
            }
            catch// (Exception ex)
            {
                try
                {
                    con.ConnectionString = "Password=B2B8C6721ACFD01E5AD3047A468FEF66A9234E5D7D5BA373A47E85A3E64BC5B;Persist Security Info=True;User ID=5265193FDE7C660;Initial Catalog=ServerLobos;Server=189.197.190.209";
                    // con.ConnectionString = "Persist Security Info=False;Integrated Security=true;Initial Catalog=ServerLobosPruebas;Timbrado_Sistemas=GUSTAVO";

                    con.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    error = ex.ToString();
                    Cerrar();
                    return false;
                }
            }

        }
        public bool Cerrar()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return false;
            }

        }
        public bool ConsultarParametros(string consulta, List<Clase_Parametros> parametro)
        {
            if (validaParametros(parametro))
            {
                try
                {
                    comando = new SqlCommand
                    {
                        Connection = con,
                        CommandType = System.Data.CommandType.StoredProcedure,
                        CommandText = consulta,
                        CommandTimeout = 3600
                    };

                    foreach (Clase_Parametros par in parametro)
                    {
                        if (par.ValParametro == null && par.ParamLista == null)
                        {
                            comando.Parameters.AddWithValue(par.NomParametro, par.Imagen);
                        }
                        else if (par.ValParametro == null && par.Imagen == null)
                        {
                            comando.Parameters.AddWithValue(par.NomParametro, par.ParamLista);
                        }
                        else
                        {
                            comando.Parameters.AddWithValue(par.NomParametro, par.ValParametro);
                        }
                    }
                    
                                        
                        if (Abrir())
                    {
                        adaptador = new SqlDataAdapter(comando);//ejecucion del comando consulta
                       
                        adaptador.Fill(Lector);
                        Cerrar();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    error = ex.ToString();
                    MessageBox.Show("error procedimiento,\n"+error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Consultar(string consulta)
        {
            try
            {

                comando = new SqlCommand
                {
                    Connection = con,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = consulta,
                    CommandTimeout = 3600
                };

                if (Abrir())
                {
                    adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(Lector);
                    Cerrar();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return false;
            }
        }
        public bool Ejecuta(string ejecuta, List<Clase_Parametros> parametro)
        {
            if (validaParametros(parametro))
            {
                try
                {

                    comando = new SqlCommand
                    {
                        Connection = con,
                        CommandType = System.Data.CommandType.StoredProcedure,
                        CommandText = ejecuta,
                        CommandTimeout = 3600
                    };
                    foreach (Clase_Parametros par in parametro)
                    {
                        if (par.ValParametro == null)
                        {
                            comando.Parameters.AddWithValue(par.NomParametro, par.Imagen);
                        }
                        else
                        {
                            comando.Parameters.AddWithValue(par.NomParametro, par.ValParametro);
                        }
                    }

                    if (Abrir())
                    {
                        comando.ExecuteNonQuery();
                        Cerrar();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {

                    error = ex.ToString();
                    MessageBox.Show(error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
