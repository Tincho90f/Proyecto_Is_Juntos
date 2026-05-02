using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class UsuarioRow
    {
        public int ID_Usuario { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Password { get; set; }
        public string DVH { get; set; } 
    }
}