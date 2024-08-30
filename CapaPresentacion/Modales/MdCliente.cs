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

namespace CapaPresentacion.Modales
{
    public partial class MdCliente : Form
    {
        public Cliente _Cliente { get; set; }

        public MdCliente()
        {
            InitializeComponent();
        }

        private void MdCliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columns in DGVData.Columns)
            {

                CboBusqueda.Items.Add(new OpcionCombo() { Valor = columns.Name, Texto = columns.HeaderText });
            }
            CboBusqueda.DisplayMember = "Texto";
            CboBusqueda.ValueMember = "Valor";
            CboBusqueda.SelectedIndex = 0;

            List<Cliente> ListaClientes = new CNCliente().Listar();
            foreach (Cliente item in ListaClientes)
            {
                if (item.Estado)
                {
                  

                    DGVData.Rows.Add(new object[] {
                    item.documento,
                    item.NombreCompleto,
                     });
                }

            }


        }

        private void DGVData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                _Cliente = new Cliente()
                {
                    documento = DGVData.Rows[iRow].Cells["Documento"].Value.ToString(),
                    NombreCompleto = DGVData.Rows[iRow].Cells["NombreCompleto"].Value.ToString(),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();

          
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
    }
}
