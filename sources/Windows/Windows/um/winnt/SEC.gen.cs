// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SEC
{
    [NativeTypeName("#define SEC_HUGE_PAGES 0x00020000")]
    public const int SEC_HUGE_PAGES = 0x00020000;

    [NativeTypeName("#define SEC_PARTITION_OWNER_HANDLE 0x00040000")]
    public const int SEC_PARTITION_OWNER_HANDLE = 0x00040000;

    [NativeTypeName("#define SEC_64K_PAGES 0x00080000")]
    public const int SEC_64K_PAGES = 0x00080000;

    [NativeTypeName("#define SEC_FILE 0x00800000")]
    public const int SEC_FILE = 0x00800000;

    [NativeTypeName("#define SEC_IMAGE 0x01000000")]
    public const int SEC_IMAGE = 0x01000000;

    [NativeTypeName("#define SEC_PROTECTED_IMAGE 0x02000000")]
    public const int SEC_PROTECTED_IMAGE = 0x02000000;

    [NativeTypeName("#define SEC_RESERVE 0x04000000")]
    public const int SEC_RESERVE = 0x04000000;

    [NativeTypeName("#define SEC_COMMIT 0x08000000")]
    public const int SEC_COMMIT = 0x08000000;

    [NativeTypeName("#define SEC_NOCACHE 0x10000000")]
    public const int SEC_NOCACHE = 0x10000000;

    [NativeTypeName("#define SEC_WRITECOMBINE 0x40000000")]
    public const int SEC_WRITECOMBINE = 0x40000000;

    [NativeTypeName("#define SEC_LARGE_PAGES 0x80000000")]
    public const uint SEC_LARGE_PAGES = 0x80000000;

    [NativeTypeName("#define SEC_IMAGE_NO_EXECUTE (SEC_IMAGE | SEC_NOCACHE)")]
    public const int SEC_IMAGE_NO_EXECUTE = (0x01000000 | 0x10000000);
}
