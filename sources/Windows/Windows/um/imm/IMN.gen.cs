// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class IMN
{
    [NativeTypeName("#define IMN_CLOSESTATUSWINDOW 0x0001")]
    public const int IMN_CLOSESTATUSWINDOW = 0x0001;
    [NativeTypeName("#define IMN_OPENSTATUSWINDOW 0x0002")]
    public const int IMN_OPENSTATUSWINDOW = 0x0002;
    [NativeTypeName("#define IMN_CHANGECANDIDATE 0x0003")]
    public const int IMN_CHANGECANDIDATE = 0x0003;
    [NativeTypeName("#define IMN_CLOSECANDIDATE 0x0004")]
    public const int IMN_CLOSECANDIDATE = 0x0004;
    [NativeTypeName("#define IMN_OPENCANDIDATE 0x0005")]
    public const int IMN_OPENCANDIDATE = 0x0005;
    [NativeTypeName("#define IMN_SETCONVERSIONMODE 0x0006")]
    public const int IMN_SETCONVERSIONMODE = 0x0006;
    [NativeTypeName("#define IMN_SETSENTENCEMODE 0x0007")]
    public const int IMN_SETSENTENCEMODE = 0x0007;
    [NativeTypeName("#define IMN_SETOPENSTATUS 0x0008")]
    public const int IMN_SETOPENSTATUS = 0x0008;
    [NativeTypeName("#define IMN_SETCANDIDATEPOS 0x0009")]
    public const int IMN_SETCANDIDATEPOS = 0x0009;
    [NativeTypeName("#define IMN_SETCOMPOSITIONFONT 0x000A")]
    public const int IMN_SETCOMPOSITIONFONT = 0x000A;
    [NativeTypeName("#define IMN_SETCOMPOSITIONWINDOW 0x000B")]
    public const int IMN_SETCOMPOSITIONWINDOW = 0x000B;
    [NativeTypeName("#define IMN_SETSTATUSWINDOWPOS 0x000C")]
    public const int IMN_SETSTATUSWINDOWPOS = 0x000C;
    [NativeTypeName("#define IMN_GUIDELINE 0x000D")]
    public const int IMN_GUIDELINE = 0x000D;
    [NativeTypeName("#define IMN_PRIVATE 0x000E")]
    public const int IMN_PRIVATE = 0x000E;
}