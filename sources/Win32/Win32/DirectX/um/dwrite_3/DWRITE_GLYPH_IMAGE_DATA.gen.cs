// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DWRITE_GLYPH_IMAGE_DATA
{
    [NativeTypeName("const void *")]
    public void* imageData;

    [NativeTypeName("UINT32")]
    public uint imageDataSize;

    [NativeTypeName("UINT32")]
    public uint uniqueDataId;

    [NativeTypeName("UINT32")]
    public uint pixelsPerEm;

    [NativeTypeName("D2D1_SIZE_U")]
    public D2D_SIZE_U pixelSize;

    [NativeTypeName("D2D1_POINT_2L")]
    public POINT horizontalLeftOrigin;

    [NativeTypeName("D2D1_POINT_2L")]
    public POINT horizontalRightOrigin;

    [NativeTypeName("D2D1_POINT_2L")]
    public POINT verticalTopOrigin;

    [NativeTypeName("D2D1_POINT_2L")]
    public POINT verticalBottomOrigin;
}
