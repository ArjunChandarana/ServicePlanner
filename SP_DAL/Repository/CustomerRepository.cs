using SP_DAL.Database;
using AutoMapper;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_DAL.Repository
{
   public class CustomerRepository : ICustomer
    {
        private readonly Database.DBEntities dbcontext = new DBEntities();


        public string AddCustomer(Customer customer)
        {
            try
            {
                if (customer != null)
                {
                    Database.Vehicle entity = new Database.Vehicle();

                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Vehicle, Database.Vehicle>());
                    var mapper = new Mapper(config);

                    entity = mapper.Map<Database.Vehicle>(customer);

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

        public List<Customers> getAllCustomers()
        {
            var entities = dbcontext.Customers.ToList();

            List<Customers> customers = new List<Customers>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.Customer, Customers>());
            var mapper = new Mapper(config);

            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Customers customer = new Customers();
                    customer = mapper.Map<Customers>(item);
                    customers.Add(customer);
                }
            }
            return customers;
        }

       

        public string UpdateCustomer(Customer customer)
        {
            try
            {
                var entity = dbcontext.Customers.Find(customer.CustomerId);

                if (entity != null)
                {

                    entity.Name = customer.Name;
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
