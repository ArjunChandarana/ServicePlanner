using AutoMapper;
using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_DAL.Repository
{
   public class VehicleRepository : IVehicle
    {
        private readonly Database.DBEntities dbcontext = new DBEntities();
        public string CreateVehicle(Vehicle vehicle)
        {
            try
            {
                if (vehicle != null)
                {
                    Database.Vehicle entity = new Database.Vehicle();

                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Vehicle, Database.Vehicle>());
                    var mapper = new Mapper(config);

                    entity = mapper.Map<Database.Vehicle>(vehicle);

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

        public List<Vehicles> getAllVehicles()
        {
            var entities = dbcontext.Vehicles.ToList();

            List<Vehicles> vehicles = new List<Vehicles>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.Vehicle, Vehicles>());
            var mapper = new Mapper(config);

            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Vehicles vehicle = new Vehicles();
                    vehicle = mapper.Map<Vehicles>(item);
                    vehicles.Add(vehicle);
                }
            }
            return vehicles;
        }

       

        public string UpdateVehicle(Vehicle vehicle)
        {
            try
            {
                var entity = dbcontext.Vehicles.Find(vehicle.VehicleId);

                if (entity != null)
                {

                    entity.VehicleName = vehicle.VehicleName;
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
