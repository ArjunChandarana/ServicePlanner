using SP_DAL.Database;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_BAL.Interfaces
{
  public interface ICustomerManager
    {
        string AddCustomer(Customers customer);
        string UpdateCustomer(Customers customer);
        List<Customers> getAllCustomers();

        Customers getCustomer(int CustomerId);
        string DeleteCustomer(int CustomerId);

        //bool IsActive(int CustomerId);
    }
}
