// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_INK_STYLE_PROPERTIES.xml' path='doc/member[@name="D2D1_INK_STYLE_PROPERTIES"]/*' />
public partial struct D2D1_INK_STYLE_PROPERTIES
{
    /// <include file='D2D1_INK_STYLE_PROPERTIES.xml' path='doc/member[@name="D2D1_INK_STYLE_PROPERTIES.nibShape"]/*' />
    public D2D1_INK_NIB_SHAPE nibShape;

    /// <include file='D2D1_INK_STYLE_PROPERTIES.xml' path='doc/member[@name="D2D1_INK_STYLE_PROPERTIES.nibTransform"]/*' />
    [NativeTypeName("D2D1_MATRIX_3X2_F")]
    public D2D_MATRIX_3X2_F nibTransform;
}
