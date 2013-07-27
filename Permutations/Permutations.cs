using System;

class Permutations
{
    static void Main()
    {
        int n = 4;
        int count = (int)Math.Pow(n, n); 

        for (int i = 0; i < count; i++)
        {
            int[] newNumber = ChanceBase(i, n, n); 
            if (newNumber != null)  
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(newNumber[j] + 1 + " ");
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
