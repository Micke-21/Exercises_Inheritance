using System;
using System.Runtime.Serialization;

namespace Exercises_Inheritance
{
    [Serializable]
    internal class InvalidSongMinutesException : Exception
    {
        public InvalidSongMinutesException()
        {
        }

        public InvalidSongMinutesException(string message) : base(message)
        {
        }

        public InvalidSongMinutesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidSongMinutesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}