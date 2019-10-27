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
    class ProductManager
    {
        ProducRepository _producRepository = new ProducRepository();
        public bool Add(Product product)
        {
            return _producRepository.Add(product);
        }

        //public List<Product> Dispaly()
        //{
        //    return _producRepository.Dispaly();
        //}

        public DataTable Display()
        {
            return _producRepository.Dispaly();
        }

        public bool Update(Product product)
        {
            return _producRepository.Update(product);
        }
        public DataTable Search(Product product)
        {
            return _producRepository.Search(product); 
        }

        public bool IsNameExist(Product product)                         
        {
            return _producRepository.IsNameExist(product);
        }
        public bool IsCodeExist(Product product)
        {
            return _producRepository.IsCodeExist(product);
        }
        public DataTable FindReorderLevel(int productid)
        {
            return _producRepository.FindReorderLevel(productid);
        }
    }
}
