using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNNegocio
    {
        private CDNegocio objcdNegocio = new CDNegocio();

        public Negocio ObtenerDatos()
        {
            return objcdNegocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string mensaje)
        {
            //VALIDACIONES DE REGISTRO 
            mensaje = string.Empty;


            if (obj.Nombre == "")
            {
                mensaje += "Es necesario ingresar el Nombre del Negocio\n";

            }

            if (obj.RUC == "")
            {
                mensaje += "Es necesario ingresar el numero de RUC del Negocio\n ";

            }

            if (obj.Direccion == "")
            {
                mensaje += "Es necesario ingresar la direccion del Negocio\n";

            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcdNegocio.GuardarDatos(obj, out mensaje);


            }
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {

            return objcdNegocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[]imagen, out string mensaje)
        {

            return objcdNegocio.ActulizarLogo(imagen, out mensaje);
        }
    }
}
