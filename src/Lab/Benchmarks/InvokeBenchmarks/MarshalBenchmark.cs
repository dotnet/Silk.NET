// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Silk.NET.Core.Contexts;

namespace InvokeBenchmarks
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class MarshalBenchmark
    {
        private TestContext _testContext;
        private RawAPI _rawAPI;
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            _testContext = new TestContext();
            _rawAPI = new RawAPI(_testContext);
        }
        
        [Benchmark(Baseline = true)]
        public void RawInvoke()
        {
            _rawAPI.RawInvoke();
        }
        
        [Benchmark]
        public int WithReturn()
        {
            return _rawAPI.WithReturn();
        }
        
        [Benchmark]
        public int WithReturnAndBStrMarshal()
        {
            return _rawAPI.WithReturnAndBStrMarshal("Hello World!");
        }
        
        [Benchmark]
        public int WithReturnAndLPStrMarshal()
        {
            return _rawAPI.WithReturnAndLPStrMarshal("Hello World!");
        }
        
        [Benchmark]
        public int WithReturnAndLPTStrMarshal()
        {
            return _rawAPI.WithReturnAndLPTStrMarshal("Hello World!");
        }
        
        [Benchmark]
        public int WithReturnAndLPWStrMarshal()
        {
            return _rawAPI.WithReturnAndLPWStrMarshal("Hello World!");
        }
        
        [Benchmark]
        public int WithReturnAndLPUTF8StrMarshal()
        {
            return _rawAPI.WithReturnAndLPUTF8StrMarshal("Hello World!");
        }

        [Benchmark]
        public int WithReturnAndSpanMarshalStackalloc()
        {
            return _rawAPI.WithReturnAndSpanMarshal(stackalloc byte[5]);
        }

        [Benchmark]
        public int WithReturnAndSpanMarshalLocalBuffer()
        {
            Span<byte> buff = new byte[5];
            return _rawAPI.WithReturnAndSpanMarshal(buff);
        }

        private static readonly byte[] _buff = new byte[5];
        [Benchmark]
        public int WithReturnAndSpanMarshalField()
        {
            return _rawAPI.WithReturnAndSpanMarshal(_buff);
        }
        
        [Benchmark]
        public int WithReturnAndBoolMarshal()
        {
            return _rawAPI.WithReturnAndBoolMarshal(true);
        }
    }
}
