``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1288 (20H2/October2020Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-rc.2.21456.8
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  Job-IUEPPH : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT

Runtime=.NET 5.0  IterationCount=3  LaunchCount=3  
WarmupCount=3  

```
|                           Method |        Mean |        Error |       StdDev |      Median | Code Size |
|--------------------------------- |------------:|-------------:|-------------:|------------:|----------:|
|    Simd128LessThanOrEqual_double |    55.28 ns |     5.847 ns |     3.479 ns |    54.86 ns |      56 B |
|                Simd128Add_double |    51.59 ns |     5.635 ns |     3.353 ns |    50.95 ns |      55 B |
|           Simd128Subtract_double |    55.32 ns |    12.166 ns |     7.240 ns |    53.22 ns |      55 B |
|           Simd128Multiply_double |    49.18 ns |     1.724 ns |     1.026 ns |    49.01 ns |      55 B |
|             Simd128Divide_double | 1,685.41 ns | 1,971.303 ns | 1,173.091 ns | 2,439.90 ns |      55 B |
|                Simd128Min_double |    49.32 ns |     2.849 ns |     1.695 ns |    49.39 ns |      55 B |
|                Simd128Max_double |    47.34 ns |     1.562 ns |     0.930 ns |    47.46 ns |      55 B |
|              Simd128Equal_double |    50.01 ns |     3.201 ns |     1.905 ns |    50.37 ns |      56 B |
|           Simd128NotEqual_double |    51.35 ns |     5.377 ns |     3.200 ns |    51.43 ns |      56 B |
|        Simd256GreaterThan_double |    28.11 ns |     6.414 ns |     3.817 ns |    27.39 ns |      59 B |
|           Simd256LessThan_double |    31.30 ns |     5.515 ns |     3.282 ns |    31.34 ns |      59 B |
| Simd256GreaterThanOrEqual_double |    28.93 ns |     4.167 ns |     2.480 ns |    29.22 ns |      59 B |
|    Simd256LessThanOrEqual_double |    31.47 ns |     7.373 ns |     4.388 ns |    29.41 ns |      59 B |
|                Simd256Add_double |    30.96 ns |     5.692 ns |     3.387 ns |    32.28 ns |      58 B |
|           Simd256Subtract_double |    28.98 ns |     3.152 ns |     1.876 ns |    28.49 ns |      58 B |
|           Simd256Multiply_double |    29.17 ns |     3.537 ns |     2.105 ns |    28.24 ns |      58 B |
|             Simd256Divide_double | 1,166.37 ns |   273.265 ns |   162.616 ns | 1,064.06 ns |      58 B |
|                Simd256Min_double |    32.36 ns |     3.751 ns |     2.232 ns |    32.93 ns |      58 B |
|                Simd256Max_double |    29.53 ns |     2.109 ns |     1.255 ns |    29.54 ns |      58 B |
|              Simd256Equal_double |    28.53 ns |     3.122 ns |     1.858 ns |    27.85 ns |      59 B |
|           Simd256NotEqual_double |    27.62 ns |     2.900 ns |     1.726 ns |    27.51 ns |      59 B |
|    Simd64GreaterThanOrEqual_long |   463.38 ns |    95.085 ns |    56.583 ns |   434.68 ns |     232 B |
|       Simd64LessThanOrEqual_long |   449.12 ns |    59.402 ns |    35.349 ns |   447.99 ns |     232 B |
|                   Simd64Add_long |   242.84 ns |    31.038 ns |    18.470 ns |   237.53 ns |     144 B |
|              Simd64Subtract_long |   226.30 ns |    14.768 ns |     8.788 ns |   225.62 ns |     144 B |
|              Simd64Multiply_long |   220.53 ns |    11.833 ns |     7.042 ns |   219.94 ns |     145 B |
|                Simd64Divide_long |   945.14 ns |    38.146 ns |    13.603 ns |   949.86 ns |     145 B |
|                   Simd64Min_long |   312.90 ns |    17.876 ns |    10.638 ns |   315.07 ns |     178 B |
|                   Simd64Max_long |   296.49 ns |    26.248 ns |    15.620 ns |   298.27 ns |     178 B |
|                 Simd64Equal_long |   402.01 ns |    16.805 ns |    10.000 ns |   404.12 ns |     232 B |
|              Simd64NotEqual_long |          NA |           NA |           NA |          NA |         - |
|          Simd128GreaterThan_long |   271.84 ns |    25.620 ns |    15.246 ns |   269.48 ns |     394 B |
|             Simd128LessThan_long |   307.68 ns |    48.865 ns |    29.079 ns |   305.15 ns |     394 B |
|   Simd128GreaterThanOrEqual_long |          NA |           NA |           NA |          NA |         - |
|      Simd128LessThanOrEqual_long |          NA |           NA |           NA |          NA |         - |
|                  Simd128Add_long |    49.33 ns |     5.234 ns |     3.114 ns |    49.07 ns |      55 B |
|             Simd128Subtract_long |    49.09 ns |     2.117 ns |     1.260 ns |    49.22 ns |      55 B |
|             Simd128Multiply_long |   242.62 ns |    16.989 ns |    10.110 ns |   240.62 ns |     325 B |
|               Simd128Divide_long |   975.93 ns |   197.682 ns |    70.495 ns |   978.58 ns |     264 B |
|                  Simd128Min_long |   310.13 ns |    28.813 ns |    17.146 ns |   302.04 ns |     331 B |
|                  Simd128Max_long |   287.16 ns |    12.481 ns |     7.427 ns |   286.64 ns |     331 B |
|                Simd128Equal_long |   297.71 ns |    42.625 ns |    25.365 ns |   294.48 ns |     394 B |
|             Simd128NotEqual_long |          NA |           NA |           NA |          NA |         - |
|          Simd256GreaterThan_long |    25.42 ns |     2.576 ns |     1.533 ns |    25.26 ns |      59 B |
|             Simd256LessThan_long |          NA |           NA |           NA |          NA |         - |
|   Simd256GreaterThanOrEqual_long |          NA |           NA |           NA |          NA |         - |
|      Simd256LessThanOrEqual_long |          NA |           NA |           NA |          NA |         - |
|                  Simd256Add_long |    26.00 ns |     4.863 ns |     2.894 ns |    24.66 ns |      58 B |
|             Simd256Subtract_long |    26.40 ns |     3.046 ns |     1.812 ns |    25.85 ns |      58 B |
|             Simd256Multiply_long |   193.00 ns |    67.073 ns |    39.914 ns |   171.31 ns |     185 B |
|               Simd256Divide_long |   904.10 ns |    81.614 ns |    48.567 ns |   904.65 ns |     190 B |
|                  Simd256Min_long |   340.49 ns |    50.079 ns |    29.801 ns |   326.60 ns |     360 B |
|                  Simd256Max_long |   334.87 ns |    25.092 ns |    14.932 ns |   329.29 ns |     360 B |
|                Simd256Equal_long |    25.92 ns |     4.078 ns |     2.427 ns |    25.76 ns |      59 B |
|             Simd256NotEqual_long |          NA |           NA |           NA |          NA |         - |
|          Simd64GreaterThan_float |   852.26 ns |    88.477 ns |    52.651 ns |   863.71 ns |     290 B |
|             Simd64LessThan_float |   988.55 ns |   257.956 ns |   153.505 ns |   988.00 ns |     290 B |
|   Simd64GreaterThanOrEqual_float |   820.90 ns |    83.176 ns |    49.497 ns |   822.66 ns |     290 B |
|      Simd64LessThanOrEqual_float |   850.36 ns |    55.875 ns |    33.250 ns |   850.61 ns |     290 B |
|                  Simd64Add_float |   454.44 ns |    89.501 ns |    53.260 ns |   439.14 ns |     163 B |
|             Simd64Subtract_float |   412.54 ns |    43.062 ns |    25.626 ns |   410.95 ns |     163 B |
|             Simd64Multiply_float | 1,716.25 ns | 3,154.100 ns | 1,876.954 ns |   497.41 ns |     163 B |
|               Simd64Divide_float | 1,752.31 ns | 3,442.432 ns | 2,048.536 ns |   391.63 ns |     163 B |
|                  Simd64Min_float |   545.79 ns |    39.023 ns |    23.222 ns |   541.89 ns |     221 B |
|                  Simd64Max_float |   560.53 ns |   128.592 ns |    76.523 ns |   557.82 ns |     227 B |
|                Simd64Equal_float |   888.65 ns |   124.829 ns |    74.284 ns |   895.60 ns |     295 B |
|             Simd64NotEqual_float |   976.71 ns |    68.908 ns |    41.006 ns |   981.18 ns |     357 B |
|         Simd128GreaterThan_float |    50.31 ns |     3.114 ns |     1.853 ns |    50.50 ns |      56 B |
|            Simd128LessThan_float |    50.06 ns |     3.048 ns |     1.814 ns |    50.23 ns |      56 B |
|  Simd128GreaterThanOrEqual_float |    49.42 ns |     3.470 ns |     2.065 ns |    49.46 ns |      56 B |
|     Simd128LessThanOrEqual_float |    49.45 ns |     1.990 ns |     1.184 ns |    49.76 ns |      56 B |
|                 Simd128Add_float |    55.06 ns |    10.677 ns |     6.354 ns |    54.84 ns |      55 B |
|            Simd128Subtract_float |    49.55 ns |     4.508 ns |     2.683 ns |    49.45 ns |      55 B |
|            Simd128Multiply_float |   676.89 ns | 1,405.477 ns |   836.377 ns |   133.66 ns |      55 B |
|              Simd128Divide_float | 1,619.06 ns | 1,973.612 ns | 1,174.465 ns | 2,384.03 ns |      55 B |
|                 Simd128Min_float |    52.31 ns |     4.237 ns |     2.521 ns |    52.26 ns |      55 B |
|                 Simd128Max_float |    54.77 ns |     8.028 ns |     4.778 ns |    52.31 ns |      55 B |
|               Simd128Equal_float |    51.13 ns |     4.097 ns |     2.438 ns |    51.26 ns |      56 B |
|            Simd128NotEqual_float |    50.92 ns |     4.008 ns |     2.385 ns |    50.60 ns |      56 B |
|         Simd256GreaterThan_float |    29.02 ns |     3.369 ns |     2.005 ns |    28.75 ns |      59 B |
|            Simd256LessThan_float |    29.96 ns |    10.243 ns |     6.096 ns |    26.12 ns |      59 B |
|  Simd256GreaterThanOrEqual_float |    29.14 ns |     1.767 ns |     1.051 ns |    29.03 ns |      59 B |
|     Simd256LessThanOrEqual_float |    30.18 ns |     4.266 ns |     2.539 ns |    29.71 ns |      59 B |
|                 Simd256Add_float |    26.90 ns |     2.750 ns |     1.636 ns |    27.14 ns |      58 B |
|            Simd256Subtract_float |    28.71 ns |     5.707 ns |     3.396 ns |    28.98 ns |      58 B |
|            Simd256Multiply_float |   502.49 ns |   620.223 ns |   369.085 ns |   411.45 ns |      58 B |
|              Simd256Divide_float |   857.69 ns |   961.205 ns |   571.998 ns | 1,233.74 ns |      58 B |
|                 Simd256Min_float |    24.91 ns |     1.483 ns |     0.883 ns |    24.73 ns |      58 B |
|                 Simd256Max_float |    27.72 ns |     4.008 ns |     2.385 ns |    27.34 ns |      58 B |
|               Simd256Equal_float |    26.01 ns |     2.368 ns |     1.409 ns |    25.60 ns |      59 B |
|            Simd256NotEqual_float |    28.21 ns |     2.389 ns |     1.422 ns |    27.64 ns |      59 B |
|         Simd64GreaterThan_double |   448.15 ns |    35.472 ns |    21.109 ns |   452.34 ns |     252 B |
|            Simd64LessThan_double |   409.31 ns |    20.314 ns |    12.089 ns |   407.97 ns |     252 B |
|  Simd64GreaterThanOrEqual_double |   404.97 ns |    21.810 ns |    12.979 ns |   405.66 ns |     252 B |
|     Simd64LessThanOrEqual_double |   390.04 ns |    18.603 ns |    11.070 ns |   387.86 ns |     252 B |
|                 Simd64Add_double |   224.31 ns |    14.710 ns |     8.754 ns |   222.28 ns |     153 B |
|            Simd64Subtract_double |   231.59 ns |    13.293 ns |     7.911 ns |   231.49 ns |     153 B |
|            Simd64Multiply_double |   239.52 ns |    29.851 ns |    17.764 ns |   235.23 ns |     153 B |
|              Simd64Divide_double | 1,711.08 ns | 3,583.323 ns | 2,132.378 ns |   347.82 ns |     153 B |
|                 Simd64Min_double |   320.00 ns |    24.597 ns |    14.637 ns |   313.08 ns |     205 B |
|                 Simd64Max_double |   307.38 ns |    24.096 ns |    14.339 ns |   304.54 ns |     211 B |
|               Simd64Equal_double |   430.67 ns |    64.867 ns |    38.601 ns |   430.55 ns |     257 B |
|            Simd64NotEqual_double |   556.27 ns |    29.689 ns |    17.667 ns |   550.51 ns |     320 B |
|        Simd128GreaterThan_double |    50.30 ns |     6.393 ns |     3.804 ns |    49.90 ns |      56 B |
|           Simd128LessThan_double |    50.88 ns |     6.209 ns |     3.695 ns |    49.69 ns |      56 B |
| Simd128GreaterThanOrEqual_double |    50.59 ns |     3.497 ns |     2.081 ns |    49.62 ns |      56 B |
|             Simd256LessThan_uint |          NA |           NA |           NA |          NA |         - |
|   Simd256GreaterThanOrEqual_uint |          NA |           NA |           NA |          NA |         - |
|      Simd256LessThanOrEqual_uint |          NA |           NA |           NA |          NA |         - |
|                  Simd256Add_uint |    27.14 ns |     4.514 ns |     2.686 ns |    26.22 ns |      58 B |
|             Simd256Subtract_uint |    26.55 ns |     3.155 ns |     1.878 ns |    25.65 ns |      58 B |
|             Simd256Multiply_uint |   349.23 ns |    92.929 ns |    55.301 ns |   332.97 ns |     185 B |
|               Simd256Divide_uint |          NA |           NA |           NA |          NA |         - |
|                  Simd256Min_uint |          NA |           NA |           NA |          NA |         - |
|                  Simd256Max_uint |          NA |           NA |           NA |          NA |         - |
|                Simd256Equal_uint |    38.41 ns |    26.883 ns |    15.997 ns |    28.95 ns |      58 B |
|             Simd256NotEqual_uint |          NA |           NA |           NA |          NA |         - |
|            Simd64GreaterThan_int |   792.69 ns |    62.250 ns |    37.044 ns |   787.05 ns |     263 B |
|               Simd64LessThan_int |   856.75 ns |   188.540 ns |   112.197 ns |   789.15 ns |     263 B |
|     Simd64GreaterThanOrEqual_int |   857.34 ns |   181.847 ns |   108.214 ns |   806.94 ns |     263 B |
|        Simd64LessThanOrEqual_int |   798.58 ns |    82.251 ns |    48.946 ns |   775.83 ns |     263 B |
|                    Simd64Add_int |   378.52 ns |    28.479 ns |    16.947 ns |   370.69 ns |     154 B |
|               Simd64Subtract_int |   393.37 ns |    50.380 ns |    29.980 ns |   385.60 ns |     154 B |
|               Simd64Multiply_int |   424.71 ns |    71.126 ns |    42.326 ns |   407.48 ns |     155 B |
|                 Simd64Divide_int |   673.80 ns |    33.439 ns |    11.925 ns |   674.62 ns |     152 B |
|                    Simd64Min_int |   430.10 ns |    57.299 ns |    34.098 ns |   431.85 ns |     160 B |
|                    Simd64Max_int |   411.72 ns |    32.804 ns |    19.521 ns |   410.23 ns |     160 B |
|                  Simd64Equal_int |   719.36 ns |    53.154 ns |    31.631 ns |   707.79 ns |     263 B |
|               Simd64NotEqual_int |          NA |           NA |           NA |          NA |         - |
|           Simd128GreaterThan_int |    44.97 ns |     3.035 ns |     1.806 ns |    44.43 ns |      55 B |
|              Simd128LessThan_int |    44.42 ns |     2.349 ns |     1.398 ns |    43.92 ns |      55 B |
|    Simd128GreaterThanOrEqual_int |          NA |           NA |           NA |          NA |         - |
|       Simd128LessThanOrEqual_int |          NA |           NA |           NA |          NA |         - |
|                   Simd128Add_int |    45.64 ns |     4.280 ns |     2.547 ns |    45.66 ns |      55 B |
|              Simd128Subtract_int |    43.54 ns |     3.099 ns |     1.844 ns |    43.83 ns |      55 B |
|              Simd128Multiply_int |   301.27 ns |    29.287 ns |    17.428 ns |   301.27 ns |     172 B |
|                Simd128Divide_int |   599.80 ns |    77.406 ns |    27.604 ns |   592.58 ns |         - |
|                   Simd128Min_int |    44.64 ns |     1.863 ns |     1.109 ns |    44.82 ns |      56 B |
|                   Simd128Max_int |    46.64 ns |     6.673 ns |     3.971 ns |    45.64 ns |      56 B |
|                 Simd128Equal_int |    45.62 ns |     5.299 ns |     3.153 ns |    44.08 ns |      55 B |
|              Simd128NotEqual_int |          NA |           NA |           NA |          NA |         - |
|           Simd256GreaterThan_int |    24.85 ns |     3.361 ns |     2.000 ns |    24.65 ns |      58 B |
|              Simd256LessThan_int |          NA |           NA |           NA |          NA |         - |
|    Simd256GreaterThanOrEqual_int |          NA |           NA |           NA |          NA |         - |
|       Simd256LessThanOrEqual_int |          NA |           NA |           NA |          NA |         - |
|                   Simd256Add_int |    22.51 ns |     2.259 ns |     1.344 ns |    21.95 ns |      58 B |
|              Simd256Subtract_int |    25.52 ns |     3.730 ns |     2.219 ns |    25.91 ns |      58 B |
|              Simd256Multiply_int |   273.14 ns |    21.272 ns |    12.659 ns |   275.31 ns |     185 B |
|                Simd256Divide_int |          NA |           NA |           NA |          NA |         - |
|                   Simd256Min_int |    26.32 ns |     6.305 ns |     3.752 ns |    26.78 ns |      59 B |
|                   Simd256Max_int |    25.54 ns |     4.297 ns |     2.557 ns |    26.98 ns |      59 B |
|                 Simd256Equal_int |    22.79 ns |     2.457 ns |     1.462 ns |    23.21 ns |      58 B |
|              Simd256NotEqual_int |          NA |           NA |           NA |          NA |         - |
|          Simd64GreaterThan_ulong |   389.08 ns |    45.293 ns |    26.953 ns |   378.27 ns |     232 B |
|             Simd64LessThan_ulong |   370.45 ns |    32.872 ns |    19.562 ns |   365.67 ns |     232 B |
|   Simd64GreaterThanOrEqual_ulong |   383.37 ns |    62.818 ns |    37.382 ns |   374.93 ns |     232 B |
|      Simd64LessThanOrEqual_ulong |   389.36 ns |    34.234 ns |    20.372 ns |   378.26 ns |     232 B |
|                  Simd64Add_ulong |   255.01 ns |    20.341 ns |    12.105 ns |   253.67 ns |     170 B |
|             Simd64Subtract_ulong |   257.39 ns |    25.484 ns |    15.165 ns |   253.93 ns |     172 B |
|             Simd64Multiply_ulong |   268.89 ns |    40.879 ns |    24.326 ns |   258.44 ns |     173 B |
|               Simd64Divide_ulong |   805.24 ns |    41.169 ns |    14.681 ns |   805.27 ns |     145 B |
|                  Simd64Min_ulong |   333.87 ns |    48.058 ns |    28.599 ns |   341.41 ns |     179 B |
|                  Simd64Max_ulong |   292.27 ns |    26.750 ns |    15.919 ns |   295.70 ns |     179 B |
|                Simd64Equal_ulong |   363.47 ns |    14.604 ns |     8.690 ns |   362.40 ns |     232 B |
|             Simd64NotEqual_ulong |          NA |           NA |           NA |          NA |         - |
|         Simd128GreaterThan_ulong |   263.59 ns |    20.443 ns |    12.165 ns |   260.53 ns |     394 B |
|            Simd128LessThan_ulong |   250.76 ns |    18.187 ns |    10.823 ns |   252.81 ns |     394 B |
|  Simd128GreaterThanOrEqual_ulong |          NA |           NA |           NA |          NA |         - |
|     Simd128LessThanOrEqual_ulong |          NA |           NA |           NA |          NA |         - |
|                 Simd128Add_ulong |    43.21 ns |     2.841 ns |     1.690 ns |    43.84 ns |      55 B |
|            Simd128Subtract_ulong |    45.81 ns |     3.300 ns |     1.964 ns |    44.89 ns |      55 B |
|            Simd128Multiply_ulong |   218.37 ns |    10.338 ns |     6.152 ns |   218.05 ns |     325 B |
|              Simd128Divide_ulong |   741.11 ns |    28.599 ns |    17.019 ns |   737.79 ns |     264 B |
|                 Simd128Min_ulong |   242.31 ns |    13.950 ns |     8.302 ns |   241.63 ns |     331 B |
|                 Simd128Max_ulong |   254.06 ns |    17.840 ns |    10.616 ns |   250.91 ns |     331 B |
|               Simd128Equal_ulong |   255.81 ns |    23.223 ns |    13.820 ns |   252.01 ns |     394 B |
|            Simd128NotEqual_ulong |          NA |           NA |           NA |          NA |         - |
|         Simd256GreaterThan_ulong |          NA |           NA |           NA |          NA |         - |
|            Simd256LessThan_ulong |          NA |           NA |           NA |          NA |         - |
|  Simd256GreaterThanOrEqual_ulong |          NA |           NA |           NA |          NA |         - |
|     Simd256LessThanOrEqual_ulong |          NA |           NA |           NA |          NA |         - |
|                 Simd256Add_ulong |    26.47 ns |     7.643 ns |     4.548 ns |    26.21 ns |      58 B |
|            Simd256Subtract_ulong |    23.61 ns |     4.419 ns |     2.630 ns |    22.48 ns |      58 B |
|            Simd256Multiply_ulong |   159.11 ns |    27.670 ns |    16.466 ns |   151.05 ns |     185 B |
|              Simd256Divide_ulong |   739.80 ns |    35.402 ns |    12.625 ns |   735.80 ns |         - |
|                 Simd256Min_ulong |   292.25 ns |    21.867 ns |    13.013 ns |   294.33 ns |     360 B |
|                 Simd256Max_ulong |   284.60 ns |    20.457 ns |    12.174 ns |   283.16 ns |     360 B |
|               Simd256Equal_ulong |    22.97 ns |     1.316 ns |     0.783 ns |    23.03 ns |      59 B |
|            Simd256NotEqual_ulong |          NA |           NA |           NA |          NA |         - |
|           Simd64GreaterThan_long |   386.51 ns |    39.842 ns |    23.709 ns |   388.02 ns |     232 B |
|              Simd64LessThan_long |   366.19 ns |    30.242 ns |    17.997 ns |   357.26 ns |     232 B |
|        Simd128GreaterThan_ushort |          NA |           NA |           NA |          NA |         - |
|           Simd128LessThan_ushort |          NA |           NA |           NA |          NA |         - |
| Simd128GreaterThanOrEqual_ushort |          NA |           NA |           NA |          NA |         - |
|    Simd128LessThanOrEqual_ushort |          NA |           NA |           NA |          NA |         - |
|                Simd128Add_ushort |    43.27 ns |     2.749 ns |     1.636 ns |    43.10 ns |      55 B |
|           Simd128Subtract_ushort |    42.13 ns |     1.859 ns |     1.106 ns |    41.92 ns |      55 B |
|           Simd128Multiply_ushort |   570.16 ns |    53.195 ns |    31.655 ns |   554.88 ns |     183 B |
|             Simd128Divide_ushort |          NA |           NA |           NA |          NA |         - |
|                Simd128Min_ushort |          NA |           NA |           NA |          NA |         - |
|                Simd128Max_ushort |          NA |           NA |           NA |          NA |         - |
|              Simd128Equal_ushort |    41.61 ns |     1.940 ns |     1.154 ns |    41.54 ns |      55 B |
|           Simd128NotEqual_ushort |          NA |           NA |           NA |          NA |         - |
|        Simd256GreaterThan_ushort |          NA |           NA |           NA |          NA |         - |
|           Simd256LessThan_ushort |          NA |           NA |           NA |          NA |         - |
| Simd256GreaterThanOrEqual_ushort |          NA |           NA |           NA |          NA |         - |
|    Simd256LessThanOrEqual_ushort |          NA |           NA |           NA |          NA |         - |
|                Simd256Add_ushort |    21.58 ns |     0.737 ns |     0.438 ns |    21.53 ns |      58 B |
|           Simd256Subtract_ushort |    23.86 ns |     4.813 ns |     2.864 ns |    23.00 ns |      58 B |
|           Simd256Multiply_ushort |   628.62 ns |    99.301 ns |    59.093 ns |   633.40 ns |     196 B |
|             Simd256Divide_ushort |          NA |           NA |           NA |          NA |         - |
|                Simd256Min_ushort |          NA |           NA |           NA |          NA |         - |
|                Simd256Max_ushort |          NA |           NA |           NA |          NA |         - |
|              Simd256Equal_ushort |    24.33 ns |     4.171 ns |     2.482 ns |    23.96 ns |      58 B |
|           Simd256NotEqual_ushort |          NA |           NA |           NA |          NA |         - |
|          Simd64GreaterThan_short | 1,331.10 ns |    92.730 ns |    55.182 ns | 1,325.29 ns |     274 B |
|             Simd64LessThan_short | 1,321.50 ns |   122.191 ns |    72.714 ns | 1,290.11 ns |     274 B |
|   Simd64GreaterThanOrEqual_short | 1,320.55 ns |   108.295 ns |    64.445 ns | 1,293.76 ns |     274 B |
|      Simd64LessThanOrEqual_short | 1,371.28 ns |    96.732 ns |    57.563 ns | 1,357.32 ns |     274 B |
|                  Simd64Add_short |   609.23 ns |    27.073 ns |    16.111 ns |   606.15 ns |     171 B |
|             Simd64Subtract_short |   628.85 ns |    51.643 ns |    30.732 ns |   636.22 ns |     171 B |
|             Simd64Multiply_short |   621.71 ns |    46.248 ns |    27.522 ns |   624.30 ns |     172 B |
|               Simd64Divide_short |          NA |           NA |           NA |          NA |         - |
|                  Simd64Min_short |   632.09 ns |    31.034 ns |    18.468 ns |   628.22 ns |     173 B |
|                  Simd64Max_short |   633.76 ns |    68.004 ns |    40.468 ns |   616.74 ns |     173 B |
|                Simd64Equal_short | 1,320.72 ns |   136.689 ns |    81.341 ns | 1,315.45 ns |     274 B |
|             Simd64NotEqual_short |          NA |           NA |           NA |          NA |         - |
|         Simd128GreaterThan_short |    42.00 ns |     2.065 ns |     1.229 ns |    41.99 ns |      55 B |
|            Simd128LessThan_short |    43.06 ns |     3.664 ns |     2.181 ns |    43.45 ns |      55 B |
|  Simd128GreaterThanOrEqual_short |          NA |           NA |           NA |          NA |         - |
|     Simd128LessThanOrEqual_short |          NA |           NA |           NA |          NA |         - |
|                 Simd128Add_short |    42.49 ns |     3.534 ns |     2.103 ns |    42.82 ns |      55 B |
|            Simd128Subtract_short |    41.94 ns |     2.729 ns |     1.624 ns |    41.67 ns |      55 B |
|            Simd128Multiply_short |   547.85 ns |    22.777 ns |    13.554 ns |   543.93 ns |     183 B |
|              Simd128Divide_short |          NA |           NA |           NA |          NA |         - |
|                 Simd128Min_short |    41.65 ns |     0.811 ns |     0.483 ns |    41.68 ns |      55 B |
|                 Simd128Max_short |    43.09 ns |     2.856 ns |     1.699 ns |    42.17 ns |      55 B |
|               Simd128Equal_short |    42.93 ns |     1.843 ns |     1.097 ns |    42.80 ns |      55 B |
|            Simd128NotEqual_short |          NA |           NA |           NA |          NA |         - |
|         Simd256GreaterThan_short |    23.10 ns |     4.930 ns |     2.934 ns |    22.04 ns |      58 B |
|            Simd256LessThan_short |          NA |           NA |           NA |          NA |         - |
|  Simd256GreaterThanOrEqual_short |          NA |           NA |           NA |          NA |         - |
|     Simd256LessThanOrEqual_short |          NA |           NA |           NA |          NA |         - |
|                 Simd256Add_short |    23.12 ns |     3.904 ns |     2.323 ns |    22.04 ns |      58 B |
|            Simd256Subtract_short |    20.68 ns |     1.109 ns |     0.660 ns |    20.81 ns |      58 B |
|            Simd256Multiply_short |   612.26 ns |    91.650 ns |    54.539 ns |   642.52 ns |     196 B |
|              Simd256Divide_short |          NA |           NA |           NA |          NA |         - |
|                 Simd256Min_short |    24.91 ns |     8.781 ns |     5.225 ns |    21.80 ns |      58 B |
|                 Simd256Max_short |    23.07 ns |     4.071 ns |     2.422 ns |    21.96 ns |      58 B |
|               Simd256Equal_short |    22.10 ns |     2.883 ns |     1.715 ns |    22.38 ns |      58 B |
|            Simd256NotEqual_short |          NA |           NA |           NA |          NA |         - |
|           Simd64GreaterThan_uint |   682.64 ns |    20.299 ns |    12.079 ns |   684.76 ns |     263 B |
|              Simd64LessThan_uint |   666.01 ns |    33.209 ns |    19.762 ns |   659.27 ns |     263 B |
|    Simd64GreaterThanOrEqual_uint |   746.28 ns |    60.847 ns |    36.209 ns |   755.45 ns |     263 B |
|       Simd64LessThanOrEqual_uint |   705.42 ns |    51.783 ns |    30.815 ns |   701.86 ns |     263 B |
|                   Simd64Add_uint |   326.71 ns |    15.497 ns |     9.222 ns |   327.31 ns |     154 B |
|              Simd64Subtract_uint |   324.48 ns |    13.518 ns |     8.045 ns |   326.36 ns |     154 B |
|              Simd64Multiply_uint |   331.90 ns |    19.065 ns |    11.346 ns |   332.36 ns |     155 B |
|                Simd64Divide_uint |   594.39 ns |   127.726 ns |     7.001 ns |   591.21 ns |         - |
|                   Simd64Min_uint |   365.60 ns |    19.930 ns |    11.860 ns |   363.10 ns |     160 B |
|                   Simd64Max_uint |   347.56 ns |    15.421 ns |     9.177 ns |   347.29 ns |     160 B |
|                 Simd64Equal_uint |   677.11 ns |    43.981 ns |    26.172 ns |   672.14 ns |     263 B |
|              Simd64NotEqual_uint |          NA |           NA |           NA |          NA |         - |
|          Simd128GreaterThan_uint |          NA |           NA |           NA |          NA |         - |
|             Simd128LessThan_uint |          NA |           NA |           NA |          NA |         - |
|   Simd128GreaterThanOrEqual_uint |          NA |           NA |           NA |          NA |         - |
|      Simd128LessThanOrEqual_uint |          NA |           NA |           NA |          NA |         - |
|                  Simd128Add_uint |    42.45 ns |     2.986 ns |     1.777 ns |    42.76 ns |      55 B |
|             Simd128Subtract_uint |    41.73 ns |     2.664 ns |     1.585 ns |    42.52 ns |      55 B |
|             Simd128Multiply_uint |   274.78 ns |    15.159 ns |     9.021 ns |   273.27 ns |     172 B |
|               Simd128Divide_uint |   578.05 ns |   138.723 ns |     7.604 ns |   578.52 ns |         - |
|                  Simd128Min_uint |          NA |           NA |           NA |          NA |         - |
|                  Simd128Max_uint |          NA |           NA |           NA |          NA |         - |
|                Simd128Equal_uint |    42.33 ns |     2.518 ns |     1.498 ns |    42.04 ns |      55 B |
|             Simd128NotEqual_uint |          NA |           NA |           NA |          NA |         - |
|          Simd256GreaterThan_uint |          NA |           NA |           NA |          NA |         - |
|           Simd64GreaterThan_byte | 2,513.78 ns |   178.321 ns |   106.116 ns | 2,504.02 ns |     270 B |
|              Simd64LessThan_byte | 2,722.11 ns |   274.856 ns |   163.562 ns | 2,724.91 ns |      40 B |
|    Simd64GreaterThanOrEqual_byte | 2,809.11 ns |   303.656 ns |   180.701 ns | 2,817.23 ns |     270 B |
|       Simd64LessThanOrEqual_byte | 2,702.70 ns |   258.625 ns |   153.904 ns | 2,724.92 ns |     270 B |
|                   Simd64Add_byte | 1,157.25 ns |    98.901 ns |    58.854 ns | 1,147.99 ns |     170 B |
|              Simd64Subtract_byte | 1,119.30 ns |    78.232 ns |    46.555 ns | 1,090.70 ns |     170 B |
|              Simd64Multiply_byte | 1,134.32 ns |    69.572 ns |    41.401 ns | 1,131.05 ns |     171 B |
|                Simd64Divide_byte |          NA |           NA |           NA |          NA |         - |
|                   Simd64Min_byte | 1,264.28 ns |    98.809 ns |    58.799 ns | 1,270.87 ns |     171 B |
|                   Simd64Max_byte | 1,451.05 ns |   148.766 ns |    88.528 ns | 1,423.93 ns |     171 B |
|                 Simd64Equal_byte | 2,558.20 ns |    94.993 ns |    56.529 ns | 2,556.91 ns |     270 B |
|              Simd64NotEqual_byte |          NA |           NA |           NA |          NA |         - |
|          Simd128GreaterThan_byte |          NA |           NA |           NA |          NA |         - |
|             Simd128LessThan_byte |          NA |           NA |           NA |          NA |         - |
|   Simd128GreaterThanOrEqual_byte |          NA |           NA |           NA |          NA |         - |
|      Simd128LessThanOrEqual_byte |          NA |           NA |           NA |          NA |         - |
|                  Simd128Add_byte |    41.48 ns |     3.543 ns |     2.108 ns |    41.47 ns |      55 B |
|             Simd128Subtract_byte |    42.42 ns |     2.553 ns |     1.520 ns |    41.71 ns |      55 B |
|             Simd128Multiply_byte | 1,032.54 ns |    73.288 ns |    43.612 ns | 1,012.47 ns |     182 B |
|               Simd128Divide_byte |          NA |           NA |           NA |          NA |         - |
|                  Simd128Min_byte |          NA |           NA |           NA |          NA |         - |
|                  Simd128Max_byte |          NA |           NA |           NA |          NA |         - |
|                Simd128Equal_byte |    42.87 ns |     3.749 ns |     2.231 ns |    42.42 ns |      55 B |
|             Simd128NotEqual_byte |          NA |           NA |           NA |          NA |         - |
|          Simd256GreaterThan_byte |          NA |           NA |           NA |          NA |         - |
|             Simd256LessThan_byte |          NA |           NA |           NA |          NA |         - |
|   Simd256GreaterThanOrEqual_byte |          NA |           NA |           NA |          NA |         - |
|      Simd256LessThanOrEqual_byte |          NA |           NA |           NA |          NA |         - |
|                  Simd256Add_byte |    24.31 ns |     4.230 ns |     2.517 ns |    24.78 ns |      58 B |
|             Simd256Subtract_byte |    23.25 ns |     4.395 ns |     2.615 ns |    21.90 ns |      58 B |
|             Simd256Multiply_byte | 1,021.26 ns |    72.317 ns |    43.035 ns | 1,008.89 ns |     195 B |
|               Simd256Divide_byte |          NA |           NA |           NA |          NA |         - |
|                  Simd256Min_byte |          NA |           NA |           NA |          NA |         - |
|                  Simd256Max_byte |          NA |           NA |           NA |          NA |         - |
|                Simd256Equal_byte |    21.94 ns |     3.847 ns |     2.289 ns |    20.78 ns |      58 B |
|             Simd256NotEqual_byte |          NA |           NA |           NA |          NA |         - |
|          Simd64GreaterThan_sbyte | 2,612.06 ns |   279.689 ns |   166.439 ns | 2,577.07 ns |     273 B |
|             Simd64LessThan_sbyte | 2,747.97 ns |   360.848 ns |   214.735 ns | 2,716.15 ns |     273 B |
|   Simd64GreaterThanOrEqual_sbyte | 2,870.33 ns |   453.110 ns |   269.639 ns | 2,915.81 ns |     273 B |
|      Simd64LessThanOrEqual_sbyte | 2,811.97 ns |   496.363 ns |   295.378 ns | 2,690.43 ns |     273 B |
|                  Simd64Add_sbyte | 1,127.94 ns |    84.326 ns |    50.181 ns | 1,128.65 ns |     171 B |
|             Simd64Subtract_sbyte | 1,138.94 ns |   104.588 ns |    62.239 ns | 1,130.33 ns |     171 B |
|             Simd64Multiply_sbyte | 1,183.82 ns |   114.470 ns |    68.119 ns | 1,197.65 ns |     172 B |
|               Simd64Divide_sbyte |          NA |           NA |           NA |          NA |         - |
|                  Simd64Min_sbyte | 1,444.53 ns |   298.516 ns |   177.642 ns | 1,519.28 ns |     172 B |
|                  Simd64Max_sbyte | 1,259.32 ns |   100.936 ns |    60.065 ns | 1,245.42 ns |     172 B |
|                Simd64Equal_sbyte | 2,551.45 ns |   195.793 ns |   116.514 ns | 2,567.90 ns |     273 B |
|             Simd64NotEqual_sbyte |          NA |           NA |           NA |          NA |         - |
|         Simd128GreaterThan_sbyte |    42.88 ns |     2.590 ns |     1.541 ns |    42.86 ns |      55 B |
|            Simd128LessThan_sbyte |    41.70 ns |     1.382 ns |     0.823 ns |    41.97 ns |      55 B |
|  Simd128GreaterThanOrEqual_sbyte |          NA |           NA |           NA |          NA |         - |
|     Simd128LessThanOrEqual_sbyte |          NA |           NA |           NA |          NA |         - |
|                 Simd128Add_sbyte |    41.90 ns |     2.043 ns |     1.216 ns |    41.81 ns |      55 B |
|            Simd128Subtract_sbyte |    41.56 ns |     2.241 ns |     1.334 ns |    41.78 ns |      55 B |
|            Simd128Multiply_sbyte | 1,038.18 ns |    77.202 ns |    45.942 ns | 1,025.39 ns |     182 B |
|              Simd128Divide_sbyte |          NA |           NA |           NA |          NA |         - |
|                 Simd128Min_sbyte |    44.41 ns |     4.443 ns |     2.644 ns |    45.22 ns |      56 B |
|                 Simd128Max_sbyte |    43.76 ns |     3.170 ns |     1.886 ns |    43.60 ns |      56 B |
|               Simd128Equal_sbyte |    43.11 ns |     2.573 ns |     1.531 ns |    43.42 ns |      55 B |
|            Simd128NotEqual_sbyte |          NA |           NA |           NA |          NA |         - |
|         Simd256GreaterThan_sbyte |    25.95 ns |     6.351 ns |     3.779 ns |    26.25 ns |      58 B |
|            Simd256LessThan_sbyte |          NA |           NA |           NA |          NA |         - |
|  Simd256GreaterThanOrEqual_sbyte |          NA |           NA |           NA |          NA |         - |
|     Simd256LessThanOrEqual_sbyte |          NA |           NA |           NA |          NA |         - |
|                 Simd256Add_sbyte |    22.06 ns |     2.963 ns |     1.763 ns |    21.79 ns |      58 B |
|            Simd256Subtract_sbyte |    23.50 ns |     4.000 ns |     2.380 ns |    22.19 ns |      58 B |
|            Simd256Multiply_sbyte | 1,101.58 ns |   192.249 ns |   114.405 ns | 1,062.01 ns |     195 B |
|              Simd256Divide_sbyte |          NA |           NA |           NA |          NA |         - |
|                 Simd256Min_sbyte |    25.07 ns |     3.275 ns |     1.949 ns |    25.67 ns |      59 B |
|                 Simd256Max_sbyte |    24.15 ns |     6.186 ns |     3.681 ns |    22.41 ns |      59 B |
|               Simd256Equal_sbyte |    25.39 ns |     9.995 ns |     5.948 ns |    21.81 ns |      58 B |
|            Simd256NotEqual_sbyte |          NA |           NA |           NA |          NA |         - |
|         Simd64GreaterThan_ushort | 1,529.34 ns |   127.508 ns |    75.878 ns | 1,519.47 ns |     286 B |
|            Simd64LessThan_ushort | 1,578.24 ns |   121.237 ns |    72.146 ns | 1,537.24 ns |     286 B |
|  Simd64GreaterThanOrEqual_ushort | 1,553.92 ns |   101.976 ns |    60.684 ns | 1,560.67 ns |     286 B |
|     Simd64LessThanOrEqual_ushort | 1,705.19 ns |   438.481 ns |   260.933 ns | 1,565.77 ns |     286 B |
|                 Simd64Add_ushort |   614.55 ns |    23.055 ns |    13.720 ns |   613.12 ns |     163 B |
|            Simd64Subtract_ushort |   622.20 ns |    37.393 ns |    22.252 ns |   615.90 ns |     163 B |
|            Simd64Multiply_ushort |   629.75 ns |    52.168 ns |    31.044 ns |   626.21 ns |     168 B |
|              Simd64Divide_ushort |          NA |           NA |           NA |          NA |         - |
|                 Simd64Min_ushort |   636.84 ns |    23.607 ns |    14.048 ns |   639.65 ns |     170 B |
|                 Simd64Max_ushort |   622.35 ns |    29.781 ns |    17.722 ns |   616.86 ns |     170 B |
|               Simd64Equal_ushort | 1,631.70 ns |   159.846 ns |    95.122 ns | 1,627.57 ns |     286 B |
|            Simd64NotEqual_ushort |          NA |           NA |           NA |          NA |         - |

Benchmarks with issues:
  SIMDDisasm.Simd64NotEqual_long: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThanOrEqual_long: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThanOrEqual_long: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128NotEqual_long: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThan_long: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThanOrEqual_long: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThanOrEqual_long: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256NotEqual_long: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThan_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThanOrEqual_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThanOrEqual_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Divide_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Min_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Max_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256NotEqual_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64NotEqual_int: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThanOrEqual_int: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThanOrEqual_int: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128NotEqual_int: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThan_int: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThanOrEqual_int: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThanOrEqual_int: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Divide_int: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256NotEqual_int: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64NotEqual_ulong: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThanOrEqual_ulong: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThanOrEqual_ulong: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128NotEqual_ulong: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThan_ulong: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThan_ulong: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThanOrEqual_ulong: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThanOrEqual_ulong: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256NotEqual_ulong: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThan_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThan_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThanOrEqual_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThanOrEqual_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128Divide_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128Min_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128Max_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128NotEqual_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThan_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThan_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThanOrEqual_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThanOrEqual_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Divide_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Min_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Max_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256NotEqual_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64Divide_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64NotEqual_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThanOrEqual_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThanOrEqual_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128Divide_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128NotEqual_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThan_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThanOrEqual_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThanOrEqual_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Divide_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256NotEqual_short: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64NotEqual_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThan_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThan_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThanOrEqual_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThanOrEqual_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128Min_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128Max_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128NotEqual_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThan_uint: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64Divide_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64NotEqual_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThan_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThan_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThanOrEqual_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThanOrEqual_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128Divide_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128Min_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128Max_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128NotEqual_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThan_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThan_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThanOrEqual_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThanOrEqual_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Divide_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Min_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Max_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256NotEqual_byte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64Divide_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64NotEqual_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128GreaterThanOrEqual_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128LessThanOrEqual_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128Divide_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd128NotEqual_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThan_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256GreaterThanOrEqual_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256LessThanOrEqual_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256Divide_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd256NotEqual_sbyte: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64Divide_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
  SIMDDisasm.Simd64NotEqual_ushort: Job-IUEPPH(Runtime=.NET 5.0, IterationCount=3, LaunchCount=3, WarmupCount=3)
