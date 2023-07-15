// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class ACM
{
    [NativeTypeName("#define ACM_OPENA (WM_USER+100)")]
    public const int ACM_OPENA = (0x0400 + 100);
    [NativeTypeName("#define ACM_OPENW (WM_USER+103)")]
    public const int ACM_OPENW = (0x0400 + 103);
    [NativeTypeName("#define ACM_OPEN ACM_OPENW")]
    public const int ACM_OPEN = (0x0400 + 103);
    [NativeTypeName("#define ACM_PLAY (WM_USER+101)")]
    public const int ACM_PLAY = (0x0400 + 101);
    [NativeTypeName("#define ACM_STOP (WM_USER+102)")]
    public const int ACM_STOP = (0x0400 + 102);
    [NativeTypeName("#define ACM_ISPLAYING (WM_USER+104)")]
    public const int ACM_ISPLAYING = (0x0400 + 104);
}