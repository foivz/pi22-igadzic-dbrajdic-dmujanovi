using System;
using System.Runtime.Serialization;

namespace E_videoteka
{
    [Serializable]
    internal class StanjeServisaException : Exception
    {
        public StanjeServisaException()
        {
        }

        public StanjeServisaException(string message) : base(message)
        {
        }

        public StanjeServisaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StanjeServisaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}