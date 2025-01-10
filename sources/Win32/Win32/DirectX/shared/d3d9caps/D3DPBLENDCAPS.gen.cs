// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DPBLENDCAPS
{
    [NativeTypeName("#define D3DPBLENDCAPS_ZERO 0x00000001L")]
    public const int D3DPBLENDCAPS_ZERO = 0x00000001;

    [NativeTypeName("#define D3DPBLENDCAPS_ONE 0x00000002L")]
    public const int D3DPBLENDCAPS_ONE = 0x00000002;

    [NativeTypeName("#define D3DPBLENDCAPS_SRCCOLOR 0x00000004L")]
    public const int D3DPBLENDCAPS_SRCCOLOR = 0x00000004;

    [NativeTypeName("#define D3DPBLENDCAPS_INVSRCCOLOR 0x00000008L")]
    public const int D3DPBLENDCAPS_INVSRCCOLOR = 0x00000008;

    [NativeTypeName("#define D3DPBLENDCAPS_SRCALPHA 0x00000010L")]
    public const int D3DPBLENDCAPS_SRCALPHA = 0x00000010;

    [NativeTypeName("#define D3DPBLENDCAPS_INVSRCALPHA 0x00000020L")]
    public const int D3DPBLENDCAPS_INVSRCALPHA = 0x00000020;

    [NativeTypeName("#define D3DPBLENDCAPS_DESTALPHA 0x00000040L")]
    public const int D3DPBLENDCAPS_DESTALPHA = 0x00000040;

    [NativeTypeName("#define D3DPBLENDCAPS_INVDESTALPHA 0x00000080L")]
    public const int D3DPBLENDCAPS_INVDESTALPHA = 0x00000080;

    [NativeTypeName("#define D3DPBLENDCAPS_DESTCOLOR 0x00000100L")]
    public const int D3DPBLENDCAPS_DESTCOLOR = 0x00000100;

    [NativeTypeName("#define D3DPBLENDCAPS_INVDESTCOLOR 0x00000200L")]
    public const int D3DPBLENDCAPS_INVDESTCOLOR = 0x00000200;

    [NativeTypeName("#define D3DPBLENDCAPS_SRCALPHASAT 0x00000400L")]
    public const int D3DPBLENDCAPS_SRCALPHASAT = 0x00000400;

    [NativeTypeName("#define D3DPBLENDCAPS_BOTHSRCALPHA 0x00000800L")]
    public const int D3DPBLENDCAPS_BOTHSRCALPHA = 0x00000800;

    [NativeTypeName("#define D3DPBLENDCAPS_BOTHINVSRCALPHA 0x00001000L")]
    public const int D3DPBLENDCAPS_BOTHINVSRCALPHA = 0x00001000;

    [NativeTypeName("#define D3DPBLENDCAPS_BLENDFACTOR 0x00002000L")]
    public const int D3DPBLENDCAPS_BLENDFACTOR = 0x00002000;

    [NativeTypeName("#define D3DPBLENDCAPS_SRCCOLOR2 0x00004000L")]
    public const int D3DPBLENDCAPS_SRCCOLOR2 = 0x00004000;

    [NativeTypeName("#define D3DPBLENDCAPS_INVSRCCOLOR2 0x00008000L")]
    public const int D3DPBLENDCAPS_INVSRCCOLOR2 = 0x00008000;
}
