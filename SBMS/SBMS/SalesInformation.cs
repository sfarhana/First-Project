using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;
using SBMS.BLL;
using System.Windows.Forms;

namespace SBMS
{
    public partial class SalesInformation : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        ProductManager _productManager = new ProductManager();
        CategoryManager _categoryManager = new CategoryManager();
        PurchaseManager _purchaseManager = new PurchaseManager();
        SalesMasterManager _SalesMasterManager = new SalesMasterManager();
        Category category = new Category();
        SalesMaster SalesMaster = new SalesMaster();

        double CustLoyaltyPoint;
        int Sales_DID = 1;
        int UpdateId = 0;
        int ReorderLevel=0;
        List<SalesDetial> listSalesDetials = new List<SalesDetial>();
        public SalesInformation()
        {
            InitializeComponent();
        }
        
        
        private void SalesInformation_Load(object sender, EventArgs e)
        {
            AllComboLoad();


        }
        public void AllComboLoad()
        {
            customerComboBox.DataSource = _customerManager.Dispaly();
            customerComboBox.DisplayMember = "CustomerName";
            customerComboBox.ValueMember = "Id";
            customerComboBox.Text = "--Select Customer Name--";


            productComboBox.DataSource = _productManager.Display();
            productComboBox.DisplayMember = "ProductName";
            productComboBox.ValueMember = "Id";
            productComboBox.Text = "--Select Product Name--";

            categoryComboBox.DataSource = _categoryManager.Display();
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.Text = "--Select Category Name--";
        }

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedItem.ToString() == "-Select Category Name-")
            {
                MessageBox.Show("Please Select Category Name");
                return;
            }
            category.Id = Int32.Parse(categoryComboBox.SelectedValue.ToString());

            productComboBox.DataSource = _purchaseManager.CatagoryWiseProductDisplay(category);
            productComboBox.DisplayMember = "ProductName";
            productComboBox.ValueMember = "Id";
            productComboBox.Text = "--Select Product Name--";
        }

        private void productComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
               
                int availableQuantity=0;
                int ProductID = Convert.ToInt32(productComboBox.SelectedValue);
                DataTable dtqnt = _SalesMasterManager.LoadQuantityNMrp(ProductID);
                if (dtqnt != null)
                {
                    DataRow row = dtqnt.Rows[0];
                    availableQuantity= Convert.ToInt16(row["AvailableQuantity"].ToString());
                    availableQuantityTextBox.Text = availableQuantity.ToString();
                    mrpTextBox.Text = row["TotalMRP"].ToString();
                }

                DataTable dtreorder = _productManager.FindReorderLevel(ProductID);
                if (dtreorder != null)
                {
                    DataRow row = dtreorder.Rows[0];
                    ReorderLevel = Convert.ToInt16(row["ReorderLevel"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
            
        }

        private void customerComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int CustomerId = Convert.ToInt32(customerComboBox.SelectedValue);
            DataTable dt = _customerManager.FindLoyaltyPoint(CustomerId);
            if (dt != null)
            {
                DataRow row = dt.Rows[0];
                CustLoyaltyPoint= Convert.ToDouble(row["LoyaltyPoint"].ToString());
                loyalityPointTextBox.Text = CustLoyaltyPoint.ToString();
            }

        }
        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(quantityTextBox.Text))
            {
                int Qnt = Convert.ToInt16(quantityTextBox.Text);
                double mrp = Convert.ToInt16(mrpTextBox.Text);
                double totalmrp = Qnt * mrp;
                toatlMrpTextBox.Text = totalmrp.ToString();

                int availqnt = Convert.ToInt16(availableQuantityTextBox.Text);
                availqnt = availqnt - Convert.ToInt32(quantityTextBox.Text);

                if (availqnt < ReorderLevel)
                {

                    MessageBox.Show("Available Quantity goes below the reorder level");
                }
                
            }

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddButton.Text == "Add")
            {

                AddInfo();
               
            }

            else
            {
              UpdateInfo();
            }
        }
        public void AddInfo()
        {
            try
            {
                int availqnt = Convert.ToInt16(availableQuantityTextBox.Text);
                availqnt = availqnt - Convert.ToInt32(quantityTextBox.Text);

                if (availqnt < ReorderLevel)
                {
                    MessageBox.Show("Available Quantity goes below the reorder level,Item can not be added");
                    return;
                }
               

                SalesDetial SalesDetial = new SalesDetial();

                SalesDetial.Sales_DID = Sales_DID++;
                SalesDetial.CategoriesID = Convert.ToInt32(categoryComboBox.SelectedValue);
                SalesDetial.ProductId = Convert.ToInt32(productComboBox.SelectedValue);
                SalesDetial.Quantity = Convert.ToInt32(quantityTextBox.Text);
                SalesDetial.MRP = float.Parse(mrpTextBox.Text);
                SalesDetial.TotalMRP = float.Parse(toatlMrpTextBox.Text);

                listSalesDetials.Add(SalesDetial);

                salesdDtaGridView.DataSource = null;
                salesdDtaGridView.DataSource = listSalesDetials;



                double GrandTotal = listSalesDetials.Sum(x => x.TotalMRP);
                grandTotalTextBox.Text = GrandTotal.ToString();

                double LoyaltyPoint = Convert.ToDouble(loyalityPointTextBox.Text);

                double Discount = LoyaltyPoint / 10;
                discountTextBox.Text = Discount.ToString();

                double DiscountAmount = GrandTotal * (Discount / 100);
                discountAmountTextBox.Text = DiscountAmount.ToString();

                double PayableAmount = GrandTotal - DiscountAmount;
                payableAmountTextBox.Text = PayableAmount.ToString();

                CustLoyaltyPoint = LoyaltyPoint - (LoyaltyPoint / 10);
                CustLoyaltyPoint = CustLoyaltyPoint + (GrandTotal / 1000);

                categoryComboBox.Text = "-Select Category Name-";
                productComboBox.Text = "-Select Product Name-";
                availableQuantityTextBox.Text = "";
                quantityTextBox.Text = "";
                mrpTextBox.Text = "";
                toatlMrpTextBox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        public void UpdateInfo()
        {
            SalesDetial supdate = new SalesDetial();

            supdate.Sales_DID = UpdateId;
            supdate.CategoriesID = int.Parse(categoryComboBox.SelectedValue.ToString());
            supdate.ProductId= int.Parse(productComboBox.SelectedValue.ToString());
            supdate.Quantity = Convert.ToInt16(quantityTextBox.Text);
            supdate.MRP = Convert.ToInt16(mrpTextBox.Text);
            supdate.TotalMRP = Convert.ToInt16(toatlMrpTextBox.Text);

            SalesDetial sdelete = new SalesDetial();
            sdelete = listSalesDetials.Where(x => x.Sales_DID == UpdateId).FirstOrDefault();
            listSalesDetials.Remove(sdelete);

            listSalesDetials.Add(supdate);
            salesdDtaGridView.DataSource = null;
            salesdDtaGridView.DataSource = listSalesDetials;

            AddButton.Text = "Add";

        }

        private void salesdDtaGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow row = salesdDtaGridView.Rows[index];

            categoryComboBox.SelectedValue = int.Parse(row.Cells["CategoriesID"].Value.ToString());
            productComboBox.SelectedValue = int.Parse(row.Cells["ProductId"].Value.ToString());
            quantityTextBox.Text = row.Cells["Quantity"].Value.ToString();
            mrpTextBox.Text = row.Cells["MRP"].Value.ToString();
            toatlMrpTextBox.Text = row.Cells["TotalMRP"].Value.ToString();

            UpdateId = int.Parse(row.Cells["Sales_DID"].Value.ToString());

            AddButton.Text = "Update";

        }
        private void submiitButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isExecutedDetails=false;
                bool isExecutedMaster = false;
                int Sales_MID = 0;

                SalesMaster.CustomerID = Convert.ToInt32(customerComboBox.SelectedValue);
                SalesMaster.Date = dateTextBox.Text;
                SalesMaster.GrandTotal = float.Parse(grandTotalTextBox.Text);
                SalesMaster.Discount = float.Parse(discountTextBox.Text);
                SalesMaster.DiscountAmount = float.Parse(discountAmountTextBox.Text);
                SalesMaster.PayableAmount = float.Parse(payableAmountTextBox.Text);

                isExecutedMaster = _SalesMasterManager.Add(SalesMaster);

               DataTable dt=_SalesMasterManager.FindSalesMID();
                if (dt != null)
                {
                    DataRow row = dt.Rows[0];
                    Sales_MID = Convert.ToInt16(row["Sales_MID"].ToString());
                }

                foreach (SalesDetial SD in listSalesDetials)
                {
                    SD.Sales_MID = Sales_MID;
                    isExecutedDetails = _SalesMasterManager.AddDetails(SD);
                }

                if(isExecutedDetails==true && isExecutedMaster==true) 
                {
                    MessageBox.Show("Sales Data Saved Successfully");
                   
                }

                bool isUpdateLoyaltyPoint = _customerManager.UpdateLoyaltyPoint(Convert.ToInt32(customerComboBox.SelectedValue), CustLoyaltyPoint);
                if (isUpdateLoyaltyPoint)
                {
                    MessageBox.Show("Loyalty Point reset Successfully");
                }
                ClearAfterSubmit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                string SalesCode = searchTextBox.Text;
                DataTable dt = _SalesMasterManager.SearchData(SalesCode);
                if (dt != null)
                {
                    salesdDtaGridView.DataSource = dt;
                }
                else
                    MessageBox.Show("Data not Found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        public void ClearAfterSubmit()
        {
            dateTextBox.Text ="";
            loyalityPointTextBox.Text ="";
            customerComboBox.Text = "-Select Customer Name-";
            categoryComboBox.Text= "-Select Category Name-";
            productComboBox.Text = "-Select Product Name-";
            availableQuantityTextBox.Text ="";
            quantityTextBox.Text ="";
            mrpTextBox.Text ="";
            toatlMrpTextBox.Text ="";
            salesdDtaGridView.DataSource = null;
            grandTotalTextBox.Text ="";
            discountTextBox.Text ="";
            discountAmountTextBox.Text ="";
            payableAmountTextBox.Text ="";
        }

     
    }
}
