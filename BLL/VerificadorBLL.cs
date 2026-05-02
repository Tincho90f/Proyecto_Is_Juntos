using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BE;
using DAL;
using Servicios;

namespace BLL
{
    public class VerificadorBLL
    {
        private readonly Verificador_DAL dvDAL;
        private readonly Usuario_Mapper usuarioDAL;
            
        public VerificadorBLL()
        {
            dvDAL = new Verificador_DAL();
            usuarioDAL = new Usuario_Mapper();
        }

        public void RecalcularTodosYGuardar()
        {
            List<UsuarioRow> usuarios = usuarioDAL.Listar_DV();

  
            for (int i = 0; i < usuarios.Count; i++)
            {
                UsuarioRow u = usuarios[i];
                string nuevoDVH = Verificador_Hash.CalcularDVH_Usuario_Hex(u.ID_Usuario, u.Usuario_Nombre, u.Password);
                if (!string.Equals(u.DVH, nuevoDVH, StringComparison.Ordinal))
                {
                    usuarioDAL.Actualizar_DVH(u.ID_Usuario, nuevoDVH);
                    u.DVH = nuevoDVH; 
                }
            }

            List<UsuarioRow> ordenados = usuarios.OrderBy(x => x.ID_Usuario).ToList();
            string dvvHex = Verificador_Hash.CalcularDVV_Hex(ordenados);
            dvDAL.GuardarDVV("USUARIO", dvvHex);
        }

        public List<string> VerificarIntegridad()
        {
            List<string> errores = new List<string>();

            List<UsuarioRow> usuarios = usuarioDAL.Listar_DV();

            //DVH por fila
            for (int i = 0; i < usuarios.Count; i++)
            {
                UsuarioRow u = usuarios[i];
                string esperado = Verificador_Hash.CalcularDVH_Usuario_Hex(u.ID_Usuario, u.Usuario_Nombre, u.Password);
                if (!string.Equals(u.DVH, esperado, StringComparison.Ordinal))
                {
                    errores.Add("DVH inconsistente en USUARIO.ID_Usuario=" + u.ID_Usuario.ToString());
                }
            }

            // DVV global
            List<UsuarioRow> ordenados = usuarios.OrderBy(x => x.ID_Usuario).ToList();
            string dvvActual = Verificador_Hash.CalcularDVV_Hex(ordenados);
            string dvvGuardado = dvDAL.ObtenerDVV("USUARIO");

            if (dvvGuardado == null || !string.Equals(dvvGuardado, dvvActual, StringComparison.Ordinal))
            {
                errores.Add("DVV inconsistente para tabla USUARIO (altas/bajas o manipulación global).");
            }

            return errores;
        }
        public void ActualizarFilaYDVV(int idUsuario)
        {
            // Traigo todos para DVV y actualizo solo la fila afectada
            List<UsuarioRow> usuarios = usuarioDAL.Listar_DV();

            for (int i = 0; i < usuarios.Count; i++)
            {
                UsuarioRow u = usuarios[i];
                if (u.ID_Usuario == idUsuario)
                {
                    string nuevo = Verificador_Hash.CalcularDVH_Usuario_Hex(u.ID_Usuario, u.Usuario_Nombre, u.Password);
                    if (!string.Equals(u.DVH, nuevo, StringComparison.Ordinal))
                    {
                        usuarioDAL.Actualizar_DVH(u.ID_Usuario, nuevo);
                        u.DVH = nuevo;
                    }
                    break;
                }
            }

            List<UsuarioRow> ordenados = usuarios.OrderBy(x => x.ID_Usuario).ToList();
            string dvvHex = Verificador_Hash.CalcularDVV_Hex(ordenados);
            dvDAL.GuardarDVV("USUARIO", dvvHex);
        }
    }
}
