// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum APPX_CAPABILITIES
{
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_INTERNET_CLIENT"]/*'/>
    APPX_CAPABILITY_INTERNET_CLIENT = 0x1,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_INTERNET_CLIENT_SERVER"]/*'/>
    APPX_CAPABILITY_INTERNET_CLIENT_SERVER = 0x2,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER"]/*'/>
    APPX_CAPABILITY_PRIVATE_NETWORK_CLIENT_SERVER = 0x4,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_DOCUMENTS_LIBRARY"]/*'/>
    APPX_CAPABILITY_DOCUMENTS_LIBRARY = 0x8,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_PICTURES_LIBRARY"]/*'/>
    APPX_CAPABILITY_PICTURES_LIBRARY = 0x10,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_VIDEOS_LIBRARY"]/*'/>
    APPX_CAPABILITY_VIDEOS_LIBRARY = 0x20,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_MUSIC_LIBRARY"]/*'/>
    APPX_CAPABILITY_MUSIC_LIBRARY = 0x40,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_ENTERPRISE_AUTHENTICATION"]/*'/>
    APPX_CAPABILITY_ENTERPRISE_AUTHENTICATION = 0x80,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_SHARED_USER_CERTIFICATES"]/*'/>
    APPX_CAPABILITY_SHARED_USER_CERTIFICATES = 0x100,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_REMOVABLE_STORAGE"]/*'/>
    APPX_CAPABILITY_REMOVABLE_STORAGE = 0x200,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_APPOINTMENTS"]/*'/>
    APPX_CAPABILITY_APPOINTMENTS = 0x400,
    /// <include file='APPX_CAPABILITIES.xml' path='doc/member[@name="APPX_CAPABILITIES.APPX_CAPABILITY_CONTACTS"]/*'/>
    APPX_CAPABILITY_CONTACTS = 0x800,
}