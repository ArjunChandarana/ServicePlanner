using SP_BAL.Interfaces;
using SP_DAL.Database;
using SP_DAL.Repository;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_BAL.Class
{
    public class UserManager : IUserManager
    {
        private readonly IUsers_Receptionist_Advisior _IUser;

        public UserManager(IUsers_Receptionist_Advisior user)
        {
            _IUser = user;
        }

        public string CreateUser(Users_Receptionist_Advisior user)
        {
            return _IUser.CreateUser(user);
        }

        public List<Users_Receptionist_Advisiors> getAllUser()
        {
            return _IUser.getAllUser();
                
        }

        public string UpdateUser(Users_Receptionist_Advisior user)
        {
            return _IUser.UpdateUser(user);
        }
    }
}
