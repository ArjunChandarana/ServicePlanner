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
   public class BrandRepository : IBrand
    {
       
        
            
         private readonly Database.DBEntities dbcontext = new DBEntities();
        public List<Brands> getAllBrands()
        {

            var entities = dbcontext.Brands.ToList();

            List<Brands> brands = new List<Brands>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.Brand, Brands>());
            var mapper = new Mapper(config);

            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Brands brand = new Brands();
                    brand = mapper.Map<Brands>(item);
                    brands.Add(brand);
                }
            }
            return brands;

        
    }
}
    }

