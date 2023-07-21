// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DWRITE_GLYPH_OFFSET.xml' path='doc/member[@name="DWRITE_GLYPH_OFFSET"]/*' />
public partial struct DWRITE_GLYPH_OFFSET
{
    /// <include file='DWRITE_GLYPH_OFFSET.xml' path='doc/member[@name="DWRITE_GLYPH_OFFSET.advanceOffset"]/*' />
    public float advanceOffset;

    /// <include file='DWRITE_GLYPH_OFFSET.xml' path='doc/member[@name="DWRITE_GLYPH_OFFSET.ascenderOffset"]/*' />
    public float ascenderOffset;
}
