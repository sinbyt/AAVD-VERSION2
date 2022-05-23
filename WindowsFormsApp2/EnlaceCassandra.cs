﻿using System;
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

            _instancia = _cluster.Connect("keyspace3");
        }

        private static void desconectar()
        {
            _cluster.Dispose();
        }

        //public bool InsertEmpleados(Empleados param);

        public bool InsertEmpleado(Empleado param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();
                //var fecha = param.fechaAlta.ToString("yyyy-MM-dd");
                var ID_Empleado = new Guid();
                ID_Empleado = Guid.NewGuid();

                var query = "INICIO NUEVO EMPLEADO";
                var query1 = "insert into users(id, nom, F_Alta, edad, depa, puesto, F_Nacimiento, CURP, NSS, RFC, domicilio, banco, cuenta, telefono, email) values({0}, '{1}', '{2}', '{3}''{4}', '{5}', '{6}''{7}', '{8}', '{9}''{10}', '{11}', '{12}''{13}', '{14}', '{15}'); ";
                query1 = string.Format(query1, ID_Empleado, param.nombre + param.apellidos, param.fechaAlta, param.edad, param.depa, param.puesto, param.fechaNacimiento, param.CURP, param.NSS, param.RFC, param.domicilio, param.banco, param.numCuenta, param.telefono, param.email);
                var query2 = "insert into users2(id, name, email) values({0}, '{1}', '{2}'); ";
                //query2 = string.Format(query2, ID_Empleado, param.name, param.email);
                query = query + query1 + query2 + " APPLY BATCH;";


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

        //public List<Empleado>

    
    }
}

        //DESDE AQUI EMPIEZA LO DEL PROFE
        /*
        public bool InsertUsers(Empleado param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();
                var fecha = param.f_nac.ToString("yyyy-MM-dd");
                var id = new Guid();
                id = Guid.NewGuid();

                var query = "BEGIN BATCH ";
                var query1 = "insert into users(id, name, email, f_nac) values({0}, '{1}', '{2}', '{3}'); ";
                query1 = string.Format(query1, id, param.name, param.email, fecha);
                var query2 = "insert into users2(id, name, email) values({0}, '{1}', '{2}'); ";
                query2 = string.Format(query2, id, param.name, param.email);
                query = query + query1 + query2 + " APPLY BATCH;";

                _instancia.Execute(query);
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

        public bool InsertClientes(clientes param)
        {
            var Err = false; // SI no hay error
            try
            {
                conectar();

                var query1 = "insert into clientes(user_id, first_name, last_name) values('{0}', '{1}', '{2}'); ";
                query1 = string.Format(query1, param.user_id, param.first_name, param.last_name);

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

        public bool UpdateClientes(clientes param, int accion)
        {
            var Err = false; // SI no hay error
            var oper = "+";
            if(accion == 0) { oper = "-"; }
            try
            {
                conectar();
                
                var query1 = "update clientes ";
                query1 += "set ";
                if (accion == 1)
                {
                    query1 += "    first_name = '{1}', ";
                    query1 += "    last_name = '{2}', ";
                }
                query1 += "    emails = emails " + oper +" ['{3}'] ";
                query1 += " where user_id =  '{0}' ";
                query1 += " IF EXISTS; ";
                query1 = string.Format(query1, param.user_id, param.first_name, param.last_name, param.emails);

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

        public List<clientes1> Get_Clientes(string user_id)
        {
            string query = "select user_id, first_name, last_name, emails ";
            query += "from clientes ";
            query += "where user_id = '{0}'; ";
            query = string.Format(query, user_id);
            conectar();

            IMapper mapper = new Mapper(_instancia);
            IEnumerable<clientes1> ctes = mapper.Fetch<clientes1>(query);

            desconectar();
            return ctes.ToList();

        }

        public void InsertaDatos(int id, string dato)
        {
            try
            {
                conectar();
                
                string qry = "insert into ejemplo(campo1, campo2) values(";
                qry = qry + id.ToString();
                qry = qry + ",'";
                qry = qry + dato;
                qry = qry + "');";


                string query = "insert into ejemplo(campo1, campo2) values({0}, '{1}');";
                qry = string.Format(query, id, dato);

                _instancia.Execute(qry);
            }
            catch(Exception e)
            {
                throw e;   
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();
            }
        }

        public IEnumerable<Ejemplo> Get_One(int dato)
        {
            string query = "SELECT campo1, campo2 FROM ejemplo WHERE campo1 = ?;";
            conectar();
            IMapper mapper = new Mapper(_instancia);
            IEnumerable<Ejemplo> users = mapper.Fetch<Ejemplo>(query, dato);

            desconectar();
            return users.ToList();
        }

        public List<Ejemplo> Get_All()
        {
            string query = "SELECT campo1, campo2 FROM ejemplo;";
            conectar();
            
            IMapper mapper = new Mapper(_instancia);
            IEnumerable<Ejemplo> users = mapper.Fetch<Ejemplo>(query);

            desconectar();
            return users.ToList();
            
        }

        // Ejemplo de leer row x row
        public void GetOne()
        {
            conectar();

            string query = "SELECT name, email FROM users;";

            // Execute a query on a connection synchronously 
            var rs = _instancia.Execute(query);
            
            // Iterate through the RowSet 
            foreach (var row in rs)
            {
                var value = row.GetValue<string>("name");
                // Do something with the value 
                var texto = row.GetValue<string>("email");
                // Do something with the value 

                MessageBox.Show(texto, value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                /*
                RowSet rsUsers = session.Execute(qry);

                ////////////////////////////////////////////////
                var users = new List<UserModel>();
                foreach (var userRow in rsUsers)
                {
                    //users.Add(ReflectionTools.GetSingleEntryDynamicFromReader<UserModel>(userRow));
                }

                foreach (UserModel user in users)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", user.Id, user.FirstName, user.LastName, user.Country, user.IsActive);
                }
                //AQUI TERMINA EL OTRO COMENTARIO (15 LINEAS ARRIBA)

            }
        }

    }
}
*/
