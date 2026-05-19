using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueo
{
    public class Conexion
    {
        public static string vStringConexionSisUser = "data source=LAPTOP-HOM9AQ08\\MSSQLSERVER02;initial catalog=ParqueoDB;Integrated Security=SSPI";
        public SqlDataAdapter vMySQLDataAdapter; // permite hacer consultas a sqlserver, no se recomienda para insert o update
        public SqlCommand vMySQLCommand; // permite hacer insert con parametros, para evitar sqlinjection
        public static SqlConnection vConexionSisUser = new SqlConnection(vStringConexionSisUser);
    }
}
