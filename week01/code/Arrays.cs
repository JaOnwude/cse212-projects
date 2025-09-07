public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'. For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}. Assume that length is a positive 
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Initialize a new double array with the specified length.
        // Step 2: Use a for loop to iterate from 1 to length (inclusive).
        // Step 3: For each iteration i (from 1 to length), calculate number * i and store it in the array at index (i-1).
        // Step 4: After the loop, return the array.

        double[] multiples = new double[length];
        for (int i = 1; i <= length; i++)
        {
            multiples[i - 1] = number * i;
        }
        return multiples;
        // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Check if the list is empty or amount is 0, but per problem, amount is 1 to data.Count, so proceed.
        // Step 2: Extract the last 'amount' elements into a new list using GetRange(data.Count - amount, amount).
        // Step 3: Remove the last 'amount' elements from the original list using RemoveRange(data.Count - amount, amount).
        // Step 4: Insert the extracted list at the beginning of the original list using InsertRange(0, extractedList).

        if (data.Count == 0 || amount == 0)
        {
            return; // Though per problem, amount is greater than or equals to (>=) 1, but safe.
        }
        List<int> lastPart = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, lastPart);
    }
}