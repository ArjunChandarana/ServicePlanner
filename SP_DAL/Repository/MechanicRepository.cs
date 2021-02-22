using SP_DAL.Database;
using SP_Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_DAL.Repository
{
    public class MechanicRepository : IMechanic
    {
        private readonly Database.DBEntities dbcontext = new DBEntities();

        public string AddMechanic(Mechanics mechanic)
        {
            try
            {
                if (mechanic != null)
                {
                    Database.Mechanic entity = new Database.Mechanic();

                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Mechanics, Database.Mechanic>());
                    var mapper = new Mapper(config);

                    entity = mapper.Map<Database.Mechanic>(mechanic);

                    dbcontext.SaveChanges();

                    return "created";
                }
                return "null";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public Mechanics getMechanic(int MechanicId)
        {
            Database.Mechanic entity = new Database.Mechanic();
            entity = dbcontext.Mechanics.Find(MechanicId);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.Mechanic, Mechanics>());
            var mapper = new Mapper(config);

            Mechanics mechanic = mapper.Map<Mechanics>(entity);
            return mechanic;

        }


        public string DeleteMechanic(int MechanicId)
        {
            Database.Mechanic entity = new Database.Mechanic();
            entity = dbcontext.Mechanics.Find(MechanicId);

            if (entity != null)
            {
                dbcontext.Mechanics.Remove(entity);
                dbcontext.SaveChanges();
                return "Successfully Deleted";
            }
            return "Done";
        }



        public List<Mechanics> getAllMechanics()
        {
            var entities = dbcontext.Mechanics.ToList();

            List<Mechanics> mechanics = new List<Mechanics>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.Mechanic, Mechanics>());
            var mapper = new Mapper(config);

            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Mechanics mechanic = new Mechanics();
                    mechanic = mapper.Map<Mechanics>(item);
                    mechanics.Add(mechanic);
                }
            }
            return mechanics;
        }


        public string UpdateMechanic(Mechanics mechanic)
        {
            try
            {
                var entity = dbcontext.Mechanics.Find(mechanic.MechanicId);

                if (entity != null)
                {

                    entity.Name = mechanic.Name;
                    //entity.IsActive = brand.IsActive;
                    dbcontext.SaveChanges();

                    return "Updated";
                }

                return "null";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
