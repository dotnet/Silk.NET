using Xunit;

namespace Silk.NET.Numerics.Tests
{
    public class LogTests
    {
        [Fact]
        public void Log0()
        {
            Assert.StrictEqual(float.NegativeInfinity, Operations.Log(0f));
        }
        
        [Fact]
        public void Log1()
        {
            Assert.StrictEqual(0f, Operations.Log(1f));
        }
        
        [Fact]
        public void LogSmall1()
        {
            Assert.Equal(-2.0955709236097195567919657540932, Operations.Log(.123f), 6);
            // MathF is also inaccurate :)
            Assert.Equal(-2.0955709236097195567919657540932, System.MathF.Log(.123f), 6);
        }

        [Fact]
        public void Log2()
        {
            Assert.Equal(0.69314718055994530941723212145818f, Operations.Log(2f));
        }
        
        [Fact]
        public void Log5()
        {
            Assert.Equal(1.6094379124341003746007593332262f, Operations.Log(5f));
        }

        [Fact]
        public void Log100()
        {
            Assert.Equal(4.6051701859880913680359829093687f, Operations.Log(100f));
        }

        [Fact]
        public void Log123()
        {
            Assert.Equal(4.8121843553724174952620086099599f, Operations.Log(123f));
        }
    }
}
