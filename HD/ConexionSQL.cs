using Common.Security;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;

namespace HD
{
    public class ConexionSQL
    {
        public static Configuration config = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);

        public static SqlConnection conexionSQL()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                SqlConnectionStringBuilder conector = new SqlConnectionStringBuilder();
                conector.DataSource = config.AppSettings.Settings["Servidor"].Value;
                conector.InitialCatalog = config.AppSettings.Settings["BD"].Value;
                conector.UserID = config.AppSettings.Settings["Usuario"].Value;
                conector.Password = Security.Decrypt(config.AppSettings.Settings["Clave"].Value,"Macbook2011");
                conn = new SqlConnection(conector.ToString());
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex) { }

            return conn;
        }
        public static void CerrarConexionBD()
        {
            conexionSQL().Close();
        }
        public static void CerrarConexionBD1()
        {
            conexionSQL().Close();
            conexionSQL().Dispose();
        }
        //Metodo para consultar usuario
        public static SqlDataReader consultarUsuario(SqlCommand comando) //Salen las credenciasles en blanco
        {
            SqlConnection con = conexionSQL();
            comando.Connection = con;
            SqlDataReader reader = comando.ExecuteReader();
            con.Close();
            return reader;

        }
        //DEvuelve un DataSet
        public static DataSet consulta(string instruccion, string nombre_tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                try
                {
                    SqlConnection con = conexionSQL();
                    SqlCommand cmd = new SqlCommand(instruccion, con);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    adaptador.Fill(ds, nombre_tabla);
                    con.Close();
                }
                catch (Exception ex) { }
                return ds;
            }
            catch (Exception ex)
            {
                return ds;
            }
        }



        //Devuelve un DataTable
        public static DataTable consultaDataTable(string instruccion, string nombre_tabla)
        {
            DataTable dtDataTable = null;
            try
            {
                SqlConnection con = conexionSQL();
                System.Data.SqlClient.SqlDataAdapter adaptador = new System.Data.SqlClient.SqlDataAdapter(instruccion, con);
                System.Data.DataSet dsDataSet = new System.Data.DataSet();

                adaptador.Fill(dsDataSet);
                dtDataTable = dsDataSet.Tables[0];

                con.Close();
                return dtDataTable;
            }
            catch (Exception ex)
            {
                return dtDataTable;
            }
        }

        // Data Manipulation Language => DML
        // Metodo DML q se dedica a realizar cambios en las tablas (insert, delete, update)
        public static int DML(string instruccion)
        {
            try
            {
                int result = 0;
                SqlConnection con = conexionSQL();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = instruccion;
                result = cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
            catch (Exception ex) { return 0; }
        }
        // es para ver si existen datos con

        public static int existencia(string strSQL)
        {
            try
            {
                SqlConnection con = conexionSQL();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                da.Fill(dt);
                con.Close();
                return dt.Rows.Count;
            }
            catch (Exception ex) { return 0; }

        }

        public static string ConsultaUnica(string instruccion)
        {
            try
            {
                SqlConnection con = conexionSQL();
                SqlCommand comando = new SqlCommand(instruccion);
                comando.Connection = con;
                String resultado = comando.ExecuteScalar().ToString();
                con.Close();
                return resultado;
            }
            catch (Exception ex) { return ex.Message; }

        }
        public static string Validar(string usuario, string pag)
        {
            try
            {
                string instruccion = String.Format("exec PrValidar '{0}','{1}'", usuario, pag);
                SqlConnection con = conexionSQL();
                SqlCommand comando = new SqlCommand(instruccion);
                comando.Connection = con;
                String resultado = comando.ExecuteScalar().ToString();
                con.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                return "";
            }

        }
        //-----------------------------------------------------------------------------------------------------------------------

    }
}