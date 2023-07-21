// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='URLTEMPLATE.xml' path='doc/member[@name="URLTEMPLATE"]/*' />
public enum URLTEMPLATE
{
    /// <include file='URLTEMPLATE.xml' path='doc/member[@name="URLTEMPLATE.URLTEMPLATE_CUSTOM"]/*' />
    URLTEMPLATE_CUSTOM = 0,

    /// <include file='URLTEMPLATE.xml' path='doc/member[@name="URLTEMPLATE.URLTEMPLATE_PREDEFINED_MIN"]/*' />
    URLTEMPLATE_PREDEFINED_MIN = 0x10000,

    /// <include file='URLTEMPLATE.xml' path='doc/member[@name="URLTEMPLATE.URLTEMPLATE_LOW"]/*' />
    URLTEMPLATE_LOW = 0x10000,

    /// <include file='URLTEMPLATE.xml' path='doc/member[@name="URLTEMPLATE.URLTEMPLATE_MEDLOW"]/*' />
    URLTEMPLATE_MEDLOW = 0x10500,

    /// <include file='URLTEMPLATE.xml' path='doc/member[@name="URLTEMPLATE.URLTEMPLATE_MEDIUM"]/*' />
    URLTEMPLATE_MEDIUM = 0x11000,

    /// <include file='URLTEMPLATE.xml' path='doc/member[@name="URLTEMPLATE.URLTEMPLATE_MEDHIGH"]/*' />
    URLTEMPLATE_MEDHIGH = 0x11500,

    /// <include file='URLTEMPLATE.xml' path='doc/member[@name="URLTEMPLATE.URLTEMPLATE_HIGH"]/*' />
    URLTEMPLATE_HIGH = 0x12000,

    /// <include file='URLTEMPLATE.xml' path='doc/member[@name="URLTEMPLATE.URLTEMPLATE_PREDEFINED_MAX"]/*' />
    URLTEMPLATE_PREDEFINED_MAX = 0x20000,
}
