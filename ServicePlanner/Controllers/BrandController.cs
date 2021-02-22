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
    public class BrandController : ApiController
    {
        private readonly IBrandManager _IBrandManager;

        public BrandController(IBrandManager brandManager)
        {
            _IBrandManager = brandManager;
        }


        // GET: api/Brand
        [HttpGet]
        public IHttpActionResult Get()
        {
            var Brands = _IBrandManager.getAllBrands();
            return Ok(Brands);
        }

        // GET: api/Brand/5
        [HttpGet]
        [Route("api/Brand/{BrandId}")]
        public IHttpActionResult Get(int BrandId)
        {
            var brandid = _IBrandManager.getBrand(BrandId);

            return Ok(brandid);
        }

        // POST: api/Brand

        public IHttpActionResult Post([FromBody]Brands brand)
        {
            var response = _IBrandManager.CreateBrand(brand);
            return Ok(response);
        }

        // PUT: api/Brand/5
        public IHttpActionResult Put([FromBody]Brands brand)
        {
            var response = _IBrandManager.UpdateBrand(brand);
            return Ok(response);
        }

        // DELETE: api/Brand/5
        [HttpDelete]
        [Route("api/Brand/{BrandId}")]
        public IHttpActionResult Delete(int BrandId)
        {
            var response = _IBrandManager.DeleteBrand(BrandId);
            return Ok(response);
        }
    }
}
