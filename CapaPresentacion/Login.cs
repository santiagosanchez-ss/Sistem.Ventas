using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        { 
            List <Usuario> TEST = new CNUsuario().Listar();


            Usuario oUsuario = new CNUsuario().Listar().Where(u => u.Documento == Txtdocumento.Text && u.Clave == Txtclave.Text).FirstOrDefault();

            if(oUsuario != null)
            {
                Inicio form = new Inicio();
                // form.Show();
                form.Hide();
                form.Show();

                form.FormClosing += Form_Closing;


            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void Form_Closing(object sender, FormClosingEventArgs e)

        {
            Txtdocumento.Text = "";
            Txtclave.Text = "";
            this.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
