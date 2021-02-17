﻿using SP_BAL.Class;
using SP_BAL.Interfaces;
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
        public IEnumerable<string> Get()
        {
            return
        }

        // GET: api/Brand/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Brand
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Brand/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Brand/5
        public void Delete(int id)
        {
        }
    }
}
