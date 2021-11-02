
// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
#if INTRINSICS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
#if SSE
using System.Runtime.Intrinsics.X86;
#endif
#if AdvSIMD
using System.Runtime.Intrinsics.Arm;
#endif

namespace Silk.NET.Maths
{
    public static unsafe partial class Simd64
    {
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> Divide<T>(Vector64<T> left, Vector64<T> right) where T : unmanaged
        {
            return Byte(left, right);

            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Byte(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(byte))
                {

                }
                return SByte(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> SByte(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(sbyte))
                {

                }
                return UInt16(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt16(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(ushort))
                {

                }
                return Int16(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int16(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(short))
                {

                }
                return UInt32(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt32(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(uint))
                {

                }
                return Int32(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int32(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(int))
                {

                }
                return UInt64(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt64(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(ulong))
                {

                }
                return Int64(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int64(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(long))
                {

                }
                return Single(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Single(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(float))
                {

                }
                return Double(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Double(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(Double))
                {

                }
                return Other(left, right);
            }
        
    
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> left, Vector64<T> right)
            {
                var vec = Vector64<T>.Zero;
                for (int i = 0; i < Vector64<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Divide(GetElement(left, i), GetElement(right, i)));
                }

                return vec;
            }

        }
    }
}
