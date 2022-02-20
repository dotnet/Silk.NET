// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Silk.NET.Maths.Benchmark
{
    public class SinBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;

        [Benchmark(Baseline = true)]
        public float Sys()
        {
#if MATHF
            return MathF.Sin(X);
#else
            return (float)Math.Sin(X);
#endif
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
