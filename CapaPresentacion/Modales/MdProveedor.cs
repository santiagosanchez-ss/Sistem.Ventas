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
    public partial class MdProveedor : Form
    {

        public Proveedor _Proveedor { get; set; }

        public MdProveedor()
        {
            InitializeComponent();
        }

        private void MdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columns in DGVData.Columns)
            {
                if (columns.Visible == true)
                {
                    CboBusqueda.Items.Add(new OpcionCombo() { Valor = columns.Name, Texto = columns.HeaderText });

                    CboBusqueda.DisplayMember = "Texto";
                    CboBusqueda.ValueMember = "Valor";
                    CboBusqueda.SelectedIndex = 0;
                }

            }


            List<Proveedor> ListaProveedores = new CNProveedor().Listar();

            foreach (Proveedor item in ListaProveedores)
            {
                DGVData.Rows.Add(new object[] {
                    "",
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial,
           
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

        private void DGVData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if( iRow >=0 && iColumn > 0)
            {
                _Proveedor = new Proveedor()
                {
                    IdProveedor =Convert.ToInt32( DGVData.Rows[iRow].Cells["Id"].Value.ToString()),
                    Documento = DGVData.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial =DGVData.Rows[iRow].Cells["RazonSocial"].Value.ToString(),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
