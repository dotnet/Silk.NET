using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarByte
    {
        [M(N)]
        public static void EntryPoint()
        {
            try {Atan(default);} catch { }
            try {Atan2(default,default);} catch { }
            try {Cos(default);} catch { }
            try {Cosh(default);} catch { }
            try {One();} catch { }
            try {Two();} catch { }
            try {IsNormal(default);} catch { }
            try {Pi();} catch { }
            try {Tau();} catch { }
            try {HalfPi();} catch { }
            try {PositiveInfinity();} catch { }
            try {NegativeInfinity();} catch { }
            try {As(default);} catch { }
            try {SquareRoot(default);} catch { }
            try {Add(default,default);} catch { }
            try {Mod(default,default);} catch { }
            try {Subtract(default,default);} catch { }
            try {Multiply(default,default);} catch { }
            try {Divide(default,default);} catch { }
            try {Min(default,default);} catch { }
            try {Max(default,default);} catch { }
            try {Larger(default,default);} catch { }
            try {Smaller(default,default);} catch { }
            try {LargerEquals(default,default);} catch { }
            try {SmallerEquals(default,default);} catch { }
            try {Clamp(default,default,default);} catch { }
            try {Negate(default);} catch { }
            try {Equal(default,default);} catch { }
            try {Acos(default);} catch { }
            try {Abs(default);} catch { }
            try {Sin(default);} catch { }
            try {Sinh(default);} catch { }
            try {Asin(default);} catch { }
        }

        private const MethodImplOptions N = MethodImplOptions.NoInlining;

        [M(N)]
        private static byte Atan(byte value) => Scalar.Atan(value);

        [M(N)]
        private static byte Atan2(byte left, byte right) => Scalar.Atan2(left, right);

        [M(N)]
        private static byte Cos(byte value) => Scalar.Cos(value);

        [M(N)]
        private static byte Cosh(byte value) => Scalar.Cosh(value);

        [M(N)]
        private static byte One() => Scalar.One<byte>();

        [M(N)]
        private static byte Two() => Scalar.Two<byte>();

        [M(N)]
        private static bool IsNormal(byte value) => Scalar.IsNormal(value);

        [M(N)]
        private static byte Pi() => Scalar.Pi<byte>();

        [M(N)]
        private static byte Tau() => Scalar.Tau<byte>();

        [M(N)]
        private static byte HalfPi() => Scalar.HalfPi<byte>();

        [M(N)]
        private static byte PositiveInfinity() => Scalar.PositiveInfinity<byte>();

        [M(N)]
        private static byte NegativeInfinity() => Scalar.NegativeInfinity<byte>();

        [M(N)]
        private static byte As(double value) => Scalar.As<byte>(value);

        [M(N)]
        private static byte SquareRoot(byte value) => Scalar.SquareRoot(value);

        [M(N)]
        private static byte Add(byte left, byte right) => Scalar.Add(left, right);

        [M(N)]
        private static byte Mod(byte left, byte right) => Scalar.Mod(left, right);

        [M(N)]
        private static byte Subtract(byte left, byte right) => Scalar.Subtract(left, right);

        [M(N)]
        private static byte Multiply(byte left, byte right) => Scalar.Multiply(left, right);

        [M(N)]
        private static byte Divide(byte left, byte right) => Scalar.Divide(left, right);

        [M(N)]
        private static byte Min(byte left, byte right) => Scalar.Min(left, right);

        [M(N)]
        private static byte Max(byte left, byte right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(byte left, byte right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(byte left, byte right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(byte left, byte right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(byte left, byte right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static byte Clamp(byte value, byte min, byte max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static byte Negate(byte value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(byte left, byte right) => Scalar.Equal(left, right);

        [M(N)]
        private static byte Acos(byte value) => Scalar.Acos(value);

        [M(N)]
        private static byte Abs(byte value) => Scalar.Abs(value);

        [M(N)]
        private static byte Sin(byte value) => Scalar.Sin(value);

        [M(N)]
        private static byte Sinh(byte value) => Scalar.Sinh(value);

        [M(N)]
        private static byte Asin(byte value) => Scalar.Asin(value);
    }
}