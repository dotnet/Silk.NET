// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using System.Runtime.Intrinsics;

/*
 
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1288 (20H2/October2020Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-rc.2.21456.8
  [Host]   : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  .NET 5.0 : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT

Job=.NET 5.0  Runtime=.NET 5.0

|                    Method |     Mean |    Error |   StdDev | Code Size |
|-------------------------- |---------:|---------:|---------:|----------:|
|        Simd256GreaterThan | 25.17 ns | 0.656 ns | 1.893 ns |      59 B |
|           Simd256LessThan | 25.72 ns | 0.557 ns | 1.087 ns |      59 B |
| Simd256GreaterThanOrEqual | 25.53 ns | 0.603 ns | 1.660 ns |      59 B |
|    Simd256LessThanOrEqual | 27.54 ns | 0.835 ns | 2.355 ns |      59 B |
 
 */

namespace Silk.NET.Maths.Benchmark
{
    // [SimpleJob(RuntimeMoniker.NetCoreApp50, launchCount: 1, warmupCount: 1, targetCount: 1)]
    
    // [SimpleJob(RuntimeMoniker.NetCoreApp31, launchCount: 1, warmupCount: 1, targetCount: 1)]
    
    [SimpleJob(RuntimeMoniker.Net50)]
    [DisassemblyDiagnoser(exportHtml: true)]
    public unsafe class SIMDDisasm
    {
        const int IterCount = 20;
        void* a;
        void* b;
        void* c;
        
        [GlobalSetup]
        public void Setup()
        {
            // native memory is not a thing on .net 5
            a = (void*)Marshal.AllocHGlobal(256/*bits*/ / 8 * IterCount);
            b = (void*)Marshal.AllocHGlobal(256/*bits*/ / 8 * IterCount);
            c = (void*)Marshal.AllocHGlobal(256/*bits*/ / 8 * IterCount);
        }

        
        [Benchmark]
        public void Simd64_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.GreaterThan(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThan_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.LessThan(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64GreaterThanOrEqual_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.GreaterThanOrEqual(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThanOrEqual_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.LessThanOrEqual(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.GreaterThan(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThan_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.LessThan(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128GreaterThanOrEqual_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.GreaterThanOrEqual(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThanOrEqual_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.LessThanOrEqual(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.GreaterThan(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThan_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.LessThan(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256GreaterThanOrEqual_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.GreaterThanOrEqual(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThanOrEqual_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.LessThanOrEqual(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.GreaterThan(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThan_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.LessThan(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64GreaterThanOrEqual_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.GreaterThanOrEqual(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThanOrEqual_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.LessThanOrEqual(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.GreaterThan(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThan_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.LessThan(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128GreaterThanOrEqual_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.GreaterThanOrEqual(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThanOrEqual_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.LessThanOrEqual(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.GreaterThan(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThan_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.LessThan(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256GreaterThanOrEqual_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.GreaterThanOrEqual(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThanOrEqual_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.LessThanOrEqual(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.GreaterThan(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThan_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.LessThan(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64GreaterThanOrEqual_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.GreaterThanOrEqual(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThanOrEqual_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.LessThanOrEqual(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.GreaterThan(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThan_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.LessThan(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128GreaterThanOrEqual_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.GreaterThanOrEqual(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThanOrEqual_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.LessThanOrEqual(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.GreaterThan(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThan_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.LessThan(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256GreaterThanOrEqual_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.GreaterThanOrEqual(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThanOrEqual_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.LessThanOrEqual(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.GreaterThan(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThan_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.LessThan(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64GreaterThanOrEqual_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.GreaterThanOrEqual(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThanOrEqual_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.LessThanOrEqual(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.GreaterThan(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThan_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.LessThan(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128GreaterThanOrEqual_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.GreaterThanOrEqual(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThanOrEqual_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.LessThanOrEqual(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.GreaterThan(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThan_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.LessThan(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256GreaterThanOrEqual_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.GreaterThanOrEqual(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThanOrEqual_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.LessThanOrEqual(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.GreaterThan(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThan_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.LessThan(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64GreaterThanOrEqual_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.GreaterThanOrEqual(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThanOrEqual_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.LessThanOrEqual(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.GreaterThan(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThan_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.LessThan(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128GreaterThanOrEqual_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.GreaterThanOrEqual(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThanOrEqual_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.LessThanOrEqual(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.GreaterThan(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThan_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.LessThan(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256GreaterThanOrEqual_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.GreaterThanOrEqual(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThanOrEqual_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.LessThanOrEqual(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.GreaterThan(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThan_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.LessThan(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64GreaterThanOrEqual_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.GreaterThanOrEqual(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThanOrEqual_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.LessThanOrEqual(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.GreaterThan(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThan_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.LessThan(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128GreaterThanOrEqual_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.GreaterThanOrEqual(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThanOrEqual_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.LessThanOrEqual(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.GreaterThan(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThan_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.LessThan(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256GreaterThanOrEqual_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.GreaterThanOrEqual(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThanOrEqual_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.LessThanOrEqual(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.GreaterThan(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThan_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.LessThan(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64GreaterThanOrEqual_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.GreaterThanOrEqual(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThanOrEqual_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.LessThanOrEqual(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.GreaterThan(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThan_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.LessThan(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128GreaterThanOrEqual_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.GreaterThanOrEqual(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThanOrEqual_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.LessThanOrEqual(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.GreaterThan(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThan_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.LessThan(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256GreaterThanOrEqual_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.GreaterThanOrEqual(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThanOrEqual_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.LessThanOrEqual(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.GreaterThan(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThan_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.LessThan(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64GreaterThanOrEqual_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.GreaterThanOrEqual(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThanOrEqual_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.LessThanOrEqual(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.GreaterThan(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThan_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.LessThan(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128GreaterThanOrEqual_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.GreaterThanOrEqual(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThanOrEqual_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.LessThanOrEqual(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.GreaterThan(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThan_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.LessThan(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256GreaterThanOrEqual_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.GreaterThanOrEqual(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThanOrEqual_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.LessThanOrEqual(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.GreaterThan(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThan_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.LessThan(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64GreaterThanOrEqual_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.GreaterThanOrEqual(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThanOrEqual_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.LessThanOrEqual(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.GreaterThan(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThan_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.LessThan(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128GreaterThanOrEqual_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.GreaterThanOrEqual(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThanOrEqual_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.LessThanOrEqual(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.GreaterThan(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThan_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.LessThan(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256GreaterThanOrEqual_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.GreaterThanOrEqual(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThanOrEqual_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.LessThanOrEqual(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.GreaterThan(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThan_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.LessThan(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64GreaterThanOrEqual_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.GreaterThanOrEqual(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd64LessThanOrEqual_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.LessThanOrEqual(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.GreaterThan(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThan_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.LessThan(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128GreaterThanOrEqual_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.GreaterThanOrEqual(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd128LessThanOrEqual_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.LessThanOrEqual(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.GreaterThan(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThan_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.LessThan(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256GreaterThanOrEqual_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.GreaterThanOrEqual(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
        
        [Benchmark]
        public void Simd256LessThanOrEqual_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.LessThanOrEqual(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
    }
}