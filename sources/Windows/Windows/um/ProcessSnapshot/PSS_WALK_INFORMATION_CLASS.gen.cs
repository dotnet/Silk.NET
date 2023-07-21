// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PSS_WALK_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_WALK_INFORMATION_CLASS"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum PSS_WALK_INFORMATION_CLASS
{
    /// <include file='PSS_WALK_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_WALK_INFORMATION_CLASS.PSS_WALK_AUXILIARY_PAGES"]/*' />
    PSS_WALK_AUXILIARY_PAGES = 0,

    /// <include file='PSS_WALK_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_WALK_INFORMATION_CLASS.PSS_WALK_VA_SPACE"]/*' />
    PSS_WALK_VA_SPACE = 1,

    /// <include file='PSS_WALK_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_WALK_INFORMATION_CLASS.PSS_WALK_HANDLES"]/*' />
    PSS_WALK_HANDLES = 2,

    /// <include file='PSS_WALK_INFORMATION_CLASS.xml' path='doc/member[@name="PSS_WALK_INFORMATION_CLASS.PSS_WALK_THREADS"]/*' />
    PSS_WALK_THREADS = 3,
}
