// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class BCM
{
    [NativeTypeName("#define BCM_FIRST 0x1600")]
    public const int BCM_FIRST = 0x1600;
    [NativeTypeName("#define BCM_GETIDEALSIZE (BCM_FIRST + 0x0001)")]
    public const int BCM_GETIDEALSIZE = (0x1600 + 0x0001);
    [NativeTypeName("#define BCM_SETIMAGELIST (BCM_FIRST + 0x0002)")]
    public const int BCM_SETIMAGELIST = (0x1600 + 0x0002);
    [NativeTypeName("#define BCM_GETIMAGELIST (BCM_FIRST + 0x0003)")]
    public const int BCM_GETIMAGELIST = (0x1600 + 0x0003);
    [NativeTypeName("#define BCM_SETTEXTMARGIN (BCM_FIRST + 0x0004)")]
    public const int BCM_SETTEXTMARGIN = (0x1600 + 0x0004);
    [NativeTypeName("#define BCM_GETTEXTMARGIN (BCM_FIRST + 0x0005)")]
    public const int BCM_GETTEXTMARGIN = (0x1600 + 0x0005);
    [NativeTypeName("#define BCM_SETDROPDOWNSTATE (BCM_FIRST + 0x0006)")]
    public const int BCM_SETDROPDOWNSTATE = (0x1600 + 0x0006);
    [NativeTypeName("#define BCM_SETSPLITINFO (BCM_FIRST + 0x0007)")]
    public const int BCM_SETSPLITINFO = (0x1600 + 0x0007);
    [NativeTypeName("#define BCM_GETSPLITINFO (BCM_FIRST + 0x0008)")]
    public const int BCM_GETSPLITINFO = (0x1600 + 0x0008);
    [NativeTypeName("#define BCM_SETNOTE (BCM_FIRST + 0x0009)")]
    public const int BCM_SETNOTE = (0x1600 + 0x0009);
    [NativeTypeName("#define BCM_GETNOTE (BCM_FIRST + 0x000A)")]
    public const int BCM_GETNOTE = (0x1600 + 0x000A);
    [NativeTypeName("#define BCM_GETNOTELENGTH (BCM_FIRST + 0x000B)")]
    public const int BCM_GETNOTELENGTH = (0x1600 + 0x000B);
    [NativeTypeName("#define BCM_SETSHIELD (BCM_FIRST + 0x000C)")]
    public const int BCM_SETSHIELD = (0x1600 + 0x000C);
}