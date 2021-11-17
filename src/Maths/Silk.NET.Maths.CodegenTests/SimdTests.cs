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

#region Vector x Vector -> Vector 128-bit float

        [Fact]
        public void Simd128GreaterThan_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.GreaterThan<float>(default, default));
        }
        [Fact]
        public void Simd128LessThan_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.LessThan<float>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<float>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<float>(default, default));
        }
        [Fact]
        public void Simd128Add_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Add<float>(default, default));
        }
        [Fact]
        public void Simd128Subtract_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Subtract<float>(default, default));
        }
        [Fact]
        public void Simd128Multiply_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Multiply<float>(default, default));
        }
        [Fact]
        public void Simd128Divide_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Divide<float>(default, default));
        }
        [Fact]
        public void Simd128Min_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Min<float>(default, default));
        }
        [Fact]
        public void Simd128Max_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Max<float>(default, default));
        }
        [Fact]
        public void Simd128Equal_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Equal<float>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.NotEqual<float>(default, default));
        }
        [Fact]
        public void Simd128And_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.And<float>(default, default));
        }
        [Fact]
        public void Simd128Xor_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Xor<float>(default, default));
        }
        [Fact]
        public void Simd128Or_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Or<float>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit float

        [Fact]
        public void Simd128Not_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Not<float>(default));
        }
 
        [Fact]
        public void Simd128Abs_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Abs<float>(default));
        }
 
        [Fact]
        public void Simd128IsFinite_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsFinite<float>(default));
        }
 
        [Fact]
        public void Simd128IsInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsInfinity<float>(default));
        }
 
        [Fact]
        public void Simd128IsNaN_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsNaN<float>(default));
        }
 
        [Fact]
        public void Simd128IsNegative_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsNegative<float>(default));
        }
 
        [Fact]
        public void Simd128IsNegativeInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<float>(default));
        }
 
        [Fact]
        public void Simd128IsNormal_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsNormal<float>(default));
        }
 
        [Fact]
        public void Simd128IsPositiveInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<float>(default));
        }
 
        [Fact]
        public void Simd128Sign_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Sign<float>(default));
        }
 

#endregion


#region Vector x Vector -> Vector 256-bit float

        [Fact]
        public void Simd256GreaterThan_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.GreaterThan<float>(default, default));
        }
        [Fact]
        public void Simd256LessThan_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.LessThan<float>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<float>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<float>(default, default));
        }
        [Fact]
        public void Simd256Add_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Add<float>(default, default));
        }
        [Fact]
        public void Simd256Subtract_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Subtract<float>(default, default));
        }
        [Fact]
        public void Simd256Multiply_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Multiply<float>(default, default));
        }
        [Fact]
        public void Simd256Divide_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Divide<float>(default, default));
        }
        [Fact]
        public void Simd256Min_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Min<float>(default, default));
        }
        [Fact]
        public void Simd256Max_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Max<float>(default, default));
        }
        [Fact]
        public void Simd256Equal_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Equal<float>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.NotEqual<float>(default, default));
        }
        [Fact]
        public void Simd256And_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.And<float>(default, default));
        }
        [Fact]
        public void Simd256Xor_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Xor<float>(default, default));
        }
        [Fact]
        public void Simd256Or_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<float>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Or<float>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit float

        [Fact]
        public void Simd256Not_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Not<float>(default));
        }
 
        [Fact]
        public void Simd256Abs_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Abs<float>(default));
        }
 
        [Fact]
        public void Simd256IsFinite_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsFinite<float>(default));
        }
 
        [Fact]
        public void Simd256IsInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsInfinity<float>(default));
        }
 
        [Fact]
        public void Simd256IsNaN_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsNaN<float>(default));
        }
 
        [Fact]
        public void Simd256IsNegative_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsNegative<float>(default));
        }
 
        [Fact]
        public void Simd256IsNegativeInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<float>(default));
        }
 
        [Fact]
        public void Simd256IsNormal_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsNormal<float>(default));
        }
 
        [Fact]
        public void Simd256IsPositiveInfinity_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<float>(default));
        }
 
        [Fact]
        public void Simd256Sign_float()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<float>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Sign<float>(default));
        }
 

#endregion


