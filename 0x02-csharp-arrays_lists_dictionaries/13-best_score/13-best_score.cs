using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList) {
        KeyValuePair<string, int> top = new KeyValuePair<string, int>("None", -1);

        foreach (KeyValuePair<string, int> pair in myList) {
            if (pair.Value > top.Value) {
                top = pair;
            }
        }

        return top.Key;
    }
}
