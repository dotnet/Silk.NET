// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MK
{
    [NativeTypeName("#define MK_LBUTTON 0x0001")]
    public const int MK_LBUTTON = 0x0001;
    [NativeTypeName("#define MK_RBUTTON 0x0002")]
    public const int MK_RBUTTON = 0x0002;
    [NativeTypeName("#define MK_SHIFT 0x0004")]
    public const int MK_SHIFT = 0x0004;
    [NativeTypeName("#define MK_CONTROL 0x0008")]
    public const int MK_CONTROL = 0x0008;
    [NativeTypeName("#define MK_MBUTTON 0x0010")]
    public const int MK_MBUTTON = 0x0010;
    [NativeTypeName("#define MK_XBUTTON1 0x0020")]
    public const int MK_XBUTTON1 = 0x0020;
    [NativeTypeName("#define MK_XBUTTON2 0x0040")]
    public const int MK_XBUTTON2 = 0x0040;
}