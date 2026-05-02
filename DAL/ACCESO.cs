using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso
    {
        /* Declaro un objeto SqlConnection, que representa la conexión con la 
         * base de datos. 
         * No inicializo el objeto
        */
        SqlConnection conexion;

        /* Se crea una nueva instancia de SqlConnection
         Se establece la cadena de conexión para conectarse a la BD
         Se llama a Open() para abrir la conexión con la BD
        //PC valen: DESKTOP-TUV7OH6
        //Notebook valen: DESKTOP-DJ6O6PQ
        */
        public void AbrirConexion()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Integrated Security=SSPI;" +
                "Persist Security Info=False;" +
                "Initial Catalog=Proyecto_Is_JuntosBD;" +
                "Data Source=DESKTOP-DJ6O6PQ\\SQLEXPRESS";
            conexion.Open();
        }

        /* Cierro la conexion con Close()
         * Llamo a GC.Collect() para forzar recolección de la basura
         * Deja el objeto conexion en null para liberar la referencia
         */
        public void CerrarConexion()
        {
            conexion.Close();
            GC.Collect();
            conexion = null;
        }

        /* Crea un SqlCommand para que se ejecute un procedimiento almacenado
         * Asocio la conexión activa
         * Se agregan al comando los parametros que recibe Lis<SqlParameter>...
         * devuelve el objeto SqlCommand (comando) para ejecutarlo
         */
        public SqlCommand CrearComando(string nombreSP, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = nombreSP;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            if (parametros != null)
            {
                foreach (SqlParameter p in parametros)
                {
                    comando.Parameters.Add(p);
                }
            }
            return comando;
        }

        /* Igual que CrearComando2, en este caso este está preparado
         * para ejectuar SQL en texto plano
         */
        public SqlCommand CrearComando2(string sql, List<SqlParameter> p = null)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

            if (p != null)
            {
                foreach (SqlParameter par in p)
                {
                    comando.Parameters.Add(par);
                }
            }
            return comando;
        }

        /* Se ejecuta un procedimiento almacenado de escritura (INSERT, UPDATE, DELETE).
         * Devuelve la cantidad de filas que fueron afectadas con ExecuteNonQuery()
         * Si hay algún error devuelve -1 que sirve para saber si la operación
         * se realizó correctamente
         */
        public int EscribirBase(string nombreSP, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = CrearComando(nombreSP, parametros);
            int filas = comando.ExecuteNonQuery();

            comando = null;
            return filas;
        }

        /* Se ejecuta un procedimiento almacendo de lectura en la BD (SELECT
         * Para ejecutar el comando se usa un SQlDataAdapter que devuelve
         * los resultados de la consulta en un DataTable
         */
        public DataTable LeerBase(string nombreSP, List<SqlParameter> parametros = null)
        {
            DataTable tabla = new DataTable();

            SqlCommand comando = CrearComando(nombreSP, parametros);
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = comando;
            adaptador.Fill(tabla);

            return tabla;
        }

        /*Crea y devuelve un objeto SqlParameter, a este (p) se le indica
         * el nombre valor y tipo de datos
         */
        public SqlParameter Crear_Parametro(string nombre, string valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.String;

            return parametro;
        }
        public SqlParameter Crear_Parametro(string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.Int32;

            return parametro;
        }
        public SqlParameter Crear_Parametro(string nombre, decimal valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.Currency;

            return parametro;
        }
        public SqlParameter Crear_Parametro(string nombre, DateTime valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.DateTime;

            return parametro;
        }

        public object LeerEscalar(string nombreSP, List<SqlParameter> parametros = null)
        {
            using (var comando = CrearComando(nombreSP, parametros))
            {
                return comando.ExecuteScalar();   // puede devolver null (DBNull)
            }
        }
    }
}
