// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MEM
{
    [NativeTypeName("#define MEM_COMMIT 0x00001000")]
    public const int MEM_COMMIT = 0x00001000;

    [NativeTypeName("#define MEM_RESERVE 0x00002000")]
    public const int MEM_RESERVE = 0x00002000;

    [NativeTypeName("#define MEM_REPLACE_PLACEHOLDER 0x00004000")]
    public const int MEM_REPLACE_PLACEHOLDER = 0x00004000;

    [NativeTypeName("#define MEM_RESERVE_PLACEHOLDER 0x00040000")]
    public const int MEM_RESERVE_PLACEHOLDER = 0x00040000;

    [NativeTypeName("#define MEM_RESET 0x00080000")]
    public const int MEM_RESET = 0x00080000;

    [NativeTypeName("#define MEM_TOP_DOWN 0x00100000")]
    public const int MEM_TOP_DOWN = 0x00100000;

    [NativeTypeName("#define MEM_WRITE_WATCH 0x00200000")]
    public const int MEM_WRITE_WATCH = 0x00200000;

    [NativeTypeName("#define MEM_PHYSICAL 0x00400000")]
    public const int MEM_PHYSICAL = 0x00400000;

    [NativeTypeName("#define MEM_ROTATE 0x00800000")]
    public const int MEM_ROTATE = 0x00800000;

    [NativeTypeName("#define MEM_DIFFERENT_IMAGE_BASE_OK 0x00800000")]
    public const int MEM_DIFFERENT_IMAGE_BASE_OK = 0x00800000;

    [NativeTypeName("#define MEM_RESET_UNDO 0x01000000")]
    public const int MEM_RESET_UNDO = 0x01000000;

    [NativeTypeName("#define MEM_LARGE_PAGES 0x20000000")]
    public const int MEM_LARGE_PAGES = 0x20000000;

    [NativeTypeName("#define MEM_4MB_PAGES 0x80000000")]
    public const uint MEM_4MB_PAGES = 0x80000000;

    [NativeTypeName("#define MEM_64K_PAGES (MEM_LARGE_PAGES | MEM_PHYSICAL)")]
    public const int MEM_64K_PAGES = (0x20000000 | 0x00400000);

    [NativeTypeName("#define MEM_UNMAP_WITH_TRANSIENT_BOOST 0x00000001")]
    public const int MEM_UNMAP_WITH_TRANSIENT_BOOST = 0x00000001;

    [NativeTypeName("#define MEM_COALESCE_PLACEHOLDERS 0x00000001")]
    public const int MEM_COALESCE_PLACEHOLDERS = 0x00000001;

    [NativeTypeName("#define MEM_PRESERVE_PLACEHOLDER 0x00000002")]
    public const int MEM_PRESERVE_PLACEHOLDER = 0x00000002;

    [NativeTypeName("#define MEM_DECOMMIT 0x00004000")]
    public const int MEM_DECOMMIT = 0x00004000;

    [NativeTypeName("#define MEM_RELEASE 0x00008000")]
    public const int MEM_RELEASE = 0x00008000;

    [NativeTypeName("#define MEM_FREE 0x00010000")]
    public const int MEM_FREE = 0x00010000;

    [NativeTypeName("#define MEM_EXTENDED_PARAMETER_GRAPHICS 0x00000001")]
    public const int MEM_EXTENDED_PARAMETER_GRAPHICS = 0x00000001;

    [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NONPAGED 0x00000002")]
    public const int MEM_EXTENDED_PARAMETER_NONPAGED = 0x00000002;

    [NativeTypeName("#define MEM_EXTENDED_PARAMETER_ZERO_PAGES_OPTIONAL 0x00000004")]
    public const int MEM_EXTENDED_PARAMETER_ZERO_PAGES_OPTIONAL = 0x00000004;

    [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NONPAGED_LARGE 0x00000008")]
    public const int MEM_EXTENDED_PARAMETER_NONPAGED_LARGE = 0x00000008;

    [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NONPAGED_HUGE 0x00000010")]
    public const int MEM_EXTENDED_PARAMETER_NONPAGED_HUGE = 0x00000010;

    [NativeTypeName("#define MEM_EXTENDED_PARAMETER_SOFT_FAULT_PAGES 0x00000020")]
    public const int MEM_EXTENDED_PARAMETER_SOFT_FAULT_PAGES = 0x00000020;

    [NativeTypeName("#define MEM_EXTENDED_PARAMETER_EC_CODE 0x00000040")]
    public const int MEM_EXTENDED_PARAMETER_EC_CODE = 0x00000040;

    [NativeTypeName("#define MEM_EXTENDED_PARAMETER_IMAGE_NO_HPAT 0x00000080")]
    public const int MEM_EXTENDED_PARAMETER_IMAGE_NO_HPAT = 0x00000080;

    [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NUMA_NODE_MANDATORY MINLONG64")]
    public const long MEM_EXTENDED_PARAMETER_NUMA_NODE_MANDATORY = unchecked((long)(~((long)(((ulong)(~((ulong)(0)))) >> 1))));

    [NativeTypeName("#define MEM_EXTENDED_PARAMETER_TYPE_BITS 8")]
    public const int MEM_EXTENDED_PARAMETER_TYPE_BITS = 8;

    [NativeTypeName("#define MEM_DEDICATED_ATTRIBUTE_NOT_SPECIFIED ((DWORD64) -1)")]
    public const ulong MEM_DEDICATED_ATTRIBUTE_NOT_SPECIFIED = unchecked((ulong)(-1));

    [NativeTypeName("#define MEM_PRIVATE 0x00020000")]
    public const int MEM_PRIVATE = 0x00020000;

    [NativeTypeName("#define MEM_MAPPED 0x00040000")]
    public const int MEM_MAPPED = 0x00040000;

    [NativeTypeName("#define MEM_IMAGE 0x01000000")]
    public const int MEM_IMAGE = 0x01000000;
}
