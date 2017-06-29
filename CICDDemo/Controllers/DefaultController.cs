using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CICDDemo.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("{name?}")]
        [HttpGet]
        public IHttpActionResult TestMe(string name = null)
        {
            string greeting = System.Configuration.ConfigurationManager.AppSettings["greeting"];

            if (!string.IsNullOrEmpty(name))
            {
                greeting += " Your name is: " + name;
            }

            return Ok(greeting);

        }
    }
}
