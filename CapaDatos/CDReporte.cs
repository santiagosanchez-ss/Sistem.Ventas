using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CDReporte
    {
        public List<ReporteCompra> Compra(string FechaInicio, string FechaFin, int IdProveedor)

        {
            List<ReporteCompra> lista = new List<ReporteCompra>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.Cadena))
            {
                try
                {

                   // StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("SPReporteCompra", oConexion);
                    DateTime fechaInicioConvertida = DateTime.Parse(FechaInicio);
                    DateTime fechaFinConvertida = DateTime.Parse(FechaFin);

                    cmd.Parameters.AddWithValue("FechaInicio", fechaInicioConvertida);
                    cmd.Parameters.AddWithValue("FechaFin", fechaFinConvertida);
                    cmd.Parameters.AddWithValue("IdProveedor", IdProveedor);
                    cmd.CommandType = CommandType.StoredProcedure;

                   


                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new ReporteCompra()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                DocumentoProveedor = dr["DocumentoProveedor"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioCompra = dr["PrecioCompra"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString(),


                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<ReporteCompra>();
                }
            }

            return lista;
        }
        public List<ReporteVenta> Venta(string FechaInicio, string FechaFin)

        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.Cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("SPReporteCompra", oConexion);
                    cmd.Parameters.AddWithValue("FechaInicio", FechaInicio);
                    cmd.Parameters.AddWithValue("FechaFin", FechaFin);
                   
                    cmd.CommandType = CommandType.StoredProcedure;




                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString(),


                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVenta>();
                }
            }

            return lista;
        }

    }
}
