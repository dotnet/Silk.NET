// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='STORAGE_DEVICE_POWER_CAP.xml' path='doc/member[@name="STORAGE_DEVICE_POWER_CAP"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_DEVICE_POWER_CAP
{
    /// <include file='STORAGE_DEVICE_POWER_CAP.xml' path='doc/member[@name="STORAGE_DEVICE_POWER_CAP.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_POWER_CAP.xml' path='doc/member[@name="STORAGE_DEVICE_POWER_CAP.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_POWER_CAP.xml' path='doc/member[@name="STORAGE_DEVICE_POWER_CAP.Units"]/*'/>
    public STORAGE_DEVICE_POWER_CAP_UNITS Units;
    /// <include file='STORAGE_DEVICE_POWER_CAP.xml' path='doc/member[@name="STORAGE_DEVICE_POWER_CAP.MaxPower"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MaxPower;
}