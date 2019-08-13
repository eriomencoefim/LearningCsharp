using System;
using System.Collections.Generic;
using System.Text;
using MagicDestroyers.Enumerations;

namespace MagicDestroyers.Characters
{
    public class Character
    {
        private Factions faction;
        private string name;

        private int healthPoints;
        private int level;

        public Factions Faction
        {
            get { return this.faction; }
            set { this.faction = Factions.Melee; }
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length <= 10 && value.Length >= 2)
                {
                    this.name = value;
                }
                else
                {
                    this.name = "No name";
                    Console.WriteLine("ERROR.Your name have less than 2 characters or more than 10 characters! ");
                }

            }
        }


        public int HealthPoints
        {
            get { return healthPoints; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.healthPoints = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR.Health points should be between 0 and 120");
                    Console.ResetColor();
                    this.healthPoints = 0;
                }
            }
        }

        public int Level
        {
            get { return this.level; }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR.Your level should be between 1 and 100");
                    Console.ResetColor();
                    this.level = 1;
                }
            }
        }

        public virtual void SayHello()
        {
            Console.WriteLine($"Hi, i am {this.name}!");
        }

        public Character()
        {

        }

        public Character(string name, int level)
        {
            Console.WriteLine("Character");
            this.Name = name;
            this.Level = level;
        }
    }
}
