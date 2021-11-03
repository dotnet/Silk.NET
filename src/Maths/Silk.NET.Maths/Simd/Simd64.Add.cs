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
    public static unsafe partial class Simd64
    {
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector64<T> Add<T>(Vector64<T> left, Vector64<T> right) where T : unmanaged
        {

            return Byte(left, right);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Byte(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(byte))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Add(left.AsByte(), right.AsByte()).As<byte, T>();
                    }
#endif

                }
                
        
                return SByte(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> SByte(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(sbyte))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Add(left.AsSByte(), right.AsSByte()).As<sbyte, T>();
                    }
#endif

                }
                
        
                return UInt16(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt16(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(ushort))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Add(left.AsUInt16(), right.AsUInt16()).As<ushort, T>();
                    }
#endif

                }
                
        
                return Int16(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int16(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(short))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Add(left.AsInt16(), right.AsInt16()).As<short, T>();
                    }
#endif

                }
                
        
                return UInt32(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt32(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(uint))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Add(left.AsUInt32(), right.AsUInt32()).As<uint, T>();
                    }
#endif

                }
                
        
                return Int32(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int32(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(int))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Add(left.AsInt32(), right.AsInt32()).As<int, T>();
                    }
#endif

                }
                
        
                return UInt64(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> UInt64(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(ulong))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Add(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
                    }
#endif

                }
                
        
                return Int64(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Int64(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(long))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Add(left.AsInt64(), right.AsInt64()).As<long, T>();
                    }
#endif

                }
                
        
                return Single(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Single(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(float))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Add(left.AsSingle(), right.AsSingle()).As<float, T>();
                    }
#endif

                }
                
        
                return Double(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Double(Vector64<T> left, Vector64<T> right)
            {
                if (typeof(T) == typeof(Double))
                {

#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Add(left.AsDouble(), right.AsDouble()).As<Double, T>();
                    }
#endif

                }
                
        
                return Other(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector64<T> Other(Vector64<T> left, Vector64<T> right)
            {
            
                var vec = Vector64<T>.Zero;
                for (int i = 0; i < Vector64<T>.Count; i++)
                {
                    WithElement(vec, i, Scalar.Add(GetElement(left, i), GetElement(right, i)));
                }

                return vec;
            }

        }
    }
}
#endif
