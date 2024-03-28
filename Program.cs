int[] arr = Generators.GenerateRandom(100, 0, 100);
//Array.Sort(arr);
SortingAlgorithms.InsertionSort(arr);

foreach (var num in arr)
{
    Console.WriteLine(num);
}








