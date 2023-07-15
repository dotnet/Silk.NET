// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_ROUNDED_RECT.xml' path='doc/member[@name="D2D1_ROUNDED_RECT"]/*'/>
public partial struct D2D1_ROUNDED_RECT
{
    /// <include file='D2D1_ROUNDED_RECT.xml' path='doc/member[@name="D2D1_ROUNDED_RECT.rect"]/*'/>
    [NativeTypeName("D2D1_RECT_F")]
    public D2D_RECT_F rect;
    /// <include file='D2D1_ROUNDED_RECT.xml' path='doc/member[@name="D2D1_ROUNDED_RECT.radiusX"]/*'/>
    public float radiusX;
    /// <include file='D2D1_ROUNDED_RECT.xml' path='doc/member[@name="D2D1_ROUNDED_RECT.radiusY"]/*'/>
    public float radiusY;
}