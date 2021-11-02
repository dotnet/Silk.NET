// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

#if INTRINSICS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace Silk.NET.Maths
{
    public static class Simd128<T> where T : unmanaged
    {
        public static bool IsSupported => typeof(T) == typeof(sbyte)
                                          || typeof(T) == typeof(byte)
                                          || typeof(T) == typeof(ushort)
                                          || typeof(T) == typeof(short)
                                          || typeof(T) == typeof(uint)
                                          || typeof(T) == typeof(int)
                                          || typeof(T) == typeof(ulong)
                                          || typeof(T) == typeof(long)
                                          || typeof(T) == typeof(float)
                                          || typeof(T) == typeof(double);
        
        /// <summary>
        /// Represents the smallest positive value that is greater than zero. Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector128<T> Epsilon;

        /// <summary>
        /// Represents the largest possible value.
        /// </summary>
        public static readonly Vector128<T> MaxValue;

        /// <summary>
        /// Represents the smallest possible value.
        /// </summary>
        public static readonly Vector128<T> MinValue;

        /// <summary>
        /// Represents not a number (NaN). Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector128<T> NaN;

        /// <summary>
        /// Represents negative infinity. Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector128<T> NegativeInfinity;

        /// <summary>
        /// Represents positive infinity. Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector128<T> PositiveInfinity;

        /// <summary>
        /// Represents zero.
        /// </summary>
        public static readonly Vector128<T> Zero = Vector128<T>.Zero;

        /// <summary>
        /// Represents one.
        /// </summary>
        public static readonly Vector128<T> One;

        /// <summary>
        /// Represents two.
        /// </summary>
        public static readonly Vector128<T> Two;

        /// <summary>
        /// Represents negative one.
        /// </summary>
        public static readonly Vector128<T> MinusOne;

        /// <summary>
        /// Represents negative two.
        /// </summary>
        public static readonly Vector128<T> MinusTwo;

        /// <summary>
        /// Represents the natural logarithmic base, specified by the constant, <code>e</code>.
        /// </summary>
        public static readonly Vector128<T> E;

        /// <summary>
        /// Represents the ratio of the circumference of a circle to its diameter, specified by the constant, <code>π</code>.
        /// </summary>
        public static readonly Vector128<T> Pi;

        /// <summary>
        /// Represents Pi divided by two.
        /// </summary>
        public static readonly Vector128<T> PiOver2;

        /// <summary>
        /// Represents the number of radians in one turn, specified by the constant, <code>τ</code>.
        /// </summary>
        public static readonly Vector128<T> Tau;

        [MethodImpl(Scalar.MaxOpt)]
        static Simd128()
        {
            Epsilon = Simd128.Create(Scalar<T>.Epsilon);
            MaxValue = Simd128.Create(Scalar<T>.MaxValue);
            MinValue = Simd128.Create(Scalar<T>.MinValue);
            NaN = Simd128.Create(Scalar<T>.NaN);
            NegativeInfinity = Simd128.Create(Scalar<T>.NegativeInfinity);
            PositiveInfinity = Simd128.Create(Scalar<T>.PositiveInfinity);
            One = Simd128.Create(Scalar<T>.One);
            Two = Simd128.Create(Scalar<T>.Two);
            MinusOne = Simd128.Create(Scalar<T>.MinusOne);
            MinusTwo = Simd128.Create(Scalar<T>.MinusTwo);
            E = Simd128.Create(Scalar<T>.E);
            Pi = Simd128.Create(Scalar<T>.Pi);
            PiOver2 = Simd128.Create(Scalar<T>.PiOver2);
            Tau = Simd128.Create(Scalar<T>.Tau);
        }
    }
}
#endif
