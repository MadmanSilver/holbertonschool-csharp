using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2) {
        HashSet<int> set1 = new HashSet<int>(list1);

        set1.SymmetricExceptWith(list2);
        List<int> res = new List<int>(set1);
        res.Sort();

        return res;
    }
}
