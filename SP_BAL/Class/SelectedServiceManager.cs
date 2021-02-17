using SP_BAL.Interfaces;
using SP_DAL.Database;
using SP_DAL.Repository;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_BAL.Class
{
    public class SelectedServiceManager : ISelectedServiceManager
    {
        private readonly ISelectedService _ISelectedService;

        public SelectedServiceManager(ISelectedService sservice)
        {
            _ISelectedService = sservice;
        }


        public List<SelectedServices> getAllSServices()
        {
            return _ISelectedService.getAllSServices();
        }

        public string UpdateSelectedService(SelectedService sservice)
        {
            return _ISelectedService.UpdateSelectedService(sservice);
        }
    }
}
