using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Stock
    {
		private List<Producto> Listado_Productos = new List<Producto>();

		public List<Producto> listado_productos
		{
			get { return Listado_Productos; }
			set { Listado_Productos = value; }
		}
	}
}