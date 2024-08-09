using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CNCategoria
    {
        private CDCategoria objcdCategoria = new CDCategoria();

        public List<Categoria> Listar()
        {
            return objcdCategoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            //VALIDACIONES DE REGISTRO 
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripcion de la categoria\n ";

            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcdCategoria.Registrar(obj, out Mensaje);


            }
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            //VALIDACIONES DE EDITAR
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripcion de la categoria\n ";

            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcdCategoria.Editar(obj, out Mensaje);


            }
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objcdCategoria.Eliminar(obj, out Mensaje);
        }
    }
}
