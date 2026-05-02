using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public abstract class Componente
    {
        private int id_permiso;
        public int ID_Permiso
        {
            get { return id_permiso; }
            set { id_permiso = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public abstract bool EsFamilia { get; }
        public abstract IList<Componente> Hijos { get; }

        public abstract void Agregar(Componente componente);
        public abstract void Quitar(Componente componente);

        public virtual bool Contiene(string nombre)
        {
            return string.Equals(this.Nombre, nombre, StringComparison.OrdinalIgnoreCase);
        }
    }
}