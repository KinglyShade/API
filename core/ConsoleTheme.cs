using System; 
namespace ABAFA.core
{
    public class ConsoleTheme
    {
        public ConsoleColor InfoColor { get; set; } = ConsoleColor.Cyan;
        public ConsoleColor WarningColor { get; set; } = ConsoleColor.Yellow;
        public ConsoleColor ErrorColor { get; set; } = ConsoleColor.Red;
        public ConsoleColor SuccessColor { get; set; } = ConsoleColor.Green;
        public ConsoleColor DefaultColor { get; set; } = ConsoleColor.Gray;

        public string Border { get; set; } = "─";
        public bool CenterText { get; set; } = false;
    }
}
