using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_BAL.Interfaces
{
   public interface IVehicleManager
    {
        
        string CreateVehicle(Vehicle vehicle);
        string UpdateVehicle(Vehicle vehicle);
        List<Vehicles> getAllVehicles();
    }
}
