using SP_BAL.Interfaces;
using SP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicePlanner.Controllers
{
    public class ServiceController : ApiController
    {
        private readonly IServiceManager _IServiceManager;

        public ServiceController(IServiceManager serviceManager)
        {
            _IServiceManager = serviceManager;
        }


        // GET: api/Service
        public IHttpActionResult Get()
        {
            var response = _IServiceManager.getAllServices();
            return Ok(response);
        }

        // GET: api/Service/5
        [HttpGet]
        [Route("api/Service/{ServiceId}")]
        public IHttpActionResult Get(int ServiceId)
        {
            var response = _IServiceManager.getService(ServiceId);
            return Ok(response);
        }

        // POST: api/Service
        public IHttpActionResult Post([FromBody]Services service)
        {
            var response = _IServiceManager.CreateService(service);
            return Ok(response);
        }

        // PUT: api/Service/5
        public IHttpActionResult Put([FromBody]Services service)
        {
            var response = _IServiceManager.UpdateService(service);
            return Ok(response);
        }

        // DELETE: api/Service/5
        [HttpDelete]
        [Route("api/Service/{ServiceId}")]
        public IHttpActionResult Delete(int ServiceId)
        {
            var response = _IServiceManager.DeleteService(ServiceId);
            return Ok(response);
        }
    }
}
