// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_BITMAP_PROPERTIES1.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1"]/*'/>
public unsafe partial struct D2D1_BITMAP_PROPERTIES1
{
    /// <include file='D2D1_BITMAP_PROPERTIES1.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1.pixelFormat"]/*'/>
    public D2D1_PIXEL_FORMAT pixelFormat;
    /// <include file='D2D1_BITMAP_PROPERTIES1.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1.dpiX"]/*'/>
    public float dpiX;
    /// <include file='D2D1_BITMAP_PROPERTIES1.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1.dpiY"]/*'/>
    public float dpiY;
    /// <include file='D2D1_BITMAP_PROPERTIES1.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1.bitmapOptions"]/*'/>
    public D2D1_BITMAP_OPTIONS bitmapOptions;
    /// <include file='D2D1_BITMAP_PROPERTIES1.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1.colorContext"]/*'/>
    public ID2D1ColorContext* colorContext;
}