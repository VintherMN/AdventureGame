using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameClassLibrary
{
    public class Weapon
    {
        Random random = new Random();
        public string Name { get; set; }
        public int TopDamage { get; set; }
        // Crit chance 1-100 (%)
        public int CritChance { get; set; }


        /// <summary>
        /// Constructor for a Weapon
        /// </summary>
        /// <param name="wName">Name of the Weapon</param>
        /// <param name="wTopDamage">The most a weapon can hit for, must be an integer</param>
        /// <param name="wCritChance">Chance to critical hit. Is optional, defaults to 10(%)</param>
        public Weapon(string wName, int wTopDamage, int wCritChance = 10)
        {
            Name = wName;
            TopDamage = wTopDamage;
            CritChance = wCritChance;
            
        }

        // A Method to make an attack, which uses the CritCheck method to alter the damage, if it returns true
        public int SwingWeapon()
        {
            int Damage = random.Next(TopDamage) + 1;
            //Critical hit modifier
            if(CritCheck() == true)
            {
                Console.WriteLine("!Critical hit!");
                return Damage + 6;
            }
            Console.WriteLine($"Attack did {Damage} Damage");
            return Damage;
        }

        /// <summary>
        /// A method for checking if an attack was a critical hit.
        /// Crit chance is subtracted from 100, and if a random number between 1 and 100 is higher than the check for a crit, you crit.
        /// </summary>
        /// <returns>Returns true if hit is critcal</returns>
        private bool CritCheck()
        {
            int crit = 100 - CritChance;
            if(random.Next(1, 101) > crit)
            {
                return true;
            } 
            return false;
        }

        public override string ToString()
        {
            if (CritChance > 0)
            {
                return $"{Name} (1-{TopDamage} Damage, and {CritChance}% Chance to critically hit)";
            }
            return $"{Name} -- (Damage: 1-{TopDamage})";
        }
    }
}
