
using Microsoft.Data.SqlClient;

namespace PobleEmocions.Data
{
    public static class ConexionDB
    {
        private static readonly string connectionString =
            "Server=TU_SERVIDOR;" +
            "Database=TU_BASE_DATOS;" +
            "User Id=TU_USUARIO;" +
            "Password=PobleEmocions#2026;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;";

        public static SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);

            try
            {
                conexion.Open();
                return conexion;
            }
            catch
            {
                conexion.Dispose();
                throw;
            }
        }

        public static bool ComprobarConexion(out string mensaje)
        {
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    mensaje = "Conexión con SQL Server correcta.";
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error de conexión: " + ex.Message;
                return false;
            }
        }
    }
}
