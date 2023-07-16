// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_PRIMITIVE_BLEND.xml' path='doc/member[@name="D2D1_PRIMITIVE_BLEND"]/*'/>
public enum D2D1_PRIMITIVE_BLEND
{
    /// <include file='D2D1_PRIMITIVE_BLEND.xml' path='doc/member[@name="D2D1_PRIMITIVE_BLEND.D2D1_PRIMITIVE_BLEND_SOURCE_OVER"]/*'/>
    D2D1_PRIMITIVE_BLEND_SOURCE_OVER = 0,
    /// <include file='D2D1_PRIMITIVE_BLEND.xml' path='doc/member[@name="D2D1_PRIMITIVE_BLEND.D2D1_PRIMITIVE_BLEND_COPY"]/*'/>
    D2D1_PRIMITIVE_BLEND_COPY = 1,
    /// <include file='D2D1_PRIMITIVE_BLEND.xml' path='doc/member[@name="D2D1_PRIMITIVE_BLEND.D2D1_PRIMITIVE_BLEND_MIN"]/*'/>
    D2D1_PRIMITIVE_BLEND_MIN = 2,
    /// <include file='D2D1_PRIMITIVE_BLEND.xml' path='doc/member[@name="D2D1_PRIMITIVE_BLEND.D2D1_PRIMITIVE_BLEND_ADD"]/*'/>
    D2D1_PRIMITIVE_BLEND_ADD = 3,
    /// <include file='D2D1_PRIMITIVE_BLEND.xml' path='doc/member[@name="D2D1_PRIMITIVE_BLEND.D2D1_PRIMITIVE_BLEND_MAX"]/*'/>
    D2D1_PRIMITIVE_BLEND_MAX = 4,
    /// <include file='D2D1_PRIMITIVE_BLEND.xml' path='doc/member[@name="D2D1_PRIMITIVE_BLEND.D2D1_PRIMITIVE_BLEND_FORCE_DWORD"]/*'/>
    D2D1_PRIMITIVE_BLEND_FORCE_DWORD = unchecked((int)(0xffffffff)),
}