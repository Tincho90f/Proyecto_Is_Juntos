using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public override string ToString()
        {
            return nombre;
        }

        public List<Componente> Asignados { get; set; } = new List<Componente>();
    }
}
