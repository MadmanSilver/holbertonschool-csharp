using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n) {
        foreach (int node in myLList) {
            if (n < node) {
                return myLList.AddBefore(myLList.Find(node), n);
            }
        }
        return myLList.AddLast(n);
    }
}
