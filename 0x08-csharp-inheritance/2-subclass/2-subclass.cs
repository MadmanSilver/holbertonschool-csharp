using System;

/// <summary> Conatins object utility functions. </summary>
class Obj
{
    /// <summary> Checks if a type is a subclass of another type. </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType) {
        if (derivedType.IsSubclassOf(baseType)) {
            return true;
        }

        return false;
    }
}
