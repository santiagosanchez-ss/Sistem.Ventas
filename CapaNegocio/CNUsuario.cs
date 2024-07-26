using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
