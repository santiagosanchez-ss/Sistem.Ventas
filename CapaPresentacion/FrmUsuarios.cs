using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
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
        {/*
            DGVData.Rows.Add(new object[] {"",TxtId.Text,TxtDocumento.Text,TxtNombreCompleto.Text,TxtCorreo.Text,TxtClave.Text,
            ((OpcionCombo)CboRol.SelectedItem).Valor.ToString(),
            ((OpcionCombo)CboRol.SelectedItem).Texto.ToString(),
            ((OpcionCombo)CboEstado.SelectedItem).Valor.ToString(),
            ((OpcionCombo)CboEstado.SelectedItem).Texto.ToString(),
        });

            Limpiar();*/
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

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
                    CboBusqueda.Items.Add(new OpcionCombo() { Valor = 1, Texto = columns.HeaderText });

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
            TxtId.Text = "0";
            TxtDocumento.Text = "";
            TxtNombreCompleto.Text = "";
            TxtCorreo.Text = "";
            TxtClave.Text = "";
            TxtConfirmarClave.Text = "";
            CboRol.SelectedIndex = 0;
            CboEstado.SelectedIndex = 0;
            TxtIndice.Text = "-1";

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

                e.Graphics.DrawImage(Properties.Resources.check24_png, new Rectangle (x, y, w, h));   
                e.Handled = true;
            }
        }

        private void DGVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int indice = e.RowIndex;

                if(indice >= 0)
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
                        if(Convert.ToInt32(oc.Valor) == Convert.ToInt32(DGVData.Rows[indice].Cells["IdRol"].Value))
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

        
    }
}
