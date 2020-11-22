using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Silk.NET.Numerics.Benchmark
{
    [MemoryDiagnoser]
    [SimpleJob(RunStrategy.Throughput)]
    public class ExpSmallBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;

        [Benchmark(Baseline = true)]
        public float Sys()
        {
            return MathF.Exp(X);
        }

        [Benchmark]
        public float Silk()
        {
            return Operations.Exp(X);
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
    public class ExpBigBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;

        [Benchmark(Baseline = true)]
        public float Sys()
        {
            return MathF.Exp(X);
        }

        [Benchmark]
        public float Silk()
        {
            return Operations.Exp(X);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();

        public IEnumerable<float> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return (float) (_random.NextDouble() * 10) + 10f;
        }
    }
}