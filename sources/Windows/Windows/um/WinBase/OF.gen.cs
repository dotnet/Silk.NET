// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class OF
{
    [NativeTypeName("#define OF_READ 0x00000000")]
    public const int OF_READ = 0x00000000;

    [NativeTypeName("#define OF_WRITE 0x00000001")]
    public const int OF_WRITE = 0x00000001;

    [NativeTypeName("#define OF_READWRITE 0x00000002")]
    public const int OF_READWRITE = 0x00000002;

    [NativeTypeName("#define OF_SHARE_COMPAT 0x00000000")]
    public const int OF_SHARE_COMPAT = 0x00000000;

    [NativeTypeName("#define OF_SHARE_EXCLUSIVE 0x00000010")]
    public const int OF_SHARE_EXCLUSIVE = 0x00000010;

    [NativeTypeName("#define OF_SHARE_DENY_WRITE 0x00000020")]
    public const int OF_SHARE_DENY_WRITE = 0x00000020;

    [NativeTypeName("#define OF_SHARE_DENY_READ 0x00000030")]
    public const int OF_SHARE_DENY_READ = 0x00000030;

    [NativeTypeName("#define OF_SHARE_DENY_NONE 0x00000040")]
    public const int OF_SHARE_DENY_NONE = 0x00000040;

    [NativeTypeName("#define OF_PARSE 0x00000100")]
    public const int OF_PARSE = 0x00000100;

    [NativeTypeName("#define OF_DELETE 0x00000200")]
    public const int OF_DELETE = 0x00000200;

    [NativeTypeName("#define OF_VERIFY 0x00000400")]
    public const int OF_VERIFY = 0x00000400;

    [NativeTypeName("#define OF_CANCEL 0x00000800")]
    public const int OF_CANCEL = 0x00000800;

    [NativeTypeName("#define OF_CREATE 0x00001000")]
    public const int OF_CREATE = 0x00001000;

    [NativeTypeName("#define OF_PROMPT 0x00002000")]
    public const int OF_PROMPT = 0x00002000;

    [NativeTypeName("#define OF_EXIST 0x00004000")]
    public const int OF_EXIST = 0x00004000;

    [NativeTypeName("#define OF_REOPEN 0x00008000")]
    public const int OF_REOPEN = 0x00008000;
}
