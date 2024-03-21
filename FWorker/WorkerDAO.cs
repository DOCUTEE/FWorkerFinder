using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Data.SqlClient;
using System.Data;
namespace FWorker
{
    internal class WorkerDAO : UserDAO
    {
        public WorkerDAO(string tableName) : base(tableName) { }

        public override void Add(string tableName, User user )
        {
            string sqlStr;
            Worker worker = (Worker)user;
         
            while (true)
            {
                sqlStr = string.Format("INSERT INTO {0} (id, name, gender, birth, phoneNumber, address, email ,citizenID, logo, rating, description, qualifications, field, pricePerHour)" +
                    " VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}', '{11}','{12}','{13}','{14}')",
                    tableName, worker.Id, worker.Name, worker.Gender, worker.Birth, worker.PhoneNumber,  worker.Address, worker.Email, worker.CitizenID,
                    worker.Rating, worker.Description, worker.Qualifications, worker.Field, worker.PricePerHour);
                bool flag = worker.ValidateData();
                if (!flag)
                {
                    MessageBox.Show("Sign Up Failed\n");
                    return;
                }
                else
                    break;
            }
           
            dbConn.AdapterExecute(sqlStr, "Sign Up Success");

        }

        public override void Edit(string tableName, User user)
        {
            string sqlStr;
            Worker worker = (Worker)user;

            while (true)
            {
                sqlStr = string.Format("UPDATE {0} SET name ='{1}', gender = '{2}', birth ='{3}', phoneNumber ='{4}', address '{5}', email ='{6}',citizenID ='{7}', logo ='{8}', rating ='{9}', description ='{10}', qualifications ='{11}', field ='{12}', pricePerHour = '{13}' WHERE id = '{14}'" +
                    tableName, worker.Name, worker.Gender, worker.Birth, worker.PhoneNumber, worker.Address, worker.Email, worker.CitizenID,
                    worker.Rating, worker.Description, worker.Qualifications, worker.Field, worker.PricePerHour, worker.Id);
                bool flag = worker.ValidateData();
                if (!flag)
                {
                    MessageBox.Show("update failed");
                    return;
                }
                else
                    break;
            }
            dbConn .AdapterExecute(sqlStr, "Update successful");
        }

        public DataTable Load()
        {
            string sqlStr = "WORKERS";
            return dbConn.LoadData(sqlStr);
        }
        public List<Worker> GetWorkerList(int quantity)
        {
            List<Worker> workers = new List<Worker>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connStr))
            {
                connection.Open();
                string sqlQuery = $"SELECT TOP {quantity} * FROM WORKERS";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Worker worker = new Worker(
                                id: reader.GetString(0),
                                name: reader.GetString(1),
                                gender: reader.GetString(2),
                                birth: reader.GetDateTime(3),
                                phoneNumber: reader.GetString(4),
                                address: reader.GetString(5),
                                email: reader.GetString(6),
                                citizenID: reader.GetString(7),
                                logo: reader.GetString(8),
                                rating: reader.GetDouble(9),
                                description: reader.GetString(10),
                                qualifications: reader.GetString(11),
                                field: reader.GetString(12),
                                pricePerHour: reader.GetDouble(13)
                            );

                            workers.Add(worker);
                        }
                    }
                }
            }

            return workers;
        }


        public Worker GetWorker(string id)
        {
            Worker worker;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connStr))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WORKERS WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                      
                        worker = new Worker(
                            id: reader.GetString(0),
                            name: reader.GetString(1),
                            gender: reader.GetString(2),
                            birth: reader.GetDateTime(3),
                            phoneNumber: reader.GetString(4),
                            address: reader.GetString(5),
                            email: reader.GetString(6),
                            citizenID: reader.GetString(7),
                            logo: reader.GetString(8),
                            rating: reader.GetDouble(9),
                            description: reader.GetString(10),
                            qualifications: reader.GetString(11),
                            field: reader.GetString(12),
                            pricePerHour: reader.GetDouble(13));
                        
                    }
                }
            }
            return worker;
        }


    }
}
