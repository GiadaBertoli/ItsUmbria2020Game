using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public abstract class Character
    {
        public string Name { get; set; } = "Player";
        public Gender Gender { get; set; }
        public CharacterType Type { get; set; }
    }
    public class Wizard : Character
    {

    }
    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
    public enum CharacterType
    {
        Human,
        Eif,
        Orc
    }

}
