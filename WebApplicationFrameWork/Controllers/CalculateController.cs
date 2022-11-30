using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationFrameWork.Controllers
{
  

    public class CalculateController : ApiController
    {
        [HttpGet]
        [Route("calculate/add")]

        public int Add(int num1,int num2)
        {
            return (num1 + num2);
        }
    }
}
