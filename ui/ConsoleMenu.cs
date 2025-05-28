using System;
using System.Collections.Generic;

namespace ABAFA.ui
{
    public static class ConsoleMenu
    {
        public static void Show(string title, Dictionary<string, Action> options)
        {
            Console.WriteLine(title);
            foreach (var option in options)
            {
                Console.WriteLine(option.Key);
            }

            Console.Write("\n> ");
            string? input = Console.ReadLine();

            foreach (var option in options)
            {
                if (option.Key.StartsWith(input ?? ""))
                {
                    option.Value.Invoke();
                    return;
                }
            }

            Console.WriteLine("Opción inválida.");
        }
    }
}
