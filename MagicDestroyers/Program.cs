using System;
using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Weapons.Sharp;

namespace MagicDestroyers
{
    class Program
    {
        static void Main()
        {
            Character warriorAsCharacter = new Warrior();
            warriorAsCharacter.Faction = Factions.Melee;
            warriorAsCharacter.HealthPoints = 100;
            warriorAsCharacter.Level = 1;
            warriorAsCharacter.Name = "joe";
            warriorAsCharacter.SayHello();

            Warrior convertedWarriorFromCharacter = (Warrior)warriorAsCharacter;


            Melee warriorAsMelee = new Warrior();
            // all from Character, and +
            warriorAsMelee.AbilityPoints = 200;
            Warrior convertedWarriorFromMelee = (Warrior)warriorAsMelee;


            Warrior warrior = new Warrior();
            // all from Character, Melee and +
            warrior.BodyArmor = new Chainlink();
            warrior.Weapon = new Axe();
            warrior.SayHello();
            
        }
    }

}
