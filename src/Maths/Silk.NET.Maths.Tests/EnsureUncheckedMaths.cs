// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class EnsureUncheckedMaths
    {
        [Fact]
        public void EnsureUncheckedMathsTest()
        {
            Assert.Equal(int.MinValue, Scalar.Add(int.MaxValue, 1));
        }
    }
}
