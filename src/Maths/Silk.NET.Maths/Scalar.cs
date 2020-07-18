// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

#if NETSTANDARD2_0
using MathF = System.Math;
#endif
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Silk.NET.Maths
{
    internal static class Scalar<T> where T : unmanaged, IFormattable
    {
        /*
         * PLEASE DO ONLY MODIFY IF ADDING A PROPERTY
         * DO NOT EVER ADD METHODS / NON-FORWARD POPERTIES TO THIS TYPE
         * See non-generic Scalar for all code
         */

        public static T One
        {
            [M(MethodImplOptions.AggressiveInlining)]
            get => Scalar.One<T>();
        }

        public static T Two
        {
            [M(MethodImplOptions.AggressiveInlining)]
            get => Scalar.Two<T>();
        }

        public static T Pi
        {
            [M(MethodImplOptions.AggressiveInlining)]
            get => Scalar.Pi<T>();
        }

        public static T Tau
        {
            [M(MethodImplOptions.AggressiveInlining)]
            get => Scalar.Tau<T>();
        }

        public static T PositiveInfinity
        {
            [M(MethodImplOptions.AggressiveInlining)]
            get => Scalar.PositiveInfinity<T>();
        }

        public static T NegativeInfinity
        {
            [M(MethodImplOptions.AggressiveInlining)]
            get => Scalar.NegativeInfinity<T>();
        }
    }

    internal static class Scalar
    {
        private const MethodImplOptions MethodImplOptions =
            System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining | (MethodImplOptions)512;

        private const double HALF_PI = Math.PI / 2;
        /* Note: The following patterns are used throughout the code here and are described here
        *
        * PATTERN:
        *    if (typeof(T) == typeof(int)) { ... }
        *    else if (typeof(T) == typeof(float)) { ... }
        *    ...
        * EXPLANATION:
        *    At runtime, each instantiation of Scalar<T> will be type-specific, and each of these typeof blocks will be eliminated,
        *    as typeof(T) is a (JIT) compile-time constant for each instantiation. This design was chosen to eliminate any overhead from
        *    delegates and other patterns.
        * 
        * PATTERN:
        *    ...
        *    return _Method2(...);
        * EXPLANATION:
        *    In some cases JIT will refuse to inline methods that have a lot of generic blocks,
        *    because there are a lot of locals and the IL is rather large
        *    See https://github.com/dotnet/runtime/issues/38106
        *
        * !!MAKE SURE TO CHECK JIT ASM WHEN MODIFYING THIS FILE!!
        */

        public static T One<T>() where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
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

            return _One2<T>();
        }

        [M(MethodImplOptions)]
        private static T _One2<T>() where T : unmanaged, IFormattable
        {
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


            Debug.Fail("Unreachable Code");
            return default;
        }

        public static T Two<T>() where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
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

            return _Two2<T>();
        }

        private static T _Two2<T>() where T : unmanaged, IFormattable
        {
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


            Debug.Fail("Unreachable Code");
            return default;
        }
        
#if !NETSTANDARD2_0
        public static bool IsNormal<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(Half))
            {
                return Half.IsNormal((Half) (object) value);
            }

            if (typeof(T) == typeof(float))
            {
                return Single.IsNormal((Single) (object) value);
            }

            if (typeof(T) == typeof(double))
            {
                return Double.IsNormal((Double) (object) value);
            }
            
            return true;
        }
