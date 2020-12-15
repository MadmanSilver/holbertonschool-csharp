using System;

namespace Enemies
{
    /// <summary>
    /// The main Zombie Class.
    /// Defines a Zombie Enemy with health.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Vitality of the zombie.
        /// </summary>
        public int health;

        /// <summary>
        /// Creates a Zombie with 0 health.
        /// </summary>
        public Zombie() {
            health = 0;
        }

        /// <summary>
        /// Creates a Zombie with a given amount of health.
        /// </summary>
        public Zombie(int value) {
            if (value < 0) {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
        }
    }
}
