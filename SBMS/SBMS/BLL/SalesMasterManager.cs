using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;
using SBMS.Repository;
using System.Data;

namespace SBMS.BLL
{
    class SalesMasterManager
    {
        SalesMasterRepository _SalesMasterRepository = new SalesMasterRepository();
        public bool Add(SalesMaster SalesMaster)
        {
            return _SalesMasterRepository.Add(SalesMaster);
        }

        public bool AddDetails(SalesDetial SD)
        {
            return _SalesMasterRepository.AddDetails(SD);
        }

        public DataTable LoadQuantityNMrp(int ProductID)
        {
            return _SalesMasterRepository.LoadQuantityNMrp(ProductID);
        }
        public DataTable FindSalesMID()
        {
            return _SalesMasterRepository.FindSalesMID();
        }
        public DataTable SearchData(string SalesCode)
        {
            return _SalesMasterRepository.SearchData(SalesCode);
        }


    }
}
