using System;
using SP_DAL.Database;
using SP_DAL.Repository;
using SP_Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SP_BAL.Interfaces;

namespace SP_BAL.Class
{

    public class ServiceManager : IServiceManager
    {
        private readonly IService _IService;

        public ServiceManager(IService service)
        {
            _IService = service;
        }

        public string CreateService(Services service)
        {
            return _IService.CreateService(service);
        }

        public List<Services> getAllServices()
        {
            return _IService.getAllServices();
        }

        public string UpdateService(Services service)
        {
            return _IService.UpdateService(service);
        }

        public Services getService(int ServiceId)
        {
            return _IService.getService(ServiceId);
        }

        public string DeleteService(int ServiceId)
        {
            return _IService.DeleteService(ServiceId);
        }
    }
}
