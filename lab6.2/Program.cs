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
            int n, index = -1;

            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            a = new int[n];
            ArrayBuilder(a, 0);
            Console.Write("\nArray:");
            PrintArray(a, 0);

            index = MaxOddElement(a, 0, 0, index);
            if (index != -1)
                Console.WriteLine($"\nMax odd element: {a[index]}\n");
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
        public static int MaxOddElement(int[] a, int i, int max, int indexMax) {
            if (i >= a.Length)
                return indexMax;
            else if (a[i] % 2 != 0)
                if (indexMax == -1) {
                    max = a[i];
                    indexMax = i;
                }
                else if (a[i] > max) {
                    max = a[i];
                    indexMax = i;
                }

            return MaxOddElement(a, i + 1, max, indexMax);
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
