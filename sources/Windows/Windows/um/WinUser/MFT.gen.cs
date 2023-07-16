// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MFT
{
    [NativeTypeName("#define MFT_STRING MF_STRING")]
    public const int MFT_STRING = 0x00000000;
    [NativeTypeName("#define MFT_BITMAP MF_BITMAP")]
    public const int MFT_BITMAP = 0x00000004;
    [NativeTypeName("#define MFT_MENUBARBREAK MF_MENUBARBREAK")]
    public const int MFT_MENUBARBREAK = 0x00000020;
    [NativeTypeName("#define MFT_MENUBREAK MF_MENUBREAK")]
    public const int MFT_MENUBREAK = 0x00000040;
    [NativeTypeName("#define MFT_OWNERDRAW MF_OWNERDRAW")]
    public const int MFT_OWNERDRAW = 0x00000100;
    [NativeTypeName("#define MFT_RADIOCHECK 0x00000200L")]
    public const int MFT_RADIOCHECK = 0x00000200;
    [NativeTypeName("#define MFT_SEPARATOR MF_SEPARATOR")]
    public const int MFT_SEPARATOR = 0x00000800;
    [NativeTypeName("#define MFT_RIGHTORDER 0x00002000L")]
    public const int MFT_RIGHTORDER = 0x00002000;
    [NativeTypeName("#define MFT_RIGHTJUSTIFY MF_RIGHTJUSTIFY")]
    public const int MFT_RIGHTJUSTIFY = 0x00004000;
}