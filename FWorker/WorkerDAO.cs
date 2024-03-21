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


        public List<Worker> GetWorkerListService(string service, int quantity)
        {

            List<Worker> workers = new List<Worker>();

            
            string sqlQuery = $"SELECT TOP {quantity} * FROM WORKERS WHERE field = service";
            dbConn.CommandExecute(sqlQuery);
            SqlParameter parameter = new SqlParameter();

            SqlDataReader reader = dbConn.GetReader(sqlQuery, parameter);
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
            return workers;
        }
        public List<Worker> GetWorkerList(int quantity)
        {
            List<Worker> workers = new List<Worker>();
            string sqlQuery = $"SELECT TOP {quantity} * FROM WORKERS";
            dbConn.CommandExecute(sqlQuery);
            SqlParameter parameter = new SqlParameter();

            SqlDataReader reader = dbConn.GetReader(sqlQuery, parameter);         
            
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

            return workers;
        }



        public Worker GetWorker(string iddd)
        {
            Worker worker;
            
            string sqlQuery = "SELECT * FROM WORKERS WHERE id=@id";
            SqlParameter paramId = new SqlParameter("@id", iddd);

            SqlDataReader reader = dbConn.GetReader(sqlQuery, paramId);


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
                        
                
            
            return worker;
        }

        public List<string> GetFieldValues(string fieldName, int quantity)
        {
            List<string> fieldValues = new List<string>();


            string sqlQuery = $"SELECT TOP {quantity} [{fieldName}] FROM WORKERS";

            dbConn.CommandExecute(sqlQuery);
            SqlParameter parameter = new SqlParameter();

            SqlDataReader reader = dbConn.GetReader(sqlQuery, parameter);

            while (reader.Read())
            {
                string fieldValue = reader.GetString(0);
                fieldValues.Add(fieldValue);
            }

            reader.Close();
            

            return fieldValues;
        }


    }
}
