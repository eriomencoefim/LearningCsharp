

using System;
using System.Data;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    using MagicDestroyers.Armors.Leather;

    public class Assasin : Melee
    {
        private const string DEFAULT_NAME = "Assasin";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FACTION = Factions.Melee;
        private readonly LeatherVest DEFAULT_BODY_ARMOR = new LeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private LeatherVest bodyArmor;
        private Sword weapon;

       

        public LeatherVest BodyArmor
        {
            get => this.bodyArmor;
            set => this.bodyArmor = value;
        }

        public Sword Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

        public Assasin()
        : this(DEFAULT_NAME , DEFAULT_LEVEL)
        {
        }

        public Assasin(string name , int level)
        : base (name , level,DEFAULT_ABILITY_POINTS)
        {
        }

        public Assasin(string name,int level,int abilityPoints)
        :base(name,level,abilityPoints)
        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void Bleed()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}