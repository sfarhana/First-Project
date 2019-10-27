using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.Model;
using SBMS.BLL;

namespace SBMS
{
    public partial class PurchaseInformation : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        CategoryManager _categoryManager = new CategoryManager();
        ProductManager _productManager = new ProductManager();
        PurchaseManager _purchaseManager = new PurchaseManager();
        PurchaseMasterManager purchaseMasterManager = new PurchaseMasterManager();
        Purchase purchase = new Purchase();
        Category category = new Category();
        Product product = new Product();
        Purchase_Master purchase_Master = new Purchase_Master();
        PurchaseDetials purchaseDetials = new PurchaseDetials();
        
        public PurchaseInformation()
        {
            InitializeComponent();
        }

        //private void addButton_Click(object sender, EventArgs e)
        //{



        //    purchase.Date = dateTextBox.Text;
        //    purchase.Bill_No = billNoTextBox.Text;
        //    purchase.Manufacture_Date = manufactureDateTextBox.Text;
        //    purchase.Expire_Date = expireDateTextBox.Text;
        //    purchase.Quantity = Convert.ToInt32(quantityTextBox.Text);
        //    purchase.Unite_Price = float.Parse(unitPriceTextBox.Text);
        //    purchase.Total_Price = float.Parse(totalPriceTextBox.Text);
        //    purchase.Previous_Cost_Price = float.Parse(preUnitPriceTextBox.Text);
        //    purchase.Previous_Mrp = float.Parse(previousMrtTextBox.Text);
        //    purchase.New_Mrp = float.Parse(mrtTtextBox.Text);
        //    purchase.Remarks = remarksTextBox.Text;
        //    purchase.Code = codeTextBox.Text;
        //    purchase.Id = Convert.ToInt32(purchaseIdTextBox.Text);
        //    purchase.SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue);
        //    purchase.ProductId = Convert.ToInt32(productComboBox.SelectedValue);






        //    if (addButton.Text == "Add")
        //    {

        //        if (_purchaseManager.Add(purchase))
        //        {


        //            if (_purchaseManager.Addother(purchase))
        //            { }
        //            MessageBox.Show("added");
        //            purchaseDataGridView.DataSource = _purchaseManager.Display();
        //            Clear();
        //        }
        //    }
        //    else
        //    {


        //        product.Id = Convert.ToInt32(idTextBox.Text);
        //        if (_productManager.Update(product))
        //        {
        //            MessageBox.Show("Update");
        //            productDataGridView.DataSource = _productManager.Display();
        //            clear();

        //        }
        //    }

        //}

        private void PurchaseInformation_Load(object sender, EventArgs e)
        {
            AllComboLoad();
            purchaseDataGridView.DataSource = _purchaseManager.Display();



        }
        public void AllComboLoad()
        {
            supplierComboBox.DataSource = _supplierManager.Dispaly();
            supplierComboBox.DisplayMember = "SupplierName";
            supplierComboBox.ValueMember = "Id";
            supplierComboBox.Text = "--Select Suplier Name--";

            CategoryComboBox.DataSource = _categoryManager.Display();
            CategoryComboBox.DisplayMember = "CategoryName";
            CategoryComboBox.ValueMember = "Id";
            CategoryComboBox.Text = "--Select Category Name--";

            productComboBox.DataSource = _productManager.Display();
            productComboBox.DisplayMember = "ProductName";
            productComboBox.ValueMember = "Id";
            productComboBox.Text = "--Select Product Name--";
        }
        public void Clear()
        {
            purchaseIdTextBox.Text = "";
            remarksTextBox.Text="";
            mrtTtextBox.Text = "";
            previousMrtTextBox.Text = "";
            preUnitPriceTextBox.Text = "";
            totalPriceTextBox.Text = "";
            //unitPriceTextBox.Text = "";
            quantityTextBox.Text = "";
            dateTextBox.Text="";
            billNoTextBox.Text = "";
            manufactureDateTextBox.Text = "";
            expireDateTextBox.Text = "";
            supplierComboBox.Text = "-Select suplier Name-";
            productComboBox.Text= "-Select Product Name-";
            CategoryComboBox.Text= "-Select Category Name-";
            codeTextBox.Text = "";
            availableQuantitytextBox.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            purchase.Code = searchTextBox.Text;
            purchaseDataGridView.DataSource = _purchaseManager.Search(purchase);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(CategoryComboBox.SelectedItem.ToString()== "-Select Category Name-")
            //{
            //    MessageBox.Show("Please Select Category Name");
            //    return;
            //}
            //category.Id =Int32.Parse(CategoryComboBox.SelectedValue.ToString());

            //productComboBox.DataSource = _purchaseManager.CatagoryWiseProductDisplay(category);
            //productComboBox.DisplayMember = "ProductName";
            //productComboBox.ValueMember = "Id";
            //productComboBox.Text = "--Select Product Name--";
        }

