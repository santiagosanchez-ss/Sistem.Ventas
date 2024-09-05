using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        //propiedades
        private static Usuario UsuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        //Metodos
        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
            {
                UsuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            }
            else
            {
                UsuarioActual = objusuario;
            }
            InitializeComponent();
        }






        private void Inicio_Load(object sender, EventArgs e)
        {

            List<Permiso> ListaPermiso = new CNPermiso().Listar(UsuarioActual.IdUsuario);

            foreach (IconMenuItem IconMenu in menu.Items)

            {
                bool Encontrado = ListaPermiso.Any(m => m.NombreMenu == IconMenu.Name);

                if (Encontrado == true)
                {
                    IconMenu.Visible = true;
                }
            }

            LblUsuario.Text = UsuarioActual.NombreCompleto;

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;


            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuarios());

        }

        //MANTENEDOR Y SUB CATEGORIAS
        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new FrmCategoria());


        }
        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new FrmProducto());

        }

        //VENTAS Y SUB CATEGORIAS


        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new FrmVentas(UsuarioActual));

        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new FrmDetalleVenta());
        }

        //COMPRA Y SUB CATEGORIAS
        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new FrmDetalleCompra());

        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new FrmCompras(UsuarioActual));

        }

        //CLIENTES
        private void MenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());

        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProveedores());

        }



        private void SubMenuNegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new FrmNegocio());

        }

        private void SubMenuReporteCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new FrmReporteCompras());
        }

        private void SubmenuReporteVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new FrmReporteVentas());

        }

        private void MenuAcercaDe_Click(object sender, EventArgs e)
        {
            MdAcercaDe md = new MdAcercaDe();
            md.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                this.Close();
                }
                
        }
    }
}
