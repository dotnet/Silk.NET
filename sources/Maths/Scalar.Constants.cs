// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;

// casting into non-nullable, unboxing from nullable  
#pragma warning disable 8600
#pragma warning disable 8605


namespace Silk.NET.Maths
{
    /// <summary>
    /// To be added.
    /// </summary>
    /// <typeparam name="T">To be added.</typeparam>
    public static partial class Scalar<T> where T : notnull
    {
        /// <summary>
        /// Represents the smallest positive value that is greater than zero. Zero for non-floating point numbers.
        /// </summary>
        public static readonly T Epsilon;

        /// <summary>
        /// Represents the largest possible value.
        /// </summary>
        public static readonly T MaxValue;

        /// <summary>
        /// Represents the smallest possible value.
        /// </summary>
        public static readonly T MinValue;

        /// <summary>
        /// Represents not a number (NaN). Zero for non-floating point numbers.
        /// </summary>
        public static readonly T NaN;

        /// <summary>
        /// Represents negative infinity. Zero for non-floating point numbers.
        /// </summary>
        public static readonly T NegativeInfinity;

        /// <summary>
        /// Represents positive infinity. Zero for non-floating point numbers.
        /// </summary>
        public static readonly T PositiveInfinity;

        /// <summary>
        /// Represents zero.
        /// </summary>
        public static readonly T Zero = default!;

        /// <summary>
        /// Represents one.
        /// </summary>
        public static readonly T One;

        /// <summary>
        /// Represents two.
        /// </summary>
        public static readonly T Two;

        /// <summary>
        /// Represents negative one.
        /// </summary>
        public static readonly T MinusOne;

        /// <summary>
        /// Represents negative two.
        /// </summary>
        public static readonly T MinusTwo;

        /// <summary>
        /// Represents the natural logarithmic base, specified by the constant, <code>e</code>.
        /// </summary>
        public static readonly T E;

        /// <summary>
        /// Represents the ratio of the circumference of a circle to its diameter, specified by the constant, <code>π</code>.
        /// </summary>
        public static readonly T Pi;

        /// <summary>
        /// Represents Pi divided by two.
        /// </summary>
        public static readonly T PiOver2;

        /// <summary>
        /// Represents the number of radians in one turn, specified by the constant, <code>τ</code>.
        /// </summary>
        public static readonly T Tau;

        /// <summary>
        /// Represents the number of degrees in a single radian.
        /// </summary>
        /// <remarks>
        /// This is equivalent to <c>180 / MathF.Pi</c>
        /// </remarks>
        public static readonly T DegreesPerRadian;

        /// <summary>
        /// Represents the number of radians in a single degree.
        /// </summary>
        /// <remarks>
        /// This is equivalent to <c>MathF.Pi / 180</c>.
        /// </remarks>
        public static readonly T RadiansPerDegree;

        internal static readonly bool IntrinsicsApplicable = typeof(T) == typeof(byte)
                                                            || typeof(T) == typeof(sbyte)
                                                            || typeof(T) == typeof(ushort)
                                                            || typeof(T) == typeof(short)
                                                            || typeof(T) == typeof(uint)
                                                            || typeof(T) == typeof(int)
                                                            || typeof(T) == typeof(ulong)
                                                            || typeof(T) == typeof(long)
                                                            || typeof(T) == typeof(float)
                                                            || typeof(T) == typeof(double);

        private const float FloatE = 2.71828175f;
        private const float FloatPi = 3.14159274f;
        private const float FloatTau = 6.283185307f;