        private void CategoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem.ToString() == "-Select Category Name-")
            {
                MessageBox.Show("Please Select Category Name");
                return;
            }
            category.Id = Int32.Parse(CategoryComboBox.SelectedValue.ToString());

            productComboBox.DataSource = _purchaseManager.CatagoryWiseProductDisplay(category);
            productComboBox.DisplayMember = "ProductName";
            productComboBox.ValueMember = "Id";
            productComboBox.Text = "--Select Product Name--";
        }

        private void productComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem.ToString() == "--Select Product Name--")
            {
                MessageBox.Show("Please Select Product Name");
                return;
            }
            product.Id = Int32.Parse(productComboBox.SelectedValue.ToString());
            DataTable dt = _purchaseManager.ProductWiseProductDisplay(product);

            if (dt.Rows.Count > 0)
            {
                codeTextBox.Text = dt.Rows[0]["Code"].ToString();
                availableQuantitytextBox.Text = dt.Rows[0]["Quantity"].ToString();
                preUnitPriceTextBox.Text = dt.Rows[0]["Unite_Price"].ToString();
                previousMrtTextBox.Text = dt.Rows[0]["Previous_Mrp"].ToString();


            }




        }

        //private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (CategoryComboBox.SelectedItem.ToString() == "--Select Product Name--")
        //    {
        //        MessageBox.Show("Please Select Product Name");
        //        return;
        //    }
        //    product.Id = Int32.Parse(productComboBox.SelectedValue.ToString());
        //    DataTable dt = _purchaseManager.ProductWiseProductDisplay(product);

        //}

        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "" || quantityTextBox.Text == "0")
            {
                MessageBox.Show("Please Unti quantity");
                return;
            }
            if (unitPriceTextBox.Text == "" || unitPriceTextBox.Text == "0")
            {
                MessageBox.Show("Please Unti price Name");
                return;
            }

            totalPriceTextBox.Text = (float.Parse(quantityTextBox.Text) * float.Parse(unitPriceTextBox.Text)).ToString();
            mrtTtextBox.Text= (float.Parse(unitPriceTextBox.Text) +(( float.Parse(unitPriceTextBox.Text))*25)/100).ToString();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void SubmiteButton_Click(object sender, EventArgs e)
        {

            purchase_Master.SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue);
            purchase_Master.BillNo= billNoTextBox.Text;
            purchase_Master.Date = dateTextBox.Text;
            purchase_Master.Remarks = remarksTextBox.Text;
            purchase_Master.MRP = float.Parse(mrtTtextBox.Text);

            if (purchaseMasterManager.Add(purchase_Master))
            {


                 
                MessageBox.Show("added");
                
                Clear();
            }
        }
        string allDeliats = "";
        List<PurchaseDetials> listPurchaseDetials = new List<PurchaseDetials>();
        private void addButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (i == 0) {
              
            }
            

            PurchaseDetials purchaseDetail = new PurchaseDetials();

            //List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>();
            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //sqlConnection.Open();
            //string query = "SELECT * FROM PurchaseDetails";
            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //while (sqlDataReader.Read())
            //{

                //PurchaseDetails purchaseDetail = new PurchaseDetails();

                purchaseDetail.Pur_MID = 0;
                purchaseDetail.CategoriesID = Convert.ToInt32(CategoryComboBox.SelectedValue);
                purchaseDetail.ProductId = Convert.ToInt32(productComboBox.SelectedValue);
                purchaseDetail.AvailableQuantity = Convert.ToInt32(availableQuantitytextBox.Text);
                purchaseDetail.ManufacturedDate = manufactureDateTextBox.Text;
                purchaseDetail.ExpireDate =expireDateTextBox.Text;
                purchaseDetail.Quantity = Convert.ToInt32(quantityTextBox.Text);
               purchaseDetail.UnitPrice = float.Parse(unitPriceTextBox.Text);
              purchaseDetail.TotalPrice = float.Parse(totalPriceTextBox.Text);
             purchaseDetail.PreviousUnitPrice = float.Parse(preUnitPriceTextBox.Text);
             purchaseDetail.PreviousMRP = float.Parse(previousMrtTextBox.Text);
            //purchaseDetail.TotalPrice = Convert.ToDouble(sqlDataReader["TotalPrice"].ToString());
            //purchaseDetail.MRP = Convert.ToDouble(sqlDataReader["MRP"].ToString());
            //purchaseDetail.Remarks = sqlDataReader["Remarks"].ToString();


            listPurchaseDetials.Add(purchaseDetail);


            
            allDeliats +=purchaseDataGridView.DataSource = listPurchaseDetials;
            i++;

            }

        }
    }

