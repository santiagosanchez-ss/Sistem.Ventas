using CapaEntidad;
using CapaNegocio;
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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        public void FrmProducto_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            CboEstado.DisplayMember = "Texto";
            CboEstado.ValueMember = "Valor";
            CboEstado.SelectedIndex = 0;

            List<Categoria> ListaCategoria = new CNCategoria().Listar();

            foreach (Categoria item in ListaCategoria)
            {
                CboCategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });

                CboCategoria.DisplayMember = "Texto";
                CboCategoria.ValueMember = "Valor";
                CboCategoria.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columns in DGVData.Columns)
            {
                if (columns.Visible == true && columns.Name != "BtnSeleccionar")
                {
                    CboBusqueda.Items.Add(new OpcionCombo() { Valor = columns.Name, Texto = columns.HeaderText });

                    CboBusqueda.DisplayMember = "Texto";
                    CboBusqueda.ValueMember = "Valor";
                    CboBusqueda.SelectedIndex = 0;
                }

            }

            //PARA MOSTRAR TODOS LOS PRODUCTOS

            List<Producto> ListaProductos = new CNProducto().Listar();

            foreach (Producto item in ListaProductos)
            {
                DGVData.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioVenta,
                    item.PrecioCompra,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo": " Inactivo"
                });
            }


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Producto objProducto = new Producto()
            {
                IdProducto = Convert.ToInt32(TxtId.Text),
                Codigo = TxtCodigoo.Text,
                Nombre = TxtNombreCompleto.Text,
                Descripcion = TxtDescripcionProd.Text,
                oCategoria = new Categoria() { IdCategoria= Convert.ToInt32(((OpcionCombo)CboCategoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)CboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objProducto.IdProducto == 0)
            {




                //LE PASAMOS EL  METODO REGISTRAR (encargado de registrar Productos en la db) Y COMO RESPUESTA OBTENEMOS EL iDProductoGENERADO
                int IdProductoGenerado = new CNProducto().Registrar(objProducto, out mensaje);


                //SI iDProductoGenerado ES DISTINTO A CERO (osea, no se registro en la base de datos ) QUE PROSIGA A MOSTRAR TODOS LOS VALORES NUEVOS AL DATAGRIDVIEW
                if (IdProductoGenerado != 0)
                {

                    DGVData.Rows.Add(new object[] {
                        "",
                        IdProductoGenerado,
                        TxtCodigoo.Text,
                        TxtNombreCompleto.Text,
                        TxtDescripcionProd.Text,
                    ((OpcionCombo)CboCategoria.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)CboCategoria.SelectedItem).Texto.ToString(),
                    "0",
                    "0,00",
                    "0,00",
                    ((OpcionCombo)CboEstado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)CboEstado.SelectedItem).Texto.ToString(),
                });
                    Limpiar();


                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool Resultado = new CNProducto().Editar(objProducto, out mensaje);
                if (Resultado == true)
                {
                    DataGridViewRow Row = DGVData.Rows[Convert.ToInt32(TxtIndice.Text)];
                    Row.Cells["Id"].Value = TxtId.Text;
                    Row.Cells["Codigo"].Value = TxtCodigoo.Text;
                    Row.Cells["NombreCompleto"].Value = TxtNombreCompleto.Text;
                    Row.Cells["Descripcion"].Value = TxtDescripcionProd.Text;
                    Row.Cells["IdCategoria"].Value = ((OpcionCombo)CboCategoria.SelectedItem).Valor.ToString();
                    Row.Cells["Categoria"].Value = ((OpcionCombo)CboCategoria.SelectedItem).Texto.ToString();
                    Row.Cells["EstadoValor"].Value = ((OpcionCombo)CboCategoria.SelectedItem).Valor.ToString();
                    Row.Cells["Estado"].Value = ((OpcionCombo)CboCategoria.SelectedItem).Texto.ToString();

                    Limpiar();


                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

        }
        public void Limpiar ()
        {
            TxtIndice.Text = "-1";
            TxtId.Text = "";
            TxtCodigoo.Text = "";
            TxtNombreCompleto.Text = "";
            TxtDescripcionProd.Text = "";
            CboCategoria.SelectedIndex = 0;
            CboEstado.SelectedIndex = 0;

            TxtCodigoo.Select();
        }

        private void DGVData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check24_png.Width;
                var h = Properties.Resources.check24_png.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check24_png, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void DGVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TxtIndice.Text = indice.ToString();
                    TxtId.Text = DGVData.Rows[indice].Cells["Id"].Value.ToString();
                    TxtCodigoo.Text = DGVData.Rows[indice].Cells["Codigo"].Value.ToString();
                    TxtNombreCompleto.Text = DGVData.Rows[indice].Cells["Nombre"].Value.ToString();
                    TxtDescripcionProd.Text = DGVData.Rows[indice].Cells["Descripcion"].Value.ToString();
                  
                    foreach (OpcionCombo oc in CboCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGVData.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int IndiceCombo = CboCategoria.Items.IndexOf(oc);
                            CboCategoria.SelectedIndex = IndiceCombo;
                            break;
                        }

                    }

                    foreach (OpcionCombo oc in CboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGVData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int IndiceCombo = CboEstado.Items.IndexOf(oc);
                            CboEstado.SelectedIndex = IndiceCombo;
                            break;
                        }

                    }
                }

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxtId.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el Producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto objProducto = new Producto()

                    {
                        IdProducto = Convert.ToInt32(TxtId.Text),

                    };

                    bool respuesta = new CNProducto().Eliminar(objProducto, out mensaje);

                    if (respuesta)
                    {
                        DGVData.Rows.RemoveAt(Convert.ToInt32(TxtIndice.Text));
                        
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string ColumnaFiltro = ((OpcionCombo)CboBusqueda.SelectedItem).Valor.ToString();
            if (DGVData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVData.Rows)
                {
                    if (row.Cells[ColumnaFiltro].Value.ToString().Trim().ToUpper().Contains(Txtbusqueda.Text.Trim().ToUpper()))

                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            Txtbusqueda.Text = "";
            foreach (DataGridViewRow row in DGVData.Rows)
            {
                row.Visible = true;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtIndice.Text = "";
            TxtCodigoo.Text = "";
            TxtNombreCompleto.Text = "";
            TxtDescripcionProd.Text = "";
            CboCategoria.Text = "";
            CboEstado.Text = "";
           
        }
    }

}


