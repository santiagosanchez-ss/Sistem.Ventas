using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class FrmReporteVentas : Form
    {
        public FrmReporteVentas()
        {
            InitializeComponent();
        }

        private void FrmReporteVentas_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in DGVData.Columns)
            {
                CboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }

            CboBusqueda.DisplayMember = "Texto";
            CboBusqueda.ValueMember = "Valor";
            CboBusqueda.SelectedIndex = 0;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CNReporte().Venta(
                TxtFechaInicio.Value.ToString(),
                TxtFechaFin.Value.ToString()

                );
            DGVData.Rows.Clear();

            foreach (ReporteVenta rv in lista)
            {
                DGVData.Rows.Add(new object[] {
                    rv.FechaRegistro,
                    rv.TipoDocumento,
                    rv.NumeroDocumento,
                    rv.MontoTotal,
                    rv.UsuarioRegistro,
                    rv.DocumentoCliente,
                    rv.NombreCliente,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Categoria,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.SubTotal
                    });
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
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

        private void BtnExcel_Click(object sender, EventArgs e)
        {

            if (DGVData.Rows.Count < 1)
            {
                MessageBox.Show("no hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                DataTable Dt = new DataTable();
                foreach (DataGridViewColumn columna in DGVData.Columns)

                {

                    if (columna.HeaderText != "" && columna.Visible)
                    {

                        Dt.Columns.Add(columna.HeaderText, typeof(string));
                    }

                }
                foreach (DataGridViewRow row in DGVData.Rows)
                {
                    if (row.Visible)
                        Dt.Rows.Add(new object[]
                        {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                          
                        });
                }
                SaveFileDialog SaveFile = new SaveFileDialog();

                SaveFile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                SaveFile.Filter = "Excel files | *.xlsx ";

                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();

                        var Hoja = wb.Worksheets.Add(Dt, "Informe");
                        Hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(SaveFile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }

            }
        }
    }
}
