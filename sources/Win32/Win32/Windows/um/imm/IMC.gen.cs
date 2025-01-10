// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IMC
{
    [NativeTypeName("#define IMC_GETCANDIDATEPOS 0x0007")]
    public const int IMC_GETCANDIDATEPOS = 0x0007;

    [NativeTypeName("#define IMC_SETCANDIDATEPOS 0x0008")]
    public const int IMC_SETCANDIDATEPOS = 0x0008;

    [NativeTypeName("#define IMC_GETCOMPOSITIONFONT 0x0009")]
    public const int IMC_GETCOMPOSITIONFONT = 0x0009;

    [NativeTypeName("#define IMC_SETCOMPOSITIONFONT 0x000A")]
    public const int IMC_SETCOMPOSITIONFONT = 0x000A;

    [NativeTypeName("#define IMC_GETCOMPOSITIONWINDOW 0x000B")]
    public const int IMC_GETCOMPOSITIONWINDOW = 0x000B;

    [NativeTypeName("#define IMC_SETCOMPOSITIONWINDOW 0x000C")]
    public const int IMC_SETCOMPOSITIONWINDOW = 0x000C;

    [NativeTypeName("#define IMC_GETSTATUSWINDOWPOS 0x000F")]
    public const int IMC_GETSTATUSWINDOWPOS = 0x000F;

    [NativeTypeName("#define IMC_SETSTATUSWINDOWPOS 0x0010")]
    public const int IMC_SETSTATUSWINDOWPOS = 0x0010;

    [NativeTypeName("#define IMC_CLOSESTATUSWINDOW 0x0021")]
    public const int IMC_CLOSESTATUSWINDOW = 0x0021;

    [NativeTypeName("#define IMC_OPENSTATUSWINDOW 0x0022")]
    public const int IMC_OPENSTATUSWINDOW = 0x0022;
}
