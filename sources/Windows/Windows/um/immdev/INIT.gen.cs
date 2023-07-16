// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class INIT
{
    [NativeTypeName("#define INIT_STATUSWNDPOS 0x00000001")]
    public const int INIT_STATUSWNDPOS = 0x00000001;
    [NativeTypeName("#define INIT_CONVERSION 0x00000002")]
    public const int INIT_CONVERSION = 0x00000002;
    [NativeTypeName("#define INIT_SENTENCE 0x00000004")]
    public const int INIT_SENTENCE = 0x00000004;
    [NativeTypeName("#define INIT_LOGFONT 0x00000008")]
    public const int INIT_LOGFONT = 0x00000008;
    [NativeTypeName("#define INIT_COMPFORM 0x00000010")]
    public const int INIT_COMPFORM = 0x00000010;
    [NativeTypeName("#define INIT_SOFTKBDPOS 0x00000020")]
    public const int INIT_SOFTKBDPOS = 0x00000020;
}