// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GLYPHMETRICS.xml' path='doc/member[@name="GLYPHMETRICS"]/*' />
public partial struct GLYPHMETRICS
{
    /// <include file='GLYPHMETRICS.xml' path='doc/member[@name="GLYPHMETRICS.gmBlackBoxX"]/*' />
    public uint gmBlackBoxX;

    /// <include file='GLYPHMETRICS.xml' path='doc/member[@name="GLYPHMETRICS.gmBlackBoxY"]/*' />
    public uint gmBlackBoxY;

    /// <include file='GLYPHMETRICS.xml' path='doc/member[@name="GLYPHMETRICS.gmptGlyphOrigin"]/*' />
    public POINT gmptGlyphOrigin;

    /// <include file='GLYPHMETRICS.xml' path='doc/member[@name="GLYPHMETRICS.gmCellIncX"]/*' />
    public short gmCellIncX;

    /// <include file='GLYPHMETRICS.xml' path='doc/member[@name="GLYPHMETRICS.gmCellIncY"]/*' />
    public short gmCellIncY;
}
