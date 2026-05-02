using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Backup_BLL
    {
        private Backup_Mapper mapper = new Backup_Mapper();

        public void GenerarBackup(string ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta))
                throw new Exception("La ruta del archivo no puede estar vacía.");

            mapper.RealizarBackup(ruta);
        }

        public void RealizarRestore(string ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta))
                throw new Exception("La ruta del archivo no puede estar vacía.");

            mapper.RealizarRestore(ruta);
        }
    }
}
