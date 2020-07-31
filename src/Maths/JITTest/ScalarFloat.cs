using System;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace JITTest
{
    public static class ScalarFloat
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
        private static float Atan(float value) => Scalar.Atan(value);

        [M(N)]
        private static float Atan2(float left, float right) => Scalar.Atan2(left, right);

        [M(N)]
        private static float Cos(float value) => Scalar.Cos(value);

        [M(N)]
        private static float Cosh(float value) => Scalar.Cosh(value);

        [M(N)]
        private static float One() => Scalar.One<float>();

        [M(N)]
        private static float Two() => Scalar.Two<float>();

        [M(N)]
        private static bool IsNormal(float value) => Scalar.IsNormal(value);

        [M(N)]
        private static float Pi() => Scalar.Pi<float>();

        [M(N)]
        private static float Tau() => Scalar.Tau<float>();

        [M(N)]
        private static float HalfPi() => Scalar.HalfPi<float>();

        [M(N)]
        private static float PositiveInfinity() => Scalar.PositiveInfinity<float>();

        [M(N)]
        private static float NegativeInfinity() => Scalar.NegativeInfinity<float>();

        [M(N)]
        private static float As(double value) => Scalar.As<float>(value);

        [M(N)]
        private static float SquareRoot(float value) => Scalar.SquareRoot(value);

        [M(N)]
        private static float Add(float left, float right) => Scalar.Add(left, right);

        [M(N)]
        private static float Mod(float left, float right) => Scalar.Mod(left, right);

        [M(N)]
        private static float Subtract(float left, float right) => Scalar.Subtract(left, right);

        [M(N)]
        private static float Multiply(float left, float right) => Scalar.Multiply(left, right);

        [M(N)]
        private static float Divide(float left, float right) => Scalar.Divide(left, right);

        [M(N)]
        private static float Min(float left, float right) => Scalar.Min(left, right);

        [M(N)]
        private static float Max(float left, float right) => Scalar.Max(left, right);

        [M(N)]
        private static bool Larger(float left, float right) => Scalar.Larger(left, right);

        [M(N)]
        private static bool Smaller(float left, float right) => Scalar.Smaller(left, right);

        [M(N)]
        private static bool LargerEquals(float left, float right) => Scalar.LargerEquals(left, right);

        [M(N)]
        private static bool SmallerEquals(float left, float right) => Scalar.SmallerEquals(left, right);

        [M(N)]
        private static float Clamp(float value, float min, float max) => Scalar.Clamp(value, min, max);

        [M(N)]
        private static float Negate(float value) => Scalar.Negate(value);

        [M(N)]
        private static bool Equal(float left, float right) => Scalar.Equal(left, right);

        [M(N)]
        private static float Acos(float value) => Scalar.Acos(value);

        [M(N)]
        private static float Abs(float value) => Scalar.Abs(value);

        [M(N)]
        private static float Sin(float value) => Scalar.Sin(value);

        [M(N)]
        private static float Sinh(float value) => Scalar.Sinh(value);

        [M(N)]
        private static float Asin(float value) => Scalar.Asin(value);
    }
}