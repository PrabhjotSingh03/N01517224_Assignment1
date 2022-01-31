using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class NumbermachineController : ApiController
    {

        public string Get(int id)
        {
            int add = id + 10;
            int sub = id - 20;
            int mul = id * 10;
            float div =  id / 10F;
            //int mul  = id * 100;
            return "Addition= " + add + " , Subtraction= " + sub + " , Multiply= " + mul + " , Divide= " + div + "";
        }

    }
}
