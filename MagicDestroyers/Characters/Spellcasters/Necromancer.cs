
 using System;
    using MagicDestroyers.Armors.Leather;
 using MagicDestroyers.Enumerations;
 using MagicDestroyers.Weapons.Sharp;


 namespace MagicDestroyers.Characters.Spellcasters
{
   
    public class Necromancer : Spellcaster
    {
        private const string DEFAULT_NAME = "Necromancer";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 70;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const Factions DEFAULT_FACTION = Factions.Spellcasters;
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

        public Necromancer()
            : this(DEFAULT_NAME,DEFAULT_LEVEL )
        {
        }

        public Necromancer(string name, int level)
            : base(name, level, DEFAULT_MANA_POINTS)
        {
        }

        public Necromancer(string name, int level, int manaPoints)
        : base(name,level,manaPoints)
        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }
        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}