// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DPSHADECAPS
{
    [NativeTypeName("#define D3DPSHADECAPS_COLORGOURAUDRGB 0x00000008L")]
    public const int D3DPSHADECAPS_COLORGOURAUDRGB = 0x00000008;

    [NativeTypeName("#define D3DPSHADECAPS_SPECULARGOURAUDRGB 0x00000200L")]
    public const int D3DPSHADECAPS_SPECULARGOURAUDRGB = 0x00000200;

    [NativeTypeName("#define D3DPSHADECAPS_ALPHAGOURAUDBLEND 0x00004000L")]
    public const int D3DPSHADECAPS_ALPHAGOURAUDBLEND = 0x00004000;

    [NativeTypeName("#define D3DPSHADECAPS_FOGGOURAUD 0x00080000L")]
    public const int D3DPSHADECAPS_FOGGOURAUD = 0x00080000;
}
