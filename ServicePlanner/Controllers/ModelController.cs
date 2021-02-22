using SP_BAL.Class;
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
    public class ModelController : ApiController
    {
        private readonly IModelManager _IModelManager;
        
        public ModelController(IModelManager modelManager)
        {
            _IModelManager = modelManager;
        }

        // GET: api/Model
        public IHttpActionResult Get()
        {
            var response = _IModelManager.getAllModels();
            return Ok(response);
        }

        // GET: api/Model/5
        [HttpGet]
        [Route("api/Model/{ModelId}")]
        public IHttpActionResult Get(int ModelId)
        {
            var response = _IModelManager.getModel(ModelId);
            return Ok(response);
        }

        // POST: api/Model
        public IHttpActionResult Post([FromBody]Models model)
        {
            var response = _IModelManager.AddModel(model);
            return Ok(response);
        }

        // PUT: api/Model/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Model/5
        public void Delete(int id)
        {
        }
    }
}
