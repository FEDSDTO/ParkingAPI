using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Space.Controllers
{
    public class get_remain_space_infoController : ApiController
    {
        Func_Public _pub = new Func_Public();

        public IHttpActionResult Get()
        {
            return Ok("Success");
        }

        public IHttpActionResult Post(object prop)
        {
            string _result = _pub.Parking_Connect(prop);
            return Ok(_result);
        }
    }
}
