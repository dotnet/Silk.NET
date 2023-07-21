// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class REG
{
    [NativeTypeName("#define REG_PROCESS_APPKEY 0x00000001")]
    public const int REG_PROCESS_APPKEY = 0x00000001;

    [NativeTypeName("#define REG_USE_CURRENT_SECURITY_CONTEXT 0x00000002")]
    public const int REG_USE_CURRENT_SECURITY_CONTEXT = 0x00000002;

    [NativeTypeName("#define REG_MUI_STRING_TRUNCATE 0x00000001")]
    public const int REG_MUI_STRING_TRUNCATE = 0x00000001;

    [NativeTypeName("#define REG_SECURE_CONNECTION 1")]
    public const int REG_SECURE_CONNECTION = 1;
}
