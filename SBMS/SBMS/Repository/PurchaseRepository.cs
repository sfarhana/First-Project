using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using SBMS.Model;

namespace SBMS.Repository
{
    class PurchaseRepository
    {
        public bool Add(Purchase purchase)
        {
            bool isAdded = false;
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"INSERT INTO Purchases (Date, Bill_No, Manufacture_Date, Expire_Date, Quantity, Unite_Price, Total_Price, Previous_Cost_Price, Previous_Mrp, New_Mrp,Remarks,ProductId, SupplierId )
                                      Values ('" + purchase.Date + "','" + purchase.Bill_No + "','" + purchase.Manufacture_Date + "','" + purchase.Expire_Date + "', '" + purchase.Quantity + "', '" +
                                      purchase.Unite_Price + "','" + purchase.Total_Price + "','" + purchase.Previous_Cost_Price + "','" + purchase.Previous_Mrp + "','" + purchase.New_Mrp + "','" +
                                      purchase.Remarks + "'," + purchase.ProductId + "," + purchase.SupplierId + ")";
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
                //exeption.Message("sss")
            }

            return isAdded;
        }

        public DataTable Dispaly()
        {
            string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT p.Id, p.Expire_Date, p.Unite_Price , p.Total_Price, p.Previous_Cost_Price,p.Previous_Mrp, p.New_Mrp, p.Remarks, p.Code,p.ProductId,p.SupplierId,pr.ProductName,s.SupplierName FROM Purchases as p
                                     JOIN Products as pr ON pr.Id=p.ProductId JOIN Suppliers as s ON s.Id=p.SupplierId";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();
            return dataTable;


        }

        public DataTable CatagoryWiseProductDisplay(Category category)
        {
            string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"select Id,ProductName from Products where CategoryId="+category.Id+"";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();
            return dataTable;


        }

        public DataTable ProductWiseProductDisplay(Product product)
        {
            string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"select b.Code, a.Quantity, Unite_Price = (Select UnitPrice from PurchaseDetials where Pur_DID=(Select max(Pur_DID) from PurchaseDetials where ProductId =" + product.Id + ")), Previous_Mrp=(Select PreviousMrp from PurchaseDetials where Pur_DID=(Select max(Pur_DID) from PurchaseDetials where ProductId= " + product.Id + "))into #temp from PurchaseDetials a  join Products b on a.ProductId=b.Id where a.ProductId= " + product.Id + " (select Code,sum(Quantity)Quantity ,Unite_Price,Previous_Mrp from #temp group by Code,Unite_Price,Previous_Mrp) drop table #temp";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();
            return dataTable;


        }

     
        public DataTable Search(Purchase purchase)
        {
            DataTable dataTable = new DataTable();
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);


                string commandString = @"SELECT * FROM Purchases WHERE Code ='"+purchase.Code+"'";
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
    }
}
