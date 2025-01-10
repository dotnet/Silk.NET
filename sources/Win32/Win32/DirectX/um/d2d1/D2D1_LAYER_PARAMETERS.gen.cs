// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D2D1_LAYER_PARAMETERS
{
    [NativeTypeName("D2D1_RECT_F")]
    public D2D_RECT_F contentBounds;
    public ID2D1Geometry geometricMask;
    public D2D1_ANTIALIAS_MODE maskAntialiasMode;

    [NativeTypeName("D2D1_MATRIX_3X2_F")]
    public D2D_MATRIX_3X2_F maskTransform;
    public float opacity;
    public ID2D1Brush opacityBrush;
    public D2D1_LAYER_OPTIONS layerOptions;
}
