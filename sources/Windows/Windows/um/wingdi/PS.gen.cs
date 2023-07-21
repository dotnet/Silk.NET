// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class PS
{
    [NativeTypeName("#define PS_SOLID 0")]
    public const int PS_SOLID = 0;

    [NativeTypeName("#define PS_DASH 1")]
    public const int PS_DASH = 1;

    [NativeTypeName("#define PS_DOT 2")]
    public const int PS_DOT = 2;

    [NativeTypeName("#define PS_DASHDOT 3")]
    public const int PS_DASHDOT = 3;

    [NativeTypeName("#define PS_DASHDOTDOT 4")]
    public const int PS_DASHDOTDOT = 4;

    [NativeTypeName("#define PS_NULL 5")]
    public const int PS_NULL = 5;

    [NativeTypeName("#define PS_INSIDEFRAME 6")]
    public const int PS_INSIDEFRAME = 6;

    [NativeTypeName("#define PS_USERSTYLE 7")]
    public const int PS_USERSTYLE = 7;

    [NativeTypeName("#define PS_ALTERNATE 8")]
    public const int PS_ALTERNATE = 8;

    [NativeTypeName("#define PS_STYLE_MASK 0x0000000F")]
    public const int PS_STYLE_MASK = 0x0000000F;

    [NativeTypeName("#define PS_ENDCAP_ROUND 0x00000000")]
    public const int PS_ENDCAP_ROUND = 0x00000000;

    [NativeTypeName("#define PS_ENDCAP_SQUARE 0x00000100")]
    public const int PS_ENDCAP_SQUARE = 0x00000100;

    [NativeTypeName("#define PS_ENDCAP_FLAT 0x00000200")]
    public const int PS_ENDCAP_FLAT = 0x00000200;

    [NativeTypeName("#define PS_ENDCAP_MASK 0x00000F00")]
    public const int PS_ENDCAP_MASK = 0x00000F00;

    [NativeTypeName("#define PS_JOIN_ROUND 0x00000000")]
    public const int PS_JOIN_ROUND = 0x00000000;

    [NativeTypeName("#define PS_JOIN_BEVEL 0x00001000")]
    public const int PS_JOIN_BEVEL = 0x00001000;

    [NativeTypeName("#define PS_JOIN_MITER 0x00002000")]
    public const int PS_JOIN_MITER = 0x00002000;

    [NativeTypeName("#define PS_JOIN_MASK 0x0000F000")]
    public const int PS_JOIN_MASK = 0x0000F000;

    [NativeTypeName("#define PS_COSMETIC 0x00000000")]
    public const int PS_COSMETIC = 0x00000000;

    [NativeTypeName("#define PS_GEOMETRIC 0x00010000")]
    public const int PS_GEOMETRIC = 0x00010000;

    [NativeTypeName("#define PS_TYPE_MASK 0x000F0000")]
    public const int PS_TYPE_MASK = 0x000F0000;
}
