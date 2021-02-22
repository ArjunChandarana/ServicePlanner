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

        public string AddModel(Models model)
        {
            try
            {
                if (model != null)
                {
                    Database.Model entity = new Database.Model();

                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Models, Database.Model>());
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


        public Models getModel(int ModelId)
        {
            Database.Model entity = new Database.Model();
            entity = dbcontext.Models.Find(ModelId);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.Model, Models>());
            var mapper = new Mapper(config);

            Models model = mapper.Map<Models>(entity);
            return model;

        }


        public string DeleteModel(int ModelId)
        {
            Database.Model entity = new Database.Model();
            entity = dbcontext.Models.Find(ModelId);

            if (entity != null)
            {
                dbcontext.Models.Remove(entity);
                dbcontext.SaveChanges();
                return "Successfully Deleted";
            }
            return "Done";
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

        public string UpdateModel(Models model)
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
