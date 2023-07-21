// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPLAYCONFIG_SCALING.xml' path='doc/member[@name="DISPLAYCONFIG_SCALING"]/*' />
public enum DISPLAYCONFIG_SCALING
{
    /// <include file='DISPLAYCONFIG_SCALING.xml' path='doc/member[@name="DISPLAYCONFIG_SCALING.DISPLAYCONFIG_SCALING_IDENTITY"]/*' />
    DISPLAYCONFIG_SCALING_IDENTITY = 1,

    /// <include file='DISPLAYCONFIG_SCALING.xml' path='doc/member[@name="DISPLAYCONFIG_SCALING.DISPLAYCONFIG_SCALING_CENTERED"]/*' />
    DISPLAYCONFIG_SCALING_CENTERED = 2,

    /// <include file='DISPLAYCONFIG_SCALING.xml' path='doc/member[@name="DISPLAYCONFIG_SCALING.DISPLAYCONFIG_SCALING_STRETCHED"]/*' />
    DISPLAYCONFIG_SCALING_STRETCHED = 3,

    /// <include file='DISPLAYCONFIG_SCALING.xml' path='doc/member[@name="DISPLAYCONFIG_SCALING.DISPLAYCONFIG_SCALING_ASPECTRATIOCENTEREDMAX"]/*' />
    DISPLAYCONFIG_SCALING_ASPECTRATIOCENTEREDMAX = 4,

    /// <include file='DISPLAYCONFIG_SCALING.xml' path='doc/member[@name="DISPLAYCONFIG_SCALING.DISPLAYCONFIG_SCALING_CUSTOM"]/*' />
    DISPLAYCONFIG_SCALING_CUSTOM = 5,

    /// <include file='DISPLAYCONFIG_SCALING.xml' path='doc/member[@name="DISPLAYCONFIG_SCALING.DISPLAYCONFIG_SCALING_PREFERRED"]/*' />
    DISPLAYCONFIG_SCALING_PREFERRED = 128,

    /// <include file='DISPLAYCONFIG_SCALING.xml' path='doc/member[@name="DISPLAYCONFIG_SCALING.DISPLAYCONFIG_SCALING_FORCE_UINT32"]/*' />
    DISPLAYCONFIG_SCALING_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
}
