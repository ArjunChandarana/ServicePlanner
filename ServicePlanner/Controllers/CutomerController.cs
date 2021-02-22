using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SP_BAL.Interfaces;
using SP_Models;

namespace ServicePlanner.Controllers
{
    public class CutomerController : ApiController
    {

        private readonly ICustomerManager _ICustomerManager;
        
        public CutomerController(ICustomerManager customerManager)
        {
            _ICustomerManager = customerManager;
        }


        // GET: api/Cutomer
        [HttpGet]
        public IHttpActionResult  Get()
        {
            var Customers = _ICustomerManager.getAllCustomers();
            return Ok(Customers);
        }

        // GET: api/Cutomer/5
        [HttpGet]
        [Route("api/Customer/{CustomerId}")]
        public IHttpActionResult Get(int CustomerId)
        {
            var response = _ICustomerManager.getCustomer(CustomerId);
            return Ok(response);
        }

        // POST: api/Cutomer
        public IHttpActionResult Post([FromBody]Customers customer)
        {
            var response = _ICustomerManager.AddCustomer(customer);
            return Ok(response);
        }

        // PUT: api/Cutomer/5
        public IHttpActionResult Put([FromBody]Customers customer )
        {
            var response = _ICustomerManager.UpdateCustomer(customer);
            return Ok(response);
        }

        // DELETE: api/Cutomer/5
        [HttpDelete]
        [Route("api/Customer/{CustomerId}")]
        public IHttpActionResult Delete(int CustomerId)
        {
            var response = _ICustomerManager.DeleteCustomer(CustomerId);
            return Ok(response);
        }
    }
}
