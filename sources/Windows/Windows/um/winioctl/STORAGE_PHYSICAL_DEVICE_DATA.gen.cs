// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct STORAGE_PHYSICAL_DEVICE_DATA
{
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.DeviceId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DeviceId;
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.Role"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Role;
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.HealthStatus"]/*'/>
    public STORAGE_COMPONENT_HEALTH_STATUS HealthStatus;
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.CommandProtocol"]/*'/>
    public STORAGE_PROTOCOL_TYPE CommandProtocol;
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.SpecVersion"]/*'/>
    public STORAGE_SPEC_VERSION SpecVersion;
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.FormFactor"]/*'/>
    public STORAGE_DEVICE_FORM_FACTOR FormFactor;
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.Vendor"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte Vendor[8];
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.Model"]/*'/>
    [NativeTypeName("BYTE[40]")]
    public fixed byte Model[40];
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.FirmwareRevision"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte FirmwareRevision[16];
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.Capacity"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Capacity;
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.PhysicalLocation"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte PhysicalLocation[32];
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.Reserved"]/*'/>
    [NativeTypeName("DWORD[2]")]
    public fixed uint Reserved[2];
}