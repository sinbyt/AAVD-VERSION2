using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;
using WindowsFormsApp2;
using static Lists;

   
namespace WindowsFormsApplication2
{
    public class EnlaceCassandra
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _instancia;

        private static void conectar()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();

            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _instancia = _cluster.Connect(_dbKeySpace);
        }


        private static void conectar2()
        {
            _cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();

            _instancia = _cluster.Connect("keyspace1");
        }

        private static void desconectar()
        {
            _cluster.Dispose();
        }

        //public bool InsertEmpleados(Empleados param);

        ///USUARIO=====================================================================




        public bool InsertUsuario(Usuario param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();

                var query1 = "insert into Usuario (usuario, tipous, contra)";
                query1 = "values'({0}','{1}','{2}','{3}');";
                query1 += "if not exists; ";
                query1 = string.Format(query1, param.usuario, param.tipous + param.contra);

                _instancia.Execute(query1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }
        
        ///EMPLEADO=====================================================================
        public bool InsertEmpleado(Empleado param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();
                //var fecha = param.fechaAlta.ToString("yyyy-MM-dd");

                var num_empleado = new Guid();
                num_empleado = Guid.NewGuid();
                param.ID_Empleado = num_empleado;
                // var query = "BEGIN BATCH ";
                var query1 = "insert into Empleado(ID_Empleado,nombre,apellidos, fechaAlta, edad, depa, puesto, fechaNacimiento, CURP, NSS,RFC,domicilio,banco,numCuenta,telefono,email,contra) values(";
                
                query1 +=param.ID_Empleado.ToString();
                query1 += ", '";
                query1 += param.nombre;
                query1 += "', '";
                query1 += param.apellidos;
                query1 += "', '";
                query1 += param.fechaAlta;
                query1 += "', ";
                query1 += param.edad.ToString();
                query1 += ", '";
                query1 += param.depa;
                query1 += "', '";
                query1 += param.puesto;
                query1 += "', '";
                query1 += param.fechaNacimiento;
                query1 += "', '";
                query1 += param.CURP;
                query1 += "', '";
                query1 += param.NSS;
                query1 += "', '";
                query1 += param.RFC;
                query1 += "', '";
                query1 += param.domicilio;
                query1 += "', '";
                query1 += param.banco;
                query1 += "', '";
                query1 += param.numCuenta;
                query1 += "', '";
                query1 += param.telefono;
                query1 += "', '";
                query1 += param.email;
                query1 += "', '";
                query1 += param.contra;

                query1 += "');";

              
                _instancia.Execute(query1);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;


           
        }
        public void EditEmpleado(Lists.Empleado param, string oldDepto, string oldPuesto)
        {

            try
            {
                conectar();





                var query1 = "ID_Empleado, nombre,apellidos, fechaAlta, edad, depa, puesto, fechaNacimiento, CURP, NSS,RFC,domicilio,banco,numCuenta,telefono,email,contra";
               // query1 +=  param.ID_Empleado,  param.nombre, param.apellidos, param.fechaAlta ,  param.edad ,  param.depa ,  param.puesto ,  param.fechaNacimiento ,  param.CURP ,  param.NSS ,  param.RFC ,  param.domicilio ,  param.banco,  param.email ,  param.numCuenta ,  param.telefono ,  param.contra 
             
            //    query1 += param.ID_Empleado;
           //     query1 += ";";

                #region PRAGMA 
                /*

                if (oldDepto != "" && oldPuesto != "")
                {
                    var query2 = "UPDATE cantidad_empleados_por_departamento SET cantidad = cantidad - 1 WHERE departamento ='";
                    query2 += oldDepto;
                    query2 += "';";

                    SimpleStatement simpleStatement2 = new SimpleStatement(query2);

                    var query3 = "UPDATE cantidad_empleados_por_departamento_puesto SET cantidad = cantidad - 1 WHERE departamento ='";
                    query3 += oldDepto;
                    query3 += "' AND puesto='";
                    query3 += oldPuesto;
                    query3 += "';";

                    SimpleStatement simpleStatement3 = new SimpleStatement(query3);

                    var query4 = "UPDATE cantidad_empleados_por_departamento SET cantidad = cantidad + 1 WHERE departamento ='";
                    query4 += param.depa;
                    query4 += "';";

                    SimpleStatement simpleStatement4 = new SimpleStatement(query4);

                    var query5 = "UPDATE cantidad_empleados_por_departamento_puesto SET cantidad = cantidad + 1 WHERE departamento ='";
                    query5 += param.depa;
                    query5 += "' AND puesto='";
                    query5 += param.depa;
                    query5 += "';";

                    SimpleStatement simpleStatement5 = new SimpleStatement(query5);

                    var query6 = "DELETE FROM empleados_por_departamento WHERE departamento ='";
                    query6 += oldDepto;
                    query6 += "' AND num_empleado=";
                    query6 += param.ID_Empleado;
                    query6 += ";";

                    SimpleStatement simpleStatement6 = new SimpleStatement(query6);


                    var query7 = "INSERT INTO empleados_por_departamento(num_empleado, nombre, departamento) VALUES(";
                    query7 += param.nombre;
                    query7 += ",'";
                    query7 += param.nombre;
                    query7 += "','";
                    query7 += param.depa;
                    query7 += "');";

                    SimpleStatement simpleStatement7 = new SimpleStatement(query7);


                    BatchStatement batchCounter = new BatchStatement().SetBatchType(BatchType.Counter).Add(simpleStatement2).Add(simpleStatement3).Add(simpleStatement4).Add(simpleStatement5);
                    BatchStatement batchNormal = new BatchStatement().SetBatchType(BatchType.Logged).Add(simpleStatement6).Add(simpleStatement7);

                    _instancia.Execute(batchNormal);
                    _instancia.Execute(batchCounter);


                }
                /*
                else if (oldDepto != "")
                {

                    var query2 = "UPDATE cantidad_empleados_por_depart  amento SET cantidad = cantidad - 1 WHERE departamento ='";
                    query2 += oldDepto;
                    query2 += "';";

                    SimpleStatement simpleStatement2 = new SimpleStatement(query2);

                    var query4 = "UPDATE cantidad_empleados_por_departamento SET cantidad = cantidad + 1 WHERE departamento ='";
                    query4 += param.depa;
                    query4 += "';";

                    SimpleStatement simpleStatement4 = new SimpleStatement(query4);


                    var query6 = "DELETE FROM empleados_por_departamento WHERE departamento ='";
                    query6 += oldDepto;
                    query6 += "' AND num_empleado=";
                    query6 += param.ID_Empleado;
                    query6 += ";";

                    SimpleStatement simpleStatement6 = new SimpleStatement(query6);


                    var query7 = "INSERT INTO empleados_por_departamento(num_empleado, nombre, departamento) VALUES(";
                    query7 += param.nombre;
                    query7 += ",'";
                    query7 += param.nombre;
                    query7 += "','";
                    query7 += param.depa;
                    query7 += "');";

                    SimpleStatement simpleStatement7 = new SimpleStatement(query7);


                    BatchStatement batchCounter = new BatchStatement().SetBatchType(BatchType.Counter).Add(simpleStatement2).Add(simpleStatement4);
                    BatchStatement batchNormal = new BatchStatement().SetBatchType(BatchType.Logged).Add(simpleStatement6).Add(simpleStatement7);

                    _instancia.Execute(batchNormal);
                    _instancia.Execute(batchCounter);



                }
                else if (oldPuesto != "")
                {

                    var query3 = "UPDATE cantidad_empleados_por_departamento_puesto SET cantidad = cantidad - 1 WHERE departamento ='";
                    query3 += param.departamento;
                    query3 += "' AND puesto='";
                    query3 += oldPuesto;
                    query3 += "';";

                    SimpleStatement simpleStatement3 = new SimpleStatement(query3);

                    var query5 = "UPDATE cantidad_empleados_por_departamento_puesto SET cantidad = cantidad + 1 WHERE departamento ='";
                    query5 += param.depa;
                    query5 += "' AND puesto='";
                    query5 += param.nom;
                    query5 += "';";

                    SimpleStatement simpleStatement5 = new SimpleStatement(query5);

                    BatchStatement batchCounter = new BatchStatement().SetBatchType(BatchType.Counter).Add(simpleStatement3).Add(simpleStatement5);

                    _session.Execute(batchCounter);


                }

                */
                #endregion
                _instancia.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }

        }
        public List<Lists.Empleado> Get_All_Empleado()
        {
            string query = "SELECT ID_Empleado, nombre,apellidos, fechaAlta, edad, depa, puesto, fechaNacimiento, CURP, NSS,RFC,domicilio,banco,numCuenta,telefono,email,contra FROM Empleado;";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<Lists.Empleado> empleado = mapper.Fetch<Lists.Empleado>(query);

            desconectar();
            return empleado.ToList();

        }
        public bool EliminarEmpleado(Guid id_emp)
        {
            try
            {
             //   Empleado delemp = get(id_emp);
                string delqry = "update Empleado set Activo = false where NUM_Empleado = ?;";
               // string dellogin = "delete from Log_Empleado where Correo_electronico = ?;";
                conectar();
                var delete_empleado = _instancia.Prepare(delqry);
                //  var delete_login = _instancia.Prepare(dellogin);
                var batch = new BatchStatement()
                            .Add(delete_empleado.Bind(id_emp));
                           // .Add(delete_login.Bind(delemp.correo_electronico))
                           // .Add(delete_rem.Bind((sbyte)1, delemp.correo_electronico));
                _instancia.Execute(batch);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                desconectar();
            }
        }

        ///DEPARTAMENTO=====================================================================
        public bool InsertDepa(Departamento param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();

                var query1 = "insert into Departamento(nomDepa, sueldoBase)";
                query1 += "values('{0}','{1}')";
                query1 += "if not exists;";
                query1 = string.Format(query1, param.nomDepa, param.sueldoBase);

                _instancia.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = true;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public List<Departamento> GetDepa()
        {
            string query = "SELECT nomDepa, sueldoBase FROM Departamento";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<Departamento> depas = mapper.Fetch<Departamento>(query);

            desconectar();
            return depas.ToList();

        }
        ///PUESTO=====================================================================
        public bool InsertPuesto(Puesto param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();

                var query1 = "insert into Puesto(nomPuesto, proporSal)";
                query1 += "values('{0}','{1}')";
                query1 += "if not exists; ";
                query1 = string.Format(query1, param.nomPuesto, param.proporSal);

                _instancia.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = true;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }


        public List<Puesto> GetPuesto()
        {
            string query = "SELECT nomPuesto, proporSal FROM Puesto";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<Puesto> puesto = mapper.Fetch<Puesto>(query);

            desconectar();
            return puesto.ToList();

        }



        ///PERDEC=====================================================================
        public bool Insertperdec(PERDEC param)
        {
            var Err = false; // SI no hay error
            try
            {


            
                conectar();
                var query5 = "insert into PERDEC(conceptoPD,monto, porcentPD, tipoDato)";
                query5 += "values('{0}','{1}','{2}','{3}')";
                query5 += "if not exists; ";
                query5 = string.Format(query5, param.conceptoPD ,param.monto, param.porcentPD, param.tipoDato);


                _instancia.Execute(query5);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }
        

        public List<PERDEC> Get_All_perdec()
        {
            string query = "SELECT tipoDato, conceptoPD, porcentPD, monto FROM PERDEC WHERE tipoDato = 'Percepcion'ALLOW FILTERING; ";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<PERDEC> perdec = mapper.Fetch<PERDEC>(query);

            desconectar();
            return perdec.ToList();


        }

        public List<PERDEC> Get_All_per()
        {
         
            try
            {
                string qry = "SELECT tipoDato, conceptoPD, porcentPD, monto FROM PERDEC WHERE tipoDato = 'Percepcion'ALLOW FILTERING;";
               
                conectar();
                IMapper mapper = new Mapper(_instancia);
                IEnumerable<PERDEC> lista = mapper.Fetch<PERDEC>(qry);
                return lista.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        public List<PERDEC> Get_All_deduc()
        {
            try
            {
                string qry = "SELECT tipoDato, conceptoPD, porcentPD, monto FROM PERDEC WHERE tipoDato = 'Deduccion'ALLOW FILTERING;";

                conectar();
                IMapper mapper = new Mapper(_instancia);
                IEnumerable<PERDEC> lista = mapper.Fetch<PERDEC>(qry);
                return lista.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                desconectar();
            }
        }


        public void InsertDeduccionEmpleado(PERDEC param)
        {

            try
            {
                conectar();


                var query1 = "INSERT INTO deducciones_por_empleado_fecha (conceptoPD, monto, porcentaje, tipoDato)";
               
                query1 += "values('{0}','{1}','{2}','{3}');";
                query1 += "if not exists; ";
                query1 = string.Format(query1, param.conceptoPD, param.monto, param.porcentPD, param.tipoDato);

                _instancia.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }

        }
        ///NOMINA=====================================================================
        public bool InsertNomina(NOMINA param)
        {

            var Err = false; // SI no hay error
            try
            {
                conectar();
                //var fecha = param.fechaAlta.ToString("yyyy-MM-dd");

                //var num_empleado = new Guid();
                //num_empleado = Guid.NewGuid();
                //param.numemp = num_empleado;
                 string percepciones = "";
                int i = 0;
                foreach (string percep in param.percep)
                {
                    if (i == 0)
                    {
                        percepciones += "['" + percep;
                    }
                    else if (i == (param.percep.Count - 1))
                    {
                        percepciones += "', '" + percep + "'] ";
                    }
                    else
                    {
                        percepciones += "', '" + percep;
                    }

                    if (i == 0 && i == (param.percep.Count - 1))
                    {
                        percepciones += "'] ";
                    }

                    i++;
                }

                string deducciones = "";
                i = 0;
                foreach (string ded in param.deducc)
                {
                    if (i == 0)
                    {
                        deducciones += "['" + ded;
                    }
                    else if (i == (param.deducc.Count - 1))
                    {
                        deducciones += "', '" + ded + "'] ";
                    }
                    else
                    {
                        deducciones += "', '" + ded;
                    }

                    if (i == 0 && i == (param.deducc.Count - 1))
                    {
                        deducciones += "'] ";
                    }

                    i++;
                }

                var query1 = "insert into NOMINA(numemp,fechanom,nomemple, percep, perpepT, deducc, deduccT, sueldoB, sueldoN, jornada,depa,puesto) values(";
               
                query1 += param.numemp.ToString();
                query1 += ", '";
                query1 += param.fechanom;
                query1 += "', '";
                query1 += param.nomemple;
                query1 += "', ";
                query1 += percepciones;
                query1 += ", '";
                query1 += param.perpepT;
                query1 += "', ";
                query1 += deducciones;
                query1 += ", '";
                query1 += param.deduccT;
                query1 += "', ";
                query1 += param.sueldoB.ToString();
                query1 += ", ";
                query1 += param.sueldoN.ToString();
                query1 += ", ";
                query1 += param.jornada.ToString();
                query1 += ", '";
                query1 += param.depa;
                query1 += "', '";
                query1 += param.puesto;           
                query1 += "');";


                _instancia.Execute(query1);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;


        }

        public List<Lists.NOMINA> GetAllNomina()
        {
            string query = "SELECT numemp,fechanom, nomemple,percep, perpepT, deducc, deduccT, sueldoB, sueldoN, jornada,depa,puesto FROM NOMINA;";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<Lists.NOMINA> nomina = mapper.Fetch<Lists.NOMINA>(query);

            desconectar();
            return nomina.ToList();

        }


        public bool listapercepc(listapercep param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into listapercep(idemp,fechanom,tipo, nom, monto) values(";
                query1 += param.idemp.ToString();
                query1 += ", '";
                query1 += param.fechanom;
                query1 += "', '";
                query1 += param.tipo;
                query1 += "', '";
                query1 += param.nom;
                query1 += "', ";
                query1 += param.monto.ToString();
                query1 += ");";


                _instancia.Execute(query1);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public List<listapercep> GetlistPercep()
        {
            string query = "SELECT idemp, fechanom,nom,monto FROM Puesto";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<listapercep> lista = mapper.Fetch<listapercep>(query);

            desconectar();
            return lista.ToList();

        }


        public bool listadeducc(listadeduc param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into listadeduc(idemp,fechanom,tipo, nom, monto) values(";

                query1 += param.idemp.ToString();
                query1 += ", '";
                query1 += param.fechanom;
                query1 += "', '";
                query1 += param.tipo;
                query1 += "', '";
                query1 += param.nom;
                query1 += "', ";
                query1 += param.monto.ToString();
                query1 += ");";


                _instancia.Execute(query1);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }


        public List<listadeduc> GetlistDeduc()
        {
            string query = "SELECT idemp, fechanom,nom,monto FROM Puesto";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<listadeduc> lista2 = mapper.Fetch<listadeduc>(query);

            desconectar();
            return lista2.ToList();

        }
        public void insert_listadeduc(string id, string fecha, string tipo, string nom, string monto)
        {
            try {
                conectar();
                var query1 = "INSERT INTO listadeduc (idemp, fechanom, tipo, nom, monto) values(";
                query1 += id;
                query1 += ",'";
                query1 += fecha;
                query1 += "','";
                query1 += tipo;
                query1 += "','";
                query1 += nom;
                query1 += "','";
                query1 += monto;
                query1 += "');";

                _instancia.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }

        }

        public void insert_listapercepc(Guid id, string fecha, string tipo, string nom, string monto)
        {
            try
            {
                conectar();
                var query1 = "INSERT INTO listapercep (idemp, fechanom, tipo, nom, monto) values(";
                query1 += id.ToString();
                query1 += ",'";
                query1 += fecha;
                query1 += "','";
                query1 += tipo;
                query1 += "','";
                query1 += nom;
                query1 += "','";
                query1 += monto;
                query1 += "');";

                _instancia.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }

        }

        ///RECIBO=====================================================================
        public bool InsertRecibo(RECIBO param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into RECIBO(numemp,nomemple, fechanom, percept, deducc, NumRec,sueldoB, sueldoN, jornada, fechaAlta,depa,puesto,sueldoNletra,RegPat,RFC_emple,RFC_EMP,inicioOp,razon_social,nomEmpresa)";
                query1 = "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}');";
                query1 += "if not exists; ";
                query1 = string.Format(query1, param.numemp, param.nomemple, param.fechanom, param.percept, param.deducc, param.NumRec, param.sueldoB, param.sueldoN, param.jornada, param.fechaAlta, param.depa, param.puesto, param.sueldoNletra, param.RegPat, param.RFC_emple, param.RFC_EMP, param.inicioOp, param.razon_social, param.nomEmpresa);




                _instancia.Execute(query1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }
        public List<RECIBO> Get_All_Recibo() {

            string query = "SELECT numemp,nomemple, fechanom, percept, deducc, NumRec,sueldoB, sueldoN, jornada, fechaAlta,depa,puesto,sueldoNletra,RegPat,RFC_emple,RFC_EMP,inicioOp,razon_social,nomEmpresa FROM RECIBO;";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<RECIBO> recibo = mapper.Fetch<RECIBO>(query);

            desconectar();
            return recibo.ToList();

        }


        ///REPORTE_GEN_NOM=====================================================================
        public bool InsertReporteGenNom(REPORTE_GEN_NOM param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert REPORTE_GEN_NOM(depa, puesto, fechanom, nomemple, edad,salDiario)";
                query1 = "values('{0}','{1}','{2}','{3}','{4}','{5}','{6});";
                query1 += "if not exists; ";
                query1 = string.Format(query1, param.depa, param.puesto, param.fechanom, param.nomemple, param.edad, param.salDiario);

                _instancia.Execute(query1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public List<REPORTE_GEN_NOM> Get_All_REPORTE_GEN_NOM()
        {

            string query = "SELECT depa, puesto, fechanom, nomemple, edad,salDiario FROM REPORTE_GEN_NOM;";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<REPORTE_GEN_NOM> recibo = mapper.Fetch<REPORTE_GEN_NOM>(query);

            desconectar();
            return recibo.ToList();

        }


        ///REPORTE_HEADCOUNTER=====================================================================
        public bool InsertReporte(REPORTE_HEADCOUNTER param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into REPORTE_HEADCOUNTER(depa, puesto, cantEmple, anio,mes, nombreEmp)";
                query1 = "values('{0}','{1}','{2}','{3}','{4}','{5}','{6});";
                query1 += "if not exists; ";
                query1 = string.Format(query1, param.depa, param.puesto, param.cantEmple, param.anio, param.mes, param.nombreEmp);

                _instancia.Execute(query1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public List<REPORTE_HEADCOUNTER> Get_All_REPORTE_HEADCOUNTER()
        {

            string query = "SELECT depa, puesto, cantEmple, anio,mes, nombreEmp FROM REPORTE_HEADCOUNTER;";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<REPORTE_HEADCOUNTER> rehead = mapper.Fetch<REPORTE_HEADCOUNTER>(query);

            desconectar();
            return rehead.ToList();

        }


        ///REPORTE_NOM=====================================================================
        public bool InsertReporte(REPORTE_NOM param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into REPORTE_NOM(sumpercep, sumdeducc, depa, sumSueldoN, sumSueldoB,anio,mes)";
                query1 = "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');";
                query1 += "if not exists; ";
                query1 = string.Format(query1, param.sumpercep, param.sumdeducc, param.depa, param.sumSueldoN, param.sumSueldoB, param.anio, param.mes);
                
             
                _instancia.Execute(query1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }


        public List<REPORTE_NOM> Get_All_REPORTE_NOM()
        {

            string query = "SELECT sumpercep, sumdeducc, depa, sumSueldoN, sumSueldoB,anio,mes FROM REPORTE_NOM; ";
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<REPORTE_NOM> renom = mapper.Fetch<REPORTE_NOM>(query);

            desconectar();
            return renom.ToList();

        }
    public bool InsertEmpresa(Empresa param)
        {
            var Err = false;
            try
            {
                conectar();
                var query1 = "insert into Empresa(razon_social, nombreEmp, domicilioFis,inicioOp, RFC_EMP )";
                query1 = "values('{0}','{1}','{2}','{3}','{4}','{5}');";
                query1 += "if not exists; ";
                query1 = string.Format(query1, param.razon_social, param.nombreEmp + param.domicilioFis, param.inicioOp, param.RFC_EMP);
                _instancia.Execute(query1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Err = true;
                throw ex;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
            
        }
         
        //public List<Datos_de_la_empresa> Get_All_InfoEmpresa()
        //{

        //    string query1 = "SELECT razon_social, nombreEmp, domicilioFis, inicioOp, RFC_EMP; ";
        //    conectar();

        //    IMapper mapper = new Mapper(_instancia);
        //    IEnumerable<REPORTE_NOM> renom = mapper.Fetch<Datos_de_la_empresa>(query1);

        //    desconectar();
        //    return renom.ToList();

        //}
       

    }
}



