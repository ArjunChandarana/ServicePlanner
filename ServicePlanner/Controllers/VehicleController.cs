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
    public class VehicleController : ApiController
    {
        private readonly IVehicleManager _IVehicleManager;

        public VehicleController(IVehicleManager vehicleManager)
        {
            _IVehicleManager = vehicleManager;
        }

        // GET: api/Vehicle
        [HttpGet]
        public IHttpActionResult Get()
        {
            var Vehicles = _IVehicleManager.getAllVehicles();
            return Ok(Vehicles);

        }

        // GET: api/Vehicle/5
        [HttpGet]
        [Route("api/Vehicle/{VehicleId}")]
        public IHttpActionResult Get(int VehicleId)
        {
            var response = _IVehicleManager.getVehicle(VehicleId);
            return Ok(response);
        }

        // POST: api/Vehicle
        public IHttpActionResult Post([FromBody]Vehicles vehicle)
        {
            var response = _IVehicleManager.CreateVehicle(vehicle);
            return Ok(response);
        }

        // PUT: api/Vehicle/5
        public IHttpActionResult Put([FromBody]Vehicles vehicle)
        {
            var response = _IVehicleManager.UpdateVehicle(vehicle);
            return Ok(response);
        }

        // DELETE: api/Vehicle/5
        [HttpDelete]
        [Route("api/Vehicle/{VehicleId}")]
        public IHttpActionResult Delete(int VehicleId)
        {
            var response = _IVehicleManager.DeleteVehicle(VehicleId);
            return Ok(response);
        }
    }
}
