using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class GestorIdioma_BLL
    {
        private static GestorIdioma_BLL _instancia;
        public static GestorIdioma_BLL Instancia
        {
            get { return _instancia ?? (_instancia = new GestorIdioma_BLL()); }
        }

        private readonly List<IObservadorIdioma> observer = new List<IObservadorIdioma>();
        private readonly Idioma_Mapper _mapper = new Idioma_Mapper();
        private Idioma _idiomaActual;

        public Idioma IdiomaActual
        {
            get { return _idiomaActual; }
            set { _idiomaActual = value; Notificar(); }
        }

        public void Cambiar_Idioma(int idIdioma)
        {
            IdiomaActual = _mapper.Obtener_Traducciones(idIdioma);
        }

        public void Suscribir(IObservadorIdioma o) 
        {
            if (!observer.Contains(o)) 
            {
                observer.Add(o);
            }
            
        }
        public void Desuscribir(IObservadorIdioma o) 
        {
            observer.Remove(o); 
        }

        private void Notificar()
        {
            foreach (var o in observer)
            {
                o.ActualizarIdioma(_idiomaActual);
            }
        }
    }
}