// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class Matrix3X4Tests
    {
        [Fact]
        public void MultiplyByMatrix4X2UsesEveryRowOfTheLeftMatrix()
        {
            var left = new Matrix3X4<float>(
                1, 2, 3, 4,
                5, 6, 7, 8,
                9, 10, 11, 12);
            var right = new Matrix4X2<float>(
                1, 2,
                3, 4,
                5, 6,
                7, 8);

            var result = left * right;

            Assert.Equal(50f, result.M11);
            Assert.Equal(60f, result.M12);
            Assert.Equal(114f, result.M21);
            Assert.Equal(140f, result.M22);
            Assert.Equal(178f, result.M31);
            Assert.Equal(220f, result.M32);
        }
    }
}
