using System;

namespace Enemies
{
    /// <summary>
    /// The main Zombie Class.
    /// Defines a Zombie Enemy with health and a name.
    /// </summary>
    public class Zombie
    {
        /// Vitality of the zombie.
        private int health;
        /// Name of the zombie.
        private string name = "(No name)";

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

        /// <summary>
        /// Returns the Zombie's health.
        /// </summary>
        public int GetHealth() {
            return health;
        }

        /// <summary>
        /// Vitality of the Zombie.
        /// </summary>
        public string Name {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Returns the string representation of the Zombie.
        /// </summary>
        public override string ToString()
        {
            return $"Zombie name: {name} / Total Health: {health}";
        }
    }
}
