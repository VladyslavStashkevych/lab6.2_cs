// Program.cs
// <Сташкевич Владислав>
// Лабораторна робота № 6.2
// Опрацювання одновимірних масивів ітераційними та рекурсивними способами
// Варіант 19

using System;

namespace ProgramNS {
    public class Program {
        static void Main(string[] args) {
            int []a;
            int n, max;

            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            a = new int[n];
            ArrayBuilder(a, 0);
            Console.Write("\nArray:");
            PrintArray(a, 0);

            max = MaxOddElement(a, 0, 0);
            if (max != 0)
                Console.WriteLine($"\nMax odd element: {max}\n");
            else
                Console.WriteLine("\nThere is no odd element in array.\n");
        }
        static int[] ArrayBuilder(int[] a, int i) {
            var rand = new Random();
            if (i >= a.Length)
                return a;
            a[i] = rand.Next(-1000, 1000);
            return ArrayBuilder(a, i + 1);
        }
        public static int MaxOddElement(int[] a, int i, int max) {
            if (i >= a.Length)
                return max;
            else if (a[i] % 2 == 1)
                if (max == 0) max = a[i];
                else if (a[i] > max) max = a[i];

            return MaxOddElement(a, i + 1, max);
        }
        static void PrintArray(int[] a, int i) {
            if (i < a.Length) {
                Console.Write($"{a[i]} ");
                PrintArray(a, i + 1);
            }
            else
                Console.WriteLine();
        }
    }
}
