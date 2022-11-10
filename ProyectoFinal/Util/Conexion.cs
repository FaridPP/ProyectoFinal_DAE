using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Util
{
    internal class Conexion
    {
        private string cadenaConexion;
        public SqlConnection con;
        public Conexion()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "FARIDPC\\SQLEXPRESS";
            builder.InitialCatalog = "CLINICAS";
            builder.UserID = "sa";
            builder.Password = "hola123";
            //builder.ApplicationName = "FARIDPC\\SQLEXPRESS";
            cadenaConexion = builder.ConnectionString;
        }

        public void createConexion()
        {
            con = new SqlConnection(cadenaConexion);
        }

        public string testConexion()
        {
            con = new SqlConnection(cadenaConexion);
            try
            {
                con.Open();
                con.Close();
                return "La conexion se realizó correctamente";
            }
            catch (Exception e)
            {
                con = null;
                return e.Message;
            }
        }
    }
}
