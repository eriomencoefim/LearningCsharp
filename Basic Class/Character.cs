using System;
using System.Collections.Generic;
using System.Text;
using Basic_Class.Weapons.Sharp;

namespace Basic_Class
{
    public class Character
    {
        private int damage;
        private int healthpoints;
        private string name;
        private int level;
        private Sword weapon;

        public int Damage
        {
            get { return this.damage; }

            private set { this.damage = value; }

        }

        public int Level
        {
            get => level;
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.level = value;
                }
            }
        }

        public int HealthPoints
        {
            get => this.healthpoints;
            set => healthpoints = value;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public Sword Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

        public Character()
        {

        }
        public Character(int damage)
        {
            this.Damage = damage;
        }

        public void Move()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I'm moving ");
            }
        }
    }
}