// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_STROKE_STYLE_PROPERTIES1.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1"]/*' />
public partial struct D2D1_STROKE_STYLE_PROPERTIES1
{
    /// <include file='D2D1_STROKE_STYLE_PROPERTIES1.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1.startCap"]/*' />
    public D2D1_CAP_STYLE startCap;

    /// <include file='D2D1_STROKE_STYLE_PROPERTIES1.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1.endCap"]/*' />
    public D2D1_CAP_STYLE endCap;

    /// <include file='D2D1_STROKE_STYLE_PROPERTIES1.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1.dashCap"]/*' />
    public D2D1_CAP_STYLE dashCap;

    /// <include file='D2D1_STROKE_STYLE_PROPERTIES1.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1.lineJoin"]/*' />
    public D2D1_LINE_JOIN lineJoin;

    /// <include file='D2D1_STROKE_STYLE_PROPERTIES1.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1.miterLimit"]/*' />
    public float miterLimit;

    /// <include file='D2D1_STROKE_STYLE_PROPERTIES1.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1.dashStyle"]/*' />
    public D2D1_DASH_STYLE dashStyle;

    /// <include file='D2D1_STROKE_STYLE_PROPERTIES1.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1.dashOffset"]/*' />
    public float dashOffset;

    /// <include file='D2D1_STROKE_STYLE_PROPERTIES1.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1.transformType"]/*' />
    public D2D1_STROKE_TRANSFORM_TYPE transformType;
}
