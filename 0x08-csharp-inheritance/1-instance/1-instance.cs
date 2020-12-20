using System;

/// <summary> Conatins object utility functions. </summary>
class Obj
{
    /// <summary> Checks if an object is an array. </summary>
    public static bool IsInstanceOfArray(object obj) {
        if (!obj.GetType().IsArray) {
            return false;
        }

        return true;
    }
}
