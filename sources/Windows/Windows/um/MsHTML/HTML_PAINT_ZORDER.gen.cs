// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER"]/*'/>
public enum HTML_PAINT_ZORDER
{
    /// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER.HTMLPAINT_ZORDER_NONE"]/*'/>
    HTMLPAINT_ZORDER_NONE = 0,
    /// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER.HTMLPAINT_ZORDER_REPLACE_ALL"]/*'/>
    HTMLPAINT_ZORDER_REPLACE_ALL = 1,
    /// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER.HTMLPAINT_ZORDER_REPLACE_CONTENT"]/*'/>
    HTMLPAINT_ZORDER_REPLACE_CONTENT = 2,
    /// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER.HTMLPAINT_ZORDER_REPLACE_BACKGROUND"]/*'/>
    HTMLPAINT_ZORDER_REPLACE_BACKGROUND = 3,
    /// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER.HTMLPAINT_ZORDER_BELOW_CONTENT"]/*'/>
    HTMLPAINT_ZORDER_BELOW_CONTENT = 4,
    /// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER.HTMLPAINT_ZORDER_BELOW_FLOW"]/*'/>
    HTMLPAINT_ZORDER_BELOW_FLOW = 5,
    /// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER.HTMLPAINT_ZORDER_ABOVE_FLOW"]/*'/>
    HTMLPAINT_ZORDER_ABOVE_FLOW = 6,
    /// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER.HTMLPAINT_ZORDER_ABOVE_CONTENT"]/*'/>
    HTMLPAINT_ZORDER_ABOVE_CONTENT = 7,
    /// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER.HTMLPAINT_ZORDER_WINDOW_TOP"]/*'/>
    HTMLPAINT_ZORDER_WINDOW_TOP = 8,
    /// <include file='HTML_PAINT_ZORDER.xml' path='doc/member[@name="HTML_PAINT_ZORDER.HTML_PAINT_ZORDER_Max"]/*'/>
    HTML_PAINT_ZORDER_Max = 2147483647,
}