// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;
#if NETSTANDARD2_0
using MathF = System.Math;
#endif

namespace Silk.NET.Maths
{
    internal static class Scalar<T> 
        where T : unmanaged, IFormattable
    {
        /* Note: The following patterns are used throughout the code here and are described here
        *
        * PATTERN:
        *    if (typeof(T) == typeof(int)) { ... }
        *    else if (typeof(T) == typeof(float)) { ... }
         *   ...
        * EXPLANATION:
        *    At runtime, each instantiation of Scalar<T> will be type-specific, and each of these typeof blocks will be eliminated,
        *    as typeof(T) is a (JIT) compile-time constant for each instantiation. This design was chosen to eliminate any overhead from
        *    delegates and other patterns.
        */
        
        public static T One
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T)(object)(byte)1;
                }

                if (typeof(T) == typeof(sbyte))
                {
                    return (T)(object)(sbyte)1;
                }

                if (typeof(T) == typeof(ushort))
                {
                    return (T)(object)(ushort)1;
                }

                if (typeof(T) == typeof(short))
                {
                    return (T)(object)(short)1;
                }

                if (typeof(T) == typeof(uint))
                {
                    return (T)(object)(uint)1;
                }

                if (typeof(T) == typeof(int))
                {
                    return (T)(object)1;
                }

                if (typeof(T) == typeof(ulong))
                {
                    return (T)(object)(ulong)1;
                }

                if (typeof(T) == typeof(long))
                {
                    return (T)(object)(long)1;
                }

                if (typeof(T) == typeof(Half))
                {
                    return (T)(object)(Half)1;
                }

                if (typeof(T) == typeof(float))
                {
                    return (T)(object)(float)1;
                }

                if (typeof(T) == typeof(double))
                {
                    return (T)(object)(double)1;
                }

                ThrowInvalidType();
                return default;
            }
        }
        
        public static T Two
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (typeof(T) == typeof(byte))
                {
                    return (T)(object)(byte)2;
                }

                if (typeof(T) == typeof(sbyte))
                {
                    return (T)(object)(sbyte)2;
                }

                if (typeof(T) == typeof(ushort))
                {
                    return (T)(object)(ushort)2;
                }

                if (typeof(T) == typeof(short))
                {
                    return (T)(object)(short)2;
                }

                if (typeof(T) == typeof(uint))
                {
                    return (T)(object)(uint)2;
                }

                if (typeof(T) == typeof(int))
                {
                    return (T)(object)2;
                }

                if (typeof(T) == typeof(ulong))
                {
                    return (T)(object)(ulong)2;
                }

                if (typeof(T) == typeof(long))
                {
                    return (T)(object)(long)2;
                }

                if (typeof(T) == typeof(Half))
                {
                    return (T)(object)(Half)2;
                }

                if (typeof(T) == typeof(float))
                {
                    return (T)(object)(float)2;
                }

                if (typeof(T) == typeof(double))
                {
                    return (T)(object)(double)2;
                }

                ThrowInvalidType();
                return default;
            }
        }

        public static T PositiveInfinity
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (typeof(T) == typeof(Half))
                {
                    return (T)(object)Half.PositiveInfinity;
                }

                if (typeof(T) == typeof(float))
                {
                    return (T)(object)float.PositiveInfinity;
                }

                if (typeof(T) == typeof(double))
                {
                    return (T)(object)double.PositiveInfinity;
                }

                ThrowInvalidType();
                return default; // can't be reached
            }
        }

        public static T NegativeInfinity
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (typeof(T) == typeof(Half))
                {
                    return (T)(object)Half.NegativeInfinity;
                }

                if (typeof(T) == typeof(float))
                {
                    return (T)(object)float.NegativeInfinity;
                }

                if (typeof(T) == typeof(double))
                {
                    return (T)(object)double.NegativeInfinity;
                }

                ThrowInvalidType();
                return default; // can't be reached
            }
        }
        
        internal static void ThrowInvalidType()
        {
            throw new NotSupportedException("This operation isn't supported for the current type.");
        }

        internal static void ThrowForUnsupportedBaseType()
        {
            if (
                typeof(T) != typeof(byte) &&
                typeof(T) != typeof(sbyte) &&
                typeof(T) != typeof(ushort) &&
                typeof(T) != typeof(short) &&
                typeof(T) != typeof(uint) &&
                typeof(T) != typeof(int) &&
                typeof(T) != typeof(ulong) &&
                typeof(T) != typeof(long) &&
                typeof(T) != typeof(Half) &&
                typeof(T) != typeof(float) &&
                typeof(T) != typeof(double))
                ThrowInvalidType();
        }

        internal static void ThrowNotSupportedByUnderlying()
        {
            throw new NotSupportedException($"{typeof(T).FullName} not supported by the underlying type");
        }

        internal static void ThrowIndexOutOfRange()
        {
            throw new IndexOutOfRangeException();
        }
        
        internal static void ThrowVectorTTooSmall()
        {
            throw new NotSupportedException("Vector<T> too small to fit");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T SquareRoot(T value)
        {
            if (typeof(T) == typeof(byte))
            {
                return (T) (object) (byte) (MathF.Sqrt((byte) (object) value));
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T) (object) (sbyte) (MathF.Sqrt((sbyte) (object) value));
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T) (object) (ushort) (MathF.Sqrt((ushort) (object) value));
            }

            if (typeof(T) == typeof(short))
            {
                return (T) (object) (short) (MathF.Sqrt((short) (object) value));
            }

            if (typeof(T) == typeof(uint))
            {
                return (T) (object) (uint) (MathF.Sqrt((uint) (object) value));
            }

            if (typeof(T) == typeof(int))
            {
                return (T) (object) (int) (MathF.Sqrt((int) (object) value));
            }

            if (typeof(T) == typeof(ulong))
            {
                return (T) (object) (ulong) (Math.Sqrt((ulong) (object) value));
            }

            if (typeof(T) == typeof(long))
            {
                return (T) (object) (long) (Math.Sqrt((long) (object) value));
            }

            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) (MathF.Sqrt((Half) (object) value));
            }

            if (typeof(T) == typeof(float))
            {
                return (T) (object) (float) (MathF.Sqrt((float) (object) value));
            }

            if (typeof(T) == typeof(double))
            {
                return (T) (object) (double) (Math.Sqrt((double) (object) value));
            }

            ThrowInvalidType();
            return default;
                
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Add(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return (T) (object) (byte) ((byte) (object) left + (byte) (object) right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T) (object) (sbyte) ((sbyte) (object) left + (sbyte) (object) right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T) (object) (ushort) ((ushort) (object) left + (ushort) (object) right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T) (object) (short) ((short) (object) left + (short) (object) right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T) (object) (uint) ((uint) (object) left + (uint) (object) right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T) (object) (int) ((int) (object) left + (int) (object) right);
            }

            if (typeof(T) == typeof(ulong))
            {
                return (T) (object) (ulong) ((ulong) (object) left + (ulong) (object) right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T) (object) (long) ((long) (object) left + (long) (object) right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((Half) (object) left + (Half) (object) right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T) (object) (float) ((float) (object) left + (float) (object) right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T) (object) (double) ((double) (object) left + (double) (object) right);
            }

            ThrowInvalidType();
            return default;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Subtract(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return (T) (object) (byte) ((byte) (object) left - (byte) (object) right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T) (object) (sbyte) ((sbyte) (object) left - (sbyte) (object) right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T) (object) (ushort) ((ushort) (object) left - (ushort) (object) right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T) (object) (short) ((short) (object) left - (short) (object) right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T) (object) (uint) ((uint) (object) left - (uint) (object) right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T) (object) (int) ((int) (object) left - (int) (object) right);
            }

            if (typeof(T) == typeof(ulong))
            {
                return (T) (object) (ulong) ((ulong) (object) left - (ulong) (object) right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T) (object) (long) ((long) (object) left - (long) (object) right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((Half) (object) left - (Half) (object) right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T) (object) (float) ((float) (object) left - (float) (object) right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T) (object) (double) ((double) (object) left - (double) (object) right);
            }

            ThrowInvalidType();
            return default;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Multiply(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return (T) (object) (byte) ((byte) (object) left * (byte) (object) right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T) (object) (sbyte) ((sbyte) (object) left * (sbyte) (object) right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T) (object) (ushort) ((ushort) (object) left * (ushort) (object) right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T) (object) (short) ((short) (object) left * (short) (object) right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T) (object) (uint) ((uint) (object) left * (uint) (object) right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T) (object) (int) ((int) (object) left * (int) (object) right);
            }

            if (typeof(T) == typeof(ulong))
            {
                return (T) (object) (ulong) ((ulong) (object) left * (ulong) (object) right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T) (object) (long) ((long) (object) left * (long) (object) right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((Half) (object) left * (Half) (object) right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T) (object) (float) ((float) (object) left * (float) (object) right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T) (object) (double) ((double) (object) left * (double) (object) right);
            }

            ThrowInvalidType();
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Divide(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return (T) (object) (byte) ((byte) (object) left / (byte) (object) right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T) (object) (sbyte) ((sbyte) (object) left / (sbyte) (object) right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T) (object) (ushort) ((ushort) (object) left / (ushort) (object) right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T) (object) (short) ((short) (object) left / (short) (object) right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T) (object) (uint) ((uint) (object) left / (uint) (object) right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T) (object) (int) ((int) (object) left / (int) (object) right);
            }

            if (typeof(T) == typeof(ulong))
            {
                return (T) (object) (ulong) ((ulong) (object) left / (ulong) (object) right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T) (object) (long) ((long) (object) left / (long) (object) right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) ((Half) (object) left / (Half) (object) right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T) (object) (float) ((float) (object) left / (float) (object) right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T) (object) (double) ((double) (object) left / (double) (object) right);
            }

            ThrowInvalidType();
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Min(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return (T) (object) (byte) (Math.Min((byte) (object) left, (byte) (object) right));
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T) (object) (sbyte) (Math.Min((sbyte) (object) left, (sbyte) (object) right));
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T) (object) (ushort) (Math.Min((ushort) (object) left, (ushort) (object) right));
            }

            if (typeof(T) == typeof(short))
            {
                return (T) (object) (short) (Math.Min((short) (object) left, (short) (object) right));
            }

            if (typeof(T) == typeof(uint))
            {
                return (T) (object) (uint) (Math.Min((uint) (object) left, (uint) (object) right));
            }

            if (typeof(T) == typeof(int))
            {
                return (T) (object) (int) (Math.Min((int) (object) left, (int) (object) right));
            }

            if (typeof(T) == typeof(ulong))
            {
                return (T) (object) (ulong) (Math.Min((ulong) (object) left, (ulong) (object) right));
            }

            if (typeof(T) == typeof(long))
            {
                return (T) (object) (long) (Math.Min((long) (object) left, (long) (object) right));
            }

            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) (Math.Min((Half) (object) left, (Half) (object) right));
            }

            if (typeof(T) == typeof(float))
            {
                return (T) (object) (float) (Math.Min((float) (object) left, (float) (object) right));
            }

            if (typeof(T) == typeof(double))
            {
                return (T) (object) (double) (Math.Min((double) (object) left, (double) (object) right));
            }

            ThrowInvalidType();
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Max(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return (T) (object) (byte) (Math.Max((byte) (object) left, (byte) (object) right));
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T) (object) (sbyte) (Math.Max((sbyte) (object) left, (sbyte) (object) right));
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T) (object) (ushort) (Math.Max((ushort) (object) left, (ushort) (object) right));
            }

            if (typeof(T) == typeof(short))
            {
                return (T) (object) (short) (Math.Max((short) (object) left, (short) (object) right));
            }

            if (typeof(T) == typeof(uint))
            {
                return (T) (object) (uint) (Math.Max((uint) (object) left, (uint) (object) right));
            }

            if (typeof(T) == typeof(int))
            {
                return (T) (object) (int) (Math.Max((int) (object) left, (int) (object) right));
            }

            if (typeof(T) == typeof(ulong))
            {
                return (T) (object) (ulong) (Math.Max((ulong) (object) left, (ulong) (object) right));
            }

            if (typeof(T) == typeof(long))
            {
                return (T) (object) (long) (Math.Max((long) (object) left, (long) (object) right));
            }

            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (Half) (Math.Max((Half) (object) left, (Half) (object) right));
            }

            if (typeof(T) == typeof(float))
            {
                return (T) (object) (float) (Math.Max((float) (object) left, (float) (object) right));
            }

            if (typeof(T) == typeof(double))
            {
                return (T) (object) (double) (Math.Max((double) (object) left, (double) (object) right));
            }

            ThrowInvalidType();
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Larger(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return ((byte) (object) left > (byte) (object) right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return ((sbyte) (object) left > (sbyte) (object) right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return ((ushort) (object) left > (ushort) (object) right);
            }

            if (typeof(T) == typeof(short))
            {
                return ((short) (object) left > (short) (object) right);
            }

            if (typeof(T) == typeof(uint))
            {
                return ((uint) (object) left > (uint) (object) right);
            }

            if (typeof(T) == typeof(int))
            {
                return ((int) (object) left > (int) (object) right);
            }

            if (typeof(T) == typeof(ulong))
            {
                return ((ulong) (object) left > (ulong) (object) right);
            }

            if (typeof(T) == typeof(long))
            {
                return ((long) (object) left > (long) (object) right);
            }

            if (typeof(T) == typeof(Half))
            {
                return ((Half) (object) left > (Half) (object) right);
            }

            if (typeof(T) == typeof(float))
            {
                return ((float) (object) left > (float) (object) right);
            }

            if (typeof(T) == typeof(double))
            {
                return ((double) (object) left > (double) (object) right);
            }

            ThrowInvalidType();
            return default;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Smaller(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return ((byte) (object) left < (byte) (object) right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return ((sbyte) (object) left < (sbyte) (object) right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return ((ushort) (object) left < (ushort) (object) right);
            }

            if (typeof(T) == typeof(short))
            {
                return ((short) (object) left < (short) (object) right);
            }

            if (typeof(T) == typeof(uint))
            {
                return ((uint) (object) left < (uint) (object) right);
            }

            if (typeof(T) == typeof(int))
            {
                return ((int) (object) left < (int) (object) right);
            }

            if (typeof(T) == typeof(ulong))
            {
                return ((ulong) (object) left < (ulong) (object) right);
            }

            if (typeof(T) == typeof(long))
            {
                return ((long) (object) left < (long) (object) right);
            }

            if (typeof(T) == typeof(Half))
            {
                return ((Half) (object) left < (Half) (object) right);
            }

            if (typeof(T) == typeof(float))
            {
                return ((float) (object) left < (float) (object) right);
            }

            if (typeof(T) == typeof(double))
            {
                return ((double) (object) left < (double) (object) right);
            }

            ThrowInvalidType();
            return default;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LargerEquals(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return ((byte) (object) left >= (byte) (object) right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return ((sbyte) (object) left >= (sbyte) (object) right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return ((ushort) (object) left >= (ushort) (object) right);
            }

            if (typeof(T) == typeof(short))
            {
                return ((short) (object) left >= (short) (object) right);
            }

            if (typeof(T) == typeof(uint))
            {
                return ((uint) (object) left >= (uint) (object) right);
            }

            if (typeof(T) == typeof(int))
            {
                return ((int) (object) left >= (int) (object) right);
            }

            if (typeof(T) == typeof(ulong))
            {
                return ((ulong) (object) left >= (ulong) (object) right);
            }

            if (typeof(T) == typeof(long))
            {
                return ((long) (object) left >= (long) (object) right);
            }

            if (typeof(T) == typeof(Half))
            {
                return ((Half) (object) left >= (Half) (object) right);
            }

            if (typeof(T) == typeof(float))
            {
                return ((float) (object) left >= (float) (object) right);
            }

            if (typeof(T) == typeof(double))
            {
                return ((double) (object) left >= (double) (object) right);
            }

            ThrowInvalidType();
            return default;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool SmallerEquals(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return ((byte) (object) left <= (byte) (object) right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return ((sbyte) (object) left <= (sbyte) (object) right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return ((ushort) (object) left <= (ushort) (object) right);
            }

            if (typeof(T) == typeof(short))
            {
                return ((short) (object) left <= (short) (object) right);
            }

            if (typeof(T) == typeof(uint))
            {
                return ((uint) (object) left <= (uint) (object) right);
            }

            if (typeof(T) == typeof(int))
            {
                return ((int) (object) left <= (int) (object) right);
            }

            if (typeof(T) == typeof(ulong))
            {
                return ((ulong) (object) left <= (ulong) (object) right);
            }

            if (typeof(T) == typeof(long))
            {
                return ((long) (object) left <= (long) (object) right);
            }

            if (typeof(T) == typeof(Half))
            {
                return ((Half) (object) left <= (Half) (object) right);
            }

            if (typeof(T) == typeof(float))
            {
                return ((float) (object) left <= (float) (object) right);
            }

            if (typeof(T) == typeof(double))
            {
                return ((double) (object) left <= (double) (object) right);
            }

            ThrowInvalidType();
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Clamp(T value, T min, T max)
        {
            return Min(Max(value, min), max);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Negate(T value)
        {
            if (typeof(T) == typeof(sbyte))
            {
                return (T) (object) ((sbyte) -(sbyte) (object) value);
            }

            if (typeof(T) == typeof(short))
            {
                return (T) (object) ((short) -(short) (object) value);
            }

            if (typeof(T) == typeof(int))
            {
                return (T) (object) ((int) -(int) (object) value);
            }

            if (typeof(T) == typeof(long))
            {
                return (T) (object) ((long) -(long) (object) value);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T) (object) ((Half)(-(Half) (object) value));
            }

            if (typeof(T) == typeof(float))
            {
                return (T) (object) ((float) -(float) (object) value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T) (object) ((double) -(double) (object) value);
            }

            ThrowInvalidType();
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Equal(T left, T right)
        {
            if (typeof(T) == typeof(byte))
            {
                return ((byte) (object) left == (byte) (object) right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return ((sbyte) (object) left == (sbyte) (object) right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return ((ushort) (object) left == (ushort) (object) right);
            }

            if (typeof(T) == typeof(short))
            {
                return ((short) (object) left == (short) (object) right);
            }

            if (typeof(T) == typeof(uint))
            {
                return ((uint) (object) left == (uint) (object) right);
            }

            if (typeof(T) == typeof(int))
            {
                return ((int) (object) left == (int) (object) right);
            }

            if (typeof(T) == typeof(ulong))
            {
                return ((ulong) (object) left == (ulong) (object) right);
            }

            if (typeof(T) == typeof(long))
            {
                return ((long) (object) left == (long) (object) right);
            }

            if (typeof(T) == typeof(Half))
            {
                return ((Half) (object) left == (Half) (object) right);
            }

            if (typeof(T) == typeof(float))
            {
                return ((float) (object) left == (float) (object) right);
            }

            if (typeof(T) == typeof(double))
            {
                return ((double) (object) left == (double) (object) right);
            }

            ThrowInvalidType();
            return default;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Acos(T value)
        {
            if (typeof(T) == typeof(byte))
            {
                return (T) (object) (MathF.Acos((byte) (object) value));
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T) (object) (MathF.Acos((sbyte) (object) value));
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T) (object) (MathF.Acos((ushort) (object) value));
            }

            if (typeof(T) == typeof(short))
            {
                return (T) (object) (MathF.Acos((short) (object) value));
            }

            if (typeof(T) == typeof(uint))
            {
                return (T) (object) (MathF.Acos((uint) (object) value));
            }

            if (typeof(T) == typeof(int))
            {
                return (T) (object) (MathF.Acos((int) (object) value));
            }

            if (typeof(T) == typeof(ulong))
            {
                return (T) (object) (ulong) (Math.Acos((ulong) (object) value));
            }

            if (typeof(T) == typeof(long))
            {
                return (T) (object) (long) (Math.Acos((long) (object) value));
            }

            if (typeof(T) == typeof(Half))
            {
                return (T) (object) (MathF.Acos((Half) (object) value));
            }

            if (typeof(T) == typeof(float))
            {
                return (T) (object) (MathF.Acos((float) (object) value));
            }

            if (typeof(T) == typeof(double))
            {
                return (T) (object) (double) (Math.Acos((double) (object) value));
            }

            ThrowInvalidType();
            return default;
        }
    }
}
