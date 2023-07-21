// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HLINKGETREF.xml' path='doc/member[@name="HLINKGETREF"]/*' />
public enum HLINKGETREF
{
    /// <include file='HLINKGETREF.xml' path='doc/member[@name="HLINKGETREF.HLINKGETREF_DEFAULT"]/*' />
    HLINKGETREF_DEFAULT = 0,

    /// <include file='HLINKGETREF.xml' path='doc/member[@name="HLINKGETREF.HLINKGETREF_ABSOLUTE"]/*' />
    HLINKGETREF_ABSOLUTE = 1,

    /// <include file='HLINKGETREF.xml' path='doc/member[@name="HLINKGETREF.HLINKGETREF_RELATIVE"]/*' />
    HLINKGETREF_RELATIVE = 2,
}
