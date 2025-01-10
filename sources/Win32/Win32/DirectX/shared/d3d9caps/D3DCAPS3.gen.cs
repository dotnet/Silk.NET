// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DCAPS3
{
    [NativeTypeName("#define D3DCAPS3_RESERVED 0x8000001fL")]
    public const uint D3DCAPS3_RESERVED = 0x8000001f;

    [NativeTypeName("#define D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD 0x00000020L")]
    public const int D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD = 0x00000020;

    [NativeTypeName("#define D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION 0x00000080L")]
    public const int D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION = 0x00000080;

    [NativeTypeName("#define D3DCAPS3_COPY_TO_VIDMEM 0x00000100L")]
    public const int D3DCAPS3_COPY_TO_VIDMEM = 0x00000100;

    [NativeTypeName("#define D3DCAPS3_COPY_TO_SYSTEMMEM 0x00000200L")]
    public const int D3DCAPS3_COPY_TO_SYSTEMMEM = 0x00000200;

    [NativeTypeName("#define D3DCAPS3_DXVAHD 0x00000400L")]
    public const int D3DCAPS3_DXVAHD = 0x00000400;

    [NativeTypeName("#define D3DCAPS3_DXVAHD_LIMITED 0x00000800L")]
    public const int D3DCAPS3_DXVAHD_LIMITED = 0x00000800;
}
