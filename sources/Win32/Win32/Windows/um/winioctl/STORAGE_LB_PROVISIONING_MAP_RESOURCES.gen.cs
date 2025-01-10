// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_LB_PROVISIONING_MAP_RESOURCES
{
    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint Version;
    public byte _bitfield1;

    [NativeTypeName("byte : 1")]
    public byte AvailableMappingResourcesValid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)(_bitfield1 & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (byte)((_bitfield1 & ~0x1u) | (value & 0x1u)); }
    }

    [NativeTypeName("byte : 1")]
    public byte UsedMappingResourcesValid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield1 >> 1) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (byte)((_bitfield1 & ~(0x1u << 1)) | ((value & 0x1u) << 1)); }
    }

    [NativeTypeName("byte : 6")]
    public byte Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield1 >> 2) & 0x3Fu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield1 = (byte)((_bitfield1 & ~(0x3Fu << 2)) | ((value & 0x3Fu) << 2)); }
    }

    [NativeTypeName("BYTE[3]")]
    public _Reserved1_e__FixedBuffer Reserved1;
    public byte _bitfield2;

    [NativeTypeName("byte : 2")]
    public byte AvailableMappingResourcesScope
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)(_bitfield2 & 0x3u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (byte)((_bitfield2 & ~0x3u) | (value & 0x3u)); }
    }

    [NativeTypeName("byte : 2")]
    public byte UsedMappingResourcesScope
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield2 >> 2) & 0x3u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (byte)((_bitfield2 & ~(0x3u << 2)) | ((value & 0x3u) << 2)); }
    }

    [NativeTypeName("byte : 4")]
    public byte Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield2 >> 4) & 0xFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield2 = (byte)((_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4)); }
    }

    [NativeTypeName("BYTE[3]")]
    public _Reserved3_e__FixedBuffer Reserved3;

    [NativeTypeName("DWORDLONG")]
    public ulong AvailableMappingResources;

    [NativeTypeName("DWORDLONG")]
    public ulong UsedMappingResources;

    [InlineArray(3)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(3)]
    public partial struct _Reserved3_e__FixedBuffer
    {
        public byte e0;
    }
}
