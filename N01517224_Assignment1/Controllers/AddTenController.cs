using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01517224_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        //addition
        //Get api/AddTen/0 ->10
        //Get api/AddTen/21 ->31
        public int Get(int id)
        {
            int add = id + 10;      //addition
            return add;             //output
        }
    }
}
