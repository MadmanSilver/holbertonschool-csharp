using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] arr = new int[3][];
        arr[0] = new int[] {0, 1, 2, 3};
        arr[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
        arr[2] = new int[] {0, 1,};

        for (int y = 0; y < arr.GetLength(0); y++) {
            for (int x = 0; x < arr[y].Length; x++) {
                Console.Write("{0:D}", arr[y][x]);
                if (x != arr[y].Length - 1) {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
