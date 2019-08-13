using System;
using System.Collections.Generic;
using System.Text;

namespace MagicDestroyers.Weapons
{
    public class Weapon
    {
        private int damage;

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.damage = value;
                }
                else
                {
                    Console.WriteLine($"Error! Should be between 1 and 100!");
                    this.damage = 1;
                }

            }
        }

        protected Weapon()
        {
            this.Damage = 10;
        }
    }
}
