using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using DocumentFormat.OpenXml.Wordprocessing;


namespace CapaPresentacion
{
    public partial class FrmReporteCompras : Form
    {
        public FrmReporteCompras()
        {
            InitializeComponent();
        }

       
        private void FrmReporteCompras_Load(object sender, EventArgs e)
        {
            List<Proveedor> lista = new CNProveedor().Listar();
            CboProveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "TODOS" });
            foreach (Proveedor item in lista)
            {
                CboProveedor.Items.Add(new OpcionCombo() { Valor =item.IdProveedor, Texto = item.RazonSocial});
            }

            CboProveedor.DisplayMember = "Texto";
            CboProveedor.ValueMember = "Valor";
            CboProveedor.SelectedIndex= 0;

            foreach (DataGridViewColumn columna in DGVData.Columns)
            {
                CboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText});
            }

            CboBusqueda.DisplayMember = "Texto";
            CboBusqueda.ValueMember = "Valor";
            CboBusqueda.SelectedIndex = 0;





        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {//Obtenemos el Idproveedor seleccionado en el despegable
            int IdProveedor =Convert.ToInt32(((OpcionCombo )CboProveedor.SelectedItem).Valor.ToString());



            List <ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CNReporte().Compra(
                TxtFechaInicio.Value.ToString(),
                TxtFechaFin.Value.ToString(),
                IdProveedor

                );
            DGVData.Rows.Clear();

            foreach (ReporteCompra rc in lista)
            {
                DGVData.Rows.Add(new object[] {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.DocumentoProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                    });
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
                            row.Cells[13].Value.ToString(),
                        });
                }
                SaveFileDialog SaveFile = new SaveFileDialog();

                SaveFile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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

        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            Txtbusqueda.Text = "";
            foreach(DataGridViewRow row in DGVData.Rows)
            {
                row.Visible = true;

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
    }
}
