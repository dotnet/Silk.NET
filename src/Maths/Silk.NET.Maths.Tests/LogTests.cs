// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace Silk.NET.Maths.Tests
{
    public class LogTests
    {
        [Fact]
        public void Log0()
        {
            Assert.StrictEqual(float.NegativeInfinity, Scalar.Log(0f));
        }
        
        [Fact]
        public void Log1()
        {
            Assert.StrictEqual(0f, Scalar.Log(1f));
        }
        
        [Fact]
        public void LogSmall1()
        {
            Assert.Equal(-2.0955709236097195567919657540932, Scalar.Log(.123f), 6);
            // MathF is also inaccurate :)
#if !NET48
            Assert.Equal(-2.0955709236097195567919657540932, System.MathF.Log(.123f), 6);
#endif
        }

        [Fact]
        public void Log2()
        {
            Assert.Equal(0.69314718055994530941723212145818f, Scalar.Log(2f));
        }
        
        [Fact]
        public void Log5()
        {
            Assert.Equal(1.6094379124341003746007593332262f, Scalar.Log(5f));
        }

        [Fact]
        public void Log100()
        {
            Assert.Equal(4.6051701859880913680359829093687f, Scalar.Log(100f));
        }

        [Fact]
        public void Log123()
        {
            Assert.Equal(4.8121843553724174952620086099599f, Scalar.Log(123f));
        }
    }
}
