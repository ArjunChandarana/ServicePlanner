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
        public string AddMechanic(Mechanic mechanic)
        {
            return _IMechanic.AddMechanic(mechanic);   
        }

        public List<Mechanics> getAllMechanics()
        {
            return _IMechanic.getAllMechanics();
        }

        public string UpdateMechanic(Mechanic mechanic)
        {
            return _IMechanic.UpdateMechanic(mechanic);
        }

       
    }
}
