using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BeezyApiManager.Controllers
{
    public class MovieController : ApiController
    {       

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

    }
}