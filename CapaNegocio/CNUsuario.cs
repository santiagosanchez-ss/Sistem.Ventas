using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
namespace CapaNegocio
{
    //CN = CAPA Negocio
    public class CNUsuario
    {
        private CDUsuario objcdUsuario = new CDUsuario();

        public List<Usuario> Listar()
        {
            return objcdUsuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            //VALIDACIONES DE REGISTRO 
            Mensaje = string.Empty;


            if (obj.Documento == "")
            {
                Mensaje += "Es necesario ingresar el documento del usuario\n";

            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario ingresar el nombre completo del usuario\n ";

            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario ingresar la clave del usuario\n";

            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcdUsuario.Registrar(obj, out Mensaje);


            }
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            //VALIDACIONES DE EDITAR
            Mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario ingresar el nombre completo del usuario\n ";

            }

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario ingresar el documento del usuario\n";

            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario ingresar la clave del usuario\n";

            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            return objcdUsuario.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario ingresar el nombre completo del usuario\n ";

            }

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario ingresar el documento del usuario\n";

            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario ingresar la clave del usuario\n";

            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            return objcdUsuario.Eliminar(obj, out Mensaje);
        }

    }
}
