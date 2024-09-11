using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameClassLibrary
{
    // Valid classes for a character
    public enum PlayerClass
    {
        Warrior,
        Wizard,
        Theif
    }
    
    public class PlayerCharacter : Creature
    {
        public int ExperiencePoints {  get; set; }
        public int Level {
            get
                {
                    return ExperiencePoints / 1000 + 1;
                }
            }
        public PlayerClass PlayerClass { get; set; }

        public PlayerCharacter(string name, PlayerClass playerClass, Weapon weapon, int hitPoints = 20) : base(name, weapon, hitPoints)
        {
            Name = name;
            PlayerClass = playerClass;
        }

        public override string ToString()
        {
            return $"Player: Level {Level} {PlayerClass}. \nName: {Name}\nHP: {HitPoints}\nGold: {Gold}g\nExp: {ExperiencePoints}\nWeapon: {Weapon.ToString()}";
        }

    }
}
