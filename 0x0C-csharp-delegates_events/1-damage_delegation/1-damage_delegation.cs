using System;

/// <summary> Definition for a player. </summary>
public class Player {
    private string name;
    private float maxHp;
    private float hp;

    /// <summary> Sets up an instance of Player </summary>
    public Player(string name = "Player", float maxHp = 100f) {
        if (name != null)
            this.name = name;
        
        if (maxHp > 0) {
            this.maxHp = maxHp;
            this.hp = maxHp;
        } else {
            this.maxHp = 100f;
            this.hp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
    }

    /// <summary> Prints the current health of the player </summary>
    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary> Calculates the current health of the player </summary>
    public delegate void CalculateHealth(float amount);

    /// <summary> Prints the damage taken by the player </summary>
    public void TakeDamage(float damage) {
        if (damage < 0)
            damage = 0;

        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <summary> Prints the health healed by the player </summary>
    public void HealDamage(float heal) {
        if (heal < 0)
            heal = 0;

        Console.WriteLine($"{name} heals {heal} HP!");
    }
}