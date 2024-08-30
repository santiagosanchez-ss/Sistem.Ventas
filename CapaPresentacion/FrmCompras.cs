using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
            using (var modal = new MdProveedor())
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
            //guardamos el MdProducto en una variable modal para que esta sea mostrada...
            using (var modal = new MdProducto())
            {
                //...Con el metodo Showdialog y que cada accion que haga la muestre en la variable result
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProducto.Text = modal._Producto.IdProducto.ToString();
                    txtCodProducto.Text = modal._Producto.Codigo;
                    TxtProducto.Text = modal._Producto.Nombre;
                    txtPrecioComp.Select();

                }
                else
                {
                    txtCodProducto.Select();
                }


            }


        }




        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CNProducto().Listar().Where(p => p.Codigo == txtCodProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {

                    txtCodProducto.BackColor = System.Drawing.Color.Honeydew;// uso System.Drawing. para solucionar porblema de ambiguedad
                    TxtIdProducto.Text = oProducto.IdProducto.ToString();
                    TxtProducto.Text = oProducto.Nombre;
                    txtPrecioComp.Select();
                }
                else
                {
                    txtCodProducto.BackColor = System.Drawing.Color.MistyRose;
                    TxtIdProducto.Text = "0";
                    TxtProducto.Text = "";

                }
            }


        }

        private void BtnAgregarProd_Click(object sender, EventArgs e)
        {
            decimal PrecioCompra = 0;
            decimal PrecioVenta = 0;
            bool ProductoExiste = false;



            if (TxtIdProducto == null || string.IsNullOrEmpty(TxtIdProducto.Text))
            {
                MessageBox.Show("Precio Compra: Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (!decimal.TryParse(txtPrecioComp.Text, out PrecioCompra))
            {
                MessageBox.Show("Precio Compra: Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioComp.Select();
                return;
            }

            if (!decimal.TryParse(TxtPrecioVen.Text, out PrecioVenta))
            {
                MessageBox.Show("Precio Venta: Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioComp.Select();
                return;
            }


            foreach (DataGridViewRow fila in DgvData.Rows)
            {
                // Asegúrate de que la columna existe
                if (fila.Cells["IdProducto"] != null && fila.Cells["IdProducto"].Value != null)
                {
                    if (fila.Cells["IdProducto"].Value.ToString() == TxtIdProducto.Text)
                    {
                        ProductoExiste = true;
                        break;
                    }
                }
            }

            if (!ProductoExiste)
            {
                DgvData.Rows.Add(new object[] {
                    TxtIdProducto.Text,
                    TxtProducto.Text,
                    txtPrecioComp.Text,
                    TxtPrecioVen.Text,
                    TxtCantidad.Value.ToString(),
                    (TxtCantidad.Value * PrecioCompra).ToString("")
                });
                Calcular();
                LimpiarProducto();
                txtCodProducto.Select();

            }
        }
        private void LimpiarProducto()

        {
            TxtIdProducto.Text = "0";
            txtCodProducto.Text = "";
            txtCodProducto.BackColor = System.Drawing.Color.White;
            TxtProducto.Text = "";
            txtPrecioComp.Text = "";
            TxtPrecioVen.Text = "";
            TxtCantidad.Value = 1;

        }


        private void Calcular()
        {
            decimal total = 0;
            if (DgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvData.Rows)
                {


                    // Verifica si la celda y su valor no son nulos antes de sumar
                    if (row.Cells["SubTotal"] != null && row.Cells["SubTotal"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                    }
                }

                // Proporciona información de formato específica de la referencia cultural y los valores numéricos de análisis.
                NumberFormatInfo formato = new CultureInfo("es-AR").NumberFormat;
                //Obtiene o establece la cadena que separa grupos de dígitos a la izquierda de la coma decimal en valores de divisa.
                formato.CurrencyGroupSeparator = ".";
                formato.NumberDecimalSeparator = ",";
                formato.CurrencySymbol = "$";

                TxtPrecioTotal.Text = (total.ToString("N", formato));
            }
        }

        private void DgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.trash24_png.Width;
                var h = Properties.Resources.trash24_png.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.trash24_png, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Columns[e.ColumnIndex].Name == "BtnEliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    DgvData.Rows.RemoveAt(indice);

                    Calcular();

                }

            }
        }

        private void TxtdocProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Proveedor oProveedor = new CNProveedor().Listar().Where(p => p.Documento == TxtdocProveedor.Text && p.Estado == true).FirstOrDefault();

                if (oProveedor != null)
                {

                    TxtdocProveedor.BackColor = System.Drawing.Color.Honeydew;// uso System.Drawing. para solucionar porblema de ambiguedad
                    textNombreProveedor.Text = oProveedor.RazonSocial.ToString();

                    txtCodProducto.Select();
                }
                else
                {
                    txtCodProducto.BackColor = System.Drawing.Color.MistyRose;
                    TxtIdProducto.Text = "0";
                    TxtProducto.Text = "";

                }
            }

        }

        private void txtPrecioComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                if (txtPrecioComp.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")

                {
                    e.Handled = true;

                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;

                    }
                    else e.Handled = true;
                }
            }
        }

        private void TxtPrecioVen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                if (TxtPrecioVen.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")

                {
                    e.Handled = true;

                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;

                    }
                    else e.Handled = true;
                }
            }

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(TxtIdProveedor.Text) == 0 )
            {
                MessageBox.Show("Debe seleccion un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable Detalle_Compra = new DataTable();

            Detalle_Compra.Columns.Add("IdProducto", typeof(int));
            Detalle_Compra.Columns.Add("PrecioCompra", typeof(decimal));
            Detalle_Compra.Columns.Add("PrecioVenta", typeof(decimal));
            Detalle_Compra.Columns.Add("Cantidad", typeof(int));
            Detalle_Compra.Columns.Add("MontoTotal", typeof(decimal));


            foreach (DataGridViewRow Row in DgvData.Rows)
            {// Validar que las celdas no sean nulas antes de convertir
                if (Row.Cells["IdProducto"].Value == null ||
                    Row.Cells["PrecioCompra"].Value == null ||
                    Row.Cells["PrecioVenta"].Value == null ||
                    Row.Cells["Cantidad"].Value == null ||
                    Row.Cells["SubTotal"].Value == null)
                {
                    MessageBox.Show("Hay productos con datos incompletos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Detalle_Compra.Rows.Add(
                    new object[]
                    {
                       Convert.ToInt32( Row.Cells["IdProducto"].Value.ToString()),
                           Row.Cells["PrecioCompra"].Value.ToString(),
                           Row.Cells["PrecioVenta"].Value.ToString(),
                           Row.Cells["Cantidad"].Value.ToString(),
                           Row.Cells["SubTotal"].Value.ToString(),
                    });
            }
            int IdCorrelativo = new CNCompra().ObtenerCorrelativo();
            string numeroDocumento = string.Format ("{0:0000}",IdCorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario},
                oProveedor = new Proveedor() { IdProveedor = int.TryParse(TxtIdProveedor.Text, out int idProveedor) ? idProveedor : 0 },
                TipoDocumento = ((OpcionCombo) CboTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = decimal.TryParse(TxtPrecioTotal.Text, out decimal montoTotal) ? montoTotal : 0m
            };

            string Mensaje = string.Empty;

            bool Respuesta = new CNCompra().Registrar(oCompra,Detalle_Compra,out Mensaje);

            if (Respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                
                    Clipboard.SetText(numeroDocumento);
                

                TxtIdProveedor.Text = "0";
                TxtdocProveedor.Text = "";
                textNombreProveedor.Text = "";
                TxtPrecioTotal.Text = "";
                DgvData.Rows.Clear();
                Calcular();
            }
            else
            {
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}

