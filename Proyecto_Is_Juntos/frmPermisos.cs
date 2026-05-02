using BE;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Is_Juntos
{
    public partial class frmPermisos : BaseForm
    {
        Bitacora_BLL bitacora = new Bitacora_BLL();

        public Usuario usuario_logueado;

        private readonly Permiso_BLL permisosBLL = new Permiso_BLL();

        private Componente seleccionActual;

        public frmPermisos()
        {
            InitializeComponent();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            Rb_Patente_Permisos.Checked = true;

            // Configurar ListBox
            lstDisponibles.DisplayMember = "Nombre";
            lstDisponibles.ValueMember = "ID_Permiso";

            ActualizarArbol();
        }

        private void ActualizarArbol()
        {
            treePermisos.Nodes.Clear();

            List<Componente> todos = permisosBLL.ObtenerTodoElArbol();

            HashSet<int> idsHijos = new HashSet<int>();
            foreach (var comp in todos)
            {
                if (comp.EsFamilia)
                {
                    foreach (var hijo in comp.Hijos) idsHijos.Add(hijo.ID_Permiso);
                }
            }

            foreach (var comp in todos)
            {
                if (!idsHijos.Contains(comp.ID_Permiso) && comp.EsFamilia)
                {
                    TreeNode nodoRaiz = CrearNodo(comp);
                    treePermisos.Nodes.Add(nodoRaiz);
                }
            }

            treePermisos.ExpandAll();
        }

        private TreeNode CrearNodo(Componente comp)
        {
            string prefijo = comp.EsFamilia ? "[FAMILIA] " : "[PATENTE] ";

            TreeNode nodo = new TreeNode(prefijo + comp.Nombre);
            nodo.Tag = comp;

            if (comp.EsFamilia)
            {
                foreach (var hijo in comp.Hijos)
                {
                    nodo.Nodes.Add(CrearNodo(hijo));
                }
            }
            return nodo;
        }

        private void treePermisos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            seleccionActual = (Componente)e.Node.Tag;

            lstDisponibles.DataSource = null;

            if (seleccionActual.EsFamilia)
            {
                CargarListasDisponibles((Familia)seleccionActual);
                lstDisponibles.DisplayMember = "Nombre";
                lstDisponibles.ValueMember = "ID_Permiso";
            }
        }

        private void CargarListasDisponibles(Familia familiaSeleccionada)
        {
            var todos = permisosBLL.ObtenerTodoElArbol();

            List<Componente> disponibles = new List<Componente>();

            foreach (var candidato in todos)
            {
                if (candidato.ID_Permiso == familiaSeleccionada.ID_Permiso) continue;

                if (familiaSeleccionada.Contiene(candidato.Nombre)) continue;

                if (candidato.EsFamilia && candidato.Contiene(familiaSeleccionada.Nombre)) continue;

                disponibles.Add(candidato);
            }

            lstDisponibles.DataSource = null;
            lstDisponibles.DataSource = disponibles;
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese un nombre.");
                return;
            }

            Componente c;
            bool esFamilia = Rb_Familia_Permisos.Checked;

            if (esFamilia) c = new Familia();
            else c = new Patente();

            c.Nombre = txtNombre.Text;
            c.Descripcion = txtDescripcion.Text;

            try
            {
                permisosBLL.GuardarComponente(c, esFamilia);
                MessageBox.Show("Componente creado correctamente.");

                txtNombre.Text = "";
                txtDescripcion.Text = "";
                ActualizarArbol();
                bitacora.Registrar_Operacion(usuario_logueado, 7);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear: " + ex.Message);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (seleccionActual == null || !seleccionActual.EsFamilia)
            {
                MessageBox.Show("Seleccione una familia en el árbol.");
                return;
            }

            var itemSeleccionado = (Componente)lstDisponibles.SelectedItem;
            if (itemSeleccionado == null)
            {
                MessageBox.Show("Seleccione un permiso de la lista para agregar.");
                return;
            }

            try
            {
                if(permisosBLL.AgregarHijo((Familia)seleccionActual, itemSeleccionado) == true)
                {
                    MessageBox.Show("Permiso agregado correctamente.");
                    ActualizarArbol();
                    bitacora.Registrar_Operacion(usuario_logueado, 8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar: " + ex.Message);
            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (treePermisos.SelectedNode == null || treePermisos.SelectedNode.Parent == null)
            {
                MessageBox.Show("Seleccione un elemento hijo (dentro de una familia) para quitar.");
                return;
            }

            Familia padre = (Familia)treePermisos.SelectedNode.Parent.Tag;
            Componente hijo = (Componente)treePermisos.SelectedNode.Tag;

            try
            {
                permisosBLL.QuitarHijo(padre, hijo);
                MessageBox.Show("Permiso quitado correctamente.");
                bitacora.Registrar_Operacion(usuario_logueado, 8);
                ActualizarArbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            ActualizarArbol();
        }
    }
}

