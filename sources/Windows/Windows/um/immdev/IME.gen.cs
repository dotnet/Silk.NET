// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class IME
{
    [NativeTypeName("#define IME_SYSINFO_WINLOGON 0x0001")]
    public const int IME_SYSINFO_WINLOGON = 0x0001;

    [NativeTypeName("#define IME_PROP_END_UNLOAD 0x00000001")]
    public const int IME_PROP_END_UNLOAD = 0x00000001;

    [NativeTypeName("#define IME_PROP_KBD_CHAR_FIRST 0x00000002")]
    public const int IME_PROP_KBD_CHAR_FIRST = 0x00000002;

    [NativeTypeName("#define IME_PROP_IGNORE_UPKEYS 0x00000004")]
    public const int IME_PROP_IGNORE_UPKEYS = 0x00000004;

    [NativeTypeName("#define IME_PROP_NEED_ALTKEY 0x00000008")]
    public const int IME_PROP_NEED_ALTKEY = 0x00000008;

    [NativeTypeName("#define IME_PROP_NO_KEYS_ON_CLOSE 0x00000010")]
    public const int IME_PROP_NO_KEYS_ON_CLOSE = 0x00000010;

    [NativeTypeName("#define IME_PROP_ACCEPT_WIDE_VKEY 0x00000020")]
    public const int IME_PROP_ACCEPT_WIDE_VKEY = 0x00000020;

    [NativeTypeName("#define IME_UI_CLASS_NAME_SIZE 16")]
    public const int IME_UI_CLASS_NAME_SIZE = 16;

    [NativeTypeName("#define IME_ESC_STRING_BUFFER_SIZE 80")]
    public const int IME_ESC_STRING_BUFFER_SIZE = 80;
}
