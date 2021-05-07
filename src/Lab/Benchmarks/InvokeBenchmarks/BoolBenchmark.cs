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
    public class BoolBenchmark
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
        [BenchmarkCategory("SystemBool")]
        public int WithReturnAndSystemBoolMarshalSilk()
        {
            return _silkAPI.WithReturnAndSystemBoolMarshal(true);
        }
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("SystemBool")]
        public int WithReturnAndSystemBoolMarshalPInvoke()
        {
            return PInvoke.WithReturnAndSystemBoolMarshal(true);
        }
        [Benchmark]
        [BenchmarkCategory("VariantBool")]
        public int WithReturnAndVariantBoolMarshalSilk()
        {
            return _silkAPI.WithReturnAndVariantBoolMarshal(true);
        }
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("VariantBool")]
        public int WithReturnAndVariantBoolMarshalPInvoke()
        {
            return PInvoke.WithReturnAndVariantBoolMarshal(true);
        }
        [Benchmark]
        [BenchmarkCategory("I2Bool")]
        public int WithReturnAndI2BoolMarshalSilk()
        {
            return _silkAPI.WithReturnAndI2BoolMarshal(true);
        }
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("I2Bool")]
        public int WithReturnAndI2BoolMarshalPInvoke()
        {
            return PInvoke.WithReturnAndI2BoolMarshal(true);
        }
        [Benchmark]
        [BenchmarkCategory("I4Bool")]
        public int WithReturnAndI4BoolMarshalSilk()
        {
            return _silkAPI.WithReturnAndI4BoolMarshal(true);
        }
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("I4Bool")]
        public int WithReturnAndI4BoolMarshalPInvoke()
        {
            return PInvoke.WithReturnAndI4BoolMarshal(true);
        }
        [Benchmark]
        [BenchmarkCategory("U2Bool")]
        public int WithReturnAndU2BoolMarshalSilk()
        {
            return _silkAPI.WithReturnAndU2BoolMarshal(true);
        }
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("U2Bool")]
        public int WithReturnAndU2BoolMarshalPInvoke()
        {
            return PInvoke.WithReturnAndU2BoolMarshal(true);
        }
        [Benchmark]
        [BenchmarkCategory("U4Bool")]
        public int WithReturnAndU4BoolMarshalSilk()
        {
            return _silkAPI.WithReturnAndU4BoolMarshal(true);
        }
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("U4Bool")]
        public int WithReturnAndU4BoolMarshalPInvoke()
        {
            return PInvoke.WithReturnAndI4BoolMarshal(true);
        }
    }
}
