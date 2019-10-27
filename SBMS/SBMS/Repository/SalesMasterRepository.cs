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
    class SalesMasterRepository
    {
        SalesMaster SalesMaster = new SalesMaster();
        public bool Add(SalesMaster SalesMaster)
        {
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"INSERT INTO SalesMaster (CustomerID, Date,GrandTotal,Discount,DiscountAmount,PayableAmount) Values ('" + SalesMaster.CustomerID + "', '" 
                                        + SalesMaster.Date + "',"+ SalesMaster.GrandTotal+","+SalesMaster.Discount
                                        +","+SalesMaster.DiscountAmount+","+SalesMaster.PayableAmount+")";
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

        public bool AddDetails(SalesDetial SD)
        {
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"INSERT INTO SalesDetails (Sales_MID,CategoriesID, ProductId,Quantity,MRP,TotalMRP)Values("+SD.Sales_MID+","+ SD.CategoriesID+","+ SD.ProductId+","+ SD.Quantity+","+ SD.MRP+","+ SD.TotalMRP + ")";
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
        public DataTable LoadQuantityNMrp(int ProductID)
        {
            try
            {
                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"select * from vwStockNPrice where ProductID= "+ ProductID;
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
        public DataTable FindSalesMID()
        {
            try
            {
                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"select Sales_MID=max(Sales_MID) from SalesMaster";
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

        public DataTable SearchData(string SalesCode)
        {
            try
            {
                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"select sm.SalesCode,sm.CustomerID,sm.Date,sm.GrandTotal,sm.DiscountAmount,sm.PayableAmount,sd.CategoriesID,sd.ProductId,sd.Quantity,sd.MRP,sd.TotalMRP
                                       from SalesMaster  sm inner join SalesDetails  sd on sm.Sales_MID=sd.Sales_MID
                                       where sm.Sales_MID=(select Sales_MID from SalesMaster where SalesCode='"+SalesCode+"')";
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
