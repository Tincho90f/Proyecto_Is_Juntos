using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Servicios;

namespace BLL
{
    public class Usuario_BLL
    {
        public Usuario_Mapper mapper = new Usuario_Mapper();

        public bool Logueo(Usuario_Cliente usuario)
        {
            try
            {
                if (SessionManager.GetInstance != null)
                {
                    throw new Exception("Ya hay una sesión iniciada");

                }
                else
                {

                    if (mapper.ObtenerUsuarioPorCredenciales(usuario) == null)
                    {
                        throw new Exception("Credenciales incorrectas");
                    }
                    else
                    {
                        SessionManager.Login(usuario);
                        return true;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
