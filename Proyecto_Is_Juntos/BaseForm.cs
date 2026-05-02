using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace Proyecto_Is_Juntos
{
    public class BaseForm : Form,  IObservadorIdioma
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GestorIdioma_BLL.Instancia.Suscribir(this);
            // Aplica el idioma actual al abrir
            if (GestorIdioma_BLL.Instancia.IdiomaActual != null)
            {
                LocalizadorUI.Aplicar(this, GestorIdioma_BLL.Instancia.IdiomaActual);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            GestorIdioma_BLL.Instancia.Desuscribir(this);
            base.OnFormClosed(e);
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            LocalizadorUI.Aplicar(this, idioma);
        }
    }
}
