// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPVACTIONS.xml' path='doc/member[@name="SPVACTIONS"]/*' />
public enum SPVACTIONS
{
    /// <include file='SPVACTIONS.xml' path='doc/member[@name="SPVACTIONS.SPVA_Speak"]/*' />
    SPVA_Speak = 0,

    /// <include file='SPVACTIONS.xml' path='doc/member[@name="SPVACTIONS.SPVA_Silence"]/*' />
    SPVA_Silence = (SPVA_Speak + 1),

    /// <include file='SPVACTIONS.xml' path='doc/member[@name="SPVACTIONS.SPVA_Pronounce"]/*' />
    SPVA_Pronounce = (SPVA_Silence + 1),

    /// <include file='SPVACTIONS.xml' path='doc/member[@name="SPVACTIONS.SPVA_Bookmark"]/*' />
    SPVA_Bookmark = (SPVA_Pronounce + 1),

    /// <include file='SPVACTIONS.xml' path='doc/member[@name="SPVACTIONS.SPVA_SpellOut"]/*' />
    SPVA_SpellOut = (SPVA_Bookmark + 1),

    /// <include file='SPVACTIONS.xml' path='doc/member[@name="SPVACTIONS.SPVA_Section"]/*' />
    SPVA_Section = (SPVA_SpellOut + 1),

    /// <include file='SPVACTIONS.xml' path='doc/member[@name="SPVACTIONS.SPVA_ParseUnknownTag"]/*' />
    SPVA_ParseUnknownTag = (SPVA_Section + 1),
}
