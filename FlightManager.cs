namespace FlightApp.Components.Data
{
    public class FlightManager
    {
        private List<Flight> flights;

        public FlightManager(List<Flight> flights)
        {
            this.flights = flights;
        }

        public List<Flight> GetAllFlights()
        {
            return flights;
        }

        public List<Flight> SearchFlights(string departure, string destination, DateTime date)
        {
            // Example implementation: searching flights based on departure, destination, and date
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return flights.Where(f => !(!f.DepartureAirport.Equals(departure, StringComparison.OrdinalIgnoreCase)
                    || !f.DestinationAirport.Equals(destination, StringComparison.OrdinalIgnoreCase)
                    || f.DepartureTime.Date != date.Date))
                .ToList();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        public void BookFlight(Flight flight, string passengerName, string citizenship)
        {
            // Example implementation: book the flight if seats are available
            if (flight.AvailableSeats() > 0)
            {
                Reservation reservation = new ReservationImpl(passengerName, citizenship, flight);
                reservation.ConfirmReservation();
            }
            else
            {
                throw new NoMoreSeatException("No more seats available on this flight.");
            }
        }
    }
}
