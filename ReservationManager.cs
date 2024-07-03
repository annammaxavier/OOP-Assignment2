using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Components.Data
{
    public class ReservationManager
    {
        private List<Reservation> reservations;

        public ReservationManager(List<Reservation> reservations)
        {
            this.reservations = reservations;
        }

        public void MakeReservation(Flight flight, string passengerName, string citizenship)
        {
            // Example implementation: create a new reservation
            Reservation reservation = new ReservationImpl(passengerName, citizenship, flight);
            reservation.ConfirmReservation();
            reservations.Add(reservation);
        }

        public void CancelReservation(Reservation reservation)
        {
            // Example implementation: cancel an existing reservation
            reservation.CancelReservation();
            reservations.Remove(reservation);
        }

        public List<Reservation> GetReservationsByPassenger(string passengerName)
        {
            // Example implementation: retrieve reservations for a specific passenger
            return reservations.FindAll(r => r.PassengerName.Equals(passengerName, StringComparison.OrdinalIgnoreCase));
        }
    }
}

