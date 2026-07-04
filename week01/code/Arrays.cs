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
        // Step 1: Create a new double array with the size specified by 'length'.
        double[] result = new double[length];

        // Step 2: Use a for loop to calculate each multiple.
        for (int i = 0; i < length; i++) {
            // Step 3: Calculate the multiple by multiplying the base number by (i + 1).
            // For example, when i = 0, the first element will be number * 1.
            result[i] = number * (i + 1);
        }

        // Step 4: Return the populated array.
        return result;
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
        // Step 1: Check if the list is empty, has one element,
        // or if the rotation amount equals the list size to avoid unnecessary work.
        if (data.Count <= 1 || amount == data.Count) {
            return;
        }

        // Step 2: Calculate the split index from the end of the list.
        // The starting point of the segment moving to the front is data.Count - amount.
        int cutoffIndex = data.Count - amount;

        // Step 3: Extract the right-hand segment that needs to rotate to the front.
        List<int> rightPart = data.GetRange(cutoffIndex, amount);

        // Step 4: Remove that segment from the end of the original list.
        data.RemoveRange(cutoffIndex, amount);

        // Step 5: Insert the saved segment back at the beginning (index 0) of the original list.
        data.InsertRange(0, rightPart);
    }
}
