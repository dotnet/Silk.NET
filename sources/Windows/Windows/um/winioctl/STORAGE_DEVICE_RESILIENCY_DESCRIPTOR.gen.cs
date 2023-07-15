// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_RESILIENCY_DESCRIPTOR"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct STORAGE_DEVICE_RESILIENCY_DESCRIPTOR
{
    /// <include file='STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.NameOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NameOffset;
    /// <include file='STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.NumberOfLogicalCopies"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfLogicalCopies;
    /// <include file='STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.NumberOfPhysicalCopies"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfPhysicalCopies;
    /// <include file='STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.PhysicalDiskRedundancy"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PhysicalDiskRedundancy;
    /// <include file='STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.NumberOfColumns"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfColumns;
    /// <include file='STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_RESILIENCY_DESCRIPTOR.Interleave"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Interleave;
}