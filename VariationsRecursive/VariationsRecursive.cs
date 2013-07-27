using System;

class VariationsRecursive
{
   static void Main()
    {
        int n = 3;
        int k = 2;
        arr = new int[k];
        PrintVariations(n, k);
    }
    static int[] arr;
    static void PrintVariations(int n, int k, int currentLoop = 0)
    {
        if (currentLoop == k)
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
                arr[currentLoop] = i;
                PrintVariations(n, k, currentLoop + 1);
            }
        }
    }

}