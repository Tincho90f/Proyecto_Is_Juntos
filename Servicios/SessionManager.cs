using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace Servicios
{
    public class SessionManager
    {
        private static object _LOCK = new object();
        private static SessionManager _session;

        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        public static SessionManager GetInstance
        {
            get
            {
                return _session;
            }
        }

        public static Usuario UsuarioActual
        {
            get
            {
                return GetInstance?.Usuario;
            }
        }

        public static void Login(Usuario usuario)
        {
            lock (_LOCK)
            {
                if (_session == null)
                {
                    _session = new SessionManager();
                    _session.Usuario = usuario;
                    _session.FechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesión ya iniciada");
                }
            }
        }

        public static void Logout()
        {
            lock (_LOCK)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }
        }

        private SessionManager() { }
    }
}