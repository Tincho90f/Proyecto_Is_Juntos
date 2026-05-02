using BE;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Usuario_Mapper
    {
        Acceso acceso = new Acceso();
       
        /* Método Credenciales
         * Este método valida las credenciales de un usuario contra los datos 
         * almacenados en la base de datos, utilizando el sp_ValidarCredenciales.
         * Se reciben como entrada los datos del usuario (nombre y contraseña) 
         * encapsulados en un objeto USUARIO.Se crea el parámetros SQL 
         * correspondiente al nombre del usuario y se pasa al procedimiento almacenado.
         * Se abre la conexión a la base de datos y se ejecuta la consulta 
         * mediante el método LeerBase, que devuelve un DataTable.
         * Si el DataTable contiene exactamente una fila, significa que
         * ese usuario existe y falta validar la contraseña.En ese caso, se 
         * valida la contraseña ingresada por el usuario con la traida de la BD.
         * Si la validacion es correcta se construye y retorna un nuevo objeto USUARIO 
         * con los datos recuperados de la base de datos.Si no se encuentra ninguna
         * coincidencia, el método retorna null, indicando que las credenciales son inválidas.
        */
        public BE.Usuario ObtenerUsuarioPorCredenciales(BE.Usuario usuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.Crear_Parametro("@usuario_nombre", usuario.Nombre));

            acceso.AbrirConexion();
            DataTable tabla = acceso.LeerBase("sp_ValidarCredenciales", parametros);
            acceso.CerrarConexion();

            if (tabla.Rows.Count == 1)
            {
                DataRow fila = tabla.Rows[0];

                string hashUsuario = Encriptador.Hash_md5(usuario.Password).ToLower();
                string hashBD = fila["password"].ToString().ToLower();

                if (hashUsuario == hashBD)
                {
                    usuario.ID = Convert.ToInt32(fila["ID_Usuario"]);
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }


        public DataTable ListarUsuarios()
        {
            acceso.AbrirConexion();
            DataTable tabla = acceso.LeerBase("LISTAR_USUARIOS");
            acceso.CerrarConexion();
            return tabla;
        }

        public void Actualizar_DVH(int idUsuario, string dvhHex)
        {
            acceso.AbrirConexion();
            List<SqlParameter> ps = new List<SqlParameter>
            {
                acceso.Crear_Parametro("@ID_Usuario", idUsuario),
                acceso.Crear_Parametro("@dvh", dvhHex ?? string.Empty)
            };
            acceso.EscribirBase("ACTUALIZAR_DVH_USUARIO", ps);
            acceso.CerrarConexion();
        }

        public List<UsuarioRow> Listar_DV()
        {
            acceso.AbrirConexion();
            DataTable tabla = acceso.LeerBase("LISTAR_USUARIOS_BASICO");
            acceso.CerrarConexion();

            List<UsuarioRow> lista = new List<UsuarioRow>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow r = tabla.Rows[i];
                UsuarioRow u = new UsuarioRow
                {
                    ID_Usuario = Convert.ToInt32(r["ID_Usuario"]),
                    Usuario_Nombre = r["usuario_nombre"].ToString(),
                    Password = r["password"].ToString(),
                    DVH = r.Table.Columns.Contains("dvh") && r["dvh"] != DBNull.Value ? r["dvh"].ToString() : string.Empty
                };
                lista.Add(u);
            }
            return lista;
        }

    }
}
