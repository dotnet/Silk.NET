// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DI
{
    [NativeTypeName("#define DI_MASK 0x0001")]
    public const int DI_MASK = 0x0001;

    [NativeTypeName("#define DI_IMAGE 0x0002")]
    public const int DI_IMAGE = 0x0002;

    [NativeTypeName("#define DI_NORMAL 0x0003")]
    public const int DI_NORMAL = 0x0003;

    [NativeTypeName("#define DI_COMPAT 0x0004")]
    public const int DI_COMPAT = 0x0004;

    [NativeTypeName("#define DI_DEFAULTSIZE 0x0008")]
    public const int DI_DEFAULTSIZE = 0x0008;

    [NativeTypeName("#define DI_NOMIRROR 0x0010")]
    public const int DI_NOMIRROR = 0x0010;
}
