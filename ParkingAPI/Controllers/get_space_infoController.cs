using ParkingAPI.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParkingAPI.Controllers
{
    public class get_space_infoController : ApiController
    {
        Func_Public _pub = new Func_Public();

        public IHttpActionResult Get()
        {
            return Ok("Success");
        }

        public IHttpActionResult Post()
        {
            object _result = _pub.Parking_get_space_info();
            return Ok(_result);
        }
    }
}
