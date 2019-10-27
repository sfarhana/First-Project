using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SBMS.Model;
using SBMS.Repository;

namespace SBMS.BLL
{
    class PurchaseManager
    {
        PurchaseRepository _purchaseRepository = new PurchaseRepository();
        public bool Add(Purchase purchase)
        {
            return _purchaseRepository.Add(purchase);
        }
        
        public DataTable Display()
        {
            return _purchaseRepository.Dispaly();
        }
        public DataTable CatagoryWiseProductDisplay(Category category)
        {
            return _purchaseRepository.CatagoryWiseProductDisplay(category);
        }
        public DataTable ProductWiseProductDisplay(Product product)
        {
            return _purchaseRepository.ProductWiseProductDisplay(product);
        }


        public DataTable Search(Purchase purchase)
        {
            return _purchaseRepository.Search(purchase);
        }
    }
}
