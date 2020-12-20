using System;

/// <summary> Conatins object utility functions. </summary>
class Obj
{
    /// <summary> Checks if an object is an int. </summary>
    public static bool IsOfTypeInt(object obj) {
        if (obj.GetType() != typeof(int)) {
            return false;
        }

        return true;
    }
}
