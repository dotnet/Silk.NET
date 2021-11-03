// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class ScalarBitwiseTest
    {
        [Fact]
        public void RotateLeft1()
        {
            Assert.Equal((byte)0b1110_0001, Scalar.RotateLeft((byte)0b1111_0000, 1)); 
        }
        
        [Fact]
        public void RotateLeft2()
        {
            Assert.Equal((ushort)0b1100_1000_0000_0011, Scalar.RotateLeft((ushort)0b1111_0010_0000_0000, 2)); 
        }
        
        [Fact]
        public void RotateRight1()
        {
            Assert.Equal((byte)0b1111_0000, Scalar.RotateRight((byte)0b1110_0001, 1)); 
        }
        
        [Fact]
        public void RotateRight2()
        {
            Assert.Equal((ushort)0b1111_0010_0000_0000, Scalar.RotateRight((ushort)0b1100_1000_0000_0011, 2)); 
        }
    }
}