// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_GET")]
    public delegate* unmanaged<
        void*,
        CRYPT_DATA_BLOB*,
        uint,
        CRYPT_DATA_BLOB*,
        byte**,
        uint*,
        ushort**,
        CRYPT_DATA_BLOB**,
        BOOL> pfnGet;

    [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_RELEASE")]
    public delegate* unmanaged<uint, void*, void> pfnRelease;

    [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE_PASSWORD")]
    public delegate* unmanaged<void*, ushort*, void> pfnFreePassword;

    [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE")]
    public delegate* unmanaged<void*, byte*, void> pfnFree;

    [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE_IDENTIFIER")]
    public delegate* unmanaged<void*, CRYPT_DATA_BLOB*, void> pfnFreeIdentifier;
}
