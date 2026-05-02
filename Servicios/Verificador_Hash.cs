using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios
{
    public class Verificador_Hash
    {
        public static string CanonUsuario(int idUsuario, string usuarioNombre, string password)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1:").Append(idUsuario.ToString())
              .Append("|2:").Append(usuarioNombre ?? string.Empty)
              .Append("|3:").Append(password ?? string.Empty);
            return sb.ToString();
        }

        public static string CalcularDVH_Usuario_Hex(int idUsuario, string usuarioNombre, string password)
        {
            string canon = CanonUsuario(idUsuario, usuarioNombre, password);
            return Encriptador.HashHex(canon);
        }

        // DVV = SHA-256 de la concatenación canónica de (ID|DVH) ordenados por ID
        public static string CalcularDVV_Hex(IEnumerable<BE.UsuarioRow> filasOrdenadasPorId)
        {
            StringBuilder sb = new StringBuilder();
            foreach (BE.UsuarioRow u in filasOrdenadasPorId)
            {
                string dvhHex = u.DVH ?? string.Empty;
                sb.Append("ID:").Append(u.ID_Usuario.ToString())
                  .Append("|DVH:").Append(dvhHex)
                  .Append("||");
            }
            return Encriptador.HashHex(sb.ToString());
        }
    }
}