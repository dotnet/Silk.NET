// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_SANITIZE_METHOD.xml' path='doc/member[@name="STORAGE_SANITIZE_METHOD"]/*'/>
public enum STORAGE_SANITIZE_METHOD
{
    /// <include file='STORAGE_SANITIZE_METHOD.xml' path='doc/member[@name="STORAGE_SANITIZE_METHOD.StorageSanitizeMethodDefault"]/*'/>
    StorageSanitizeMethodDefault = 0,
    /// <include file='STORAGE_SANITIZE_METHOD.xml' path='doc/member[@name="STORAGE_SANITIZE_METHOD.StorageSanitizeMethodBlockErase"]/*'/>
    StorageSanitizeMethodBlockErase,
    /// <include file='STORAGE_SANITIZE_METHOD.xml' path='doc/member[@name="STORAGE_SANITIZE_METHOD.StorageSanitizeMethodCryptoErase"]/*'/>
    StorageSanitizeMethodCryptoErase,
}