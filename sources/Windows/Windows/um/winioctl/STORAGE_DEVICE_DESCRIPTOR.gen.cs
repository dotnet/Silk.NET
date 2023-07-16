// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR"]/*'/>
public unsafe partial struct STORAGE_DEVICE_DESCRIPTOR
{
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.DeviceType"]/*'/>
    public byte DeviceType;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.DeviceTypeModifier"]/*'/>
    public byte DeviceTypeModifier;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.RemovableMedia"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte RemovableMedia;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.CommandQueueing"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte CommandQueueing;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.VendorIdOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint VendorIdOffset;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.ProductIdOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProductIdOffset;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.ProductRevisionOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProductRevisionOffset;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.SerialNumberOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SerialNumberOffset;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.BusType"]/*'/>
    public STORAGE_BUS_TYPE BusType;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.RawPropertiesLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RawPropertiesLength;
    /// <include file='STORAGE_DEVICE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_DESCRIPTOR.RawDeviceProperties"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte RawDeviceProperties[1];
}