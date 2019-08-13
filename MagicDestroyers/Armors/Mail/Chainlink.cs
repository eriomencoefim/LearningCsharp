using System;

namespace MagicDestroyers.Armors.Mail
{
    public class Chainlink
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get { return this.armorPoints; }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.armorPoints = value;
                }
                else
                {
                    Console.WriteLine($"Error! Should be between 1 and 100!");
                    this.armorPoints = 1;
                }

            }
        }

        public Chainlink()
        {
            this.ArmorPoints = 10;
        }

    }
}