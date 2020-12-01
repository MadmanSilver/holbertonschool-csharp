using System;

class Line
{
    public static void PrintDiagonal(int length) {
        for (int i = 0; i < length; i++) {
            for (int s = 0; s < i; s++) {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
        Console.WriteLine();
    }
}
