using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Http5112_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello World!" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return $"Greetings to {id} people!";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
            value = "Hello World!";
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}