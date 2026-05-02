using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Operacion
    {
        private int id_operacion;

        public int ID_Operacion
        {
            get { return id_operacion; }
            set { id_operacion = value; }
        }

        private int num_tipo_operacion;

        public int Num_Tipo_Operacion
        {
            get { return num_tipo_operacion; }
            set { num_tipo_operacion = value; }
        }

        private TiposDeOperacion tipo_operacion;

        public TiposDeOperacion Tipo_Operacion
        {
            get { return tipo_operacion; }
            set { tipo_operacion = value; }
        }

        private DateTime fecha_operacion;

        public DateTime Fecha_Operacion
        {
            get { return fecha_operacion; }
            set { fecha_operacion = value; }
        }

        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}