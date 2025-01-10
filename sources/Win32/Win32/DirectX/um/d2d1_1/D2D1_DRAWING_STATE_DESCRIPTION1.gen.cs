// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_DRAWING_STATE_DESCRIPTION1
{
    public D2D1_ANTIALIAS_MODE antialiasMode;
    public D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode;

    [NativeTypeName("D2D1_TAG")]
    public ulong tag1;

    [NativeTypeName("D2D1_TAG")]
    public ulong tag2;

    [NativeTypeName("D2D1_MATRIX_3X2_F")]
    public D2D_MATRIX_3X2_F transform;
    public D2D1_PRIMITIVE_BLEND primitiveBlend;
    public D2D1_UNIT_MODE unitMode;
}
