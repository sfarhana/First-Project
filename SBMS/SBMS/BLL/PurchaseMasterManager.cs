using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;
using SBMS.Repository;

namespace SBMS.BLL
{
    class PurchaseMasterManager
    {
        PurhaseMasterRepository _masterRepository = new PurhaseMasterRepository();
        public bool Add(Purchase_Master purchase_Master)
        {
            return _masterRepository.Add(purchase_Master);
        }
    }
}
