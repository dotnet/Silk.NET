// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HTML_PAINT_DRAW_INFO.xml' path='doc/member[@name="HTML_PAINT_DRAW_INFO"]/*'/>
public partial struct HTML_PAINT_DRAW_INFO
{
    /// <include file='HTML_PAINT_DRAW_INFO.xml' path='doc/member[@name="HTML_PAINT_DRAW_INFO.rcViewport"]/*'/>
    public RECT rcViewport;
    /// <include file='HTML_PAINT_DRAW_INFO.xml' path='doc/member[@name="HTML_PAINT_DRAW_INFO.hrgnUpdate"]/*'/>
    public HRGN hrgnUpdate;
    /// <include file='HTML_PAINT_DRAW_INFO.xml' path='doc/member[@name="HTML_PAINT_DRAW_INFO.xform"]/*'/>
    public HTML_PAINT_XFORM xform;
}