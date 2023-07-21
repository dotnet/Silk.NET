// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='TextRenderingHint.xml' path='doc/member[@name="TextRenderingHint"]/*' />
public enum TextRenderingHint
{
    /// <include file='TextRenderingHint.xml' path='doc/member[@name="TextRenderingHint.TextRenderingHintSystemDefault"]/*' />
    TextRenderingHintSystemDefault = 0,

    /// <include file='TextRenderingHint.xml' path='doc/member[@name="TextRenderingHint.TextRenderingHintSingleBitPerPixelGridFit"]/*' />
    TextRenderingHintSingleBitPerPixelGridFit,

    /// <include file='TextRenderingHint.xml' path='doc/member[@name="TextRenderingHint.TextRenderingHintSingleBitPerPixel"]/*' />
    TextRenderingHintSingleBitPerPixel,

    /// <include file='TextRenderingHint.xml' path='doc/member[@name="TextRenderingHint.TextRenderingHintAntiAliasGridFit"]/*' />
    TextRenderingHintAntiAliasGridFit,

    /// <include file='TextRenderingHint.xml' path='doc/member[@name="TextRenderingHint.TextRenderingHintAntiAlias"]/*' />
    TextRenderingHintAntiAlias,

    /// <include file='TextRenderingHint.xml' path='doc/member[@name="TextRenderingHint.TextRenderingHintClearTypeGridFit"]/*' />
    TextRenderingHintClearTypeGridFit,
}
