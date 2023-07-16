// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class WM
{
    [NativeTypeName("#define WM_TABLET_DEFBASE 0x02C0")]
    public const int WM_TABLET_DEFBASE = 0x02C0;
    [NativeTypeName("#define WM_TABLET_MAXOFFSET 0x20")]
    public const int WM_TABLET_MAXOFFSET = 0x20;
    [NativeTypeName("#define WM_TABLET_ADDED (WM_TABLET_DEFBASE + 8)")]
    public const int WM_TABLET_ADDED = (0x02C0 + 8);
    [NativeTypeName("#define WM_TABLET_DELETED (WM_TABLET_DEFBASE + 9)")]
    public const int WM_TABLET_DELETED = (0x02C0 + 9);
    [NativeTypeName("#define WM_TABLET_FLICK (WM_TABLET_DEFBASE + 11)")]
    public const int WM_TABLET_FLICK = (0x02C0 + 11);
    [NativeTypeName("#define WM_TABLET_QUERYSYSTEMGESTURESTATUS (WM_TABLET_DEFBASE + 12)")]
    public const int WM_TABLET_QUERYSYSTEMGESTURESTATUS = (0x02C0 + 12);
}