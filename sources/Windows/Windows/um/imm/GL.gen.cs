// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class GL
{
    [NativeTypeName("#define GL_LEVEL_NOGUIDELINE 0x00000000")]
    public const int GL_LEVEL_NOGUIDELINE = 0x00000000;

    [NativeTypeName("#define GL_LEVEL_FATAL 0x00000001")]
    public const int GL_LEVEL_FATAL = 0x00000001;

    [NativeTypeName("#define GL_LEVEL_ERROR 0x00000002")]
    public const int GL_LEVEL_ERROR = 0x00000002;

    [NativeTypeName("#define GL_LEVEL_WARNING 0x00000003")]
    public const int GL_LEVEL_WARNING = 0x00000003;

    [NativeTypeName("#define GL_LEVEL_INFORMATION 0x00000004")]
    public const int GL_LEVEL_INFORMATION = 0x00000004;

    [NativeTypeName("#define GL_ID_UNKNOWN 0x00000000")]
    public const int GL_ID_UNKNOWN = 0x00000000;

    [NativeTypeName("#define GL_ID_NOMODULE 0x00000001")]
    public const int GL_ID_NOMODULE = 0x00000001;

    [NativeTypeName("#define GL_ID_NODICTIONARY 0x00000010")]
    public const int GL_ID_NODICTIONARY = 0x00000010;

    [NativeTypeName("#define GL_ID_CANNOTSAVE 0x00000011")]
    public const int GL_ID_CANNOTSAVE = 0x00000011;

    [NativeTypeName("#define GL_ID_NOCONVERT 0x00000020")]
    public const int GL_ID_NOCONVERT = 0x00000020;

    [NativeTypeName("#define GL_ID_TYPINGERROR 0x00000021")]
    public const int GL_ID_TYPINGERROR = 0x00000021;

    [NativeTypeName("#define GL_ID_TOOMANYSTROKE 0x00000022")]
    public const int GL_ID_TOOMANYSTROKE = 0x00000022;

    [NativeTypeName("#define GL_ID_READINGCONFLICT 0x00000023")]
    public const int GL_ID_READINGCONFLICT = 0x00000023;

    [NativeTypeName("#define GL_ID_INPUTREADING 0x00000024")]
    public const int GL_ID_INPUTREADING = 0x00000024;

    [NativeTypeName("#define GL_ID_INPUTRADICAL 0x00000025")]
    public const int GL_ID_INPUTRADICAL = 0x00000025;

    [NativeTypeName("#define GL_ID_INPUTCODE 0x00000026")]
    public const int GL_ID_INPUTCODE = 0x00000026;

    [NativeTypeName("#define GL_ID_INPUTSYMBOL 0x00000027")]
    public const int GL_ID_INPUTSYMBOL = 0x00000027;

    [NativeTypeName("#define GL_ID_CHOOSECANDIDATE 0x00000028")]
    public const int GL_ID_CHOOSECANDIDATE = 0x00000028;

    [NativeTypeName("#define GL_ID_REVERSECONVERSION 0x00000029")]
    public const int GL_ID_REVERSECONVERSION = 0x00000029;

    [NativeTypeName("#define GL_ID_PRIVATE_FIRST 0x00008000")]
    public const int GL_ID_PRIVATE_FIRST = 0x00008000;

    [NativeTypeName("#define GL_ID_PRIVATE_LAST 0x0000FFFF")]
    public const int GL_ID_PRIVATE_LAST = 0x0000FFFF;
}
