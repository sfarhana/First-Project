using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SBMS.Model;


namespace SBMS.Repository
{
    class PurhaseMasterRepository
    {
        Purchase_Master purchase_Master = new Purchase_Master();
        public bool Add(Purchase_Master purchase_Master)
        {
            bool isAdded = false;
            try
            {

                string connectionString = @"Server=FARHANAMOSTO-PC; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);



                string commandString = @"INSERT INTO PurchaseMaster (SupplierId, BillNo, Date,Remarks,MRP) Values ('" + purchase_Master.SupplierId + "', '" + purchase_Master.BillNo + "', '" + purchase_Master.Date + "', '" + purchase_Master.Remarks + "','" + purchase_Master.MRP + "')";
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

            }

            return isAdded;
        }

    }
}
