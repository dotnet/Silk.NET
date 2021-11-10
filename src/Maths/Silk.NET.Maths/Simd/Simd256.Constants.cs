// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if INTRINSICS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Exposes bunch of methods for working with hardware accelerated operations.
    /// </summary>
    public static class Simd256<T> where T : unmanaged
    {
        /// <summary>
        /// Indicates if the type is supported.
        /// </summary>
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
        public static readonly Vector256<T> Epsilon;

        /// <summary>
        /// Represents the largest possible value.
        /// </summary>
        public static readonly Vector256<T> MaxValue;

        /// <summary>
        /// Represents the smallest possible value.
        /// </summary>
        public static readonly Vector256<T> MinValue;

        /// <summary>
        /// Represents not a number (NaN). Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector256<T> NaN;

        /// <summary>
        /// Represents negative infinity. Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector256<T> NegativeInfinity;

        /// <summary>
        /// Represents positive infinity. Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector256<T> PositiveInfinity;

        /// <summary>
        /// Represents zero.
        /// </summary>
        public static readonly Vector256<T> Zero = Vector256<T>.Zero;

        /// <summary>
        /// Represents one.
        /// </summary>
        public static readonly Vector256<T> One;

        /// <summary>
        /// Represents two.
        /// </summary>
        public static readonly Vector256<T> Two;

        /// <summary>
        /// Represents negative one.
        /// </summary>
        public static readonly Vector256<T> MinusOne;

        /// <summary>
        /// Represents negative two.
        /// </summary>
        public static readonly Vector256<T> MinusTwo;

        /// <summary>
        /// Represents the natural logarithmic base, specified by the constant, <code>e</code>.
        /// </summary>
        public static readonly Vector256<T> E;

        /// <summary>
        /// Represents the ratio of the circumference of a circle to its diameter, specified by the constant, <code>π</code>.
        /// </summary>
        public static readonly Vector256<T> Pi;

        /// <summary>
        /// Represents Pi divided by two.
        /// </summary>
        public static readonly Vector256<T> PiOver2;

        /// <summary>
        /// Represents the number of radians in one turn, specified by the constant, <code>τ</code>.
        /// </summary>
        public static readonly Vector256<T> Tau;
        
        /// <summary>
        /// Gets a new <see cref="Vector256{T}" /> with all bits set to 1.
        /// </summary>
        public static readonly Vector256<T> AllBitsSet;

        /// <summary>
        /// Indicates if there exists SIMD hardware acceleration
        /// for the type <typeparamref name="T"/>.
        /// </summary>
        public static bool IsHardwareAccelerated => Avx2.IsSupported;

        internal static readonly Vector256<T> MaxValueOver2;

        [MethodImpl(Scalar.MaxOpt)]
        static Simd256()
        {
            Epsilon = Simd256.Create(Scalar<T>.Epsilon);
            MaxValue = Simd256.Create(Scalar<T>.MaxValue);
            MinValue = Simd256.Create(Scalar<T>.MinValue);
            NaN = Simd256.Create(Scalar<T>.NaN);
            NegativeInfinity = Simd256.Create(Scalar<T>.NegativeInfinity);
            PositiveInfinity = Simd256.Create(Scalar<T>.PositiveInfinity);
            One = Simd256.Create(Scalar<T>.One);
            Two = Simd256.Create(Scalar<T>.Two);
            MinusOne = Simd256.Create(Scalar<T>.MinusOne);
            MinusTwo = Simd256.Create(Scalar<T>.MinusTwo);
            E = Simd256.Create(Scalar<T>.E);
            Pi = Simd256.Create(Scalar<T>.Pi);
            PiOver2 = Simd256.Create(Scalar<T>.PiOver2);
            Tau = Simd256.Create(Scalar<T>.Tau);
            MaxValueOver2 = Simd256.Add(Simd256.Divide(Simd256<T>.MaxValue, Simd256<T>.Two), Simd256<T>.One);
#if NET5_0_OR_GREATER
            AllBitsSet = Vector256<T>.AllBitsSet;
#else
            AllBitsSet = Vector256<T>.Zero;
            for (int i = 0; i < Vector256<T>.Count; i++)
            {
                AllBitsSet = AllBitsSet.WithElement(i, Scalar.Not(Scalar<T>.Zero));
            }
#endif
        }
    }
}
#endif
