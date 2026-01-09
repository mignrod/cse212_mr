public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of size 'length' to store the multiples
        double[] multiples = new double[length];

        // Step 2: Use a loop to calculate each multiple and store it in the array
        // The first element will be 'number', the second 'number * 2', etc.
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return the array with the multiples
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Calculate the effective rotation amount of the list using the count of elements
        int n = data.Count;

        // Step 2: Use a loop to perform the rotation where i is less than amount
        for (int i = 0; i < amount; i++)
        {
            // Step 3: Remove the last element and insert it at the front of the list
            int lastElement = data[n - 1];
            data.RemoveAt(n - 1);
            data.Insert(0, lastElement);
        }
    }
}
