// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DCS
{
    [NativeTypeName("#define D3DCS_LEFT 0x00000001L")]
    public const int D3DCS_LEFT = 0x00000001;

    [NativeTypeName("#define D3DCS_RIGHT 0x00000002L")]
    public const int D3DCS_RIGHT = 0x00000002;

    [NativeTypeName("#define D3DCS_TOP 0x00000004L")]
    public const int D3DCS_TOP = 0x00000004;

    [NativeTypeName("#define D3DCS_BOTTOM 0x00000008L")]
    public const int D3DCS_BOTTOM = 0x00000008;

    [NativeTypeName("#define D3DCS_FRONT 0x00000010L")]
    public const int D3DCS_FRONT = 0x00000010;

    [NativeTypeName("#define D3DCS_BACK 0x00000020L")]
    public const int D3DCS_BACK = 0x00000020;

    [NativeTypeName("#define D3DCS_PLANE0 0x00000040L")]
    public const int D3DCS_PLANE0 = 0x00000040;

    [NativeTypeName("#define D3DCS_PLANE1 0x00000080L")]
    public const int D3DCS_PLANE1 = 0x00000080;

    [NativeTypeName("#define D3DCS_PLANE2 0x00000100L")]
    public const int D3DCS_PLANE2 = 0x00000100;

    [NativeTypeName("#define D3DCS_PLANE3 0x00000200L")]
    public const int D3DCS_PLANE3 = 0x00000200;

    [NativeTypeName("#define D3DCS_PLANE4 0x00000400L")]
    public const int D3DCS_PLANE4 = 0x00000400;

    [NativeTypeName("#define D3DCS_PLANE5 0x00000800L")]
    public const int D3DCS_PLANE5 = 0x00000800;

    [NativeTypeName(
        "#define D3DCS_ALL (D3DCS_LEFT   | \\\r\n                   D3DCS_RIGHT  | \\\r\n                   D3DCS_TOP    | \\\r\n                   D3DCS_BOTTOM | \\\r\n                   D3DCS_FRONT  | \\\r\n                   D3DCS_BACK   | \\\r\n                   D3DCS_PLANE0 | \\\r\n                   D3DCS_PLANE1 | \\\r\n                   D3DCS_PLANE2 | \\\r\n                   D3DCS_PLANE3 | \\\r\n                   D3DCS_PLANE4 | \\\r\n                   D3DCS_PLANE5)"
    )]
    public const int D3DCS_ALL = (
        0x00000001
        | 0x00000002
        | 0x00000004
        | 0x00000008
        | 0x00000010
        | 0x00000020
        | 0x00000040
        | 0x00000080
        | 0x00000100
        | 0x00000200
        | 0x00000400
        | 0x00000800
    );
}
