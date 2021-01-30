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
    public static unsafe class Simd128
    {
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> Load<T>(T* ptr) where T : unmanaged
        {
            return Byte(ptr);
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Byte(T* ptr)
            {
                if (typeof(T) == typeof(byte))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((byte*) ptr);
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((byte*) ptr);
                    }
#endif

                    var bPtr = (byte*) ptr;
                    return (Vector128<T>)(object)Vector128.Create(bPtr[0], bPtr[1], bPtr[2], bPtr[3], bPtr[4], bPtr[5], bPtr[6], bPtr[7], bPtr[8], bPtr[9], bPtr[10], bPtr[11], bPtr[12], bPtr[13], bPtr[14], bPtr[15]);
                }

                return SByte(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SByte(T* ptr)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((sbyte*) ptr);
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((sbyte*) ptr);
                    }
#endif

                    var bPtr = (sbyte*) ptr;
                    return (Vector128<T>)(object)Vector128.Create(bPtr[0], bPtr[1], bPtr[2], bPtr[3], bPtr[4], bPtr[5], bPtr[6], bPtr[7], bPtr[8], bPtr[9], bPtr[10], bPtr[11], bPtr[12], bPtr[13], bPtr[14], bPtr[15]);
                }

                return UShort(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UShort(T* ptr)
            {
                if (typeof(T) == typeof(ushort))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((ushort*) ptr);
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((ushort*) ptr);
                    }
#endif

                    var bPtr = (ushort*) ptr;
                    return (Vector128<T>)(object)Vector128.Create(bPtr[0], bPtr[1], bPtr[2], bPtr[3], bPtr[4], bPtr[5], bPtr[6], bPtr[7]);
                }

                return Short(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Short(T* ptr)
            {
                if (typeof(T) == typeof(short))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((short*) ptr);
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((short*) ptr);
                    }
#endif

                    var bPtr = (short*) ptr;
                    return (Vector128<T>)(object)Vector128.Create(bPtr[0], bPtr[1], bPtr[2], bPtr[3], bPtr[4], bPtr[5], bPtr[6], bPtr[7]);
                }

                return UInt(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt(T* ptr)
            {
                if (typeof(T) == typeof(uint))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((uint*) ptr);
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((uint*) ptr);
                    }
#endif

                    var bPtr = (uint*) ptr;
                    return (Vector128<T>)(object)Vector128.Create(bPtr[0], bPtr[1], bPtr[2], bPtr[3]);
                }

                return Int(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int(T* ptr)
            {
                if (typeof(T) == typeof(int))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((int*) ptr);
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((int*) ptr);
                    }
#endif

                    var bPtr = (int*) ptr;
                    return (Vector128<T>)(object)Vector128.Create(bPtr[0], bPtr[1], bPtr[2], bPtr[3]);
                }

                return ULong(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> ULong(T* ptr)
            {
                if (typeof(T) == typeof(ulong))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((ulong*) ptr);
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((ulong*) ptr);
                    }
#endif

                    var bPtr = (ulong*) ptr;
                    return (Vector128<T>)(object)Vector128.Create(bPtr[0], bPtr[1]);
                }

                return Long(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Long(T* ptr)
            {
                if (typeof(T) == typeof(long))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((long*) ptr);
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((long*) ptr);
                    }
#endif

                    var bPtr = (long*) ptr;
                    return (Vector128<T>)(object)Vector128.Create(bPtr[0], bPtr[1]);
                }

                return Float(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Float(T* ptr)
            {
                if (typeof(T) == typeof(float))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse.LoadVector128((float*) ptr);
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((float*) ptr);
                    }
#endif

                    var bPtr = (float*) ptr;
                    return (Vector128<T>)(object)Vector128.Create(bPtr[0], bPtr[1], bPtr[2], bPtr[3]);
                }

                return Double(ptr);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(T* ptr)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return (Vector128<T>) (object) Sse2.LoadVector128((double*) ptr);
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return (Vector128<T>) (object) AdvSimd.LoadVector128((double*) ptr);
                    }
#endif

                    var bPtr = (double*) ptr;
                    return (Vector128<T>)(object)Vector128.Create(bPtr[0], bPtr[1]);
                }

                return Float(ptr);
            }
        }
    }
}
#endif