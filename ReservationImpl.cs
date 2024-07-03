namespace FlightApp.Components.Data
{
    internal class ReservationImpl : Reservation
    {
        private Flight flight;

        public ReservationImpl(string passengerName, string citizenship, Flight flight)
        {
            PassengerName = passengerName;
            Citizenship = citizenship;
            this.flight = flight;
        }

        public override void ConfirmReservation()
        {
            throw new NotImplementedException();
        }
    }
}