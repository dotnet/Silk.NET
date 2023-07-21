// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BINDVERB.xml' path='doc/member[@name="BINDVERB"]/*' />
public enum BINDVERB
{
    /// <include file='BINDVERB.xml' path='doc/member[@name="BINDVERB.BINDVERB_GET"]/*' />
    BINDVERB_GET = 0,

    /// <include file='BINDVERB.xml' path='doc/member[@name="BINDVERB.BINDVERB_POST"]/*' />
    BINDVERB_POST = 0x1,

    /// <include file='BINDVERB.xml' path='doc/member[@name="BINDVERB.BINDVERB_PUT"]/*' />
    BINDVERB_PUT = 0x2,

    /// <include file='BINDVERB.xml' path='doc/member[@name="BINDVERB.BINDVERB_CUSTOM"]/*' />
    BINDVERB_CUSTOM = 0x3,

    /// <include file='BINDVERB.xml' path='doc/member[@name="BINDVERB.BINDVERB_RESERVED1"]/*' />
    BINDVERB_RESERVED1 = 0x4,
}
