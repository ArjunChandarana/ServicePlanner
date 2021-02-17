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
    public class SelectedServiceRepository : ISelectedService
    {
        private readonly Database.DBEntities dbcontext = new DBEntities();

        public List<SelectedServices> getAllSServices()
        {
            var entities = dbcontext.SelectedServices.ToList();

            List<SelectedServices> sservices = new List<SelectedServices>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.SelectedService, SelectedServices>());
            var mapper = new Mapper(config);

            if (entities != null)
            {
                foreach (var item in entities)
                {
                    SelectedServices sservice = new SelectedServices();
                    sservice = mapper.Map<SelectedServices>(item);
                    sservices.Add(sservice);
                }
            }
            return sservices;
        }

        public string UpdateSelectedService(SelectedService sservice)
        {
            try
            {
                var entity = dbcontext.SelectedServices.Find(sservice.SelectedServiceId);

                if (entity != null)
                {

                    entity.SelectedServiceId = sservice.SelectedServiceId;
                    // entity.IsActive = brand.IsActive;
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
