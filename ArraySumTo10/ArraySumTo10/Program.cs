using System;
using System.Linq;

namespace ArraySumTo10
{

    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 1, 2, 4, 4, 5, 5, 5, 6, 7, 9 };
            int n = arr.Length;
            int sum = 10;
            printPairs(arr, n, sum);
        }

        static void printPairs(int[] arr, int n, int sum)
        {
            // Print the given array
            Console.WriteLine("Given array:");
            foreach (int a in arr)
            {
                Console.Write(a);
            }
            Console.WriteLine("\n");

            // 1) output all pairs (includes duplicates and the reversed ordered pairs)
            // Sort the array
            Array.Sort(arr);
            Console.WriteLine("1) output all pairs (includes duplicates and the reversed ordered pairs):");
            // Find all pairs that add to given sum
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        Console.Write("(" + arr[i] + ", " + arr[j] + ")" + "\n");
                    }  
                }  
            }

            // 2) output unique pairs only once (removes the duplicates but includes the reversed ordered pairs)
            Console.WriteLine();
            Console.WriteLine("2) output unique pairs only once (removes the duplicates but includes the reversed ordered pairs):");
            // Remove duplicates from array and creates a new array
            int[] dist = arr.Distinct().ToArray();
            // Get new array length
            int m = dist.Length;
            // Find all pairs from distinct array that add to given sum
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (dist[i] + dist[j] == sum)
                    {
                        Console.Write("(" + dist[i] + ", " + dist[j] + ")" + "\n");
                    }
                }
            }

            // 3) output the same combo pair only once (removes the reversed ordered pairs)
            Console.WriteLine();
            Console.WriteLine("3) output the same combo pair only once (removes the reversed ordered pairs):");
            // Find same combo pairs only once
            for (int i = 0; i < m; i++)
            {
                for (int j = i; j < m; j++)
                {
                    if (dist[i] + dist[j] == sum)
                    {
                        Console.Write("(" + dist[i] + ", " + dist[j] + ")" + "\n");
                    }
                }
            }




            
            Console.ReadLine();
        }
    }
}
