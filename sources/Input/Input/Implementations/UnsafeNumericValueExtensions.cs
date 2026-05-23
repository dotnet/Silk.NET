// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

/// <summary>
/// Some unsafe methods for comparing numeric values of simple numeric types.
/// </summary>
[Experimental(diagnosticId: "ST0006", UrlFormat = "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/diagnostics/{0}")]
public static class UnsafeNumericValueExtensions
{
    /// <param name="value"></param>
    /// <typeparam name="T"></typeparam>
    extension<T>(T value) where T : unmanaged
    {
        /// <summary>
        /// Compares two values of the same type for equality.
        /// Type must be no larger than 8 bytes.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        [Experimental(diagnosticId: "ST0007", UrlFormat = "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/diagnostics/{0}")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(T other) => value.Convert<T, ulong>() == other.Convert<T, ulong>();

        /// <summary>
        /// Compares two values of differing types for numeric equality
        /// Types must be no larger than 8 bytes.
        /// </summary>
        /// <param name="right"></param>
        /// <typeparam name="T2"></typeparam>
        /// <returns></returns>
        [Experimental(diagnosticId: "ST0008", UrlFormat = "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/diagnostics/{0}")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals<T2>(T2 right) where T2 : unmanaged => value.Convert<T, ulong>() == right.Convert<T2, ulong>();

        /// <summary>
        /// Returns the numerical value of the enum value provided in a type-safe way
        /// </summary>
        /// <typeparam name="TTo"></typeparam>
        /// <returns></returns>
        [Experimental(diagnosticId: "ST0009", UrlFormat = "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/diagnostics/{0}")]
        internal unsafe TTo Convert<TTo>() where TTo : unmanaged
        {
            if (sizeof(T) == sizeof(TTo))
            {
                return Unsafe.Read<TTo>(&value);
            }

            var minSize = Math.Min(sizeof(TTo), sizeof(T));
            // var maxSize = Math.Max(sizeof(TTo), sizeof(T));

            var originalValuePtr = (byte*)&value;

            // var sizeDelta = maxSize - minSize;
            var valuePtr = &originalValuePtr[0]; // todo: does this assume little-endianness?
            var resultPtr = stackalloc byte[sizeof(TTo)];

            // ensure block is initialized (as it isnt guaranteed?) so any missing bytes of the output will stay 0
            // if type TNumber is a larger size than type T
            Unsafe.InitBlock(resultPtr, 0, (uint)sizeof(TTo));

            var copyToPtr = &resultPtr[0];
            Buffer.MemoryCopy(valuePtr, copyToPtr, sizeof(TTo), minSize);
            return *(TTo*)resultPtr;
        }
    }
}
