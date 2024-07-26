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
using CapaDatos;

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


            Usuario oUsuario = new CNUsuario().Listar().Where(u => u.Documento == TxtDocumento.Text && u.Clave == TxtClave.Text).FirstOrDefault();


            Inicio form= new Inicio();
           // form.Show();
            form.Hide();
            form.Show();

            form.FormClosing += Form_Closing;

        }

        private void Form_Closing(object sender, FormClosingEventArgs e)

        {
            TxtDocumento.Text = "";
            TxtClave.Text = "";
            this.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
