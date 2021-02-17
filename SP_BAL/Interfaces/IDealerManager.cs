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
        string CreateDealer(Dealer dealer);
        string UpdateDealer(Dealer dealer));
        List<Dealers> getAllDealers();
        bool IsActive(int DealerId);
    }
}
