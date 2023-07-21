// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='STORAGE_DEVICE_NUMBER_EX.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER_EX"]/*' />
public partial struct STORAGE_DEVICE_NUMBER_EX
{
    /// <include file='STORAGE_DEVICE_NUMBER_EX.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER_EX.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_DEVICE_NUMBER_EX.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER_EX.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_DEVICE_NUMBER_EX.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER_EX.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='STORAGE_DEVICE_NUMBER_EX.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER_EX.DeviceType"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceType;

    /// <include file='STORAGE_DEVICE_NUMBER_EX.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER_EX.DeviceNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceNumber;

    /// <include file='STORAGE_DEVICE_NUMBER_EX.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER_EX.DeviceGuid"]/*' />
    public Guid DeviceGuid;

    /// <include file='STORAGE_DEVICE_NUMBER_EX.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER_EX.PartitionNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint PartitionNumber;
}
