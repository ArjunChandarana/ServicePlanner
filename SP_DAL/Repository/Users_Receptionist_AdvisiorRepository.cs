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
   public class Users_Receptionist_AdvisiorRepository : IUsers_Receptionist_Advisior
    {
        private readonly Database.DBEntities dbcontext = new DBEntities();
        public string CreateUser(Users_Receptionist_Advisior user)
        {
          

       
        
            try
            {
                if (user != null)
                {
                    Database.Users_Receptionist_Advisior entity = new Database.Users_Receptionist_Advisior();

                    var config = new MapperConfiguration(cfg => cfg.CreateMap<Users_Receptionist_Advisior, Database.Users_Receptionist_Advisior>());
                    var mapper = new Mapper(config);

                    entity = mapper.Map<Database.Users_Receptionist_Advisior>(user);

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

        public List<Users_Receptionist_Advisiors> getAllUser()
        {
            var entities = dbcontext.Users_Receptionist_Advisior.ToList();

            List<Users_Receptionist_Advisiors> users = new List<Users_Receptionist_Advisiors>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Database.Users_Receptionist_Advisior, Users_Receptionist_Advisiors>());
            var mapper = new Mapper(config);

            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Users_Receptionist_Advisiors user = new Users_Receptionist_Advisiors();
                    user = mapper.Map<Users_Receptionist_Advisiors>(item);
                    users.Add(user);
                }
            }
            return users;
        }

        public string UpdateUser(Users_Receptionist_Advisior user)
        {
            try
            {
                var entity = dbcontext.Users_Receptionist_Advisior.Find(user.UserId);

                if (entity != null)
                {

                    entity.Name = user.Name;
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
