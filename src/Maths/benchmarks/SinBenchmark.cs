using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Silk.NET.Numerics.Benchmark
{
    public class SinBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;

        [Benchmark(Baseline = true)]
        public float Sys()
        {
            return MathF.Sin(X);
        }

        [Benchmark]
        public float Silk()
        {
            return Scalar.Sin(X);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();
        public IEnumerable<float> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return (float) _random.NextDouble();
        }
    }
}
