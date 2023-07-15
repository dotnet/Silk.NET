// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SWP
{
    [NativeTypeName("#define SWP_NOSIZE 0x0001")]
    public const int SWP_NOSIZE = 0x0001;
    [NativeTypeName("#define SWP_NOMOVE 0x0002")]
    public const int SWP_NOMOVE = 0x0002;
    [NativeTypeName("#define SWP_NOZORDER 0x0004")]
    public const int SWP_NOZORDER = 0x0004;
    [NativeTypeName("#define SWP_NOREDRAW 0x0008")]
    public const int SWP_NOREDRAW = 0x0008;
    [NativeTypeName("#define SWP_NOACTIVATE 0x0010")]
    public const int SWP_NOACTIVATE = 0x0010;
    [NativeTypeName("#define SWP_FRAMECHANGED 0x0020")]
    public const int SWP_FRAMECHANGED = 0x0020;
    [NativeTypeName("#define SWP_SHOWWINDOW 0x0040")]
    public const int SWP_SHOWWINDOW = 0x0040;
    [NativeTypeName("#define SWP_HIDEWINDOW 0x0080")]
    public const int SWP_HIDEWINDOW = 0x0080;
    [NativeTypeName("#define SWP_NOCOPYBITS 0x0100")]
    public const int SWP_NOCOPYBITS = 0x0100;
    [NativeTypeName("#define SWP_NOOWNERZORDER 0x0200")]
    public const int SWP_NOOWNERZORDER = 0x0200;
    [NativeTypeName("#define SWP_NOSENDCHANGING 0x0400")]
    public const int SWP_NOSENDCHANGING = 0x0400;
    [NativeTypeName("#define SWP_DRAWFRAME SWP_FRAMECHANGED")]
    public const int SWP_DRAWFRAME = 0x0020;
    [NativeTypeName("#define SWP_NOREPOSITION SWP_NOOWNERZORDER")]
    public const int SWP_NOREPOSITION = 0x0200;
    [NativeTypeName("#define SWP_DEFERERASE 0x2000")]
    public const int SWP_DEFERERASE = 0x2000;
    [NativeTypeName("#define SWP_ASYNCWINDOWPOS 0x4000")]
    public const int SWP_ASYNCWINDOWPOS = 0x4000;
}