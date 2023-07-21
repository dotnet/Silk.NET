// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SEF
{
    [NativeTypeName("#define SEF_DACL_AUTO_INHERIT 0x01")]
    public const int SEF_DACL_AUTO_INHERIT = 0x01;

    [NativeTypeName("#define SEF_SACL_AUTO_INHERIT 0x02")]
    public const int SEF_SACL_AUTO_INHERIT = 0x02;

    [NativeTypeName("#define SEF_DEFAULT_DESCRIPTOR_FOR_OBJECT 0x04")]
    public const int SEF_DEFAULT_DESCRIPTOR_FOR_OBJECT = 0x04;

    [NativeTypeName("#define SEF_AVOID_PRIVILEGE_CHECK 0x08")]
    public const int SEF_AVOID_PRIVILEGE_CHECK = 0x08;

    [NativeTypeName("#define SEF_AVOID_OWNER_CHECK 0x10")]
    public const int SEF_AVOID_OWNER_CHECK = 0x10;

    [NativeTypeName("#define SEF_DEFAULT_OWNER_FROM_PARENT 0x20")]
    public const int SEF_DEFAULT_OWNER_FROM_PARENT = 0x20;

    [NativeTypeName("#define SEF_DEFAULT_GROUP_FROM_PARENT 0x40")]
    public const int SEF_DEFAULT_GROUP_FROM_PARENT = 0x40;

    [NativeTypeName("#define SEF_MACL_NO_WRITE_UP 0x100")]
    public const int SEF_MACL_NO_WRITE_UP = 0x100;

    [NativeTypeName("#define SEF_MACL_NO_READ_UP 0x200")]
    public const int SEF_MACL_NO_READ_UP = 0x200;

    [NativeTypeName("#define SEF_MACL_NO_EXECUTE_UP 0x400")]
    public const int SEF_MACL_NO_EXECUTE_UP = 0x400;

    [NativeTypeName("#define SEF_AI_USE_EXTRA_PARAMS 0x800")]
    public const int SEF_AI_USE_EXTRA_PARAMS = 0x800;

    [NativeTypeName("#define SEF_AVOID_OWNER_RESTRICTION 0x1000")]
    public const int SEF_AVOID_OWNER_RESTRICTION = 0x1000;

    [NativeTypeName("#define SEF_FORCE_USER_MODE 0x2000")]
    public const int SEF_FORCE_USER_MODE = 0x2000;

    [NativeTypeName("#define SEF_NORMALIZE_OUTPUT_DESCRIPTOR 0x4000")]
    public const int SEF_NORMALIZE_OUTPUT_DESCRIPTOR = 0x4000;

    [NativeTypeName("#define SEF_MACL_VALID_FLAGS (SEF_MACL_NO_WRITE_UP   | \\\r\n                                           SEF_MACL_NO_READ_UP    | \\\r\n                                           SEF_MACL_NO_EXECUTE_UP)")]
    public const int SEF_MACL_VALID_FLAGS = (0x100 | 0x200 | 0x400);
}
