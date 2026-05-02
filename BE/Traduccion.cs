using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Traduccion
    {
		private Etiqueta etiqueta;

		public Etiqueta Etiqueta
		{
			get { return etiqueta; }
			set { etiqueta = value; }
		}

		private string texto;

		public string Texto
		{
			get { return texto; }
			set { texto = value; }
		}

	}
}