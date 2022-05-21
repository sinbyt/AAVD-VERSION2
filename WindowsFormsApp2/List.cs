
    public class List
    {
        public class C_Departamento
        {
            public string nomDepa { get; set; }
            public string SueldoBase { get; set; }
        }

        public class C_Puesto
        {
            public string nomPuesto { get; set; }
            public string proporSal { get; set; }

        }
      public class Departamento
      {
        public string nomDepa{ get; set; }
        public string sueldoBase { get; set; }

      }
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
        public class Empresa
        {
            public string razon_social { get; set; }
            public string nombreEmp { get; set; }
            public string domicilioFis { get; set; }
            public string datosEmpCont { get; set; }
            public string regPat { get; set; }
            public string RFC_EMP { get; set; }
            public string inicioOp { get; set; }

        }
        public class C_Nomina
        {
            public string NomEmple { get; set; }
            public string FechaNom { get; set; }
            public string percept { get; set; }
            public string deducc { get; set; }
            public string sueldoB { get; set; }
            public string sueldoN { get; set; }
            public string jornada { get; set; }
            public string NumRec { get; set; }
            public string depa { get; set; }
            public string puesto { get; set; }
        }
        public class C_Recibo
        {
            public string nombreEmp { get; set; }
            public string FechaNom { get; set; }
            public string percept { get; set; }
            public string deducc { get; set; }
            public string NumRec { get; set; }
            public string sueldoB { get; set; }
            public string sueldoN { get; set; }
            public string jornada { get; set; }
            public string fechaAlta { get; set; }
            public string depa { get; set; }
            public string puesto { get; set; }
            public string sueldoNletra { get; set; }
            public string RegPat { get; set; }
            public string RFC_emple { get; set; }
            public string RFC_EMP { get; set; }
            public string inicioOp { get; set; }
            public string razon_social { get; set; }
            public string nomEmpresa { get; set; }
        }
    }

