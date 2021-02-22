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
    public class VehicleManager : IVehicleManager
    {
        private readonly IVehicle _IVehicle;

        public VehicleManager(IVehicle vehicle)
        {
            _IVehicle = vehicle;
        }

        public string CreateVehicle(Vehicles vehicle)
        {
            return _IVehicle.CreateVehicle(vehicle);
        }

        public List<Vehicles> getAllVehicles()
        {
            return _IVehicle.getAllVehicles();
        }

        public string UpdateVehicle(Vehicles vehicle)
        {
            return _IVehicle.UpdateVehicle(vehicle);
        }

       public  Vehicles getVehicle(int VehicleId)
        {
            return _IVehicle.getVehicle(VehicleId);
        }
        public string DeleteVehicle(int VehicleId)
        {
            return _IVehicle.DeleteVehicle(VehicleId);
        }
    }
}
