// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.xml' path='doc/member[@name="CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE
{
    /// <include file='CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.xml' path='doc/member[@name="CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.xml' path='doc/member[@name="CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.pfnGet"]/*'/>
    [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_GET")]
    public delegate* unmanaged<void*, CRYPT_DATA_BLOB*, uint, CRYPT_DATA_BLOB*, byte**, uint*, ushort**, CRYPT_DATA_BLOB**, BOOL> pfnGet;
    /// <include file='CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.xml' path='doc/member[@name="CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.pfnRelease"]/*'/>
    [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_RELEASE")]
    public delegate* unmanaged<uint, void*, void> pfnRelease;
    /// <include file='CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.xml' path='doc/member[@name="CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.pfnFreePassword"]/*'/>
    [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE_PASSWORD")]
    public delegate* unmanaged<void*, ushort*, void> pfnFreePassword;
    /// <include file='CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.xml' path='doc/member[@name="CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.pfnFree"]/*'/>
    [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE")]
    public delegate* unmanaged<void*, byte*, void> pfnFree;
    /// <include file='CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.xml' path='doc/member[@name="CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE.pfnFreeIdentifier"]/*'/>
    [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE_IDENTIFIER")]
    public delegate* unmanaged<void*, CRYPT_DATA_BLOB*, void> pfnFreeIdentifier;
}