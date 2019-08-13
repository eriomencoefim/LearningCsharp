using System;
using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{

    public class Warrior : Melee
    {
        private const string DEFAULT_NAME = "Warrior";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 120;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        private Chainlink bodyArmor;
        private Axe weapon;

        public Chainlink BodyArmor
        {
            get => this.bodyArmor;
            set => this.bodyArmor = value;
        }
        public Axe Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            Console.WriteLine("1st warrior");
        }

        public Warrior(string name, int level)
            : base(name, level, DEFAULT_ABILITY_POINTS)
        {
            Console.WriteLine("2nd warrior");
        }

        public Warrior(string name, int level, int abilityPoints)
        : base(name , level,abilityPoints)
        {
            Console.WriteLine("3rd warrior");
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }

        public override void SayHello()
        {
            Console.WriteLine($"Arggg, Hi i am {base.Name}");
        }
    }
}