using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Patente : Componente
    {
        //Se si es familia o no, ya que en la lista no lo puedo saber
        public override bool EsFamilia => false;

        public override IList<Componente> Hijos => new List<Componente>();

        public override void Agregar(Componente componente)
        {
            throw new Exception("No se pueden agregar hijos a una patente (hoja).");
        }

        public override void Quitar(Componente componente)
        {
            throw new Exception("No se pueden quitar hijos a una patente (hoja).");
        }
    }
}