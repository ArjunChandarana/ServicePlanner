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

        public string CreateService(Service service)
        {
            return _IService.CreateService(service);
        }

        public List<Services> getAllServices()
        {
            return _IService.getAllServices();
        }

        public string UpdateService(Service service)
        {
            return _IService.UpdateService(service);
        }
    }
}
