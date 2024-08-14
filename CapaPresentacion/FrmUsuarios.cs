using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Usuario objUsuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(TxtId.Text),
                Documento = TxtDocumento.Text,
                NombreCompleto = TxtNombreCompleto.Text,
                Correo = TxtCorreo.Text,
                Clave = TxtClave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)CboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)CboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objUsuario.IdUsuario == 0)
            {




                //LE PASAMOS EL  METODO REGISTRAR (encargado de registrar usuarios en la db) Y COMO RESPUESTA OBTENEMOS EL iDUSUARIOGENERADO
                int IdUsuarioGenerado = new CNUsuario().Registrar(objUsuario, out mensaje);


                //SI iDUsuarioGenerado ES DISTINTO A CERO (osea, no se registro en la base de datos ) QUE PROSIGA A MOSTRAR TODOS LOS VALORES NUEVOS AL DATAGRIDVIEW
                if (IdUsuarioGenerado != 0)
                {

                    DGVData.Rows.Add(new object[] {"",IdUsuarioGenerado,TxtDocumento.Text,TxtNombreCompleto.Text,TxtCorreo.Text,TxtClave.Text,
                    ((OpcionCombo)CboRol.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)CboRol.SelectedItem).Texto.ToString(),
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
                bool Resultado = new CNUsuario().Editar(objUsuario, out mensaje);
                if (Resultado == true)
                {
                    DataGridViewRow Row = DGVData.Rows[Convert.ToInt32(TxtIndice.Text)];
                    Row.Cells["Id"].Value = TxtId.Text;
                    Row.Cells["Documento"].Value = TxtDocumento.Text;
                    Row.Cells["NombreCompleto"].Value = TxtNombreCompleto.Text;
                    Row.Cells["Correo"].Value = TxtCorreo.Text;
                    Row.Cells["Clave"].Value = TxtClave.Text;
                    Row.Cells["IdRol"].Value = ((OpcionCombo)CboRol.SelectedItem).Valor.ToString();
                    Row.Cells["Rol"].Value = ((OpcionCombo)CboRol.SelectedItem).Texto.ToString();
                    Row.Cells["EstadoValor"].Value = ((OpcionCombo)CboRol.SelectedItem).Valor.ToString();
                    Row.Cells["Estado"].Value = ((OpcionCombo)CboRol.SelectedItem).Texto.ToString();

                    Limpiar();


                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxtId.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el Usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objUsuario = new Usuario()

                    {
                        IdUsuario = Convert.ToInt32(TxtId.Text),

                    };

                    bool respuesta = new CNUsuario().Eliminar(objUsuario, out mensaje);

                    if(respuesta )
                    {
                        DGVData.Rows.RemoveAt(Convert.ToInt32(TxtIndice.Text));

                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtDocumento.Text = "";
            TxtNombreCompleto.Text = "";
            TxtCorreo.Text = "";
            TxtClave.Text = "";
            TxtConfirmarClave.Text = "";
            CboRol.Text = "";
            CboEstado.Text = "";
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            CboEstado.DisplayMember = "Texto";
            CboEstado.ValueMember = "Valor";
            CboEstado.SelectedIndex = 0;

            List<Rol> ListRol = new CNRol().Listar();

            foreach (Rol item in ListRol)
            {
                CboRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });

                CboRol.DisplayMember = "Texto";
                CboRol.ValueMember = "Valor";
                CboRol.SelectedIndex = 0;
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

            //PARA MOSTRAR TODOS LOS USUARIOS

            List<Usuario> ListaUsuarios = new CNUsuario().Listar();

            foreach (Usuario item in ListaUsuarios)
            {
                DGVData.Rows.Add(new object[] {
                    "",
                    item.IdUsuario,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo": " Inactivo"
                });
            }


        }

        private void Limpiar()
        {
            TxtIndice.Text = "-1";
            TxtId.Text = "";
            TxtDocumento.Text = "";
            TxtNombreCompleto.Text = "";
            TxtCorreo.Text = "";
            TxtClave.Text = "";
            TxtConfirmarClave.Text = "";
            CboRol.SelectedIndex = 0;
            CboEstado.SelectedIndex = 0;

            TxtDocumento.Select();
        }

        private void CboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // PARA PINTAR EL CHECK EN LA LISTA  ROW 0
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
                    TxtDocumento.Text = DGVData.Rows[indice].Cells["Documento"].Value.ToString();
                    TxtNombreCompleto.Text = DGVData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    TxtCorreo.Text = DGVData.Rows[indice].Cells["Correo"].Value.ToString();
                    TxtClave.Text = DGVData.Rows[indice].Cells["Clave"].Value.ToString();
                    TxtConfirmarClave.Text = DGVData.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo oc in CboRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGVData.Rows[indice].Cells["IdRol"].Value))
                        {
                            int IndiceCombo = CboRol.Items.IndexOf(oc);
                            CboRol.SelectedIndex = IndiceCombo;
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

        private void  BtmBuscar_Click(object sender, EventArgs e)
        {

            string ColumnaFiltro = ((OpcionCombo)CboBusqueda.SelectedItem).Valor.ToString();
            if (DGVData.Rows.Count > 0)
            {
                foreach( DataGridViewRow row in DGVData.Rows)
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
            foreach(DataGridViewRow row in DGVData.Rows)
            {
                row.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
