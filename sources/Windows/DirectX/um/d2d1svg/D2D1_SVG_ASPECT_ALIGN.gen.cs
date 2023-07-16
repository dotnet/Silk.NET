// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN"]/*'/>
public enum D2D1_SVG_ASPECT_ALIGN
{
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_NONE"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_NONE = 0,
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MIN"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MIN = 1,
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MIN"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MIN = 2,
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MIN"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MIN = 3,
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MID"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MID = 4,
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MID"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MID = 5,
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MID"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MID = 6,
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MAX"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MAX = 7,
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MAX"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MAX = 8,
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MAX"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MAX = 9,
    /// <include file='D2D1_SVG_ASPECT_ALIGN.xml' path='doc/member[@name="D2D1_SVG_ASPECT_ALIGN.D2D1_SVG_ASPECT_ALIGN_FORCE_DWORD"]/*'/>
    D2D1_SVG_ASPECT_ALIGN_FORCE_DWORD = unchecked((int)(0xffffffff)),
}