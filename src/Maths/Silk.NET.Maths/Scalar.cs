using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    internal static class Scalar<T>
        where T : unmanaged
    {
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
            throw new NotSupportedException(); // TODO: Document what went wrong
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T SquareRoot(T value)
        {
            throw new NotImplementedException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Add(T right, T left)
        {
            throw new NotImplementedException();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Subtract(T right, T left)
        {
            throw new NotImplementedException();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Multiply(T right, T left)
        {
            throw new NotImplementedException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Divide(T right, T left)
        {
            throw new NotImplementedException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Min(T right, T left)
        {
            throw new NotImplementedException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Max(T right, T left)
        {
            throw new NotImplementedException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Larger(T left, T right)
        {
            throw new NotImplementedException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Clamp(T value, T min, T max)
        {
            throw new NotImplementedException();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Negate(T value)
        {
            throw new NotImplementedException();
        }

        public static bool Equal(T left, T right)
        {
            throw new NotImplementedException();
        }
    }
}
