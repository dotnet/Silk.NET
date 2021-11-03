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
    public static unsafe partial class Simd128
    {
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> Create<T>(T value) where T : unmanaged
        {
            return Byte(value);

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Byte(T value)
            {
                if (typeof(T) == typeof(byte))
                {
                    return (Vector128<T>) (object) Vector128.Create((byte) (object) value);
                }

                return SByte(value);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SByte(T value)
            {
                if (typeof(T) == typeof(sbyte))
                {
                    return (Vector128<T>) (object) Vector128.Create((sbyte) (object) value);
                }

                return UInt(value);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> UInt(T value)
            {
                if (typeof(T) == typeof(uint))
                {
                    return (Vector128<T>) (object) Vector128.Create((uint) (object) value);
                }

                return Int(value);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int(T value)
            {
                if (typeof(T) == typeof(int))
                {
                    return (Vector128<T>) (object) Vector128.Create((int) (object) value);
                }

                return ULong(value);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> ULong(T value)
            {
                if (typeof(T) == typeof(ulong))
                {
                    return (Vector128<T>) (object) Vector128.Create((ulong) (object) value);
                }

                return Long(value);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Long(T value)
            {
                if (typeof(T) == typeof(long))
                {
                    return (Vector128<T>) (object) Vector128.Create((long) (object) value);
                }

                return Float(value);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Float(T value)
            {
                if (typeof(T) == typeof(float))
                {
                    return (Vector128<T>) (object) Vector128.Create((float) (object) value);
                }

                return Double(value);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(T value)
            {
                if (typeof(T) == typeof(double))
                {
                    return (Vector128<T>) (object) Vector128.Create((double) (object) value);
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

        // these two should ONLY be used in the constant-sized unrolled loops.
        // unfortunately there is an issue otherwise. See https://sharplab.io/#v2:EYLgxg9gTgpgtADwGwBYA0AXEBDAzgWwB8ABAJgEYBYAKGIAYACY8gOgCUBXAOwwEt8YLAJI8ovLrl5hcAbho1iAZiakGAYRoBvGg11MUDACoxcGABQBKHXu3U99hgDNoDM+IwNeDALwM6MzwYAHgYANRgwDGhyUgAOIMcAGwhsDAA+FjUIbgwA3gBqfKs7B1KAOQgAeQAHNws5Et0AX2tdVv0GCpq3Hk9i+1tS3V5HVzMOdwtAtN8AegAqccn52fDI6LiE5NSMrJyp2dnguDgGbkh8AV6wPAx2oaZyAE5LBvsW6iagA
        [MethodImpl(Scalar.MaxOpt)]
        private static Vector128<T> WithElement<T>(Vector128<T> vector, int index, T value) where T : unmanaged
        {
            Vector128<T> result = vector;
            ref T e0 = ref Unsafe.As<Vector128<T>, T>(ref result);
            Unsafe.Add(ref e0, index) = value;
            return result;
        }

        [MethodImpl(Scalar.MaxOpt)]
        private static T GetElement<T>(Vector128<T> vector, int index) where T : unmanaged
        {
            ref T e0 = ref Unsafe.As<Vector128<T>, T>(ref vector);
            return Unsafe.Add(ref e0, index);
        }

        [MethodImpl(Scalar.MaxOpt)]
        public static Vector128<T> Abs<T>(Vector128<T> vector) where T : unmanaged
        {
            return Start(vector);

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Start(Vector128<T> vector)
            {
                if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
                    return vector;

                return SByte(vector);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> SByte(Vector128<T> vector)
            {
                if (typeof(T) == typeof(sbyte))
                {
#if SSE
                    if (Ssse3.IsSupported)
                    {
                        return Ssse3.Abs(vector.AsSByte()).As<byte, T>();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Abs(vector.AsSByte()).As<byte, T>();
                    }
#endif
                }

                return Short(vector);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Short(Vector128<T> vector)
            {
                if (typeof(T) == typeof(short))
                {
#if SSE
                    if (Ssse3.IsSupported)
                    {
                        return Ssse3.Abs(vector.AsInt16()).As<ushort, T>();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Abs(vector.AsInt16()).As<ushort, T>();
                    }
#endif
                }

                return Int(vector);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Int(Vector128<T> vector)
            {
                if (typeof(T) == typeof(int))
                {
#if SSE
                    if (Ssse3.IsSupported)
                    {
                        return Ssse3.Abs(vector.AsInt32()).As<uint, T>();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.Abs(vector.AsInt32()).As<uint, T>();
                    }
#endif
                }

                return Long(vector);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Long(Vector128<T> vector)
            {
                if (typeof(T) == typeof(long))
                {
                    // no intrinsic available
                }

                return Float(vector);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Float(Vector128<T> vector)
            {
                if (typeof(T) == typeof(float))
                {
#if SSE
                    if (Sse.IsSupported)
                    {
                        return Sse.And(vector.AsSingle(), Vector128.Create((uint) 0x7FFF_FFFF).AsSingle()).As<float, T>();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.And(vector.AsSingle(), Vector128.Create((uint) 0x7FFF_FFFF).AsSingle()).As<float, T>();
                    }
#endif
                }

                return Double(vector);
            }

            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Double(Vector128<T> vector)
            {
                if (typeof(T) == typeof(double))
                {
#if SSE
                    if (Sse2.IsSupported)
                    {
                        return Sse2.And(vector.AsDouble(), Vector128.Create((ulong) 0x7FFF_FFFF_FFFF_FFF).AsDouble()).As<double, T>();
                    }
#endif
#if AdvSIMD
                    if (AdvSimd.IsSupported)
                    {
                        return AdvSimd.And(vector.AsDouble(), Vector128.Create((ulong) 0x7FFF_FFFF_FFFF_FFF).AsDouble()).As<double, T>();
                    }
#endif
                }

                return Other(vector);
            }


            [MethodImpl(Scalar.MaxOpt)]
            static Vector128<T> Other(Vector128<T> vector)
            {
                for (int i = 0; i < Vector128<T>.Count; i++)
                    vector = WithElement(vector, i, Scalar.Abs(GetElement(vector, i)));
                return vector;
            }
        }
    }
}
#endif