#endif

        public static T Pi<T>() where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)Math.PI;
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)(float)Math.PI;
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.PI;
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        public static T Tau<T>() where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)HALF_PI;
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)(float)HALF_PI;
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)HALF_PI;
            }

            Debug.Fail("Unreachable Code");
            return default;
        }

        public static T PositiveInfinity<T>() where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();

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


            Debug.Fail("Unreachable Code");
            return default; // can't be reached
        }

        public static T NegativeInfinity<T>() where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();

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


            Debug.Fail("Unreachable Code");
            return default; // can't be reached
        }

        public static T As<T>(float value) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)(byte)value;
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)(sbyte)value;
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T)(object)(ushort)value;
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)(short)value;
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)(object)(uint)value;
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)(int)value;
            }

            return _As2<T>(value);
        }

        private static T _As2<T>(float value) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (T)(object)(ulong)value;
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)(long)value;
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)value;
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)value;
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)(double)value;
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        internal static void ThrowInvalidType()
            => throw new NotSupportedException("This operation isn't supported for the current type.");

        [M(MethodImplOptions)]
        internal static void ThrowForUnsupportedBaseType<T>() where T : unmanaged, IFormattable
        {
            if (typeof(T) != typeof(byte) && typeof(T) != typeof(sbyte) && typeof(T) != typeof(ushort) &&
                typeof(T) != typeof(short) && typeof(T) != typeof(uint) && typeof(T) != typeof(int) &&
                typeof(T) != typeof(ulong) && typeof(T) != typeof(long) && typeof(T) != typeof(Half) &&
                typeof(T) != typeof(float) && typeof(T) != typeof(double))
            {
                ThrowInvalidType();
            }
        }

        [M(MethodImplOptions)]
        internal static void ThrowForIntegerBaseType<T>() where T : unmanaged, IFormattable
        {
            if (typeof(T) != typeof(Half) && typeof(T) != typeof(float) && typeof(T) != typeof(double))
            {
                ThrowInvalidType();
            }
        }

#if !NETSTANDARD2_0
        [DoesNotReturn]
#endif
        internal static void ThrowNotSupportedByUnderlying<T>() where T : unmanaged, IFormattable
            => throw new NotSupportedException($"{typeof(T).FullName} not supported by the underlying type");

#if !NETSTANDARD2_0
        [DoesNotReturn]
#endif
        internal static void ThrowIndexOutOfRange() => throw new IndexOutOfRangeException();

#if !NETSTANDARD2_0
        [DoesNotReturn]
