using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProveedor
    {
        private CDProveedor objcdProveedor = new CDProveedor();

        public List<Proveedor> Listar()
        {
            return objcdProveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            //VALIDACIONES DE REGISTRO 
            Mensaje = string.Empty;


            if (obj.Documento == "")
            {
                Mensaje += "Es necesario ingresar el documento del Proveedor\n";

            }

            if (obj.RazonSocial== "")
            {
                Mensaje += "Es necesario ingresar el nombre completo del Proveedor\n ";

            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar la Correoo del Proveedor\n";

            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcdProveedor.Registrar(obj, out Mensaje);


            }
        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            //VALIDACIONES DE EDITAR
            Mensaje = string.Empty;

            if (obj.RazonSocial== "")
            {
                Mensaje += "Es necesario ingresar el nombre completo del Proveedor\n ";

            }

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario ingresar el documento del Proveedor\n";

            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar la Correoo del Proveedor\n";

            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            return objcdProveedor.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.RazonSocial== "")
            {
                Mensaje += "Es necesario ingresar el nombre completo del Proveedor\n ";

            }

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario ingresar el documento del Proveedor\n";

            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario ingresar la Correoo del Proveedor\n";

            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            return objcdProveedor.Eliminar(obj, out Mensaje);
        }
    }
}
