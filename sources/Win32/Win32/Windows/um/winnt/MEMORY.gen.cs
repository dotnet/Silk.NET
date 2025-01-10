// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MEMORY
{
    [NativeTypeName("#define MEMORY_PRIORITY_LOWEST 0")]
    public const int MEMORY_PRIORITY_LOWEST = 0;

    [NativeTypeName("#define MEMORY_PRIORITY_VERY_LOW 1")]
    public const int MEMORY_PRIORITY_VERY_LOW = 1;

    [NativeTypeName("#define MEMORY_PRIORITY_LOW 2")]
    public const int MEMORY_PRIORITY_LOW = 2;

    [NativeTypeName("#define MEMORY_PRIORITY_MEDIUM 3")]
    public const int MEMORY_PRIORITY_MEDIUM = 3;

    [NativeTypeName("#define MEMORY_PRIORITY_BELOW_NORMAL 4")]
    public const int MEMORY_PRIORITY_BELOW_NORMAL = 4;

    [NativeTypeName("#define MEMORY_PRIORITY_NORMAL 5")]
    public const int MEMORY_PRIORITY_NORMAL = 5;

    [NativeTypeName("#define MEMORY_PARTITION_QUERY_ACCESS 0x0001")]
    public const int MEMORY_PARTITION_QUERY_ACCESS = 0x0001;

    [NativeTypeName("#define MEMORY_PARTITION_MODIFY_ACCESS 0x0002")]
    public const int MEMORY_PARTITION_MODIFY_ACCESS = 0x0002;

    [NativeTypeName(
        "#define MEMORY_PARTITION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED |      \\\r\n                                     SYNCHRONIZE |                   \\\r\n                                     MEMORY_PARTITION_QUERY_ACCESS | \\\r\n                                     MEMORY_PARTITION_MODIFY_ACCESS)"
    )]
    public const int MEMORY_PARTITION_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001 | 0x0002);
}
