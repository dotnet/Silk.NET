// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3DOVERLAYCAPS
{
    public uint Caps;
    public uint MaxOverlayDisplayWidth;
    public uint MaxOverlayDisplayHeight;

    [NativeTypeName("#define D3DOVERLAYCAPS_FULLRANGERGB 0x00000001")]
    public const int D3DOVERLAYCAPS_FULLRANGERGB = 0x00000001;

    [NativeTypeName("#define D3DOVERLAYCAPS_LIMITEDRANGERGB 0x00000002")]
    public const int D3DOVERLAYCAPS_LIMITEDRANGERGB = 0x00000002;

    [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT601 0x00000004")]
    public const int D3DOVERLAYCAPS_YCbCr_BT601 = 0x00000004;

    [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT709 0x00000008")]
    public const int D3DOVERLAYCAPS_YCbCr_BT709 = 0x00000008;

    [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT601_xvYCC 0x00000010")]
    public const int D3DOVERLAYCAPS_YCbCr_BT601_xvYCC = 0x00000010;

    [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT709_xvYCC 0x00000020")]
    public const int D3DOVERLAYCAPS_YCbCr_BT709_xvYCC = 0x00000020;

    [NativeTypeName("#define D3DOVERLAYCAPS_STRETCHX 0x00000040")]
    public const int D3DOVERLAYCAPS_STRETCHX = 0x00000040;

    [NativeTypeName("#define D3DOVERLAYCAPS_STRETCHY 0x00000080")]
    public const int D3DOVERLAYCAPS_STRETCHY = 0x00000080;
}
