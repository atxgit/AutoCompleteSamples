using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AutoCompleteSamples.Controllers
{
    public class ValuesAPIController : ApiController
    {
        // GET api/valuesapi
        public IEnumerable<string> Get([FromUri]string term)
        {
            var ret = new string[] {};
            //System.Threading.Thread.Sleep(2000);
            if (!string.IsNullOrEmpty(term))
            {
                ret = new string[] { term + " Smith", term + " Jones", term + " Baker" };
            }

            return ret;
        }

        // GET api/valuesapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/valuesapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/valuesapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/valuesapi/5
        public void Delete(int id)
        {
        }
    }
}
