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
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomer _ICustomer;

        public CustomerManager(ICustomer customer)
        {
            _ICustomer = customer;
        }

        public string AddCustomer(Customer customer)
        {
            return _ICustomer.AddCustomer(customer);
        }

        public List<Customers> getAllCustomers()
        {
            return _ICustomer.getAllCustomers();
        }

        public string UpdateCustomer(Customer customer)
        {
            return _ICustomer.UpdateCustomer(customer);
        }
    }
}
