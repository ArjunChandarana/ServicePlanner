using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_BAL.Interfaces
{
   public  interface IServiceManager
    {
        string CreateService(Services service);
        string UpdateService(Services service);
        List<Services> getAllServices();
        // bool IsActive(int ServiceId);
        Services getService(int ServiceId);
        string DeleteService(int ServiceId);
    }
}
