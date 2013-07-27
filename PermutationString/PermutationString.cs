using System;

class Permutations
{
    static void Main()
    {
        string[] arr = { "Gosho", "Pesho", "Stamat", "Ivan" };
        int n = arr.Length;
        int count = (int)Math.Pow(n, n);

        for (int i = 0; i < count; i++)
        {
            int[] newNumber = ChanceBase(i, n, n);
            if (newNumber != null)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[newNumber[j]] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    static int[] ChanceBase(int number, int newBase, int numberLenght)
    {
        bool[] usedNumbers = new bool[newBase];
        int[] result = new int[numberLenght];
        for (int i = 0; i < numberLenght; i++)
        {
            int nextDigit = number % newBase;
            if (!usedNumbers[nextDigit])
            {
                result[numberLenght - 1 - i] = nextDigit;
                number /= newBase;
                usedNumbers[nextDigit] = true;
            }
            else
            {
                return null;
            }
        }
        return result;
    }

}
