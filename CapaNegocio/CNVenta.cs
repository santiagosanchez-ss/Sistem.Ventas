using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CNVenta
    {
        private CDVenta objcdVenta = new CDVenta();

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objcdVenta.RestarStock(idproducto, cantidad);
        }
        public bool SumarStock(int idproducto, int cantidad)
        {
            return objcdVenta.SumarStock(idproducto, cantidad);
        }

        public int ObtenerCorrelativo()
        {
            return objcdVenta.ObtenerCorrelativo();
        }

        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {

            return objcdVenta.Registrar(obj, DetalleVenta, out Mensaje);


        }


        public Venta ObtenerVenta(string numero)

        {
            Venta oVenta = objcdVenta.ObtenerVenta(numero);
            if (oVenta.IdVentas != 0)
            {
                List<DetalleVenta> oDetalleVenta = objcdVenta.ObtenerDetalleVenta(oVenta.IdVentas);
                oVenta.oDetalleVenta =oDetalleVenta;
            }
            return oVenta;
        }




    }
}
