using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CDNegocio
    {
        public Negocio ObtenerDatos()
        {
            Negocio Obj = new Negocio();

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.Cadena))
                {
                    oConexion.Open();

                    string query = "select IdNegocio, Nombre,RUC,Direccion from NEGOCIO where IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader() )
                    {
                        while (dr.Read()) {
                            Obj = new Negocio()
                            {
                                IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                RUC = dr["RUC"].ToString(),
                                Direccion = dr["Direccion"].ToString()

                            };
                        }

                    }

                }

            }
            catch
            {
                Obj = new Negocio();
            }
            return Obj;
        }

        public bool GuardarDatos(Negocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;


            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.Cadena))
                {
                    oConexion.Open();

                    StringBuilder query = new StringBuilder();

                    query.AppendLine("UPDATE NEGOCIO SET Nombre = @Nombre,");
                    query.AppendLine("RUC = @RUC,");
                    query.AppendLine("Direccion = @Direccion");
                    query.AppendLine("WHERE IdNegocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@RUC", objeto.RUC);
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
           
                    cmd.CommandType = CommandType.Text;

                    if(cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo guardar los datos";
                        respuesta = false;
                    }
                   
                }

            }
            catch (Exception ex) 
            {
                mensaje += ex.Message;
                respuesta =false;

            }
            return respuesta;

        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.Cadena))
                {
                    oConexion.Open();
                    //solicitamos el logo por medio de una consulta a la tabla NEGOCIO
                    string query = "select Logo from NEGOCIO where IdNegocio = 1";
                    //el sqlcommand lo toma desde la conexion 
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    //aclaramos que es un tipo texto
                    cmd.CommandType = CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LogoBytes = (byte[])dr["Logo"];
                            
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                obtenido = false;
                LogoBytes= new byte[0];

            }
            return LogoBytes;

        }

        public bool ActulizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;


            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.Cadena))
                {
                    oConexion.Open();

                    StringBuilder query = new StringBuilder();

                    query.AppendLine("Update NEGOCIO set Logo =@imagen");
                    query.AppendLine("where IdNegocio =1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@imagen", image);

                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actulizar el logo";
                        respuesta = false;
                    }

                }

            }
            catch (Exception ex)
            {
                mensaje += ex.Message;
                respuesta = false;

            }
            return respuesta;
        }
    }
}
