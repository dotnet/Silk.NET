// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CREDUIWIN
{
    [NativeTypeName("#define CREDUIWIN_GENERIC 0x00000001")]
    public const int CREDUIWIN_GENERIC = 0x00000001;

    [NativeTypeName("#define CREDUIWIN_CHECKBOX 0x00000002")]
    public const int CREDUIWIN_CHECKBOX = 0x00000002;

    [NativeTypeName("#define CREDUIWIN_AUTHPACKAGE_ONLY 0x00000010")]
    public const int CREDUIWIN_AUTHPACKAGE_ONLY = 0x00000010;

    [NativeTypeName("#define CREDUIWIN_IN_CRED_ONLY 0x00000020")]
    public const int CREDUIWIN_IN_CRED_ONLY = 0x00000020;

    [NativeTypeName("#define CREDUIWIN_ENUMERATE_ADMINS 0x00000100")]
    public const int CREDUIWIN_ENUMERATE_ADMINS = 0x00000100;

    [NativeTypeName("#define CREDUIWIN_ENUMERATE_CURRENT_USER 0x00000200")]
    public const int CREDUIWIN_ENUMERATE_CURRENT_USER = 0x00000200;

    [NativeTypeName("#define CREDUIWIN_SECURE_PROMPT 0x00001000")]
    public const int CREDUIWIN_SECURE_PROMPT = 0x00001000;

    [NativeTypeName("#define CREDUIWIN_PREPROMPTING 0X00002000")]
    public const int CREDUIWIN_PREPROMPTING = 0X00002000;

    [NativeTypeName("#define CREDUIWIN_PACK_32_WOW 0x10000000")]
    public const int CREDUIWIN_PACK_32_WOW = 0x10000000;

    [NativeTypeName("#define CREDUIWIN_USE_V2 0x00000040")]
    public const int CREDUIWIN_USE_V2 = 0x00000040;

    [NativeTypeName("#define CREDUIWIN_IGNORE_CLOUDAUTHORITY_NAME 0x00040000")]
    public const int CREDUIWIN_IGNORE_CLOUDAUTHORITY_NAME = 0x00040000;

    [NativeTypeName("#define CREDUIWIN_DOWNLEVEL_HELLO_AS_SMART_CARD 0x80000000")]
    public const uint CREDUIWIN_DOWNLEVEL_HELLO_AS_SMART_CARD = 0x80000000;

    [NativeTypeName(
        "#define CREDUIWIN_VALID_FLAGS ( \\\r\n        CREDUIWIN_GENERIC                | \\\r\n        CREDUIWIN_CHECKBOX               | \\\r\n        CREDUIWIN_AUTHPACKAGE_ONLY       | \\\r\n        CREDUIWIN_IN_CRED_ONLY           | \\\r\n        CREDUIWIN_ENUMERATE_ADMINS       | \\\r\n        CREDUIWIN_ENUMERATE_CURRENT_USER | \\\r\n        CREDUIWIN_SECURE_PROMPT          | \\\r\n        CREDUIWIN_PREPROMPTING           | \\\r\n        CREDUIWIN_PACK_32_WOW            | \\\r\n        CREDUIWIN_IGNORE_CLOUDAUTHORITY_NAME    | \\\r\n        CREDUIWIN_DOWNLEVEL_HELLO_AS_SMART_CARD )"
    )]
    public const uint CREDUIWIN_VALID_FLAGS = (
        0x00000001
        | 0x00000002
        | 0x00000010
        | 0x00000020
        | 0x00000100
        | 0x00000200
        | 0x00001000
        | 0X00002000
        | 0x10000000
        | 0x00040000
        | 0x80000000
    );
}
