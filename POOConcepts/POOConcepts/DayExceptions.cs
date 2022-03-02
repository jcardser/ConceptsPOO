using System.Runtime.Serialization;

namespace POOConcepts
{
    [Serializable]
    internal class DayExceptions : Exception
    {
        public DayExceptions()
        {
        }

        public DayExceptions(string? message) : base(message)
        {
        }

        public DayExceptions(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DayExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}