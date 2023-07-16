// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY.xml' path='doc/member[@name="STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY"]/*'/>
public partial struct STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY
{
    /// <include file='STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY.xml' path='doc/member[@name="STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY.xml' path='doc/member[@name="STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY.xml' path='doc/member[@name="STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY.SupportsSelfEncryption"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SupportsSelfEncryption;
}