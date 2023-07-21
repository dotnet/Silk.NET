// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class TBIF
{
    [NativeTypeName("#define TBIF_IMAGE 0x00000001")]
    public const int TBIF_IMAGE = 0x00000001;

    [NativeTypeName("#define TBIF_TEXT 0x00000002")]
    public const int TBIF_TEXT = 0x00000002;

    [NativeTypeName("#define TBIF_STATE 0x00000004")]
    public const int TBIF_STATE = 0x00000004;

    [NativeTypeName("#define TBIF_STYLE 0x00000008")]
    public const int TBIF_STYLE = 0x00000008;

    [NativeTypeName("#define TBIF_LPARAM 0x00000010")]
    public const int TBIF_LPARAM = 0x00000010;

    [NativeTypeName("#define TBIF_COMMAND 0x00000020")]
    public const int TBIF_COMMAND = 0x00000020;

    [NativeTypeName("#define TBIF_SIZE 0x00000040")]
    public const int TBIF_SIZE = 0x00000040;

    [NativeTypeName("#define TBIF_BYINDEX 0x80000000")]
    public const uint TBIF_BYINDEX = 0x80000000;
}
