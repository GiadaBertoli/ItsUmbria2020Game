using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.OnlineGame.Library.Models.Characters
{
    public class Warrior : Character
    {
        public Warrior() : base()
        {
        }
        public Warrior(string name) : base(name)
        {
        }

        public override int MaxHealth => 130;
        public override int MaxMana => 20;
    }
}