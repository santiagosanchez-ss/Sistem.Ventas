using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNReporte
    {
        private CDReporte objcdReporte = new CDReporte();

        public List <ReporteCompra> Compra (string FechaInicio, string FechaFin, int IdProveedor)
        {
            return objcdReporte.Compra(FechaInicio,FechaFin,IdProveedor);   

        }

        public List<ReporteVenta> Venta(string FechaInicio, string FechaFin)
        {
            return objcdReporte.Venta(FechaInicio, FechaFin);

        }
    }
}
