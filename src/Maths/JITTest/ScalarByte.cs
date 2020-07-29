using System.Runtime.CompilerServices;
using static  Silk.NET.Maths.Scalar;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarByte
    {
        public static int EntryPoint()
            => One() + Two() + Pi() + Tau() + HalfPi() + PositiveInfinity() + NegativeInfinity(); 
        
        private const MethodImplOptions N = MethodImplOptions.NoInlining;

        [M(N)]
        private static byte One() => One<byte>();
        
        [M(N)]
        private static byte Two() => Two<byte>();
        
        [M(N)]
        private static byte Pi() => Pi<byte>();
        
        [M(N)]
        private static byte Tau() => Tau<byte>();

        [M(N)]
        private static byte HalfPi() => HalfPi<byte>();
        
        [M(N)]
        private static byte PositiveInfinity() => PositiveInfinity<byte>();
        
        [M(N)]
        private static byte NegativeInfinity() => NegativeInfinity<byte>();
    }
}
