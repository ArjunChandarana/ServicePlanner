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
  public  class DealerRepository:IDealer
    {
        private readonly Database.DBEntities dbcontext = new DBEntities();

        public string CreateDealer(Dealer dealer)
        {
            try
            {
                if (dealer != null)
                {
                    Database.Dealer entity = new Database.Dealer();

                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Dealer, Database.Dealer>());
                    var mapper = new Mapper(config);

                    entity = mapper.Map<Database.Dealer>(dealer);

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

        public string UpdateDealer(Dealer dealer)
        {
            try
            {
                var entity = dbcontext.Brands.Find(dealer.DealerId);

                if (entity != null)
                {

                    entity.Name = dealer.Name;
                    entity.IsActive = dealer.IsActive;
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

        public bool IsActive(int DealerId)
        {
            Database.Dealer entity = new Database.Dealer();

            if (entity.IsActive)
            {
                return true;
            }
            return false;
        }

        public List<Dealers> getAllDealers()
        {

            var entities = dbcontext.Dealers.ToList();

            List<Dealers> dealers = new List<Dealers>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.Dealer, Dealers>());
            var mapper = new Mapper(config);

            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Dealers dealer = new Dealers();
                    dealer = mapper.Map<Dealers>(item);
                    dealers.Add(dealer);
                }
            }
            return dealers;


        }
}

    
