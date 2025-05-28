using ABAFA.core;

namespace ABAFA.exeptions
{
    public static class ExceptionManager
    {
        public static void Handle(ConsoleException ex)
        {
            MessageType type = ex.Type switch
            {
                ConsoleExceptionType.Info => MessageType.Info,
                ConsoleExceptionType.Warning => MessageType.Warning,
                ConsoleExceptionType.Critical => MessageType.Error,
                _ => MessageType.Error
            };

            ConsoleMessage.Show($"Excepción: {ex.Message}", type);
        }
    }
}
