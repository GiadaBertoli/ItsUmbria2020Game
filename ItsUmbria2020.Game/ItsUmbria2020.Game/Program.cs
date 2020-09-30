using ItsUmbria2020.OnlineGame.Library.Models.Characters;
using System;
using System.Reflection.PortableExecutable;

namespace ItsUmbria2020.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Wizard();
            PrintCharacters(new Wizard());
        }

        private static void PrintCharacters(Character character)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(character.Name);
            Console.ResetColor();
        }
    }
}