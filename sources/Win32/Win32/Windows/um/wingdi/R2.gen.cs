// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class R2
{
    [NativeTypeName("#define R2_BLACK 1")]
    public const int R2_BLACK = 1;

    [NativeTypeName("#define R2_NOTMERGEPEN 2")]
    public const int R2_NOTMERGEPEN = 2;

    [NativeTypeName("#define R2_MASKNOTPEN 3")]
    public const int R2_MASKNOTPEN = 3;

    [NativeTypeName("#define R2_NOTCOPYPEN 4")]
    public const int R2_NOTCOPYPEN = 4;

    [NativeTypeName("#define R2_MASKPENNOT 5")]
    public const int R2_MASKPENNOT = 5;

    [NativeTypeName("#define R2_NOT 6")]
    public const int R2_NOT = 6;

    [NativeTypeName("#define R2_XORPEN 7")]
    public const int R2_XORPEN = 7;

    [NativeTypeName("#define R2_NOTMASKPEN 8")]
    public const int R2_NOTMASKPEN = 8;

    [NativeTypeName("#define R2_MASKPEN 9")]
    public const int R2_MASKPEN = 9;

    [NativeTypeName("#define R2_NOTXORPEN 10")]
    public const int R2_NOTXORPEN = 10;

    [NativeTypeName("#define R2_NOP 11")]
    public const int R2_NOP = 11;

    [NativeTypeName("#define R2_MERGENOTPEN 12")]
    public const int R2_MERGENOTPEN = 12;

    [NativeTypeName("#define R2_COPYPEN 13")]
    public const int R2_COPYPEN = 13;

    [NativeTypeName("#define R2_MERGEPENNOT 14")]
    public const int R2_MERGEPENNOT = 14;

    [NativeTypeName("#define R2_MERGEPEN 15")]
    public const int R2_MERGEPEN = 15;

    [NativeTypeName("#define R2_WHITE 16")]
    public const int R2_WHITE = 16;

    [NativeTypeName("#define R2_LAST 16")]
    public const int R2_LAST = 16;
}
