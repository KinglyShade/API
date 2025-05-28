using System; 
namespace ABAFA.core
{
    public static class ConsoleMessage
    {
        private static ConsoleTheme _theme = new();

        public static void Configure(ConsoleTheme theme)
        {
            _theme = theme;
        }

        public static void Show(string message, MessageType type, bool? center = null)
        {
            ConsoleColor color = _theme.DefaultColor;
            string prefix = "";

            switch (type)
            {
                case MessageType.Info:
                    color = _theme.InfoColor;
                    prefix = "[ℹ] ";
                    break;
                case MessageType.Warning:
                    color = _theme.WarningColor;
                    prefix = "[⚠] ";
                    break;
                case MessageType.Error:
                    color = _theme.ErrorColor;
                    prefix = "[✖] ";
                    break;
                case MessageType.Success:
                    color = _theme.SuccessColor;
                    prefix = "[✔] ";
                    break;
            }

            Console.ForegroundColor = color;

            string fullMessage = prefix + message;
            bool doCenter = center ?? _theme.CenterText;

            if (!string.IsNullOrEmpty(_theme.Border))
                Console.WriteLine(_theme.Border.PadLeft(Console.WindowWidth, _theme.Border[0]));

            if (doCenter)
                Console.WriteLine(fullMessage.PadLeft((Console.WindowWidth + fullMessage.Length) / 2));
            else
                Console.WriteLine(fullMessage);

            if (!string.IsNullOrEmpty(_theme.Border))
                Console.WriteLine(_theme.Border.PadLeft(Console.WindowWidth, _theme.Border[0]));

            Console.ResetColor();
        }
    }
}
