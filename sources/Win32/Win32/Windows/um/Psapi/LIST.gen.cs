// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class LIST
{
    [NativeTypeName("#define LIST_MODULES_DEFAULT 0x0")]
    public const int LIST_MODULES_DEFAULT = 0x0;

    [NativeTypeName("#define LIST_MODULES_32BIT 0x01")]
    public const int LIST_MODULES_32BIT = 0x01;

    [NativeTypeName("#define LIST_MODULES_64BIT 0x02")]
    public const int LIST_MODULES_64BIT = 0x02;

    [NativeTypeName("#define LIST_MODULES_ALL (LIST_MODULES_32BIT | LIST_MODULES_64BIT)")]
    public const int LIST_MODULES_ALL = (0x01 | 0x02);
}
