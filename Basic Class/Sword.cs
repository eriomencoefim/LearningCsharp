using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Class.Weapons.Sharp
{
    public class Sword
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;

            }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    this.damage = value;
                }
                else
                {
                    this.damage = 1;
                    Console.WriteLine("Error ! Damage should be between 1 and 10");
                }
            }
        }

        public Sword()
        {
            this.Damage = 10;
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
