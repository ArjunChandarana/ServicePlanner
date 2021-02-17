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
        string AddCustomer(Customer customer);
        string UpdateCustomer(Customer customer);
        List<Customers> getAllCustomers();
        //bool IsActive(int CustomerId);
    }
}
