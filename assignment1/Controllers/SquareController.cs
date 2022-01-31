using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class SquareController : ApiController
    {
        //Squaring
        //Get api/Square/10 ->100
        //Get api/Square/2 ->4
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
