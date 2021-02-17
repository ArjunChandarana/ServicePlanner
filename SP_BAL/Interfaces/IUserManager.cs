using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_BAL.Interfaces
{
    public interface IUserManager
    {
        string CreateUser(Users_Receptionist_Advisior user);
        string UpdateUser(Users_Receptionist_Advisior user);
        List<Users_Receptionist_Advisiors> getAllUser();
    }
}
