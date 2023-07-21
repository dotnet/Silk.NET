// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO"]/*' />
public unsafe partial struct SCM_PD_DEVICE_INFO
{
    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.DeviceGuid"]/*' />
    public Guid DeviceGuid;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.UnsafeShutdownCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint UnsafeShutdownCount;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.PersistentMemorySizeInBytes"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong PersistentMemorySizeInBytes;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.VolatileMemorySizeInBytes"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong VolatileMemorySizeInBytes;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.TotalMemorySizeInBytes"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong TotalMemorySizeInBytes;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SlotNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint SlotNumber;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.DeviceHandle"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceHandle;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.PhysicalId"]/*' />
    [NativeTypeName("WORD")]
    public ushort PhysicalId;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.NumberOfFormatInterfaceCodes"]/*' />
    public byte NumberOfFormatInterfaceCodes;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.FormatInterfaceCodes"]/*' />
    [NativeTypeName("WORD[8]")]
    public fixed ushort FormatInterfaceCodes[8];

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.VendorId"]/*' />
    [NativeTypeName("DWORD")]
    public uint VendorId;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.ProductId"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProductId;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SubsystemDeviceId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SubsystemDeviceId;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SubsystemVendorId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SubsystemVendorId;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.ManufacturingLocation"]/*' />
    public byte ManufacturingLocation;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.ManufacturingWeek"]/*' />
    public byte ManufacturingWeek;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.ManufacturingYear"]/*' />
    public byte ManufacturingYear;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SerialNumber4Byte"]/*' />
    [NativeTypeName("DWORD")]
    public uint SerialNumber4Byte;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SerialNumberLengthInChars"]/*' />
    [NativeTypeName("DWORD")]
    public uint SerialNumberLengthInChars;

    /// <include file='SCM_PD_DEVICE_INFO.xml' path='doc/member[@name="SCM_PD_DEVICE_INFO.SerialNumber"]/*' />
    [NativeTypeName("CHAR[1]")]
    public fixed sbyte SerialNumber[1];
}
