using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Benchmarks
{
    public IEnumerable<int[]> SmallArray()
    {
        yield return Generators.GenerateRandom(10, 0, 100000);
        yield return Generators.GenerateSorted(10, 0, 100000);
        yield return Generators.GenerateReversed(10, 0, 100000);
        yield return Generators.GenerateAlmostSorted(10, 0, 100000);
        yield return Generators.GenerateFewUnique(10, 0, 100000);
    }
    public IEnumerable<int[]> MediumArray()
    {
        yield return Generators.GenerateRandom(1000, 0, 100000);
        yield return Generators.GenerateSorted(1000, 0, 100000);
        yield return Generators.GenerateReversed(1000, 0, 100000);
        yield return Generators.GenerateAlmostSorted(1000, 0, 100000);
        yield return Generators.GenerateFewUnique(1000, 0, 100000);
    }
    public IEnumerable<int[]> BigArray()
    {
        yield return Generators.GenerateRandom(100000, 0, 100000);
        yield return Generators.GenerateSorted(100000, 0, 100000);
        yield return Generators.GenerateReversed(100000, 0, 100000);
        yield return Generators.GenerateAlmostSorted(100000, 0, 100000);
        yield return Generators.GenerateFewUnique(100000, 0, 100000);
    }

    // InsertionSort
    [Benchmark]
    [ArgumentsSource(nameof(SmallArray))]
    public void TestInsertionSort(int[] array)
    {
        SortingAlgorithms.InsertionSort(array);
    }
    [Benchmark]
    [ArgumentsSource(nameof(MediumArray))]
    public void TestInsertionSortMediumArray(int[] array)
    {
        SortingAlgorithms.InsertionSort(array);
    }
    [Benchmark]
    [ArgumentsSource(nameof(BigArray))]
    public void TestInsertionSortBigArray(int[] array)
    {
        SortingAlgorithms.InsertionSort(array);
    }

    // QuickSortClassical
    [Benchmark]
    [ArgumentsSource(nameof(SmallArray))]
    public void TestQuickSortClassicalSmallArray(int[] array)
    {
        SortingAlgorithms.QuickSortClassical(array);
    }
    [Benchmark]
    [ArgumentsSource(nameof(MediumArray))]
    public void TestQuickSortClassicalMediumArray(int[] array)
    {
        SortingAlgorithms.QuickSortClassical(array);
    }
    [Benchmark]
    [ArgumentsSource(nameof(BigArray))]
    public void TestQuickSortClassicalBigArray(int[] array)
    {
        SortingAlgorithms.QuickSortClassical(array);
    }

    // MergeSort
    [Benchmark]
    [ArgumentsSource(nameof(SmallArray))]
    public void TestMergeSortSmallArray(int[] array)
    {
        SortingAlgorithms.MergeSort(array);
    }
    [Benchmark]
    [ArgumentsSource(nameof(MediumArray))]
    public void TestMergeSortMediumArray(int[] array)
    {
        SortingAlgorithms.MergeSort(array);
    }
    [Benchmark]
    [ArgumentsSource(nameof(BigArray))]
    public void TestMergeSortBigArray(int[] array)
    {
        SortingAlgorithms.MergeSort(array);
    }

    // Array.Sort
    [Benchmark]
    [ArgumentsSource(nameof(SmallArray))]
    public void TestArraySortSmallArray(int[] array)
    {
        Array.Sort(array);
    }
    [Benchmark]
    [ArgumentsSource(nameof(MediumArray))]
    public void TestArraySortMediumArray(int[] array)
    {
        Array.Sort(array);
    }
    [Benchmark]
    [ArgumentsSource(nameof(BigArray))]
    public void TestArraySortBigArray(int[] array)
    {
        Array.Sort(array);
    }
}