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
    public class MechanicManager : IMechanicManager
    {
        private readonly IMechanic _IMechanic;

        public MechanicManager(IMechanic mechanic)
        {
            _IMechanic = mechanic;
        }
        public string AddMechanic(Mechanics mechanic)
        {
            return _IMechanic.AddMechanic(mechanic);   
        }

        public List<Mechanics> getAllMechanics()
        {
            return _IMechanic.getAllMechanics();
        }

        public string UpdateMechanic(Mechanics mechanic)
        {
            return _IMechanic.UpdateMechanic(mechanic);
        }

       public Mechanics getMechanic(int MechanicId)
        {
            return _IMechanic.getMechanic(MechanicId);
        }

        public string DeleteMechanic(int MechanicId)
        {
            return _IMechanic.DeleteMechanic(MechanicId);
        }
    }
}
