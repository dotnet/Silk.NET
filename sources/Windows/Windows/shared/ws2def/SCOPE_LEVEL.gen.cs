// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SCOPE_LEVEL.xml' path='doc/member[@name="SCOPE_LEVEL"]/*' />
public enum SCOPE_LEVEL
{
    /// <include file='SCOPE_LEVEL.xml' path='doc/member[@name="SCOPE_LEVEL.ScopeLevelInterface"]/*' />
    ScopeLevelInterface = 1,

    /// <include file='SCOPE_LEVEL.xml' path='doc/member[@name="SCOPE_LEVEL.ScopeLevelLink"]/*' />
    ScopeLevelLink = 2,

    /// <include file='SCOPE_LEVEL.xml' path='doc/member[@name="SCOPE_LEVEL.ScopeLevelSubnet"]/*' />
    ScopeLevelSubnet = 3,

    /// <include file='SCOPE_LEVEL.xml' path='doc/member[@name="SCOPE_LEVEL.ScopeLevelAdmin"]/*' />
    ScopeLevelAdmin = 4,

    /// <include file='SCOPE_LEVEL.xml' path='doc/member[@name="SCOPE_LEVEL.ScopeLevelSite"]/*' />
    ScopeLevelSite = 5,

    /// <include file='SCOPE_LEVEL.xml' path='doc/member[@name="SCOPE_LEVEL.ScopeLevelOrganization"]/*' />
    ScopeLevelOrganization = 8,

    /// <include file='SCOPE_LEVEL.xml' path='doc/member[@name="SCOPE_LEVEL.ScopeLevelGlobal"]/*' />
    ScopeLevelGlobal = 14,

    /// <include file='SCOPE_LEVEL.xml' path='doc/member[@name="SCOPE_LEVEL.ScopeLevelCount"]/*' />
    ScopeLevelCount = 16,
}
