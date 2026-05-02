using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Producto
    {
		private int id_producto;

		public int ID_Producto
		{
			get { return id_producto; }
			set { id_producto = value; }
		}

		private string nombre_producto;

		public string Nombre_Producto
		{
			get { return nombre_producto; }
			set { nombre_producto = value; }
		}

		private decimal precio;

		public decimal Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		private Usuario usuario_modificador;

		public Usuario Usuario_Modificador
		{
			get { return usuario_modificador; }
			set { usuario_modificador = value; }
		}

		private DateTime fecha_modificacion;

		public DateTime Fecha_Modificacion
		{
			get { return fecha_modificacion; }
			set { fecha_modificacion = value; }
		}

		private int num_tipo_de_modificacion;

		public int Num_Tipo_De_Modificacion
		{
			get { return num_tipo_de_modificacion; }
			set { num_tipo_de_modificacion = value; }
		}

		private TipoDeModificacion tipo_de_modificacion;

		public TipoDeModificacion Tipo_De_Modificacion
		{
			get { return tipo_de_modificacion; }
			set { tipo_de_modificacion = value; }
		}

	}
}