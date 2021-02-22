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
        string AddCustomer(Customers customer);
        string UpdateCustomer(Customers customer);
        List<Customers> getAllCustomers();

        Customers getCustomer(int CustomerId);
        string DeleteCustomer(int CustomerId);

        //bool IsActive(int CustomerId);
    }
}
