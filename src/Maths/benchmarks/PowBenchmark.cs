using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Silk.NET.Numerics.Benchmark
{
    [MemoryDiagnoser]
    [SimpleJob(RunStrategy.Throughput)]
    public class PowSmallBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;
        [ParamsSource("GenerateNumber")] public float Y;

        [Benchmark(Baseline = true)]
        public float Sys()
        {
            return MathF.Pow(X, Y);
        }

        [Benchmark]
        public float Silk()
        {
            return Operations.Pow(X, Y);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();

        public IEnumerable<float> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return (float) _random.NextDouble();
        }
    }

    [MemoryDiagnoser]
    [SimpleJob(RunStrategy.Throughput)]
    public class PowBigBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;
        [ParamsSource("GenerateNumber")] public float Y;

        [Benchmark(Baseline = true)]
        public float Sys()
        {
            return MathF.Pow(X, Y);
        }

        [Benchmark]
        public float Silk()
        {
            return Operations.Pow(X, Y);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();

        public IEnumerable<float> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return (float) (_random.NextDouble() * 10) + 10f;
        }
    }
    
    [MemoryDiagnoser]
    [SimpleJob(RunStrategy.Throughput)]
    public class PowIntBenchmark
    {
        [ParamsSource("GenerateNumber")] public int X;
        [ParamsSource("GenerateNumber")] public int Y;

        [Benchmark(Baseline = true)]
        public float Sys()
        {
            return MathF.Pow(X, Y);
        }

        [Benchmark]
        public float SilkFloat()
        {
            return Operations.Pow<float>(X, Y);
        }
        
        [Benchmark]
        public float SilkInt()
        {
            return Operations.Pow<int>(X, Y);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();

        public IEnumerable<int> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return _random.Next(-1000, 1000);
        }
    }
}