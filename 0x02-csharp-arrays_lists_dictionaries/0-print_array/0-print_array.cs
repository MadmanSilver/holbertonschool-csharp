using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] arr;

        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        arr = new int[size];

        for (int i = 0; i < size; i++) {
            Console.Write("{0:D}", i);
            if (i != size - 1)
                Console.Write(" ");
            arr[i] = i;
        }
        Console.WriteLine();

        return arr;
    }
}
