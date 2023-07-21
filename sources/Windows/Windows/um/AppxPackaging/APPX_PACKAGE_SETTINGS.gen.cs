// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='APPX_PACKAGE_SETTINGS.xml' path='doc/member[@name="APPX_PACKAGE_SETTINGS"]/*' />
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct APPX_PACKAGE_SETTINGS
{
    /// <include file='APPX_PACKAGE_SETTINGS.xml' path='doc/member[@name="APPX_PACKAGE_SETTINGS.forceZip32"]/*' />
    public BOOL forceZip32;

    /// <include file='APPX_PACKAGE_SETTINGS.xml' path='doc/member[@name="APPX_PACKAGE_SETTINGS.hashMethod"]/*' />
    public IUri* hashMethod;
}
