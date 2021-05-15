using System;
using System.Collections.Generic;

namespace SumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var api = SumAPI.GetApi();
            var list = new List<int>();
            Console.WriteLine("Enter Numbers, enter nothing to calculate sum");
            while (true)
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;
                if (int.TryParse(line, out var num))
                    list.Add(num);
            }

            var sum = api.Sum(list.Count, list.ToArray());
            Console.WriteLine($"Sum: {sum}");
            Console.ReadLine();
        }
    }
}
