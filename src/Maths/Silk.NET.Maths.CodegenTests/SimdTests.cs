// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NET5_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CodegenAssertions;
using Xunit;

namespace Silk.NET.Maths.CodegenTests
{
    public class SimdCodegenTests
    {

#region Vector x Vector -> Vector 64-bit byte

        [Fact]
        public void Simd64GreaterThan_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThan<byte>(default, default));
        }
        [Fact]
        public void Simd64LessThan_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThan<byte>(default, default));
        }
        [Fact]
        public void Simd64GreaterThanOrEqual_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThanOrEqual<byte>(default, default));
        }
        [Fact]
        public void Simd64LessThanOrEqual_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThanOrEqual<byte>(default, default));
        }
        [Fact]
        public void Simd64Add_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Add<byte>(default, default));
        }
        [Fact]
        public void Simd64Subtract_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Subtract<byte>(default, default));
        }
        [Fact]
        public void Simd64Multiply_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Multiply<byte>(default, default));
        }
        [Fact]
        public void Simd64Divide_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Divide<byte>(default, default));
        }
        [Fact]
        public void Simd64Min_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Min<byte>(default, default));
        }
        [Fact]
        public void Simd64Max_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Max<byte>(default, default));
        }
        [Fact]
        public void Simd64Equal_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Equal<byte>(default, default));
        }
        [Fact]
        public void Simd64NotEqual_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.NotEqual<byte>(default, default));
        }
        [Fact]
        public void Simd64And_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.And<byte>(default, default));
        }
        [Fact]
        public void Simd64Xor_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Xor<byte>(default, default));
        }
        [Fact]
        public void Simd64Or_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Or<byte>(default, default));
        }

#endregion

#region Vector -> Vector 64-bit byte

        [Fact]
        public void Simd64Not_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Not<byte>(default)); 
        }
        [Fact]
        public void Simd64Abs_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Abs<byte>(default)); 
        }
        [Fact]
        public void Simd64IsFinite_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsFinite<byte>(default)); 
        }
        [Fact]
        public void Simd64IsInfinity_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsInfinity<byte>(default)); 
        }
        [Fact]
        public void Simd64IsNaN_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNaN<byte>(default)); 
        }
        [Fact]
        public void Simd64IsNegative_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegative<byte>(default)); 
        }
        [Fact]
        public void Simd64IsNegativeInfinity_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegativeInfinity<byte>(default)); 
        }
        [Fact]
        public void Simd64IsNormal_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNormal<byte>(default)); 
        }
        [Fact]
        public void Simd64IsPositiveInfinity_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsPositiveInfinity<byte>(default)); 
        }
        [Fact]
        public void Simd64Sign_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Sign<byte>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 128-bit byte

        [Fact]
        public void Simd128GreaterThan_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<byte>(default, default));
        }
        [Fact]
        public void Simd128LessThan_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<byte>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<byte>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<byte>(default, default));
        }
        [Fact]
        public void Simd128Add_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<byte>(default, default));
        }
        [Fact]
        public void Simd128Subtract_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<byte>(default, default));
        }
        [Fact]
        public void Simd128Multiply_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<byte>(default, default));
        }
        [Fact]
        public void Simd128Divide_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<byte>(default, default));
        }
        [Fact]
        public void Simd128Min_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<byte>(default, default));
        }
        [Fact]
        public void Simd128Max_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<byte>(default, default));
        }
        [Fact]
        public void Simd128Equal_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<byte>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<byte>(default, default));
        }
        [Fact]
        public void Simd128And_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<byte>(default, default));
        }
        [Fact]
        public void Simd128Xor_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<byte>(default, default));
        }
        [Fact]
        public void Simd128Or_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<byte>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit byte

        [Fact]
        public void Simd128Not_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<byte>(default)); 
        }
        [Fact]
        public void Simd128Abs_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<byte>(default)); 
        }
        [Fact]
        public void Simd128IsFinite_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<byte>(default)); 
        }
        [Fact]
        public void Simd128IsInfinity_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<byte>(default)); 
        }
        [Fact]
        public void Simd128IsNaN_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<byte>(default)); 
        }
        [Fact]
        public void Simd128IsNegative_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<byte>(default)); 
        }
        [Fact]
        public void Simd128IsNegativeInfinity_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<byte>(default)); 
        }
        [Fact]
        public void Simd128IsNormal_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<byte>(default)); 
        }
        [Fact]
        public void Simd128IsPositiveInfinity_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<byte>(default)); 
        }
        [Fact]
        public void Simd128Sign_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<byte>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 256-bit byte

        [Fact]
        public void Simd256GreaterThan_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<byte>(default, default));
        }
        [Fact]
        public void Simd256LessThan_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<byte>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<byte>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<byte>(default, default));
        }
        [Fact]
        public void Simd256Add_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<byte>(default, default));
        }
        [Fact]
        public void Simd256Subtract_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<byte>(default, default));
        }
        [Fact]
        public void Simd256Multiply_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<byte>(default, default));
        }
        [Fact]
        public void Simd256Divide_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<byte>(default, default));
        }
        [Fact]
        public void Simd256Min_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<byte>(default, default));
        }
        [Fact]
        public void Simd256Max_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<byte>(default, default));
        }
        [Fact]
        public void Simd256Equal_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<byte>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<byte>(default, default));
        }
        [Fact]
        public void Simd256And_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<byte>(default, default));
        }
        [Fact]
        public void Simd256Xor_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<byte>(default, default));
        }
        [Fact]
        public void Simd256Or_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<byte>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit byte

        [Fact]
        public void Simd256Not_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<byte>(default)); 
        }
        [Fact]
        public void Simd256Abs_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<byte>(default)); 
        }
        [Fact]
        public void Simd256IsFinite_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<byte>(default)); 
        }
        [Fact]
        public void Simd256IsInfinity_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<byte>(default)); 
        }
        [Fact]
        public void Simd256IsNaN_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<byte>(default)); 
        }
        [Fact]
        public void Simd256IsNegative_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<byte>(default)); 
        }
        [Fact]
        public void Simd256IsNegativeInfinity_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<byte>(default)); 
        }
        [Fact]
        public void Simd256IsNormal_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<byte>(default)); 
        }
        [Fact]
        public void Simd256IsPositiveInfinity_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<byte>(default)); 
        }
        [Fact]
        public void Simd256Sign_byte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<byte>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 64-bit sbyte

        [Fact]
        public void Simd64GreaterThan_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThan<sbyte>(default, default));
        }
        [Fact]
        public void Simd64LessThan_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThan<sbyte>(default, default));
        }
        [Fact]
        public void Simd64GreaterThanOrEqual_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThanOrEqual<sbyte>(default, default));
        }
        [Fact]
        public void Simd64LessThanOrEqual_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThanOrEqual<sbyte>(default, default));
        }
        [Fact]
        public void Simd64Add_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Add<sbyte>(default, default));
        }
        [Fact]
        public void Simd64Subtract_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Subtract<sbyte>(default, default));
        }
        [Fact]
        public void Simd64Multiply_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Multiply<sbyte>(default, default));
        }
        [Fact]
        public void Simd64Divide_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Divide<sbyte>(default, default));
        }
        [Fact]
        public void Simd64Min_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Min<sbyte>(default, default));
        }
        [Fact]
        public void Simd64Max_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Max<sbyte>(default, default));
        }
        [Fact]
        public void Simd64Equal_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Equal<sbyte>(default, default));
        }
        [Fact]
        public void Simd64NotEqual_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.NotEqual<sbyte>(default, default));
        }
        [Fact]
        public void Simd64And_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.And<sbyte>(default, default));
        }
        [Fact]
        public void Simd64Xor_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Xor<sbyte>(default, default));
        }
        [Fact]
        public void Simd64Or_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Or<sbyte>(default, default));
        }

