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
    public class BaseBenchmark
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
        [BenchmarkCategory("EmptyInvoke")]
        public void EmptyInvokeSilk()
        {
            _silkAPI.RawInvoke();
        }
        
        [Benchmark]
        [BenchmarkCategory("WithReturn")]
        public int WithReturnSilk()
        {
            return _silkAPI.WithReturn();
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("EmptyInvoke")]
        public void EmptyInvokePInvoke()
        {
            PInvoke.RawInvoke();
        }
        
        [Benchmark(Baseline = true)]
        [BenchmarkCategory("WithReturn")]
        public int WithReturnPInvoke()
        {
            return PInvoke.WithReturn();
        }
    }
}
