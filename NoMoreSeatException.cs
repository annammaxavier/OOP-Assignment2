using System.Runtime.Serialization;

namespace FlightApp.Components.Data
{
    [Serializable]
    internal class NoMoreSeatException : Exception
    {
        public NoMoreSeatException()
        {
        }

        public NoMoreSeatException(string? message) : base(message)
        {
        }

        public NoMoreSeatException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoMoreSeatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}