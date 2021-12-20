using System;
using System.Runtime.Serialization;

namespace Exercises_Inheritance
{
    [Serializable]
    internal class InvalidSongLengthException : Exception
    {
        public InvalidSongLengthException()
        {
        }

        public InvalidSongLengthException(string message) : base(message)
        {
        }

        public InvalidSongLengthException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidSongLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}