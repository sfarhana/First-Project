using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;
using System.Data.SqlClient;
using System.Data;

namespace SBMS.Repository
{
    class PurchaseDetialsRepository
    {
        PurchaseDetials purchaseDetials = new PurchaseDetials();
        public List<Customer> Search(Customer customer)
        {
            List<Customer> Customers = new List<Customer>();

            try
            {
                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT * FROM Customers WHERE CustomerName='" + customer.CustomerName + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();



                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {

                    Customer custome = new Customer();
                    custome.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    custome.Code = sqlDataReader["Code"].ToString();
                    custome.CustomerName = sqlDataReader["CustomerName"].ToString();
                    custome.Address = sqlDataReader["Address"].ToString();
                    custome.Email = sqlDataReader["Email"].ToString();
                    custome.Contact = sqlDataReader["Contact"].ToString();
                    custome.LoyaltyPoint = Convert.ToDouble(sqlDataReader["LoyaltyPoint"]);

                    Customers.Add(custome);
                }

                sqlConnection.Close();




            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Customers;
        }
    }
}
