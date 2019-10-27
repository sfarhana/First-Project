using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    class SalesMaster
    {
        public int Sales_MID { get; set; }
        public int SalesCode { get; set; }
        public int CustomerID { get; set; }
        public string Date { get; set; }
        public float GrandTotal { get; set; }
        public float Discount { get; set; }
        public float DiscountAmount { get; set; }
        public float PayableAmount { get; set; }

    }
}
 