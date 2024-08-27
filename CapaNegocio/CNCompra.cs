using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCompra
    {
        private CDCompra objcdCompra = new CDCompra();

        public int ObtenerCorrelativo()
        {
            return objcdCompra.ObtenerCorrelativo();
        }
        
        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
           
                return objcdCompra.Registrar(obj, DetalleCompra,out Mensaje);


        }

    }
}
