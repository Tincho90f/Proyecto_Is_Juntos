using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Idioma
    {
		private int id_idioma;

		public int Id_Idioma
		{
			get { return id_idioma; }
			set { id_idioma = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private List<Traduccion> traducciones = new List<Traduccion>();

		public List<Traduccion> Traducciones
		{
			get { return traducciones ; }
			set { traducciones = value; }
		}

        public override string ToString()
        {
			return nombre;
        }
	}
}