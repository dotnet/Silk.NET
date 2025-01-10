// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_CRYPTO_DESCRIPTOR_V2
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint NumKeysSupported;

    [NativeTypeName("DWORD")]
    public uint NumCryptoCapabilities;
    public STORAGE_ICE_TYPE IceType;

    [NativeTypeName("__AnonymousRecord_winioctl_L2074_C5")]
    public _SecurityComplianceBitmask_e__Union SecurityComplianceBitmask;

    [NativeTypeName("STORAGE_CRYPTO_CAPABILITY_V2[1]")]
    public _CryptoCapabilities_e__FixedBuffer CryptoCapabilities;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _SecurityComplianceBitmask_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L2075_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        public byte AsUchar;
        public byte FIPS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.FIPS; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.FIPS = value; }
        }
        public byte Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.Reserved; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.Reserved = value; }
        }

        public partial struct _Anonymous_e__Struct
        {
            public byte _bitfield;

            [NativeTypeName("byte : 1")]
            public byte FIPS
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)(_bitfield & 0x1u); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u)); }
            }

            [NativeTypeName("byte : 7")]
            public byte Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (byte)((_bitfield >> 1) & 0x7Fu); }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (byte)((_bitfield & ~(0x7Fu << 1)) | ((value & 0x7Fu) << 1)); }
            }
        }
    }

    public partial struct _CryptoCapabilities_e__FixedBuffer
    {
        public STORAGE_CRYPTO_CAPABILITY_V2 e0;

        [UnscopedRef]
        public ref STORAGE_CRYPTO_CAPABILITY_V2 this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_CRYPTO_CAPABILITY_V2> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
