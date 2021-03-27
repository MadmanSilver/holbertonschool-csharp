using System;

/// <summary> Abstract base class </summary>
abstract class Base {
    public string name;

    public override string ToString() {
        return $"{name} is a {this.GetType()}";
    }
}