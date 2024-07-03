using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Components.Data
{
    public class InvalidCitizenshipException
    {
        public InvalidCitizenshipException() : this("Invalid citizenship information provided.") { }

        public InvalidCitizenshipException(string v)
        {
        }
    }
}

