using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    class PurchaseDetials
    {
        public int Pur_DID { get; set; }
        public int Pur_MID { get; set; }
        public int CategoriesID { get; set; }
        public int ProductId { get; set; }
        public int AvailableQuantity { get; set; }
        public string ManufacturedDate { get; set; }
        public string ExpireDate { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float TotalPrice { get; set; }
        public float PreviousUnitPrice { get; set; }
        public float PreviousMRP { get; set; }


    }
}




 