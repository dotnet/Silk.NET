// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
[SupportedOSPlatform("windows6.2")]
public enum APPX_CAPABILITIES
{
    APPX_CAPABILITY_INTERNET_CLIENT = 0x1,
    APPX_CAPABILITY_INTERNET_CLIENT_SERVER = 0x2,
    APPX_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER = 0x4,
    APPX_CAPABILITY_DOCUMENTS_LIBRARY = 0x8,
    APPX_CAPABILITY_PICTURES_LIBRARY = 0x10,
    APPX_CAPABILITY_VIDEOS_LIBRARY = 0x20,
    APPX_CAPABILITY_MUSIC_LIBRARY = 0x40,
    APPX_CAPABILITY_ENTERPRISE_AUTHENTICATION = 0x80,
    APPX_CAPABILITY_SHARED_USER_CERTIFICATES = 0x100,
    APPX_CAPABILITY_REMOVABLE_STORAGE = 0x200,
    APPX_CAPABILITY_APPOINTMENTS = 0x400,
    APPX_CAPABILITY_CONTACTS = 0x800,
}
