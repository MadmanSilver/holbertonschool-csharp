using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength) {
        List<int> res = new List<int>();

        for (int i = 0; i < listLength; i++) {
            try {
                res.Add(list1[i] / list2[i]);
            } catch (DivideByZeroException) {
                Console.WriteLine("Cannot divide by zero");
                res.Add(0);
            } catch {
                Console.WriteLine("Out of range");
                return res;
            }
        }

        return res;
    }
}
