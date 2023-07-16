// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct DEVICE_DATA_SET_LB_PROVISIONING_STATE
{
    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.SlabSizeInBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong SlabSizeInBytes;
    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.SlabOffsetDeltaInBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SlabOffsetDeltaInBytes;
    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.SlabAllocationBitMapBitCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SlabAllocationBitMapBitCount;
    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.SlabAllocationBitMapLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SlabAllocationBitMapLength;
    /// <include file='DEVICE_DATA_SET_LB_PROVISIONING_STATE.xml' path='doc/member[@name="DEVICE_DATA_SET_LB_PROVISIONING_STATE.SlabAllocationBitMap"]/*'/>
    [NativeTypeName("DWORD[1]")]
    public fixed uint SlabAllocationBitMap[1];
}