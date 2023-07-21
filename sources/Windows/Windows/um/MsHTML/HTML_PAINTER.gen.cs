// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER"]/*' />
public enum HTML_PAINTER
{
    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_OPAQUE"]/*' />
    HTMLPAINTER_OPAQUE = 0x1,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_TRANSPARENT"]/*' />
    HTMLPAINTER_TRANSPARENT = 0x2,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_ALPHA"]/*' />
    HTMLPAINTER_ALPHA = 0x4,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_COMPLEX"]/*' />
    HTMLPAINTER_COMPLEX = 0x8,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_OVERLAY"]/*' />
    HTMLPAINTER_OVERLAY = 0x10,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_HITTEST"]/*' />
    HTMLPAINTER_HITTEST = 0x20,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_SURFACE"]/*' />
    HTMLPAINTER_SURFACE = 0x100,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_3DSURFACE"]/*' />
    HTMLPAINTER_3DSURFACE = 0x200,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_NOBAND"]/*' />
    HTMLPAINTER_NOBAND = 0x400,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_NODC"]/*' />
    HTMLPAINTER_NODC = 0x1000,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_NOPHYSICALCLIP"]/*' />
    HTMLPAINTER_NOPHYSICALCLIP = 0x2000,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_NOSAVEDC"]/*' />
    HTMLPAINTER_NOSAVEDC = 0x4000,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_SUPPORTS_XFORM"]/*' />
    HTMLPAINTER_SUPPORTS_XFORM = 0x8000,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_EXPAND"]/*' />
    HTMLPAINTER_EXPAND = 0x10000,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTMLPAINTER_NOSCROLLBITS"]/*' />
    HTMLPAINTER_NOSCROLLBITS = 0x20000,

    /// <include file='HTML_PAINTER.xml' path='doc/member[@name="HTML_PAINTER.HTML_PAINTER_Max"]/*' />
    HTML_PAINTER_Max = 2147483647,
}
