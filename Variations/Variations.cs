using System;

class Variations
{
    static void Main()
    {
        var start = DateTime.Now;
        int n = 3;
        int k = 2;

        int count = (int)Math.Pow(n, k);  // The count of the variations is N^K (k slots with N choices)

        for (int i = 0; i < count; i++)
        {
            int[] permutations = ChanceBase(i, n, k);   // the new number is represented as array of digits (as the base might be much higher than 10)
            for (int j = 0; j < k; j++)
            {
               Console.Write(permutations[j] + 1 + " "); // +1 because we want our numeral system to start from 1 instead of 0
            }
            Console.WriteLine();
        }

        var end = DateTime.Now;
        var timeNeeded = end - start;
        Console.WriteLine("Time needed: {0}m:{1}s:{2}ms", timeNeeded.Minutes, timeNeeded.Seconds, timeNeeded.Milliseconds);

    }

    /// <summary>
    /// This method coverts a number to another numeral system and returns the new number as array of digits
    /// </summary>
    /// <param name="number">The number to be converted</param>
    /// <param name="newBase">The base of the numeral system that the number will be converted to</param>
    /// <param name="numberLenght">The lenght of digits the number will have ex: if set to 3: number 1 will be represented as 0 0 1 </param>
    /// <returns></returns>
    static int[] ChanceBase(int number, int newBase, int numberLenght)
    {
        int[] result = new int[numberLenght];
        for (int i = 0; i < numberLenght; i++)
        {
            result[numberLenght - 1 - i] = number % newBase;
            number /= newBase;
        }
        return result;
    }

}
