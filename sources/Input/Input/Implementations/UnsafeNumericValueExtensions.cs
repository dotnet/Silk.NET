// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

/// <summary>
/// Some unsafe methods for comparing numeric values of simple numeric types.
/// </summary>
/// <remarks>
/// WARNING: If your values come from uninitialized memory, these extension methods may return incorrect results.
/// </remarks>
[Experimental(diagnosticId: "ST0006", UrlFormat = "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/diagnostics/{0}")]
public static class UnsafeNumericValueExtensions
{
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    extension<T>(T value) where T : unmanaged
    {
        /// <summary>
        /// Reinterprets the raw bytes of <typeparamref name="T"/> as <typeparamref name="TTo"/>.
        /// </summary>
        /// <returns>
        /// A value whose low-order bytes come from the source value's in-memory representation, reinterpreted as
        /// <typeparamref name="TTo"/>.
        /// </returns>
        /// <remarks>
        /// This method performs a raw byte reinterpretation/copy, not a cast.
        /// As a result, <b>numeric equivalence is not guaranteed.</b><br/>
        /// <br/>
        /// Non-equivalent return values are caused by:<br/>
        /// 1. Truncation when <typeparamref name="TTo"/> is smaller than <typeparamref name="T"/>.<br/>
        /// 2. Sign changes when source and destination signedness differ.<br/>
        /// <br/>
        /// Widening initializes extra destination bytes to zero (zero-extension), which can change the numeric meaning
        /// for signed source values.
        /// </remarks>
        /// <throws> <see cref="ArgumentException"/>if the types are based on floating-point values</throws>
        [Experimental(diagnosticId: "ST0009",
            UrlFormat = "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/diagnostics/{0}")]
        public unsafe TTo ConvertBitwiseUnsafe<TTo>() where TTo : unmanaged
        {
#if DEBUG
            if (typeof(T) == typeof(float) || typeof(T) == typeof(double) ||
                typeof(TTo) == typeof(float) || typeof(TTo) == typeof(double))
            {
                throw new ArgumentException("Floating-point types are not supported");
            }
#endif

            if (sizeof(T) == sizeof(TTo))
            {
                return Unsafe.ReadUnaligned<TTo>(&value);
            }

            if (BitConverter.IsLittleEndian && sizeof(TTo) < sizeof(T))
            {
                return Unsafe.ReadUnaligned<TTo>(&value);
            }

            var src = (byte*)&value;
            Unsafe.SkipInit(out TTo result);
            var dst = (byte*)Unsafe.AsPointer(ref result);

            var minSize = Math.Min(sizeof(TTo), sizeof(T));
            if (!BitConverter.IsLittleEndian)
            {
                // big-endian keeps low-order bytes at the end
                src += sizeof(T) - minSize;
                dst += sizeof(TTo) - minSize;
            }

            var sizeDelta = sizeof(TTo) - sizeof(T);
            if (sizeDelta > 0)
            {
                var zeroStartPtr = dst;
                if (BitConverter.IsLittleEndian) // JIT turns this into a constant, removing this as a branch
                {
                    // only zero "tail" bytes that were widened
                    zeroStartPtr += sizeof(T);
                }

                Unsafe.InitBlockUnaligned(startAddress: zeroStartPtr, value: 0, (uint)sizeDelta);
            }

            Unsafe.CopyBlockUnaligned(destination: dst, source: src, byteCount: (uint)minSize);

            return result;
        }

        /// <summary>
        /// Compares two values of the same type for equality.
        /// </summary>
        /// <remarks>
        /// This will only be faster than <see cref="EqualsUnsafe"/> if you are providing a large struct.
        /// This method does not require hardware support for vectorization, and thus will likely be slower
        /// than vectorized methods for large types.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool EqualsUnsafe(in T other)
        {
            var left = (byte*)&value;
            var right = (byte*)Unsafe.AsPointer(in other);
            var length = sizeof(T);
            var index = 0;
            ulong diff = 0;

            var maxSimdIndex = length & ~(sizeof(ulong) - 1); // equivalent to length - (length % sizeof(ulong))
            for (; index < maxSimdIndex; index += sizeof(ulong))
            {
                diff |= Unsafe.ReadUnaligned<ulong>(left + index) ^ Unsafe.ReadUnaligned<ulong>(right + index);
            }

            // remaining bytes
            for (; index < length; ++index)
            {
                diff |= (byte)(left[index] ^ right[index]);
            }

            return diff == 0;
        }
    }

    extension<T>(T value) where T : unmanaged, IUnsignedNumber<T>, IBinaryInteger<T>
    {
        /// <inheritdoc cref="UnsafeNumericValueExtensions.ConvertBitwiseUnsafe{T,TTo}"/>
        private TTo ConvertUnsafeUnsigned<TTo>() where TTo : unmanaged, IUnsignedNumber<TTo> =>
            value.ConvertBitwiseUnsafe<T, TTo>();
    }

    extension<T>(T value) where T : unmanaged, ISignedNumber<T>, IBinaryInteger<T>
    {
        /// <inheritdoc cref="UnsafeNumericValueExtensions.ConvertBitwiseUnsafe{T,TTo}"/>
        private TTo ConvertUnsafeSigned<TTo>() where TTo : unmanaged, ISignedNumber<TTo> =>
            value.ConvertBitwiseUnsafe<T, TTo>();
    }
}
