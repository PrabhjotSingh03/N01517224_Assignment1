using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01517224_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        //api/Greeting
        public string Get()
        {
            return "Hello World!";      //output
        }

        //GET api/Greeting/3 ->Greetings to 3 people!
        public string Get(int id)
        {

            return "Greetings to " + id + " people!";       //output
        }
    }
}
