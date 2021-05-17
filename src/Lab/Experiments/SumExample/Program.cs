using System;
using SumExample;

using var api = SumAPI.GetApi();

var arr = new[] {5, 3, 2};
var sum = api.Sum(arr.Length, arr);
Console.WriteLine($"{string.Join(" + ", arr)} = {sum}");