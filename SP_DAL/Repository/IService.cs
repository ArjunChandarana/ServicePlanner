using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_DAL.Repository
{
   public interface IService
    {
        string CreateService(Service service);
        string UpdateService(Service service);
        List<Services> getAllServices();
       // bool IsActive(int ServiceId);
    }
}
