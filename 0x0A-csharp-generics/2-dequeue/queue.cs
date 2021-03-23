using System;

/// <summary> Generic Queue class. </summary>
class Queue<T> {
    Node head = null;
    Node tail = null;
    int count = 0;

    /// <summary> Returns the type of the queue object. </summary>
    public Type CheckType() {
        return typeof(T);
    }

    /// <summary> Adds a new node to the end of the queue. </summary>
    public void Enqueue(T value) {
        if (count == 0) {
            head = new Node(value);
            tail = head;
        } else {
            tail.next = new Node(value);
            tail = tail.next;
        }
        count++;
    }

    /// <summary> Removes the first node in the queue and returns it's value. </summary>
    public T Dequeue() {
        if (count != 0) {
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }

        Console.WriteLine("Queue is empty");
        return default(T);
    }

    /// <summary> Returns the number of items in the queue. </summary>
    public int Count() {
        return count;
    }

    /// <summary> Node class for items in a queue. </summary>
    public class Node {
        public T value = default(T);
        public Node next = null;

        /// <summary> Creates a new Node and sets the value. </summary>
        public Node(T value) {
            this.value = value;
        }
    }
}
