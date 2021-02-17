using System;
using SP_DAL.Repository;
using SP_Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SP_DAL.Database;

namespace SP_DAL.Repository
{
   public interface ICustomer
    {
        string AddCustomer(Customer customer);
        string UpdateCustomer(Customer customer);
        List<Customers> getAllCustomers();
        //bool IsActive(int CustomerId);
    }
}
