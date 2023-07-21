// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class OBJ
{
    [NativeTypeName("#define OBJ_INHERIT 0x00000002L")]
    public const int OBJ_INHERIT = 0x00000002;

    [NativeTypeName("#define OBJ_PERMANENT 0x00000010L")]
    public const int OBJ_PERMANENT = 0x00000010;

    [NativeTypeName("#define OBJ_EXCLUSIVE 0x00000020L")]
    public const int OBJ_EXCLUSIVE = 0x00000020;

    [NativeTypeName("#define OBJ_CASE_INSENSITIVE 0x00000040L")]
    public const int OBJ_CASE_INSENSITIVE = 0x00000040;

    [NativeTypeName("#define OBJ_OPENIF 0x00000080L")]
    public const int OBJ_OPENIF = 0x00000080;

    [NativeTypeName("#define OBJ_OPENLINK 0x00000100L")]
    public const int OBJ_OPENLINK = 0x00000100;

    [NativeTypeName("#define OBJ_KERNEL_HANDLE 0x00000200L")]
    public const int OBJ_KERNEL_HANDLE = 0x00000200;

    [NativeTypeName("#define OBJ_FORCE_ACCESS_CHECK 0x00000400L")]
    public const int OBJ_FORCE_ACCESS_CHECK = 0x00000400;

    [NativeTypeName("#define OBJ_IGNORE_IMPERSONATED_DEVICEMAP 0x00000800L")]
    public const int OBJ_IGNORE_IMPERSONATED_DEVICEMAP = 0x00000800;

    [NativeTypeName("#define OBJ_DONT_REPARSE 0x00001000L")]
    public const int OBJ_DONT_REPARSE = 0x00001000;

    [NativeTypeName("#define OBJ_VALID_ATTRIBUTES 0x00001FF2L")]
    public const int OBJ_VALID_ATTRIBUTES = 0x00001FF2;
}
