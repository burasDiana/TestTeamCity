using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        public int Calculate(int a, int b, string op)
        {
            if (a != b && a != -b && b != -a)
            {
                if (op.Equals("+"))
                {
                    return a + b;
                }

                if (op.Equals("-"))
                {
                    return a - b;
                }
            }

            return 0; //means the wrong operand was inserted, or the if checks were violated
        }
        
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
