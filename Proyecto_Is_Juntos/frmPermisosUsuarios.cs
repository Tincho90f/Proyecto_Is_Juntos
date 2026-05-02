using BE;
using BLL;
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
    public partial class frmPermisosUsuarios : BaseForm
    {
        private readonly Usuario_BLL usuarioBLL = new Usuario_BLL();
        private readonly Permiso_BLL permisoBLL = new Permiso_BLL();
        private readonly Bitacora_BLL bitacora = new Bitacora_BLL();

        public Usuario usuario_logueado;

        public frmPermisosUsuarios()
        {
            InitializeComponent();
        }

        private void frmPermisosUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarDisponibles();
        }

        private void CargarUsuarios()
        {
            DataTable usuarios = usuarioBLL.ListarUsuarios();
            cboUsuarios.DataSource = usuarios;
            cboUsuarios.DisplayMember = "usuario_nombre";
            cboUsuarios.ValueMember = "ID_Usuario";
            cboUsuarios.SelectedIndex = -1;
        }

        private void CargarDisponibles()
        {
            List<Componente> todos = permisoBLL.ObtenerTodoElArbol();

            List<ListItem> items = new List<ListItem>();

            foreach (var comp in todos)
            {
                string prefijo = comp.EsFamilia ? "[ROL] " : "[PERMISO] ";
                items.Add(new ListItem { Text = prefijo + comp.Nombre, Value = comp.ID_Permiso, Tag = comp });
            }

            items = items.OrderBy(x => x.Text).ToList();

            lstDisponibles.DisplayMember = "Text";
            lstDisponibles.ValueMember = "Value";
            lstDisponibles.DataSource = items;
        }

        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUsuarios.SelectedValue is int idUsuario)
            {
                CargarAsignadosEfectivos(idUsuario);
            }
            else
            {
                treeAsignados.Nodes.Clear();
            }
        }

        private void CargarAsignadosEfectivos(int idUsuario)
        {
            treeAsignados.BeginUpdate();
            treeAsignados.Nodes.Clear();

            List<Componente> asignados = usuarioBLL.ObtenerAsignadosEfectivos(idUsuario);

            foreach (Componente comp in asignados)
            {
                TreeNode nodo = CrearNodoDesdeComponente(comp);
                treeAsignados.Nodes.Add(nodo);
            }

            treeAsignados.ExpandAll();
            treeAsignados.EndUpdate();
        }

        private TreeNode CrearNodoDesdeComponente(Componente componente)
        {
            string prefijo = componente.EsFamilia ? "[ROL] " : "[PERMISO] ";
            TreeNode nodo = new TreeNode(prefijo + componente.Nombre);
            nodo.Tag = componente; 

            if (componente.EsFamilia)
            {
                foreach (var hijo in componente.Hijos)
                {
                    TreeNode hijoNodo = CrearNodoDesdeComponente(hijo);
                    nodo.Nodes.Add(hijoNodo);
                }
            }
            return nodo;
        }

        private void Btn_Asignar_PermisosUsuarios_Click(object sender, EventArgs e)
        {
            if (!(cboUsuarios.SelectedValue is int idUsuario))
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            ListItem itemSeleccionado = lstDisponibles.SelectedItem as ListItem;
            if (itemSeleccionado == null)
            {
                MessageBox.Show("Seleccione un permiso o rol de la lista para asignar.");
                return;
            }

            int idPermiso = itemSeleccionado.Value;
            Componente compSeleccionado = itemSeleccionado.Tag as Componente;

            var actuales = usuarioBLL.ObtenerAsignadosEfectivos(idUsuario);

            if (actuales.Any(c => c.ID_Permiso == idPermiso))
            {
                MessageBox.Show("El usuario ya tiene asignado este elemento directamente.");
                return;
            }

            foreach (var c in actuales)
            {
                if (c.Contiene(compSeleccionado.Nombre))
                {
                    MessageBox.Show($"El usuario ya tiene el permiso '{compSeleccionado.Nombre}' incluido dentro del Rol '{c.Nombre}'. No es necesario asignarlo explícitamente.");
                    return;
                }
            } 
            
            try
            {
                usuarioBLL.Asignar(idUsuario, idPermiso);

                CargarAsignadosEfectivos(idUsuario);
                MessageBox.Show("Asignación realizada correctamente.");

                bitacora.Registrar_Operacion(usuario_logueado, 9); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar: " + ex.Message);
            }
        }

        private void Btn_Quitar_PermisosUsuarios_Click(object sender, EventArgs e)
        {
            if (!(cboUsuarios.SelectedValue is int idUsuario))
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            if (treeAsignados.SelectedNode == null)
            {
                MessageBox.Show("Seleccione un elemento del árbol para quitar.");
                return;
            }

            if (treeAsignados.SelectedNode.Parent != null)
            {
                MessageBox.Show("No se puede quitar este permiso individualmente porque es parte de un ROL.\n\n" +
                                "Debe quitar el ROL padre (" + treeAsignados.SelectedNode.Parent.Text + ") para revocar este acceso.",
                                "Acción Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Componente seleccionado = (Componente)treeAsignados.SelectedNode.Tag;

            DialogResult confirmar = MessageBox.Show(
                $"¿Está seguro de quitar la asignación de '{seleccionado.Nombre}' al usuario?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            try
            {
                usuarioBLL.Quitar(idUsuario, seleccionado.ID_Permiso);

                CargarAsignadosEfectivos(idUsuario);
                MessageBox.Show("Permiso quitado correctamente.");


                bitacora.Registrar_Operacion(usuario_logueado, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al quitar: " + ex.Message);
            }
        }

        private void Btn_Refrescar_PermisosUsuarios_Click(object sender, EventArgs e)
        {
            if (cboUsuarios.SelectedValue is int idUsuario)
            {
                CargarAsignadosEfectivos(idUsuario);
            }
            CargarDisponibles();
        }

        private class ListItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public Componente Tag { get; set; } 
        }
    }

}