#endregion

#region Vector -> Vector 64-bit sbyte

        [Fact]
        public void Simd64Not_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Not<sbyte>(default)); 
        }
        [Fact]
        public void Simd64Abs_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Abs<sbyte>(default)); 
        }
        [Fact]
        public void Simd64IsFinite_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsFinite<sbyte>(default)); 
        }
        [Fact]
        public void Simd64IsInfinity_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsInfinity<sbyte>(default)); 
        }
        [Fact]
        public void Simd64IsNaN_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNaN<sbyte>(default)); 
        }
        [Fact]
        public void Simd64IsNegative_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegative<sbyte>(default)); 
        }
        [Fact]
        public void Simd64IsNegativeInfinity_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegativeInfinity<sbyte>(default)); 
        }
        [Fact]
        public void Simd64IsNormal_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNormal<sbyte>(default)); 
        }
        [Fact]
        public void Simd64IsPositiveInfinity_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsPositiveInfinity<sbyte>(default)); 
        }
        [Fact]
        public void Simd64Sign_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Sign<sbyte>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 128-bit sbyte

        [Fact]
        public void Simd128GreaterThan_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<sbyte>(default, default));
        }
        [Fact]
        public void Simd128LessThan_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<sbyte>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<sbyte>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<sbyte>(default, default));
        }
        [Fact]
        public void Simd128Add_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<sbyte>(default, default));
        }
        [Fact]
        public void Simd128Subtract_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<sbyte>(default, default));
        }
        [Fact]
        public void Simd128Multiply_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<sbyte>(default, default));
        }
        [Fact]
        public void Simd128Divide_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<sbyte>(default, default));
        }
        [Fact]
        public void Simd128Min_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<sbyte>(default, default));
        }
        [Fact]
        public void Simd128Max_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<sbyte>(default, default));
        }
        [Fact]
        public void Simd128Equal_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<sbyte>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<sbyte>(default, default));
        }
        [Fact]
        public void Simd128And_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<sbyte>(default, default));
        }
        [Fact]
        public void Simd128Xor_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<sbyte>(default, default));
        }
        [Fact]
        public void Simd128Or_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<sbyte>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit sbyte

        [Fact]
        public void Simd128Not_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<sbyte>(default)); 
        }
        [Fact]
        public void Simd128Abs_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<sbyte>(default)); 
        }
        [Fact]
        public void Simd128IsFinite_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<sbyte>(default)); 
        }
        [Fact]
        public void Simd128IsInfinity_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<sbyte>(default)); 
        }
        [Fact]
        public void Simd128IsNaN_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<sbyte>(default)); 
        }
        [Fact]
        public void Simd128IsNegative_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<sbyte>(default)); 
        }
        [Fact]
        public void Simd128IsNegativeInfinity_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<sbyte>(default)); 
        }
        [Fact]
        public void Simd128IsNormal_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<sbyte>(default)); 
        }
        [Fact]
        public void Simd128IsPositiveInfinity_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<sbyte>(default)); 
        }
        [Fact]
        public void Simd128Sign_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<sbyte>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 256-bit sbyte

        [Fact]
        public void Simd256GreaterThan_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<sbyte>(default, default));
        }
        [Fact]
        public void Simd256LessThan_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<sbyte>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<sbyte>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<sbyte>(default, default));
        }
        [Fact]
        public void Simd256Add_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<sbyte>(default, default));
        }
        [Fact]
        public void Simd256Subtract_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<sbyte>(default, default));
        }
        [Fact]
        public void Simd256Multiply_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<sbyte>(default, default));
        }
        [Fact]
        public void Simd256Divide_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<sbyte>(default, default));
        }
        [Fact]
        public void Simd256Min_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<sbyte>(default, default));
        }
        [Fact]
        public void Simd256Max_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<sbyte>(default, default));
        }
        [Fact]
        public void Simd256Equal_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<sbyte>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<sbyte>(default, default));
        }
        [Fact]
        public void Simd256And_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<sbyte>(default, default));
        }
        [Fact]
        public void Simd256Xor_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<sbyte>(default, default));
        }
        [Fact]
        public void Simd256Or_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<sbyte>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit sbyte

        [Fact]
        public void Simd256Not_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<sbyte>(default)); 
        }
        [Fact]
        public void Simd256Abs_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<sbyte>(default)); 
        }
        [Fact]
        public void Simd256IsFinite_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<sbyte>(default)); 
        }
        [Fact]
        public void Simd256IsInfinity_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<sbyte>(default)); 
        }
        [Fact]
        public void Simd256IsNaN_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<sbyte>(default)); 
        }
        [Fact]
        public void Simd256IsNegative_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<sbyte>(default)); 
        }
        [Fact]
        public void Simd256IsNegativeInfinity_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<sbyte>(default)); 
        }
        [Fact]
        public void Simd256IsNormal_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<sbyte>(default)); 
        }
        [Fact]
        public void Simd256IsPositiveInfinity_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<sbyte>(default)); 
        }
        [Fact]
        public void Simd256Sign_sbyte()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<sbyte>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 64-bit ushort

        [Fact]
        public void Simd64GreaterThan_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThan<ushort>(default, default));
        }
        [Fact]
        public void Simd64LessThan_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThan<ushort>(default, default));
        }
        [Fact]
        public void Simd64GreaterThanOrEqual_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThanOrEqual<ushort>(default, default));
        }
        [Fact]
        public void Simd64LessThanOrEqual_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThanOrEqual<ushort>(default, default));
        }
        [Fact]
        public void Simd64Add_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Add<ushort>(default, default));
        }
        [Fact]
        public void Simd64Subtract_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Subtract<ushort>(default, default));
        }
        [Fact]
        public void Simd64Multiply_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Multiply<ushort>(default, default));
        }
        [Fact]
        public void Simd64Divide_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Divide<ushort>(default, default));
        }
        [Fact]
        public void Simd64Min_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Min<ushort>(default, default));
        }
        [Fact]
        public void Simd64Max_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Max<ushort>(default, default));
        }
        [Fact]
        public void Simd64Equal_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Equal<ushort>(default, default));
        }
        [Fact]
        public void Simd64NotEqual_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.NotEqual<ushort>(default, default));
        }
        [Fact]
        public void Simd64And_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.And<ushort>(default, default));
        }
        [Fact]
        public void Simd64Xor_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Xor<ushort>(default, default));
        }
        [Fact]
        public void Simd64Or_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Or<ushort>(default, default));
        }

#endregion

