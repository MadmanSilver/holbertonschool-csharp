using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n) {
        int i = 0;

        foreach (int node in myLList) {
            if (i == n) {
                return node;
            }
            i++;
        }

        return 0;
    }
}
