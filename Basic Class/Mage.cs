
using System;
using Basic_Class.Weapons.Sharp;

namespace BasicClass.Character.Spellcaster.Mage
{
    public class Mage
    {
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_DAMAGE = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const string DEFAULT_NAME = "Bob";
        private int factions;
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

        public Mage(int damage, int healthPoints, string name, Sword weapon)
        {
            this.Damage = damage;
            this.HealthPoints = healthPoints;
            this.Name = name;
            this.weapon = weapon;
            this.Weapon = new Sword();
        }

        public void Greetings(string name)
        {
            Console.WriteLine($"{this.name} greets {name}");
        }

        public void Attack(Mage enemyMage)
        {
            enemyMage.HealthPoints -= Damage;
        }

        public static void GetAllDefaultInformation()
        {
            Console.WriteLine(DEFAULT_LEVEL);
        }
    }
}