// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;

/// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES"]/*' />
public unsafe partial struct STORAGE_LB_PROVISIONING_MAP_RESOURCES
{
    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    public byte _bitfield1;

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.AvailableMappingResourcesValid"]/*' />
    [NativeTypeName("byte : 1")]
    public byte AvailableMappingResourcesValid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)(_bitfield1 & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (byte)((_bitfield1 & ~0x1u) | (value & 0x1u));
        }
    }

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.UsedMappingResourcesValid"]/*' />
    [NativeTypeName("byte : 1")]
    public byte UsedMappingResourcesValid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield1 >> 1) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (byte)((_bitfield1 & ~(0x1u << 1)) | ((value & 0x1u) << 1));
        }
    }

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.Reserved0"]/*' />
    [NativeTypeName("byte : 6")]
    public byte Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield1 >> 2) & 0x3Fu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (byte)((_bitfield1 & ~(0x3Fu << 2)) | ((value & 0x3Fu) << 2));
        }
    }

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.Reserved1"]/*' />
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved1[3];

    public byte _bitfield2;

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.AvailableMappingResourcesScope"]/*' />
    [NativeTypeName("byte : 2")]
    public byte AvailableMappingResourcesScope
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)(_bitfield2 & 0x3u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (byte)((_bitfield2 & ~0x3u) | (value & 0x3u));
        }
    }

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.UsedMappingResourcesScope"]/*' />
    [NativeTypeName("byte : 2")]
    public byte UsedMappingResourcesScope
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield2 >> 2) & 0x3u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (byte)((_bitfield2 & ~(0x3u << 2)) | ((value & 0x3u) << 2));
        }
    }

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.Reserved2"]/*' />
    [NativeTypeName("byte : 4")]
    public byte Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield2 >> 4) & 0xFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (byte)((_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
        }
    }

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.Reserved3"]/*' />
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved3[3];

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.AvailableMappingResources"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong AvailableMappingResources;

    /// <include file='STORAGE_LB_PROVISIONING_MAP_RESOURCES.xml' path='doc/member[@name="STORAGE_LB_PROVISIONING_MAP_RESOURCES.UsedMappingResources"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong UsedMappingResources;
}
