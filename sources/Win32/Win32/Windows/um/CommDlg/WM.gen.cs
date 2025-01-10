// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WM
{
    [NativeTypeName("#define WM_CHOOSEFONT_GETLOGFONT (WM_USER + 1)")]
    public const int WM_CHOOSEFONT_GETLOGFONT = (0x0400 + 1);

    [NativeTypeName("#define WM_CHOOSEFONT_SETLOGFONT (WM_USER + 101)")]
    public const int WM_CHOOSEFONT_SETLOGFONT = (0x0400 + 101);

    [NativeTypeName("#define WM_CHOOSEFONT_SETFLAGS (WM_USER + 102)")]
    public const int WM_CHOOSEFONT_SETFLAGS = (0x0400 + 102);

    [NativeTypeName("#define WM_PSD_PAGESETUPDLG (WM_USER  )")]
    public const int WM_PSD_PAGESETUPDLG = (0x0400);

    [NativeTypeName("#define WM_PSD_FULLPAGERECT (WM_USER+1)")]
    public const int WM_PSD_FULLPAGERECT = (0x0400 + 1);

    [NativeTypeName("#define WM_PSD_MINMARGINRECT (WM_USER+2)")]
    public const int WM_PSD_MINMARGINRECT = (0x0400 + 2);

    [NativeTypeName("#define WM_PSD_MARGINRECT (WM_USER+3)")]
    public const int WM_PSD_MARGINRECT = (0x0400 + 3);

    [NativeTypeName("#define WM_PSD_GREEKTEXTRECT (WM_USER+4)")]
    public const int WM_PSD_GREEKTEXTRECT = (0x0400 + 4);

    [NativeTypeName("#define WM_PSD_ENVSTAMPRECT (WM_USER+5)")]
    public const int WM_PSD_ENVSTAMPRECT = (0x0400 + 5);

    [NativeTypeName("#define WM_PSD_YAFULLPAGERECT (WM_USER+6)")]
    public const int WM_PSD_YAFULLPAGERECT = (0x0400 + 6);
}
