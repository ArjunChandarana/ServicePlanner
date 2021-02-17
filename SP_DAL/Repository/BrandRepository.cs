﻿using AutoMapper;
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

        public string CreateBrand(Brand brand)
        {
            try
            {
                if (brand != null)
                {
                    Database.Brand entity = new Database.Brand();

                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Brand, Database.Brand>());
                    var mapper = new Mapper(config);

                    entity = mapper.Map<Database.Brand>(brand);

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

        public string UpdateBrand(Brand brand)
        {
            try
            {
                var entity = dbcontext.Brands.Find(brand.BrandId);

                if (entity != null)
                {

                    entity.Name = brand.Name;
                    entity.IsActive = brand.IsActive;
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

        public bool IsActive(int BrandId)
        {
            Database.Brand entity = new Database.Brand();

            if (entity.IsActive)
            {
                return true;
            }
            return false;
        }
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

