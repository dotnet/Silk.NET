// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_SVG_DISPLAY.xml' path='doc/member[@name="D2D1_SVG_DISPLAY"]/*'/>
public enum D2D1_SVG_DISPLAY
{
    /// <include file='D2D1_SVG_DISPLAY.xml' path='doc/member[@name="D2D1_SVG_DISPLAY.D2D1_SVG_DISPLAY_INLINE"]/*'/>
    D2D1_SVG_DISPLAY_INLINE = 0,
    /// <include file='D2D1_SVG_DISPLAY.xml' path='doc/member[@name="D2D1_SVG_DISPLAY.D2D1_SVG_DISPLAY_NONE"]/*'/>
    D2D1_SVG_DISPLAY_NONE = 1,
    /// <include file='D2D1_SVG_DISPLAY.xml' path='doc/member[@name="D2D1_SVG_DISPLAY.D2D1_SVG_DISPLAY_FORCE_DWORD"]/*'/>
    D2D1_SVG_DISPLAY_FORCE_DWORD = unchecked((int)(0xffffffff)),
}