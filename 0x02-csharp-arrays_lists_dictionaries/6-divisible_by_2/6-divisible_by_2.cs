using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList) {
        List<bool> bl = new List<bool>();

        foreach (int num in myList) {
            bl.Add(num % 2 == 0);
        }

        return bl;
    }
}
