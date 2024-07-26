using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    //ESTA CLASE SERA LA ENCARGADA DE REPARTIR LA CADENA DE CONEXION A TODAS LAS DEMAS CLASES
    public class Conexion
    {
        

        public static string Cadena = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
            
    }
}
