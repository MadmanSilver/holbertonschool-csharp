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

        ValidateHP(hp - damage);
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <summary> Prints the health healed by the player </summary>
    public void HealDamage(float heal) {
        if (heal < 0)
            heal = 0;

        ValidateHP(hp + heal);
        Console.WriteLine($"{name} heals {heal} HP!");
    }

    /// <summary> Sets the hp to a new value </summary>
    public void ValidateHP(float newHp) {
        if (newHp < 0) {
            hp = 0;
        } else if (newHp > maxHp) {
            hp = maxHp;
        } else {
            hp = newHp;
        }
    }

    /// <summary> Applies a modifier to a value </summary>
    public float ApplyModifier(float baseValue, Modifier modifier) {
        return baseValue * ((int)modifier * 0.5f);
    }
}

/// <summary> Modifier levels to apply </summary>
public enum Modifier {
    /// <summary> Weakest mod </summary>
    Weak=1,
    /// <summary> No mod </summary>
    Base,
    /// <summary> Strongest mod </summary>
    Strong
}

/// <summary> Calculates modifier values </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);