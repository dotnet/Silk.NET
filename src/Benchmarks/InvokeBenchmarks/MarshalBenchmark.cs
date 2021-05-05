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
        private sealed class TestContext : INativeContext
        {
            public void Dispose()
            {
                throw new System.NotImplementedException();
            }

            [UnmanagedCallersOnly(CallConvs = new []{typeof(CallConvCdecl)})]
            private static void RawInvoke()
            {
                
            }
            [UnmanagedCallersOnly(CallConvs = new []{typeof(CallConvCdecl)})]
            private static int WithReturn()
            {
                return 5;
            }
            [UnmanagedCallersOnly(CallConvs = new []{typeof(CallConvCdecl)})]
            private static unsafe int WithReturnAndStringMarshal(byte* bytes)
            {
                return *bytes;
            }
            [UnmanagedCallersOnly(CallConvs = new []{typeof(CallConvCdecl)})]
            private static unsafe int WithReturnAndMultiStringMarshal(byte* bytes, byte* bytes2)
            {
                return *bytes + *bytes2;
            }
            [UnmanagedCallersOnly(CallConvs = new []{typeof(CallConvCdecl)})]
            private static unsafe int WithReturnAndSpanMarshal(byte* bytes)
            {
                return *bytes;
            }
            [UnmanagedCallersOnly(CallConvs = new []{typeof(CallConvCdecl)})]
            private static unsafe int WithReturnAndBoolMarshal(short b)
            {
                return b;
            }
            
            public nint GetProcAddress(string proc, int? slot = default)
            {
                TryGetProcAddress(proc, out var v, slot);
                return v;
            }

            public unsafe bool TryGetProcAddress(string proc, out nint addr, int? slot = default)
            {
                if (proc == "Test1")
                {
                    addr = (nint)(delegate* unmanaged[Cdecl]<void>)(&RawInvoke);
                    return true;
                }
                
                if (proc == "Test2")
                {
                    addr = (nint)(delegate* unmanaged[Cdecl]<int>)(&WithReturn);
                    return true;
                }
                
                if (proc == "Test3")
                {
                    addr = (nint)(delegate* unmanaged[Cdecl]<byte*, int>)(&WithReturnAndStringMarshal);
                    return true;
                }
                
                if (proc == "Test4")
                {
                    addr = (nint)(delegate* unmanaged[Cdecl]<byte*, byte*, int>)(&WithReturnAndMultiStringMarshal);
                    return true;
                }
                
                if (proc == "Test5")
                {
                    addr = (nint)(delegate* unmanaged[Cdecl]<byte*, int>)(&WithReturnAndSpanMarshal);
                    return true;
                }
                
                if (proc == "Test6")
                {
                    addr = (nint)(delegate* unmanaged[Cdecl]<short, int>)(&WithReturnAndBoolMarshal);
                    return true;
                }

                addr = 0;
                return false;
            }
        }

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
        public int WithReturnAndStringMarshal()
        {
            return _rawAPI.WithReturnAndStringMarshal("Hello World!");
        }
        
        [Benchmark]
        public int WithReturnAndMultiStringMarshal()
        {
            return _rawAPI.WithReturnAndMultiStringMarshal("Hello ", "World!");
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
