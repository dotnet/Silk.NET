using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarUInt32
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
        private static uint Atan(uint value) => Scalar.Atan(value);

        [M(N)]
        private static uint Atan2(uint left, uint right) => Scalar.Atan2(left, right);

        [M(N)]
        private static uint Cos(uint value) => Scalar.Cos(value);

        [M(N)]
        private static uint Cosh(uint value) => Scalar.Cosh(value);

        [M(N)]
        private static uint One() => Scalar.One<uint>();

        [M(N)]
        private static uint Two() => Scalar.Two<uint>();

        [M(N)]
        private static bool IsNormal(uint value) => Scalar.IsNormal(value);

        [M(N)]
        private static uint Pi() => Scalar.Pi<uint>();

        [M(N)]
        private static uint Tau() => Scalar.Tau<uint>();

        [M(N)]
        private static uint HalfPi() => Scalar.HalfPi<uint>();

        [M(N)]
        private static uint PositiveInfinity() => Scalar.PositiveInfinity<uint>();

        [M(N)]
        private static uint NegativeInfinity() => Scalar.NegativeInfinity<uint>();

        [M(N)]
        private static uint As(double value) => Scalar.As<uint>(value);

        [M(N)]
        private static uint SquareRoot(uint value) => Scalar.SquareRoot(value);

        [M(N)]
        private static uint Add(uint left, uint right) => Scalar.Add(left, right);

        [M(N)]
        private static uint Mod(uint left, uint right) => Scalar.Mod(left, right);

        [M(N)]
        private static uint Subtract(uint left, uint right) => Scalar.Subtract(left, right);

        [M(N)]
        private static uint Multiply(uint left, uint right) => Scalar.Multiply(left, right);

        [M(N)]
        private static uint Divide(uint left, uint right) => Scalar.Divide(left, right);

        [M(N)]
        private static uint Min(uint left, uint right) => Scalar.Min(left, right);

        [M(N)]
        private static uint Max(uint left, uint right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(uint left, uint right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(uint left, uint right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(uint left, uint right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(uint left, uint right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static uint Clamp(uint value, uint min, uint max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static uint Negate(uint value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(uint left, uint right) => Scalar.Equal(left, right);

        [M(N)]
        private static uint Acos(uint value) => Scalar.Acos(value);

        [M(N)]
        private static uint Abs(uint value) => Scalar.Abs(value);

        [M(N)]
        private static uint Sin(uint value) => Scalar.Sin(value);

        [M(N)]
        private static uint Sinh(uint value) => Scalar.Sinh(value);

        [M(N)]
        private static uint Asin(uint value) => Scalar.Asin(value);
    }
}