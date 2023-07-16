// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HTML_PAINT_EVENT_FLAGS.xml' path='doc/member[@name="HTML_PAINT_EVENT_FLAGS"]/*'/>
public enum HTML_PAINT_EVENT_FLAGS
{
    /// <include file='HTML_PAINT_EVENT_FLAGS.xml' path='doc/member[@name="HTML_PAINT_EVENT_FLAGS.HTMLPAINT_EVENT_TARGET"]/*'/>
    HTMLPAINT_EVENT_TARGET = 0x1,
    /// <include file='HTML_PAINT_EVENT_FLAGS.xml' path='doc/member[@name="HTML_PAINT_EVENT_FLAGS.HTMLPAINT_EVENT_SETCURSOR"]/*'/>
    HTMLPAINT_EVENT_SETCURSOR = 0x2,
    /// <include file='HTML_PAINT_EVENT_FLAGS.xml' path='doc/member[@name="HTML_PAINT_EVENT_FLAGS.HTML_PAINT_EVENT_FLAGS_Max"]/*'/>
    HTML_PAINT_EVENT_FLAGS_Max = 2147483647,
}