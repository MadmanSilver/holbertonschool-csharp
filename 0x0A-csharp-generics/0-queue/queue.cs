using System;

/// <summary> Generic Queue class. </summary>
class Queue<T> {
    /// <summary> Returns the type of the queue object. </summary>
    public Type CheckType() {
        return typeof(T);
    }
}
