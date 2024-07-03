using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Components.Data
{
    public class InvalidFlightCodeException
    {
        public InvalidFlightCodeException() : this("Invalid flight code provided.") { }

        public InvalidFlightCodeException(string v)
        {
        }
    }
}

