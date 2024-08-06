using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
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

            return objcdUsuario.Registrar(obj,out Mensaje );
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            return objcdUsuario.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcdUsuario.Eliminar(obj, out Mensaje);
        }

    }
}
