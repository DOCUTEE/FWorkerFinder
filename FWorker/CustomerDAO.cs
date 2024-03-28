using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Data.SqlClient;
using System.Data;
namespace FWorker
{
    internal class CustomerDAO : UserDAO
    {
        public CustomerDAO(): base("CUSTOMER") { }
        public override void Add(User user)
        {
            string sqlStr;
            Customer customer = (Customer)user;

            while (true)
            {
                sqlStr = string.Format("INSERT INTO {0} (id, name, gender, birth, phoneNumber, address, email ,citizenID)" +
                    " VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                    this.tableName, customer.Id, customer.Name, customer.Gender, customer.Birth, customer.PhoneNumber, customer.Address, customer.Email, customer.CitizenID);
                bool flag = customer.ValidateData();
                if (!flag)
                {
                    MessageBox.Show("Add to become worker Failed\n");
                    return;
                }
                else
                    break;
            }

            dbConn.CommandExecute(sqlStr);
        }

        public override void Edit(User user)
        {
            string sqlStr;
            Customer customer = (Customer)user;

            while (true)
            {
                sqlStr = string.Format("UPDATE {0} SET name ='{1}', gender = '{2}', birth ='{3}', phoneNumber ='{4}', address '{5}', email ='{6}',citizenID ='{7}', rating ='{8}', WHERE id = '{9}'" +
                    this.tableName, customer.Name, customer.Gender, customer.Birth, customer.PhoneNumber, customer.Address, customer.Email, customer.CitizenID, customer.Id);
                bool flag = customer.ValidateData();
                if (!flag)
                {
                    MessageBox.Show("update failed");
                    return;
                }
                else
                    break;
            }
            dbConn.CommandExecute(sqlStr);
        }

        public Customer GetCustomer(string id)
        {
            Customer customer = null;
            string sqlQuery = "SELECT * FROM CUSTOMER WHERE id=@id";

            SqlParameter paramId = new SqlParameter("@id", id);

            SqlDataReader reader = dbConn.GetReader1(sqlQuery, paramId);

            if (reader != null && reader.Read())
            {
                customer = new Customer(
                id: reader.GetString(0),
                name: reader.GetString(1),
                gender: reader.GetString(2),
                birth: reader.GetDateTime(3),
                phoneNumber: reader.GetString(4),
                address: reader.GetString(5),
                email: reader.GetString(6),
                citizenID: reader.GetString(7),
                logo: reader.GetString(8)
                );
            }
            else
                MessageBox.Show("Không tìm thấy khách hàng có ID: " + id);
            return customer;
        }
    }
}
