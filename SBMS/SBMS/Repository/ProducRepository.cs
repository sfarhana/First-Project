﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SBMS.Model;

namespace SBMS.Repository
{
    class ProducRepository
    {
        public bool Add(Product product)
        {
            bool isAdded = false;
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"INSERT INTO Products (Code, ProductName, ReorderLevel, Description, CategoryId) Values ('" + product .Code + "','" + product.ProductName + "','" +  product.ReorderLevel + "','" + product.Description + "', '" + product.CategoryId + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return isAdded;
        }

       

        public DataTable Dispaly()
        {
            string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT p.Id, p.Code, p.ProductName , p.ReorderLevel, p.Description,p.CategoryId, c.CategoryName FROM Products as p
                                     JOIN Categories as c ON c.Id=p.CategoryId";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();
            return dataTable;


        }

        public bool Update(Product product)
        {
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                string commandString = @"UPDATE Products SET Code = '"+product.Code+"', ProductName = '"+product.ProductName+"', ReorderLevel = "+product.ReorderLevel+",  Description = '"+product.Description+"', CategoryId ="+product.CategoryId+"  WHERE Id = "+product.Id+"";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();


                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }

                sqlConnection.Close();


            }
            catch (Exception exeption)
            {

            }
            return false;
        }

        public DataTable Search(Product product)
        {
            DataTable dataTable = new DataTable();
            try
            {
              
                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                
                string commandString = @"SELECT p.Id, p.Code, p.ProductName , p.ReorderLevel, p.Description,p.CategoryId, c.CategoryName FROM Products as p
                                     JOIN Categories as c ON c.Id=p.CategoryId WHERE ProductName='" + product.ProductName+ "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

              
                sqlConnection.Open();

             
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
                 
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                 
            }
            return dataTable;
        }

        public bool IsNameExist(Product product)

        {
            bool isExist = false;
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                string commandString = @"SELECT * FROM Products WHERE Code='" + product.Code + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();


                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    isExist = true;
                }


                sqlConnection.Close();

            }
            catch (Exception exeption)
            {

            }
            return isExist;
        }

        public bool IsCodeExist(Product product)

        {
            bool isExist = false;
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                string commandString = @"SELECT Id FROM Products WHERE Code='" + product.Code + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                sqlConnection.Open();


                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    int codewiseID = 0;
                    codewiseID = Int32.Parse(dataTable.Rows[0]["Id"].ToString());
                    if (product.Id != codewiseID)
                    {
                        isExist = true;
                    }
                }


                sqlConnection.Close();

            }
            catch (Exception exeption)
            {

            }
            return isExist;
        }
        public DataTable FindReorderLevel(int productid)
        {
            try
            {
                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"select ReorderLevel from Products where Id=" + productid;
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

    }
}

