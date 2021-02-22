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
        string AddMechanic(Mechanics mechanic);
        string UpdateMechanic(Mechanics mechanic);
        List<Mechanics> getAllMechanics();
        //bool IsActive(int MechanicId);
        Mechanics getMechanic(int MechanicId);
        string DeleteMechanic(int MechanicId);
    }
}
