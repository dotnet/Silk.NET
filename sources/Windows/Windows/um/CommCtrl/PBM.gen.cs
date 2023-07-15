// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PBM
{
    [NativeTypeName("#define PBM_SETRANGE (WM_USER+1)")]
    public const int PBM_SETRANGE = (0x0400 + 1);
    [NativeTypeName("#define PBM_SETPOS (WM_USER+2)")]
    public const int PBM_SETPOS = (0x0400 + 2);
    [NativeTypeName("#define PBM_DELTAPOS (WM_USER+3)")]
    public const int PBM_DELTAPOS = (0x0400 + 3);
    [NativeTypeName("#define PBM_SETSTEP (WM_USER+4)")]
    public const int PBM_SETSTEP = (0x0400 + 4);
    [NativeTypeName("#define PBM_STEPIT (WM_USER+5)")]
    public const int PBM_STEPIT = (0x0400 + 5);
    [NativeTypeName("#define PBM_SETRANGE32 (WM_USER+6)")]
    public const int PBM_SETRANGE32 = (0x0400 + 6);
    [NativeTypeName("#define PBM_GETRANGE (WM_USER+7)")]
    public const int PBM_GETRANGE = (0x0400 + 7);
    [NativeTypeName("#define PBM_GETPOS (WM_USER+8)")]
    public const int PBM_GETPOS = (0x0400 + 8);
    [NativeTypeName("#define PBM_SETBARCOLOR (WM_USER+9)")]
    public const int PBM_SETBARCOLOR = (0x0400 + 9);
    [NativeTypeName("#define PBM_SETBKCOLOR CCM_SETBKCOLOR")]
    public const int PBM_SETBKCOLOR = (0x2000 + 1);
    [NativeTypeName("#define PBM_SETMARQUEE (WM_USER+10)")]
    public const int PBM_SETMARQUEE = (0x0400 + 10);
    [NativeTypeName("#define PBM_GETSTEP (WM_USER+13)")]
    public const int PBM_GETSTEP = (0x0400 + 13);
    [NativeTypeName("#define PBM_GETBKCOLOR (WM_USER+14)")]
    public const int PBM_GETBKCOLOR = (0x0400 + 14);
    [NativeTypeName("#define PBM_GETBARCOLOR (WM_USER+15)")]
    public const int PBM_GETBARCOLOR = (0x0400 + 15);
    [NativeTypeName("#define PBM_SETSTATE (WM_USER+16)")]
    public const int PBM_SETSTATE = (0x0400 + 16);
    [NativeTypeName("#define PBM_GETSTATE (WM_USER+17)")]
    public const int PBM_GETSTATE = (0x0400 + 17);
}