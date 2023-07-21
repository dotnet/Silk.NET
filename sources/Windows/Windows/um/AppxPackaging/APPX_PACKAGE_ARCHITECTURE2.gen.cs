// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='APPX_PACKAGE_ARCHITECTURE2.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE2"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum APPX_PACKAGE_ARCHITECTURE2
{
    /// <include file='APPX_PACKAGE_ARCHITECTURE2.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE2.APPX_PACKAGE_ARCHITECTURE2_X86"]/*' />
    APPX_PACKAGE_ARCHITECTURE2_X86 = 0,

    /// <include file='APPX_PACKAGE_ARCHITECTURE2.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE2.APPX_PACKAGE_ARCHITECTURE2_ARM"]/*' />
    APPX_PACKAGE_ARCHITECTURE2_ARM = 5,

    /// <include file='APPX_PACKAGE_ARCHITECTURE2.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE2.APPX_PACKAGE_ARCHITECTURE2_X64"]/*' />
    APPX_PACKAGE_ARCHITECTURE2_X64 = 9,

    /// <include file='APPX_PACKAGE_ARCHITECTURE2.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE2.APPX_PACKAGE_ARCHITECTURE2_NEUTRAL"]/*' />
    APPX_PACKAGE_ARCHITECTURE2_NEUTRAL = 11,

    /// <include file='APPX_PACKAGE_ARCHITECTURE2.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE2.APPX_PACKAGE_ARCHITECTURE2_ARM64"]/*' />
    APPX_PACKAGE_ARCHITECTURE2_ARM64 = 12,

    /// <include file='APPX_PACKAGE_ARCHITECTURE2.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE2.APPX_PACKAGE_ARCHITECTURE2_X86_ON_ARM64"]/*' />
    APPX_PACKAGE_ARCHITECTURE2_X86_ON_ARM64 = 14,

    /// <include file='APPX_PACKAGE_ARCHITECTURE2.xml' path='doc/member[@name="APPX_PACKAGE_ARCHITECTURE2.APPX_PACKAGE_ARCHITECTURE2_UNKNOWN"]/*' />
    APPX_PACKAGE_ARCHITECTURE2_UNKNOWN = 0xffff,
}
