using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNPermiso
    {
        private CDPermiso objcdPermiso = new CDPermiso();

        public List<Permiso> Listar(int IdUsuario)
        {
            return objcdPermiso.Listar(IdUsuario);
        }
    }
}
