using System;

namespace ABAFA.exeptions
{
    public enum ConsoleExceptionType
    {
        Info,
        Warning,
        Error,
        Critical
    }

    public class ConsoleException : Exception
    {
        public ConsoleExceptionType Type { get; }

        public ConsoleException(string message, ConsoleExceptionType type = ConsoleExceptionType.Error)
            : base(message)
        {
            Type = type;
        }
    }
}
