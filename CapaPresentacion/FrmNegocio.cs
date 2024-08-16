using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmNegocio : Form
    {
        public FrmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] ImageByte)
        {
            MemoryStream  ms = new MemoryStream();
            ms.Write(ImageByte, 0, ImageByte.Length);
            Image image = new Bitmap(ms);
            return image;
        }

        private void FrmNegocio_Load(object sender, EventArgs e)
        {
            bool Obtenido = true;
            byte[] ByteImagen = new CNNegocio().ObtenerLogo(out Obtenido);

            if (Obtenido)
            {
                PicLogo.Image = ByteToImage(ByteImagen);
            }

            Negocio Datos = new CNNegocio().ObtenerDatos();

            TxtNombre.Text = Datos.Nombre;
            TxtRUC.Text = Datos.RUC;
            TxtDireccion.Text = Datos.Direccion;
        }

        private void BtnSubirImg_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();

            oOpenFileDialog.FileName = "Files|*.jpg;*.jepg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] ByteImage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CNNegocio().ActualizarLogo(ByteImage, out mensaje);
            
                if (respuesta)
                {
                    PicLogo.Image = ByteToImage(ByteImage);
                }
                else
                {
                    MessageBox.Show( mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                }
            }



        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
              Nombre  = TxtNombre.Text,
              RUC  = TxtRUC.Text,
              Direccion = TxtDireccion.Text

            };
            bool respuesta = new CNNegocio().GuardarDatos(obj, out mensaje);

            if (respuesta) 
            {
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
    }

  
    
}
