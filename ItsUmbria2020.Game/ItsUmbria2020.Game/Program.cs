using ItsUmbria2020.OnlineGame.Library.Models.Characters;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace ItsUmbria2020.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            Warrior warrior = new Warrior();
            Wizard wizard = new Wizard();
            Rogue rogue = new Rogue();
            Paladin paladin = new Paladin();
            characters.Add(warrior);
            characters.Add(wizard);
            characters.Add(rogue);
            characters.Add(paladin);

            //wizard.ThrowFireBall(warrior);

            foreach (Character character in characters)
            {
                character.PrintInfo();
            }
        }
    }
}