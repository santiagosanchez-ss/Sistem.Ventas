using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion.Modales
{
    public partial class MdProducto : Form
    {

        public Producto _Producto { get; set; }

        public MdProducto()
        {
            InitializeComponent();
        }

        private void MdProducto_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columns in DGVData.Columns)
            {
                if (columns.Visible == true )
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
                    
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioVenta,
                    item.PrecioCompra,
                   
                });
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

        private void Limpiar()
        {

            Txtbusqueda.Text = "";


        }

        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            Limpiar();
            Txtbusqueda.Text = "";
            foreach (DataGridViewRow row in DGVData.Rows)
            {
                row.Visible = true;
            }
        }


        private void DGVData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                _Producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(DGVData.Rows[iRow].Cells["Id"].Value.ToString()),
                    Codigo = DGVData.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Nombre = DGVData.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(DGVData.Rows[iRow].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(DGVData.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(DGVData.Rows[iRow].Cells["PrecioVenta"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();

            }

        }
    }
}


