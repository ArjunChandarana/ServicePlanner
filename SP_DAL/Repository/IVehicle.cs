using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_DAL.Repository
{
   public interface IVehicle
    {
        string CreateVehicle(Vehicles vehicle);
        string UpdateVehicle(Vehicles vehicle);
        List<Vehicles> getAllVehicles();

        Vehicles getVehicle(int VehicleId);
        string DeleteVehicle(int VehicleId);
       
    }
}
