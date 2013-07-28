using System;

class VariationStrings
{
    static void Main()
    {
        // This is an example of generating all variations of k elements

        string[] arr = { "Cherry", "Dollar", "BAR", "#7" };  // example of printing all variations of elements in a slot machine

        int k = 3;

        PrintVariations(arr, k);


    }

    /// <summary>
    /// This method prints all permutations of the members of an array
    /// </summary>
    static void PrintVariations<T>(T[] arr, int elementsCount)
    {

        int count = (int)Math.Pow(arr.Length, elementsCount);

        // This code generates all permutations of the indexes [0... arr.Lenght-1] and prints arr[index];
        for (int i = 0; i < count; i++)
        {
            int[] permutations = ChanceBase(i, arr.Length, elementsCount);
            for (int j = 0; j < elementsCount; j++)
            {
                Console.Write(arr[permutations[j]] + " ");
            }
            Console.WriteLine();
        }
    }


    /// <summary>
    /// This Method Returns the number represented in another numeral system as an array
    /// </summary>
    /// <param name="numberLenght">The lenght of the array ex: if set to 3: number 1 will be represented as 0 0 1 </param>
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