        [MethodImpl(Scalar.MaxOpt)]
#pragma warning disable 8618 // unitialized fields
        static Scalar()
#pragma warning restore 8618
        {
            // This won't inline as nicely on platforms that aren't .NET 5, however there's no other way to yield the
            // constant folding benefits that come with the fields being static readonly.
            //
            // We have used local functions elsewhere to get around this elsewhere, however there's no sane way we can
            // do that with local functions.
            //
            // This will inline fine on .NET 5, though. See also: https://github.com/dotnet/runtime/issues/38106
            if (typeof(T) == typeof(Half))
            {
                Epsilon = (T) (object) Half.Epsilon;
                MaxValue = (T) (object) Half.MaxValue;
                MinValue = (T) (object) Half.MinValue;
                NaN = (T) (object) Half.NaN;
                NegativeInfinity = (T) (object) Half.NegativeInfinity;
                PositiveInfinity = (T) (object) Half.PositiveInfinity;
                One = (T) (object) (Half) 1;
                Two = (T) (object) (Half) 2;
                MinusOne = (T) (object) (Half) (-1f);
                MinusTwo = (T) (object) (Half) (-2f);
                E = (T) (object) (Half) FloatE;
                Pi = (T) (object) (Half) FloatPi;
                Tau = (T) (object) (Half) FloatTau;
            }
            else if (typeof(T) == typeof(float))
            {
                Epsilon = (T) (object) float.Epsilon;
                MaxValue = (T) (object) float.MaxValue;
                MinValue = (T) (object) float.MinValue;
                NaN = (T) (object) float.NaN;
                NegativeInfinity = (T) (object) float.NegativeInfinity;
                PositiveInfinity = (T) (object) float.PositiveInfinity;
                One = (T) (object) 1f;
                Two = (T) (object) 2f;
                MinusOne = (T) (object) -1f;
                MinusTwo = (T) (object) -2f;
                E = (T) (object) FloatE;
                Pi = (T) (object) FloatPi;
                Tau = (T) (object) FloatTau;
            }
            else if (typeof(T) == typeof(double))
            {
                Epsilon = (T) (object) double.Epsilon;
                MaxValue = (T) (object) double.MaxValue;
                MinValue = (T) (object) double.MinValue;
                NaN = (T) (object) double.NaN;
                NegativeInfinity = (T) (object) double.NegativeInfinity;
                PositiveInfinity = (T) (object) double.PositiveInfinity;
                One = (T) (object) 1d;
                Two = (T) (object) 2d;
                MinusOne = (T) (object) -1d;
                MinusTwo = (T) (object) -2d;
                E = (T) (object) Math.E;
                Pi = (T) (object) Math.PI;
#if !NET5_0
                Tau = Scalar.Multiply(Pi, Two);
#else
                Tau = (T) (object) Math.Tau;
#endif
            }
            else if (typeof(T) == typeof(decimal))
            {
                Epsilon = default!;
                MaxValue = (T) (object) decimal.MaxValue;
                MinValue = (T) (object) decimal.MinValue;
                NaN = default!;
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) (decimal) 1;
                Two = (T) (object) (decimal) 2;
                MinusOne = (T) (object) (decimal) -1;
                MinusTwo = (T) (object) (decimal) -2;
                E = (T) (object) (decimal) Math.E;
                Pi = (T) (object) (decimal) Math.PI;
                Tau = Scalar.Multiply(Pi, Two);
            }
            else if (typeof(T) == typeof(short))
            {
                Epsilon = default!;
                MaxValue = (T) (object) short.MaxValue;
                MinValue = (T) (object) short.MinValue;
                NaN = default!;
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) (short) 1;
                Two = (T) (object) (short) 2;
                MinusOne = (T) (object) (short) -1;
                MinusTwo = (T) (object) (short) -2;
                E = (T) (object) (short) FloatE;
                Pi = (T) (object) (short) FloatPi;
                Tau = (T) (object) (short) FloatTau;
            }
            else if (typeof(T) == typeof(ushort))
            {
                Epsilon = default!;
                MaxValue = (T) (object) ushort.MaxValue;
                MinValue = (T) (object) ushort.MinValue;
                NaN = default!;
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) (ushort) 1;
                Two = (T) (object) (ushort) 2;
                MinusOne = default!;
                MinusTwo = default!;
                E = (T) (object) (ushort) FloatE;
                Pi = (T) (object) (ushort) FloatPi;
                Tau = (T) (object) (ushort) FloatTau;
            }
            else if (typeof(T) == typeof(sbyte))
            {
                Epsilon = default!;
                MaxValue = (T) (object) sbyte.MaxValue;
                MinValue = (T) (object) sbyte.MinValue;
                NaN = default!;
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) (sbyte) 1;
                Two = (T) (object) (sbyte) 2;
                MinusOne = (T) (object) (sbyte) -1;
                MinusTwo = (T) (object) (sbyte) -2;
                E = (T) (object) (sbyte) FloatE;
                Pi = (T) (object) (sbyte) FloatPi;
                Tau = (T) (object) (sbyte) FloatTau;
            }
            else if (typeof(T) == typeof(byte))
            {
                Epsilon = default!;
                MaxValue = (T) (object) byte.MaxValue;
                MinValue = (T) (object) byte.MinValue;
                NaN = default!;
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) (byte) 1;
                Two = (T) (object) (byte) 2;
                MinusOne = default!;
                MinusTwo = default!;
                E = (T) (object) (byte) FloatE;
                Pi = (T) (object) (byte) FloatPi;
                Tau = (T) (object) (byte) FloatTau;
            }
            else if (typeof(T) == typeof(int))
            {
                Epsilon = default!;
                MaxValue = (T) (object) int.MaxValue;
                MinValue = (T) (object) int.MinValue;
                NaN = default!;
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) 1;
                Two = (T) (object) 2;
                MinusOne = (T) (object) -1;
                MinusTwo = (T) (object) -2;
                E = (T) (object) (int) FloatE;
                Pi = (T) (object) (int) FloatPi;
                Tau = (T) (object) (int) FloatTau;
            }
            else if (typeof(T) == typeof(uint))
            {
                Epsilon = default!;
                MaxValue = (T) (object) uint.MaxValue;
                MinValue = (T) (object) uint.MinValue;
                NaN = default!;
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) 1u;
                Two = (T) (object) 2u;
                MinusOne = default!;
                MinusTwo = default!;
                E = (T) (object) (uint) FloatE;
                Pi = (T) (object) (uint) FloatPi;
                Tau = (T) (object) (uint) FloatTau;
            }
            else if (typeof(T) == typeof(long))
            {
                Epsilon = default!;
                MaxValue = (T) (object) long.MaxValue;
                MinValue = (T) (object) long.MinValue;
                NaN = default!;
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) 1L;
                Two = (T) (object) 2L;
                MinusOne = (T) (object) -1L;
                MinusTwo = (T) (object) -2L;
                E = (T) (object) (long) FloatE;
                Pi = (T) (object) (long) FloatPi;
                Tau = (T) (object) (long) FloatTau;
            }
            else if (typeof(T) == typeof(ulong))
            {
                Epsilon = default!;
                MaxValue = (T) (object) ulong.MaxValue;
                MinValue = (T) (object) ulong.MinValue;
                NaN = default!;
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) 1ul;
                Two = (T) (object) 2ul;
                MinusOne = default!;
                MinusTwo = default!;
                E = (T) (object) (ulong) FloatE;
                Pi = (T) (object) (ulong) FloatPi;
                Tau = (T) (object) (ulong) FloatTau;
            }
            else if (typeof(T) == typeof(BigInteger))
            {
                Epsilon = default!;
                MaxValue = default!;
                MinValue = default!;
                NaN = default!;
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) BigInteger.One;
                Two = (T) (object) (BigInteger) 2;
                MinusOne = default!;
                MinusTwo = default!;
                E = (T) (object) (BigInteger) FloatE;
                Pi = (T) (object) (BigInteger) FloatPi;
                Tau = (T) (object) (BigInteger) FloatTau;
            }
            else if (typeof(T) == typeof(Complex))
            {
                Epsilon = (T) (object) (Complex)double.Epsilon;
                MaxValue = default!;
                MinValue = default!;
#if NETCOREAPP3_0_OR_GREATER
                NaN = (T) (object) Complex.NaN;
#else
// https://source.dot.net/#System.Runtime.Numerics/System/Numerics/Complex.cs,d2c68d149ad2b6de
                NaN = (T) (object) new Complex(double.NaN, double.NaN);
#endif
                NegativeInfinity = default!;
                PositiveInfinity = default!;
                One = (T) (object) (Complex) 1;
                Two = (T) (object) (Complex) 2;
                MinusOne = (T) (object) (Complex) (-1d);
                MinusTwo = (T) (object) (Complex) (-2d);
                E = (T) (object) (Complex) Math.E;
                Pi = (T) (object) (Complex) Math.PI;
#if !NET5_0
                Tau = Scalar.Multiply(Pi, Two);
#else
                Tau = (T) (object) (Complex) Math.Tau;
#endif
            }
            else
            {
                // if it's none of these cases, don't do the general cases.
                return;
            }

            PiOver2 = Scalar.Divide(Pi, Two);
            DegreesPerRadian = Scalar.Divide(Scalar.As<float, T>(180), Pi);
            RadiansPerDegree = Scalar.Divide(Pi, Scalar.As<float, T>(180));
        }
    }
}