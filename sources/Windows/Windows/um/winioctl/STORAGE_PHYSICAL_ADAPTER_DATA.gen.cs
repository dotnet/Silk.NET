// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA"]/*' />
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct STORAGE_PHYSICAL_ADAPTER_DATA
{
    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.AdapterId"]/*' />
    [NativeTypeName("DWORD")]
    public uint AdapterId;

    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.HealthStatus"]/*' />
    public STORAGE_COMPONENT_HEALTH_STATUS HealthStatus;

    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.CommandProtocol"]/*' />
    public STORAGE_PROTOCOL_TYPE CommandProtocol;

    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.SpecVersion"]/*' />
    public STORAGE_SPEC_VERSION SpecVersion;

    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.Vendor"]/*' />
    [NativeTypeName("BYTE[8]")]
    public fixed byte Vendor[8];

    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.Model"]/*' />
    [NativeTypeName("BYTE[40]")]
    public fixed byte Model[40];

    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.FirmwareRevision"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte FirmwareRevision[16];

    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.PhysicalLocation"]/*' />
    [NativeTypeName("BYTE[32]")]
    public fixed byte PhysicalLocation[32];

    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.ExpanderConnected"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte ExpanderConnected;

    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.Reserved0"]/*' />
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved0[3];

    /// <include file='STORAGE_PHYSICAL_ADAPTER_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_ADAPTER_DATA.Reserved1"]/*' />
    [NativeTypeName("DWORD[3]")]
    public fixed uint Reserved1[3];
}
