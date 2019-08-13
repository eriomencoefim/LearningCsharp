
namespace MagicDestroyers.Characters.Melee
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Melee : Character
    {
        private int abilityPoints;
        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("ERROR.Health points should be in range of 120!");
                    Console.ResetColor();
                    this.abilityPoints = 0;
                }
            }
        }

        public Melee(string name, int level, int abilityPoints)
        : base(name,level)
        {
            Console.WriteLine("Melee");
            base.Name = name;
            base.Level = level;
            this.AbilityPoints = abilityPoints;
        }
    }
}
