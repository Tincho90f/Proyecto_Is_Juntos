using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Etiqueta
    {
		private int id_etiqueta;

		public int ID_Etiqueta
		{
			get { return id_etiqueta; }
			set { id_etiqueta = value; }
		}

		private string nombre_etiqueta;

		public string Nombre_Etiqueta
		{
			get { return nombre_etiqueta; }
			set { nombre_etiqueta = value; }
		}

	}
}