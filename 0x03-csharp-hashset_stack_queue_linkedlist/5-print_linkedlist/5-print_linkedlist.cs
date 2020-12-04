using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size) {
        LinkedList<int> l = new LinkedList<int>();

        for (int i = 0; i < size; i++) {
            l.AddLast(i);
            Console.WriteLine("{0}", i);
        }

        return l;
    }
}
