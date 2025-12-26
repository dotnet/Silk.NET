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
            Assert.Equal(
                (ushort)0b1100_1000_0000_0011,
                Scalar.RotateLeft((ushort)0b1111_0010_0000_0000, 2)
            );
        }

        [Fact]
        public void RotateRight1()
        {
            Assert.Equal((byte)0b1111_0000, Scalar.RotateRight((byte)0b1110_0001, 1));
        }

        [Fact]
        public void RotateRight2()
        {
            Assert.Equal(
                (ushort)0b1111_0010_0000_0000,
                Scalar.RotateRight((ushort)0b1100_1000_0000_0011, 2)
            );
        }

        [Fact]
        public void And1()
        {
            Assert.Equal(0b1010, Scalar.And(0b1110, 0b1011));
        }

        [Fact]
        public void And2()
        {
            Assert.Equal((byte)0b1010, Scalar.And((byte)0b1110, (byte)0b1011));
        }

        [Fact]
        public void And3()
        {
            Assert.Equal((long)0b1010, Scalar.And((long)0b1110, (long)0b1011));
        }

        [Fact]
        public void Or1()
        {
            Assert.Equal(0b1111, Scalar.Or(0b1110, 0b1011));
        }

        [Fact]
        public void Or2()
        {
            Assert.Equal((byte)0b1111, Scalar.Or((byte)0b1110, (byte)0b1011));
        }

        [Fact]
        public void Or3()
        {
            Assert.Equal((long)0b1111, Scalar.Or((long)0b1110, (long)0b1011));
        }

        [Fact]
        public void Xor1()
        {
            Assert.Equal(0b0101, Scalar.Xor(0b1110, 0b1011));
        }

        [Fact]
        public void Xor2()
        {
            Assert.Equal((byte)0b0101, Scalar.Xor((byte)0b1110, (byte)0b1011));
        }

        [Fact]
        public void Xor3()
        {
            Assert.Equal((long)0b0101, Scalar.Xor((long)0b1110, (long)0b1011));
        }

        [Fact]
        public void Not1()
        {
            Assert.Equal(~0b1110, Scalar.Not(0b1110));
        }

        [Fact]
        public void Not2()
        {
            var b = ~(byte)0b1110 & byte.MaxValue;
            // ReSharper disable once IntVariableOverflowInUncheckedContext
            Assert.Equal((byte)b, Scalar.Not((byte)0b1110));
        }

        [Fact]
        public void Not3()
        {
            Assert.Equal(~(ulong)0b1110, Scalar.Not((ulong)0b1110));
        }
    }
}
