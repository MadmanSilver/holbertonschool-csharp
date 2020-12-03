using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict) {
        List<string> keys = new List<string>(myDict.Keys);

        keys.Sort();

        foreach (string key in keys) {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
