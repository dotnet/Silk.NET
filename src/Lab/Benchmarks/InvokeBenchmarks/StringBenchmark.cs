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
    public class StringBenchmark
    {
        private TestContext _testContext;
        private SilkAPI _silkAPI;
        
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
            return _silkAPI.WithReturnAndBStrMarshal("Hello World!");
        }
        
        [Benchmark]
        [BenchmarkCategory("LPStr")]
        public int WithReturnAndLPStrMarshalSilk()
        {
            return _silkAPI.WithReturnAndLPStrMarshal("Hello World!");
        }
        
        [Benchmark]
        [BenchmarkCategory("LPTStr")]
        public int WithReturnAndLPTStrMarshalSilk()
        {
            return _silkAPI.WithReturnAndLPTStrMarshal("Hello World!");
        }
        
        [Benchmark]
        [BenchmarkCategory("LPWStr")]
        public int WithReturnAndLPWStrMarshalSilk()
        {
            return _silkAPI.WithReturnAndLPWStrMarshal("Hello World!");
        }
        
        [Benchmark]
        [BenchmarkCategory("LPUTF8Str")]
        public int WithReturnAndLPUTF8StrMarshalSilk()
        {
            return _silkAPI.WithReturnAndLPUTF8StrMarshal("Hello World!");
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("BStr")]
        public int WithReturnAndBStrMarshalPInvoke()
        {
            return PInvoke.WithReturnAndBStrMarshal("Hello World!");
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("LPStr")]
        public int WithReturnAndLPStrMarshalPInvoke()
        {
            return PInvoke.WithReturnAndLPStrMarshal("Hello World!");
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("LPTStr")]
        public int WithReturnAndLPTStrMarshalPInvoke()
        {
            return PInvoke.WithReturnAndLPTStrMarshal("Hello World!");
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("LPWStr")]
        public int WithReturnAndLPWStrMarshalPInvoke()
        {
            return PInvoke.WithReturnAndLPWStrMarshal("Hello World!");
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("LPUTF8Str")]
        public int WithReturnAndLPUTF8StrMarshalPInvoke()
        {
            return PInvoke.WithReturnAndLPUTF8StrMarshal("Hello World!");
        }
    }
}
