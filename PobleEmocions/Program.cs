
using PobleEmocions.Data;

namespace PobleEmocions
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Comprobar conexión con SQL Server
            if (!ConexionDB.ComprobarConexion(out string mensaje))
            {
                MessageBox.Show(
                    mensaje,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Si la conexión funciona, iniciar la aplicación
            Application.Run(new Login());
        }
    }
}
