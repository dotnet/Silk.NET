// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_OPACITY_MASK_CONTENT.xml' path='doc/member[@name="D2D1_OPACITY_MASK_CONTENT"]/*'/>
public enum D2D1_OPACITY_MASK_CONTENT
{
    /// <include file='D2D1_OPACITY_MASK_CONTENT.xml' path='doc/member[@name="D2D1_OPACITY_MASK_CONTENT.D2D1_OPACITY_MASK_CONTENT_GRAPHICS"]/*'/>
    D2D1_OPACITY_MASK_CONTENT_GRAPHICS = 0,
    /// <include file='D2D1_OPACITY_MASK_CONTENT.xml' path='doc/member[@name="D2D1_OPACITY_MASK_CONTENT.D2D1_OPACITY_MASK_CONTENT_TEXT_NATURAL"]/*'/>
    D2D1_OPACITY_MASK_CONTENT_TEXT_NATURAL = 1,
    /// <include file='D2D1_OPACITY_MASK_CONTENT.xml' path='doc/member[@name="D2D1_OPACITY_MASK_CONTENT.D2D1_OPACITY_MASK_CONTENT_TEXT_GDI_COMPATIBLE"]/*'/>
    D2D1_OPACITY_MASK_CONTENT_TEXT_GDI_COMPATIBLE = 2,
    /// <include file='D2D1_OPACITY_MASK_CONTENT.xml' path='doc/member[@name="D2D1_OPACITY_MASK_CONTENT.D2D1_OPACITY_MASK_CONTENT_FORCE_DWORD"]/*'/>
    D2D1_OPACITY_MASK_CONTENT_FORCE_DWORD = unchecked((int)(0xffffffff)),
}