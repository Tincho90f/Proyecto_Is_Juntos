using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace Proyecto_Is_Juntos
{
    internal class LocalizadorUI
    {
        public static void Aplicar(Control root, Idioma idioma)
        {
            if (idioma == null) return;

            var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var t in idioma.Traducciones)
            {
                string clave = t.Etiqueta != null ? t.Etiqueta.Nombre_Etiqueta : null;
                if (!string.IsNullOrEmpty(clave) && !dict.ContainsKey(clave))
                    dict.Add(clave, t.Texto);
            }

            TraducirControlRecursivo(root, dict);

            // traducir título del Form (usa Tag o Name como clave)
            var form = root as Form;
            if (form != null)
            {
                string claveTitulo = form.Tag != null ? form.Tag.ToString() : form.Name;
                string texto;
                if (dict.TryGetValue(claveTitulo, out texto)) form.Text = texto;
            }
        }

        private static void TraducirControlRecursivo(Control c, Dictionary<string, string> dict)
        {
            string clave = c.Tag != null ? c.Tag.ToString() : c.Name;
            string texto;
            if (dict.TryGetValue(clave, out texto)) c.Text = texto;

            // MenuStrip / ToolStrip
            var menu = c as MenuStrip;
            if (menu != null) TraducirToolStripItems(menu.Items, dict);

            var tool = c as ToolStrip;
            if (tool != null) TraducirToolStripItems(tool.Items, dict);

            // TabControl
            var tabs = c as TabControl;
            if (tabs != null)
            {
                foreach (TabPage page in tabs.TabPages)
                {
                    var claveTab = page.Tag != null ? page.Tag.ToString() : page.Name;
                    if (dict.TryGetValue(claveTab, out texto)) page.Text = texto;
                    foreach (Control child in page.Controls) TraducirControlRecursivo(child, dict);
                }
                return;
            }

            // DataGridView (headers)
            var grid = c as DataGridView;
            if (grid != null)
            {
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    var claveCol = col.Tag != null ? col.Tag.ToString() : col.Name;
                    if (dict.TryGetValue(claveCol, out texto)) col.HeaderText = texto;
                }
            }

            foreach (Control child in c.Controls)
                TraducirControlRecursivo(child, dict);
        }

        private static void TraducirToolStripItems(ToolStripItemCollection items, Dictionary<string, string> dict)
        {
            foreach (ToolStripItem item in items)
            {
                string clave = item.Tag != null ? item.Tag.ToString() : item.Name;
                string texto;
                if (dict.TryGetValue(clave, out texto)) item.Text = texto;

                var drop = item as ToolStripDropDownItem;
                if (drop != null && drop.DropDownItems != null)
                    TraducirToolStripItems(drop.DropDownItems, dict);
            }
        }
    }
}
