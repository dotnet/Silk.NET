// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR"]/*'/>
public partial struct STORAGE_ADAPTER_DESCRIPTOR
{
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.MaximumTransferLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaximumTransferLength;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.MaximumPhysicalPages"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaximumPhysicalPages;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.AlignmentMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AlignmentMask;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.AdapterUsesPio"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte AdapterUsesPio;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.AdapterScansDown"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte AdapterScansDown;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.CommandQueueing"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte CommandQueueing;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.AcceleratedTransfer"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte AcceleratedTransfer;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.BusType"]/*'/>
    public byte BusType;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.BusMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort BusMajorVersion;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.BusMinorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort BusMinorVersion;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.SrbType"]/*'/>
    public byte SrbType;
    /// <include file='STORAGE_ADAPTER_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ADAPTER_DESCRIPTOR.AddressType"]/*'/>
    public byte AddressType;
}