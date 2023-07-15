// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2.xml' path='doc/member[@name="STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2"]/*'/>
public partial struct STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2
{
    /// <include file='STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2.xml' path='doc/member[@name="STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2.xml' path='doc/member[@name="STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2.xml' path='doc/member[@name="STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2.SupportsSelfEncryption"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SupportsSelfEncryption;
    /// <include file='STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2.xml' path='doc/member[@name="STORAGE_DEVICE_SELF_ENCRYPTION_PROPERTY_V2.EncryptionType"]/*'/>
    public STORAGE_ENCRYPTION_TYPE EncryptionType;
}