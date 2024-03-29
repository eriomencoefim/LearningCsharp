﻿
using System;
using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Enumerations;

namespace MagicDestroyers.Characters.Spellcasters
{
    using MagicDestroyers.Armors.Cloth;
    using MagicDestroyers.Weapons.Blunt;

    public class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Mage";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 20;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const Factions DEFAULT_FACTION = Factions.Spellcasters;
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private ClothRobe bodyArmor;
        private Staff weapon;

        public ClothRobe BodyArmor
        {
            get => this.bodyArmor;
            set => this.bodyArmor = value;
        }

        public Staff Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Mage(string name, int level)
            : base(name, level, DEFAULT_MANA_POINTS)
        {
        }

        public Mage(string name, int level, int manaPoints)
        : base(name,level,manaPoints)
        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}