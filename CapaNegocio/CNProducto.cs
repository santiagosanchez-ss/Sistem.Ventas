using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProducto
    {
        private CDProducto objcdProducto = new CDProducto();

        public List<Producto> Listar()
        {
            return objcdProducto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            //VALIDACIONES DE REGISTRO 
            Mensaje = string.Empty;


            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario ingresar el codigo del Producto\n";

            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario ingresar el nombre del Producto\n ";

            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario ingresar la descripcion del Producto\n";

            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcdProducto.Registrar(obj, out Mensaje);


            }
        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            //VALIDACIONES DE EDITAR
            Mensaje = string.Empty;


            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario ingresar el codigo del Producto\n";

            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario ingresar el nombre del Producto\n ";

            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario ingresar la descripcion del Producto\n";

            }

            if (Mensaje != string.Empty)
            {
                return false; 
            }
            else
            {
                return objcdProducto.Editar(obj, out Mensaje);


            }
        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
           
            return objcdProducto.Eliminar(obj, out Mensaje);
        }

    
    }
}
