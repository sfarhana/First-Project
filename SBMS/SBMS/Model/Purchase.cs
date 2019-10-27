using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    class Purchase
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Bill_No { get; set; }
        public string Manufacture_Date { get; set; }
        public string Expire_Date { get; set; }
        public int Quantity { get; set; }
        public float Unite_Price { get; set; }
        public float Total_Price { get; set; }
        public float Previous_Cost_Price { get; set; }
        public float Previous_Mrp { get; set; }
        public float New_Mrp { get; set; }
        public string Remarks { get; set; }
        public string Code { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }




    }
}
