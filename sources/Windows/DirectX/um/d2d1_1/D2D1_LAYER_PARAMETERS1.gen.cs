// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_LAYER_PARAMETERS1.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1"]/*'/>
public unsafe partial struct D2D1_LAYER_PARAMETERS1
{
    /// <include file='D2D1_LAYER_PARAMETERS1.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1.contentBounds"]/*'/>
    [NativeTypeName("D2D1_RECT_F")]
    public D2D_RECT_F contentBounds;
    /// <include file='D2D1_LAYER_PARAMETERS1.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1.geometricMask"]/*'/>
    public ID2D1Geometry* geometricMask;
    /// <include file='D2D1_LAYER_PARAMETERS1.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1.maskAntialiasMode"]/*'/>
    public D2D1_ANTIALIAS_MODE maskAntialiasMode;
    /// <include file='D2D1_LAYER_PARAMETERS1.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1.maskTransform"]/*'/>
    [NativeTypeName("D2D1_MATRIX_3X2_F")]
    public D2D_MATRIX_3X2_F maskTransform;
    /// <include file='D2D1_LAYER_PARAMETERS1.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1.opacity"]/*'/>
    public float opacity;
    /// <include file='D2D1_LAYER_PARAMETERS1.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1.opacityBrush"]/*'/>
    public ID2D1Brush* opacityBrush;
    /// <include file='D2D1_LAYER_PARAMETERS1.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1.layerOptions"]/*'/>
    public D2D1_LAYER_OPTIONS1 layerOptions;
}