// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HTML_PAINT_DRAW_FLAGS.xml' path='doc/member[@name="HTML_PAINT_DRAW_FLAGS"]/*'/>
public enum HTML_PAINT_DRAW_FLAGS
{
    /// <include file='HTML_PAINT_DRAW_FLAGS.xml' path='doc/member[@name="HTML_PAINT_DRAW_FLAGS.HTMLPAINT_DRAW_UPDATEREGION"]/*'/>
    HTMLPAINT_DRAW_UPDATEREGION = 0x1,
    /// <include file='HTML_PAINT_DRAW_FLAGS.xml' path='doc/member[@name="HTML_PAINT_DRAW_FLAGS.HTMLPAINT_DRAW_USE_XFORM"]/*'/>
    HTMLPAINT_DRAW_USE_XFORM = 0x2,
    /// <include file='HTML_PAINT_DRAW_FLAGS.xml' path='doc/member[@name="HTML_PAINT_DRAW_FLAGS.HTML_PAINT_DRAW_FLAGS_Max"]/*'/>
    HTML_PAINT_DRAW_FLAGS_Max = 2147483647,
}