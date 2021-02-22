using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_BAL.Interfaces
{
   public interface IDealerManager
    {
        string CreateDealer(Dealers dealer);
        string UpdateDealer(Dealers dealer);
        List<Dealers> getAllDealers();
        bool IsActive(int DealerId);
        Dealers getDealer(int DealerId);
        string DeleteDealer(int DealerId);
    }
}