#region Vector -> Vector 64-bit ushort

        [Fact]
        public void Simd64Not_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Not<ushort>(default)); 
        }
        [Fact]
        public void Simd64Abs_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Abs<ushort>(default)); 
        }
        [Fact]
        public void Simd64IsFinite_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsFinite<ushort>(default)); 
        }
        [Fact]
        public void Simd64IsInfinity_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsInfinity<ushort>(default)); 
        }
        [Fact]
        public void Simd64IsNaN_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNaN<ushort>(default)); 
        }
        [Fact]
        public void Simd64IsNegative_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegative<ushort>(default)); 
        }
        [Fact]
        public void Simd64IsNegativeInfinity_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegativeInfinity<ushort>(default)); 
        }
        [Fact]
        public void Simd64IsNormal_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNormal<ushort>(default)); 
        }
        [Fact]
        public void Simd64IsPositiveInfinity_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsPositiveInfinity<ushort>(default)); 
        }
        [Fact]
        public void Simd64Sign_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Sign<ushort>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 128-bit ushort

        [Fact]
        public void Simd128GreaterThan_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<ushort>(default, default));
        }
        [Fact]
        public void Simd128LessThan_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<ushort>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<ushort>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<ushort>(default, default));
        }
        [Fact]
        public void Simd128Add_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<ushort>(default, default));
        }
        [Fact]
        public void Simd128Subtract_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<ushort>(default, default));
        }
        [Fact]
        public void Simd128Multiply_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<ushort>(default, default));
        }
        [Fact]
        public void Simd128Divide_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<ushort>(default, default));
        }
        [Fact]
        public void Simd128Min_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<ushort>(default, default));
        }
        [Fact]
        public void Simd128Max_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<ushort>(default, default));
        }
        [Fact]
        public void Simd128Equal_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<ushort>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<ushort>(default, default));
        }
        [Fact]
        public void Simd128And_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<ushort>(default, default));
        }
        [Fact]
        public void Simd128Xor_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<ushort>(default, default));
        }
        [Fact]
        public void Simd128Or_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<ushort>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit ushort

        [Fact]
        public void Simd128Not_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<ushort>(default)); 
        }
        [Fact]
        public void Simd128Abs_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<ushort>(default)); 
        }
        [Fact]
        public void Simd128IsFinite_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<ushort>(default)); 
        }
        [Fact]
        public void Simd128IsInfinity_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<ushort>(default)); 
        }
        [Fact]
        public void Simd128IsNaN_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<ushort>(default)); 
        }
        [Fact]
        public void Simd128IsNegative_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<ushort>(default)); 
        }
        [Fact]
        public void Simd128IsNegativeInfinity_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<ushort>(default)); 
        }
        [Fact]
        public void Simd128IsNormal_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<ushort>(default)); 
        }
        [Fact]
        public void Simd128IsPositiveInfinity_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<ushort>(default)); 
        }
        [Fact]
        public void Simd128Sign_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<ushort>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 256-bit ushort

        [Fact]
        public void Simd256GreaterThan_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<ushort>(default, default));
        }
        [Fact]
        public void Simd256LessThan_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<ushort>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<ushort>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<ushort>(default, default));
        }
        [Fact]
        public void Simd256Add_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<ushort>(default, default));
        }
        [Fact]
        public void Simd256Subtract_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<ushort>(default, default));
        }
        [Fact]
        public void Simd256Multiply_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<ushort>(default, default));
        }
        [Fact]
        public void Simd256Divide_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<ushort>(default, default));
        }
        [Fact]
        public void Simd256Min_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<ushort>(default, default));
        }
        [Fact]
        public void Simd256Max_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<ushort>(default, default));
        }
        [Fact]
        public void Simd256Equal_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<ushort>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<ushort>(default, default));
        }
        [Fact]
        public void Simd256And_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<ushort>(default, default));
        }
        [Fact]
        public void Simd256Xor_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<ushort>(default, default));
        }
        [Fact]
        public void Simd256Or_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<ushort>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit ushort

        [Fact]
        public void Simd256Not_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<ushort>(default)); 
        }
        [Fact]
        public void Simd256Abs_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<ushort>(default)); 
        }
        [Fact]
        public void Simd256IsFinite_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<ushort>(default)); 
        }
        [Fact]
        public void Simd256IsInfinity_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<ushort>(default)); 
        }
        [Fact]
        public void Simd256IsNaN_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<ushort>(default)); 
        }
        [Fact]
        public void Simd256IsNegative_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<ushort>(default)); 
        }
        [Fact]
        public void Simd256IsNegativeInfinity_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<ushort>(default)); 
        }
        [Fact]
        public void Simd256IsNormal_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<ushort>(default)); 
        }
        [Fact]
        public void Simd256IsPositiveInfinity_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<ushort>(default)); 
        }
        [Fact]
        public void Simd256Sign_ushort()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<ushort>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 64-bit short

        [Fact]
        public void Simd64GreaterThan_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThan<short>(default, default));
        }
        [Fact]
        public void Simd64LessThan_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThan<short>(default, default));
        }
        [Fact]
        public void Simd64GreaterThanOrEqual_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThanOrEqual<short>(default, default));
        }
        [Fact]
        public void Simd64LessThanOrEqual_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThanOrEqual<short>(default, default));
        }
        [Fact]
        public void Simd64Add_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Add<short>(default, default));
        }
        [Fact]
        public void Simd64Subtract_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Subtract<short>(default, default));
        }
        [Fact]
        public void Simd64Multiply_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Multiply<short>(default, default));
        }
        [Fact]
        public void Simd64Divide_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Divide<short>(default, default));
        }
        [Fact]
        public void Simd64Min_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Min<short>(default, default));
        }
        [Fact]
        public void Simd64Max_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Max<short>(default, default));
        }
        [Fact]
        public void Simd64Equal_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Equal<short>(default, default));
        }
        [Fact]
        public void Simd64NotEqual_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.NotEqual<short>(default, default));
        }
        [Fact]
        public void Simd64And_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.And<short>(default, default));
        }
        [Fact]
        public void Simd64Xor_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Xor<short>(default, default));
        }
        [Fact]
        public void Simd64Or_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Or<short>(default, default));
        }

#endregion

