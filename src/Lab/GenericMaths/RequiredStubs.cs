// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

#if NETSTANDARD2_0
using MathF = System.Math;
#endif
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using M = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Silk.NET.Maths
{
    internal static class Scalar
    {
        private const MethodImplOptions MIP = MethodImplOptions.AggressiveInlining | (MethodImplOptions) 0x0200;

        internal static void ThrowInvalidType()
            => throw new NotSupportedException("This operation isn't supported for the current type.");

        [M(MIP)]
        internal static void ThrowForUnsupportedBaseType<T>() where T : unmanaged, IFormattable
        {
            if (typeof(T) != typeof(byte) && typeof(T) != typeof(sbyte) && typeof(T) != typeof(ushort) &&
                typeof(T) != typeof(short) && typeof(T) != typeof(uint) && typeof(T) != typeof(int) &&
                typeof(T) != typeof(ulong) && typeof(T) != typeof(long) && 
#if HALF
                typeof(T) != typeof(Half) &&
#endif
                typeof(T) != typeof(float) && typeof(T) != typeof(double))
            {
                ThrowInvalidType();
            }
        }
        
        [M(MIP)]
        internal static void ThrowForNonFloatingPointType<T>() where T : unmanaged, IFormattable
        {
            if (
#if HALF
                typeof(T) != typeof(Half) &&
#endif                
            typeof(T) != typeof(float) && typeof(T) != typeof(double))
            {
                ThrowInvalidType();
            }
        }

        [M(MIP)]
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)((float)(Half)(object)left + (float)(Half)(object)right);
            }
#endif
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
        
        [M(MIP)]
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)((float)(Half)(object)left % (float)(Half)(object)right);
            }
#endif
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

        [M(MIP)]
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)((float)(Half)(object)left - (float)(Half)(object)right);
            }
#endif
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

        [M(MIP)]
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)((float)(Half)(object)left * (float)(Half)(object)right);
            }
#endif
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

        [M(MIP)]
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)((float)(Half)(object)left / (float)(Half)(object)right);
            }
#endif
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
        
        [M(MIP)]
        public static T Atan2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForNonFloatingPointType<T>();
#if HALF
            if (typeof(T) == typeof(Half)) 
            {
                return (T)(object)MathF.Atan2((float)(Half)(object)left, (float)(Half)(object)right); 
            }
#endif
            if (typeof(T) == typeof(float))
            {
                return (T) (object) MathF.Atan2((float) (object) left, (float) (object) right);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)Math.Atan2((double)(object)left, (double)(object)right); 
            }

            Debug.Fail("Unreachable Code");
            return default;
        }
        
        [M(MIP)]
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left > (Half)(object)right;
            }
#endif
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

        [M(MIP)]
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left < (Half)(object)right;
            }
#endif
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

        [M(MIP)]
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left >= (Half)(object)right;
            }
#endif
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

        [M(MIP)]
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left <= (Half)(object)right;
            }
#endif
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (T)(object)(Half)(-(float)(Half)(object)value);
            }
#endif
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

        [M(MIP)]
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

        [M(MIP)]
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
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left == (Half)(object)right;
            }
#endif
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
        
        [M(MIP)]
        public static bool NotEqual<T>(T left, T right) where T : unmanaged, IFormattable
        {
            ThrowForUnsupportedBaseType<T>();
            if (typeof(T) == typeof(byte))
            {
                return (byte)(object)left != (byte)(object)right;
            }

            if (typeof(T) == typeof(sbyte))
            {
                return (sbyte)(object)left != (sbyte)(object)right;
            }

            if (typeof(T) == typeof(ushort))
            {
                return (ushort)(object)left != (ushort)(object)right;
            }

            if (typeof(T) == typeof(short))
            {
                return (short)(object)left != (short)(object)right;
            }

            if (typeof(T) == typeof(uint))
            {
                return (uint)(object)left != (uint)(object)right;
            }

            if (typeof(T) == typeof(int))
            {
                return (int)(object)left != (int)(object)right;
            }

            return _NotEqual2(left, right);
        }

        [M(MIP)]
        private static bool _NotEqual2<T>(T left, T right) where T : unmanaged, IFormattable
        {
            if (typeof(T) == typeof(ulong))
            {
                return (ulong)(object)left != (ulong)(object)right;
            }

            if (typeof(T) == typeof(long))
            {
                return (long)(object)left != (long)(object)right;
            }
#if HALF
            if (typeof(T) == typeof(Half))
            {
                return (Half)(object)left != (Half)(object)right;
            }
#endif
            if (typeof(T) == typeof(float))
            {
                return (float)(object)left != (float)(object)right;
            }

            if (typeof(T) == typeof(double))
            {
                return (double)(object)left != (double)(object)right;
            }


            Debug.Fail("Unreachable Code");
            return default;
        }
    }
}