using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Registros.Models
{
    //internal class Empleados
    public class Empleados
    {
        [PrimaryKey, AutoIncrement]
        public int IdEmp { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string ApellidoPaterno { get; set; }

        [MaxLength(50)]
        public string ApellidoMaterno { get; set; }

        public int Edad { get; set; }

        public string Telefono { get; set; }
    }
}
