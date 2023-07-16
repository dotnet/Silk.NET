// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct DEVICE_LB_PROVISIONING_DESCRIPTOR
{
    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    public byte _bitfield;
    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.ThinProvisioningEnabled"]/*'/>
    [NativeTypeName("byte : 1")]
    public byte ThinProvisioningEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)(_bitfield & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
        }
    }

    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.ThinProvisioningReadZeros"]/*'/>
    [NativeTypeName("byte : 1")]
    public byte ThinProvisioningReadZeros
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 1) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
        }
    }

    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.AnchorSupported"]/*'/>
    [NativeTypeName("byte : 3")]
    public byte AnchorSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 2) & 0x7u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x7u << 2)) | ((value & 0x7u) << 2));
        }
    }

    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.UnmapGranularityAlignmentValid"]/*'/>
    [NativeTypeName("byte : 1")]
    public byte UnmapGranularityAlignmentValid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 5) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5));
        }
    }

    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.GetFreeSpaceSupported"]/*'/>
    [NativeTypeName("byte : 1")]
    public byte GetFreeSpaceSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 6) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6));
        }
    }

    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.MapSupported"]/*'/>
    [NativeTypeName("byte : 1")]
    public byte MapSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (byte)((_bitfield >> 7) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (byte)((_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7));
        }
    }

    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.Reserved1"]/*'/>
    [NativeTypeName("BYTE[7]")]
    public fixed byte Reserved1[7];
    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.OptimalUnmapGranularity"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong OptimalUnmapGranularity;
    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.UnmapGranularityAlignment"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UnmapGranularityAlignment;
    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.MaxUnmapLbaCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxUnmapLbaCount;
    /// <include file='DEVICE_LB_PROVISIONING_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_LB_PROVISIONING_DESCRIPTOR.MaxUnmapBlockDescriptorCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxUnmapBlockDescriptorCount;
}