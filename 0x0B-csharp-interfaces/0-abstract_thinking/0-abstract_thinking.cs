using System;

/// <summary> Abstract base class </summary>
abstract class Base {
    public string name;

    /// <summary> Override of the ToString method. </summary>
    public override string ToString() {
        return $"{name} is a {this.GetType()}";
    }
}