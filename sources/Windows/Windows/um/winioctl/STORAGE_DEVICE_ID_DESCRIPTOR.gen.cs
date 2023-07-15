// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_DEVICE_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_ID_DESCRIPTOR"]/*'/>
public unsafe partial struct STORAGE_DEVICE_ID_DESCRIPTOR
{
    /// <include file='STORAGE_DEVICE_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_ID_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_ID_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_ID_DESCRIPTOR.NumberOfIdentifiers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfIdentifiers;
    /// <include file='STORAGE_DEVICE_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_ID_DESCRIPTOR.Identifiers"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Identifiers[1];
}