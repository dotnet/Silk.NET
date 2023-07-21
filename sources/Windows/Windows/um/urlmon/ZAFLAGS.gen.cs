// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS"]/*' />
[Flags]
public enum ZAFLAGS
{
    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_CUSTOM_EDIT"]/*' />
    ZAFLAGS_CUSTOM_EDIT = 0x1,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_ADD_SITES"]/*' />
    ZAFLAGS_ADD_SITES = 0x2,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_REQUIRE_VERIFICATION"]/*' />
    ZAFLAGS_REQUIRE_VERIFICATION = 0x4,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_INCLUDE_PROXY_OVERRIDE"]/*' />
    ZAFLAGS_INCLUDE_PROXY_OVERRIDE = 0x8,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_INCLUDE_INTRANET_SITES"]/*' />
    ZAFLAGS_INCLUDE_INTRANET_SITES = 0x10,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_NO_UI"]/*' />
    ZAFLAGS_NO_UI = 0x20,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_SUPPORTS_VERIFICATION"]/*' />
    ZAFLAGS_SUPPORTS_VERIFICATION = 0x40,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_UNC_AS_INTRANET"]/*' />
    ZAFLAGS_UNC_AS_INTRANET = 0x80,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_DETECT_INTRANET"]/*' />
    ZAFLAGS_DETECT_INTRANET = 0x100,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_USE_LOCKED_ZONES"]/*' />
    ZAFLAGS_USE_LOCKED_ZONES = 0x10000,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_VERIFY_TEMPLATE_SETTINGS"]/*' />
    ZAFLAGS_VERIFY_TEMPLATE_SETTINGS = 0x20000,

    /// <include file='ZAFLAGS.xml' path='doc/member[@name="ZAFLAGS.ZAFLAGS_NO_CACHE"]/*' />
    ZAFLAGS_NO_CACHE = 0x40000,
}
