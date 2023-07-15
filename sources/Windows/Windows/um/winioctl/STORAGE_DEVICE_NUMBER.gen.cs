// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_DEVICE_NUMBER.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER"]/*'/>
public partial struct STORAGE_DEVICE_NUMBER
{
    /// <include file='STORAGE_DEVICE_NUMBER.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER.DeviceType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DeviceType;
    /// <include file='STORAGE_DEVICE_NUMBER.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER.DeviceNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DeviceNumber;
    /// <include file='STORAGE_DEVICE_NUMBER.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBER.PartitionNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PartitionNumber;
}