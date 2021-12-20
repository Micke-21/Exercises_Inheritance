using System;
using System.Runtime.Serialization;

namespace Exercises_Inheritance
{
    [Serializable]
    internal class InvalidSongSecondsException : Exception
    {
        public InvalidSongSecondsException()
        {
        }

        public InvalidSongSecondsException(string message) : base(message)
        {
        }

        public InvalidSongSecondsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidSongSecondsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}