#region Vector -> Vector 64-bit short

        [Fact]
        public void Simd64Not_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Not<short>(default)); 
        }
        [Fact]
        public void Simd64Abs_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Abs<short>(default)); 
        }
        [Fact]
        public void Simd64IsFinite_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsFinite<short>(default)); 
        }
        [Fact]
        public void Simd64IsInfinity_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsInfinity<short>(default)); 
        }
        [Fact]
        public void Simd64IsNaN_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNaN<short>(default)); 
        }
        [Fact]
        public void Simd64IsNegative_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegative<short>(default)); 
        }
        [Fact]
        public void Simd64IsNegativeInfinity_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegativeInfinity<short>(default)); 
        }
        [Fact]
        public void Simd64IsNormal_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNormal<short>(default)); 
        }
        [Fact]
        public void Simd64IsPositiveInfinity_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsPositiveInfinity<short>(default)); 
        }
        [Fact]
        public void Simd64Sign_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Sign<short>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 128-bit short

        [Fact]
        public void Simd128GreaterThan_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<short>(default, default));
        }
        [Fact]
        public void Simd128LessThan_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<short>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<short>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<short>(default, default));
        }
        [Fact]
        public void Simd128Add_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<short>(default, default));
        }
        [Fact]
        public void Simd128Subtract_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<short>(default, default));
        }
        [Fact]
        public void Simd128Multiply_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<short>(default, default));
        }
        [Fact]
        public void Simd128Divide_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<short>(default, default));
        }
        [Fact]
        public void Simd128Min_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<short>(default, default));
        }
        [Fact]
        public void Simd128Max_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<short>(default, default));
        }
        [Fact]
        public void Simd128Equal_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<short>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<short>(default, default));
        }
        [Fact]
        public void Simd128And_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<short>(default, default));
        }
        [Fact]
        public void Simd128Xor_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<short>(default, default));
        }
        [Fact]
        public void Simd128Or_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<short>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit short

        [Fact]
        public void Simd128Not_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<short>(default)); 
        }
        [Fact]
        public void Simd128Abs_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<short>(default)); 
        }
        [Fact]
        public void Simd128IsFinite_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<short>(default)); 
        }
        [Fact]
        public void Simd128IsInfinity_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<short>(default)); 
        }
        [Fact]
        public void Simd128IsNaN_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<short>(default)); 
        }
        [Fact]
        public void Simd128IsNegative_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<short>(default)); 
        }
        [Fact]
        public void Simd128IsNegativeInfinity_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<short>(default)); 
        }
        [Fact]
        public void Simd128IsNormal_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<short>(default)); 
        }
        [Fact]
        public void Simd128IsPositiveInfinity_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<short>(default)); 
        }
        [Fact]
        public void Simd128Sign_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<short>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 256-bit short

        [Fact]
        public void Simd256GreaterThan_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<short>(default, default));
        }
        [Fact]
        public void Simd256LessThan_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<short>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<short>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<short>(default, default));
        }
        [Fact]
        public void Simd256Add_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<short>(default, default));
        }
        [Fact]
        public void Simd256Subtract_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<short>(default, default));
        }
        [Fact]
        public void Simd256Multiply_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<short>(default, default));
        }
        [Fact]
        public void Simd256Divide_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<short>(default, default));
        }
        [Fact]
        public void Simd256Min_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<short>(default, default));
        }
        [Fact]
        public void Simd256Max_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<short>(default, default));
        }
        [Fact]
        public void Simd256Equal_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<short>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<short>(default, default));
        }
        [Fact]
        public void Simd256And_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<short>(default, default));
        }
        [Fact]
        public void Simd256Xor_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<short>(default, default));
        }
        [Fact]
        public void Simd256Or_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<short>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit short

        [Fact]
        public void Simd256Not_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<short>(default)); 
        }
        [Fact]
        public void Simd256Abs_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<short>(default)); 
        }
        [Fact]
        public void Simd256IsFinite_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<short>(default)); 
        }
        [Fact]
        public void Simd256IsInfinity_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<short>(default)); 
        }
        [Fact]
        public void Simd256IsNaN_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<short>(default)); 
        }
        [Fact]
        public void Simd256IsNegative_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<short>(default)); 
        }
        [Fact]
        public void Simd256IsNegativeInfinity_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<short>(default)); 
        }
        [Fact]
        public void Simd256IsNormal_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<short>(default)); 
        }
        [Fact]
        public void Simd256IsPositiveInfinity_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<short>(default)); 
        }
        [Fact]
        public void Simd256Sign_short()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<short>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 64-bit uint

        [Fact]
        public void Simd64GreaterThan_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThan<uint>(default, default));
        }
        [Fact]
        public void Simd64LessThan_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThan<uint>(default, default));
        }
        [Fact]
        public void Simd64GreaterThanOrEqual_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThanOrEqual<uint>(default, default));
        }
        [Fact]
        public void Simd64LessThanOrEqual_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThanOrEqual<uint>(default, default));
        }
        [Fact]
        public void Simd64Add_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Add<uint>(default, default));
        }
        [Fact]
        public void Simd64Subtract_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Subtract<uint>(default, default));
        }
        [Fact]
        public void Simd64Multiply_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Multiply<uint>(default, default));
        }
        [Fact]
        public void Simd64Divide_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Divide<uint>(default, default));
        }
        [Fact]
        public void Simd64Min_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Min<uint>(default, default));
        }
        [Fact]
        public void Simd64Max_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Max<uint>(default, default));
        }
        [Fact]
        public void Simd64Equal_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Equal<uint>(default, default));
        }
        [Fact]
        public void Simd64NotEqual_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.NotEqual<uint>(default, default));
        }
        [Fact]
        public void Simd64And_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.And<uint>(default, default));
        }
        [Fact]
        public void Simd64Xor_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Xor<uint>(default, default));
        }
        [Fact]
        public void Simd64Or_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Or<uint>(default, default));
        }

#endregion

#region Vector -> Vector 64-bit uint

        [Fact]
        public void Simd64Not_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Not<uint>(default)); 
        }
        [Fact]
        public void Simd64Abs_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Abs<uint>(default)); 
        }
        [Fact]
        public void Simd64IsFinite_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsFinite<uint>(default)); 
        }
        [Fact]
        public void Simd64IsInfinity_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsInfinity<uint>(default)); 
        }
        [Fact]
        public void Simd64IsNaN_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNaN<uint>(default)); 
        }
        [Fact]
        public void Simd64IsNegative_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegative<uint>(default)); 
        }
        [Fact]
        public void Simd64IsNegativeInfinity_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegativeInfinity<uint>(default)); 
        }
        [Fact]
        public void Simd64IsNormal_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNormal<uint>(default)); 
        }
        [Fact]
        public void Simd64IsPositiveInfinity_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsPositiveInfinity<uint>(default)); 
        }
        [Fact]
        public void Simd64Sign_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Sign<uint>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 128-bit uint

        [Fact]
        public void Simd128GreaterThan_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<uint>(default, default));
        }
        [Fact]
        public void Simd128LessThan_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<uint>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<uint>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<uint>(default, default));
        }
        [Fact]
        public void Simd128Add_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<uint>(default, default));
        }
        [Fact]
        public void Simd128Subtract_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<uint>(default, default));
        }
        [Fact]
        public void Simd128Multiply_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<uint>(default, default));
        }
        [Fact]
        public void Simd128Divide_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<uint>(default, default));
        }
        [Fact]
        public void Simd128Min_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<uint>(default, default));
        }
        [Fact]
        public void Simd128Max_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<uint>(default, default));
        }
        [Fact]
        public void Simd128Equal_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<uint>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<uint>(default, default));
        }
        [Fact]
        public void Simd128And_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<uint>(default, default));
        }
        [Fact]
        public void Simd128Xor_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<uint>(default, default));
        }
        [Fact]
        public void Simd128Or_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<uint>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit uint

        [Fact]
        public void Simd128Not_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<uint>(default)); 
        }
        [Fact]
        public void Simd128Abs_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<uint>(default)); 
        }
        [Fact]
        public void Simd128IsFinite_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<uint>(default)); 
        }
        [Fact]
        public void Simd128IsInfinity_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<uint>(default)); 
        }
        [Fact]
        public void Simd128IsNaN_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<uint>(default)); 
        }
        [Fact]
        public void Simd128IsNegative_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<uint>(default)); 
        }
        [Fact]
        public void Simd128IsNegativeInfinity_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<uint>(default)); 
        }
        [Fact]
        public void Simd128IsNormal_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<uint>(default)); 
        }
        [Fact]
        public void Simd128IsPositiveInfinity_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<uint>(default)); 
        }
        [Fact]
        public void Simd128Sign_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<uint>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 256-bit uint

        [Fact]
        public void Simd256GreaterThan_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<uint>(default, default));
        }
        [Fact]
        public void Simd256LessThan_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<uint>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<uint>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<uint>(default, default));
        }
        [Fact]
        public void Simd256Add_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<uint>(default, default));
        }
        [Fact]
        public void Simd256Subtract_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<uint>(default, default));
        }
        [Fact]
        public void Simd256Multiply_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<uint>(default, default));
        }
        [Fact]
        public void Simd256Divide_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<uint>(default, default));
        }
        [Fact]
        public void Simd256Min_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<uint>(default, default));
        }
        [Fact]
        public void Simd256Max_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<uint>(default, default));
        }
        [Fact]
        public void Simd256Equal_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<uint>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<uint>(default, default));
        }
        [Fact]
        public void Simd256And_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<uint>(default, default));
        }
        [Fact]
        public void Simd256Xor_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<uint>(default, default));
        }
        [Fact]
        public void Simd256Or_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<uint>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit uint

        [Fact]
        public void Simd256Not_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<uint>(default)); 
        }
        [Fact]
        public void Simd256Abs_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<uint>(default)); 
        }
        [Fact]
        public void Simd256IsFinite_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<uint>(default)); 
        }
        [Fact]
        public void Simd256IsInfinity_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<uint>(default)); 
        }
        [Fact]
        public void Simd256IsNaN_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<uint>(default)); 
        }
        [Fact]
        public void Simd256IsNegative_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<uint>(default)); 
        }
        [Fact]
        public void Simd256IsNegativeInfinity_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<uint>(default)); 
        }
        [Fact]
        public void Simd256IsNormal_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<uint>(default)); 
        }
        [Fact]
        public void Simd256IsPositiveInfinity_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<uint>(default)); 
        }
        [Fact]
        public void Simd256Sign_uint()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<uint>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 64-bit int

        [Fact]
        public void Simd64GreaterThan_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThan<int>(default, default));
        }
        [Fact]
        public void Simd64LessThan_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThan<int>(default, default));
        }
        [Fact]
        public void Simd64GreaterThanOrEqual_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThanOrEqual<int>(default, default));
        }
        [Fact]
        public void Simd64LessThanOrEqual_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThanOrEqual<int>(default, default));
        }
        [Fact]
        public void Simd64Add_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Add<int>(default, default));
        }
        [Fact]
        public void Simd64Subtract_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Subtract<int>(default, default));
        }
        [Fact]
        public void Simd64Multiply_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Multiply<int>(default, default));
        }
        [Fact]
        public void Simd64Divide_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Divide<int>(default, default));
        }
        [Fact]
        public void Simd64Min_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Min<int>(default, default));
        }
        [Fact]
        public void Simd64Max_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Max<int>(default, default));
        }
        [Fact]
        public void Simd64Equal_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Equal<int>(default, default));
        }
        [Fact]
        public void Simd64NotEqual_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.NotEqual<int>(default, default));
        }
        [Fact]
        public void Simd64And_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.And<int>(default, default));
        }
        [Fact]
        public void Simd64Xor_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Xor<int>(default, default));
        }
        [Fact]
        public void Simd64Or_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Or<int>(default, default));
        }

