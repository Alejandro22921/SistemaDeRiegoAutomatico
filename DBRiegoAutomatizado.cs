using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeRiegoAutomatico
{
    public class DBRiegoAutomatizado
    {
        /* <--- CONEXIÓN A LAB BD ---> */
        static SqlConnection conexion;
        public static void DBConectar()
        {
            // CADENA DE CONEXIÓN ALEX: Data Source=LAPTOP-7JPH5U2H\\SQLExpress;Initial Catalog=DBRiegoAutomatizado;Integrated Security=True
            // CADENA DE CONEXIÓN VLADIMIR: 
            conexion = new SqlConnection("Data Source=LAPTOP-7JPH5U2H\\SQLExpress;Initial Catalog=DBRiegoAutomatizado;Integrated Security=True");
            conexion.Open();
        }

    }
}
