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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            CboEstado.DisplayMember = "Texto";
            CboEstado.ValueMember = "Valor";
            CboEstado.SelectedIndex = 0;

            List<Rol> ListRol = new CNRol().Listar();

       

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

            //PARA MOSTRAR TODOS LOS ClienteS

            List<Cliente> ListaClientes = new CNCliente().Listar();

            foreach (Cliente item in ListaClientes)
            {
                DGVData.Rows.Add(new object[] {
                    "",
                    item.IdCliente,
                    item.documento,
                    item.NombreCompleto,
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
            Cliente objCliente = new Cliente()
            {
                IdCliente = Convert.ToInt32(TxtId.Text),
                documento = TxtDocumento.Text,
                NombreCompleto = TxtNombreCompleto.Text,
                Correo = TxtCorreo.Text,
                Telefono = TxtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)CboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objCliente.IdCliente == 0)
            {




                //LE PASAMOS EL  METODO REGISTRAR (encargado de registrar Clientes en la db) Y COMO RESPUESTA OBTENEMOS EL iDClienteGENERADO
                int IdClienteGenerado = new CNCliente().Registrar(objCliente, out mensaje);


                //SI iDClienteGenerado ES DISTINTO A CERO (osea, no se registro en la base de datos ) QUE PROSIGA A MOSTRAR TODOS LOS VALORES NUEVOS AL DATAGRIDVIEW
                if (IdClienteGenerado != 0)
                {

                    DGVData.Rows.Add(new object[] {"",IdClienteGenerado,TxtDocumento.Text,TxtNombreCompleto.Text,TxtCorreo.Text,TxtTelefono.Text,

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
                bool Resultado = new CNCliente().Editar(objCliente, out mensaje);
                if (Resultado == true)
                {
                    DataGridViewRow Row = DGVData.Rows[Convert.ToInt32(TxtIndice.Text)];
                    Row.Cells["Id"].Value = TxtId.Text;
                    Row.Cells["documento"].Value = TxtDocumento.Text;
                    Row.Cells["NombreCompleto"].Value = TxtNombreCompleto.Text;
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
            TxtNombreCompleto.Text = "";
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

        private void DGVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DGVData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    TxtIndice.Text = indice.ToString();
                    TxtId.Text = DGVData.Rows[indice].Cells["Id"].Value.ToString();
                    TxtDocumento.Text = DGVData.Rows[indice].Cells["documento"].Value.ToString();
                    TxtNombreCompleto.Text = DGVData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
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
                if (MessageBox.Show("Desea eliminar el Cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente objCliente = new Cliente()

                    {
                        IdCliente = Convert.ToInt32(TxtId.Text),

                    };

                    bool respuesta = new CNCliente().Eliminar(objCliente, out mensaje);

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
    }
}
