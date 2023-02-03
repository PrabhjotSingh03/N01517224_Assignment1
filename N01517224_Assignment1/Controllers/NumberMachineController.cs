using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01517224_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        // GET /api/NumberMachine/{id}
        public string Get(int id)
        {
            int add = id + 10;     //Addition
            int sub = id - 20;     //Subtraction
            int mul = id * 10;      //Multipilication
            float div = id / 10F;       //Division
            return "Addition= " + add + " , Subtraction= " + sub + " , Multiply= " + mul + " , Divide= " + div + "";    //Output
        }
    }
}
