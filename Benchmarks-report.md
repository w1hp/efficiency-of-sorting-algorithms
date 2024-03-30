```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4170/22H2/2022Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.201
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2


```
| Method                            | array         | Mean             | Error          | StdDev         | Gen0      | Gen1     | Gen2     | Allocated  |
|---------------------------------- |-------------- |-----------------:|---------------:|---------------:|----------:|---------:|---------:|-----------:|
| **TestInsertionSortBigArray**         | **Int32[100000]** |    **187,604.89 ns** |     **976.411 ns** |     **865.563 ns** |         **-** |        **-** |        **-** |          **-** |
| TestInsertionSortBigArray         | Int32[100000] |    187,194.17 ns |     431.630 ns |     382.629 ns |         - |        - |        - |          - |
| TestInsertionSortBigArray         | Int32[100000] |    306,266.67 ns |   5,968.188 ns |   9,466.179 ns |         - |        - |        - |      400 B |
| TestInsertionSortBigArray         | Int32[100000] |    279,999.85 ns |     585.841 ns |     489.204 ns |         - |        - |        - |          - |
| TestInsertionSortBigArray         | Int32[100000] |    280,119.92 ns |     947.334 ns |     886.136 ns |         - |        - |        - |          - |
| TestQuickSortClassicalBigArray    | Int32[100000] |  3,485,618.71 ns |  18,498.321 ns |  17,303.341 ns |         - |        - |        - |        2 B |
| TestQuickSortClassicalBigArray    | Int32[100000] |  3,106,660.69 ns |   5,195.434 ns |   4,605.617 ns |         - |        - |        - |        2 B |
| TestQuickSortClassicalBigArray    | Int32[100000] |  3,129,484.04 ns |   6,577.258 ns |   5,830.567 ns |         - |        - |        - |        2 B |
| TestQuickSortClassicalBigArray    | Int32[100000] |  3,098,608.93 ns |  17,721.598 ns |  16,576.793 ns |         - |        - |        - |        2 B |
| TestQuickSortClassicalBigArray    | Int32[100000] |  3,123,990.43 ns |   6,270.667 ns |   5,558.783 ns |         - |        - |        - |        2 B |
| TestMergeSortBigArray             | Int32[100000] | 10,995,575.52 ns |  35,710.866 ns |  27,880.695 ns | 2375.0000 | 234.3750 | 234.3750 | 12031269 B |
| TestMergeSortBigArray             | Int32[100000] | 11,068,032.81 ns | 120,083.444 ns | 106,450.846 ns | 2375.0000 | 234.3750 | 234.3750 | 12031269 B |
| TestMergeSortBigArray             | Int32[100000] | 10,655,320.91 ns |  73,817.462 ns |  61,640.924 ns | 2375.0000 | 234.3750 | 234.3750 | 12031269 B |
| TestMergeSortBigArray             | Int32[100000] |  9,954,567.19 ns |  60,612.575 ns |  53,731.469 ns | 2375.0000 | 234.3750 | 234.3750 | 12031269 B |
| TestMergeSortBigArray             | Int32[100000] | 10,922,896.46 ns |  77,062.112 ns |  72,083.948 ns | 2375.0000 | 234.3750 | 234.3750 | 12031269 B |
| TestArraySortBigArray             | Int32[100000] |  1,562,025.66 ns |   3,873.999 ns |   3,623.741 ns |         - |        - |        - |        1 B |
| TestArraySortBigArray             | Int32[100000] |  1,610,417.64 ns |   5,373.297 ns |   4,486.946 ns |         - |        - |        - |        1 B |
| TestArraySortBigArray             | Int32[100000] |  1,569,553.81 ns |   7,159.921 ns |   6,347.084 ns |         - |        - |        - |        1 B |
| TestArraySortBigArray             | Int32[100000] |  1,568,663.35 ns |   4,961.567 ns |   4,398.300 ns |         - |        - |        - |        1 B |
| TestArraySortBigArray             | Int32[100000] |  2,325,052.57 ns |   3,138.175 ns |   2,781.910 ns |         - |        - |        - |        2 B |
| **TestInsertionSortMediumArray**      | **Int32[1000]**   |      **2,793.74 ns** |       **2.494 ns** |       **2.211 ns** |         **-** |        **-** |        **-** |          **-** |
| TestInsertionSortMediumArray      | Int32[1000]   |      2,796.22 ns |       4.784 ns |       3.995 ns |         - |        - |        - |          - |
| TestInsertionSortMediumArray      | Int32[1000]   |      1,873.03 ns |       9.810 ns |       8.696 ns |         - |        - |        - |          - |
| TestInsertionSortMediumArray      | Int32[1000]   |      1,867.87 ns |       6.756 ns |       5.275 ns |         - |        - |        - |          - |
| TestInsertionSortMediumArray      | Int32[1000]   |      2,913.28 ns |      56.972 ns |      88.698 ns |         - |        - |        - |          - |
| TestQuickSortClassicalMediumArray | Int32[1000]   |     13,267.81 ns |     259.421 ns |     363.673 ns |         - |        - |        - |          - |
| TestQuickSortClassicalMediumArray | Int32[1000]   |     13,287.76 ns |     265.246 ns |     354.096 ns |         - |        - |        - |          - |
| TestQuickSortClassicalMediumArray | Int32[1000]   |     13,823.06 ns |     259.661 ns |     404.261 ns |         - |        - |        - |          - |
| TestQuickSortClassicalMediumArray | Int32[1000]   |     13,163.55 ns |     134.058 ns |     118.839 ns |         - |        - |        - |          - |
| TestQuickSortClassicalMediumArray | Int32[1000]   |     13,018.17 ns |     162.605 ns |     144.145 ns |         - |        - |        - |          - |
| TestMergeSortMediumArray          | Int32[1000]   |     71,780.42 ns |   1,380.101 ns |   3,587.067 ns |   19.5313 |        - |        - |    92304 B |
| TestMergeSortMediumArray          | Int32[1000]   |     69,148.66 ns |     671.344 ns |     560.602 ns |   19.5313 |        - |        - |    92304 B |
| TestMergeSortMediumArray          | Int32[1000]   |     65,059.38 ns |   1,205.638 ns |   1,184.097 ns |   19.5313 |        - |        - |    92304 B |
| TestMergeSortMediumArray          | Int32[1000]   |     67,798.94 ns |     497.723 ns |     441.219 ns |   19.5313 |        - |        - |    92304 B |
| TestMergeSortMediumArray          | Int32[1000]   |     71,372.85 ns |   1,310.118 ns |   2,460.718 ns |   19.5313 |        - |        - |    92304 B |
| TestArraySortMediumArray          | Int32[1000]   |      6,414.44 ns |      43.783 ns |      36.561 ns |         - |        - |        - |          - |
| TestArraySortMediumArray          | Int32[1000]   |      6,208.92 ns |      61.004 ns |      54.079 ns |         - |        - |        - |          - |
| TestArraySortMediumArray          | Int32[1000]   |      6,698.59 ns |     129.601 ns |     127.285 ns |         - |        - |        - |          - |
| TestArraySortMediumArray          | Int32[1000]   |      6,400.70 ns |      15.040 ns |      13.332 ns |         - |        - |        - |          - |
| TestArraySortMediumArray          | Int32[1000]   |      6,466.65 ns |      15.971 ns |      13.336 ns |         - |        - |        - |          - |
| **TestInsertionSort**                 | **Int32[10]**     |         **24.02 ns** |       **0.159 ns** |       **0.149 ns** |         **-** |        **-** |        **-** |          **-** |
| TestInsertionSort                 | Int32[10]     |         15.73 ns |       0.055 ns |       0.046 ns |         - |        - |        - |          - |
| TestInsertionSort                 | Int32[10]     |         15.84 ns |       0.157 ns |       0.146 ns |         - |        - |        - |          - |
| TestInsertionSort                 | Int32[10]     |         23.85 ns |       0.011 ns |       0.009 ns |         - |        - |        - |          - |
| TestInsertionSort                 | Int32[10]     |         23.55 ns |       0.149 ns |       0.132 ns |         - |        - |        - |          - |
| TestQuickSortClassicalSmallArray  | Int32[10]     |         53.76 ns |       0.109 ns |       0.102 ns |         - |        - |        - |          - |
| TestQuickSortClassicalSmallArray  | Int32[10]     |         52.69 ns |       0.098 ns |       0.077 ns |         - |        - |        - |          - |
| TestQuickSortClassicalSmallArray  | Int32[10]     |         51.15 ns |       0.107 ns |       0.090 ns |         - |        - |        - |          - |
| TestQuickSortClassicalSmallArray  | Int32[10]     |         51.03 ns |       0.291 ns |       0.243 ns |         - |        - |        - |          - |
| TestQuickSortClassicalSmallArray  | Int32[10]     |         52.06 ns |       0.076 ns |       0.059 ns |         - |        - |        - |          - |
| TestMergeSortSmallArray           | Int32[10]     |        343.06 ns |       1.049 ns |       0.876 ns |    0.1326 |        - |        - |      624 B |
| TestMergeSortSmallArray           | Int32[10]     |        328.31 ns |       1.235 ns |       1.031 ns |    0.1326 |        - |        - |      624 B |
| TestMergeSortSmallArray           | Int32[10]     |        339.56 ns |       1.206 ns |       1.069 ns |    0.1326 |        - |        - |      624 B |
| TestMergeSortSmallArray           | Int32[10]     |        330.83 ns |       1.293 ns |       1.147 ns |    0.1326 |        - |        - |      624 B |
| TestMergeSortSmallArray           | Int32[10]     |        340.72 ns |       0.919 ns |       0.815 ns |    0.1326 |        - |        - |      624 B |
| TestArraySortSmallArray           | Int32[10]     |         24.66 ns |       0.427 ns |       0.378 ns |         - |        - |        - |          - |
| TestArraySortSmallArray           | Int32[10]     |         25.80 ns |       0.048 ns |       0.038 ns |         - |        - |        - |          - |
| TestArraySortSmallArray           | Int32[10]     |         24.34 ns |       0.200 ns |       0.167 ns |         - |        - |        - |          - |
| TestArraySortSmallArray           | Int32[10]     |         24.04 ns |       0.284 ns |       0.252 ns |         - |        - |        - |          - |
| TestArraySortSmallArray           | Int32[10]     |         25.48 ns |       0.023 ns |       0.018 ns |         - |        - |        - |          - |
