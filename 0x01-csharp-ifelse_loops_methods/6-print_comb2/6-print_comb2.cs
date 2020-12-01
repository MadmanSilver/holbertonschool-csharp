using System;

class Program
{
    static void Main(string[] args)
    {
        for (int a = 0; a < 8; a++) {
            for (int b = a + 1; b < 10; b++) {
                Console.Write("{0:D}{1:D}, ", a, b);
            }
        }
        Console.WriteLine("89");
    }
}
