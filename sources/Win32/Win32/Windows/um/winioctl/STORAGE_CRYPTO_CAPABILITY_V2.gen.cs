// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_CRYPTO_CAPABILITY_V2
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint CryptoCapabilityIndex;
    public STORAGE_CRYPTO_ALGORITHM_ID AlgorithmId;
    public STORAGE_CRYPTO_KEY_SIZE KeySize;

    [NativeTypeName("DWORD")]
    public uint DataUnitSizeBitmask;

    [NativeTypeName("WORD")]
    public ushort MaxIVBitSize;

    [NativeTypeName("WORD")]
    public ushort Reserved;

    [NativeTypeName("__AnonymousRecord_winioctl_L1976_C5")]
    public _SecurityComplianceBitmask_e__Union SecurityComplianceBitmask;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _SecurityComplianceBitmask_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L1977_C9")]
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
}
