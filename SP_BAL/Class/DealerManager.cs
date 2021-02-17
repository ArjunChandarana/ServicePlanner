using SP_BAL.Interfaces;
using SP_DAL.Database;
using SP_DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SP_Models;

namespace SP_BAL.Class
{
    
    
        public class DealerManager : IDealerManager
        {
            private readonly IDealer _IDealer;

            public DealerManager(IDealer dealer)
            {
                _IDealer = dealer;
            }


         
        public string CreateDealer(Dealer dealer)
        {
            return _IDealer.CreateDealer(dealer);
        }

        public string UpdateDealer(Dealer dealer)
        {
            return _IDealer.UpdateDealer(dealer);
        }

        public List<Dealers> getAllDealers()
        {
            return _IDealer.getAllDealers();
        }

      public  bool IsActive(int DealerId)
        {
            return _IDealer.IsActive(DealerId); 
        }
    }
    }
}
