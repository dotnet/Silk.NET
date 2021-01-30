// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

#if INTRINSICS
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
                }

                return Other(ptr);
            }
            
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(T* ptr)
            {
                return Unsafe.ReadUnaligned<Vector128<T>>(ptr);
            }
        }
        
        [MethodImpl(Scalar.MaxOpt)]
        public static void Store<T>(T* destination, Vector128<T> source) where T : unmanaged
        {
            Byte(destination, source);
            return;
            
            [MethodImpl(Scalar.MaxOpt)]
            static void Byte(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(byte))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((byte*) destination, (Vector128<byte>)(object)source);
                        return;
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((byte*) destination, (Vector128<byte>)(object)source);
                        return;
                    }
#endif
                }

                SByte(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void SByte(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((sbyte*) destination, (Vector128<sbyte>)(object)source);
                        return;
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((sbyte*) destination, (Vector128<sbyte>)(object)source);
                        return;
                    }
#endif
                }

                UShort(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void UShort(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(ushort))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((ushort*) destination, (Vector128<ushort>)(object)source);
                        return;
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((ushort*) destination, (Vector128<ushort>)(object)source);
                        return;
                    }
#endif
                }

                Short(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void Short(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(short))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((short*) destination, (Vector128<short>)(object)source);
                        return;
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((short*) destination, (Vector128<short>)(object)source);
                        return;
                    }
#endif
                }

                UInt(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void UInt(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(uint))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((uint*) destination, (Vector128<uint>)(object)source);
                        return;
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((uint*) destination, (Vector128<uint>)(object)source);
                        return;
                    }
#endif
                }

                Int(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void Int(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(int))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((int*) destination, (Vector128<int>)(object)source);
                        return;
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((int*) destination, (Vector128<int>)(object)source);
                        return;
                    }
#endif
                }

                ULong(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void ULong(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(ulong))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((ulong*) destination, (Vector128<ulong>)(object)source);
                        return;
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((ulong*) destination, (Vector128<ulong>)(object)source);
                        return;
                    }
#endif
                }

                Long(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void Long(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(long))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((long*) destination, (Vector128<long>)(object)source);
                        return;
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((long*) destination, (Vector128<long>)(object)source);
                        return;
                    }
#endif
                }

                Float(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void Float(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(float))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        Sse.Store((float*) destination, (Vector128<float>)(object)source);
                        return;
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((float*) destination, (Vector128<float>)(object)source);
                        return;
                    }
#endif
                }

                Double(destination, source);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static void Double(T* destination, Vector128<T> source)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        Sse2.Store((double*) destination, (Vector128<double>)(object)source);
                        return;
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        AdvSimd.Store((double*) destination, (Vector128<double>)(object)source);
                        return;
                    }
#endif
                }

                Other(destination, source);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static void Other(T* dest, Vector128<T> src)
            {
                Unsafe.WriteUnaligned(dest, src);
            }
        }

        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> Create<T>(T value) where T : unmanaged
        {
            return Byte(value);

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Byte(T value)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (Vector128<T>)(object)Vector128.Create((byte) (object) value);
                }

                return SByte(value);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SByte(T value)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (Vector128<T>)(object)Vector128.Create((sbyte) (object) value);
                }

                return UInt(value);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt(T value)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (Vector128<T>)(object)Vector128.Create((uint) (object) value);
                }

                return Int(value);
            }
                        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int(T value)
            {
                if (typeof(T) == typeof(int))
                {
                    return (Vector128<T>)(object)Vector128.Create((int) (object) value);
                }

                return ULong(value);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> ULong(T value)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (Vector128<T>)(object)Vector128.Create((ulong) (object) value);
                }

                return Long(value);
            }
                        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Long(T value)
            {
                if (typeof(T) == typeof(long))
                {
                    return (Vector128<T>)(object)Vector128.Create((long) (object) value);
                }

                return Float(value);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Float(T value)
            {
                if (typeof(T) == typeof(float))
                {
                    return (Vector128<T>)(object)Vector128.Create((float) (object) value);
                }

                return Double(value);
            }
                        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(T value)
            {
                if (typeof(T) == typeof(double))
                {
                    return (Vector128<T>)(object)Vector128.Create((double) (object) value);
                }

                return Other(value);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(T value)
            {
                Scalar.ThrowUnsupportedType();
                return default; // unreachable
            }
        }
    }
}
#endif