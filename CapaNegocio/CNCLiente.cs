using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCliente
    {
        private CDCliente objcdCliente = new CDCliente();

        public List<Cliente> Listar()
        {
            return objcdCliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            //VALIDACIONES DE REGISTRO 
            Mensaje = string.Empty;


            if (obj.documento == "")
            {
                Mensaje += "Es necesario ingresar el documento del Cliente\n";

            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario ingresar el nombre completo del Cliente\n ";

            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar el Correo del Cliente\n";

            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcdCliente.Registrar(obj, out Mensaje);


            }
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            //VALIDACIONES DE EDITAR
            Mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario ingresar el nombre completo del Cliente\n ";

            }

            if (obj.documento == "")
            {
                Mensaje += "Es necesario ingresar el documento del Cliente\n";

            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar el Correo del Cliente\n";

            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            return objcdCliente.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario ingresar el nombre completo del Cliente\n ";

            }

            if (obj.documento == "")
            {
                Mensaje += "Es necesario ingresar el documento del Cliente\n";

            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar el Correo del Cliente\n";

            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            return objcdCliente.Eliminar(obj, out Mensaje);
        }

    }
}