#endregion

#region Vector -> Vector 64-bit int

        [Fact]
        public void Simd64Not_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Not<int>(default)); 
        }
        [Fact]
        public void Simd64Abs_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Abs<int>(default)); 
        }
        [Fact]
        public void Simd64IsFinite_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsFinite<int>(default)); 
        }
        [Fact]
        public void Simd64IsInfinity_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsInfinity<int>(default)); 
        }
        [Fact]
        public void Simd64IsNaN_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNaN<int>(default)); 
        }
        [Fact]
        public void Simd64IsNegative_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegative<int>(default)); 
        }
        [Fact]
        public void Simd64IsNegativeInfinity_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegativeInfinity<int>(default)); 
        }
        [Fact]
        public void Simd64IsNormal_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNormal<int>(default)); 
        }
        [Fact]
        public void Simd64IsPositiveInfinity_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsPositiveInfinity<int>(default)); 
        }
        [Fact]
        public void Simd64Sign_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Sign<int>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 128-bit int

        [Fact]
        public void Simd128GreaterThan_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<int>(default, default));
        }
        [Fact]
        public void Simd128LessThan_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<int>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<int>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<int>(default, default));
        }
        [Fact]
        public void Simd128Add_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<int>(default, default));
        }
        [Fact]
        public void Simd128Subtract_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<int>(default, default));
        }
        [Fact]
        public void Simd128Multiply_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<int>(default, default));
        }
        [Fact]
        public void Simd128Divide_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<int>(default, default));
        }
        [Fact]
        public void Simd128Min_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<int>(default, default));
        }
        [Fact]
        public void Simd128Max_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<int>(default, default));
        }
        [Fact]
        public void Simd128Equal_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<int>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<int>(default, default));
        }
        [Fact]
        public void Simd128And_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<int>(default, default));
        }
        [Fact]
        public void Simd128Xor_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<int>(default, default));
        }
        [Fact]
        public void Simd128Or_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<int>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit int

        [Fact]
        public void Simd128Not_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<int>(default)); 
        }
        [Fact]
        public void Simd128Abs_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<int>(default)); 
        }
        [Fact]
        public void Simd128IsFinite_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<int>(default)); 
        }
        [Fact]
        public void Simd128IsInfinity_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<int>(default)); 
        }
        [Fact]
        public void Simd128IsNaN_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<int>(default)); 
        }
        [Fact]
        public void Simd128IsNegative_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<int>(default)); 
        }
        [Fact]
        public void Simd128IsNegativeInfinity_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<int>(default)); 
        }
        [Fact]
        public void Simd128IsNormal_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<int>(default)); 
        }
        [Fact]
        public void Simd128IsPositiveInfinity_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<int>(default)); 
        }
        [Fact]
        public void Simd128Sign_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<int>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 256-bit int

        [Fact]
        public void Simd256GreaterThan_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<int>(default, default));
        }
        [Fact]
        public void Simd256LessThan_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<int>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<int>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<int>(default, default));
        }
        [Fact]
        public void Simd256Add_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<int>(default, default));
        }
        [Fact]
        public void Simd256Subtract_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<int>(default, default));
        }
        [Fact]
        public void Simd256Multiply_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<int>(default, default));
        }
        [Fact]
        public void Simd256Divide_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<int>(default, default));
        }
        [Fact]
        public void Simd256Min_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<int>(default, default));
        }
        [Fact]
        public void Simd256Max_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<int>(default, default));
        }
        [Fact]
        public void Simd256Equal_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<int>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<int>(default, default));
        }
        [Fact]
        public void Simd256And_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<int>(default, default));
        }
        [Fact]
        public void Simd256Xor_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<int>(default, default));
        }
        [Fact]
        public void Simd256Or_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<int>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit int

        [Fact]
        public void Simd256Not_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<int>(default)); 
        }
        [Fact]
        public void Simd256Abs_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<int>(default)); 
        }
        [Fact]
        public void Simd256IsFinite_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<int>(default)); 
        }
        [Fact]
        public void Simd256IsInfinity_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<int>(default)); 
        }
        [Fact]
        public void Simd256IsNaN_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<int>(default)); 
        }
        [Fact]
        public void Simd256IsNegative_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<int>(default)); 
        }
        [Fact]
        public void Simd256IsNegativeInfinity_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<int>(default)); 
        }
        [Fact]
        public void Simd256IsNormal_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<int>(default)); 
        }
        [Fact]
        public void Simd256IsPositiveInfinity_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<int>(default)); 
        }
        [Fact]
        public void Simd256Sign_int()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<int>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 64-bit ulong

        [Fact]
        public void Simd64GreaterThan_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThan<ulong>(default, default));
        }
        [Fact]
        public void Simd64LessThan_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThan<ulong>(default, default));
        }
        [Fact]
        public void Simd64GreaterThanOrEqual_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThanOrEqual<ulong>(default, default));
        }
        [Fact]
        public void Simd64LessThanOrEqual_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThanOrEqual<ulong>(default, default));
        }
        [Fact]
        public void Simd64Add_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Add<ulong>(default, default));
        }
        [Fact]
        public void Simd64Subtract_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Subtract<ulong>(default, default));
        }
        [Fact]
        public void Simd64Multiply_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Multiply<ulong>(default, default));
        }
        [Fact]
        public void Simd64Divide_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Divide<ulong>(default, default));
        }
        [Fact]
        public void Simd64Min_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Min<ulong>(default, default));
        }
        [Fact]
        public void Simd64Max_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Max<ulong>(default, default));
        }
        [Fact]
        public void Simd64Equal_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Equal<ulong>(default, default));
        }
        [Fact]
        public void Simd64NotEqual_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.NotEqual<ulong>(default, default));
        }
        [Fact]
        public void Simd64And_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.And<ulong>(default, default));
        }
        [Fact]
        public void Simd64Xor_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Xor<ulong>(default, default));
        }
        [Fact]
        public void Simd64Or_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Or<ulong>(default, default));
        }

