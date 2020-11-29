using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Silk.NET.Maths.Benchmark
{
    [SimpleJob(RunStrategy.Throughput)]
    public class RoundBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;
        public int XInt;
        [ParamsAllValues] public MidpointRounding Mode;
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            XInt = (int)X;
        }
        
        [Benchmark(Baseline = true)]
        public float Sys()
        {
            return MathF.Round(X, Mode);
        }

        [Benchmark]
        public float SilkFloat()
        {
            return Scalar.Round(X, Mode);
        }

        [Benchmark]
        public int SilkInt()
        {
            return Scalar.Round(XInt, Mode);
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
