public static class Generators
{
    public static int[] GenerateRandom(int size, int minVal, int maxVal)
    {
        var random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(minVal, maxVal);
        }

        return array;
    }

    public static int[] GenerateSorted(int size, int minVal, int maxVal)
    {
        int[] array = GenerateRandom(size, minVal, maxVal);
        Array.Sort(array);
        return array;
    }

    public static int[] GenerateReversed(int size, int minVal, int maxVal)
    {
        int[] array = GenerateSorted(size, minVal, maxVal);
        Array.Reverse(array);
        return array;
    }

    public static int[] GenerateAlmostSorted(int size, int minVal, int maxVal)
    {
        int[] array = GenerateSorted(size, minVal, maxVal);
        var random = new Random();
        int swapCount = random.Next(size / 2);

        for (int i = 0; i < swapCount; i++)
        {
            int index1 = random.Next(size);
            int index2 = random.Next(size);

            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        return array;
    }
    public static int[] GenerateFewUnique(int size, int minVal, int maxVal)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(maxVal/4);
        }

        return array;
    }
}