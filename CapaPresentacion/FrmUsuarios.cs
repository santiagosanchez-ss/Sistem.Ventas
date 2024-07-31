using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

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
            DGVData.Rows.Add(new object[] {"",TxtId.Text,TxtDocumento.Text,TxtNombreCompleto.Text,TxtCorreo.Text,TxtClave.Text,
            ((OpcionCombo)CboRol.SelectedItem).Valor.ToString(),
            ((OpcionCombo)CboRol.SelectedItem).Texto.ToString(),
            ((OpcionCombo)CboEstado.SelectedItem).Valor.ToString(),
            ((OpcionCombo)CboEstado.SelectedItem).Texto.ToString(),
        });

            Limpiar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor=1,Texto="Activo" } );
            CboEstado.Items.Add(new OpcionCombo() { Valor=0,Texto="Inactivo" } );
            CboEstado.DisplayMember = "Texto";
            CboEstado.ValueMember = "Valor";
            CboEstado.SelectedIndex = 0;

            List <Rol> ListRol = new CNRol().Listar();

            foreach(Rol item in ListRol)
            {
                CboRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });

                CboRol.DisplayMember = "Texto";
                CboRol.ValueMember = "Valor";
                CboRol.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columns in DGVData.Columns)
            {
                if(columns.Visible == true && columns.Name != "BtnSeleccionar")
                {
                    CboBusqueda.Items.Add(new OpcionCombo() { Valor = 1, Texto = columns.HeaderText });

                    CboBusqueda.DisplayMember = "Texto";
                    CboBusqueda.ValueMember = "Valor";
                    CboBusqueda.SelectedIndex = 0;
                }

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
            CboRol.SelectedIndex =0;
            CboEstado.SelectedIndex =0;

        }

        private void CboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