#endif
        internal static void ThrowVectorTTooSmall() => throw new NotSupportedException("Vector<T> too small to fit");

        [M(MethodImplOptions)]
        public static T SquareRoot<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)(byte)MathF.Sqrt((byte)(object)value);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)(sbyte)MathF.Sqrt((sbyte)(object)value);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T)(object)(ushort)MathF.Sqrt((ushort)(object)value);
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)(short)MathF.Sqrt((short)(object)value);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)(object)(uint)MathF.Sqrt((uint)(object)value);
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)(int)MathF.Sqrt((int)(object)value);
            }

            return _SquareRoot2(value);
        }

        [M(MethodImplOptions)]
        private static T _SquareRoot2<T>(T value) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (T)(object)(ulong)Math.Sqrt((ulong)(object)value);
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)(long)Math.Sqrt((long)(object)value);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)MathF.Sqrt((Half)(object)value);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)MathF.Sqrt((float)(object)value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Sqrt((double)(object)value);
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Add<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)(byte)((byte)(object)left + (byte)(object)right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)(sbyte)((sbyte)(object)left + (sbyte)(object)right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T)(object)(ushort)((ushort)(object)left + (ushort)(object)right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)(short)((short)(object)left + (short)(object)right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)(object)((uint)(object)left + (uint)(object)right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)((int)(object)left + (int)(object)right);
            }

            return _Add2(left, right);
        }

        [M(MethodImplOptions)]
        private static T _Add2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (T)(object)((ulong)(object)left + (ulong)(object)right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)((long)(object)left + (long)(object)right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)((Half)(object)left + (Half)(object)right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)((float)(object)left + (float)(object)right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)((double)(object)left + (double)(object)right);
            }

            Debug.Fail("Unreachable Code");
            return default;
        }
        
        [M(MethodImplOptions)]
        public static T Mod<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)(byte)((byte)(object)left % (byte)(object)right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)(sbyte)((sbyte)(object)left % (sbyte)(object)right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T)(object)(ushort)((ushort)(object)left % (ushort)(object)right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)(short)((short)(object)left % (short)(object)right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)(object)((uint)(object)left % (uint)(object)right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)((int)(object)left % (int)(object)right);
            }

            return _Mod2(left, right);
        }

        [M(MethodImplOptions)]
        private static T _Mod2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (T)(object)((ulong)(object)left % (ulong)(object)right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)((long)(object)left % (long)(object)right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)((Half)(object)left % (Half)(object)right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)((float)(object)left % (float)(object)right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)((double)(object)left % (double)(object)right);
            }

            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Subtract<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)(byte)((byte)(object)left - (byte)(object)right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)(sbyte)((sbyte)(object)left - (sbyte)(object)right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T)(object)(ushort)((ushort)(object)left - (ushort)(object)right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)(short)((short)(object)left - (short)(object)right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)(object)((uint)(object)left - (uint)(object)right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)((int)(object)left - (int)(object)right);
            }

            return _Subtract2(left, right);
        }

        [M(MethodImplOptions)]
        private static T _Subtract2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (T)(object)((ulong)(object)left - (ulong)(object)right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)((long)(object)left - (long)(object)right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)((Half)(object)left - (Half)(object)right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)((float)(object)left - (float)(object)right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)((double)(object)left - (double)(object)right);
            }

            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Multiply<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)(byte)((byte)(object)left * (byte)(object)right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)(sbyte)((sbyte)(object)left * (sbyte)(object)right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T)(object)(ushort)((ushort)(object)left * (ushort)(object)right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)(short)((short)(object)left * (short)(object)right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)(object)((uint)(object)left * (uint)(object)right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)((int)(object)left * (int)(object)right);
            }

            return _Multiply2(left, right);
        }

        [M(MethodImplOptions)]
        private static T _Multiply2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (T)(object)((ulong)(object)left * (ulong)(object)right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)((long)(object)left * (long)(object)right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)((Half)(object)left * (Half)(object)right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)((float)(object)left * (float)(object)right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)((double)(object)left * (double)(object)right);
            }

            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Divide<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)(byte)((byte)(object)left / (byte)(object)right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)(sbyte)((sbyte)(object)left / (sbyte)(object)right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T)(object)(ushort)((ushort)(object)left / (ushort)(object)right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)(short)((short)(object)left / (short)(object)right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)(object)((uint)(object)left / (uint)(object)right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)((int)(object)left / (int)(object)right);
            }

            return _Divide2(left, right);
        }

        [M(MethodImplOptions)]
        private static T _Divide2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (T)(object)((ulong)(object)left / (ulong)(object)right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)((long)(object)left / (long)(object)right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)((Half)(object)left / (Half)(object)right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)((float)(object)left / (float)(object)right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)((double)(object)left / (double)(object)right);
            }

            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Min<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)Math.Min((byte)(object)left, (byte)(object)right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)Math.Min((sbyte)(object)left, (sbyte)(object)right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T)(object)Math.Min((ushort)(object)left, (ushort)(object)right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)Math.Min((short)(object)left, (short)(object)right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)(object)Math.Min((uint)(object)left, (uint)(object)right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)Math.Min((int)(object)left, (int)(object)right);
            }

            return _Min2(left, right);
        }

        [M(MethodImplOptions)]
        private static T _Min2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (T)(object)Math.Min((ulong)(object)left, (ulong)(object)right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)Math.Min((long)(object)left, (long)(object)right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)Math.Min((Half)(object)left, (Half)(object)right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)Math.Min((float)(object)left, (float)(object)right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Min((double)(object)left, (double)(object)right);
            }

            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Max<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)Math.Max((byte)(object)left, (byte)(object)right);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)Math.Max((sbyte)(object)left, (sbyte)(object)right);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T)(object)Math.Max((ushort)(object)left, (ushort)(object)right);
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)Math.Max((short)(object)left, (short)(object)right);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)(object)Math.Max((uint)(object)left, (uint)(object)right);
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)Math.Max((int)(object)left, (int)(object)right);
            }

            return _Max2(left, right);
        }

        [M(MethodImplOptions)]
        private static T _Max2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (T)(object)Math.Max((ulong)(object)left, (ulong)(object)right);
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)Math.Max((long)(object)left, (long)(object)right);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)Math.Max((Half)(object)left, (Half)(object)right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)Math.Max((float)(object)left, (float)(object)right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Max((double)(object)left, (double)(object)right);
            }

            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static bool Larger<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (byte)(object)left > (byte)(object)right;
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (sbyte)(object)left > (sbyte)(object)right;
            }

            if (typeof(T) == typeof(ushort))
            {
                return (ushort)(object)left > (ushort)(object)right;
            }

            if (typeof(T) == typeof(short))
            {
                return (short)(object)left > (short)(object)right;
            }

            if (typeof(T) == typeof(uint))
            {
                return (uint)(object)left > (uint)(object)right;
            }

            if (typeof(T) == typeof(int))
            {
                return (int)(object)left > (int)(object)right;
            }

            return _Larger2(left, right);
        }

        [M(MethodImplOptions)]
        private static bool _Larger2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (ulong)(object)left > (ulong)(object)right;
            }

            if (typeof(T) == typeof(long))
            {
                return (long)(object)left > (long)(object)right;
            }

            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left > (Half)(object)right;
            }

            if (typeof(T) == typeof(float))
            {
                return (float)(object)left > (float)(object)right;
            }

            if (typeof(T) == typeof(double))
            {
                return (double)(object)left > (double)(object)right;
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static bool Smaller<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (byte)(object)left < (byte)(object)right;
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (sbyte)(object)left < (sbyte)(object)right;
            }

            if (typeof(T) == typeof(ushort))
            {
                return (ushort)(object)left < (ushort)(object)right;
            }

            if (typeof(T) == typeof(short))
            {
                return (short)(object)left < (short)(object)right;
            }

            if (typeof(T) == typeof(uint))
            {
                return (uint)(object)left < (uint)(object)right;
            }

            if (typeof(T) == typeof(int))
            {
                return (int)(object)left < (int)(object)right;
            }

            return _Smaller2(left, right);
        }

        [M(MethodImplOptions)]
        private static bool _Smaller2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (ulong)(object)left < (ulong)(object)right;
            }

            if (typeof(T) == typeof(long))
            {
                return (long)(object)left < (long)(object)right;
            }

            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left < (Half)(object)right;
            }

            if (typeof(T) == typeof(float))
            {
                return (float)(object)left < (float)(object)right;
            }

            if (typeof(T) == typeof(double))
            {
                return (double)(object)left < (double)(object)right;
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static bool LargerEquals<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (byte)(object)left >= (byte)(object)right;
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (sbyte)(object)left >= (sbyte)(object)right;
            }

            if (typeof(T) == typeof(ushort))
            {
                return (ushort)(object)left >= (ushort)(object)right;
            }

            if (typeof(T) == typeof(short))
            {
                return (short)(object)left >= (short)(object)right;
            }

            if (typeof(T) == typeof(uint))
            {
                return (uint)(object)left >= (uint)(object)right;
            }

            if (typeof(T) == typeof(int))
            {
                return (int)(object)left >= (int)(object)right;
            }

            return _LargerEquals2(left, right);
        }

        [M(MethodImplOptions)]
        private static bool _LargerEquals2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (ulong)(object)left >= (ulong)(object)right;
            }

            if (typeof(T) == typeof(long))
            {
                return (long)(object)left >= (long)(object)right;
            }

            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left >= (Half)(object)right;
            }

            if (typeof(T) == typeof(float))
            {
                return (float)(object)left >= (float)(object)right;
            }

            if (typeof(T) == typeof(double))
            {
                return (double)(object)left >= (double)(object)right;
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static bool SmallerEquals<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (byte)(object)left <= (byte)(object)right;
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (sbyte)(object)left <= (sbyte)(object)right;
            }

            if (typeof(T) == typeof(ushort))
            {
                return (ushort)(object)left <= (ushort)(object)right;
            }

            if (typeof(T) == typeof(short))
            {
                return (short)(object)left <= (short)(object)right;
            }

            if (typeof(T) == typeof(uint))
            {
                return (uint)(object)left <= (uint)(object)right;
            }

            if (typeof(T) == typeof(int))
            {
                return (int)(object)left <= (int)(object)right;
            }

            return _SmallerEquals2(left, right);
        }

        [M(MethodImplOptions)]
        private static bool _SmallerEquals2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (ulong)(object)left <= (ulong)(object)right;
            }

            if (typeof(T) == typeof(long))
            {
                return (long)(object)left <= (long)(object)right;
            }

            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left <= (Half)(object)right;
            }

            if (typeof(T) == typeof(float))
            {
                return (float)(object)left <= (float)(object)right;
            }

            if (typeof(T) == typeof(double))
            {
                return (double)(object)left <= (double)(object)right;
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Clamp<T>(T value, T min, T max) where T : unmanaged, IFormattable => Min(Max(value, min), max);

        [M(MethodImplOptions)]
        public static T Negate<T>(T value) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)(sbyte)-(sbyte)(object)value;
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)(short)-(short)(object)value;
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)-(int)(object)value;
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)-(long)(object)value;
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)-(Half)(object)value;
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)-(float)(object)value;
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)-(double)(object)value;
            }

            ThrowInvalidType();
            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static bool Equal<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (byte)(object)left == (byte)(object)right;
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (sbyte)(object)left == (sbyte)(object)right;
            }

            if (typeof(T) == typeof(ushort))
            {
                return (ushort)(object)left == (ushort)(object)right;
            }

            if (typeof(T) == typeof(short))
            {
                return (short)(object)left == (short)(object)right;
            }

            if (typeof(T) == typeof(uint))
            {
                return (uint)(object)left == (uint)(object)right;
            }

            if (typeof(T) == typeof(int))
            {
                return (int)(object)left == (int)(object)right;
            }

            return _Equal2(left, right);
        }

        private static bool _Equal2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (ulong)(object)left == (ulong)(object)right;
            }

            if (typeof(T) == typeof(long))
            {
                return (long)(object)left == (long)(object)right;
            }

            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left == (Half)(object)right;
            }

            if (typeof(T) == typeof(float))
            {
                return (float)(object)left == (float)(object)right;
            }

            if (typeof(T) == typeof(double))
            {
                return (double)(object)left == (double)(object)right;
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Acos<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)MathF.Acos((Half)(object)value);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)MathF.Acos((float)(object)value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Acos((double)(object)value);
            }

            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Abs<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (T)(object)(byte)MathF.Abs((byte)(object)value);
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (T)(object)(sbyte)MathF.Abs((sbyte)(object)value);
            }

            if (typeof(T) == typeof(ushort))
            {
                return (T)(object)(ushort)MathF.Abs((ushort)(object)value);
            }

            if (typeof(T) == typeof(short))
            {
                return (T)(object)(short)MathF.Abs((short)(object)value);
            }

            if (typeof(T) == typeof(uint))
            {
                return (T)(object)(uint)MathF.Abs((uint)(object)value);
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)(int)MathF.Abs((int)(object)value);
            }

            return _Abs2(value);
        }

        [M(MethodImplOptions)]
        private static T _Abs2<T>(T value) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                ThrowNotSupportedByUnderlying<T>();
            }

            if (typeof(T) == typeof(long))
            {
                return (T)(object)Math.Abs((long)(object)value);
            }

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)MathF.Abs((Half)(object)value);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)MathF.Abs((float)(object)value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Abs((double)(object)value);
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        // note that when `Cos` gets a better implementation, Sin should just become `Cos(Subtract(Tau, value));`
        [M(MethodImplOptions)]
        public static T Sin<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)MathF.Sin((Half)(object)value);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)MathF.Sin((float)(object)value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Sin((double)(object)value);
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Sinh<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)MathF.Sinh((Half)(object)value);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)MathF.Sinh((float)(object)value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Sinh((double)(object)value);
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Asin<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)MathF.Asin((Half)(object)value);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)MathF.Asin((float)(object)value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Asin((double)(object)value);
            }


            Debug.Fail("Unreachable Code");
            return default;
        }


        [M(MethodImplOptions)]
        public static T Atan<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)MathF.Atan((Half)(object)value);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)MathF.Atan((float)(object)value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Atan((double)(object)value);
            }


            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        public static T Atan2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)Math.Atan2((Half)(object)left, (Half)(object)right);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)Math.Atan2((float)(object)left, (float)(object)right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Atan2((double)(object)left, (double)(object)right);
            }

            Debug.Fail("Unreachable Code");
            return default;
        }

        [M(MethodImplOptions)]
        private static T Floor<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)(short)(Half)(object)value;
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)(float)(int)(float)(object)value;
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)(double)(long)(double)(object)value;
            }

            return value;
        }


        [M(MethodImplOptions)]
        public static T Cos<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)MathF.Cos((Half)(object)value);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)MathF.Cos((float)(object)value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Cos((double)(object)value);
            }


            Debug.Fail("Unreachable Code");
            return default;
        }


        [M(MethodImplOptions)]
        public static T Cosh<T>(T value) where T : unmanaged, IFormattable
        {
            ThrowForIntegerBaseType<T>();

            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)MathF.Cosh((Half)(object)value);
            }

            if (typeof(T) == typeof(float))
            {
                return (T)(object)MathF.Cosh((float)(object)value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Cosh((double)(object)value);
            }

            Debug.Fail("Unreachable Code");
            return default;
        }
    }
}