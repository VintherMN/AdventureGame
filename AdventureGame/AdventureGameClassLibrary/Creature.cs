using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameClassLibrary
{
    public abstract class Creature
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public bool _isAlive;
        public Weapon Weapon { get; set; }
        internal static Random random = new Random();
        public int Gold { get; set; } = random.Next(25);

        public bool IsAlive
        {
            get { return _isAlive; }
            set
            {
                if (HitPoints > 0)
                {
                    _isAlive = true;
                }
            }
        }

        /// <summary>
        /// This is the constructor for a Creature
        /// </summary>
        /// <param name="CreatureName">Name of the creature (Required)</param>
        /// <param name="weapon">A Weapon for the Creature (Optional, defaults to null if no weapon)</param>
        /// <param name="hp">HitPoints of the Creature (Optional, defaults to 15hp)</param>
        public Creature(string CreatureName, Weapon weapon = null, int hp = 15)
        {
            Name = CreatureName;
            Weapon = weapon;
            HitPoints = hp;

        }

        // Attack does 1 damage if no weapon, otherwise use properties from the weapon
        public int Attack()
        {
            if (Weapon != null)
            {
                return Weapon.SwingWeapon();
            }

            return 1;
        }

        protected string GetWeaponName()
        {
            string weaponName = "No Weapon Equipped";
            if (Weapon != null)
            {
                weaponName = $"{Weapon.Name}";
            }
            return weaponName;
        }

        public override string ToString()
        {
            return $"Creature: {GetType().Name}. Name: {Name}. HP: {HitPoints}. Weapon: {GetWeaponName()}.";
        }
    }
}
