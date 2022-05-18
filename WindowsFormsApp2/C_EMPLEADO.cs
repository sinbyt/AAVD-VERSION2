using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;

namespace WindowsFormsApp2
{

    public class Empleado
    {
       
        public int ID_Empleado { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string fechaAlta { get; set; }
        public string edad { get; set; }
        public string depa { get; set; }
        public string puesto { get; set; }
        public string fechaNacimiento { get; set; }
        public string CURP { get; set; }
        public string NSS { get; set; }
        public string RFC { get; set; }
        public string domicilio { get; set; }
        public string banco { get; set; }
        public string numCuenta { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

    }
    class C_EMPLEADO
    {
       
    }
}
