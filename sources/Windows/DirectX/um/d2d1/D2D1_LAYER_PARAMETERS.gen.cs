// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_LAYER_PARAMETERS.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS"]/*'/>
public unsafe partial struct D2D1_LAYER_PARAMETERS
{
    /// <include file='D2D1_LAYER_PARAMETERS.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS.contentBounds"]/*'/>
    [NativeTypeName("D2D1_RECT_F")]
    public D2D_RECT_F contentBounds;
    /// <include file='D2D1_LAYER_PARAMETERS.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS.geometricMask"]/*'/>
    public ID2D1Geometry* geometricMask;
    /// <include file='D2D1_LAYER_PARAMETERS.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS.maskAntialiasMode"]/*'/>
    public D2D1_ANTIALIAS_MODE maskAntialiasMode;
    /// <include file='D2D1_LAYER_PARAMETERS.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS.maskTransform"]/*'/>
    [NativeTypeName("D2D1_MATRIX_3X2_F")]
    public D2D_MATRIX_3X2_F maskTransform;
    /// <include file='D2D1_LAYER_PARAMETERS.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS.opacity"]/*'/>
    public float opacity;
    /// <include file='D2D1_LAYER_PARAMETERS.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS.opacityBrush"]/*'/>
    public ID2D1Brush* opacityBrush;
    /// <include file='D2D1_LAYER_PARAMETERS.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS.layerOptions"]/*'/>
    public D2D1_LAYER_OPTIONS layerOptions;
}