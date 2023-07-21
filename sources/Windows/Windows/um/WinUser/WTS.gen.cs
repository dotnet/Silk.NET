// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WTS
{
    [NativeTypeName("#define WTS_CONSOLE_CONNECT 0x1")]
    public const int WTS_CONSOLE_CONNECT = 0x1;

    [NativeTypeName("#define WTS_CONSOLE_DISCONNECT 0x2")]
    public const int WTS_CONSOLE_DISCONNECT = 0x2;

    [NativeTypeName("#define WTS_REMOTE_CONNECT 0x3")]
    public const int WTS_REMOTE_CONNECT = 0x3;

    [NativeTypeName("#define WTS_REMOTE_DISCONNECT 0x4")]
    public const int WTS_REMOTE_DISCONNECT = 0x4;

    [NativeTypeName("#define WTS_SESSION_LOGON 0x5")]
    public const int WTS_SESSION_LOGON = 0x5;

    [NativeTypeName("#define WTS_SESSION_LOGOFF 0x6")]
    public const int WTS_SESSION_LOGOFF = 0x6;

    [NativeTypeName("#define WTS_SESSION_LOCK 0x7")]
    public const int WTS_SESSION_LOCK = 0x7;

    [NativeTypeName("#define WTS_SESSION_UNLOCK 0x8")]
    public const int WTS_SESSION_UNLOCK = 0x8;

    [NativeTypeName("#define WTS_SESSION_REMOTE_CONTROL 0x9")]
    public const int WTS_SESSION_REMOTE_CONTROL = 0x9;

    [NativeTypeName("#define WTS_SESSION_CREATE 0xa")]
    public const int WTS_SESSION_CREATE = 0xa;

    [NativeTypeName("#define WTS_SESSION_TERMINATE 0xb")]
    public const int WTS_SESSION_TERMINATE = 0xb;
}
