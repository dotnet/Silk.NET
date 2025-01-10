// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DVS
{
    [NativeTypeName("#define D3DVS_ADDRESSMODE_SHIFT 13")]
    public const int D3DVS_ADDRESSMODE_SHIFT = 13;

    [NativeTypeName("#define D3DVS_ADDRESSMODE_MASK (1 << D3DVS_ADDRESSMODE_SHIFT)")]
    public const int D3DVS_ADDRESSMODE_MASK = (1 << 13);

    [NativeTypeName("#define D3DVS_SWIZZLE_SHIFT 16")]
    public const int D3DVS_SWIZZLE_SHIFT = 16;

    [NativeTypeName("#define D3DVS_SWIZZLE_MASK 0x00FF0000")]
    public const int D3DVS_SWIZZLE_MASK = 0x00FF0000;

    [NativeTypeName("#define D3DVS_X_X (0 << D3DVS_SWIZZLE_SHIFT)")]
    public const int D3DVS_X_X = (0 << 16);

    [NativeTypeName("#define D3DVS_X_Y (1 << D3DVS_SWIZZLE_SHIFT)")]
    public const int D3DVS_X_Y = (1 << 16);

    [NativeTypeName("#define D3DVS_X_Z (2 << D3DVS_SWIZZLE_SHIFT)")]
    public const int D3DVS_X_Z = (2 << 16);

    [NativeTypeName("#define D3DVS_X_W (3 << D3DVS_SWIZZLE_SHIFT)")]
    public const int D3DVS_X_W = (3 << 16);

    [NativeTypeName("#define D3DVS_Y_X (0 << (D3DVS_SWIZZLE_SHIFT + 2))")]
    public const int D3DVS_Y_X = (0 << (16 + 2));

    [NativeTypeName("#define D3DVS_Y_Y (1 << (D3DVS_SWIZZLE_SHIFT + 2))")]
    public const int D3DVS_Y_Y = (1 << (16 + 2));

    [NativeTypeName("#define D3DVS_Y_Z (2 << (D3DVS_SWIZZLE_SHIFT + 2))")]
    public const int D3DVS_Y_Z = (2 << (16 + 2));

    [NativeTypeName("#define D3DVS_Y_W (3 << (D3DVS_SWIZZLE_SHIFT + 2))")]
    public const int D3DVS_Y_W = (3 << (16 + 2));

    [NativeTypeName("#define D3DVS_Z_X (0 << (D3DVS_SWIZZLE_SHIFT + 4))")]
    public const int D3DVS_Z_X = (0 << (16 + 4));

    [NativeTypeName("#define D3DVS_Z_Y (1 << (D3DVS_SWIZZLE_SHIFT + 4))")]
    public const int D3DVS_Z_Y = (1 << (16 + 4));

    [NativeTypeName("#define D3DVS_Z_Z (2 << (D3DVS_SWIZZLE_SHIFT + 4))")]
    public const int D3DVS_Z_Z = (2 << (16 + 4));

    [NativeTypeName("#define D3DVS_Z_W (3 << (D3DVS_SWIZZLE_SHIFT + 4))")]
    public const int D3DVS_Z_W = (3 << (16 + 4));

    [NativeTypeName("#define D3DVS_W_X (0 << (D3DVS_SWIZZLE_SHIFT + 6))")]
    public const int D3DVS_W_X = (0 << (16 + 6));

    [NativeTypeName("#define D3DVS_W_Y (1 << (D3DVS_SWIZZLE_SHIFT + 6))")]
    public const int D3DVS_W_Y = (1 << (16 + 6));

    [NativeTypeName("#define D3DVS_W_Z (2 << (D3DVS_SWIZZLE_SHIFT + 6))")]
    public const int D3DVS_W_Z = (2 << (16 + 6));

    [NativeTypeName("#define D3DVS_W_W (3 << (D3DVS_SWIZZLE_SHIFT + 6))")]
    public const int D3DVS_W_W = (3 << (16 + 6));

    [NativeTypeName("#define D3DVS_NOSWIZZLE (D3DVS_X_X | D3DVS_Y_Y | D3DVS_Z_Z | D3DVS_W_W)")]
    public const int D3DVS_NOSWIZZLE = (
        (0 << 16) | (1 << (16 + 2)) | (2 << (16 + 4)) | (3 << (16 + 6))
    );
}
