// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if INTRINSICS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Exposes bunch of methods for working with hardware accelerated operations.
    /// </summary>
    public static class Simd64<T> where T : unmanaged
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
        public static readonly Vector64<T> Epsilon;

        /// <summary>
        /// Represents the largest possible value.
        /// </summary>
        public static readonly Vector64<T> MaxValue;

        /// <summary>
        /// Represents the smallest possible value.
        /// </summary>
        public static readonly Vector64<T> MinValue;

        /// <summary>
        /// Represents not a number (NaN). Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector64<T> NaN;

        /// <summary>
        /// Represents negative infinity. Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector64<T> NegativeInfinity;

        /// <summary>
        /// Represents positive infinity. Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector64<T> PositiveInfinity;

        /// <summary>
        /// Represents zero.
        /// </summary>
        public static readonly Vector64<T> Zero = Vector64<T>.Zero;

        /// <summary>
        /// Represents one.
        /// </summary>
        public static readonly Vector64<T> One;

        /// <summary>
        /// Represents two.
        /// </summary>
        public static readonly Vector64<T> Two;

        /// <summary>
        /// Represents negative one.
        /// </summary>
        public static readonly Vector64<T> MinusOne;

        /// <summary>
        /// Represents negative two.
        /// </summary>
        public static readonly Vector64<T> MinusTwo;

        /// <summary>
        /// Represents the natural logarithmic base, specified by the constant, <code>e</code>.
        /// </summary>
        public static readonly Vector64<T> E;

        /// <summary>
        /// Represents the ratio of the circumference of a circle to its diameter, specified by the constant, <code>π</code>.
        /// </summary>
        public static readonly Vector64<T> Pi;

        /// <summary>
        /// Represents Pi divided by two.
        /// </summary>
        public static readonly Vector64<T> PiOver2;

        /// <summary>
        /// Represents the number of radians in one turn, specified by the constant, <code>τ</code>.
        /// </summary>
        public static readonly Vector64<T> Tau;
        
        /// <summary>
        /// Gets a new <see cref="Vector64{T}" /> with all bits set to 1.
        /// </summary>
        public static readonly Vector64<T> AllBitsSet;

        /// <summary>
        /// Indicates if there exists SIMD hardware acceleration
        /// for the type <typeparamref name="T"/>.
        /// </summary>
        public static bool IsHardwareAccelerated =>
#if AdvSIMD
            System.Runtime.Intrinsics.Arm.AdvSimd.IsSupported;
#else
            false;
#endif

        internal static readonly Vector64<T> MaxValueOver2;

        [MethodImpl(Scalar.MaxOpt)]
        static Simd64()
        {
            Epsilon = Simd64.Create(Scalar<T>.Epsilon);
            MaxValue = Simd64.Create(Scalar<T>.MaxValue);
            MinValue = Simd64.Create(Scalar<T>.MinValue);
            NaN = Simd64.Create(Scalar<T>.NaN);
            NegativeInfinity = Simd64.Create(Scalar<T>.NegativeInfinity);
            PositiveInfinity = Simd64.Create(Scalar<T>.PositiveInfinity);
            One = Simd64.Create(Scalar<T>.One);
            Two = Simd64.Create(Scalar<T>.Two);
            MinusOne = Simd64.Create(Scalar<T>.MinusOne);
            MinusTwo = Simd64.Create(Scalar<T>.MinusTwo);
            E = Simd64.Create(Scalar<T>.E);
            Pi = Simd64.Create(Scalar<T>.Pi);
            PiOver2 = Simd64.Create(Scalar<T>.PiOver2);
            Tau = Simd64.Create(Scalar<T>.Tau);
            MaxValueOver2 = Simd64.Add(Simd64.Divide(Simd64<T>.MaxValue, Simd64<T>.Two), Simd64<T>.One);
#if NET5_0_OR_GREATER
            AllBitsSet = Vector64<T>.AllBitsSet;
#else
            AllBitsSet = Vector64<T>.Zero;
            for (int i = 0; i < Vector64<T>.Count; i++)
            {
                AllBitsSet = AllBitsSet.WithElement(i, Scalar.Not(Scalar<T>.Zero));
            }
#endif
        }
    }
}
#endif
