// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Silk.NET.Maths.Benchmark
{
    [MemoryDiagnoser]
    [SimpleJob(RunStrategy.Throughput)]
    public class LogSmallBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;

        [Benchmark(Baseline = true)]
        public float Sys()
        {
#if MATHF
            return MathF.Log(X);
#else
            return (float)Math.Log(X);
#endif
        }

        [Benchmark]
        public float Silk()
        {
            return Scalar.Log(X);
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
    public class LogBigBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;

        [Benchmark(Baseline = true)]
        public float Sys()
        {
#if MATHF
            return MathF.Log(X);
#else
            return (float)Math.Log(X);
#endif
        }

        [Benchmark]
        public float Silk()
        {
            return Scalar.Log(X);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();

        public IEnumerable<float> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return (float) (_random.NextDouble() * 1000);
        }
    }
}