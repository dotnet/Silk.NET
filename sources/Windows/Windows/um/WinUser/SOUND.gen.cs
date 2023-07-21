// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SOUND
{
    [NativeTypeName("#define SOUND_SYSTEM_STARTUP 1")]
    public const int SOUND_SYSTEM_STARTUP = 1;

    [NativeTypeName("#define SOUND_SYSTEM_SHUTDOWN 2")]
    public const int SOUND_SYSTEM_SHUTDOWN = 2;

    [NativeTypeName("#define SOUND_SYSTEM_BEEP 3")]
    public const int SOUND_SYSTEM_BEEP = 3;

    [NativeTypeName("#define SOUND_SYSTEM_ERROR 4")]
    public const int SOUND_SYSTEM_ERROR = 4;

    [NativeTypeName("#define SOUND_SYSTEM_QUESTION 5")]
    public const int SOUND_SYSTEM_QUESTION = 5;

    [NativeTypeName("#define SOUND_SYSTEM_WARNING 6")]
    public const int SOUND_SYSTEM_WARNING = 6;

    [NativeTypeName("#define SOUND_SYSTEM_INFORMATION 7")]
    public const int SOUND_SYSTEM_INFORMATION = 7;

    [NativeTypeName("#define SOUND_SYSTEM_MAXIMIZE 8")]
    public const int SOUND_SYSTEM_MAXIMIZE = 8;

    [NativeTypeName("#define SOUND_SYSTEM_MINIMIZE 9")]
    public const int SOUND_SYSTEM_MINIMIZE = 9;

    [NativeTypeName("#define SOUND_SYSTEM_RESTOREUP 10")]
    public const int SOUND_SYSTEM_RESTOREUP = 10;

    [NativeTypeName("#define SOUND_SYSTEM_RESTOREDOWN 11")]
    public const int SOUND_SYSTEM_RESTOREDOWN = 11;

    [NativeTypeName("#define SOUND_SYSTEM_APPSTART 12")]
    public const int SOUND_SYSTEM_APPSTART = 12;

    [NativeTypeName("#define SOUND_SYSTEM_FAULT 13")]
    public const int SOUND_SYSTEM_FAULT = 13;

    [NativeTypeName("#define SOUND_SYSTEM_APPEND 14")]
    public const int SOUND_SYSTEM_APPEND = 14;

    [NativeTypeName("#define SOUND_SYSTEM_MENUCOMMAND 15")]
    public const int SOUND_SYSTEM_MENUCOMMAND = 15;

    [NativeTypeName("#define SOUND_SYSTEM_MENUPOPUP 16")]
    public const int SOUND_SYSTEM_MENUPOPUP = 16;
}
