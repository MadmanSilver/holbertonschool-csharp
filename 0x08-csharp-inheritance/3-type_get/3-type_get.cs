using System;
using System.Reflection;

/// <summary> Conatins object utility functions. </summary>
class Obj
{
    /// <summary> Prints all properties and methods of a type. </summary>
    public static void Print(object myObj) {
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (PropertyInfo prop in myObj.GetType().GetProperties()) {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach (MethodInfo meth in myObj.GetType().GetMethods()) {
            Console.WriteLine(meth.Name);
        }
    }
}
