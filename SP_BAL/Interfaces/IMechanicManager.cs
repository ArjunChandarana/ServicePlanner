using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_BAL.Interfaces
{
    public interface IMechanicManager
    {
        string AddMechanic(Mechanic mechanic);
        string UpdateMechanic(Mechanic mechanic);
        List<Mechanics> getAllMechanics();
        //bool IsActive(int MechanicId);
    }
}
