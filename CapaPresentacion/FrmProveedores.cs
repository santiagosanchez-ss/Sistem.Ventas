using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;


namespace CapaPresentacion
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            CboEstado.DisplayMember = "Texto";
            CboEstado.ValueMember = "Valor";
            CboEstado.SelectedIndex = 0;





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

            //PARA MOSTRAR TODOS LOS ProveedorS

            List<Proveedor> ListaProveedores = new CNProveedor().Listar();

            foreach (Proveedor item in ListaProveedores)
            {
                DGVData.Rows.Add(new object[] {
                    "",
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo": " Inactivo"
                });
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Proveedor objProveedor = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(TxtId.Text),
                Documento = TxtDocumento.Text,
                RazonSocial = TxtRazonSocial.Text,
                Correo = TxtCorreo.Text,
                Telefono = TxtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)CboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objProveedor.IdProveedor == 0)
            {




                //LE PASAMOS EL  METODO REGISTRAR (encargado de registrar Proveedors en la db) Y COMO RESPUESTA OBTENEMOS EL iDProveedorGENERADO
                int IdProveedorGenerado = new CNProveedor().Registrar(objProveedor, out mensaje);


                //SI iDProveedorGenerado ES DISTINTO A CERO (osea, no se registro en la base de datos ) QUE PROSIGA A MOSTRAR TODOS LOS VALORES NUEVOS AL DATAGRIDVIEW
                if (IdProveedorGenerado != 0)
                {

                    DGVData.Rows.Add(new object[] {"",IdProveedorGenerado,TxtDocumento.Text,LabelRazonSocial.Text,TxtCorreo.Text,TxtTelefono.Text,

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
                bool Resultado = new CNProveedor().Editar(objProveedor, out mensaje);
                if (Resultado == true)
                {
                    DataGridViewRow Row = DGVData.Rows[Convert.ToInt32(TxtIndice.Text)];
                    Row.Cells["Id"].Value = TxtId.Text;
                    Row.Cells["documento"].Value = TxtDocumento.Text;
                    Row.Cells["RazonSocial"].Value = LabelRazonSocial.Text;
                    Row.Cells["Correo"].Value = TxtCorreo.Text;
                    Row.Cells["Telefono"].Value = TxtTelefono.Text;

                    Row.Cells["EstadoValor"].Value = ((OpcionCombo)CboEstado.SelectedItem).Valor.ToString();
                    Row.Cells["Estado"].Value = ((OpcionCombo)CboEstado.SelectedItem).Texto.ToString();

                    Limpiar();


                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

        }



        private void Limpiar()
        {
            TxtIndice.Text = "-1";
            TxtId.Text = "";
            TxtDocumento.Text = "";
            LabelRazonSocial.Text = "";
            TxtCorreo.Text = "";
            TxtTelefono.Text = "";
            CboEstado.SelectedIndex = 0;

            TxtDocumento.Select();
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

        private void DGVData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TxtIndice.Text = indice.ToString();
                    TxtId.Text = DGVData.Rows[indice].Cells["Id"].Value.ToString();
                    TxtDocumento.Text = DGVData.Rows[indice].Cells["Documento"].Value.ToString();
                    TxtRazonSocial.Text = DGVData.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    TxtCorreo.Text = DGVData.Rows[indice].Cells["Correo"].Value.ToString();
                    TxtTelefono.Text = DGVData.Rows[indice].Cells["Telefono"].Value.ToString();

                    foreach (OpcionCombo oc in CboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGVData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int IndiceCombo = CboEstado.Items.IndexOf(oc);
                            CboEstado.SelectedIndex = IndiceCombo;
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
                if (MessageBox.Show("Desea eliminar el Proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Proveedor objProveedor = new Proveedor()

                    {
                        IdProveedor = Convert.ToInt32(TxtId.Text),

                    };

                    bool respuesta = new CNProveedor().Eliminar(objProveedor, out mensaje);

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
            Limpiar();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (DGVData.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crear DataTable y agregar columnas visibles
            DataTable Dt = new DataTable();
            foreach (DataGridViewColumn columna in DGVData.Columns)
            {
                if (columna.Visible && !string.IsNullOrEmpty(columna.HeaderText))
                {
                    Dt.Columns.Add(columna.HeaderText);
                }
            }

            // Llenar el DataTable con los datos visibles de las filas
            foreach (DataGridViewRow row in DGVData.Rows)
            {
                if (row.Visible)
                {
                    var newRow = Dt.NewRow();
                    foreach (DataGridViewColumn columna in DGVData.Columns)
                    {
                        if (columna.Visible && !string.IsNullOrEmpty(columna.HeaderText))
                        {
                            newRow[columna.HeaderText] = row.Cells[columna.Index].Value?.ToString() ?? string.Empty;
                        }
                    }
                    Dt.Rows.Add(newRow);
                }
            }

            // Configurar el diálogo de guardado
            using (SaveFileDialog SaveFile = new SaveFileDialog
            {
                FileName = $"ReporteProveedor_{DateTime.Now:dd/MM/yyyy/HH:mm:ss}.xlsx",
                Filter = "Excel files | *.xlsx"
            })
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(Dt, "Informe").ColumnsUsed().AdjustToContents();
                            wb.SaveAs(SaveFile.FileName);
                        }
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar reporte: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

        }
    }
}
