// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_SECURITY_HEADER_LAYOUT.xml' path='doc/member[@name="WS_SECURITY_HEADER_LAYOUT"]/*' />
public enum WS_SECURITY_HEADER_LAYOUT
{
    /// <include file='WS_SECURITY_HEADER_LAYOUT.xml' path='doc/member[@name="WS_SECURITY_HEADER_LAYOUT.WS_SECURITY_HEADER_LAYOUT_STRICT"]/*' />
    WS_SECURITY_HEADER_LAYOUT_STRICT = 1,

    /// <include file='WS_SECURITY_HEADER_LAYOUT.xml' path='doc/member[@name="WS_SECURITY_HEADER_LAYOUT.WS_SECURITY_HEADER_LAYOUT_LAX"]/*' />
    WS_SECURITY_HEADER_LAYOUT_LAX = 2,

    /// <include file='WS_SECURITY_HEADER_LAYOUT.xml' path='doc/member[@name="WS_SECURITY_HEADER_LAYOUT.WS_SECURITY_HEADER_LAYOUT_LAX_WITH_TIMESTAMP_FIRST"]/*' />
    WS_SECURITY_HEADER_LAYOUT_LAX_WITH_TIMESTAMP_FIRST = 3,

    /// <include file='WS_SECURITY_HEADER_LAYOUT.xml' path='doc/member[@name="WS_SECURITY_HEADER_LAYOUT.WS_SECURITY_HEADER_LAYOUT_LAX_WITH_TIMESTAMP_LAST"]/*' />
    WS_SECURITY_HEADER_LAYOUT_LAX_WITH_TIMESTAMP_LAST = 4,
}
