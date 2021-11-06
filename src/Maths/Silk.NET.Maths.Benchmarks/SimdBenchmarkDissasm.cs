// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using System.Runtime.Intrinsics;


namespace Silk.NET.Maths.Benchmark
{
    [SimpleJob(RuntimeMoniker.Net50, launchCount: 1, warmupCount: 3, targetCount: 3)]
    [DisassemblyDiagnoser(exportHtml: true)]
    public unsafe class SIMDDisasm
    {
        const int IterCount = 30;
        void* a;
        void* b;
        void* c;
        
        [GlobalSetup]
        public void Setup()
        {
            // native memory is not a thing on .net 5
            var byteCount = 256/*bits*/ / 8 * IterCount;
            a = (void*)Marshal.AllocHGlobal(byteCount);
            b = (void*)Marshal.AllocHGlobal(byteCount);
            c = (void*)Marshal.AllocHGlobal(byteCount);
            var rand = new Random();
            for (int i = 0; i < byteCount; i++)
            {
                *(byte*)a = (byte)rand.Next(1, 255);
                *(byte*)b = (byte)rand.Next(1, 255);
            }
        }

        [Benchmark]
        public void Simd64GreaterThan_byte()
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
        public void Simd64Add_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.Add(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Subtract_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.Subtract(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Multiply_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.Multiply(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Divide_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.Divide(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Min_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.Min(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Max_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.Max(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Equal_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.Equal(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64NotEqual_byte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<byte>*)c + i) = Simd64.NotEqual(*((Vector64<byte>*)a + i), *((Vector64<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128GreaterThan_byte()
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
        public void Simd128Add_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.Add(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Subtract_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.Subtract(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Multiply_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.Multiply(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Divide_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.Divide(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Min_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.Min(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Max_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.Max(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Equal_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.Equal(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128NotEqual_byte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<byte>*)c + i) = Simd128.NotEqual(*((Vector128<byte>*)a + i), *((Vector128<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256GreaterThan_byte()
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
        public void Simd256Add_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.Add(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Subtract_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.Subtract(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Multiply_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.Multiply(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Divide_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.Divide(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Min_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.Min(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Max_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.Max(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Equal_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.Equal(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256NotEqual_byte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<byte>*)c + i) = Simd256.NotEqual(*((Vector256<byte>*)a + i), *((Vector256<byte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64GreaterThan_sbyte()
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
        public void Simd64Add_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.Add(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Subtract_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.Subtract(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Multiply_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.Multiply(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Divide_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.Divide(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Min_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.Min(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Max_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.Max(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Equal_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.Equal(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64NotEqual_sbyte()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<sbyte>*)c + i) = Simd64.NotEqual(*((Vector64<sbyte>*)a + i), *((Vector64<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128GreaterThan_sbyte()
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
        public void Simd128Add_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.Add(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Subtract_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.Subtract(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Multiply_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.Multiply(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Divide_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.Divide(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Min_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.Min(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Max_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.Max(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Equal_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.Equal(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd128NotEqual_sbyte()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<sbyte>*)c + i) = Simd128.NotEqual(*((Vector128<sbyte>*)a + i), *((Vector128<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256GreaterThan_sbyte()
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
        public void Simd256Add_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.Add(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Subtract_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.Subtract(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Multiply_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.Multiply(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Divide_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.Divide(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Min_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.Min(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Max_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.Max(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Equal_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.Equal(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd256NotEqual_sbyte()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<sbyte>*)c + i) = Simd256.NotEqual(*((Vector256<sbyte>*)a + i), *((Vector256<sbyte>*)b + i)); 
        }
        [Benchmark]
        public void Simd64GreaterThan_ushort()
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
        public void Simd64Add_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.Add(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Subtract_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.Subtract(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Multiply_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.Multiply(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Divide_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.Divide(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Min_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.Min(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Max_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.Max(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Equal_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.Equal(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd64NotEqual_ushort()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ushort>*)c + i) = Simd64.NotEqual(*((Vector64<ushort>*)a + i), *((Vector64<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd128GreaterThan_ushort()
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
        public void Simd128Add_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.Add(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Subtract_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.Subtract(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Multiply_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.Multiply(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Divide_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.Divide(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Min_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.Min(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Max_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.Max(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Equal_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.Equal(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd128NotEqual_ushort()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ushort>*)c + i) = Simd128.NotEqual(*((Vector128<ushort>*)a + i), *((Vector128<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd256GreaterThan_ushort()
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
        public void Simd256Add_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.Add(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Subtract_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.Subtract(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Multiply_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.Multiply(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Divide_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.Divide(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Min_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.Min(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Max_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.Max(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Equal_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.Equal(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd256NotEqual_ushort()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ushort>*)c + i) = Simd256.NotEqual(*((Vector256<ushort>*)a + i), *((Vector256<ushort>*)b + i)); 
        }
        [Benchmark]
        public void Simd64GreaterThan_short()
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
        public void Simd64Add_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.Add(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Subtract_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.Subtract(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Multiply_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.Multiply(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Divide_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.Divide(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Min_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.Min(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Max_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.Max(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Equal_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.Equal(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd64NotEqual_short()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<short>*)c + i) = Simd64.NotEqual(*((Vector64<short>*)a + i), *((Vector64<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd128GreaterThan_short()
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
        public void Simd128Add_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.Add(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Subtract_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.Subtract(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Multiply_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.Multiply(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Divide_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.Divide(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Min_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.Min(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Max_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.Max(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Equal_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.Equal(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd128NotEqual_short()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<short>*)c + i) = Simd128.NotEqual(*((Vector128<short>*)a + i), *((Vector128<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd256GreaterThan_short()
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
        public void Simd256Add_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.Add(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Subtract_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.Subtract(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Multiply_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.Multiply(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Divide_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.Divide(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Min_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.Min(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Max_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.Max(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Equal_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.Equal(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd256NotEqual_short()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<short>*)c + i) = Simd256.NotEqual(*((Vector256<short>*)a + i), *((Vector256<short>*)b + i)); 
        }
        [Benchmark]
        public void Simd64GreaterThan_uint()
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
        public void Simd64Add_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.Add(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Subtract_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.Subtract(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Multiply_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.Multiply(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Divide_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.Divide(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Min_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.Min(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Max_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.Max(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Equal_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.Equal(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd64NotEqual_uint()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<uint>*)c + i) = Simd64.NotEqual(*((Vector64<uint>*)a + i), *((Vector64<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd128GreaterThan_uint()
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
        public void Simd128Add_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.Add(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Subtract_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.Subtract(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Multiply_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.Multiply(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Divide_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.Divide(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Min_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.Min(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Max_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.Max(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Equal_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.Equal(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd128NotEqual_uint()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<uint>*)c + i) = Simd128.NotEqual(*((Vector128<uint>*)a + i), *((Vector128<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd256GreaterThan_uint()
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
        public void Simd256Add_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.Add(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Subtract_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.Subtract(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Multiply_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.Multiply(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Divide_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.Divide(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Min_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.Min(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Max_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.Max(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Equal_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.Equal(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd256NotEqual_uint()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<uint>*)c + i) = Simd256.NotEqual(*((Vector256<uint>*)a + i), *((Vector256<uint>*)b + i)); 
        }
        [Benchmark]
        public void Simd64GreaterThan_int()
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
        public void Simd64Add_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.Add(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Subtract_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.Subtract(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Multiply_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.Multiply(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Divide_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.Divide(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Min_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.Min(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Max_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.Max(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Equal_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.Equal(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd64NotEqual_int()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<int>*)c + i) = Simd64.NotEqual(*((Vector64<int>*)a + i), *((Vector64<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd128GreaterThan_int()
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
        public void Simd128Add_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.Add(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Subtract_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.Subtract(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Multiply_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.Multiply(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Divide_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.Divide(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Min_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.Min(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Max_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.Max(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Equal_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.Equal(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd128NotEqual_int()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<int>*)c + i) = Simd128.NotEqual(*((Vector128<int>*)a + i), *((Vector128<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd256GreaterThan_int()
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
        public void Simd256Add_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.Add(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Subtract_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.Subtract(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Multiply_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.Multiply(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Divide_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.Divide(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Min_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.Min(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Max_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.Max(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Equal_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.Equal(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd256NotEqual_int()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<int>*)c + i) = Simd256.NotEqual(*((Vector256<int>*)a + i), *((Vector256<int>*)b + i)); 
        }
        [Benchmark]
        public void Simd64GreaterThan_ulong()
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
        public void Simd64Add_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.Add(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Subtract_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.Subtract(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Multiply_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.Multiply(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Divide_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.Divide(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Min_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.Min(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Max_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.Max(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Equal_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.Equal(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd64NotEqual_ulong()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<ulong>*)c + i) = Simd64.NotEqual(*((Vector64<ulong>*)a + i), *((Vector64<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd128GreaterThan_ulong()
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
        public void Simd128Add_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.Add(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Subtract_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.Subtract(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Multiply_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.Multiply(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Divide_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.Divide(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Min_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.Min(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Max_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.Max(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Equal_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.Equal(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd128NotEqual_ulong()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<ulong>*)c + i) = Simd128.NotEqual(*((Vector128<ulong>*)a + i), *((Vector128<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd256GreaterThan_ulong()
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
        public void Simd256Add_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.Add(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Subtract_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.Subtract(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Multiply_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.Multiply(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Divide_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.Divide(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Min_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.Min(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Max_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.Max(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Equal_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.Equal(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd256NotEqual_ulong()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<ulong>*)c + i) = Simd256.NotEqual(*((Vector256<ulong>*)a + i), *((Vector256<ulong>*)b + i)); 
        }
        [Benchmark]
        public void Simd64GreaterThan_long()
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
        public void Simd64Add_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.Add(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Subtract_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.Subtract(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Multiply_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.Multiply(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Divide_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.Divide(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Min_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.Min(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Max_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.Max(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Equal_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.Equal(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd64NotEqual_long()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<long>*)c + i) = Simd64.NotEqual(*((Vector64<long>*)a + i), *((Vector64<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd128GreaterThan_long()
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
        public void Simd128Add_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.Add(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Subtract_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.Subtract(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Multiply_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.Multiply(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Divide_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.Divide(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Min_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.Min(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Max_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.Max(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Equal_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.Equal(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd128NotEqual_long()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<long>*)c + i) = Simd128.NotEqual(*((Vector128<long>*)a + i), *((Vector128<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd256GreaterThan_long()
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
        public void Simd256Add_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.Add(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Subtract_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.Subtract(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Multiply_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.Multiply(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Divide_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.Divide(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Min_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.Min(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Max_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.Max(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Equal_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.Equal(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd256NotEqual_long()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<long>*)c + i) = Simd256.NotEqual(*((Vector256<long>*)a + i), *((Vector256<long>*)b + i)); 
        }
        [Benchmark]
        public void Simd64GreaterThan_float()
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
        public void Simd64Add_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.Add(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Subtract_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.Subtract(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Multiply_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.Multiply(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Divide_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.Divide(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Min_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.Min(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Max_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.Max(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Equal_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.Equal(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd64NotEqual_float()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<float>*)c + i) = Simd64.NotEqual(*((Vector64<float>*)a + i), *((Vector64<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd128GreaterThan_float()
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
        public void Simd128Add_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.Add(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Subtract_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.Subtract(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Multiply_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.Multiply(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Divide_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.Divide(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Min_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.Min(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Max_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.Max(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Equal_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.Equal(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd128NotEqual_float()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<float>*)c + i) = Simd128.NotEqual(*((Vector128<float>*)a + i), *((Vector128<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd256GreaterThan_float()
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
        public void Simd256Add_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.Add(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Subtract_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.Subtract(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Multiply_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.Multiply(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Divide_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.Divide(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Min_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.Min(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Max_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.Max(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Equal_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.Equal(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd256NotEqual_float()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<float>*)c + i) = Simd256.NotEqual(*((Vector256<float>*)a + i), *((Vector256<float>*)b + i)); 
        }
        [Benchmark]
        public void Simd64GreaterThan_double()
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
        public void Simd64Add_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.Add(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Subtract_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.Subtract(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Multiply_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.Multiply(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Divide_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.Divide(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Min_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.Min(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Max_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.Max(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd64Equal_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.Equal(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd64NotEqual_double()
        {
            for (int i = 0; i < IterCount * (4); i++)
                *((Vector64<double>*)c + i) = Simd64.NotEqual(*((Vector64<double>*)a + i), *((Vector64<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd128GreaterThan_double()
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
        public void Simd128Add_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.Add(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Subtract_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.Subtract(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Multiply_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.Multiply(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Divide_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.Divide(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Min_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.Min(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Max_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.Max(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd128Equal_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.Equal(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd128NotEqual_double()
        {
            for (int i = 0; i < IterCount * (2); i++)
                *((Vector128<double>*)c + i) = Simd128.NotEqual(*((Vector128<double>*)a + i), *((Vector128<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd256GreaterThan_double()
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
        [Benchmark]
        public void Simd256Add_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.Add(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Subtract_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.Subtract(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Multiply_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.Multiply(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Divide_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.Divide(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Min_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.Min(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Max_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.Max(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd256Equal_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.Equal(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
        [Benchmark]
        public void Simd256NotEqual_double()
        {
            for (int i = 0; i < IterCount * (1); i++)
                *((Vector256<double>*)c + i) = Simd256.NotEqual(*((Vector256<double>*)a + i), *((Vector256<double>*)b + i)); 
        }
    }
}