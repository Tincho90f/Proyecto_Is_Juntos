using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Backup_Mapper
    {
        private string connectionStringMaster = "Data Source=DESKTOP-DJ6O6PQ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

        private string connectionStringBase = "Data Source=DESKTOP-DJ6O6PQ\\SQLEXPRESS;Initial Catalog=Proyecto_Is_JuntosBD;Integrated Security=True";

        public void RealizarBackup(string rutaArchivo)
        {
            using (SqlConnection conn = new SqlConnection(connectionStringBase))
            {
                conn.Open();
                string nombreBase = "Proyecto_Is_JuntosBD";

                string cmdText = $"BACKUP DATABASE [{nombreBase}] TO DISK = @ruta WITH FORMAT, INIT, NAME = 'Backup Completo'";

                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@ruta", rutaArchivo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RealizarRestore(string rutaArchivo)
        {
            using (SqlConnection conn = new SqlConnection(connectionStringMaster))
            {
                conn.Open();
                string nombreBase = "Proyecto_Is_JuntosBD";

               
                string sqlAlter1 = $"ALTER DATABASE [{nombreBase}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                using (SqlCommand cmd1 = new SqlCommand(sqlAlter1, conn))
                {
                    cmd1.ExecuteNonQuery();
                }

                string sqlRestore = $"RESTORE DATABASE [{nombreBase}] FROM DISK = @ruta WITH REPLACE";
                using (SqlCommand cmd2 = new SqlCommand(sqlRestore, conn))
                {
                    cmd2.Parameters.AddWithValue("@ruta", rutaArchivo);
                    cmd2.ExecuteNonQuery();
                }

                string sqlAlter2 = $"ALTER DATABASE [{nombreBase}] SET MULTI_USER";
                using (SqlCommand cmd3 = new SqlCommand(sqlAlter2, conn))
                {
                    cmd3.ExecuteNonQuery();
                }
            }
        }
    }
}
