// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_HTTP_HEADER_AUTH_TARGET.xml' path='doc/member[@name="WS_HTTP_HEADER_AUTH_TARGET"]/*' />
public enum WS_HTTP_HEADER_AUTH_TARGET
{
    /// <include file='WS_HTTP_HEADER_AUTH_TARGET.xml' path='doc/member[@name="WS_HTTP_HEADER_AUTH_TARGET.WS_HTTP_HEADER_AUTH_TARGET_SERVICE"]/*' />
    WS_HTTP_HEADER_AUTH_TARGET_SERVICE = 1,

    /// <include file='WS_HTTP_HEADER_AUTH_TARGET.xml' path='doc/member[@name="WS_HTTP_HEADER_AUTH_TARGET.WS_HTTP_HEADER_AUTH_TARGET_PROXY"]/*' />
    WS_HTTP_HEADER_AUTH_TARGET_PROXY = 2,
}
