using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Verificador
    {
        private string nombreTabla;
        public string Nombre_Tabla
        {
            get { return nombreTabla; }
            set { nombreTabla = value; }
        }

        private string dvv;
        public string DVV
        {
            get { return dvv; }
            set { dvv = value; }
        }
    }
}