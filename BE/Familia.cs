using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Familia : Componente
    {

        //Lista de los hijos, EsFamilia evita la verificaion a la hora de recorrer el arbol
        private readonly List<Componente> _hijos = new List<Componente>();
        public override bool EsFamilia => true;

        //Lista interna de hijos
        public override IList<Componente> Hijos => _hijos;

        public override void Agregar(Componente componente)
        {
            _hijos.Add(componente);
        }

        public override void Quitar(Componente componente)
        {
            _hijos.Remove(componente);
        }

        //Averiguar si la familia contiene ya esa patente
        public override bool Contiene(string nombre)
        {
            if (base.Contiene(nombre)) return true;

            foreach (Componente hijo in _hijos)
            {
                if (hijo.Contiene(nombre)) return true;
            }
            return false;
        }

    }
}