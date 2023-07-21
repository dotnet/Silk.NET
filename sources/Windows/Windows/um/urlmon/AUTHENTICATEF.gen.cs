// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='AUTHENTICATEF.xml' path='doc/member[@name="AUTHENTICATEF"]/*' />
[Flags]
public enum AUTHENTICATEF
{
    /// <include file='AUTHENTICATEF.xml' path='doc/member[@name="AUTHENTICATEF.AUTHENTICATEF_PROXY"]/*' />
    AUTHENTICATEF_PROXY = 0x1,

    /// <include file='AUTHENTICATEF.xml' path='doc/member[@name="AUTHENTICATEF.AUTHENTICATEF_BASIC"]/*' />
    AUTHENTICATEF_BASIC = 0x2,

    /// <include file='AUTHENTICATEF.xml' path='doc/member[@name="AUTHENTICATEF.AUTHENTICATEF_HTTP"]/*' />
    AUTHENTICATEF_HTTP = 0x4,
}
