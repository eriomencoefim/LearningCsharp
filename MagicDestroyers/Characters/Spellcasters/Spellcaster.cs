using System;
using System.Collections.Generic;
using System.Text;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        private int manaPoints;
        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    this.manaPoints = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("ERROR.Mana points should be in range of 120!");
                    Console.ResetColor();
                    this.manaPoints = 0;
                }
            }
        }

        public Spellcaster(string name, int level, int manaPoints)
            : base(name, level)
        {
            base.Name = name;
            base.Level = level;
            this.ManaPoints = manaPoints;
        }
    }
}
