// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class PSD
{
    [NativeTypeName("#define PSD_DEFAULTMINMARGINS 0x00000000")]
    public const int PSD_DEFAULTMINMARGINS = 0x00000000;
    [NativeTypeName("#define PSD_INWININIINTLMEASURE 0x00000000")]
    public const int PSD_INWININIINTLMEASURE = 0x00000000;
    [NativeTypeName("#define PSD_MINMARGINS 0x00000001")]
    public const int PSD_MINMARGINS = 0x00000001;
    [NativeTypeName("#define PSD_MARGINS 0x00000002")]
    public const int PSD_MARGINS = 0x00000002;
    [NativeTypeName("#define PSD_INTHOUSANDTHSOFINCHES 0x00000004")]
    public const int PSD_INTHOUSANDTHSOFINCHES = 0x00000004;
    [NativeTypeName("#define PSD_INHUNDREDTHSOFMILLIMETERS 0x00000008")]
    public const int PSD_INHUNDREDTHSOFMILLIMETERS = 0x00000008;
    [NativeTypeName("#define PSD_DISABLEMARGINS 0x00000010")]
    public const int PSD_DISABLEMARGINS = 0x00000010;
    [NativeTypeName("#define PSD_DISABLEPRINTER 0x00000020")]
    public const int PSD_DISABLEPRINTER = 0x00000020;
    [NativeTypeName("#define PSD_NOWARNING 0x00000080")]
    public const int PSD_NOWARNING = 0x00000080;
    [NativeTypeName("#define PSD_DISABLEORIENTATION 0x00000100")]
    public const int PSD_DISABLEORIENTATION = 0x00000100;
    [NativeTypeName("#define PSD_RETURNDEFAULT 0x00000400")]
    public const int PSD_RETURNDEFAULT = 0x00000400;
    [NativeTypeName("#define PSD_DISABLEPAPER 0x00000200")]
    public const int PSD_DISABLEPAPER = 0x00000200;
    [NativeTypeName("#define PSD_SHOWHELP 0x00000800")]
    public const int PSD_SHOWHELP = 0x00000800;
    [NativeTypeName("#define PSD_ENABLEPAGESETUPHOOK 0x00002000")]
    public const int PSD_ENABLEPAGESETUPHOOK = 0x00002000;
    [NativeTypeName("#define PSD_ENABLEPAGESETUPTEMPLATE 0x00008000")]
    public const int PSD_ENABLEPAGESETUPTEMPLATE = 0x00008000;
    [NativeTypeName("#define PSD_ENABLEPAGESETUPTEMPLATEHANDLE 0x00020000")]
    public const int PSD_ENABLEPAGESETUPTEMPLATEHANDLE = 0x00020000;
    [NativeTypeName("#define PSD_ENABLEPAGEPAINTHOOK 0x00040000")]
    public const int PSD_ENABLEPAGEPAINTHOOK = 0x00040000;
    [NativeTypeName("#define PSD_DISABLEPAGEPAINTING 0x00080000")]
    public const int PSD_DISABLEPAGEPAINTING = 0x00080000;
    [NativeTypeName("#define PSD_NONETWORKBUTTON 0x00200000")]
    public const int PSD_NONETWORKBUTTON = 0x00200000;
}