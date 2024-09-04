using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVentas : Form
    {
        private Usuario _Usuario;

        public FrmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }


        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CboTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            CboTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            CboTipoDocumento.DisplayMember = "Texto";
            CboTipoDocumento.ValueMember = "Valor";
            CboTipoDocumento.SelectedIndex = 0;

            TxtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            TxtIdProducto.Text = "0";
            TxtPagaCon.Text = "0";
            TxtCambio.Text = "0";
            TxtTotalAPagar.Text = "0";
            TxtIdCliente.Text = "0";


        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            //guardamos el MdCliente en una variable modal para que esta sea mostrada...
            using (var modal = new MdCliente())
            {
                //...Con el metodo Showdialog y que cada accion que haga la muestre en la variable result
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {


                    TxtdocCliente.Text = modal._Cliente.documento;
                    txtNombreCliente.Text = modal._Cliente.NombreCompleto;
                    txtCodProducto.Select();

                }
                else
                {
                    TxtdocCliente.Select();
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
                    TxtPrecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    TxtStock.Text = modal._Producto.Stock.ToString();
                    TxtCantidad.Select();



                }
                else
                {
                    txtCodProducto.Select();
                }


            }
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

                TxtTotalAPagar.Text = (total.ToString("N", formato));
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
                    TxtPrecio.Text = oProducto.PrecioVenta.ToString("0.00");
                    TxtStock.Text = oProducto.Stock.ToString();
                    TxtPrecio.Select();
                }
                else
                {
                    txtCodProducto.BackColor = System.Drawing.Color.MistyRose;
                    TxtIdProducto.Text = "0";
                    TxtProducto.Text = "";
                    TxtPrecio.Text = "";
                    TxtStock.Text = "";
                    TxtCantidad.Value = 1;


                }
            }
        }

        private void BtnAgregarProd_Click(object sender, EventArgs e)
        {
            decimal Precio = 0;

            bool ProductoExiste = false;



            if (TxtIdProducto == null || string.IsNullOrEmpty(TxtIdProducto.Text))
            {
                MessageBox.Show(" Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (!decimal.TryParse(TxtPrecio.Text, out Precio))
            {
                MessageBox.Show("Revise elprecio del producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(TxtStock.Text) < Convert.ToInt32(TxtCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad solicitada no puede superar al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPrecio.Select();
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
                string msg = string.Empty;
                bool respuesta = new CNVenta().RestarStock(
                    Convert.ToInt32(TxtIdProducto.Text),
                    Convert.ToInt32(TxtCantidad.Value.ToString())
                    );

                if (respuesta == true)
                {
                    DgvData.Rows.Add(new object[] {
                    TxtIdProducto.Text,
                    TxtProducto.Text,
                    Precio.ToString("0.00"),
                    TxtCantidad.Value.ToString(),
                    (TxtCantidad.Value * Precio).ToString("0.00")
                });



                    Calcular();
                    LimpiarProducto();
                    txtCodProducto.Select();

                }
            }
        }
        private void LimpiarProducto()

        {
            TxtIdProducto.Text = "0";
            txtCodProducto.Text = "";
            txtCodProducto.BackColor = System.Drawing.Color.White;
            TxtProducto.Text = "";
            TxtPrecio.Text = "";
            TxtStock.Text = "";
            TxtCantidad.Value = 1;

        }

        private void DgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 5)
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
                    bool respuesta = new CNVenta().SumarStock(
                   Convert.ToInt32(DgvData.Rows[indice].Cells["IdProducto"].Value.ToString()),
                   Convert.ToInt32(DgvData.Rows[indice].Cells["Cantidad"].Value.ToString())
                    );

                    if (respuesta)
                    {
                        DgvData.Rows.RemoveAt(indice);

                        Calcular();


                    }


                }

            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                if (TxtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")

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

        private void TxtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                if (TxtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")

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

        private void CalcularCambio()
        {

            decimal total;
            decimal pagaCon;

            if (TxtTotalAPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existe productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (TxtPagaCon.Text == "")
            {
                MessageBox.Show("No  ingreso el monto con el que paga el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            
                total = Convert.ToDecimal(TxtTotalAPagar.Text);
                pagaCon = Convert.ToDecimal(TxtPagaCon.Text);



            if (TxtPagaCon.Text.Trim() == "")
            {
                TxtPagaCon.Text = "0";
            }
            if (decimal.TryParse(TxtPagaCon.Text.Trim(), out pagaCon))
            {
                if (pagaCon < total)
                {
                    TxtCambio.Text = "0.00";
                }
                else
                {
                    decimal MontoDevuelto = pagaCon - total;
                    TxtCambio.Text = MontoDevuelto.ToString("0.00");
                }
            }
            

        }





        private void TxtPagaCon_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalcularCambio();
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtdocCliente.Text == "")
            {
                MessageBox.Show("Ud debe ingresar documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Ud debe ingresar el nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (TxtPagaCon.Text == "")
            {
                MessageBox.Show("Ud debe ingresar el monto con el que paga el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           

            if (DgvData.Rows.Count < 1)
            {
                MessageBox.Show("Ud debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DataTable Detalle_Venta = new DataTable();
            Detalle_Venta.Columns.Add("IdProducto", typeof(int));
            Detalle_Venta.Columns.Add("PrecioVenta", typeof(decimal));
            Detalle_Venta.Columns.Add("Cantidad", typeof(int));
            Detalle_Venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in DgvData.Rows)
            {

                Detalle_Venta.Rows.Add(new object[]
                {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString(),
                });
            }

            int IdCorrelativo = new CNVenta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:0000}", IdCorrelativo);
            CalcularCambio();
            
                Venta oVenta = new Venta()
                {
                    oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                    TipoDocumento = ((OpcionCombo)CboTipoDocumento.SelectedItem).Texto,
                    NumeroDocumento = numeroDocumento,
                    DocumentoCliente = TxtdocCliente.Text,
                    NombreCliente = txtNombreCliente.Text,
                    MontoTotal = Convert.ToDecimal(TxtTotalAPagar.Text),
                    MontoPago = Convert.ToDecimal(TxtPagaCon.Text),
                    MontoCambio = Convert.ToDecimal(TxtCambio.Text),
                   
                };
            
        

            string mensaje = string.Empty;

            bool respuesta = new CNVenta().Registrar(oVenta, Detalle_Venta, out mensaje);
            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapeles?", "Mensaje",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)

                    Clipboard.SetText(numeroDocumento);

                TxtdocCliente.Text = "";
                txtNombreCliente.Text = "";
                DgvData.Rows.Clear();
                Calcular();
                TxtTotalAPagar.Text = "";
                TxtPagaCon.Text = "";
                TxtCambio.Text = "";
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }

}
