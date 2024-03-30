public class SortingAlgorithms
{
    public static void QuickSortClassical(int[] array)
    {
        QuickSortClassical(array, 0, array.Length - 1);
    }

    public static void QuickSortClassical(int[] array, int start, int end)
    {
        int _start = start;
        int _end = end;

        int pivot = array[(start + end) / 2];

        while (_start <= _end)
        {
            while (array[_start] < pivot)
                _start++;

            while (array[_end] > pivot)
                _end--;

            if (_start <= _end)
            {
                var temp = array[_start];
                array[_start++] = array[_end];
                array[_end--] = temp;
            }
        }

        if (_end > start)
            QuickSortClassical(array, start, _end);

        if (_start < end)
            QuickSortClassical(array, _start, end);
    }

    public static void Merge(int[] array, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] tempLeft = new int[n1];
        int[] tempRight = new int[n2];

        int i, j;
        for (i = 0; i < n1; ++i)
        {
            tempLeft[i] = array[left + i];
        }
        for (j = 0; j < n2; ++j)
        {
            tempRight[j] = array[middle + 1 + j];
        }

        i = 0;
        j = 0;

        int k = left;
        while (i < n1 && j < n2)
        {
            if (tempLeft[i] <= tempRight[j])
            {
                array[k] = tempLeft[i];
                i++;
            }
            else
            {
                array[k] = tempRight[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            array[k] = tempLeft[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            array[k] = tempRight[j];
            j++;
            k++;
        }
    }
    public static void MergeSort(int[] array)
    {
        MergeSort(array, 0, array.Length - 1);
    }
    public static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);

            Merge(array, left, middle, right);
        }
    }

    public static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }
}