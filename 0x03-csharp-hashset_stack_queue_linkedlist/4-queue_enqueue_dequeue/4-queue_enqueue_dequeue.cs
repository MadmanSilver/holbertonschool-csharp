using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search) {
        Console.WriteLine("Number of items: {0:D}", aQueue.Count);

        if (aQueue.Count == 0) {
            Console.WriteLine("Queue is empty");
        } else {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }

        aQueue.Enqueue(newItem);

        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));

        if (aQueue.Contains(search)) {
            while (aQueue.Dequeue() != search);
        }

        return aQueue;
    }
}
