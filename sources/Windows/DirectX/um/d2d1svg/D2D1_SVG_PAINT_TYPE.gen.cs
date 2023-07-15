// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_SVG_PAINT_TYPE.xml' path='doc/member[@name="D2D1_SVG_PAINT_TYPE"]/*'/>
public enum D2D1_SVG_PAINT_TYPE
{
    /// <include file='D2D1_SVG_PAINT_TYPE.xml' path='doc/member[@name="D2D1_SVG_PAINT_TYPE.D2D1_SVG_PAINT_TYPE_NONE"]/*'/>
    D2D1_SVG_PAINT_TYPE_NONE = 0,
    /// <include file='D2D1_SVG_PAINT_TYPE.xml' path='doc/member[@name="D2D1_SVG_PAINT_TYPE.D2D1_SVG_PAINT_TYPE_COLOR"]/*'/>
    D2D1_SVG_PAINT_TYPE_COLOR = 1,
    /// <include file='D2D1_SVG_PAINT_TYPE.xml' path='doc/member[@name="D2D1_SVG_PAINT_TYPE.D2D1_SVG_PAINT_TYPE_CURRENT_COLOR"]/*'/>
    D2D1_SVG_PAINT_TYPE_CURRENT_COLOR = 2,
    /// <include file='D2D1_SVG_PAINT_TYPE.xml' path='doc/member[@name="D2D1_SVG_PAINT_TYPE.D2D1_SVG_PAINT_TYPE_URI"]/*'/>
    D2D1_SVG_PAINT_TYPE_URI = 3,
    /// <include file='D2D1_SVG_PAINT_TYPE.xml' path='doc/member[@name="D2D1_SVG_PAINT_TYPE.D2D1_SVG_PAINT_TYPE_URI_NONE"]/*'/>
    D2D1_SVG_PAINT_TYPE_URI_NONE = 4,
    /// <include file='D2D1_SVG_PAINT_TYPE.xml' path='doc/member[@name="D2D1_SVG_PAINT_TYPE.D2D1_SVG_PAINT_TYPE_URI_COLOR"]/*'/>
    D2D1_SVG_PAINT_TYPE_URI_COLOR = 5,
    /// <include file='D2D1_SVG_PAINT_TYPE.xml' path='doc/member[@name="D2D1_SVG_PAINT_TYPE.D2D1_SVG_PAINT_TYPE_URI_CURRENT_COLOR"]/*'/>
    D2D1_SVG_PAINT_TYPE_URI_CURRENT_COLOR = 6,
    /// <include file='D2D1_SVG_PAINT_TYPE.xml' path='doc/member[@name="D2D1_SVG_PAINT_TYPE.D2D1_SVG_PAINT_TYPE_FORCE_DWORD"]/*'/>
    D2D1_SVG_PAINT_TYPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}