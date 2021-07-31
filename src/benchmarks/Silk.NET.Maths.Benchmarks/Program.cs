using System.Reflection;
using BenchmarkDotNet.Running;

namespace Silk.NET.Maths.Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(Assembly.GetEntryAssembly()).Run(args);
        }
    }
}