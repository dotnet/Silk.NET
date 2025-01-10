// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class BAUD
{
    [NativeTypeName("#define BAUD_075 ((DWORD)0x00000001)")]
    public const uint BAUD_075 = ((uint)(0x00000001));

    [NativeTypeName("#define BAUD_110 ((DWORD)0x00000002)")]
    public const uint BAUD_110 = ((uint)(0x00000002));

    [NativeTypeName("#define BAUD_134_5 ((DWORD)0x00000004)")]
    public const uint BAUD_134_5 = ((uint)(0x00000004));

    [NativeTypeName("#define BAUD_150 ((DWORD)0x00000008)")]
    public const uint BAUD_150 = ((uint)(0x00000008));

    [NativeTypeName("#define BAUD_300 ((DWORD)0x00000010)")]
    public const uint BAUD_300 = ((uint)(0x00000010));

    [NativeTypeName("#define BAUD_600 ((DWORD)0x00000020)")]
    public const uint BAUD_600 = ((uint)(0x00000020));

    [NativeTypeName("#define BAUD_1200 ((DWORD)0x00000040)")]
    public const uint BAUD_1200 = ((uint)(0x00000040));

    [NativeTypeName("#define BAUD_1800 ((DWORD)0x00000080)")]
    public const uint BAUD_1800 = ((uint)(0x00000080));

    [NativeTypeName("#define BAUD_2400 ((DWORD)0x00000100)")]
    public const uint BAUD_2400 = ((uint)(0x00000100));

    [NativeTypeName("#define BAUD_4800 ((DWORD)0x00000200)")]
    public const uint BAUD_4800 = ((uint)(0x00000200));

    [NativeTypeName("#define BAUD_7200 ((DWORD)0x00000400)")]
    public const uint BAUD_7200 = ((uint)(0x00000400));

    [NativeTypeName("#define BAUD_9600 ((DWORD)0x00000800)")]
    public const uint BAUD_9600 = ((uint)(0x00000800));

    [NativeTypeName("#define BAUD_14400 ((DWORD)0x00001000)")]
    public const uint BAUD_14400 = ((uint)(0x00001000));

    [NativeTypeName("#define BAUD_19200 ((DWORD)0x00002000)")]
    public const uint BAUD_19200 = ((uint)(0x00002000));

    [NativeTypeName("#define BAUD_38400 ((DWORD)0x00004000)")]
    public const uint BAUD_38400 = ((uint)(0x00004000));

    [NativeTypeName("#define BAUD_56K ((DWORD)0x00008000)")]
    public const uint BAUD_56K = ((uint)(0x00008000));

    [NativeTypeName("#define BAUD_128K ((DWORD)0x00010000)")]
    public const uint BAUD_128K = ((uint)(0x00010000));

    [NativeTypeName("#define BAUD_115200 ((DWORD)0x00020000)")]
    public const uint BAUD_115200 = ((uint)(0x00020000));

    [NativeTypeName("#define BAUD_57600 ((DWORD)0x00040000)")]
    public const uint BAUD_57600 = ((uint)(0x00040000));

    [NativeTypeName("#define BAUD_USER ((DWORD)0x10000000)")]
    public const uint BAUD_USER = ((uint)(0x10000000));
}
