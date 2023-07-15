// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_GLYPH_IMAGE_DATA.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_DATA"]/*'/>
public unsafe partial struct DWRITE_GLYPH_IMAGE_DATA
{
    /// <include file='DWRITE_GLYPH_IMAGE_DATA.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_DATA.imageData"]/*'/>
    [NativeTypeName("const void *")]
    public void* imageData;
    /// <include file='DWRITE_GLYPH_IMAGE_DATA.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_DATA.imageDataSize"]/*'/>
    [NativeTypeName("UINT32")]
    public uint imageDataSize;
    /// <include file='DWRITE_GLYPH_IMAGE_DATA.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_DATA.uniqueDataId"]/*'/>
    [NativeTypeName("UINT32")]
    public uint uniqueDataId;
    /// <include file='DWRITE_GLYPH_IMAGE_DATA.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_DATA.pixelsPerEm"]/*'/>
    [NativeTypeName("UINT32")]
    public uint pixelsPerEm;
    /// <include file='DWRITE_GLYPH_IMAGE_DATA.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_DATA.pixelSize"]/*'/>
    [NativeTypeName("D2D1_SIZE_U")]
    public D2D_SIZE_U pixelSize;
    /// <include file='DWRITE_GLYPH_IMAGE_DATA.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_DATA.horizontalLeftOrigin"]/*'/>
    [NativeTypeName("D2D1_POINT_2L")]
    public POINT horizontalLeftOrigin;
    /// <include file='DWRITE_GLYPH_IMAGE_DATA.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_DATA.horizontalRightOrigin"]/*'/>
    [NativeTypeName("D2D1_POINT_2L")]
    public POINT horizontalRightOrigin;
    /// <include file='DWRITE_GLYPH_IMAGE_DATA.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_DATA.verticalTopOrigin"]/*'/>
    [NativeTypeName("D2D1_POINT_2L")]
    public POINT verticalTopOrigin;
    /// <include file='DWRITE_GLYPH_IMAGE_DATA.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_DATA.verticalBottomOrigin"]/*'/>
    [NativeTypeName("D2D1_POINT_2L")]
    public POINT verticalBottomOrigin;
}