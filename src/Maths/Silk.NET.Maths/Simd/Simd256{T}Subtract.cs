
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
    public static unsafe partial class Simd256
    {
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> Subtract<T>(Vector256<T> left, Vector256<T> right) where T : unmanaged
        {
            return Byte(left, right);

            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Byte(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(byte))
                {

                }
                return SByte(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> SByte(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(sbyte))
                {

                }
                return UInt16(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt16(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(ushort))
                {

                }
                return Int16(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int16(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(short))
                {

                }
                return UInt32(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt32(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(uint))
                {

                }
                return Int32(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int32(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(int))
                {

                }
                return UInt64(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt64(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(ulong))
                {

                }
                return Int64(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int64(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(long))
                {

                }
                return Single(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Single(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(float))
                {

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsSingle(), right.AsSingle()).As<float, T>();
                    }
#endif

                }
                return Double(left, right);
            }
        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Double(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(Double))
                {

                }
                return Other(left, right);
            }
        
    
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Other(Vector256<T> left, Vector256<T> right)
            {
                var vec = Vector256<T>.Zero;
                for (int i = 0; i < Vector256<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Subtract(GetElement(left, i), GetElement(right, i)));
                }

                return vec;
            }

        }
    }
}
