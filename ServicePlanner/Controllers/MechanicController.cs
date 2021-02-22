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
    public class MechanicController : ApiController
    {

        private readonly IMechanicManager _IMechanicManager;
        public MechanicController(IMechanicManager mechanicManager)
        {
            _IMechanicManager = mechanicManager;
        }


        // GET: api/Mechanic
        public IHttpActionResult Get()
        {
            var response = _IMechanicManager.getAllMechanics();
            return Ok(response);
        }

        // GET: api/Mechanic/5
        [HttpGet]
        [Route("api/Mechanic/{MechanicId}")]
        public IHttpActionResult Get(int MechanicId)
        {
            var response = _IMechanicManager.getMechanic(MechanicId);
            return Ok(response);
        }

        // POST: api/Mechanic
        public IHttpActionResult Post([FromBody]Mechanics mechanic)
        {
            var response = _IMechanicManager.AddMechanic(mechanic);
            return Ok(response);
        }

        // PUT: api/Mechanic/5
        public IHttpActionResult Put([FromBody]Mechanics mechanic)
        {
            var response = _IMechanicManager.UpdateMechanic(mechanic);
            return Ok(response);
        }

        // DELETE: api/Mechanic/5
        [HttpDelete]
        [Route("api/Mechanic/{MechanicId}")]
        public IHttpActionResult Delete(int MechanicId)
        {
            var response = _IMechanicManager.DeleteMechanic(MechanicId);
            return Ok(response);
        }
    }
}
