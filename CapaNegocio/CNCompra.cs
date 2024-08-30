using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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

        public Compra ObtenerCompra(string numero)
        {
            Compra oCompra = objcdCompra.ObtenerCompra(numero);
            if (oCompra.IdCompra !=0)
            {
                List <DetalleCompra> oDetalleCompra= objcdCompra.ObtenerDetalleCompra(oCompra.IdCompra);    
                oCompra.oDetalleCompra = oDetalleCompra;
            }
            return oCompra; 
        }

    }
}
