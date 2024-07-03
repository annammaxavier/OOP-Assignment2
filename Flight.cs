using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Components.Data
{
    public abstract class Flight
    {
        public string? FlightCode { get; protected set; }
        public string? Airline { get; protected set; }
        public string? DepartureAirport { get; protected set; }
        public string? DestinationAirport { get; protected set; }
        public DateTime DepartureTime { get; protected set; }
        public int Capacity { get; protected set; }
        public decimal Price { get; protected set; }

        // Abstract method for calculating available seats
        public abstract int AvailableSeats();
    }
}

