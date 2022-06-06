using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace wyklad6_moj.Controllers
{
    public class NaszeapiController : ApiController
    {
        // GET: api/naszeapi

        [HttpGet]
        public IEnumerable<string> GetItems()
        {
            return new string[] { "value1", "value2", "value3", "value4" };

        }



        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };

        }

        // GET: api/naszeapi/5
        public string Get(int id)
        {
            return "value";
        }

        public string Get(char id)
        {
            return "value";
        }

        // POST: api/naszeapi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/naszeapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/naszeapi/5
        public void Delete(int id)
        {
        }
    }
}
