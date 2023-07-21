// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DESCKIND.xml' path='doc/member[@name="DESCKIND"]/*' />
public enum DESCKIND
{
    /// <include file='DESCKIND.xml' path='doc/member[@name="DESCKIND.DESCKIND_NONE"]/*' />
    DESCKIND_NONE = 0,

    /// <include file='DESCKIND.xml' path='doc/member[@name="DESCKIND.DESCKIND_FUNCDESC"]/*' />
    DESCKIND_FUNCDESC = (DESCKIND_NONE + 1),

    /// <include file='DESCKIND.xml' path='doc/member[@name="DESCKIND.DESCKIND_VARDESC"]/*' />
    DESCKIND_VARDESC = (DESCKIND_FUNCDESC + 1),

    /// <include file='DESCKIND.xml' path='doc/member[@name="DESCKIND.DESCKIND_TYPECOMP"]/*' />
    DESCKIND_TYPECOMP = (DESCKIND_VARDESC + 1),

    /// <include file='DESCKIND.xml' path='doc/member[@name="DESCKIND.DESCKIND_IMPLICITAPPOBJ"]/*' />
    DESCKIND_IMPLICITAPPOBJ = (DESCKIND_TYPECOMP + 1),

    /// <include file='DESCKIND.xml' path='doc/member[@name="DESCKIND.DESCKIND_MAX"]/*' />
    DESCKIND_MAX = (DESCKIND_IMPLICITAPPOBJ + 1),
}
