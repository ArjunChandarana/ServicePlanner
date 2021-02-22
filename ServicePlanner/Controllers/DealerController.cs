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
    public class DealerController : ApiController
    {
        private readonly IDealerManager _IDealerManager;
        
        public DealerController(IDealerManager dealerManager)
        {
            _IDealerManager = dealerManager;
        }

        // GET: api/Dealer
        public IHttpActionResult Get()
        {
            var response = _IDealerManager.getAllDealers();
            return Ok(response);
        }

        // GET: api/Dealer/5
        [HttpGet]
        [Route("api/Dealer/{DealerId}")]
        public IHttpActionResult Get(int DealerId)
        {
            var response = _IDealerManager.getDealer(DealerId);
            return Ok(response);
        }

        // POST: api/Dealer
        public IHttpActionResult Post([FromBody]Dealers dealer)
        {
            var response = _IDealerManager.CreateDealer(dealer);
            return Ok(response);
        }

        // PUT: api/Dealer/5
        public IHttpActionResult Put([FromBody]Dealers dealer)
        {
            var response = _IDealerManager.UpdateDealer(dealer);
            return Ok(response);
        }

        // DELETE: api/Dealer/5
        [HttpDelete]
        public IHttpActionResult Delete(int DealerId)
        {
            var response = _IDealerManager.DeleteDealer(DelaerId);
            return Ok(response);
        }
    }
}
