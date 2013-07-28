using System;


class Permutations
{
    static void Main()
    {
        // This is an example of generating all permutations of the members of a string array
        // example: we have an array of 4 names that take part in a competition and we and we want to print all possible outcomes of the game
        string[] arr = { "Gosho", "Pesho", "Stamat", "Ivan" };
        PrintAllPermutations(arr);
    }



    /// <summary>
    /// This method prints all permutations of the members of an array
    /// </summary>
    static void PrintAllPermutations<T>(T[] arr)
    {
        int n = arr.Length;
        int count = (int)Math.Pow(n, n);

        // This code generates all permutations of the indexes [0... arr.Lenght-1] without repeating indexes and printing arr[index]
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

    /// <summary>
    /// This Method Returns the number represented in another numeral system as an array
    /// </summary>
    /// <param name="numberLenght">The lenght of the array ex: if set to 3: number 1 will be represented as 0 0 1 </param>
    /// <returns></returns>
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
