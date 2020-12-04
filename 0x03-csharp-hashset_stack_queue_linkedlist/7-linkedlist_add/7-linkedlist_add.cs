using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n) {
        return myLList.AddFirst(n);
    }
}
