using System;
using System.Collections.Generic;

namespace ABAFA.ui
{
    //realizar un programa que pida al usuario 3, eh indique cual numero es el mayo
    public static class ActionRegistry
    {
        private static readonly Dictionary<string, Action> _actions = new();

        public static void Register(string name, Action action)
        {
            if (_actions.ContainsKey(name))
                throw new InvalidOperationException($"Ya existe una acción con el nombre '{name}'.");

            _actions[name] = action;
        }

        public static void Unregister(string name)
        {
            _actions.Remove(name);
        }

        public static void Invoke(string name)
        {
            if (_actions.TryGetValue(name, out var action))
            {
                action.Invoke();
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró la acción '{name}'.");
            }
        }

        public static void List()
        {
            Console.WriteLine("Acciones registradas:");
            foreach (var key in _actions.Keys)
            {
                Console.WriteLine($"- {key}");
            }
        }

        public static bool Exists(string name) => _actions.ContainsKey(name);
    }
}
