using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Bitacora
    {
		private List<Operacion> Operaciones_Bitacora = new List<Operacion>();

		public List<Operacion> operaciones_bitacora
		{
			get { return Operaciones_Bitacora ; }
			set { Operaciones_Bitacora = value; }
		}
	}
}