#endregion

#region Vector -> Vector 64-bit ulong

        [Fact]
        public void Simd64Not_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Not<ulong>(default)); 
        }
        [Fact]
        public void Simd64Abs_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Abs<ulong>(default)); 
        }
        [Fact]
        public void Simd64IsFinite_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsFinite<ulong>(default)); 
        }
        [Fact]
        public void Simd64IsInfinity_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsInfinity<ulong>(default)); 
        }
        [Fact]
        public void Simd64IsNaN_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNaN<ulong>(default)); 
        }
        [Fact]
        public void Simd64IsNegative_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegative<ulong>(default)); 
        }
        [Fact]
        public void Simd64IsNegativeInfinity_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegativeInfinity<ulong>(default)); 
        }
        [Fact]
        public void Simd64IsNormal_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNormal<ulong>(default)); 
        }
        [Fact]
        public void Simd64IsPositiveInfinity_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsPositiveInfinity<ulong>(default)); 
        }
        [Fact]
        public void Simd64Sign_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Sign<ulong>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 128-bit ulong

        [Fact]
        public void Simd128GreaterThan_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<ulong>(default, default));
        }
        [Fact]
        public void Simd128LessThan_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<ulong>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<ulong>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<ulong>(default, default));
        }
        [Fact]
        public void Simd128Add_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<ulong>(default, default));
        }
        [Fact]
        public void Simd128Subtract_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<ulong>(default, default));
        }
        [Fact]
        public void Simd128Multiply_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<ulong>(default, default));
        }
        [Fact]
        public void Simd128Divide_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<ulong>(default, default));
        }
        [Fact]
        public void Simd128Min_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<ulong>(default, default));
        }
        [Fact]
        public void Simd128Max_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<ulong>(default, default));
        }
        [Fact]
        public void Simd128Equal_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<ulong>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<ulong>(default, default));
        }
        [Fact]
        public void Simd128And_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<ulong>(default, default));
        }
        [Fact]
        public void Simd128Xor_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<ulong>(default, default));
        }
        [Fact]
        public void Simd128Or_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<ulong>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit ulong

        [Fact]
        public void Simd128Not_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<ulong>(default)); 
        }
        [Fact]
        public void Simd128Abs_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<ulong>(default)); 
        }
        [Fact]
        public void Simd128IsFinite_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<ulong>(default)); 
        }
        [Fact]
        public void Simd128IsInfinity_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<ulong>(default)); 
        }
        [Fact]
        public void Simd128IsNaN_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<ulong>(default)); 
        }
        [Fact]
        public void Simd128IsNegative_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<ulong>(default)); 
        }
        [Fact]
        public void Simd128IsNegativeInfinity_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<ulong>(default)); 
        }
        [Fact]
        public void Simd128IsNormal_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<ulong>(default)); 
        }
        [Fact]
        public void Simd128IsPositiveInfinity_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<ulong>(default)); 
        }
        [Fact]
        public void Simd128Sign_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<ulong>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 256-bit ulong

        [Fact]
        public void Simd256GreaterThan_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<ulong>(default, default));
        }
        [Fact]
        public void Simd256LessThan_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<ulong>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<ulong>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<ulong>(default, default));
        }
        [Fact]
        public void Simd256Add_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<ulong>(default, default));
        }
        [Fact]
        public void Simd256Subtract_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<ulong>(default, default));
        }
        [Fact]
        public void Simd256Multiply_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<ulong>(default, default));
        }
        [Fact]
        public void Simd256Divide_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<ulong>(default, default));
        }
        [Fact]
        public void Simd256Min_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<ulong>(default, default));
        }
        [Fact]
        public void Simd256Max_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<ulong>(default, default));
        }
        [Fact]
        public void Simd256Equal_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<ulong>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<ulong>(default, default));
        }
        [Fact]
        public void Simd256And_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<ulong>(default, default));
        }
        [Fact]
        public void Simd256Xor_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<ulong>(default, default));
        }
        [Fact]
        public void Simd256Or_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<ulong>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit ulong

        [Fact]
        public void Simd256Not_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<ulong>(default)); 
        }
        [Fact]
        public void Simd256Abs_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<ulong>(default)); 
        }
        [Fact]
        public void Simd256IsFinite_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<ulong>(default)); 
        }
        [Fact]
        public void Simd256IsInfinity_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<ulong>(default)); 
        }
        [Fact]
        public void Simd256IsNaN_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<ulong>(default)); 
        }
        [Fact]
        public void Simd256IsNegative_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<ulong>(default)); 
        }
        [Fact]
        public void Simd256IsNegativeInfinity_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<ulong>(default)); 
        }
        [Fact]
        public void Simd256IsNormal_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<ulong>(default)); 
        }
        [Fact]
        public void Simd256IsPositiveInfinity_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<ulong>(default)); 
        }
        [Fact]
        public void Simd256Sign_ulong()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<ulong>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 64-bit long

        [Fact]
        public void Simd64GreaterThan_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThan<long>(default, default));
        }
        [Fact]
        public void Simd64LessThan_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThan<long>(default, default));
        }
        [Fact]
        public void Simd64GreaterThanOrEqual_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThanOrEqual<long>(default, default));
        }
        [Fact]
        public void Simd64LessThanOrEqual_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThanOrEqual<long>(default, default));
        }
        [Fact]
        public void Simd64Add_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Add<long>(default, default));
        }
        [Fact]
        public void Simd64Subtract_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Subtract<long>(default, default));
        }
        [Fact]
        public void Simd64Multiply_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Multiply<long>(default, default));
        }
        [Fact]
        public void Simd64Divide_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Divide<long>(default, default));
        }
        [Fact]
        public void Simd64Min_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Min<long>(default, default));
        }
        [Fact]
        public void Simd64Max_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Max<long>(default, default));
        }
        [Fact]
        public void Simd64Equal_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Equal<long>(default, default));
        }
        [Fact]
        public void Simd64NotEqual_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.NotEqual<long>(default, default));
        }
        [Fact]
        public void Simd64And_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.And<long>(default, default));
        }
        [Fact]
        public void Simd64Xor_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Xor<long>(default, default));
        }
        [Fact]
        public void Simd64Or_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Or<long>(default, default));
        }

#endregion

