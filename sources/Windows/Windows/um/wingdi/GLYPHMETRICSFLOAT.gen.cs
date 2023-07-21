// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GLYPHMETRICSFLOAT.xml' path='doc/member[@name="GLYPHMETRICSFLOAT"]/*' />
public partial struct GLYPHMETRICSFLOAT
{
    /// <include file='GLYPHMETRICSFLOAT.xml' path='doc/member[@name="GLYPHMETRICSFLOAT.gmfBlackBoxX"]/*' />
    public float gmfBlackBoxX;

    /// <include file='GLYPHMETRICSFLOAT.xml' path='doc/member[@name="GLYPHMETRICSFLOAT.gmfBlackBoxY"]/*' />
    public float gmfBlackBoxY;

    /// <include file='GLYPHMETRICSFLOAT.xml' path='doc/member[@name="GLYPHMETRICSFLOAT.gmfptGlyphOrigin"]/*' />
    public POINTFLOAT gmfptGlyphOrigin;

    /// <include file='GLYPHMETRICSFLOAT.xml' path='doc/member[@name="GLYPHMETRICSFLOAT.gmfCellIncX"]/*' />
    public float gmfCellIncX;

    /// <include file='GLYPHMETRICSFLOAT.xml' path='doc/member[@name="GLYPHMETRICSFLOAT.gmfCellIncY"]/*' />
    public float gmfCellIncY;
}
