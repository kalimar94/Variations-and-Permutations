using System;

class PermutationsRecursive
{
   static void Main()
    {
        int n = 4;
        arr = new int[n];
        usedNumbers = new bool[n + 1];
        PrintPermutations(n);

    }
    public static int[] arr;
    static bool[] usedNumbers;
    static void PrintPermutations(int n, int loopsCount = 0)
    {
        if (loopsCount == n)
        {
            foreach (var item in arr)
            {

                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                if (usedNumbers[i])
                {
                    continue;
                }
                arr[loopsCount] = i;
                usedNumbers[i] = true;
                PrintPermutations(n, loopsCount + 1);
                usedNumbers[i] = false;

            }
        }
    }
}