#region Vector -> Vector 64-bit long

        [Fact]
        public void Simd64Not_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Not<long>(default)); 
        }
        [Fact]
        public void Simd64Abs_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Abs<long>(default)); 
        }
        [Fact]
        public void Simd64IsFinite_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsFinite<long>(default)); 
        }
        [Fact]
        public void Simd64IsInfinity_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsInfinity<long>(default)); 
        }
        [Fact]
        public void Simd64IsNaN_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNaN<long>(default)); 
        }
        [Fact]
        public void Simd64IsNegative_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegative<long>(default)); 
        }
        [Fact]
        public void Simd64IsNegativeInfinity_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegativeInfinity<long>(default)); 
        }
        [Fact]
        public void Simd64IsNormal_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNormal<long>(default)); 
        }
        [Fact]
        public void Simd64IsPositiveInfinity_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsPositiveInfinity<long>(default)); 
        }
        [Fact]
        public void Simd64Sign_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Sign<long>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 128-bit long

        [Fact]
        public void Simd128GreaterThan_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<long>(default, default));
        }
        [Fact]
        public void Simd128LessThan_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<long>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<long>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<long>(default, default));
        }
        [Fact]
        public void Simd128Add_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<long>(default, default));
        }
        [Fact]
        public void Simd128Subtract_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<long>(default, default));
        }
        [Fact]
        public void Simd128Multiply_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<long>(default, default));
        }
        [Fact]
        public void Simd128Divide_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<long>(default, default));
        }
        [Fact]
        public void Simd128Min_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<long>(default, default));
        }
        [Fact]
        public void Simd128Max_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<long>(default, default));
        }
        [Fact]
        public void Simd128Equal_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<long>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<long>(default, default));
        }
        [Fact]
        public void Simd128And_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<long>(default, default));
        }
        [Fact]
        public void Simd128Xor_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<long>(default, default));
        }
        [Fact]
        public void Simd128Or_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<long>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit long

        [Fact]
        public void Simd128Not_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<long>(default)); 
        }
        [Fact]
        public void Simd128Abs_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<long>(default)); 
        }
        [Fact]
        public void Simd128IsFinite_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<long>(default)); 
        }
        [Fact]
        public void Simd128IsInfinity_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<long>(default)); 
        }
        [Fact]
        public void Simd128IsNaN_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<long>(default)); 
        }
        [Fact]
        public void Simd128IsNegative_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<long>(default)); 
        }
        [Fact]
        public void Simd128IsNegativeInfinity_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<long>(default)); 
        }
        [Fact]
        public void Simd128IsNormal_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<long>(default)); 
        }
        [Fact]
        public void Simd128IsPositiveInfinity_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<long>(default)); 
        }
        [Fact]
        public void Simd128Sign_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<long>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 256-bit long

        [Fact]
        public void Simd256GreaterThan_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<long>(default, default));
        }
        [Fact]
        public void Simd256LessThan_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<long>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<long>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<long>(default, default));
        }
        [Fact]
        public void Simd256Add_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<long>(default, default));
        }
        [Fact]
        public void Simd256Subtract_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<long>(default, default));
        }
        [Fact]
        public void Simd256Multiply_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<long>(default, default));
        }
        [Fact]
        public void Simd256Divide_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<long>(default, default));
        }
        [Fact]
        public void Simd256Min_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<long>(default, default));
        }
        [Fact]
        public void Simd256Max_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<long>(default, default));
        }
        [Fact]
        public void Simd256Equal_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<long>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<long>(default, default));
        }
        [Fact]
        public void Simd256And_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<long>(default, default));
        }
        [Fact]
        public void Simd256Xor_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<long>(default, default));
        }
        [Fact]
        public void Simd256Or_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<long>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit long

        [Fact]
        public void Simd256Not_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<long>(default)); 
        }
        [Fact]
        public void Simd256Abs_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<long>(default)); 
        }
        [Fact]
        public void Simd256IsFinite_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<long>(default)); 
        }
        [Fact]
        public void Simd256IsInfinity_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<long>(default)); 
        }
        [Fact]
        public void Simd256IsNaN_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<long>(default)); 
        }
        [Fact]
        public void Simd256IsNegative_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<long>(default)); 
        }
        [Fact]
        public void Simd256IsNegativeInfinity_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<long>(default)); 
        }
        [Fact]
        public void Simd256IsNormal_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<long>(default)); 
        }
        [Fact]
        public void Simd256IsPositiveInfinity_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<long>(default)); 
        }
        [Fact]
        public void Simd256Sign_long()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<long>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 64-bit float

        [Fact]
        public void Simd64GreaterThan_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThan<float>(default, default));
        }
        [Fact]
        public void Simd64LessThan_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThan<float>(default, default));
        }
        [Fact]
        public void Simd64GreaterThanOrEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThanOrEqual<float>(default, default));
        }
        [Fact]
        public void Simd64LessThanOrEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThanOrEqual<float>(default, default));
        }
        [Fact]
        public void Simd64Add_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Add<float>(default, default));
        }
        [Fact]
        public void Simd64Subtract_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Subtract<float>(default, default));
        }
        [Fact]
        public void Simd64Multiply_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Multiply<float>(default, default));
        }
        [Fact]
        public void Simd64Divide_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Divide<float>(default, default));
        }
        [Fact]
        public void Simd64Min_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Min<float>(default, default));
        }
        [Fact]
        public void Simd64Max_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Max<float>(default, default));
        }
        [Fact]
        public void Simd64Equal_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Equal<float>(default, default));
        }
        [Fact]
        public void Simd64NotEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.NotEqual<float>(default, default));
        }
        [Fact]
        public void Simd64And_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.And<float>(default, default));
        }
        [Fact]
        public void Simd64Xor_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Xor<float>(default, default));
        }
        [Fact]
        public void Simd64Or_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Or<float>(default, default));
        }

#endregion

