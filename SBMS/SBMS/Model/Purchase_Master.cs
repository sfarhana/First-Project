using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    class Purchase_Master
    {
        public int Pur_MID { get; set; }
        public int SupplierId { get; set; }
        public string BillNo { get; set; }
        public string Date { get; set; }
        public string Remarks { get; set; }
        public float MRP { get; set; }

    }
}
 