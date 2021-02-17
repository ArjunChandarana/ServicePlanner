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
    public class ModelRepository : IModel
    {
        private readonly Database.DBEntities dbcontext = new DBEntities();

        public string AddModel(Model model)
        {
            try
            {
                if (model != null)
                {
                    Database.Model entity = new Database.Model();

                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Model, Database.Model>());
                    var mapper = new Mapper(config);

                    entity = mapper.Map<Database.Model>(model);

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

        public List<Models> getAllModels()
        {
            var entities = dbcontext.Models.ToList();

            List<Models> models = new List<Models>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.Model, Models>());
            var mapper = new Mapper(config);

            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Models model = new Models();
                    model = mapper.Map<Models>(item);
                    models.Add(model);
                }
            }
            return models;
        }

        public bool IsActive(int ModelId)
        {
            Database.Model entity = new Database.Model();

            if (entity.IsActive)
            {
                return true;
            }
            return false;
        }

        public string UpdateModel(Model model)
        {
            try
            {
                var entity = dbcontext.Models.Find(model.ModelId);

                if (entity != null)
                {

                    entity.Name = model.Name;
                    entity.IsActive = model.IsActive;
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
