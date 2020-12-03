using System;

class Array
{
    public static void Reverse(int[] array) {
        int i;

        if (array != null) {
            for (i = array.Length - 1; i >= 0; i--) {
                Console.Write("{0:D}", array[i]);
                if (i != 0) {
                    Console.Write(" ");
                }
            }
        }

        Console.WriteLine();
    }
}
