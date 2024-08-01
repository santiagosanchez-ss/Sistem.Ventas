using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Remoting.Messaging;


namespace CapaDatos
{
    public class CDUsuario
    {

        public List<Usuario> Listar()

        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.Cadena)) 
            {



                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.IdUsuario,u.Documento,u.NombreCompleto,u.Correo,u.Clave,u.Estado,r.IdRol,R.Descripcion from Usuario u");
                    query.AppendLine("inner join ROL r on r.IdRol = u.IdRol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;


                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave=dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion= dr["Descripcion"].ToString() }

                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }

            return lista;
        }
        
    }
}
