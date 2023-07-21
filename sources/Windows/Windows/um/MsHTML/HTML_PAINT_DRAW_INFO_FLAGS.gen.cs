// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HTML_PAINT_DRAW_INFO_FLAGS.xml' path='doc/member[@name="HTML_PAINT_DRAW_INFO_FLAGS"]/*' />
public enum HTML_PAINT_DRAW_INFO_FLAGS
{
    /// <include file='HTML_PAINT_DRAW_INFO_FLAGS.xml' path='doc/member[@name="HTML_PAINT_DRAW_INFO_FLAGS.HTMLPAINT_DRAWINFO_VIEWPORT"]/*' />
    HTMLPAINT_DRAWINFO_VIEWPORT = 0x1,

    /// <include file='HTML_PAINT_DRAW_INFO_FLAGS.xml' path='doc/member[@name="HTML_PAINT_DRAW_INFO_FLAGS.HTMLPAINT_DRAWINFO_UPDATEREGION"]/*' />
    HTMLPAINT_DRAWINFO_UPDATEREGION = 0x2,

    /// <include file='HTML_PAINT_DRAW_INFO_FLAGS.xml' path='doc/member[@name="HTML_PAINT_DRAW_INFO_FLAGS.HTMLPAINT_DRAWINFO_XFORM"]/*' />
    HTMLPAINT_DRAWINFO_XFORM = 0x4,

    /// <include file='HTML_PAINT_DRAW_INFO_FLAGS.xml' path='doc/member[@name="HTML_PAINT_DRAW_INFO_FLAGS.HTML_PAINT_DRAW_INFO_FLAGS_Max"]/*' />
    HTML_PAINT_DRAW_INFO_FLAGS_Max = 2147483647,
}
