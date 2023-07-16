// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class TME
{
    [NativeTypeName("#define TME_HOVER 0x00000001")]
    public const int TME_HOVER = 0x00000001;
    [NativeTypeName("#define TME_LEAVE 0x00000002")]
    public const int TME_LEAVE = 0x00000002;
    [NativeTypeName("#define TME_NONCLIENT 0x00000010")]
    public const int TME_NONCLIENT = 0x00000010;
    [NativeTypeName("#define TME_QUERY 0x40000000")]
    public const int TME_QUERY = 0x40000000;
    [NativeTypeName("#define TME_CANCEL 0x80000000")]
    public const uint TME_CANCEL = 0x80000000;
}