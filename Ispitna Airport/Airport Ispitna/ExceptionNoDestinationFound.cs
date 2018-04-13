using System;
using System.Runtime.Serialization;


namespace Airport_Ispitna
{
    [Serializable]
    internal class ExceptionNoDestinationFound : Exception
    {
        public ExceptionNoDestinationFound()
        {
            
        }

        public ExceptionNoDestinationFound(string message) : base(message)
        {
        }

        public ExceptionNoDestinationFound(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionNoDestinationFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}