#region Vector x Vector -> Vector 128-bit double

        [Fact]
        public void Simd128GreaterThan_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThan<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.GreaterThan<double>(default, default));
        }
        [Fact]
        public void Simd128LessThan_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThan<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.LessThan<double>(default, default));
        }
        [Fact]
        public void Simd128GreaterThanOrEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.GreaterThanOrEqual<double>(default, default));
        }
        [Fact]
        public void Simd128LessThanOrEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.LessThanOrEqual<double>(default, default));
        }
        [Fact]
        public void Simd128Add_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Add<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Add<double>(default, default));
        }
        [Fact]
        public void Simd128Subtract_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Subtract<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Subtract<double>(default, default));
        }
        [Fact]
        public void Simd128Multiply_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Multiply<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Multiply<double>(default, default));
        }
        [Fact]
        public void Simd128Divide_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Divide<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Divide<double>(default, default));
        }
        [Fact]
        public void Simd128Min_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Min<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Min<double>(default, default));
        }
        [Fact]
        public void Simd128Max_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Max<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Max<double>(default, default));
        }
        [Fact]
        public void Simd128Equal_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Equal<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Equal<double>(default, default));
        }
        [Fact]
        public void Simd128NotEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.NotEqual<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.NotEqual<double>(default, default));
        }
        [Fact]
        public void Simd128And_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.And<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.And<double>(default, default));
        }
        [Fact]
        public void Simd128Xor_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Xor<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Xor<double>(default, default));
        }
        [Fact]
        public void Simd128Or_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Or<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Or<double>(default, default));
        }

#endregion

#region Vector -> Vector 128-bit double

        [Fact]
        public void Simd128Not_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Not<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Not<double>(default));
        }
 
        [Fact]
        public void Simd128Abs_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Abs<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Abs<double>(default));
        }
 
        [Fact]
        public void Simd128IsFinite_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsFinite<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsFinite<double>(default));
        }
 
        [Fact]
        public void Simd128IsInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsInfinity<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsInfinity<double>(default));
        }
 
        [Fact]
        public void Simd128IsNaN_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNaN<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsNaN<double>(default));
        }
 
        [Fact]
        public void Simd128IsNegative_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegative<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsNegative<double>(default));
        }
 
        [Fact]
        public void Simd128IsNegativeInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsNegativeInfinity<double>(default));
        }
 
        [Fact]
        public void Simd128IsNormal_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsNormal<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsNormal<double>(default));
        }
 
        [Fact]
        public void Simd128IsPositiveInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.IsPositiveInfinity<double>(default));
        }
 
        [Fact]
        public void Simd128Sign_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd128.Sign<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd128.Sign<double>(default));
        }
 

#endregion


#region Vector x Vector -> Vector 256-bit double

        [Fact]
        public void Simd256GreaterThan_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThan<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.GreaterThan<double>(default, default));
        }
        [Fact]
        public void Simd256LessThan_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThan<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.LessThan<double>(default, default));
        }
        [Fact]
        public void Simd256GreaterThanOrEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.GreaterThanOrEqual<double>(default, default));
        }
        [Fact]
        public void Simd256LessThanOrEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.LessThanOrEqual<double>(default, default));
        }
        [Fact]
        public void Simd256Add_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Add<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Add<double>(default, default));
        }
        [Fact]
        public void Simd256Subtract_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Subtract<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Subtract<double>(default, default));
        }
        [Fact]
        public void Simd256Multiply_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Multiply<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Multiply<double>(default, default));
        }
        [Fact]
        public void Simd256Divide_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Divide<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Divide<double>(default, default));
        }
        [Fact]
        public void Simd256Min_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Min<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Min<double>(default, default));
        }
        [Fact]
        public void Simd256Max_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Max<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Max<double>(default, default));
        }
        [Fact]
        public void Simd256Equal_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Equal<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Equal<double>(default, default));
        }
        [Fact]
        public void Simd256NotEqual_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.NotEqual<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.NotEqual<double>(default, default));
        }
        [Fact]
        public void Simd256And_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.And<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.And<double>(default, default));
        }
        [Fact]
        public void Simd256Xor_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Xor<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Xor<double>(default, default));
        }
        [Fact]
        public void Simd256Or_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Or<double>(default, default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Or<double>(default, default));
        }

#endregion

#region Vector -> Vector 256-bit double

        [Fact]
        public void Simd256Not_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Not<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Not<double>(default));
        }
 
        [Fact]
        public void Simd256Abs_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Abs<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Abs<double>(default));
        }
 
        [Fact]
        public void Simd256IsFinite_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsFinite<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsFinite<double>(default));
        }
 
        [Fact]
        public void Simd256IsInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsInfinity<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsInfinity<double>(default));
        }
 
        [Fact]
        public void Simd256IsNaN_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNaN<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsNaN<double>(default));
        }
 
        [Fact]
        public void Simd256IsNegative_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegative<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsNegative<double>(default));
        }
 
        [Fact]
        public void Simd256IsNegativeInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsNegativeInfinity<double>(default));
        }
 
        [Fact]
        public void Simd256IsNormal_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsNormal<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsNormal<double>(default));
        }
 
        [Fact]
        public void Simd256IsPositiveInfinity_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.IsPositiveInfinity<double>(default));
        }
 
        [Fact]
        public void Simd256Sign_double()
        {
            AssertCodegen.NoBranches(CompilationTier.Tier1, () => Simd256.Sign<double>(default));
            AssertCodegen.NoCalls(CompilationTier.Tier1, () => Simd256.Sign<double>(default));
        }
 

#endregion

    }
}
#endif