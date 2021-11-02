// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsByte(), right.AsByte()).As<byte, T>();
                    }
#endif

                }
                
        
                return SByte(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> SByte(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(sbyte))
                {

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsSByte(), right.AsSByte()).As<sbyte, T>();
                    }
#endif

                }
                
        
                return UInt16(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt16(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(ushort))
                {

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsUInt16(), right.AsUInt16()).As<ushort, T>();
                    }
#endif

                }
                
        
                return Int16(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int16(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(short))
                {

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsInt16(), right.AsInt16()).As<short, T>();
                    }
#endif

                }
                
        
                return UInt32(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt32(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(uint))
                {

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsUInt32(), right.AsUInt32()).As<uint, T>();
                    }
#endif

                }
                
        
                return Int32(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int32(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(int))
                {

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsInt32(), right.AsInt32()).As<int, T>();
                    }
#endif

                }
                
        
                return UInt64(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> UInt64(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(ulong))
                {

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
                    }
#endif

                }
                
        
                return Int64(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Int64(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(long))
                {

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsInt64(), right.AsInt64()).As<long, T>();
                    }
#endif

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

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsDouble(), right.AsDouble()).As<Double, T>();
                    }
#endif

                }
                
        
                return Other(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Other(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof())
                {

#if AVX
                    if (Avx2.IsSupported)
                    {
                        return Avx2.Subtract(left.AsOther(), right.AsOther()).As<, T>();
                    }
#endif

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
