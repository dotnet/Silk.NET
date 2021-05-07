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
    public class SpanBenchmark
    {
        private TestContext _testContext;
        private SilkAPI _silkAPI;
        private static readonly byte[] _buff = new byte[5];
        
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
        [BenchmarkCategory("Stackalloc")]
        public int WithReturnAndSpanMarshalStackallocSilk()
        {
            return _silkAPI.WithReturnAndSpanMarshal(stackalloc byte[5]);
        }

        [Benchmark]
        [BenchmarkCategory("LocalBuffer")]
        public int WithReturnAndSpanMarshalLocalBufferSilk()
        {
            Span<byte> buff = new byte[5];
            return _silkAPI.WithReturnAndSpanMarshal(buff);
        }

        [Benchmark]
        [BenchmarkCategory("Field")]
        public int WithReturnAndSpanMarshalFieldSilk()
        {
            return _silkAPI.WithReturnAndSpanMarshal(_buff);
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("Stackalloc")]
        public int WithReturnAndSpanMarshalStackallocPInvoke()
        {
            return PInvoke.WithReturnAndSpanMarshal(stackalloc byte[5]);
        }

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("LocalBuffer")]
        public int WithReturnAndSpanMarshalLocalBufferPInvoke()
        {
            Span<byte> buff = new byte[5];
            return PInvoke.WithReturnAndSpanMarshal(buff);
        }

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("Field")]
        public int WithReturnAndSpanMarshalFieldPInvoke()
        {
            return PInvoke.WithReturnAndSpanMarshal(_buff);
        }
    }
}
