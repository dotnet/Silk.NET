// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_ENCRYPTION_TYPE.xml' path='doc/member[@name="STORAGE_ENCRYPTION_TYPE"]/*'/>
public enum STORAGE_ENCRYPTION_TYPE
{
    /// <include file='STORAGE_ENCRYPTION_TYPE.xml' path='doc/member[@name="STORAGE_ENCRYPTION_TYPE.StorageEncryptionTypeUnknown"]/*'/>
    StorageEncryptionTypeUnknown = 0x00,
    /// <include file='STORAGE_ENCRYPTION_TYPE.xml' path='doc/member[@name="STORAGE_ENCRYPTION_TYPE.StorageEncryptionTypeEDrive"]/*'/>
    StorageEncryptionTypeEDrive = 0x01,
    /// <include file='STORAGE_ENCRYPTION_TYPE.xml' path='doc/member[@name="STORAGE_ENCRYPTION_TYPE.StorageEncryptionTypeTcgOpal"]/*'/>
    StorageEncryptionTypeTcgOpal = 0x02,
}