int[] arr = Generators.GenerateFewUnique(100, 0, 100);
Array.Sort(arr);
foreach (var num in arr)
{
    Console.WriteLine(num);
}