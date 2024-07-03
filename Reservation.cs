using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Components.Data
{
    public abstract class Reservation
    {
        public string? PassengerName { get; protected set; }
        public string? Citizenship { get; protected set; }
        public Flight? ReservedFlight { get; protected set; }

        // Abstract method for confirming the reservation
        public abstract void ConfirmReservation();

        internal void CancelReservation()
        {
            throw new NotImplementedException();
        }
    }
}
