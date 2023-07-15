// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_BITMAP_PROPERTIES.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES"]/*'/>
public partial struct D2D1_BITMAP_PROPERTIES
{
    /// <include file='D2D1_BITMAP_PROPERTIES.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES.pixelFormat"]/*'/>
    public D2D1_PIXEL_FORMAT pixelFormat;
    /// <include file='D2D1_BITMAP_PROPERTIES.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES.dpiX"]/*'/>
    public float dpiX;
    /// <include file='D2D1_BITMAP_PROPERTIES.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES.dpiY"]/*'/>
    public float dpiY;
}