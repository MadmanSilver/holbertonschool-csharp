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
    }
}
