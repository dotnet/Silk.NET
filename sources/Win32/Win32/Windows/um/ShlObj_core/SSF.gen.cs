// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SSF
{
    [NativeTypeName("#define SSF_SHOWALLOBJECTS 0x00000001")]
    public const int SSF_SHOWALLOBJECTS = 0x00000001;

    [NativeTypeName("#define SSF_SHOWEXTENSIONS 0x00000002")]
    public const int SSF_SHOWEXTENSIONS = 0x00000002;

    [NativeTypeName("#define SSF_HIDDENFILEEXTS 0x00000004")]
    public const int SSF_HIDDENFILEEXTS = 0x00000004;

    [NativeTypeName("#define SSF_SERVERADMINUI 0x00000004")]
    public const int SSF_SERVERADMINUI = 0x00000004;

    [NativeTypeName("#define SSF_SHOWCOMPCOLOR 0x00000008")]
    public const int SSF_SHOWCOMPCOLOR = 0x00000008;

    [NativeTypeName("#define SSF_SORTCOLUMNS 0x00000010")]
    public const int SSF_SORTCOLUMNS = 0x00000010;

    [NativeTypeName("#define SSF_SHOWSYSFILES 0x00000020")]
    public const int SSF_SHOWSYSFILES = 0x00000020;

    [NativeTypeName("#define SSF_DOUBLECLICKINWEBVIEW 0x00000080")]
    public const int SSF_DOUBLECLICKINWEBVIEW = 0x00000080;

    [NativeTypeName("#define SSF_SHOWATTRIBCOL 0x00000100")]
    public const int SSF_SHOWATTRIBCOL = 0x00000100;

    [NativeTypeName("#define SSF_DESKTOPHTML 0x00000200")]
    public const int SSF_DESKTOPHTML = 0x00000200;

    [NativeTypeName("#define SSF_WIN95CLASSIC 0x00000400")]
    public const int SSF_WIN95CLASSIC = 0x00000400;

    [NativeTypeName("#define SSF_DONTPRETTYPATH 0x00000800")]
    public const int SSF_DONTPRETTYPATH = 0x00000800;

    [NativeTypeName("#define SSF_SHOWINFOTIP 0x00002000")]
    public const int SSF_SHOWINFOTIP = 0x00002000;

    [NativeTypeName("#define SSF_MAPNETDRVBUTTON 0x00001000")]
    public const int SSF_MAPNETDRVBUTTON = 0x00001000;

    [NativeTypeName("#define SSF_NOCONFIRMRECYCLE 0x00008000")]
    public const int SSF_NOCONFIRMRECYCLE = 0x00008000;

    [NativeTypeName("#define SSF_HIDEICONS 0x00004000")]
    public const int SSF_HIDEICONS = 0x00004000;

    [NativeTypeName("#define SSF_FILTER 0x00010000")]
    public const int SSF_FILTER = 0x00010000;

    [NativeTypeName("#define SSF_WEBVIEW 0x00020000")]
    public const int SSF_WEBVIEW = 0x00020000;

    [NativeTypeName("#define SSF_SHOWSUPERHIDDEN 0x00040000")]
    public const int SSF_SHOWSUPERHIDDEN = 0x00040000;

    [NativeTypeName("#define SSF_SEPPROCESS 0x00080000")]
    public const int SSF_SEPPROCESS = 0x00080000;

    [NativeTypeName("#define SSF_NONETCRAWLING 0x00100000")]
    public const int SSF_NONETCRAWLING = 0x00100000;

    [NativeTypeName("#define SSF_STARTPANELON 0x00200000")]
    public const int SSF_STARTPANELON = 0x00200000;

    [NativeTypeName("#define SSF_SHOWSTARTPAGE 0x00400000")]
    public const int SSF_SHOWSTARTPAGE = 0x00400000;

    [NativeTypeName("#define SSF_AUTOCHECKSELECT 0x00800000")]
    public const int SSF_AUTOCHECKSELECT = 0x00800000;

    [NativeTypeName("#define SSF_ICONSONLY 0x01000000")]
    public const int SSF_ICONSONLY = 0x01000000;

    [NativeTypeName("#define SSF_SHOWTYPEOVERLAY 0x02000000")]
    public const int SSF_SHOWTYPEOVERLAY = 0x02000000;

    [NativeTypeName("#define SSF_SHOWSTATUSBAR 0x04000000")]
    public const int SSF_SHOWSTATUSBAR = 0x04000000;
}
