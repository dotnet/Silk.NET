// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct DEVICE_LB_PROVISIONING_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;
    public byte _bitfield;

    [NativeTypeName("byte : 1")]
    public byte ThinProvisioningEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)(_bitfield & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u)); }
    }

    [NativeTypeName("byte : 1")]
    public byte ThinProvisioningReadZeros
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 1) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1)); }
    }

    [NativeTypeName("byte : 3")]
    public byte AnchorSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 2) & 0x7u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x7u << 2)) | ((value & 0x7u) << 2)); }
    }

    [NativeTypeName("byte : 1")]
    public byte UnmapGranularityAlignmentValid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 5) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5)); }
    }

    [NativeTypeName("byte : 1")]
    public byte GetFreeSpaceSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 6) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6)); }
    }

    [NativeTypeName("byte : 1")]
    public byte MapSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 7) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7)); }
    }

    [NativeTypeName("BYTE[7]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [NativeTypeName("DWORDLONG")]
    public ulong OptimalUnmapGranularity;

    [NativeTypeName("DWORDLONG")]
    public ulong UnmapGranularityAlignment;

    [NativeTypeName("DWORD")]
    public uint MaxUnmapLbaCount;

    [NativeTypeName("DWORD")]
    public uint MaxUnmapBlockDescriptorCount;

    [InlineArray(7)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }
}
