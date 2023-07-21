// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ENABLE
{
    [NativeTypeName("#define ENABLE_PROCESSED_INPUT 0x0001")]
    public const int ENABLE_PROCESSED_INPUT = 0x0001;

    [NativeTypeName("#define ENABLE_LINE_INPUT 0x0002")]
    public const int ENABLE_LINE_INPUT = 0x0002;

    [NativeTypeName("#define ENABLE_ECHO_INPUT 0x0004")]
    public const int ENABLE_ECHO_INPUT = 0x0004;

    [NativeTypeName("#define ENABLE_WINDOW_INPUT 0x0008")]
    public const int ENABLE_WINDOW_INPUT = 0x0008;

    [NativeTypeName("#define ENABLE_MOUSE_INPUT 0x0010")]
    public const int ENABLE_MOUSE_INPUT = 0x0010;

    [NativeTypeName("#define ENABLE_INSERT_MODE 0x0020")]
    public const int ENABLE_INSERT_MODE = 0x0020;

    [NativeTypeName("#define ENABLE_QUICK_EDIT_MODE 0x0040")]
    public const int ENABLE_QUICK_EDIT_MODE = 0x0040;

    [NativeTypeName("#define ENABLE_EXTENDED_FLAGS 0x0080")]
    public const int ENABLE_EXTENDED_FLAGS = 0x0080;

    [NativeTypeName("#define ENABLE_AUTO_POSITION 0x0100")]
    public const int ENABLE_AUTO_POSITION = 0x0100;

    [NativeTypeName("#define ENABLE_VIRTUAL_TERMINAL_INPUT 0x0200")]
    public const int ENABLE_VIRTUAL_TERMINAL_INPUT = 0x0200;

    [NativeTypeName("#define ENABLE_PROCESSED_OUTPUT 0x0001")]
    public const int ENABLE_PROCESSED_OUTPUT = 0x0001;

    [NativeTypeName("#define ENABLE_WRAP_AT_EOL_OUTPUT 0x0002")]
    public const int ENABLE_WRAP_AT_EOL_OUTPUT = 0x0002;

    [NativeTypeName("#define ENABLE_VIRTUAL_TERMINAL_PROCESSING 0x0004")]
    public const int ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;

    [NativeTypeName("#define ENABLE_LVB_GRID_WORLDWIDE 0x0010")]
    public const int ENABLE_LVB_GRID_WORLDWIDE = 0x0010;
}
