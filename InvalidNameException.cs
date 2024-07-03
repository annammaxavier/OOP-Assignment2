using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Components.Data
{
    public class InvalidNameException
    {
        public InvalidNameException() : this("Invalid name provided.") { }

        public InvalidNameException(string v)
        {
            V = v;
        }

        public string V { get; }
    }
}
