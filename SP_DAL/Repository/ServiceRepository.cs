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
    public class ServiceRepository : IService
    {


        private readonly Database.DBEntities dbcontext = new DBEntities();

        public string CreateService(Service service)
        {
            try
            {
                if (service != null)
                {
                    Database.Service entity = new Database.Service();

                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Service, Database.Service>());
                    var mapper = new Mapper(config);

                    entity = mapper.Map<Database.Service>(service);

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

        public List<Services> getAllServices()
        {
            var entities = dbcontext.Services.ToList();

            List<Services> services = new List<Services>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.Service, Services>());
            var mapper = new Mapper(config);

            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Services service = new Services();
                    service = mapper.Map<Services>(item);
                    services.Add(service);
                }
            }
            return services;
        }

        
        public string UpdateService(Service service)
        {
            try
            {
                var entity = dbcontext.Services.Find(service.ServiceId);

                if (entity != null)
                {

                    entity.Name = service.Name;
                    //entity.IsActive = service.IsActive;
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
