// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Silk.NET.Maths.Benchmark
{
    [SimpleJob(RunStrategy.Throughput)]
    public class RoundAllBenchmark
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
#if MATHF
            return MathF.Round(X, Mode);
#else
            return (float)Math.Round(X, Mode);
#endif
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

#if !NET48
    [SimpleJob(RunStrategy.Throughput)]
    public class RoundToPositiveInfinityBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;
        public int XInt;
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            XInt = (int)X;
        }
        
        [Benchmark(Baseline = true)]
        public float Sys()
        {
#if MATHF
            return MathF.Round(X, MidpointRounding.ToPositiveInfinity);
#else
            return (float)Math.Round(X, MidpointRounding.ToPositiveInfinity);
#endif
        }

        [Benchmark]
        public float SilkFloat()
        {
            return Scalar.Round(X, MidpointRounding.ToPositiveInfinity);
        }

        [Benchmark]
        public int SilkInt()
        {
            return Scalar.Round(XInt, MidpointRounding.ToPositiveInfinity);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();
        public IEnumerable<float> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return (float) _random.NextDouble();
        }
    }
    
    [SimpleJob(RunStrategy.Throughput)]
    public class RoundToNegativeInfinityBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;
        public int XInt;
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            XInt = (int)X;
        }
        
        [Benchmark(Baseline = true)]
        public float Sys()
        {
#if MATHF
            return MathF.Round(X, MidpointRounding.ToNegativeInfinity);
#else
            return (float)Math.Round(X, MidpointRounding.ToNegativeInfinity);
#endif
        }

        [Benchmark]
        public float SilkFloat()
        {
            return Scalar.Round(X, MidpointRounding.ToNegativeInfinity);
        }

        [Benchmark]
        public int SilkInt()
        {
            return Scalar.Round(XInt, MidpointRounding.ToNegativeInfinity);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();
        public IEnumerable<float> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return (float) _random.NextDouble();
        }
    }
        
    [SimpleJob(RunStrategy.Throughput)]
    public class RoundToZeroBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;
        public int XInt;
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            XInt = (int)X;
        }
        
        [Benchmark(Baseline = true)]
        public float Sys()
        {
#if MATHF
            return MathF.Round(X, MidpointRounding.ToZero);
#else
            return (float)Math.Round(X, MidpointRounding.ToZero);
#endif
        }

        [Benchmark]
        public float SilkFloat()
        {
            return Scalar.Round(X, MidpointRounding.ToZero);
        }

        [Benchmark]
        public int SilkInt()
        {
            return Scalar.Round(XInt, MidpointRounding.ToZero);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();
        public IEnumerable<float> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return (float) _random.NextDouble();
        }
    }
#endif

    [SimpleJob(RunStrategy.Throughput)]
    public class RoundAwayFromZeroBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;
        public int XInt;

        [GlobalSetup]
        public void GlobalSetup()
        {
            XInt = (int) X;
        }

        [Benchmark(Baseline = true)]
        public float Sys()
        {
#if MATHF
            return MathF.Round(X, MidpointRounding.AwayFromZero);
#else
            return (float) Math.Round(X, MidpointRounding.AwayFromZero);
#endif
        }

        [Benchmark]
        public float SilkFloat()
        {
            return Scalar.Round(X, MidpointRounding.AwayFromZero);
        }

        [Benchmark]
        public int SilkInt()
        {
            return Scalar.Round(XInt, MidpointRounding.AwayFromZero);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();
        public IEnumerable<float> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return (float) _random.NextDouble();
        }
    }

    [SimpleJob(RunStrategy.Throughput)]
    public class RoundToEvenBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;
        public int XInt;
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            XInt = (int)X;
        }
        
        [Benchmark(Baseline = true)]
        public float Sys()
        {
#if MATHF
            return MathF.Round(X, MidpointRounding.ToEven);
#else
            return (float)Math.Round(X, MidpointRounding.ToEven);
#endif
        }

        [Benchmark]
        public float SilkFloat()
        {
            return Scalar.Round(X, MidpointRounding.ToEven);
        }

        [Benchmark]
        public int SilkInt()
        {
            return Scalar.Round(XInt, MidpointRounding.ToEven);
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
