using CapaEntidad;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCompras : Form
    {
        private Usuario _Usuario;

        public FrmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();  
        }

     

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            CboTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            CboTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            CboTipoDocumento.DisplayMember = "Texto";
            CboTipoDocumento.ValueMember = "Valor";
            CboTipoDocumento.SelectedIndex = 0;

            TxtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            TxtIdProducto.Text = "0";
            TxtIdProveedor.Text = "0";  
             

        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            //guardamos el MdProveedor en una variable modal para que esta sea mostrada...
            using (var modal= new MdProveedor())
            { 
                //...Con el metodo Showdialog y que cada accion que haga la muestre en la variable result
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    
                    TxtdocProveedor.Text = modal._Proveedor.Documento.ToString();
                    textNombreProveedor.Text = modal._Proveedor.RazonSocial.ToString();
                    
                }


            }


        }

        private void BtnbuscarProd_Click(object sender, EventArgs e)
        {
            //guardamos el MdProveedor en una variable modal para que esta sea mostrada...
            using (var modal = new MdProveedor())
            {
                //...Con el metodo Showdialog y que cada accion que haga la muestre en la variable result
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProveedor.Text = modal._Producto.IdProveedor.ToString();

                    TxtdocProveedor.Text = modal._Proveedor.Documento.ToString();
                    textNombreProveedor.Text = modal._Proveedor.RazonSocial.ToString();

                }


            }


        }
    }
}
