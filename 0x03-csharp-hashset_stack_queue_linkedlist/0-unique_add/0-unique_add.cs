using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList) {
        HashSet<int> set = new HashSet<int>(myList);
        int total = 0;

        foreach (int n in set) {
            total += n;
        }

        return total;
    }
}
