// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_CRYPTO_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint NumKeysSupported;

    [NativeTypeName("DWORD")]
    public uint NumCryptoCapabilities;

    [NativeTypeName("STORAGE_CRYPTO_CAPABILITY[1]")]
    public _CryptoCapabilities_e__FixedBuffer CryptoCapabilities;

    public partial struct _CryptoCapabilities_e__FixedBuffer
    {
        public STORAGE_CRYPTO_CAPABILITY e0;

        [UnscopedRef]
        public ref STORAGE_CRYPTO_CAPABILITY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_CRYPTO_CAPABILITY> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
