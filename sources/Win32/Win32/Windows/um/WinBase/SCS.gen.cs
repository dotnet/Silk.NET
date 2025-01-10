// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SCS
{
    [NativeTypeName("#define SCS_32BIT_BINARY 0")]
    public const int SCS_32BIT_BINARY = 0;

    [NativeTypeName("#define SCS_DOS_BINARY 1")]
    public const int SCS_DOS_BINARY = 1;

    [NativeTypeName("#define SCS_WOW_BINARY 2")]
    public const int SCS_WOW_BINARY = 2;

    [NativeTypeName("#define SCS_PIF_BINARY 3")]
    public const int SCS_PIF_BINARY = 3;

    [NativeTypeName("#define SCS_POSIX_BINARY 4")]
    public const int SCS_POSIX_BINARY = 4;

    [NativeTypeName("#define SCS_OS216_BINARY 5")]
    public const int SCS_OS216_BINARY = 5;

    [NativeTypeName("#define SCS_64BIT_BINARY 6")]
    public const int SCS_64BIT_BINARY = 6;
}
