// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using Silk.NET.Core.Contexts;

namespace InvokeBenchmarks
{
    [CategoriesColumn]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class SmallStringBenchmark
    {
        private TestContext _testContext;
        private SilkAPI _silkAPI;

        [Params("AAAA", "®®®®", "𝄞𝄞𝄞𝄞")]
        public string Param;
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            _testContext = new TestContext();
            _silkAPI = new SilkAPI(_testContext);
        }

        [GlobalCleanup]
        public void GlobalCleanup()
        {
            _testContext.Dispose();
            _silkAPI.Dispose();
        }

        [Benchmark]
        [BenchmarkCategory("BStr")]
        public int WithReturnAndBStrMarshalSilk()
        {
            return _silkAPI.WithReturnAndBStrMarshal(Param);
        }
        
        [Benchmark]
        [BenchmarkCategory("LPStr")]
        public int WithReturnAndLPStrMarshalSilk()
        {
            return _silkAPI.WithReturnAndLPStrMarshal(Param);
        }
        
        [Benchmark]
        [BenchmarkCategory("LPTStr")]
        public int WithReturnAndLPTStrMarshalSilk()
        {
            return _silkAPI.WithReturnAndLPTStrMarshal(Param);
        }
        
        [Benchmark]
        [BenchmarkCategory("LPWStr")]
        public int WithReturnAndLPWStrMarshalSilk()
        {
            return _silkAPI.WithReturnAndLPWStrMarshal(Param);
        }
        
        [Benchmark]
        [BenchmarkCategory("LPUTF8Str")]
        public int WithReturnAndLPUTF8StrMarshalSilk()
        {
            return _silkAPI.WithReturnAndLPUTF8StrMarshal(Param);
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("BStr")]
        public int WithReturnAndBStrMarshalPInvoke()
        {
            return PInvoke.WithReturnAndBStrMarshal(Param);
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("LPStr")]
        public int WithReturnAndLPStrMarshalPInvoke()
        {
            return PInvoke.WithReturnAndLPStrMarshal(Param);
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("LPTStr")]
        public int WithReturnAndLPTStrMarshalPInvoke()
        {
            return PInvoke.WithReturnAndLPTStrMarshal(Param);
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("LPWStr")]
        public int WithReturnAndLPWStrMarshalPInvoke()
        {
            return PInvoke.WithReturnAndLPWStrMarshal(Param);
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("LPUTF8Str")]
        public int WithReturnAndLPUTF8StrMarshalPInvoke()
        {
            return PInvoke.WithReturnAndLPUTF8StrMarshal(Param);
        }
    }
}
