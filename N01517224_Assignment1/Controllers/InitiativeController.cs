using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01517224_Assignment1.Controllers
{
    public class InitiativeController : ApiController
    {
        // api/Initiative/{id}
        public IEnumerable<string> Get(int id)
        {
            double fortnights = id / 14;                                //Step-1 Id Divided by 14 
            int fortnights2 = Convert.ToInt32(fortnights + 1);          //Step-2 Division value from step-1 gets added here
            double fortnightCharge = 5.50 * fortnights2;                //Step-3  Value generated from step-2 gets multiplied in this step
            double HstTotal = fortnights2 * 0.72;                       //step-4 Value from step-2 gets multiplied here
            double TotalBill = fortnightCharge + HstTotal;              //Step-5 Values from step-3 and step-4 gets added here.
            return new string[]
                {
                    fortnights2 + " Fortnights at $5.50/FN = $"+ fortnightCharge+ " CAD" ,"HST 13% = $" + HstTotal+" CAD","Total = $" + TotalBill +" CAD"           //output
                };
        }
    }
}
