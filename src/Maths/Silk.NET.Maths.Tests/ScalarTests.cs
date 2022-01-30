// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class ScalarTests
    {
        [Fact] public void AddBigInteger()
            => Assert.Equal(new BigInteger(100), Scalar.Add(BigInteger.One, 99));
            
        [Fact] public void SubtractBigInteger()
            => Assert.Equal(new BigInteger(-98), Scalar.Subtract(BigInteger.One, 99));
            
        [Fact] public void MultiplyBigInteger()
            => Assert.Equal(new BigInteger(990), Scalar.Multiply(new BigInteger(10), 99));
        
        [Fact] public void DivideBigInteger()
            => Assert.Equal(new BigInteger(5), Scalar.Divide(new BigInteger(16), 3));
        
        [Fact] public void LessThanBigInteger()
            => Assert.True(Scalar.LessThan(new BigInteger(10), 99));
        
        [Fact] public void GreaterThanBigInteger()
            => Assert.False(Scalar.GreaterThan(new BigInteger(10), 99));
        
        [Fact] public void LessThanOrEqualBigInteger()
            => Assert.True(Scalar.LessThanOrEqual(new BigInteger(10), 99));
        
        [Fact] public void GreaterThanOrEqualBigInteger()
            => Assert.False(Scalar.GreaterThanOrEqual(new BigInteger(10), 99));
        
        [Fact] public void EqualBigInteger1()
            => Assert.False(Scalar.Equal(new BigInteger(10), 99));
        
        [Fact] public void EqualBigInteger2()
            => Assert.True(Scalar.Equal(new BigInteger(10), 10));
        
        // [Fact(Skip = "Abs is unmanaged currently")] public void AbsBigInteger()
        //     => Assert.Equal(new BigInteger(5), Scalar.Abs(new BigInteger(-5)));
        
        
        [Fact] public void AddComplex()
            => Assert.Equal(new Complex(109, 5), Scalar.Add(new Complex(10, 5), 99));
        
        [Fact] public void SubtractComplex()
            => Assert.Equal(new Complex(-89, 5), Scalar.Subtract(new Complex(10, 5), 99));
        
        [Fact] public void MultiplyComplex()
            => Assert.Equal(new Complex(990, 495), Scalar.Multiply(new Complex(10, 5), 99));
        
        [Fact] public void DivideComplex()
            => Assert.Equal(new Complex(10 / 99d, 5 / 99d), Scalar.Divide(new Complex(10, 5), 99));
        
        [Fact] public void EqualComplex1()
            => Assert.True(Scalar.Equal(new Complex(10, 5), new Complex(10, 5)));
        
        [Fact] public void EqualComplex2()
            => Assert.False(Scalar.Equal(new Complex(10, 5), new Complex(10, 6)));
        
        [Fact] public void IsFiniteComplex1()
            => Assert.True(Scalar.IsFinite(new Complex(10, 5)));
        
        [Fact] public void IsFiniteComplex2()
            => Assert.False(Scalar.IsFinite(new Complex(double.NaN, 5)));
        
        [Fact] public void IsFiniteComplex3()
            => Assert.False(Scalar.IsFinite(new Complex(10, double.NaN)));
        
        [Fact] public void IsFiniteComplex4()
            => Assert.False(Scalar.IsFinite(new Complex(10, double.NegativeInfinity)));
        
        [Fact] public void IsInfinityComplex1()
            => Assert.True(Scalar.IsInfinity(new Complex(double.NegativeInfinity, 5)));
        
        [Fact] public void IsInfinityComplex2()
            => Assert.True(Scalar.IsInfinity(new Complex(5, double.NegativeInfinity)));
            
        [Fact] public void IsInfinityComplex3()
            => Assert.True(Scalar.IsInfinity(new Complex(double.PositiveInfinity, 5)));
        
        [Fact] public void IsInfinityComplex4()
            => Assert.True(Scalar.IsInfinity(new Complex(5, double.PositiveInfinity)));
        
        [Fact] public void AbsComplex()
            => Assert.Equal(new Complex(5, 0), Scalar.Abs(new Complex(3, 4)));
    }
}