#region Vector -> Vector 64-bit float

        [Fact]
        public void Simd64Not_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Not<float>(default)); 
        }
        [Fact]
        public void Simd64Abs_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Abs<float>(default)); 
        }
        [Fact]
        public void Simd64IsFinite_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsFinite<float>(default)); 
        }
        [Fact]
        public void Simd64IsInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsInfinity<float>(default)); 
        }
        [Fact]
        public void Simd64IsNaN_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNaN<float>(default)); 
        }
        [Fact]
        public void Simd64IsNegative_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegative<float>(default)); 
        }
        [Fact]
        public void Simd64IsNegativeInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegativeInfinity<float>(default)); 
        }
        [Fact]
        public void Simd64IsNormal_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNormal<float>(default)); 
        }
        [Fact]
        public void Simd64IsPositiveInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsPositiveInfinity<float>(default)); 
        }
        [Fact]
        public void Simd64Sign_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Sign<float>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 128-bit float

        [Fact]
        public void Simd128GreaterThan_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<float>(default, default));
        }
        [Fact]
        public void Simd128LessThan_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<float>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<float>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<float>(default, default));
        }
        [Fact]
        public void Simd128Add_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<float>(default, default));
        }
        [Fact]
        public void Simd128Subtract_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<float>(default, default));
        }
        [Fact]
        public void Simd128Multiply_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<float>(default, default));
        }
        [Fact]
        public void Simd128Divide_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<float>(default, default));
        }
        [Fact]
        public void Simd128Min_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<float>(default, default));
        }
        [Fact]
        public void Simd128Max_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<float>(default, default));
        }
        [Fact]
        public void Simd128Equal_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<float>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<float>(default, default));
        }
        [Fact]
        public void Simd128And_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<float>(default, default));
        }
        [Fact]
        public void Simd128Xor_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<float>(default, default));
        }
        [Fact]
        public void Simd128Or_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<float>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit float

        [Fact]
        public void Simd128Not_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<float>(default)); 
        }
        [Fact]
        public void Simd128Abs_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<float>(default)); 
        }
        [Fact]
        public void Simd128IsFinite_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<float>(default)); 
        }
        [Fact]
        public void Simd128IsInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<float>(default)); 
        }
        [Fact]
        public void Simd128IsNaN_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<float>(default)); 
        }
        [Fact]
        public void Simd128IsNegative_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<float>(default)); 
        }
        [Fact]
        public void Simd128IsNegativeInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<float>(default)); 
        }
        [Fact]
        public void Simd128IsNormal_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<float>(default)); 
        }
        [Fact]
        public void Simd128IsPositiveInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<float>(default)); 
        }
        [Fact]
        public void Simd128Sign_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<float>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 256-bit float

        [Fact]
        public void Simd256GreaterThan_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<float>(default, default));
        }
        [Fact]
        public void Simd256LessThan_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<float>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<float>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<float>(default, default));
        }
        [Fact]
        public void Simd256Add_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<float>(default, default));
        }
        [Fact]
        public void Simd256Subtract_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<float>(default, default));
        }
        [Fact]
        public void Simd256Multiply_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<float>(default, default));
        }
        [Fact]
        public void Simd256Divide_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<float>(default, default));
        }
        [Fact]
        public void Simd256Min_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<float>(default, default));
        }
        [Fact]
        public void Simd256Max_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<float>(default, default));
        }
        [Fact]
        public void Simd256Equal_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<float>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<float>(default, default));
        }
        [Fact]
        public void Simd256And_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<float>(default, default));
        }
        [Fact]
        public void Simd256Xor_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<float>(default, default));
        }
        [Fact]
        public void Simd256Or_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<float>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit float

        [Fact]
        public void Simd256Not_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<float>(default)); 
        }
        [Fact]
        public void Simd256Abs_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<float>(default)); 
        }
        [Fact]
        public void Simd256IsFinite_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<float>(default)); 
        }
        [Fact]
        public void Simd256IsInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<float>(default)); 
        }
        [Fact]
        public void Simd256IsNaN_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<float>(default)); 
        }
        [Fact]
        public void Simd256IsNegative_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<float>(default)); 
        }
        [Fact]
        public void Simd256IsNegativeInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<float>(default)); 
        }
        [Fact]
        public void Simd256IsNormal_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<float>(default)); 
        }
        [Fact]
        public void Simd256IsPositiveInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<float>(default)); 
        }
        [Fact]
        public void Simd256Sign_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<float>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 64-bit double

        [Fact]
        public void Simd64GreaterThan_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThan<double>(default, default));
        }
        [Fact]
        public void Simd64LessThan_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThan<double>(default, default));
        }
        [Fact]
        public void Simd64GreaterThanOrEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.GreaterThanOrEqual<double>(default, default));
        }
        [Fact]
        public void Simd64LessThanOrEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.LessThanOrEqual<double>(default, default));
        }
        [Fact]
        public void Simd64Add_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Add<double>(default, default));
        }
        [Fact]
        public void Simd64Subtract_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Subtract<double>(default, default));
        }
        [Fact]
        public void Simd64Multiply_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Multiply<double>(default, default));
        }
        [Fact]
        public void Simd64Divide_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Divide<double>(default, default));
        }
        [Fact]
        public void Simd64Min_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Min<double>(default, default));
        }
        [Fact]
        public void Simd64Max_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Max<double>(default, default));
        }
        [Fact]
        public void Simd64Equal_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Equal<double>(default, default));
        }
        [Fact]
        public void Simd64NotEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.NotEqual<double>(default, default));
        }
        [Fact]
        public void Simd64And_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.And<double>(default, default));
        }
        [Fact]
        public void Simd64Xor_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Xor<double>(default, default));
        }
        [Fact]
        public void Simd64Or_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Or<double>(default, default));
        }

#endregion

#region Vector -> Vector 64-bit double

        [Fact]
        public void Simd64Not_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Not<double>(default)); 
        }
        [Fact]
        public void Simd64Abs_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Abs<double>(default)); 
        }
        [Fact]
        public void Simd64IsFinite_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsFinite<double>(default)); 
        }
        [Fact]
        public void Simd64IsInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsInfinity<double>(default)); 
        }
        [Fact]
        public void Simd64IsNaN_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNaN<double>(default)); 
        }
        [Fact]
        public void Simd64IsNegative_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegative<double>(default)); 
        }
        [Fact]
        public void Simd64IsNegativeInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNegativeInfinity<double>(default)); 
        }
        [Fact]
        public void Simd64IsNormal_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsNormal<double>(default)); 
        }
        [Fact]
        public void Simd64IsPositiveInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.IsPositiveInfinity<double>(default)); 
        }
        [Fact]
        public void Simd64Sign_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd64.Sign<double>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 128-bit double

        [Fact]
        public void Simd128GreaterThan_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<double>(default, default));
        }
        [Fact]
        public void Simd128LessThan_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<double>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<double>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<double>(default, default));
        }
        [Fact]
        public void Simd128Add_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<double>(default, default));
        }
        [Fact]
        public void Simd128Subtract_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<double>(default, default));
        }
        [Fact]
        public void Simd128Multiply_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<double>(default, default));
        }
        [Fact]
        public void Simd128Divide_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<double>(default, default));
        }
        [Fact]
        public void Simd128Min_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<double>(default, default));
        }
        [Fact]
        public void Simd128Max_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<double>(default, default));
        }
        [Fact]
        public void Simd128Equal_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<double>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<double>(default, default));
        }
        [Fact]
        public void Simd128And_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<double>(default, default));
        }
        [Fact]
        public void Simd128Xor_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<double>(default, default));
        }
        [Fact]
        public void Simd128Or_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<double>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit double

        [Fact]
        public void Simd128Not_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<double>(default)); 
        }
        [Fact]
        public void Simd128Abs_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<double>(default)); 
        }
        [Fact]
        public void Simd128IsFinite_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<double>(default)); 
        }
        [Fact]
        public void Simd128IsInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<double>(default)); 
        }
        [Fact]
        public void Simd128IsNaN_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<double>(default)); 
        }
        [Fact]
        public void Simd128IsNegative_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<double>(default)); 
        }
        [Fact]
        public void Simd128IsNegativeInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<double>(default)); 
        }
        [Fact]
        public void Simd128IsNormal_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<double>(default)); 
        }
        [Fact]
        public void Simd128IsPositiveInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<double>(default)); 
        }
        [Fact]
        public void Simd128Sign_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<double>(default)); 
        }

#endregion


#region Vector x Vector -> Vector 256-bit double

        [Fact]
        public void Simd256GreaterThan_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<double>(default, default));
        }
        [Fact]
        public void Simd256LessThan_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<double>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<double>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<double>(default, default));
        }
        [Fact]
        public void Simd256Add_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<double>(default, default));
        }
        [Fact]
        public void Simd256Subtract_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<double>(default, default));
        }
        [Fact]
        public void Simd256Multiply_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<double>(default, default));
        }
        [Fact]
        public void Simd256Divide_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<double>(default, default));
        }
        [Fact]
        public void Simd256Min_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<double>(default, default));
        }
        [Fact]
        public void Simd256Max_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<double>(default, default));
        }
        [Fact]
        public void Simd256Equal_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<double>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<double>(default, default));
        }
        [Fact]
        public void Simd256And_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<double>(default, default));
        }
        [Fact]
        public void Simd256Xor_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<double>(default, default));
        }
        [Fact]
        public void Simd256Or_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<double>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit double

        [Fact]
        public void Simd256Not_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<double>(default)); 
        }
        [Fact]
        public void Simd256Abs_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<double>(default)); 
        }
        [Fact]
        public void Simd256IsFinite_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<double>(default)); 
        }
        [Fact]
        public void Simd256IsInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<double>(default)); 
        }
        [Fact]
        public void Simd256IsNaN_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<double>(default)); 
        }
        [Fact]
        public void Simd256IsNegative_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<double>(default)); 
        }
        [Fact]
        public void Simd256IsNegativeInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<double>(default)); 
        }
        [Fact]
        public void Simd256IsNormal_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<double>(default)); 
        }
        [Fact]
        public void Simd256IsPositiveInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<double>(default)); 
        }
        [Fact]
        public void Simd256Sign_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<double>(default)); 
        }

#endregion

    }
}
#endif