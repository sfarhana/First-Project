﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;

namespace SBMS.Repository
{
    class CustomerRepository
    {
        Customer customer = new Customer();
        public bool Add(Customer customer)
        {
            bool isAdded = false;
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"INSERT INTO Customers (Code, CustomerName, Address,Email,Contact,LoyaltyPoint) Values ('" + customer.Code + "', '" + customer.CustomerName+ "', '" + customer.Address + "', '" + customer.Email + "','" + customer.Contact+ "', " + customer.LoyaltyPoint+ ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                sqlConnection.Close();
            }
            catch
            {
                throw;
            }

            return isAdded;
        }

        public List<Customer> Dispaly()
        {
            List<Customer> Customers = new List<Customer>();

            try
            {
                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT * FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();



                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {

                    Customer customer = new Customer();
                    customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    customer.Code = sqlDataReader["Code"].ToString();
                    customer.CustomerName = sqlDataReader["CustomerName"].ToString();
                    customer.Address = sqlDataReader["Address"].ToString();
                    customer.Email = sqlDataReader["Email"].ToString();
                    customer.Contact = sqlDataReader["Contact"].ToString();
                    customer.LoyaltyPoint = Convert.ToDouble(sqlDataReader["LoyaltyPoint"]);

                    Customers.Add(customer);
                }

                sqlConnection.Close();

            }
            catch
            {
                throw;
            }
            return Customers;
        }

        public List<Customer> Search(Customer customer)
        {
            List<Customer> Customers = new List<Customer>();

            try
            {
                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string commandString = @"SELECT * FROM Customers WHERE CustomerName='"+customer.CustomerName+"'";
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
            catch
            {
                throw;
            }
            return Customers;
        }

        public bool Update(Customer customer)
        {
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                string commandString = @"UPDATE Customers SET Code ='" + customer.Code + "', CustomerName = '" + customer.CustomerName + "',  Address ='" + customer.Address + "', Email = '" + customer.Email + "', Contact ='" + customer.Contact + "', LoyaltyPoint = " + customer.LoyaltyPoint + "  WHERE Id = " + customer.Id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();


                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }

                sqlConnection.Close();


            }
            catch
            {
                throw;
            }
            return false;
        }

        public DataTable FindLoyaltyPoint(int CustomerId)
        {
            try
            {
                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"select LoyaltyPoint from Customers where Id="+ CustomerId;
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    return dataTable;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw;
            }
        }
        public bool UpdateLoyaltyPoint(int CustomerId, double CustLoyaltyPoint)
        {
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                string commandString = @"UPDATE Customers SET LoyaltyPoint="+ CustLoyaltyPoint+ "where Id="+ CustomerId;
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if (isExecuted > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                throw;
            }
          
        }
    }
}
