```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
13th Gen Intel Core i7-13700KF, 1 CPU, 24 logical and 16 physical cores
.NET SDK 7.0.400
  [Host]             : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9167.0), X64 RyuJIT VectorSize=256


```
|                      Method |                Job |            Runtime | ListSize |          Mean |       Error |      StdDev |   Gen0 | Allocated |
|---------------------------- |------------------- |------------------- |--------- |--------------:|------------:|------------:|-------:|----------:|
|               **ForeachInList** |           **.NET 7.0** |           **.NET 7.0** |       **10** |      **5.445 ns** |   **0.0352 ns** |   **0.0330 ns** |      **-** |         **-** |
|         ForeachInEnumerable |           .NET 7.0 |           .NET 7.0 |       10 |     66.938 ns |   0.1589 ns |   0.1409 ns | 0.0025 |      40 B |
| ForeachInGenericIEnumerable |           .NET 7.0 |           .NET 7.0 |       10 |     68.550 ns |   0.7081 ns |   0.6624 ns | 0.0025 |      40 B |
|       ForeachInGenericIList |           .NET 7.0 |           .NET 7.0 |       10 |     68.080 ns |   0.5825 ns |   0.5449 ns | 0.0025 |      40 B |
|               ForeachInList | .NET Framework 4.8 | .NET Framework 4.8 |       10 |     23.759 ns |   0.0753 ns |   0.0704 ns |      - |         - |
|         ForeachInEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |       10 |     60.055 ns |   0.3314 ns |   0.2938 ns | 0.0063 |      40 B |
| ForeachInGenericIEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |       10 |     63.547 ns |   0.5429 ns |   0.5078 ns | 0.0063 |      40 B |
|       ForeachInGenericIList | .NET Framework 4.8 | .NET Framework 4.8 |       10 |     62.952 ns |   0.2396 ns |   0.2124 ns | 0.0063 |      40 B |
|               **ForeachInList** |           **.NET 7.0** |           **.NET 7.0** |      **100** |     **37.004 ns** |   **0.0992 ns** |   **0.0928 ns** |      **-** |         **-** |
|         ForeachInEnumerable |           .NET 7.0 |           .NET 7.0 |      100 |    575.119 ns |   2.4632 ns |   2.3041 ns | 0.0019 |      40 B |
| ForeachInGenericIEnumerable |           .NET 7.0 |           .NET 7.0 |      100 |    588.658 ns |   4.9573 ns |   4.6370 ns | 0.0019 |      40 B |
|       ForeachInGenericIList |           .NET 7.0 |           .NET 7.0 |      100 |    585.273 ns |   0.9626 ns |   0.7515 ns | 0.0019 |      40 B |
|               ForeachInList | .NET Framework 4.8 | .NET Framework 4.8 |      100 |    181.859 ns |   0.2878 ns |   0.2692 ns |      - |         - |
|         ForeachInEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |      100 |    508.654 ns |   0.8597 ns |   0.7179 ns | 0.0057 |      40 B |
| ForeachInGenericIEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |      100 |    529.362 ns |   0.4452 ns |   0.4164 ns | 0.0057 |      40 B |
|       ForeachInGenericIList | .NET Framework 4.8 | .NET Framework 4.8 |      100 |    533.717 ns |   3.2480 ns |   3.0381 ns | 0.0057 |      40 B |
|               **ForeachInList** |           **.NET 7.0** |           **.NET 7.0** |    **10000** |  **2,845.717 ns** |   **3.8087 ns** |   **3.5627 ns** |      **-** |         **-** |
|         ForeachInEnumerable |           .NET 7.0 |           .NET 7.0 |    10000 | 54,154.203 ns |  32.4249 ns |  30.3303 ns |      - |      40 B |
| ForeachInGenericIEnumerable |           .NET 7.0 |           .NET 7.0 |    10000 | 56,814.034 ns |  66.8705 ns |  62.5507 ns |      - |      40 B |
|       ForeachInGenericIList |           .NET 7.0 |           .NET 7.0 |    10000 | 56,429.038 ns | 317.7770 ns | 297.2488 ns |      - |      40 B |
|               ForeachInList | .NET Framework 4.8 | .NET Framework 4.8 |    10000 | 16,841.743 ns |  24.3009 ns |  22.7311 ns |      - |         - |
|         ForeachInEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |    10000 | 49,477.353 ns |  82.9215 ns |  77.5649 ns |      - |      40 B |
| ForeachInGenericIEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |    10000 | 50,923.471 ns | 508.3068 ns | 475.4705 ns |      - |      40 B |
|       ForeachInGenericIList | .NET Framework 4.8 | .NET Framework 4.8 |    10000 | 50,474.825 ns |  57.1024 ns |  53.4136 ns |      - |      40 B |
